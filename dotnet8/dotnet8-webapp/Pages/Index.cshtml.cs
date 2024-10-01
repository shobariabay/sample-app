using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet8_webapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _config;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void OnGet()
        {
            var _env = _config["Environment"];
            var _applicationSetting = _config.GetSection("ApplicationSetting");

            ViewData["env"] = _env;
            ViewData["url"] = _applicationSetting["url"];

        }
    }
}
