﻿using System;
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
             options => options.UseSqlServer(conexao)
         );
         services.AddSingleton(typeof(IRepository<>),typeof(Repository<>));
         services.AddSingleton(typeof(CategoryStorer));
        }
    }
}
