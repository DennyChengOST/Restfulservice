using MongoDB.Bson;
using MongoDB.Driver;

using System;
using System.Linq;

using TestApi.Interfaces.Repositories;
using TestApi.ServiceModel.Types;

namespace TestApi.Repositories
{
    public class ProductPricesRepository :IProductPricesRepository
    {
        #region Fields
        private readonly IMongoCollection<BsonDocument> _collection;
        #endregion

        #region Constructor
        public ProductPricesRepository()
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            var database = client.GetDatabase("ProductPrices");
            //Need to figure out how to move this into a factory of some sort?

            _collection = database.GetCollection<BsonDocument>("ProductCurrentPrice");
            //potentially want another collection of previous prices? Debating between ProductPrice vs ProductcurrentPrice
        }

        #endregion

        #region Public Methods

        public ProductPrice GetProductCurrentPrice(Int64 requestId)
        {
            var getFilter = Builders<BsonDocument>.Filter.Eq("ProductId", requestId);

            var collection = _collection.Find(getFilter).First();
            if (!collection.IsBsonNull)
            {
                return new ProductPrice()
                {
                    CurrencyCode = collection["CurrencyCode"].ToString(),
                    Value = collection["Value"].ToDecimal()
                };
            }
            else
            {
                return new ProductPrice();
            }
        }

        public object UpdateProductCurrentPrice(string requestId, decimal updatedPrice)
        {
            var getFilter = Builders<BsonDocument>.Filter.Eq("ProductId", requestId);

            var updateParameter = Builders<BsonDocument>.Update.Set("Price", updatedPrice);

           return _collection.UpdateOne(getFilter, updateParameter);
            //Do I need to potentially account for user wanting to change Currency Code?
        }

        #endregion
    }
}
