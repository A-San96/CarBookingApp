using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBookingApp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        public string Heading { get; set; }
        public void OnGet()
        {
            Heading = "List of Cars"; 
        }
    }
}
