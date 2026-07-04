using System.Data;
using Microsoft.Data.SqlClient;

namespace FS_mods_to_sql;

public class CreateDatabase
{
    public static void create(String server, String db, String dir)
    {
        SqlConnection myConn = new SqlConnection ("Server=" + server + ";Integrated security=SSPI;database=master");
        String str = "CREATE DATABASE " + db + " ON PRIMARY " +
                      "(NAME = " + db + ", " +
                      "FILENAME = '" + dir + "\\" + db + "Data.mdf', " +
                      "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
                      "LOG ON (NAME = " + db + "_Log, " +
                      "FILENAME = '" + dir + "\\" + db + "Log.ldf', " +
                      "SIZE = 1MB, " +
                      "MAXSIZE = 5MB, " +
                      "FILEGROWTH = 10%)";

        SqlCommand myCommand = new SqlCommand(str, myConn);
        try
        {
            myConn.Open();
            myCommand.ExecuteNonQuery();
            MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (System.Exception ex)
        {
            MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        finally
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
        }
    }
}