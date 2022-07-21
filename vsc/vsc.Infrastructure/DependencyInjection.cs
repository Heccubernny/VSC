using System.ComponentModel.Design;
using Microsoft.Extensions.DependencyInjection;
using vsc.Application.Common.Interfaces.Authentication;
using vsc.Application.Common.Interfaces.Authentication.Services;
using vsc.Infrastructure.Authentication;
using vsc.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace vsc.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            _ = services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            _ = services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
