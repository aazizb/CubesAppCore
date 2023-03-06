
namespace CubesAppCore.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ICubeBuilder, CubeBuilder>();
            return services;
        }

    }
}
