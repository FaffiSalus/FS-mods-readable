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
        ExcelCheckBox = new System.Windows.Forms.CheckBox();
        CsvCheckBox = new System.Windows.Forms.CheckBox();
        SqlCheckBox = new System.Windows.Forms.CheckBox();
        label11 = new System.Windows.Forms.Label();
        btnChooseExcelDirectory = new System.Windows.Forms.Button();
        btnChooseCsvDirectory = new System.Windows.Forms.Button();
        btnExport = new System.Windows.Forms.Button();
        btnChooseSqlLogDirectory = new System.Windows.Forms.Button();
        ExcelFileName = new System.Windows.Forms.TextBox();
        label9 = new System.Windows.Forms.Label();
        ExcelDirectory = new System.Windows.Forms.TextBox();
        btnChooseSqlDataDirectory = new System.Windows.Forms.Button();
        label10 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        CsvBatchLimit = new System.Windows.Forms.TextBox();
        CsvDirectory = new System.Windows.Forms.TextBox();
        btnCreateSqlDatabase = new System.Windows.Forms.Button();
        label8 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        SqlServerName = new System.Windows.Forms.TextBox();
        SqlLogFileDirectory = new System.Windows.Forms.TextBox();
        SqlDatabaseName = new System.Windows.Forms.TextBox();
        SqlDataFileDirectory = new System.Windows.Forms.TextBox();
        AdvancedSettings = new System.Windows.Forms.TabPage();
        btnChooseLogDirectory = new System.Windows.Forms.Button();
        btnCreateLogfile = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        LogFileName = new System.Windows.Forms.TextBox();
        LogFileDirectory = new System.Windows.Forms.TextBox();
        tabControl1.SuspendLayout();
        SQL.SuspendLayout();
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
        tabControl1.Controls.Add(AdvancedSettings);
        tabControl1.Location = new System.Drawing.Point(12, 12);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new System.Drawing.Size(789, 534);
        tabControl1.TabIndex = 10;
        // 
        // SQL
        // 
        SQL.Controls.Add(ExcelCheckBox);
        SQL.Controls.Add(CsvCheckBox);
        SQL.Controls.Add(SqlCheckBox);
        SQL.Controls.Add(label11);
        SQL.Controls.Add(btnChooseExcelDirectory);
        SQL.Controls.Add(btnChooseCsvDirectory);
        SQL.Controls.Add(btnExport);
        SQL.Controls.Add(btnChooseSqlLogDirectory);
        SQL.Controls.Add(ExcelFileName);
        SQL.Controls.Add(label9);
        SQL.Controls.Add(ExcelDirectory);
        SQL.Controls.Add(btnChooseSqlDataDirectory);
        SQL.Controls.Add(label10);
        SQL.Controls.Add(label7);
        SQL.Controls.Add(CsvBatchLimit);
        SQL.Controls.Add(CsvDirectory);
        SQL.Controls.Add(btnCreateSqlDatabase);
        SQL.Controls.Add(label8);
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
        SQL.Size = new System.Drawing.Size(781, 506);
        SQL.TabIndex = 0;
        SQL.Text = "SQL";
        SQL.UseVisualStyleBackColor = true;
        // 
        // ExcelCheckBox
        // 
        ExcelCheckBox.Location = new System.Drawing.Point(508, 98);
        ExcelCheckBox.Name = "ExcelCheckBox";
        ExcelCheckBox.Size = new System.Drawing.Size(104, 24);
        ExcelCheckBox.TabIndex = 17;
        ExcelCheckBox.Text = "Excel";
        ExcelCheckBox.UseVisualStyleBackColor = true;
        ExcelCheckBox.CheckedChanged += ExcelCheckBox_CheckedChanged;
        // 
        // CsvCheckBox
        // 
        CsvCheckBox.Location = new System.Drawing.Point(508, 68);
        CsvCheckBox.Name = "CsvCheckBox";
        CsvCheckBox.Size = new System.Drawing.Size(104, 24);
        CsvCheckBox.TabIndex = 16;
        CsvCheckBox.Text = "CSV";
        CsvCheckBox.UseVisualStyleBackColor = true;
        CsvCheckBox.CheckedChanged += CsvCheckBox_CheckedChanged;
        // 
        // SqlCheckBox
        // 
        SqlCheckBox.Location = new System.Drawing.Point(508, 38);
        SqlCheckBox.Name = "SqlCheckBox";
        SqlCheckBox.Size = new System.Drawing.Size(104, 24);
        SqlCheckBox.TabIndex = 15;
        SqlCheckBox.Text = "SQL";
        SqlCheckBox.UseVisualStyleBackColor = true;
        SqlCheckBox.CheckedChanged += SqlCheckBox_CheckedChanged;
        // 
        // label11
        // 
        label11.Location = new System.Drawing.Point(508, 12);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(100, 23);
        label11.TabIndex = 14;
        label11.Text = "Export Mods to";
        // 
        // btnChooseExcelDirectory
        // 
        btnChooseExcelDirectory.Location = new System.Drawing.Point(281, 199);
        btnChooseExcelDirectory.Name = "btnChooseExcelDirectory";
        btnChooseExcelDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseExcelDirectory.TabIndex = 11;
        btnChooseExcelDirectory.Text = "Choose Directory";
        btnChooseExcelDirectory.UseVisualStyleBackColor = true;
        btnChooseExcelDirectory.Click += btnChooseExcelDirectory_Click;
        // 
        // btnChooseCsvDirectory
        // 
        btnChooseCsvDirectory.Location = new System.Drawing.Point(281, 135);
        btnChooseCsvDirectory.Name = "btnChooseCsvDirectory";
        btnChooseCsvDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseCsvDirectory.TabIndex = 11;
        btnChooseCsvDirectory.Text = "Choose Directory";
        btnChooseCsvDirectory.UseVisualStyleBackColor = true;
        btnChooseCsvDirectory.Click += btnChooseCsvDirectory_Click;
        // 
        // btnExport
        // 
        btnExport.Location = new System.Drawing.Point(508, 144);
        btnExport.Name = "btnExport";
        btnExport.Size = new System.Drawing.Size(85, 23);
        btnExport.TabIndex = 12;
        btnExport.Text = "Export Mods";
        btnExport.UseVisualStyleBackColor = true;
        btnExport.Click += btnExport_Click;
        // 
        // btnChooseSqlLogDirectory
        // 
        btnChooseSqlLogDirectory.Location = new System.Drawing.Point(281, 43);
        btnChooseSqlLogDirectory.Name = "btnChooseSqlLogDirectory";
        btnChooseSqlLogDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseSqlLogDirectory.TabIndex = 11;
        btnChooseSqlLogDirectory.Text = "Choose Directory";
        btnChooseSqlLogDirectory.UseVisualStyleBackColor = true;
        btnChooseSqlLogDirectory.Click += btnChooseSqlLogDirectory_Click;
        // 
        // ExcelFileName
        // 
        ExcelFileName.Location = new System.Drawing.Point(162, 231);
        ExcelFileName.Name = "ExcelFileName";
        ExcelFileName.ReadOnly = true;
        ExcelFileName.Size = new System.Drawing.Size(100, 23);
        ExcelFileName.TabIndex = 3;
        ExcelFileName.TextChanged += ExcelFileName_TextChanged;
        // 
        // label9
        // 
        label9.Location = new System.Drawing.Point(6, 199);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(127, 32);
        label9.TabIndex = 0;
        label9.Text = "Excel Directory";
        // 
        // ExcelDirectory
        // 
        ExcelDirectory.Location = new System.Drawing.Point(162, 199);
        ExcelDirectory.Name = "ExcelDirectory";
        ExcelDirectory.ReadOnly = true;
        ExcelDirectory.Size = new System.Drawing.Size(100, 23);
        ExcelDirectory.TabIndex = 2;
        ExcelDirectory.TextChanged += ExcelDirectory_TextChanged;
        // 
        // btnChooseSqlDataDirectory
        // 
        btnChooseSqlDataDirectory.Location = new System.Drawing.Point(281, 12);
        btnChooseSqlDataDirectory.Name = "btnChooseSqlDataDirectory";
        btnChooseSqlDataDirectory.Size = new System.Drawing.Size(114, 23);
        btnChooseSqlDataDirectory.TabIndex = 10;
        btnChooseSqlDataDirectory.Text = "Choose Directory";
        btnChooseSqlDataDirectory.UseVisualStyleBackColor = true;
        btnChooseSqlDataDirectory.Click += btnChooseSqlDataDirectory_Click;
        // 
        // label10
        // 
        label10.Location = new System.Drawing.Point(6, 231);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(127, 32);
        label10.TabIndex = 1;
        label10.Text = "Excel File Name";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(6, 135);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(127, 32);
        label7.TabIndex = 0;
        label7.Text = "Csv Directory";
        // 
        // CsvBatchLimit
        // 
        CsvBatchLimit.Location = new System.Drawing.Point(162, 167);
        CsvBatchLimit.Name = "CsvBatchLimit";
        CsvBatchLimit.ReadOnly = true;
        CsvBatchLimit.Size = new System.Drawing.Size(100, 23);
        CsvBatchLimit.TabIndex = 3;
        CsvBatchLimit.TextChanged += CsvBatchLimit_TextChanged;
        // 
        // CsvDirectory
        // 
        CsvDirectory.Location = new System.Drawing.Point(162, 135);
        CsvDirectory.Name = "CsvDirectory";
        CsvDirectory.ReadOnly = true;
        CsvDirectory.Size = new System.Drawing.Size(100, 23);
        CsvDirectory.TabIndex = 1;
        // 
        // btnCreateSqlDatabase
        // 
        btnCreateSqlDatabase.Location = new System.Drawing.Point(281, 104);
        btnCreateSqlDatabase.Name = "btnCreateSqlDatabase";
        btnCreateSqlDatabase.Size = new System.Drawing.Size(114, 23);
        btnCreateSqlDatabase.TabIndex = 8;
        btnCreateSqlDatabase.Text = "Create Database";
        btnCreateSqlDatabase.UseVisualStyleBackColor = true;
        btnCreateSqlDatabase.Click += btnCreateSqlDatabase_Click;
        // 
        // label8
        // 
        label8.Location = new System.Drawing.Point(6, 167);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(127, 32);
        label8.TabIndex = 2;
        label8.Text = "Csv Batch Limit";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(6, 108);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(127, 32);
        label6.TabIndex = 7;
        label6.Text = "SQL Database Name";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(6, 76);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(127, 32);
        label5.TabIndex = 6;
        label5.Text = "SQL Servername";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(6, 44);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(127, 32);
        label4.TabIndex = 5;
        label4.Text = "SQL Log File Directory";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(6, 12);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(127, 32);
        label3.TabIndex = 4;
        label3.Text = "SQL Data File Directory";
        // 
        // SqlServerName
        // 
        SqlServerName.Location = new System.Drawing.Point(162, 73);
        SqlServerName.Name = "SqlServerName";
        SqlServerName.ReadOnly = true;
        SqlServerName.Size = new System.Drawing.Size(100, 23);
        SqlServerName.TabIndex = 3;
        SqlServerName.TextChanged += SqlServerName_TextChanged;
        // 
        // SqlLogFileDirectory
        // 
        SqlLogFileDirectory.Location = new System.Drawing.Point(162, 44);
        SqlLogFileDirectory.Name = "SqlLogFileDirectory";
        SqlLogFileDirectory.ReadOnly = true;
        SqlLogFileDirectory.Size = new System.Drawing.Size(100, 23);
        SqlLogFileDirectory.TabIndex = 2;
        SqlLogFileDirectory.TextChanged += SqlLogFileDirectory_TextChanged;
        // 
        // SqlDatabaseName
        // 
        SqlDatabaseName.Location = new System.Drawing.Point(162, 105);
        SqlDatabaseName.Name = "SqlDatabaseName";
        SqlDatabaseName.ReadOnly = true;
        SqlDatabaseName.Size = new System.Drawing.Size(100, 23);
        SqlDatabaseName.TabIndex = 1;
        SqlDatabaseName.TextChanged += SqlDatabaseName_TextChanged;
        // 
        // SqlDataFileDirectory
        // 
        SqlDataFileDirectory.Location = new System.Drawing.Point(162, 12);
        SqlDataFileDirectory.Name = "SqlDataFileDirectory";
        SqlDataFileDirectory.ReadOnly = true;
        SqlDataFileDirectory.Size = new System.Drawing.Size(100, 23);
        SqlDataFileDirectory.TabIndex = 0;
        SqlDataFileDirectory.TextChanged += SqlDataFileDirectory_TextChanged;
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
        AdvancedSettings.Size = new System.Drawing.Size(781, 506);
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
        ClientSize = new System.Drawing.Size(801, 558);
        Controls.Add(tabControl1);
        Text = "Readable Mods";
        tabControl1.ResumeLayout(false);
        SQL.ResumeLayout(false);
        SQL.PerformLayout();
        AdvancedSettings.ResumeLayout(false);
        AdvancedSettings.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.CheckBox SqlCheckBox;
    private System.Windows.Forms.CheckBox CsvCheckBox;
    private System.Windows.Forms.CheckBox ExcelCheckBox;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Button btnExport;

    private System.Windows.Forms.Button btnChooseSqlDataDirectory;
    private System.Windows.Forms.Button btnChooseSqlLogDirectory;
    private System.Windows.Forms.Button btnChooseCsvDirectory;
    private System.Windows.Forms.Button btnChooseExcelDirectory;
    private System.Windows.Forms.Button btnChooseLogDirectory;

    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox ExcelDirectory;
    private System.Windows.Forms.TextBox ExcelFileName;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox CsvBatchLimit;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox CsvDirectory;

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

    private System.Windows.Forms.TabPage AdvancedSettings;
    private System.Windows.Forms.TextBox LogFileDirectory;
    private System.Windows.Forms.TextBox LogFileName;

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage SQL;

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    #endregion
}