using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace U20240408.AccesoADatos
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddDalDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("conn")));
            services.AddScoped<PersonaUDAL>();
            return services;
        }
    }
}
