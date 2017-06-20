using System.Diagnostics;
using System.Threading.Tasks;

namespace PromptManager
{
    public class WindowsPromptManager : PromptManager, IPromptManager
    {
        const string fileName = "cmd";

        public async Task<NetworkInfo> GetNetworkInfo()
        {
            var _argument = "/c ipconfig /all";

            this._startInfo.FileName = fileName;
            this._startInfo.Arguments = _argument;

            this.ExecuteProcess();

            var _response = await this.GetStandardOutput();

            NetworkInfo _network = new NetworkInfo();
            _network.IPAddress = "0.0.0.0";
            _network.SubnetMask = "255.255.255.255";
            _network.Gateway = "0.0.0.0";
            _network.DnsAddress = new string[] { "0.0.0.0", "0.0.0.0" };

            return _network;
        }

        public void Reboot()
        {
            var _argument = "/c shutdown /r /f /t 0";

            this._startInfo.FileName = fileName;
            this._startInfo.Arguments = _argument;

            this.ExecuteProcess();
        }
    }
}
