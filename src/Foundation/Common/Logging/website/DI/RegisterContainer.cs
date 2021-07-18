using Camaro.Foundation.Common.Logging.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Camaro.Foundation.Common.Logging.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<ILogRepository, LogRepository>();
        }
    }
}