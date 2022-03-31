using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TelegramSendMessage
{
    class ResultErro
    {
        [DataMember(Name = "ok")]
        public string sStatus { get; set; }

        [DataMember(Name = "error_code")]
        public string sCodErro { get; set; }

        [DataMember(Name = "description")]
        public string sDescricao { get; set; }

        [DataMember(Name = "Bad Request")]
        public string sMsg { get; set; }
    }
}
