using System.Diagnostics;

namespace JsonToExcel
{
    public static class Project
    {
        public static string GetSoftwareVersion()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return fileVersionInfo.FileVersion;
        }
    }
}