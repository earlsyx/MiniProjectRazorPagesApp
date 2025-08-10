using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiniProjectRazorPages.Pages
{
    public class AddressesModel : PageModel
    {
        [BindProperty]
        public AddressModel Address { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //STATE CHECK
            if (ModelState.IsValid == false)
            {
                return Page(); 
            }

            //checking vlaidation on server side

            return RedirectToPage("./Index"); 
        }
    }
}
