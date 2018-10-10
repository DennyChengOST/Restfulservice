using Funq;
using ServiceStack.Validation;
using System.Configuration;
using TestApi.Interfaces.Managers;
using TestApi.Interfaces.Repositories;
using TestApi.Interfaces.Repositories.ServiceClients;
using TestApi.Managers;
using TestApi.Repositories;
using TestApi.Repositories.ServiceClients;
using TestApi.Validation;

namespace TestApi
{
    public static class ContainerManager
    {
        public static void Register(Container container)
        {
            // add service validation
            container.RegisterValidators(ReuseScope.Container, typeof(ValidationInfo).Assembly);

            // Mapper
            container.Register(c => MappingConfigurator.CreateMapper());

            // Utilities

            // ServiceClients Factories

            // ServiceClients
            container.Register<IRedSkyServiceClient>(c => new RedSkyServiceClient(ConfigurationManager.AppSettings["RedSkyServiceUrl"])).ReusedWithin(ReuseScope.None);


            // Repositories
            container.RegisterAs<ProductPricesRepository, IProductPricesRepository>();
            container.RegisterAs<RedskyRepository, IRedSkyRepository>();

            // Factories

            // Managers
            container.RegisterAs<ProductDetailsManager, IProductDetailsManager>();

            //container.RegisterAs<ProductDetailsManager, IProductDetailsManager>();


        }

    }
}
