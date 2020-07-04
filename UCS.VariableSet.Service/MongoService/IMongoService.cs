using System;
using System.Collections.Generic;
using System.Text;

namespace UCS.VariableSet.Service.MongoService
{
    public interface IMongoService
    {
        public void Insert<T>(string table, T body);
        public List<T> GetListByCollection<T>(string table);
    }
}
