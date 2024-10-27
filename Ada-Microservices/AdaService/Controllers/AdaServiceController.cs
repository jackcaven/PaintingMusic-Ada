using AdaService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AdaService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdaServiceController : ControllerBase
    {
        private readonly ILogger<AdaServiceController> _logger;

        public AdaServiceController(ILogger<AdaServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTracks")]
        IEnumerable<TrackBasicInfo> Get()
        {
            return [];
        }

        [HttpGet(Name = "GetImage")]
        byte[] GetImage()
        {
            throw new NotImplementedException();
        }
    }
}
