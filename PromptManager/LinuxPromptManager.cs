using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace PromptManager
{
    public class LinuxPromptManager : PromptManager, IPromptManager
    {
        const string fileName = "/bin/bash";

        public async Task<NetworkInfo> GetNetworkInfo()
        {
            var _argument = "-c ifconfig eth0";

            _startInfo.FileName = fileName;
            _startInfo.Arguments = _argument;

            this.ExecuteProcess();

            var _response = await this._process.StandardOutput.ReadToEndAsync();

            NetworkInfo _network = new NetworkInfo();
            _network.IPAddress = "0.0.0.0";
            _network.SubnetMask = "255.255.255.255";
            _network.Gateway = "0.0.0.0";
            _network.DnsAddress = new string[] { "0.0.0.0", "0.0.0.0" };

            return _network;
        }

        public void Reboot()
        {
            var _argument = "-c reboot";

            this._startInfo.FileName = fileName;
            this._startInfo.Arguments = _argument;

            this.ExecuteProcess();
        }
    }
}
