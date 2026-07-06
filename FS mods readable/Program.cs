namespace FS_mods_readable;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ExcelPackage.License.SetNonCommercialOrganization("FaffiSalus");
        File.Delete(Directory.GetCurrentDirectory() + "\\log.txt");
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}