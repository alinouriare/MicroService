using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitie.Configurations
{
    public class ZaminConfigurations
    {
        public string ServiceId { get; set; } = "Service01";
        public string JsonSerializerTypeName { get; set; }

        public string ExcelSerializerTypeName { get; set; }
        public string UserInfoServiceTypeName { get; set; }
        public bool RegisterAutomapperProfiles { get; set; } = true;
        public string AssmblyNameForLoad { get; set; }
        public MessageBus MessageBus { get; set; }
        public Messageconsumer Messageconsumer { get; set; }
        public PoolingPublisher PoolingPublisher { get; set; }

        public Translator Translator { get; set; }

        public Swagger Swagger { get; set; }
        public Chaching Chaching { get; set; }
    }
}
