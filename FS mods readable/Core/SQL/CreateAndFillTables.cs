namespace FS_mods_readable.Core.SQL;

public static class CreateAndFillTables
{
    public static void CreateTable(string server, string db, string tableName, DataTable table)
    {
        SqlConnection conn = new SqlConnection ("Server=" + server + ";Integrated security=SSPI;database=" + db);
        string script = GetCreateScript(tableName,  table);
        SqlCommand myCommand = new SqlCommand(script, conn);
        try
        {
            conn.Open();
            myCommand.ExecuteNonQuery();
            File.AppendAllText(Directory.GetCurrentDirectory() + "\\log.txt", DateTime.Now.ToShortTimeString() + ": Table " + tableName + " created \n");
        }
        catch (System.Exception ex)
        {
            File.AppendAllText(Directory.GetCurrentDirectory() + "\\log.txt", DateTime.Now.ToShortTimeString() + ": " + ex.ToString() + "\n");
        }
        finally
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
    
    public static void FillTable(string server, string db, string tableName, DataTable table)
    {
        using SqlConnection dbConnection = new SqlConnection("Server=" + server + ";Integrated security=SSPI;database=" + db);
        dbConnection.Open();
        using SqlBulkCopy s = new SqlBulkCopy(dbConnection);
        s.DestinationTableName = tableName;
        s.BulkCopyTimeout = 0;
        s.WriteToServer(table);
        File.AppendAllText(Directory.GetCurrentDirectory() + "\\log.txt", DateTime.Now.ToShortTimeString() + ": Filled Table " + tableName + " with " + table.Rows.Count + " records \n");
    }

    private static string GetCreateScript(string tableName, DataTable table)
    {
        var sqlsc = "DROP TABLE IF EXISTS " + tableName + ";\n CREATE TABLE " + tableName + "(";
        for (int i = 0; i < table.Columns.Count; i++)
        {
            sqlsc += "\n [" + table.Columns[i].ColumnName + "] ";
            sqlsc += string.Format(" nvarchar({0}) ", table.Columns[i].MaxLength == -1 ? "max" : table.Columns[i].MaxLength.ToString());
            sqlsc += ",";
        }

        return sqlsc.Substring(0, sqlsc.Length - 1) + "\n)";
    }
}