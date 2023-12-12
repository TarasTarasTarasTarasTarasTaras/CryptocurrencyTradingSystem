using AutoMapper;
using CryptocurrencyTradingSystem.Core.EF.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Users.DTOs;
using Users.Models;
using Users.Services;

namespace Users.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly TradingSystemContext _dbContext;
        private readonly IUserService _userService;

        public UserController(IMapper mapper, TradingSystemContext dbContext, IUserService userService)
        {
            _mapper = mapper;
            _dbContext = dbContext;
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public ActionResult Register([FromBody] RegisterModel request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _userService.Register(_mapper.Map<RegisterDTO>(request));

            var accessToken = _userService.Login(_mapper.Map<LoginDTO>(request));
            return Ok(accessToken);
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public ActionResult Login([FromBody] LoginModel request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var accessToken = _userService.Login(_mapper.Map<LoginDTO>(request));
            return Ok(accessToken);
        }

        [HttpGet("test")]
        public ActionResult Get()
        {
            _dbContext.Users.Add(new()
            {
                FirstName = "taras",
                Email = "taras@gmail.com"
            });
            _dbContext.SaveChanges();

            return Ok(_dbContext.Users.ToList());
        }
    }
}
