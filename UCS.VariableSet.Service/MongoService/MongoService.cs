using System;
using System.Collections.Generic;
using System.Text;
using UCS.VariableSet.MongoDb.MongoDbBase;

namespace UCS.VariableSet.Service.MongoService
{
    public class MongoService : IMongoService
    {
        private IMongoDbOperation _mongoDbOperation;
        public MongoService(IMongoDbOperation mongoDbOperation)
        {
            _mongoDbOperation = mongoDbOperation;
        }

        public List<T> GetListByCollection<T>(string table)
        {
            return _mongoDbOperation.GetListByCollection<T>(table);
        }

        public void Insert<T>(string table, T body)
        {
            _mongoDbOperation.Insert<T>(table, body);
        }
    }
}
