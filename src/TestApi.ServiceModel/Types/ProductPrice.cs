using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.ServiceModel.Types
{
    [BsonIgnoreExtraElements]
    public class ProductPrice
    {
        [BsonId]
        [BsonElement(elementName:"_id")]
        public ObjectId _id { get; set; }

        [BsonElement(elementName: "ProductId")]
        [DataMember(Order = 1)]
        public string ProductId { get; set; }

        [BsonElement(elementName: "Value")]
        [DataMember(Order = 2)]
        public decimal Value{ get; set; }

        [BsonElement(elementName: "CurrencyCode")]
        [DataMember(Order = 3)]
        public string CurrencyCode{ get; set; }
    }
}
