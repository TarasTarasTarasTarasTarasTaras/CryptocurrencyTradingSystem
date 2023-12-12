using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orders.DTOs;
using Orders.Extensions;
using Orders.Models;
using Orders.Services;

namespace Orders.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public OrderController(IMapper mapper, IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        [HttpGet("all")]
        public IEnumerable<OrderDTO> GetAllOrders()
        {
            var orders = _orderService.GetAllOrdersByUserId(User.GetId());
            return orders;
        }

        [HttpPost("create")]
        public ActionResult CreateOrder([FromForm] OrderModel model)
        {
            var order = _mapper.Map<OrderDTO>(model);
            order.UserId = User.GetId();

            _orderService.CreateOrder(order);
            return Ok();
        }
    }
}
