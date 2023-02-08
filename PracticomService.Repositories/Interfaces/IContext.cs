using Microsoft.EntityFrameworkCore;
using PracticomService.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Repositories.Interfaces
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Child> Children { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    }
}
