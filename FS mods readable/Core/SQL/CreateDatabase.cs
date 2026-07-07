namespace FS_mods_readable.Core.SQL;

public static class CreateDatabase
{
    public static void Create()
    {
        var db = ConfigHandler.GetSqlDatabaseName();
        var myConn = new SqlConnection("Server=" + ConfigHandler.GetSqlServerName() +
                                       ";Integrated security=SSPI;database=master");
        var str = "CREATE DATABASE " + db + " ON PRIMARY " +
                  "(NAME = " + db + ", " +
                  "FILENAME = '" + ConfigHandler.GetSQLDirectory_Data() + "\\" + db + "Data.mdf', " +
                  "SIZE = 2GB, MAXSIZE = 10GB, FILEGROWTH = 10%)" +
                  "LOG ON (NAME = " + db + "_Log, " +
                  "FILENAME = '" + ConfigHandler.GetSQLDirectory_Log() + "\\" + db + "Log.ldf', " +
                  "SIZE = 1GB, " +
                  "MAXSIZE = 5GB, " +
                  "FILEGROWTH = 10%)";

        using var myCommand = new SqlCommand(str, myConn);
        try
        {
            myConn.Open();
            myCommand.ExecuteNonQuery();
            myCommand.CommandTimeout = 600;
            LogHandler.WriteToLog("DataBase " + db + " is Created Successfully");
        }
        catch (Exception ex)
        {
            LogHandler.WriteToLog(ex.Message);
        }
        finally
        {
            if (myConn.State == ConnectionState.Open) myConn.Close();
        }
    }
}