using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Modul4HW4
{
    public class ConfigService
    {
        private const string _path = "Config.json";
        private Config _config;
        public ConfigService()
        {
            GetConfig();
        }

        public string ConnectionString => _config.ConnectionString;

        private void GetConfig()
        {
            _config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(_path));
        }
    }
}
