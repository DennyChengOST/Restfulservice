using System;
using TestApi.ServiceModel.Types;

namespace TestApi.Interfaces.Repositories
{
    public interface IProductPricesRepository
    {
        ProductPrice GetProductCurrentPrice(Int64 requestId);

        object UpdateProductCurrentPrice(string requestId, decimal updatedPrice);
    }
}
