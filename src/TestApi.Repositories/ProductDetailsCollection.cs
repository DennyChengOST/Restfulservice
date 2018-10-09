using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.Interfaces;

namespace TestApi.Repositories
{
    public class ProductDetailsCollection
    {
        private readonly IMongoFactory _mongoFactory;

        public ProductDetailsCollection(IMongoFactory mongoFactory)
        {
            _mongoFactory = mongoFactory;

            //Initialize();
        }

        public IMongoCollection<BsonDocument> GetCollection()
        {
            return _mongoFactory.GetCollection<BsonDocument>("ProductDetails");

        }
    }
}
