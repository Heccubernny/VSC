using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vsc.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace vsc.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }

    }
}
