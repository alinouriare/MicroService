using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumerDtoes
{
    public static class APICaller
    {
        static public async Task<HttpResponseMessage> Call(string url, string id)
        {
            using (var client = new HttpClient { BaseAddress = new Uri(url) })
            {
                try
                {
                    var response = await client.GetAsync($"/api/person/?id={id}");
                    return response;
                }
                catch (System.Exception ex)
                {
                    throw new Exception("There was a problem connecting to Provider API.", ex);
                }
            }
        }
    }

}
