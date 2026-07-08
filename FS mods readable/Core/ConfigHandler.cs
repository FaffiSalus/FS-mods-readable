using System.Xml;

namespace FS_mods_readable.Core;

public static class ConfigHandler
{
    public static string? GetLogDirectory()
    {
        return ReadFromConfig("LogDirectory");
    }

    public static void SetLogDirectory(string logDirectory)
    {
        WriteToConfig("LogDirectory", logDirectory);
    }

    public static string? GetLogFileName()
    {
        return ReadFromConfig("LogFileName");
    }

    public static void SetLogFileName(string logFileName)
    {
        WriteToConfig("LogFileName", logFileName);
    }

    public static string? GetSQLDirectory_Data()
    {
        return ReadFromConfig("SQLDirectory_Data");
    }

    public static void SetSQLDirectory_Data(string dataDirectory)
    {
        WriteToConfig("SQLDirectory_Data", dataDirectory);
    }

    public static string? GetSQLDirectory_Log()
    {
        return ReadFromConfig("SQLDirectory_Log");
    }

    public static void SetSQLDirectory_Log(string logDirectory)
    {
        WriteToConfig("SQLDirectory_Log", logDirectory);
    }

    public static string? GetSqlServerName()
    {
        return ReadFromConfig("SQLServerName");
    }

    public static void SetSqlServerName(string sqlServerName)
    {
        WriteToConfig("SQLServerName", sqlServerName);
    }

    public static string? GetSqlDatabaseName()
    {
        return ReadFromConfig("SQLDatabaseName");
    }

    public static void SetSqlDatabaseName(string sqlDatabaseName)
    {
        WriteToConfig("SQLDatabaseName", sqlDatabaseName);
    }

    public static string? GetCsvDirectory()
    {
        return ReadFromConfig("CSVDirectory");
    }

    public static void SetCsvDirectory(string? csvDirectory)
    {
        WriteToConfig("CSVDirectory", csvDirectory);
    }

    public static string? GetCsvBatchLimit()
    {
        return ReadFromConfig("CSVBatchLimit");
    }

    public static void SetCsvBatchLimit(string csvBatchLimit)
    {
        WriteToConfig("CSVBatchLimit", csvBatchLimit);
    }

    public static string? GetExcelDirectory()
    {
        return ReadFromConfig("ExcelDirectory");
    }

    public static void SetExcelDirectory(string excelDirectory)
    {
        WriteToConfig("ExcelDirectory", excelDirectory);
    }

    public static string? GetExcelFileName()
    {
        return ReadFromConfig("ExcelFileName");
    }

    public static void SetExcelFileName(string? excelFileName)
    {
        WriteToConfig("ExcelFileName", excelFileName);
    }

    public static string? GetExcelCellLimit()
    {
        return ReadFromConfig("ExcelCellLimit");
    }

    public static void SetExcelCellLimit(string excelCellLimit)
    {
        WriteToConfig("ExcelCellLimit", excelCellLimit);
    }

    public static string? GetExcelRowLimit()
    {
        return ReadFromConfig("ExcelRowLimit");
    }

    public static void SetExcelRowLimit(string excelRowLimit)
    {
        WriteToConfig("ExcelRowLimit", excelRowLimit);
    }

    public static string? GetSql()
    {
        return ReadFromConfig("SQL");
    }

    public static void SetSql(string sql)
    {
        WriteToConfig("SQL", sql);
    }

    public static string? GetCsv()
    {
        return ReadFromConfig("CSV");
    }

    public static void SetCsv(string csv)
    {
        WriteToConfig("CSV", csv);
    }

    public static string? GetExcel()
    {
        return ReadFromConfig("Excel");
    }

    public static void SetExcel(string excel)
    {
        WriteToConfig("Excel", excel);
    }


    private static string? ReadFromConfig(string nodeName)
    {
        var doc = new XmlDocument();
        doc.Load(Directory.GetCurrentDirectory() + "\\Config\\config.xml");
        var node = doc.SelectSingleNode("/Config/" + nodeName);
        return node.InnerText;
    }

    private static void WriteToConfig(string nodeName, string value)
    {
        var doc = new XmlDocument();
        doc.Load(Directory.GetCurrentDirectory() + "\\Config\\config.xml");
        var node = doc.SelectSingleNode("/Config/" + nodeName);
        node.InnerText = value;
        doc.Save(Directory.GetCurrentDirectory() + "\\Config\\config.xml");
    }
}