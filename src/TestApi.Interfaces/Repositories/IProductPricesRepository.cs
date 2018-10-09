using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Interfaces.Repositories
{
    public interface IProductPricesRepository
    {
        object GetProductCurrentPrice(Int64 requestId);

        object UpdateProductCurrentPrice(string requestId, decimal updatedPrice);
    }
}
