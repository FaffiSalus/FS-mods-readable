using FS_mods_to_sql.Core;
using FS_mods_to_sql.Skyrim;

namespace FS_mods_to_sql;

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
        var fileContent = string.Empty;

        // Show the FolderBrowserDialog.
        DialogResult result = _folderBrowserDialog1.ShowDialog();
        if (result == DialogResult.OK)
        {
            _filePath = _folderBrowserDialog1.SelectedPath;
            this.textboxDirectory.Text = _filePath;
        }
    }

    private void btnFillTables_Click(object sender, EventArgs e)
    {
        String server = this.textboxServer.Text;
        String db = this.textboxDBName.Text;
        GetData.FillWeapons(server, db);
    }
}