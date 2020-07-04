using UCS.VariableSet.Configuration.Models;

namespace UCS.VariableSet.Configuration
{
    public class SystemSettings
    {
        public MongoDbConfiguration MongoDbConfiguration { get; set; }
        public SystemSettings()
        {
            MongoDbConfiguration = new MongoDbConfiguration();
        }
    }
}
