using System.Diagnostics;

namespace JsonToExcel
{
    public static class CommonUtilities
    {
        public static string GetSoftwareVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fvi.FileVersion;
        }
    }
}