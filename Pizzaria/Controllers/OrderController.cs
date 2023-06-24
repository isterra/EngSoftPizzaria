using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services.Interface;
using System.Security.Claims;

namespace Pizzaria.Controllers
{
    [ApiController]
    [Route("order")]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync([FromBody] CreateOrder createOrder)
        {
            var order = await _orderService.CreateOrder(createOrder, Int32.Parse((User.Identity as ClaimsIdentity).Claims.First(c => c.Type == "id").Value));
            return Ok(order);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrdersOfUserAsync()
        {
            var orders = await _orderService.GetAllOrdersOfUserAsync(Int32.Parse((User.Identity as ClaimsIdentity).Claims.First(c => c.Type == "id").Value));
            return Ok(orders);
        }

        [HttpGet]
        [Route("details")]
        public async Task<IActionResult> GetAllOrdersWithDetailOfUserAsync()
        {
            var orders = await _orderService.GetAllOrdersWithDetailOfUserAsync(Int32.Parse((User.Identity as ClaimsIdentity).Claims.First(c => c.Type == "id").Value));
            return Ok(orders);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAllOrdersWithDetailOfUserAsync(int id)
        {
            var order = await _orderService.GetSpecificOrderUserAsync(Int32.Parse((User.Identity as ClaimsIdentity).Claims.First(c => c.Type == "id").Value), id);
            return Ok(order);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteOrderAsync(int id)
        {
            await _orderService.DeleteOrderByIdAsync(Int32.Parse((User.Identity as ClaimsIdentity).Claims.First(c => c.Type == "id").Value), id, (User.Identity as ClaimsIdentity).Claims.First(c => c.Type == ClaimTypes.Role).Value);
            return Ok();
        }

    }
}
