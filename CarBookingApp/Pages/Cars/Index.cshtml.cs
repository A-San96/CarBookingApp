using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBookingApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        public string Heading { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            Heading = "List of Cars";
            Message = _configuration["Message"];
        }
    }
}
