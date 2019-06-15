using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSilkRoadStore.Application.ProductsAdmin;
using TheSilkRoadStore.Database;

namespace TheSilkRoadStore.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _ctx;
        public AdminController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Do());

        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProducts(_ctx).Do());

        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProduct.Request request) => Ok((await new CreateProduct(_ctx).Do(request)));

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id) => Ok((await new DeleteProduct(_ctx).Do(id)));

        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProduct.Request request) => Ok((await new UpdateProduct(_ctx).Do(request)));

    }
}
