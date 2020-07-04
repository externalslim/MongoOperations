using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using UCS.VariableSet.Configuration;

namespace UCS.VariableSet.MongoDb.MongoDbBase
{
    public class MongoDbOperation : IMongoDbOperation
    {
        public IMongoDatabase _mongoDatabase;
        public MongoDbOperation()
        {
            var client = new MongoClient();
            _mongoDatabase = client.GetDatabase(ConfigurationProvider.Instance.MongoDbConfiguration.Database);
        }

        public void Insert<T>(string table, T body)
        {
            var collection = _mongoDatabase.GetCollection<T>(table);
            collection.InsertOne(body);
        }

        public List<T> GetListByCollection<T>(string table)
        {
            var collection = _mongoDatabase.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
    }
}