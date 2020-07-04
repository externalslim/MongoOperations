using System.IO;
using System.Text;
using Newtonsoft.Json;
using UCS.VariableSet.Configuration.Models;

namespace UCS.VariableSet.Configuration
{
    public class ConfigurationProvider
    {
        protected static object LockObject = new object();
        private static ConfigurationProvider _instance = null;
        private SystemSettings SystemSettings { get; set; }

        public static ConfigurationProvider Instance
        {
            get
            {
                if (_instance == null)
                    lock (LockObject)
                        if (_instance == null)
                            _instance = new ConfigurationProvider();
                return _instance;
            }
        }

        public void Load()
        {
            var m = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            var fileStream = new FileStream(m, FileMode.Open, FileAccess.Read);
            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                var systemConfigStr = reader.ReadToEnd();
                fileStream.Close();
                reader.Close();
                SystemSettings = JsonConvert.DeserializeObject<SystemSettings>(systemConfigStr);
            }
        }

        public MongoDbConfiguration MongoDbConfiguration => SystemSettings.MongoDbConfiguration;
    }
}