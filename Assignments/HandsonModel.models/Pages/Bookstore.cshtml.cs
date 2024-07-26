using HandsonModel.models.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace HandsonModel.models.Pages
{
    public class Bookstore : PageModel
    {
        private static List<Book> books = new List<Book>();

        [BindProperty]
        public Book b { get; set; }

        public void OnGet()
        {
            // This method can be used to initialize or load data if needed
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                books.Add(b);
                return RedirectToPage("Bookstore");
            }
            return Page(); // Return the same page if the model state is invalid
        }

        public List<Book> List
        {
            get { return books; }
        }
    }
}