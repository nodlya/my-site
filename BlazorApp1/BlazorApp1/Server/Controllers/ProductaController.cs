using BlazorApp1.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Server.Controllers
{
    [ApiController]
    [Route("add")]
    public class ProductaController : ControllerBase
    {
        private static List<Product> products = new();

        // GET: ProductaController/Create
        [HttpPost]
        public void Post(ProductForm form)
        {
            Console.WriteLine(form.ProductName);
            products.Add(new Product(form));
            Console.WriteLine(products.Count > 0 ? products[0].Name : "no products in controller uga buga");
        }

        [HttpGet]
        public IEnumerable<Product> Get() => products;


        [HttpPut("/{id}")]
        public void Put([FromQuery] Guid id)
        {
            Product uaa = products.First(t => t.Id == id);
            uaa.IsBought = !uaa.IsBought;
            Console.WriteLine(uaa.Name + " unga bunga");
        }

        [HttpDelete("/{id}")]
        public void Delete([FromQuery] Guid id)
        {
            Product uaa = products.First(t => t.Id == id);
            products.Remove(uaa);
            Console.WriteLine(uaa.Id);
        }
    }
}
