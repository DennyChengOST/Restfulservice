using MyRetailService.Api.DataModels;

namespace TestApi.Interfaces.Managers
{
    public interface IProductDetailsManager
    {
        ProductDetailsModel ReadByProductId(ProductDetailsModel productDetailsModel);
    }
}
