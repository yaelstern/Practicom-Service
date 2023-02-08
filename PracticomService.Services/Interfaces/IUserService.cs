using PracticomService.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Services.Interfaces
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetListAsync();

        Task<UserDTO> GetByIdAsync(int id);

        Task<UserDTO> AddAsync(UserDTO User);

        Task<UserDTO> UpdateAsync(UserDTO User);

        Task DeleteAsync(int id);
    }
}
