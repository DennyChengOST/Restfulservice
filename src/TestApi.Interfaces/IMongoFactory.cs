using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi.Interfaces
{
    public interface IMongoFactory
    {
        IMongoCollection<TDocument> GetCollection<TDocument>(string collectionName);
    }
}
