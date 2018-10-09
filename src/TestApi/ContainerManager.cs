using Funq;
using ServiceStack.Validation;
using TestApi.Interfaces.Repositories;
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

            // Utilities

            // ServiceClients Factories

            // ServiceClients

            // Repositories
            container.RegisterAs<ProductPricesRepository, IProductPricesRepository>();

            // Factories

        }

    }
}
