using System.ComponentModel;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;

namespace FS_mods_to_sql;

public partial class Form1 : Form
{
    private FolderBrowserDialog folderBrowserDialog1;
    string filePath = string.Empty;
    
    public Form1()
    {
        InitializeComponent();
        this.folderBrowserDialog1 = new FolderBrowserDialog();
    }

    private void btnCreateDatabase_Click(object sender, EventArgs e)
    {
        String server = this.textboxServer.Text;
        String db = this.textboxDBName.Text;
        String dir = "D:";
        if (this.textboxDirectory.Text.Length > 0)
        {
            dir = this.textboxDirectory.Text;
        }
        
        CreateDatabase.create(server, db, dir);
    }

    private void btnFileThingy_Click(object sender, EventArgs e)
    {
        var fileContent = string.Empty;

        // Show the FolderBrowserDialog.
        DialogResult result = folderBrowserDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
            filePath = folderBrowserDialog1.SelectedPath;
            this.textboxDirectory.Text = filePath;
        }
    }

}