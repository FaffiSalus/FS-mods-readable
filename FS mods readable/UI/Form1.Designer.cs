using IContainer = System.ComponentModel.IContainer;

namespace FS_mods_readable.UI;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        tabControl1 = new System.Windows.Forms.TabControl();
        SQL = new System.Windows.Forms.TabPage();
        btnChooseSqlLogDirectory = new System.Windows.Forms.Button();
        btnChooseSqlDataDirectory = new System.Windows.Forms.Button();
        btnFillAllTables = new System.Windows.Forms.Button();
        btnCreateSqlDatabase = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        SqlServerName = new System.Windows.Forms.TextBox();
        SqlLogFileDirectory = new System.Windows.Forms.TextBox();
        SqlDatabaseName = new System.Windows.Forms.TextBox();
        SqlDataFileDirectory = new System.Windows.Forms.TextBox();
        CSV = new System.Windows.Forms.TabPage();
        btnChooseCsvDirectory = new System.Windows.Forms.Button();
        btnCreateCsvFiles = new System.Windows.Forms.Button();
        CsvBatchLimit = new System.Windows.Forms.TextBox();
        label8 = new System.Windows.Forms.Label();
        CsvDirectory = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        Excel = new System.Windows.Forms.TabPage();
        btnChooseExcelDirectory = new System.Windows.Forms.Button();
        btnCreateExcel = new System.Windows.Forms.Button();
        ExcelFileName = new System.Windows.Forms.TextBox();
        ExcelDirectory = new System.Windows.Forms.TextBox();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        AdvancedSettings = new System.Windows.Forms.TabPage();
        btnChooseLogDirectory = new System.Windows.Forms.Button();
        btnCreateLogfile = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        LogFileName = new System.Windows.Forms.TextBox();
        LogFileDirectory = new System.Windows.Forms.TextBox();
        tabControl1.SuspendLayout();
        SQL.SuspendLayout();
        CSV.SuspendLayout();
        Excel.SuspendLayout();
        AdvancedSettings.SuspendLayout();
        SuspendLayout();
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(SQL);
        tabControl1.Controls.Add(CSV);
        tabControl1.Controls.Add(Excel);
        tabControl1.Controls.Add(AdvancedSettings);
        tabControl1.Location = new System.Drawing.Point(12, 12);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(789, 437);
        tabControl1.TabIndex = 10;
        // 
        // SQL
        // 
        SQL.Controls.Add(btnChooseSqlLogDirectory);
        SQL.Controls.Add(btnChooseSqlDataDirectory);
        SQL.Controls.Add(btnFillAllTables);
        SQL.Controls.Add(btnCreateSqlDatabase);
        SQL.Controls.Add(label6);
        SQL.Controls.Add(label5);
        SQL.Controls.Add(label4);
        SQL.Controls.Add(label3);
        SQL.Controls.Add(SqlServerName);
        SQL.Controls.Add(SqlLogFileDirectory);
        SQL.Controls.Add(SqlDatabaseName);
        SQL.Controls.Add(SqlDataFileDirectory);
        SQL.Location = new System.Drawing.Point(4, 24);
        SQL.Name = "SQL";
        SQL.Padding = new System.Windows.Forms.Padding(3);
        SQL.Size = new System.Drawing.Size(781, 409);
        SQL.TabIndex = 0;
        SQL.Text = "SQL";
        SQL.UseVisualStyleBackColor = true;
        // 
        // btnChooseSqlLogDirectory
        // 
        btnChooseSqlLogDirectory.Location = new System.Drawing.Point(231, 51);
        btnChooseSqlLogDirectory.Name = "btnChooseSqlLogDirectory";
        btnChooseSqlLogDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseSqlLogDirectory.TabIndex = 11;
        btnChooseSqlLogDirectory.Text = "Choose Directory";
        btnChooseSqlLogDirectory.UseVisualStyleBackColor = true;
        btnChooseSqlLogDirectory.Click += btnChooseSqlLogDirectory_Click;
        // 
        // btnChooseSqlDataDirectory
        // 
        btnChooseSqlDataDirectory.Location = new System.Drawing.Point(231, 12);
        btnChooseSqlDataDirectory.Name = "btnChooseSqlDataDirectory";
        btnChooseSqlDataDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseSqlDataDirectory.TabIndex = 10;
        btnChooseSqlDataDirectory.Text = "Choose Directory";
        btnChooseSqlDataDirectory.UseVisualStyleBackColor = true;
        btnChooseSqlDataDirectory.Click += btnChooseSqlDataDirectory_Click;
        // 
        // btnFillAllTables
        // 
        btnFillAllTables.Location = new System.Drawing.Point(6, 197);
        btnFillAllTables.Name = "btnFillAllTables";
        btnFillAllTables.Size = new System.Drawing.Size(100, 23);
        btnFillAllTables.TabIndex = 9;
        btnFillAllTables.Text = "Fill All Tables";
        btnFillAllTables.UseVisualStyleBackColor = true;
        btnFillAllTables.Click += btnFillAllTables_Click;
        // 
        // btnCreateSqlDatabase
        // 
        btnCreateSqlDatabase.Location = new System.Drawing.Point(6, 168);
        btnCreateSqlDatabase.Name = "btnCreateSqlDatabase";
        btnCreateSqlDatabase.Size = new System.Drawing.Size(100, 23);
        btnCreateSqlDatabase.TabIndex = 8;
        btnCreateSqlDatabase.Text = "Create Database";
        btnCreateSqlDatabase.UseVisualStyleBackColor = true;
        btnCreateSqlDatabase.Click += btnCreateSqlDatabase_Click;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 116);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 31);
        label6.TabIndex = 7;
        label6.Text = "SQL Database Name";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 90);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 6;
        label5.Text = "SQL Servername";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 52);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 32);
        label4.TabIndex = 5;
        label4.Text = "SQL Log File Directory";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 12);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 30);
        label3.TabIndex = 4;
        label3.Text = "SQL Data File Directory";
        // 
        // SqlServerName
        // 
        SqlServerName.Location = new System.Drawing.Point(112, 87);
        SqlServerName.Name = "SqlServerName";
        SqlServerName.Size = new System.Drawing.Size(100, 23);
        SqlServerName.TabIndex = 3;
        SqlServerName.TextChanged += SqlServerName_TextChanged;
        // 
        // SqlLogFileDirectory
        // 
        SqlLogFileDirectory.Location = new System.Drawing.Point(112, 52);
        SqlLogFileDirectory.Name = "SqlLogFileDirectory";
        SqlLogFileDirectory.Size = new System.Drawing.Size(100, 23);
        SqlLogFileDirectory.TabIndex = 2;
        SqlLogFileDirectory.TextChanged += SqlLogFileDirectory_TextChanged;
        // 
        // SqlDatabaseName
        // 
        SqlDatabaseName.Location = new System.Drawing.Point(112, 124);
        SqlDatabaseName.Name = "SqlDatabaseName";
        SqlDatabaseName.Size = new System.Drawing.Size(100, 23);
        SqlDatabaseName.TabIndex = 1;
        SqlDatabaseName.TextChanged += SqlDatabaseName_TextChanged;
        // 
        // SqlDataFileDirectory
        // 
        SqlDataFileDirectory.Location = new System.Drawing.Point(112, 12);
        SqlDataFileDirectory.Name = "SqlDataFileDirectory";
        SqlDataFileDirectory.Size = new System.Drawing.Size(100, 23);
        SqlDataFileDirectory.TabIndex = 0;
        SqlDataFileDirectory.TextChanged += SqlDataFileDirectory_TextChanged;
        // 
        // CSV
        // 
        CSV.Controls.Add(btnChooseCsvDirectory);
        CSV.Controls.Add(btnCreateCsvFiles);
        CSV.Controls.Add(CsvBatchLimit);
        CSV.Controls.Add(label8);
        CSV.Controls.Add(CsvDirectory);
        CSV.Controls.Add(label7);
        CSV.Location = new System.Drawing.Point(4, 24);
        CSV.Name = "CSV";
        CSV.Padding = new System.Windows.Forms.Padding(3);
        CSV.Size = new System.Drawing.Size(781, 409);
        CSV.TabIndex = 1;
        CSV.Text = "CSV";
        CSV.UseVisualStyleBackColor = true;
        // 
        // btnChooseCsvDirectory
        // 
        btnChooseCsvDirectory.Location = new System.Drawing.Point(230, 12);
        btnChooseCsvDirectory.Name = "btnChooseCsvDirectory";
        btnChooseCsvDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseCsvDirectory.TabIndex = 11;
        btnChooseCsvDirectory.Text = "Choose Directory";
        btnChooseCsvDirectory.UseVisualStyleBackColor = true;
        btnChooseCsvDirectory.Click += btnChooseCsvDirectory_Click;
        // 
        // btnCreateCsvFiles
        // 
        btnCreateCsvFiles.Location = new System.Drawing.Point(6, 92);
        btnCreateCsvFiles.Name = "btnCreateCsvFiles";
        btnCreateCsvFiles.Size = new System.Drawing.Size(100, 23);
        btnCreateCsvFiles.TabIndex = 4;
        btnCreateCsvFiles.Text = "Create Csv Files";
        btnCreateCsvFiles.UseVisualStyleBackColor = true;
        btnCreateCsvFiles.Click += btnCreateCsvFiles_Click;
        // 
        // CsvBatchLimit
        // 
        CsvBatchLimit.Location = new System.Drawing.Point(112, 44);
        CsvBatchLimit.Name = "CsvBatchLimit";
        CsvBatchLimit.Size = new System.Drawing.Size(100, 23);
        CsvBatchLimit.TabIndex = 3;
        CsvBatchLimit.TextChanged += CsvBatchLimit_TextChanged;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(6, 47);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(100, 23);
        label8.TabIndex = 2;
        label8.Text = "Csv Batch Limit";
        // 
        // CsvDirectory
        // 
        CsvDirectory.Location = new System.Drawing.Point(112, 12);
        CsvDirectory.Name = "CsvDirectory";
        CsvDirectory.Size = new System.Drawing.Size(100, 23);
        CsvDirectory.TabIndex = 1;
        CsvDirectory.TextChanged += CsvDirectory_TextChanged;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(6, 12);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 23);
        label7.TabIndex = 0;
        label7.Text = "Csv Directory";
        // 
        // Excel
        // 
        Excel.Controls.Add(btnChooseExcelDirectory);
        Excel.Controls.Add(btnCreateExcel);
        Excel.Controls.Add(ExcelFileName);
        Excel.Controls.Add(ExcelDirectory);
        Excel.Controls.Add(label10);
        Excel.Controls.Add(label9);
        Excel.Location = new System.Drawing.Point(4, 24);
        Excel.Name = "Excel";
        Excel.Size = new System.Drawing.Size(781, 409);
        Excel.TabIndex = 2;
        Excel.Text = "Excel";
        Excel.UseVisualStyleBackColor = true;
        // 
        // btnChooseExcelDirectory
        // 
        btnChooseExcelDirectory.Location = new System.Drawing.Point(229, 9);
        btnChooseExcelDirectory.Name = "btnChooseExcelDirectory";
        btnChooseExcelDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseExcelDirectory.TabIndex = 11;
        btnChooseExcelDirectory.Text = "Choose Directory";
        btnChooseExcelDirectory.UseVisualStyleBackColor = true;
        btnChooseExcelDirectory.Click += btnChooseExcelDirectory_Click;
        // 
        // btnCreateExcel
        // 
        btnCreateExcel.Location = new System.Drawing.Point(3, 87);
        btnCreateExcel.Name = "btnCreateExcel";
        btnCreateExcel.Size = new System.Drawing.Size(100, 23);
        btnCreateExcel.TabIndex = 4;
        btnCreateExcel.Text = "Create Excel";
        btnCreateExcel.UseVisualStyleBackColor = true;
        btnCreateExcel.Click += btnCreateExcel_Click;
        // 
        // ExcelFileName
        // 
        ExcelFileName.Location = new System.Drawing.Point(109, 45);
        ExcelFileName.Name = "ExcelFileName";
        ExcelFileName.Size = new System.Drawing.Size(100, 23);
        ExcelFileName.TabIndex = 3;
        ExcelFileName.TextChanged += ExcelFileName_TextChanged;
        // 
        // ExcelDirectory
        // 
        ExcelDirectory.Location = new System.Drawing.Point(109, 9);
        ExcelDirectory.Name = "ExcelDirectory";
        ExcelDirectory.Size = new System.Drawing.Size(100, 23);
        ExcelDirectory.TabIndex = 2;
        ExcelDirectory.TextChanged += ExcelDirectory_TextChanged;
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(3, 45);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(100, 23);
        label10.TabIndex = 1;
        label10.Text = "Excel File Name";
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(3, 9);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(100, 23);
        label9.TabIndex = 0;
        label9.Text = "Excel Directory";
        // 
        // AdvancedSettings
        // 
        AdvancedSettings.Controls.Add(btnChooseLogDirectory);
        AdvancedSettings.Controls.Add(btnCreateLogfile);
        AdvancedSettings.Controls.Add(label2);
        AdvancedSettings.Controls.Add(label1);
        AdvancedSettings.Controls.Add(LogFileName);
        AdvancedSettings.Controls.Add(LogFileDirectory);
        AdvancedSettings.Location = new System.Drawing.Point(4, 24);
        AdvancedSettings.Name = "AdvancedSettings";
        AdvancedSettings.Size = new System.Drawing.Size(781, 409);
        AdvancedSettings.TabIndex = 3;
        AdvancedSettings.Text = "Advanced Settings";
        AdvancedSettings.UseVisualStyleBackColor = true;
        // 
        // btnChooseLogDirectory
        // 
        btnChooseLogDirectory.Location = new System.Drawing.Point(233, 10);
        btnChooseLogDirectory.Name = "btnChooseLogDirectory";
        btnChooseLogDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseLogDirectory.TabIndex = 11;
        btnChooseLogDirectory.Text = "Choose Directory";
        btnChooseLogDirectory.UseVisualStyleBackColor = true;
        btnChooseLogDirectory.Click += btnChooseLogDirectory_Click;
        // 
        // btnCreateLogfile
        // 
        btnCreateLogfile.Location = new System.Drawing.Point(3, 83);
        btnCreateLogfile.Name = "btnCreateLogfile";
        btnCreateLogfile.Size = new System.Drawing.Size(125, 23);
        btnCreateLogfile.TabIndex = 5;
        btnCreateLogfile.Text = "Create New Logfile";
        btnCreateLogfile.UseVisualStyleBackColor = true;
        btnCreateLogfile.Click += btnCreateLogfile_Click;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(3, 39);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 4;
        label2.Text = "Log File Name";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(3, 10);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 3;
        label1.Text = "Log File Directory";
        // 
        // LogFileName
        // 
        LogFileName.Location = new System.Drawing.Point(109, 39);
        LogFileName.Name = "LogFileName";
        LogFileName.Size = new System.Drawing.Size(100, 23);
        LogFileName.TabIndex = 1;
        LogFileName.TextChanged += LogFileName_TextChanged;
        // 
        // LogFileDirectory
        // 
        LogFileDirectory.Location = new System.Drawing.Point(109, 10);
        LogFileDirectory.Name = "LogFileDirectory";
        LogFileDirectory.Size = new System.Drawing.Size(100, 23);
        LogFileDirectory.TabIndex = 0;
        LogFileDirectory.TextChanged += LogFileDirectory_TextChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(tabControl1);
        Text = "Readable Mods";
        tabControl1.ResumeLayout(false);
        SQL.ResumeLayout(false);
        SQL.PerformLayout();
        CSV.ResumeLayout(false);
        CSV.PerformLayout();
        Excel.ResumeLayout(false);
        Excel.PerformLayout();
        AdvancedSettings.ResumeLayout(false);
        AdvancedSettings.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnChooseSqlDataDirectory;
    private System.Windows.Forms.Button btnChooseSqlLogDirectory;
    private System.Windows.Forms.Button btnChooseCsvDirectory;
    private System.Windows.Forms.Button btnChooseExcelDirectory;
    private System.Windows.Forms.Button btnChooseLogDirectory;

    private System.Windows.Forms.Button btnCreateExcel;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox ExcelDirectory;
    private System.Windows.Forms.TextBox ExcelFileName;

    private System.Windows.Forms.Button btnCreateCsvFiles;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox CsvBatchLimit;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox CsvDirectory;

    private System.Windows.Forms.Button btnFillAllTables;

    private System.Windows.Forms.Button btnCreateSqlDatabase;

    private System.Windows.Forms.TextBox SqlDataFileDirectory;
    private System.Windows.Forms.TextBox SqlDatabaseName;
    private System.Windows.Forms.TextBox SqlLogFileDirectory;
    private System.Windows.Forms.TextBox SqlServerName;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Button btnCreateLogfile;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.TabPage Excel;
    private System.Windows.Forms.TabPage AdvancedSettings;
    private System.Windows.Forms.TextBox LogFileDirectory;
    private System.Windows.Forms.TextBox LogFileName;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage SQL;
    private System.Windows.Forms.TabPage CSV;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    #endregion
}