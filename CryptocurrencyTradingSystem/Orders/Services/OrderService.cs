using Orders.DTOs;
using Orders.Repositories;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<OrderDTO> GetAllOrdersByUserId(int userId)
        {
            return _orderRepository.GetAllOrdersByUserId(userId);
        }

        public void CreateOrder(OrderDTO orderDTO)
        {
            _orderRepository.CreateOrder(orderDTO);
        }
    }
}
