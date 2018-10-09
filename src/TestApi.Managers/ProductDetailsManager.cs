using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Interfaces.Repositories;

namespace TestApi.Managers
{
    public class ProductDetailsManager
    {
        #region Fields

        private readonly IProductPricesRepository _productPricesRepository;

        private readonly IRedSkyRepository _redSkyRepository;

        #endregion

        #region Constructors
        public ProductDetailsManager(IProductPricesRepository productPricesRepository, IRedSkyRepository redSkyRepository)
        {
            _productPricesRepository = productPricesRepository;
            _redSkyRepository = redSkyRepository;
        }

        #endregion

        #region Public Methods

        public void ReadByProductId(Int64 id)
        {
            //take in a string
            //Call out to HTTP GET for product name
            var productName = _redSkyRepository.GetProductName(id);
            //Call out to MongoPrice
            var productPrice = _productPricesRepository.GetProductCurrentPrice(id);
            //Send to builder or just assemble response obj here?
            //returns object from builder

        }

        #endregion
    }
}
