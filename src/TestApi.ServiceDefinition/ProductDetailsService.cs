using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.ServiceModel.Messages;

namespace TestApi.ServiceDefinition
{
    public class ProductDetailsService : Service
    {
        #region Fields

        #endregion

        #region Constructors
        public ProductDetailsService()
        {

        }

        #endregion

        #region Public Methods

        public GetProductDetailsResponse Get(GetProductDetails request)
        {
            return new GetProductDetailsResponse();
        }

        #endregion
    }
}
