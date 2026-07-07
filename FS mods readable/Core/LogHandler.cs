namespace FS_mods_readable.Core;

public static class LogHandler
{
    public static void CreateLogFile()
    {
        File.Create(ConfigHandler.GetLogDirectory() + "\\" +  ConfigHandler.GetLogFileName()).Close();
    }
    public static void WriteToLog(string log)
    {
        File.AppendAllText(ConfigHandler.GetLogDirectory() + "\\" + ConfigHandler.GetLogFileName(), DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString() + ": " + log + "\n");
    }
}