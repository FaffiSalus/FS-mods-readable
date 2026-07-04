namespace FS_mods_to_sql;

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
        btnFileThingy = new System.Windows.Forms.Button();
        textboxDirectory = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        textboxServer = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        textboxDBName = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // btnCreateDatabase
        // 
        btnCreateDatabase.Location = new System.Drawing.Point(6, 140);
        btnCreateDatabase.Name = "btnCreateDatabase";
        btnCreateDatabase.Size = new System.Drawing.Size(125, 34);
        btnCreateDatabase.TabIndex = 0;
        btnCreateDatabase.Text = "Create Database";
        btnCreateDatabase.UseVisualStyleBackColor = true;
        btnCreateDatabase.Click += btnCreateDatabase_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // btnFileThingy
        // 
        btnFileThingy.Location = new System.Drawing.Point(6, 111);
        btnFileThingy.Name = "btnFileThingy";
        btnFileThingy.Size = new System.Drawing.Size(125, 23);
        btnFileThingy.TabIndex = 2;
        btnFileThingy.Text = "Choose Directory";
        btnFileThingy.UseVisualStyleBackColor = true;
        btnFileThingy.Click += btnFileThingy_Click;
        // 
        // textboxDirectory
        // 
        textboxDirectory.Location = new System.Drawing.Point(112, 51);
        textboxDirectory.Name = "textboxDirectory";
        textboxDirectory.ReadOnly = true;
        textboxDirectory.Size = new System.Drawing.Size(100, 23);
        textboxDirectory.TabIndex = 3;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(6, 51);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 4;
        label1.Text = "Directory";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(6, 18);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 5;
        label2.Text = "Servername";
        // 
        // textboxServer
        // 
        textboxServer.Location = new System.Drawing.Point(112, 18);
        textboxServer.Name = "textboxServer";
        textboxServer.Size = new System.Drawing.Size(100, 23);
        textboxServer.TabIndex = 6;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(299, 18);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 7;
        label3.Text = "Databasename";
        // 
        // textboxDBName
        // 
        textboxDBName.Location = new System.Drawing.Point(389, 18);
        textboxDBName.Name = "textboxDBName";
        textboxDBName.Size = new System.Drawing.Size(100, 23);
        textboxDBName.TabIndex = 8;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(textboxDBName);
        Controls.Add(label3);
        Controls.Add(textboxServer);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(textboxDirectory);
        Controls.Add(btnFileThingy);
        Controls.Add(btnCreateDatabase);
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textboxDBName;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textboxServer;

    private System.Windows.Forms.TextBox textboxDirectory;

    private System.Windows.Forms.Button btnFileThingy;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Button btnCreateDatabase;

    #endregion
}