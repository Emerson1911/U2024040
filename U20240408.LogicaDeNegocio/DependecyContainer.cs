﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using U20240408.AccesoADatos;

namespace U20240408.LogicaDeNegocio
{
    public  static class DependecyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDalDependecies(configuration);
            services.AddScoped<PersonaUBL>();
            return services;
        }
    }
}
