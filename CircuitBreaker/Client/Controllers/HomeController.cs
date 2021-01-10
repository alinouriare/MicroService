using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using Newtonsoft.Json;
using Polly;
using Polly.CircuitBreaker;
using Polly.Fallback;
using Polly.Retry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;

namespace Client.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private string _baseurl = "https://localhost:44372/Home/Ten";
        private readonly AsyncRetryPolicy<HttpResponseMessage> _retryPolicy;
        private readonly AsyncFallbackPolicy<HttpResponseMessage> _fallbackPolicy;
        private readonly Polly.CircuitBreaker.AsyncCircuitBreakerPolicy<HttpResponseMessage> _circuitBreaker =
            Policy.HandleResult<HttpResponseMessage>(r => !r.IsSuccessStatusCode).Or<HttpRequestException>()
            .CircuitBreakerAsync(2, TimeSpan.FromSeconds(10), (d, c) =>
            { string a = "Break"; },
                ()=> { string a = "Rest"; }, 
                () => { string a = "Half"; });

        public HomeController()
        {
            _retryPolicy = Policy.HandleResult<HttpResponseMessage>(result => !result.IsSuccessStatusCode)
                                .RetryAsync(5, (d, c) => { string a = "Retry"; });


            _fallbackPolicy = Policy.HandleResult<HttpResponseMessage>(result => !result.IsSuccessStatusCode)
                .Or<BrokenCircuitException>()
                .FallbackAsync(new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new ObjectContent(typeof(Message), new Message
                    {
                        Id = 100,
                        Text = "متن پیش فرض"
                    }, new JsonMediaTypeFormatter())
                });
        }
        public async Task<IActionResult> Index()
        {
            HttpClient client = new HttpClient();
            // var result =await _retryPolicy.ExecuteAsync(()=> client.GetAsync(_baseurl)) ;
            //  var result = await client.GetAsync(_baseurl);

            var result =await _fallbackPolicy.ExecuteAsync(()=>_retryPolicy.ExecuteAsync(() => _circuitBreaker.ExecuteAsync(() => client.GetAsync(_baseurl))));
            var str = await result.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<ClientMessage>(str);
            return Ok(obj);
        }

    }
}
