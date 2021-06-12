using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RealEstateAPI.Services;
using Microsoft.Extensions.Logging;
using System;
using RealEstateAPI.Models;

namespace RealEstateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressContoller : ControllerBase
    {
        private IRealEstateAPIServices _realEstateAPIServices;
        private ILogger _logger;
        public AddressContoller(
            ILogger<AddressContoller> logger,
            IRealEstateAPIServices realEstateAPIServices )
        {
            _logger = logger;
            _realEstateAPIServices = realEstateAPIServices;
        }
        [HttpPost]
        public async Task<IActionResult> GetAddress([FromBody] string address)
        {
            try
            {
                GetAddressResponse ret = await _realEstateAPIServices.GetAddressAsync(address);

                return Ok(ret);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return BadRequest();
            }
        }
    }
}
