using AutoMapper;
using MyRetailService.Api.DataModels;

using TestApi.ServiceModel.Messages;

namespace TestApi
{
    public static class MappingConfigurator
    {
        public static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(mapperConfiguration =>
            {
                MapServiceModelToDataModel(mapperConfiguration);
            });
            return config.CreateMapper();

        }

        private static void MapServiceModelToDataModel(IProfileExpression mapperConfiguration)
        {
            mapperConfiguration.CreateMap<GetProductDetailsRequest, ProductDetailsModel>();

        }
    }
}
