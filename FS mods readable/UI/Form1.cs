using FS_mods_readable.Core;
using FS_mods_readable.Core.SQL;
using FS_mods_readable.Skyrim;

namespace FS_mods_readable.UI;

public partial class Form1 : Form
{
    private readonly FolderBrowserDialog _folderBrowserDialog1;

    public Form1()
    {
        InitializeComponent();
        ConfigHandler.SetLogDirectory(Directory.GetCurrentDirectory());
        ConfigHandler.SetLogFileName("log_" + DateTime.Now.ToFileTimeUtc() + ".txt");
        LogHandler.CreateLogFile();
        ConfigHandler.SetSql(false.ToString());
        ConfigHandler.SetCsv(false.ToString());
        ConfigHandler.SetExcel(false.ToString());
        InitializeValues();
        _folderBrowserDialog1 = new FolderBrowserDialog();
    }

    private void InitializeValues()
    {
        LogFileDirectory.Text = ConfigHandler.GetLogDirectory();
        LogFileName.Text = ConfigHandler.GetLogFileName();
        SqlDataFileDirectory.Text = ConfigHandler.GetSQLDirectory_Data();
        SqlLogFileDirectory.Text = ConfigHandler.GetSQLDirectory_Log();
        SqlServerName.Text = ConfigHandler.GetSqlServerName();
        SqlDatabaseName.Text = ConfigHandler.GetSqlDatabaseName();
        CsvDirectory.Text = ConfigHandler.GetCsvDirectory();
        CsvBatchLimit.Text = ConfigHandler.GetCsvBatchLimit();
        ExcelDirectory.Text = ConfigHandler.GetExcelDirectory();
        ExcelFileName.Text = ConfigHandler.GetExcelFileName();
        SqlCheckBox.Checked = bool.Parse(ConfigHandler.GetSql()!);
        CsvCheckBox.Checked = bool.Parse(ConfigHandler.GetCsv()!);
        ExcelCheckBox.Checked = bool.Parse(ConfigHandler.GetExcel()!);
    }

    private string ChooseDirectory()
    {
        var result = _folderBrowserDialog1.ShowDialog();
        return result != DialogResult.OK ? string.Empty : _folderBrowserDialog1.SelectedPath;
    }

    private void LogFileDirectory_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetLogDirectory(LogFileDirectory.Text);
    }

    private void LogFileName_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetLogFileName(LogFileName.Text);
    }

    private void btnCreateLogfile_Click(object sender, EventArgs e)
    {
        LogHandler.CreateLogFile();
    }

    private void SqlDataFileDirectory_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetSQLDirectory_Data(SqlDataFileDirectory.Text);
    }

    private void SqlLogFileDirectory_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetSQLDirectory_Log(SqlLogFileDirectory.Text);
    }

    private void SqlServerName_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetSqlServerName(SqlServerName.Text);
    }

    private void SqlDatabaseName_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetSqlDatabaseName(SqlDatabaseName.Text);
    }

    private void btnCreateSqlDatabase_Click(object sender, EventArgs e)
    {
        CreateDatabase.Create();
    }

    private void CsvBatchLimit_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetCsvBatchLimit(CsvBatchLimit.Text);
    }

    private void ExcelDirectory_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetExcelDirectory(ExcelDirectory.Text);
    }

    private void ExcelFileName_TextChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetExcelFileName(ExcelFileName.Text);
    }

    private void btnChooseSqlDataDirectory_Click(object sender, EventArgs e)
    {
        var dir = ChooseDirectory();
        ConfigHandler.SetSQLDirectory_Data(dir);
        SqlDataFileDirectory.Text = dir;
    }

    private void btnChooseSqlLogDirectory_Click(object sender, EventArgs e)
    {
        var dir = ChooseDirectory();
        ConfigHandler.SetSQLDirectory_Log(dir);
        SqlLogFileDirectory.Text = dir;
    }

    private void btnChooseCsvDirectory_Click(object sender, EventArgs e)
    {
        var dir = ChooseDirectory();
        ConfigHandler.SetCsvDirectory(dir);
        CsvDirectory.Text = dir;
    }

    private void btnChooseExcelDirectory_Click(object sender, EventArgs e)
    {
        var dir = ChooseDirectory();
        ConfigHandler.SetExcelDirectory(dir);
        ExcelDirectory.Text = dir;
    }

    private void btnChooseLogDirectory_Click(object sender, EventArgs e)
    {
        var dir = ChooseDirectory();
        ConfigHandler.SetLogDirectory(dir);
        LogFileDirectory.Text = dir;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Starting");
        GetSkyrimDataForModlist.GetAll();
        MessageBox.Show("Done");
    }

    private void SqlCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetSql(SqlCheckBox.Checked.ToString());

        SqlDatabaseName.ReadOnly = !SqlCheckBox.Checked;
        SqlDataFileDirectory.ReadOnly = !SqlCheckBox.Checked;
        SqlLogFileDirectory.ReadOnly = !SqlCheckBox.Checked;
        SqlServerName.ReadOnly = !SqlCheckBox.Checked;
    }

    private void CsvCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetCsv(CsvCheckBox.Checked.ToString());

        CsvBatchLimit.ReadOnly = !CsvCheckBox.Checked;
        CsvDirectory.ReadOnly = !CsvCheckBox.Checked;
    }

    private void ExcelCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ConfigHandler.SetExcel(ExcelCheckBox.Checked.ToString());

        ExcelDirectory.ReadOnly = !ExcelCheckBox.Checked;
        ExcelFileName.ReadOnly = !ExcelCheckBox.Checked;
    }
}