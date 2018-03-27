using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Products;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conexao)
        {
         services.AddDbContext<ApplicationDbContext> (
             options => options.UseSqlServer(conexao));
         services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
         services.AddScoped(typeof(CategoryStorer));
         services.AddScoped(typeof(IUnitOfWork),typeof(UnitOfWork));
        }
    }
}
