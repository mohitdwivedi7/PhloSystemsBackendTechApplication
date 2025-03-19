using Microsoft.AspNetCore.Mvc;
using PhloSystemsBackendTechApplication.Models;
using PhloSystemsBackendTechApplication.Services;

namespace PhloSystemsBackendTechApplication.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PhloSystemsBackendController : ControllerBase
{
    private readonly PhloSystemsBackendService productService;

    private readonly ILogger<PhloSystemsBackendController> logger;

    public PhloSystemsBackendController(ILogger<PhloSystemsBackendController> _logger, PhloSystemsBackendService _productService)
    {
        logger = _logger;
        productService = _productService;
    }

    [HttpGet("GetProductDetails")]
    public ActionResult<IEnumerable<PhloSystemsBackendProduct>> GetProductDetails([FromQuery] decimal? minprice, [FromQuery] decimal? maxprice, [FromQuery] string? size, [FromQuery] string? highlight)
    {
        try
        {
            var filteredProducts = productService.GetProductDetails(minprice, maxprice, size, highlight);

            // Return in the specified format
            var result = new { products = filteredProducts };
            return Ok(result);
        }
        catch (Exception ex)
        {
            throw ex.InnerException;
        }
    }
}