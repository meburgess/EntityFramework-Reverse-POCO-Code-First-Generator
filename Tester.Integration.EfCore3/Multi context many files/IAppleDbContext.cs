// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EfCore3.Multi_context_many_filesAppleDbContext
{
    public interface IAppleDbContext : IDisposable
    {
        DbSet<Stafford_Boo> Stafford_Boos { get; set; } // Boo
        DbSet<Stafford_Foo> Stafford_Foos { get; set; } // Foo

        int SaveChanges();
        int SaveChanges(bool acceptAllChangesOnSuccess);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));
        DatabaseFacade Database { get; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }
}
// </auto-generated>
