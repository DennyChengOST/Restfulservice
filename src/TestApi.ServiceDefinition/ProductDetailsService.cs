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
            //Should I do serivce model/data model mapping? or just pass directly the ID?
            //figure I made a datamodel for future casing scenarios where they wanted to
            //get different sets of data by ID or other parameters in the future
            //want to get product detaisl by name vs id? am i over thinking it?
            var productDetailsModel = _mapper.Map<ProductDetailsModel>(request);
            var response = _productDetailsManager.ReadByProductId(productDetailsModel);

            var getProductDetailsResponse = _mapper.Map<GetProductDetailsResponse>(response);
            return getProductDetailsResponse;
        }

        #endregion
    }
}
