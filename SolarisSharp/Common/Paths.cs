namespace SolarisSharp.Common
{
    internal class Paths
    {
        public static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "//Solaris//";
        public static string AppDataDirectory = Path.GetFullPath(AppData);
        public static string AppToken = Path.GetFullPath(AppDataDirectory + "//token.solaris");
    }
}
