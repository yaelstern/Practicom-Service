using Microsoft.AspNetCore.Mvc;
using PracticomService.Common.DTOs;
using PracticomService.Services.Interfaces;
using PracticomService.WebAPI.Models;

namespace PracticomService.WebAPI.Controllers
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
        [HttpGet]
        public async Task<List<UserDTO>> Get()
        {
            return await _userService.GetListAsync();
        }
        [HttpGet("{id}")]
        public async Task<UserDTO> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<UserDTO> Post([FromBody] UserPostModel user)
        {
            List<ChildDTO> l = new List<ChildDTO>();
            foreach (ChildPostModel item in user.Children)
            {
                l.Add(new ChildDTO { BornDate = item.BornDate, FullName = item.FullName,IdentityNumber=item.IdentityNumber });
            }
            return await _userService.AddAsync(new UserDTO { FirstName = user.FirstName, LastName = user.LastName, BornDate = user.BornDate, HMO = user.HMO, GenderId = user.GenderId, IdentityNumber = user.IdentityNumber, Children = l });
        }
        [HttpPut]
        public async Task<UserDTO> Put([FromBody] UserPostModel user)
        {
            List<ChildDTO> l = new List<ChildDTO>();
            foreach (ChildPostModel item in user.Children)
            {
                l.Add(new ChildDTO { BornDate = item.BornDate, FullName = item.FullName, IdentityNumber = item.IdentityNumber });
            }
            return await _userService.UpdateAsync(new UserDTO { FirstName = user.FirstName, LastName = user.LastName, BornDate = user.BornDate, HMO = user.HMO, GenderId = user.GenderId, IdentityNumber = user.IdentityNumber, Children = l });
        }
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);
        }
    }
}
