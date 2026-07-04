using FS_mods_readable.Core;
using FS_mods_readable.Core.SQL;

namespace FS_mods_readable.Skyrim;

public static class Skyrim2Sql
{
    public static void FillWeapons(string server, string db)
    {
        const string tablename = "[dbo].[Weapon]";
        DataTable dataTable = GetData.GetWeapon();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAcousticSpace(string server, string db)
    {
        const string tablename = "[dbo].[AcousticSpace]";
        DataTable dataTable = GetData.GetAcousticSpace();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillActionRecord(string server, string db)
    {
        const string tablename = "[dbo].[ActionRecord]";
        DataTable dataTable = GetData.GetActionRecord();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillActivator(string server, string db)
    {
        const string tablename = "[dbo].[Activator]";
        DataTable dataTable = GetData.GetActivator();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillActorValueInformation(string server, string db)
    {
        const string tablename = "[dbo].[ActorValueInformation]";
        DataTable dataTable = GetData.GetActorValueInformation();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAddonNode(string server, string db)
    {
        const string tablename = "[dbo].[AddonNode]";
        DataTable dataTable = GetData.GetAddonNode();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAlchemicalApparatus(string server, string db)
    {
        const string tablename = "[dbo].[AlchemicalApparatus]";
        DataTable dataTable = GetData.GetAlchemicalApparatus();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAmmunition(string server, string db)
    {
        const string tablename = "[dbo].[Ammunition]";
        DataTable dataTable = GetData.GetAmmunition();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAnimatedObject(string server, string db)
    {
        const string tablename = "[dbo].[AnimatedObject]";
        DataTable dataTable = GetData.GetAnimatedObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAPlacedTrap(string server, string db)
    {
        const string tablename = "[dbo].[APlacedTrap]";
        DataTable dataTable = GetData.GetAPlacedTrap();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillArmor(string server, string db)
    {
        const string tablename = "[dbo].[Armor]";
        DataTable dataTable = GetData.GetArmor();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillArmorAddon(string server, string db)
    {
        const string tablename = "[dbo].[ArmorAddon]";
        DataTable dataTable = GetData.GetArmorAddon();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillArtObject(string server, string db)
    {
        const string tablename = "[dbo].[ArtObject]";
        DataTable dataTable = GetData.GetArtObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAssociationType(string server, string db)
    {
        const string tablename = "[dbo].[AssociationType]";
        DataTable dataTable = GetData.GetAssociationType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillAStoryManagerNode(string server, string db)
    {
        const string tablename = "[dbo].[AStoryManagerNode]";
        DataTable dataTable = GetData.GetAStoryManagerNode();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillBodyPartData(string server, string db)
    {
        const string tablename = "[dbo].[BodyPartData]";
        DataTable dataTable = GetData.GetBodyPartData();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillBook(string server, string db)
    {
        const string tablename = "[dbo].[Book]";
        DataTable dataTable = GetData.GetBook();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }
}