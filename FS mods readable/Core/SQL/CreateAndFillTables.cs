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
            MessageBox.Show("Table is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        s.WriteToServer(table);
    }

    private static string GetCreateScript(string tableName, DataTable table)
    {
        var sqlsc = "CREATE TABLE " + tableName + "(";
        for (int i = 0; i < table.Columns.Count; i++)
        {
            sqlsc += "\n [" + table.Columns[i].ColumnName + "] ";
            sqlsc += string.Format(" nvarchar({0}) ", table.Columns[i].MaxLength == -1 ? "max" : table.Columns[i].MaxLength.ToString());
            sqlsc += ",";
        }

        return sqlsc.Substring(0, sqlsc.Length - 1) + "\n)";
    }
}