using HandsonModel.models.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HandsonModel.models.Pages
{
    public class GetallModelsModel : PageModel
    {
       static  List<product> products = new List<product>()
        {
            new product(){ Id =1,price =200,Name ="pen",stock =10},
             new product(){ Id =2,price =200,Name ="pencil",stock =10},
              new product(){ Id =3,price =200,Name ="box",stock =10},
        };
        public List<product> List
        {
            get { return products;}
        }
        public void OnGet()
        {

        }
        [BindProperty]
        public product product { get; set;}
        public IActionResult  Onpast()
        {
            products.Add(product);
            return RedirectToPage("GetAll");
        }
    }
}
