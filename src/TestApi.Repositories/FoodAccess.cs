using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi.ServiceModel.Types;

namespace TestApi.Repositories
{
    public class FoodAccess
    {
        public FoodAccess()
        {

        }
        public string Testfunction()
        {
            return "meow";
        }
        public void StoreFood(string food)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("DennyTest");

            var collection = database.GetCollection<BsonDocument>("Foodz");


            var testDocument = new BsonDocument()
            {
                {"Type","Fruit"},
                {"Name","Banana"},
                {"Quantity", 4 },
                {"Color", "Yellow"}
            };

            collection.InsertOne(testDocument);

        }

        public void StorePrices()
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("ProductPrices");

            var collection = database.GetCollection<BsonDocument>("ProductCurrentPrice");


            var testDocument = new BsonDocument()
            {
                {"ProductId",12},
                {"Value",13.49},
                {"CurrencyCode", "USD" }
            };

            collection.InsertOne(testDocument);

        }

        public ProductPrice SearchProduct(string productId)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("ProductPrices");

            var collection = database.GetCollection<BsonDocument>("ProductCurrentPrice");

            var filter = Builders<BsonDocument>.Filter.Eq("ProductId", productId);

            var documentFood = collection.Find(filter).First();
            //var test = BsonSerializer.Deserialize<ProductPrice>(documentFood);

            var productPrice = new ProductPrice()
            {
                CurrencyCode = documentFood["CurrencyCode"].ToString(),
                Value = documentFood["Value"].ToDecimal()
            };

            return productPrice;

        }

        public BsonDocument SearchFood(string food)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("DennyTest");

            var collection = database.GetCollection<BsonDocument>("Foodz");

            var filter = Builders<BsonDocument>.Filter.Eq("Name",food);

            var documentFood = collection.Find(filter).First();

            return documentFood;

        }

        public void Updatefood(string food, string updateValue)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("DennyTest");

            var collection = database.GetCollection<BsonDocument>("Foodz");

            var filter = Builders<BsonDocument>.Filter.Eq("Name", "Banana");

            var update = Builders<BsonDocument>.Update.Set("Name", "xiangjiao");

            collection.UpdateOne(filter, update);
        }

        public void DeleteFood(string name)
        {
            var connectionString = "mongodb://localhost:27017";

            var client = new MongoClient(connectionString);

            //abstract out the DB
            var database = client.GetDatabase("DennyTest");

            var collection = database.GetCollection<BsonDocument>("Foodz");

            var deletingFilter = Builders<BsonDocument>.Filter.Eq("Name", "Grape");

            //collection.DeleteOne(deletingFilter);

            var result = collection.DeleteMany(deletingFilter);
        }

    }
}
