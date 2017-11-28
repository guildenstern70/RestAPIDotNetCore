using Microsoft.AspNetCore.Mvc;


namespace RestAPI.Controllers.Web
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
