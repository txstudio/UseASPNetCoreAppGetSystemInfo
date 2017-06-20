using System;
using System.Collections.Generic;
using System.Text;

namespace PromptManager
{
    /// <summary>網路資訊</summary>
    public class NetworkInfo
    {
        /// <summary>IP位址</summary>
        public string IPAddress { get; set; }

        /// <summary>子網路遮罩</summary>
        public string SubnetMask { get; set; }

        /// <summary>預設閘道</summary>
        public string Gateway { get; set; }

        /// <summary>DNS 伺服器清單</summary>
        public IEnumerable<string> DnsAddress { get; set; }
    }
}
