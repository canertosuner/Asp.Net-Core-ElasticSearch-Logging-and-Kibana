using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Product.Api.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    // GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new List<string> { "Mobile Phone", "Laptop", "Books", "Shoes" };
    }
}
}
