using Microsoft.EntityFrameworkCore;
using PracticomService.Repositories.Entities;
using PracticomService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Repositories.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User u)
        {
            _context.Users.Add(u);
            await _context.SaveChangesAsync();
            return u;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User user)
        {

            var user2 = _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user2.Entity;
        }
    }
}
