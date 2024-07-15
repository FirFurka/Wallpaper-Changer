using System.Runtime.InteropServices;

namespace ChangeWallpaper 
{
    internal class ChangeWallpaper
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, string vParam, UInt32 winIni);
        private static void Main(string[] args)
        {
            string Path = ""; 
            SystemParametersInfo(0x14, 0, Path, 0x01 | 0x02);
        }
    }
}