using Funq;
using ServiceStack;
using TestApi.Interfaces.Repositories.Factory;

namespace TestApi.Repositories.Factory
{
    public class ClientFactory : IClientFactory
    {
        private Container _container;

        public ClientFactory(Container container)
        {
            _container = container;
        }

        public IServiceClient GetClient<T>() where T : IServiceClient
        {
            return _container.TryResolve<T>();
        }
    }
}
