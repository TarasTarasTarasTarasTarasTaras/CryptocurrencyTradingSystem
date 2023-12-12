using AutoMapper;
using CryptocurrencyTradingSystem.Core.EF.Entities;
using Orders.DTOs;
using Orders.Models;

namespace Orders.AutoMappers
{
    public class OrderMapper : Profile
    {
        public OrderMapper()
        {
            CreateMap<OrderModel, OrderDTO>();
            CreateMap<OrderDTO, Order>().ReverseMap();
        }
    }
}
