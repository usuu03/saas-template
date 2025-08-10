using System;
using Glevo.Domain.Common;
using Microsoft.AspNetCore.Identity;

namespace Glevo.Domain.Entities;

public class AppUser : IdentityUser<Guid>
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string DisplayName => $"{FirstName} {LastName}";
    public string? AvatarUrl { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }

    public  bool Equals(AppUser? other)
    {
        return other is not null &&
               Id == other.Id &&
               FirstName == other.FirstName &&
               LastName == other.LastName &&
               AvatarUrl == other.AvatarUrl &&
               CreatedAt == other.CreatedAt &&
               DeletedAt == other.DeletedAt;
    }
}
