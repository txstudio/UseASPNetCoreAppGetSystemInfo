using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace PromptManager
{

    /// <summary>命令提示字元基底類別</summary>
    public abstract class PromptManager
    {
        protected ProcessStartInfo _startInfo;
        protected Process _process;

        public PromptManager()
        {
            this._startInfo = new ProcessStartInfo();
            this._startInfo.CreateNoWindow = true;
            this._startInfo.UseShellExecute = false;
            this._startInfo.RedirectStandardOutput = true;
        }


        protected void ExecuteProcess()
        {
            this._process = new Process();
            this._process.StartInfo = this._startInfo;
            this._process.Start();
        }

        protected async Task<string> GetStandardOutput()
        {
            return await this._process.StandardOutput.ReadToEndAsync();
        }
        
        public virtual async Task<string> GetHostName()
        {
            return await Task.Run(() =>
            {
                return Dns.GetHostName();
            });
        }
    }
}
