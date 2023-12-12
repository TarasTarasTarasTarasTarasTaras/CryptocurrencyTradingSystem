using AutoMapper;
using CryptocurrencyTradingSystem.Core.EF.Entities;
using Orders.DTOs;

namespace Orders.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMapper _mapper;
        private readonly TradingSystemContext _dbContext;

        public OrderRepository(IMapper mapper, TradingSystemContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public IEnumerable<OrderDTO> GetAllOrdersByUserId(int userId)
        {
            var allOrders = _dbContext.Orders.Where(o => o.UserId == userId);
            return _mapper.Map<IEnumerable<OrderDTO>>(allOrders);
        }

        public void CreateOrder(OrderDTO model)
        {
            Order order = _mapper.Map<Order>(model);
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }
    }
}
