using AutoMapper;
using PracticomService.Common.DTOs;
using PracticomService.Repositories.Entities;
using PracticomService.Repositories.Interfaces;
using PracticomService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> AddAsync(UserDTO user)
        {
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(_mapper.Map<User>(user)));
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }

        public async Task<UserDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }

        public async Task<List<UserDTO>> GetListAsync()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> UpdateAsync(UserDTO User)
        {
            return _mapper.Map<UserDTO>(await _userRepository.UpdateAsync(_mapper.Map<User>(User)));
        }
    }
}
