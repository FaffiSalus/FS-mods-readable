using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace FS_mods_to_sql;

public class CreateTables
{
    public static void createAllTables(SqlConnection conn, string db)
    {
        Server server = new Server(new ServerConnection(conn));
        string[] files = Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "SQLScripts"), "*.txt");
        foreach (string file in files)
        {
            string script = "USE [" + db + "] \n GO \n";
            script += File.ReadAllText(file);
            server.ConnectionContext.ExecuteNonQuery(script);
        }
    }
}