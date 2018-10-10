using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //public ProductPrice GetProductCurrentPrice(Int64 requestId)
        //{
        //    var getFilter = Builders<BsonDocument>.Filter.Eq("ProductId", requestId);

        //    var collection =_collection.Find(getFilter).First();
        //    if (!collection.IsBsonNull)
        //    {
        //        return new ProductPrice()
        //        {
        //            CurrencyCode = collection["CurrencyCode"].ToString(),
        //            Value = collection["Value"].ToDecimal()
        //        };
        //    }
        //    else
        //    {
        //        return new ProductPrice();
        //    }
        //}

        public ProductPrice GetProductCurrentPrice(Int64 requestId)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("ProductPrices");

            var collection = database.GetCollection<BsonDocument>("ProductCurrentPrice");

            var filter = Builders<BsonDocument>.Filter.Eq("ProductId", requestId);

            var documentFood = collection.Find(filter).First();
            //var test = BsonSerializer.Deserialize<ProductPrice>(documentFood);

            var productPrice = new ProductPrice()
            {
                CurrencyCode = documentFood["CurrencyCode"].ToString(),
                Value = documentFood["Value"].ToDecimal()
            };

            return productPrice;
        }

        public object UpdateProductCurrentPrice(string requestId, decimal updatedPrice)
        {
            var getFilter = Builders<BsonDocument>.Filter.Eq("Id", requestId);

            var updateParameter = Builders<BsonDocument>.Update.Set("Price", updatedPrice);

           return _collection.UpdateOne(getFilter, updateParameter);
            //Do I need to potentially account for user wanting to change Currency Code?
        }

        #endregion
    }
}
