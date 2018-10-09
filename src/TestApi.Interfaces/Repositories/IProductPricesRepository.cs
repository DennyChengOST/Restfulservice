using System;

namespace TestApi.Interfaces.Repositories
{
    public interface IProductPricesRepository
    {
        object GetProductCurrentPrice(Int64 requestId);

        object UpdateProductCurrentPrice(string requestId, decimal updatedPrice);
    }
}
