using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinOS_Rest_API.Models;

namespace MinOS_Rest_API.Controllers
{
    [Route("menu/")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public MenuController() { }

        [HttpGet("get-all-items")]
        public IActionResult GetAllItems()
        {
            List<Item> menu = new List<Item>();

            Item i1 = new Item();
            i1.Id = 1;
            i1.Name = "Baião de Dois";
            i1.Price = 6.5f;

            Item i2 = new Item();
            i2.Id = 2;
            i2.Name = "Carne de Sol";
            i2.Price = 10.25f;

            menu.Add(i1);
            menu.Add(i2);

            return Ok(menu);
        }
    }
}
