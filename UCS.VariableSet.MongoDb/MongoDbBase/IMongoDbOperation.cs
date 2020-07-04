using System.Collections.Generic;

namespace UCS.VariableSet.MongoDb.MongoDbBase
{
    public interface IMongoDbOperation
    {
        public void Insert<T>(string table, T body);
        public List<T> GetListByCollection<T>(string table);
    }
}