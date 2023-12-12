using Orders.DTOs;

namespace Orders.Repositories
{
    public interface IOrderRepository
    {
        void CreateOrder(OrderDTO model);
        IEnumerable<OrderDTO> GetAllOrdersByUserId(int userId);
    }
}