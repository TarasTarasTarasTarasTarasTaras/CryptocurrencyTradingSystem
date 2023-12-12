using AutoMapper;
using CryptocurrencyTradingSystem.Core.EF.Entities;
using Users.DTOs;

namespace Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IMapper _mapper;
        private readonly TradingSystemContext _dbContext;

        public UserRepository(IMapper mapper, TradingSystemContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public void Register(RegisterDTO model)
        {
            var user = _mapper.Map<User>(model);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public UserDTO? GetUserByEmail(string email)
        {
            var account = _dbContext.Users
                .FirstOrDefault(_ => _.Email == email);

            return account == null ? null : _mapper.Map<UserDTO>(account);
        }
    }
}
