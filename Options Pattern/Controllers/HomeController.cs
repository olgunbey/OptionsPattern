using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace Options_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //private readonly IConfiguration configuration;
        private readonly IOptions<MailInfo> options;
        public HomeController(/*IConfiguration _configuration*/ IOptions<MailInfo> _options)
        {
            //configuration = _configuration;
            options = _options;
        }
        [HttpGet]
        public IActionResult Index()
        {
            
          //MailInfo mailInfo= configuration.GetSection("MailInfo").Get<MailInfo>();
            
            return Ok(/*mailInfo*/options.Value);
        }
    }
}
