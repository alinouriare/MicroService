using ApplicationServicesApp.Writers.Commands;
using EndPoints.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPointsApi.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/[Controller]")]
    public class Writer : BaseController
    {
        [HttpPost("/Save")]
        public async Task<IActionResult> Post([FromBody] CreateWiterCommand createWtirer)
        {
            return await Create<CreateWiterCommand, long>(createWtirer);
        }
    }
}
