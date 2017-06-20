using System.Runtime.InteropServices;


namespace OperatingSystemPlatform
{

    /// <summary>作業系統平台判斷</summary>
    public static class PlatformHelper
    {
        /// <summary>為 Windows 作業系統</summary>
        public static bool IsWindows()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

        /// <summary>為 MAC 作業系統</summary>
        public static bool IsMac()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        }

        /// <summary>為 Linux 作業系統</summary>
        public static bool IsLinux()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        }
    }
}
