using System;

namespace Glevo.Domain.Interfaces;

public interface IHaveSoftDelete
{
    DateTime? DeletedAt { get; set; }

}
