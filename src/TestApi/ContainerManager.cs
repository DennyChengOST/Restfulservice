using Funq;
using ServiceStack.Validation;

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

            // Repositories
            container.RegisterAs<ProductPricesRepository, IProductPricesRepository>();
            container.RegisterAs<RedskyRepository, IRedSkyRepository>();

            // Managers
            container.RegisterAs<ProductDetailsManager, IProductDetailsManager>();
        }

    }
}
