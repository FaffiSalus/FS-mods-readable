namespace FS_mods_to_sql.Core;

public static class CreateDatabase
{
    public static void Create(string server, string db, string dir)
    {
        SqlConnection myConn = new SqlConnection ("Server=" + server + ";Integrated security=SSPI;database=master");
        string str = "CREATE DATABASE " + db + " ON PRIMARY " +
                      "(NAME = " + db + ", " +
                      "FILENAME = '" + dir + "\\" + db + "Data.mdf', " +
                      "SIZE = 2GB, MAXSIZE = 10GB, FILEGROWTH = 10%)" +
                      "LOG ON (NAME = " + db + "_Log, " +
                      "FILENAME = '" + dir + "\\" + db + "Log.ldf', " +
                      "SIZE = 1GB, " +
                      "MAXSIZE = 5GB, " +
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