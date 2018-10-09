using ServiceStack;

using TestApi.Interfaces.Repositories.ServiceClients;

namespace TestApi.Repositories.ServiceClients
{
   public class RedSkyServiceClient : JsonServiceClient, IRedSkyServiceClient
    {
        public RedSkyServiceClient(string baseUrl) : base(baseUrl)
        {
        }
    }
}
