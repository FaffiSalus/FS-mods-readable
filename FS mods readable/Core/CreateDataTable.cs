namespace FS_mods_readable.Core;

public static class CreateDataTable
{
    public static DataTable CreateTable(IEnumerable<IMajorRecordGetter> recordGetters)
    {
        DataTable dataTable = new DataTable();
        bool firstRun = true;
        int counter = 0;
        foreach (var rec in recordGetters)
        {
            if (firstRun)
            {
                foreach (var field in rec.GetType().GetProperties())
                {
                    DataColumn dataColumn = new DataColumn(field.Name);
                    dataColumn.AllowDBNull = true;
                    dataTable.Columns.Add(dataColumn);
                    firstRun = false;
                }
            }
            var i = 0;
            var max = rec.GetType().GetProperties().Length;
            var fieldData = new string?[max];
            foreach (var field in rec.GetType().GetProperties())
            {
                fieldData[i] = field.GetValue(rec)?.ToString();
                i++;
            }
            dataTable.Rows.Add(fieldData);
            counter++;
        }
        MessageBox.Show(counter.ToString());
        return dataTable;
    }
}