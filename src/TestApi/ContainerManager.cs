using Funq;
using ServiceStack.Validation;
using System.Configuration;
using TestApi.Interfaces.Managers;
using TestApi.Interfaces.Repositories;
using TestApi.Managers;
using TestApi.Repositories;
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
