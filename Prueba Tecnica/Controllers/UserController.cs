using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dto;
using PruebaTecnica.Interfaces.Services;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _userService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

    

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _userService.GetById(id);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpPost("Post")]
        public async Task<IActionResult> Post([FromBody] UserDbAlterDto userDto)
        {
            var response = await _userService.Post(userDto);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UserDbAlterDto usuarioDto)
        {
            var updatedUser = await _userService.Update(id, usuarioDto);
            return Ok(updatedUser);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.Delete(id);
            return NoContent();
        }

    }
}
