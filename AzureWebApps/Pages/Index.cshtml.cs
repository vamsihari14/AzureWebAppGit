using AzureWebApps.Models;
using AzureWebApps.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureWebApps.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products = productService.GetProducts();

        }
    }
}