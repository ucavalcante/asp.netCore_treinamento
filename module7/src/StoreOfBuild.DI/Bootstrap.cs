﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conexao)
        {
         services.AddDbContext<ApplicationDbContext> (
             options => options.UseSqlServer(conexao)
         );
        }
    }
}
