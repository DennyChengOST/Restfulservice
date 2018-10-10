using System;

using TestApi.ServiceModel.Types;

namespace MyRetailService.Api.DataModels
{
    public class ProductDetailsModel
    {
        public Int64 Id { get; set; }

        public string Name { get; set; }

        public ProductPrice CurrentPrice { get; set; }
    }
}
