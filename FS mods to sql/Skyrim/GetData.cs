using FS_mods_to_sql.Core;

namespace FS_mods_to_sql.Skyrim;

public static class GetData
{
    public static void FillWeapons(string server, string db)
    {
        const string tablename = "[dbo].[Weapon]";
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        DataTable dataTable = CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Weapon().WinningOverrides());
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }
}