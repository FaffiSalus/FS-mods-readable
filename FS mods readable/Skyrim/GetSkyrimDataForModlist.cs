using FS_mods_readable.Core;
using FS_mods_readable.Core.CSV;
using FS_mods_readable.Core.Excel;
using FS_mods_readable.Core.SQL;

namespace FS_mods_readable.Skyrim;

public static class GetSkyrimDataForModlist
{
    public static void GetAll()
    {
        var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        // var priorityOrder = env.LoadOrder.PriorityOrder;
        // MessageBox.Show(priorityOrder.GetType().ToString());
        // foreach (var method in priorityOrder.GetType().GetProperties())
        // {
        //     if (method.GetType() == typeof(TopLevelTypedLoadOrderAccess<ISkyrimMod, ISkyrimModGetter, IWeapon, IWeaponGetter>))
        //     {
        //         var newTables =
        //             CreateDataTable.CreateDataTables(method.GetValue(priorityOrder) as IEnumerable<IMajorRecordGetter> ?? []);
        //         foreach (var dataTable in newTables)
        //         {
        //             CreateAndFillTables.CreateTable(dataTable);
        //             CreateAndFillTables.FillTable(dataTable);
        //         }
        //     }
        // }
        //TODO: figure out how to actually do this dynamically

        foreach (var method in typeof(GetSkyrimDataForModlist).GetMethods())
        {
            if (method.Name == "GetAll") continue;
            if (method.ReturnType != typeof(List<DataTable>)) continue;
            var dataTables = (List<DataTable>)method.Invoke(null, [env])!;
            foreach (var dataTable in dataTables)
            {
                if (bool.Parse(ConfigHandler.GetSql()!))
                {
                    CreateAndFillTables.CreateTable(dataTable);
                    CreateAndFillTables.FillTable(dataTable);
                }

                if (bool.Parse(ConfigHandler.GetCsv()!)) CreateAndFillCsvFile.CreateAndFill(dataTable);

                if (bool.Parse(ConfigHandler.GetExcel()!)) CreateAndFillExcelFile.CreateAndFill(dataTable);
            }
        }
    }

    public static List<DataTable> GetWeapon(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Weapon().WinningOverrides());
    }

    public static List<DataTable> GetAcousticSpace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.AcousticSpace().WinningOverrides());
    }

    public static List<DataTable> GetActionRecord(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ActionRecord().WinningOverrides());
    }

    public static List<DataTable> GetActivator(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Activator().WinningOverrides());
    }

    public static List<DataTable> GetActorValueInformation(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ActorValueInformation().WinningOverrides());
    }

    public static List<DataTable> GetAddonNode(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.AddonNode().WinningOverrides());
    }

    public static List<DataTable> GetAlchemicalApparatus(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.AlchemicalApparatus().WinningOverrides());
    }

    public static List<DataTable> GetAmmunition(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Ammunition().WinningOverrides());
    }

    public static List<DataTable> GetAnimatedObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.AnimatedObject().WinningOverrides());
    }

    public static List<DataTable> GetAPlacedTrap(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.APlacedTrap().WinningOverrides());
    }

    public static List<DataTable> GetArmor(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Armor().WinningOverrides());
    }

    public static List<DataTable> GetArmorAddon(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ArmorAddon().WinningOverrides());
    }

    public static List<DataTable> GetArtObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ArtObject().WinningOverrides());
    }

    public static List<DataTable> GetAssociationType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.AssociationType().WinningOverrides());
    }

    public static List<DataTable> GetAStoryManagerNode(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.AStoryManagerNode().WinningOverrides());
    }

    public static List<DataTable> GetBodyPartData(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.BodyPartData().WinningOverrides());
    }

    public static List<DataTable> GetBook(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Book().WinningOverrides());
    }

    public static List<DataTable> GetCameraPath(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.CameraPath().WinningOverrides());
    }

    public static List<DataTable> GetCameraShot(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.CameraShot().WinningOverrides());
    }

    public static List<DataTable> GetCell(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Cell().WinningOverrides());
    }

    public static List<DataTable> GetClass(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Class().WinningOverrides());
    }

    public static List<DataTable> GetClimate(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Climate().WinningOverrides());
    }

    public static List<DataTable> GetCollisionLayer(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.CollisionLayer().WinningOverrides());
    }

    public static List<DataTable> GetColorRecord(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ColorRecord().WinningOverrides());
    }

    public static List<DataTable> GetCombatStyle(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.CombatStyle().WinningOverrides());
    }

    public static List<DataTable> GetConstructibleObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ConstructibleObject().WinningOverrides());
    }

    public static List<DataTable> GetContainer(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Container().WinningOverrides());
    }

    public static List<DataTable> GetDebris(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Debris().WinningOverrides());
    }

    public static List<DataTable> GetDefaultObjectManager(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.DefaultObjectManager().WinningOverrides());
    }

    public static List<DataTable> GetDialogBranch(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.DialogBranch().WinningOverrides());
    }

    public static List<DataTable> GetDialogResponses(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.DialogResponses().WinningOverrides());
    }

    public static List<DataTable> GetDialogTopic(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.DialogTopic().WinningOverrides());
    }

    public static List<DataTable> GetDialogView(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.DialogView().WinningOverrides());
    }

    public static List<DataTable> GetDoor(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Door().WinningOverrides());
    }

    public static List<DataTable> GetDualCastData(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.DualCastData().WinningOverrides());
    }

    public static List<DataTable> GetEffectShader(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.EffectShader().WinningOverrides());
    }

    public static List<DataTable> GetEncounterZone(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.EncounterZone().WinningOverrides());
    }

    public static List<DataTable> GetEquipType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.EquipType().WinningOverrides());
    }

    public static List<DataTable> GetExplosion(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Explosion().WinningOverrides());
    }

    public static List<DataTable> GetEyes(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Eyes().WinningOverrides());
    }

    public static List<DataTable> GetFaction(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Faction().WinningOverrides());
    }

    public static List<DataTable> GetFlora(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Flora().WinningOverrides());
    }

    public static List<DataTable> GetFootstep(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Footstep().WinningOverrides());
    }

    public static List<DataTable> GetFootstepSet(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.FootstepSet().WinningOverrides());
    }

    public static List<DataTable> GetFormList(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.FormList().WinningOverrides());
    }

    public static List<DataTable> GetFurniture(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Furniture().WinningOverrides());
    }

    public static List<DataTable> GetGameSetting(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.GameSetting().WinningOverrides());
    }

    public static List<DataTable> GetGlobal(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Global().WinningOverrides());
    }

    public static List<DataTable> GetGrass(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Grass().WinningOverrides());
    }

    public static List<DataTable> GetHair(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Hair().WinningOverrides());
    }

    public static List<DataTable> GetHazard(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Hazard().WinningOverrides());
    }

    public static List<DataTable> GetHeadPart(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.HeadPart().WinningOverrides());
    }

    public static List<DataTable> GetIdleAnimation(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.IdleAnimation().WinningOverrides());
    }

    public static List<DataTable> GetIdleMarker(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.IdleMarker().WinningOverrides());
    }

    public static List<DataTable> GetImageSpace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ImageSpace().WinningOverrides());
    }

    public static List<DataTable> GetImageSpaceAdapter(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ImageSpaceAdapter().WinningOverrides());
    }

    public static List<DataTable> GetImpact(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Impact().WinningOverrides());
    }

    public static List<DataTable> GetImpactDataSet(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ImpactDataSet().WinningOverrides());
    }

    public static List<DataTable> GetIngestible(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Ingestible().WinningOverrides());
    }

    public static List<DataTable> GetIngredient(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Ingredient().WinningOverrides());
    }

    public static List<DataTable> GetKey(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Key().WinningOverrides());
    }

    public static List<DataTable> GetKeyword(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Keyword().WinningOverrides());
    }

    public static List<DataTable> GetLandscape(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Landscape().WinningOverrides());
    }

    public static List<DataTable> GetLandscapeTexture(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LandscapeTexture().WinningOverrides());
    }

    public static List<DataTable> GetLensFlare(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LensFlare().WinningOverrides());
    }

    public static List<DataTable> GetLeveledItem(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides());
    }

    public static List<DataTable> GetLeveledNpc(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LeveledNpc().WinningOverrides());
    }

    public static List<DataTable> GetLeveledSpell(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LeveledSpell().WinningOverrides());
    }

    public static List<DataTable> GetLight(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Light().WinningOverrides());
    }

    public static List<DataTable> GetLightingTemplate(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LightingTemplate().WinningOverrides());
    }

    public static List<DataTable> GetLoadScreen(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LoadScreen().WinningOverrides());
    }

    public static List<DataTable> GetLocation(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Location().WinningOverrides());
    }

    public static List<DataTable> GetLocationReferenceType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.LocationReferenceType().WinningOverrides());
    }

    public static List<DataTable> GetMagicEffect(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MagicEffect().WinningOverrides());
    }

    public static List<DataTable> GetMaterialObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MaterialObject().WinningOverrides());
    }

    public static List<DataTable> GetMaterialType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MaterialType().WinningOverrides());
    }

    public static List<DataTable> GetMessage(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Message().WinningOverrides());
    }

    public static List<DataTable> GetMiscItem(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MiscItem().WinningOverrides());
    }

    public static List<DataTable> GetMoveableStatic(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MoveableStatic().WinningOverrides());
    }

    public static List<DataTable> GetMovementType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MovementType().WinningOverrides());
    }

    public static List<DataTable> GetMusicTrack(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MusicTrack().WinningOverrides());
    }

    public static List<DataTable> GetMusicType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.MusicType().WinningOverrides());
    }

    public static List<DataTable> GetNavigationMesh(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.NavigationMesh().WinningOverrides());
    }

    public static List<DataTable> GetNavigationMeshInfoMap(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.NavigationMeshInfoMap().WinningOverrides());
    }

    public static List<DataTable> GetNpc(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Npc().WinningOverrides());
    }

    public static List<DataTable> GetObjectEffect(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ObjectEffect().WinningOverrides());
    }

    public static List<DataTable> GetOutfit(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Outfit().WinningOverrides());
    }

    public static List<DataTable> GetPackage(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Package().WinningOverrides());
    }

    public static List<DataTable> GetPerk(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Perk().WinningOverrides());
    }

    public static List<DataTable> GetPlacedNpc(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.PlacedNpc().WinningOverrides());
    }

    public static List<DataTable> GetPlacedObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.PlacedObject().WinningOverrides());
    }

    public static List<DataTable> GetProjectile(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Projectile().WinningOverrides());
    }

    public static List<DataTable> GetQuest(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Quest().WinningOverrides());
    }

    public static List<DataTable> GetRace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Race().WinningOverrides());
    }

    public static List<DataTable> GetRegion(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Region().WinningOverrides());
    }

    public static List<DataTable> GetRelationship(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Relationship().WinningOverrides());
    }

    public static List<DataTable> GetReverbParameters(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ReverbParameters().WinningOverrides());
    }

    public static List<DataTable> GetScene(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Scene().WinningOverrides());
    }

    public static List<DataTable> GetScroll(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Scroll().WinningOverrides());
    }

    public static List<DataTable> GetShaderParticleGeometry(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.ShaderParticleGeometry()
            .WinningOverrides());
    }

    public static List<DataTable> GetShout(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Shout().WinningOverrides());
    }

    public static List<DataTable> GetSoulGem(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.SoulGem().WinningOverrides());
    }

    public static List<DataTable> GetSoundCategory(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.SoundCategory().WinningOverrides());
    }

    public static List<DataTable> GetSoundDescriptor(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.SoundDescriptor().WinningOverrides());
    }

    public static List<DataTable> GetSoundMarker(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.SoundMarker().WinningOverrides());
    }

    public static List<DataTable> GetSoundOutputModel(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.SoundOutputModel().WinningOverrides());
    }

    public static List<DataTable> GetSpell(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Spell().WinningOverrides());
    }

    public static List<DataTable> GetStatic(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Static().WinningOverrides());
    }

    public static List<DataTable> GetTalkingActivator(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.TalkingActivator().WinningOverrides());
    }

    public static List<DataTable> GetTextureSet(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.TextureSet().WinningOverrides());
    }

    public static List<DataTable> GetTree(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Tree().WinningOverrides());
    }

    public static List<DataTable> GetVisualEffect(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.VisualEffect().WinningOverrides());
    }

    public static List<DataTable> GetVoiceType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.VoiceType().WinningOverrides());
    }

    public static List<DataTable> GetVolumetricLighting(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.VolumetricLighting().WinningOverrides());
    }

    public static List<DataTable> GetWater(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Water().WinningOverrides());
    }

    public static List<DataTable> GetWeather(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Weather().WinningOverrides());
    }

    public static List<DataTable> GetWordOfPower(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.WordOfPower().WinningOverrides());
    }

    public static List<DataTable> GetWorldSpace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env)
    {
        return CreateDataTable.CreateDataTables(env.LoadOrder.PriorityOrder.Worldspace().WinningOverrides());
    }
}