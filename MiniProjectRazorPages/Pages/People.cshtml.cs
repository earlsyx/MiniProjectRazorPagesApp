using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DemoLibrary;
namespace MiniProjectRazorPages.Pages
{
    public class PeopleModel : PageModel
    {
        [BindProperty]//so we can post to it.
        public PersonModel Person { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //check if the model is valid, also redirect to same page.
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./Index"); //(.) dot means the site root /Index the page we redirect too
        }
    }
}
