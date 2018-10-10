using AutoMapper;
using MyRetailService.Api.DataModels;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Interfaces.Managers;
using TestApi.ServiceModel.Messages;

namespace TestApi.ServiceDefinition
{
    public class ProductDetailsService : Service
    {
        #region Fields

        private readonly IProductDetailsManager _productDetailsManager;

        private readonly IMapper _mapper;

        #endregion

        #region Constructors
        public ProductDetailsService(IProductDetailsManager productDetailsManager, IMapper mapper)
        {
            _productDetailsManager = productDetailsManager;
            _mapper = mapper;
        }

        #endregion

        #region Public Methods

        public GetProductDetailsResponse Get(GetProductDetailsRequest request)
        {
            //Is doing servicemodel/Datamodel too much complexity? D: 
            var readByProductIdRequest = _mapper.Map<ProductDetailsModel>(request);
            var readByProductIdResponse = _productDetailsManager.ReadByProductId(readByProductIdRequest);

            var getProductDetailsResponse = _mapper.Map<GetProductDetailsResponse>(readByProductIdResponse);
            return getProductDetailsResponse;
        }

        #endregion
    }
}
