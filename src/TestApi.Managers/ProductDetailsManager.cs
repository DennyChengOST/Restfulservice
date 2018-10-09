using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Interfaces.Repositories;

namespace TestApi.Managers
{
    class ProductDetailsManager
    {
        #region Fields

        private readonly IProductPricesRepository _productPricesRepository;

        #endregion

        #region Constructors
        public ProductDetailsManager(IProductPricesRepository productPricesRepository)
        {
            _productPricesRepository = productPricesRepository;
        }

        #endregion

        #region Public Methods

        public void ReadByProductId(Int64 id)
        {
            //take in a string
            //Call out to HTTP GET for product name
            var productName
            //Call out to MongoPrice
            var productPrice = _productPricesRepository.GetProductCurrentPrice(id);
            //Send to builder
            //returns object from builder

        }

        #endregion
    }
}
