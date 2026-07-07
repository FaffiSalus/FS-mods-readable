namespace FS_mods_readable.Core.SQL;

public static class CreateAndFillTables
{
    public static void CreateTable(string tableName, DataTable table)
    {
        using var conn = new SqlConnection("Server=" + ConfigHandler.GetSqlServerName() +
                                           ";Integrated security=SSPI;database=" + ConfigHandler.GetSqlDatabaseName());
        var script = GetCreateScript(tableName, table);
        using var myCommand = new SqlCommand(script, conn);
        var logMessage = "";
        try
        {
            conn.Open();
            myCommand.ExecuteNonQuery();
            logMessage = "Table " + tableName + " created";
        }
        catch (Exception ex)
        {
            logMessage = ex.ToString();
        }
        finally
        {
            LogHandler.WriteToLog(logMessage);
            if (conn.State == ConnectionState.Open) conn.Close();
        }
    }

    public static void FillTable(string tableName, DataTable table)
    {
        using var dbConnection = new SqlConnection("Server=" + ConfigHandler.GetSqlServerName() +
                                                   ";Integrated security=SSPI;database=" +
                                                   ConfigHandler.GetSqlDatabaseName());
        dbConnection.Open();
        using var s = new SqlBulkCopy(dbConnection);
        s.DestinationTableName = tableName;
        s.BulkCopyTimeout = 0;
        s.WriteToServer(table);
        LogHandler.WriteToLog("Filled Table " + tableName + " with " + table.Rows.Count + " records");
    }

    private static string GetCreateScript(string tableName, DataTable table)
    {
        var script = "DROP TABLE IF EXISTS " + tableName + ";\n CREATE TABLE " + tableName + "(";
        for (var i = 0; i < table.Columns.Count; i++)
        {
            script += "\n [" + table.Columns[i].ColumnName + "] ";
            script += " nvarchar(" +
                      (table.Columns[i].MaxLength == -1 ? "max" : table.Columns[i].MaxLength.ToString()) + ") ";
            script += ",";
        }

        return script[..^1] + "\n)";
    }
}