using FS_mods_readable.Core;
using FS_mods_readable.Core.SQL;
using FS_mods_readable.Skyrim;

namespace FS_mods_readable;

public partial class Form1 : Form
{
    private readonly FolderBrowserDialog _folderBrowserDialog1;
    private string _filePath = string.Empty;
    
    public Form1()
    {
        InitializeComponent();
        this._folderBrowserDialog1 = new FolderBrowserDialog();
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
        
        CreateDatabase.Create(server, db, dir);
    }

    private void btnFileThingy_Click(object sender, EventArgs e)
    {
        DialogResult result = _folderBrowserDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
            _filePath = _folderBrowserDialog1.SelectedPath;
            textboxDirectory.Text = _filePath;
        }
    }

    private void btnFillTables_Click(object sender, EventArgs e)
    {
        String server = this.textboxServer.Text;
        String db = this.textboxDBName.Text;
        Skyrim2Sql.FillAllTables(server, db);
    }

    private void btnCreateCSV_Click(object sender, EventArgs e)
    {
        if (textboxDirectory.Text == String.Empty)
        {
            throw new Exception("Please specify a directory path");
        }

        Skyrim2Csv.FillAllFiles(textboxDirectory.Text);
    }

}