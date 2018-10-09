using ServiceStack;

namespace TestApi.Interfaces.Repositories.Factory
{
    public interface IClientFactory
    {
        IServiceClient GetClient<T>() where T : IServiceClient;
    }
}
