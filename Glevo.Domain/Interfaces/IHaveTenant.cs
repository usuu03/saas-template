using System;

namespace Glevo.Domain.Interfaces;

public interface IHaveTenant
{
    Guid TenantId { get; set; }

}
