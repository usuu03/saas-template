using System;
using Glevo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Glevo.Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<AppUser> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}
