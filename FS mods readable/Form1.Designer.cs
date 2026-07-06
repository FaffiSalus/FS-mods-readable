namespace FS_mods_readable;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
        btnCreateDatabase = new System.Windows.Forms.Button();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        btnChooseDirectory = new System.Windows.Forms.Button();
        textboxDirectory = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textboxServer = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textboxDBName = new System.Windows.Forms.TextBox();
        btnFillTables = new System.Windows.Forms.Button();
        btnCreateCSV = new System.Windows.Forms.Button();
        btnCreateExcel = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btnCreateDatabase
        // 
        btnCreateDatabase.Location = new System.Drawing.Point(12, 131);
        btnCreateDatabase.Name = "btnCreateDatabase";
        btnCreateDatabase.Size = new System.Drawing.Size(113, 34);
        btnCreateDatabase.TabIndex = 4;
        btnCreateDatabase.Text = "Create Database";
        btnCreateDatabase.UseVisualStyleBackColor = true;
        btnCreateDatabase.Click += btnCreateDatabase_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // btnChooseDirectory
        // 
        btnChooseDirectory.Location = new System.Drawing.Point(12, 102);
        btnChooseDirectory.Name = "btnChooseDirectory";
        btnChooseDirectory.Size = new System.Drawing.Size(113, 23);
        btnChooseDirectory.TabIndex = 3;
        btnChooseDirectory.Text = "Choose Directory";
        btnChooseDirectory.UseVisualStyleBackColor = true;
        btnChooseDirectory.Click += btnChooseDirectory_Click;
        // 
        // textboxDirectory
        // 
        textboxDirectory.Location = new System.Drawing.Point(118, 42);
        textboxDirectory.Name = "textboxDirectory";
        textboxDirectory.ReadOnly = true;
        textboxDirectory.Size = new System.Drawing.Size(88, 23);
        textboxDirectory.TabIndex = 3;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 42);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(88, 23);
        label1.TabIndex = 4;
        label1.Text = "Directory";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 9);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(88, 23);
        label2.TabIndex = 5;
        label2.Text = "Servername";
        // 
        // textboxServer
        // 
        textboxServer.Location = new System.Drawing.Point(118, 9);
        textboxServer.Name = "textboxServer";
        textboxServer.Size = new System.Drawing.Size(88, 23);
        textboxServer.TabIndex = 1;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(229, 12);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 7;
        label3.Text = "Databasename";
        // 
        // textboxDBName
        // 
        textboxDBName.Location = new System.Drawing.Point(319, 12);
        textboxDBName.Name = "textboxDBName";
        textboxDBName.Size = new System.Drawing.Size(100, 23);
        textboxDBName.TabIndex = 2;
        // 
        // btnFillTables
        // 
        btnFillTables.Location = new System.Drawing.Point(12, 171);
        btnFillTables.Name = "btnFillTables";
        btnFillTables.Size = new System.Drawing.Size(113, 36);
        btnFillTables.TabIndex = 5;
        btnFillTables.Text = "FillTables";
        btnFillTables.UseVisualStyleBackColor = true;
        btnFillTables.Click += btnFillTables_Click;
        // 
        // btnCreateCSV
        // 
        btnCreateCSV.Location = new System.Drawing.Point(167, 102);
        btnCreateCSV.Name = "btnCreateCSV";
        btnCreateCSV.Size = new System.Drawing.Size(89, 23);
        btnCreateCSV.TabIndex = 8;
        btnCreateCSV.Text = "Create CSV";
        btnCreateCSV.UseVisualStyleBackColor = true;
        btnCreateCSV.Click += btnCreateCSV_Click;
        // 
        // btnCreateExcel
        // 
        btnCreateExcel.Location = new System.Drawing.Point(167, 131);
        btnCreateExcel.Name = "btnCreateExcel";
        btnCreateExcel.Size = new System.Drawing.Size(89, 23);
        btnCreateExcel.TabIndex = 9;
        btnCreateExcel.Text = "Create Excel";
        btnCreateExcel.UseVisualStyleBackColor = true;
        btnCreateExcel.Click += btnCreateExcel_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btnCreateExcel);
        Controls.Add(btnCreateCSV);
        Controls.Add(textboxServer);
        Controls.Add(textboxDBName);
        Controls.Add(label2);
        Controls.Add(btnFillTables);
        Controls.Add(label1);
        Controls.Add(label3);
        Controls.Add(textboxDirectory);
        Controls.Add(btnCreateDatabase);
        Controls.Add(btnChooseDirectory);
        Text = "Readable Mods";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btnCreateExcel;

    private System.Windows.Forms.Button btnCreateCSV;

    private System.Windows.Forms.Button btnFillTables;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textboxDBName;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textboxServer;

    private System.Windows.Forms.TextBox textboxDirectory;

    private System.Windows.Forms.Button btnChooseDirectory;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Button btnCreateDatabase;

    #endregion
}