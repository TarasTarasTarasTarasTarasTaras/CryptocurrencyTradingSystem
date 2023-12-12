using Orders.DTOs;

namespace Orders.Services
{
    public interface IOrderService
    {
        void CreateOrder(OrderDTO orderDTO);
        IEnumerable<OrderDTO> GetAllOrdersByUserId(int userId);
    }
}