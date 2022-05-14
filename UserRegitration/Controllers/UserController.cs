using Microsoft.AspNetCore.Mvc;
using UserRegitration.Application.Interfaces;
using UserRegitration.Dto;

namespace UserRegitration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _userService.Get());
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _userService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] InputUserDto userDto)
        {
            _userService.Add(userDto.Login, userDto.Password, userDto.Email, userDto.Tel);

            return Ok();
        }


        [HttpPatch]
        public IActionResult Patch([FromBody] InputUserDto userDto)
        {
            _userService.Add(userDto.Login, userDto.Password, userDto.Email, userDto.Tel);

            return Ok();
        }




    }

}