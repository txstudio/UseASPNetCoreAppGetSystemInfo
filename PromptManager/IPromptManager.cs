using System.Threading.Tasks;

namespace PromptManager
{

    /// <summary>定義命令提示字元模組的存取方法</summary>
    public interface IPromptManager
    {
        /// <summary>重新啟動電腦</summary>
        void Reboot();

        /// <summary>取得主機名稱</summary>
        /// <returns>主機名稱</returns>
        Task<string> GetHostName();

        /// <summary>取得網路資訊</summary>
        /// <returns></returns>
        Task<NetworkInfo> GetNetworkInfo();
    }
}
