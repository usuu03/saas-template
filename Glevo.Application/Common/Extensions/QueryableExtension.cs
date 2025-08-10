using System;
using Glevo.Domain.Interfaces;

namespace Glevo.Application.Common.Extensions;


public static class QueryableExtensions
{
    public static IQueryable<T> FilterActive<T>(this IQueryable<T> query) where T : class, IHaveSoftDelete
    {
        return query.Where(x => x.DeletedAt == null);
    }

    // public static IQueryable<T> FilterTenancy<T>(this IQueryable<T> query, Guid tenantId) where T : class, IHaveSoftDelete
    // {
    //     // Assuming there's a TenantId property in the entity
    //     return query.Where(x => x.TenantId == tenantId && x.DeletedAt == null);
    // }

}
