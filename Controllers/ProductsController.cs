using Microsoft.AspNetCore.Mvc;

namespace ServerApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 1200.50,
                    Stock = 25,
                    Category = new Category { Id = 101, Name = "Electronics" }
                },
                new Product
                {
                    Id = 2,
                    Name = "Headphones",
                    Price = 50.00,
                    Stock = 100,
                    Category = new Category { Id = 102, Name = "Audio" }
                }
            };
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int Stock { get; set; }
            public Category Category { get; set; } = default!;
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}

