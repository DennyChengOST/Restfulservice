using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Interfaces.Repositories;
using TestApi.Interfaces.Repositories.Factory;
using TestApi.Interfaces.Repositories.ServiceClients;
using TestApi.ServiceModel.Messages;

namespace TestApi.Repositories
{
    public class RedskyRepository : IRedSkyRepository
    {
        #region Fields

        private readonly IClientFactory _clientFactory;

        #endregion

        #region Constructors

        public RedskyRepository(IClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        #endregion

        #region IRedSkyRepository Implementation

        public string GetProductName(Int64 id)
        {
            var response = new GetProductDetailsResponse();

            using (var client = _clientFactory.GetClient<IRedSkyServiceClient>())
            {
                var request = new GetProductDetailsRequest() { Id = id};
                response = client.Get(request);
            }
            return response.Name;
        }
        //thinking is this best practice to just pass back the ID?
        //i'm anticipating this HTTp call would get me only the name and nothing else
        //but reviewing the JSOn i'm not sure how to interpret it.
        //Potentially add mapping config?

        //Also thoughts on the usin the incomin request as place holder objs or should
        //I construct place holder dtos?
        #endregion
    }
}
