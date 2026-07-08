using FS_mods_readable.Core;
using FS_mods_readable.Core.CSV;
using FS_mods_readable.Core.Excel;
using FS_mods_readable.Core.SQL;

namespace FS_mods_readable.Skyrim;

public static class GetSkyrimDataForSpecificMod
{
    public static void GetAll(List<string> mods)
    {
        var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        var originalExcelFileName = ConfigHandler.GetExcelFileName();
        var originalCsvDirectory = ConfigHandler.GetCsvDirectory();

        foreach (var mod in mods)
        {
            var readableMod = mod[..mod.IndexOf('.')];
            readableMod = string.Concat(readableMod.Split('@', ',', '.', ';', '\'', ' ', '-', '0', '1', '2', '3', '4',
                '5', '6', '7', '8', '9', '0'));
            ConfigHandler.SetCsvDirectory(originalCsvDirectory + "\\" + readableMod);
            Directory.CreateDirectory(originalCsvDirectory + "\\" + readableMod);
            ConfigHandler.SetExcelFileName(originalExcelFileName + "_" + readableMod);
            foreach (var method in typeof(GetSkyrimDataForSpecificMod).GetMethods())
            {
                if (method.Name == "GetAll") continue;
                if (method.ReturnType != typeof(List<DataTable>)) continue;
                var dataTables = (List<DataTable>)method.Invoke(null, [env, mod])!;
                foreach (var dataTable in dataTables)
                {
                    if (bool.Parse(ConfigHandler.GetSql()!))
                    {
                        CreateAndFillTables.CreateTable(dataTable, readableMod + "_");
                        CreateAndFillTables.FillTable(dataTable, readableMod + "_");
                    }
                    
                    if (bool.Parse(ConfigHandler.GetCsv()!)) CreateAndFillCsvFile.CreateAndFill(dataTable);

                    if (bool.Parse(ConfigHandler.GetExcel()!)) CreateAndFillExcelFile.CreateAndFill(dataTable);
                }
            }
        }
        ConfigHandler.SetCsvDirectory(originalCsvDirectory);
        ConfigHandler.SetExcelFileName(originalExcelFileName);
    }

    public static List<DataTable> GetWeapon(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        Path.Combine(mod, mod);
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Weapons);
    }

    public static List<DataTable> GetAcousticSpace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).AcousticSpaces);
    }

    public static List<DataTable> GetActionRecord(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Actions);
    }

    public static List<DataTable> GetActivator(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Activators);
    }

    public static List<DataTable> GetActorValueInformation(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ActorValueInformation);
    }

    public static List<DataTable> GetAddonNode(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).AddonNodes);
    }

    public static List<DataTable> GetAlchemicalApparatus(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).AlchemicalApparatuses);
    }

    public static List<DataTable> GetAmmunition(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Ammunitions);
    }

    public static List<DataTable> GetAnimatedObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).AnimatedObjects);
    }

    public static List<DataTable> GetArmor(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Armors);
    }

    public static List<DataTable> GetArmorAddon(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ArmorAddons);
    }

    public static List<DataTable> GetArtObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ArtObjects);
    }

    public static List<DataTable> GetAssociationType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).AssociationTypes);
    }

    public static List<DataTable> GetStoryManagerBranchNodes(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).StoryManagerBranchNodes);
    }
    
    public static List<DataTable> GetStoryManagerEventNodes(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).StoryManagerEventNodes);
    }
    
    public static List<DataTable> GetStoryManagerQuestNodes(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).StoryManagerQuestNodes);
    }

    public static List<DataTable> GetBodyPartData(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).BodyParts);
    }

    public static List<DataTable> GetBook(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Books);
    }

    public static List<DataTable> GetCameraPath(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).CameraPaths);
    }

    public static List<DataTable> GetCameraShot(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).CameraShots);
    }

    // public static List<DataTable> GetCell(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    // {
    //     return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Cells); -> Wrong Type
    // }

    public static List<DataTable> GetClass(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Classes);
    }

    public static List<DataTable> GetClimate(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Climates);
    }

    public static List<DataTable> GetCollisionLayer(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).CollisionLayers);
    }

    public static List<DataTable> GetColorRecord(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Colors);
    }

    public static List<DataTable> GetCombatStyle(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).CombatStyles);
    }

    public static List<DataTable> GetConstructibleObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ConstructibleObjects);
    }

    public static List<DataTable> GetContainer(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Containers);
    }

    public static List<DataTable> GetDebris(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Debris);
    }

    public static List<DataTable> GetDefaultObjectManager(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).DefaultObjectManagers);
    }

    public static List<DataTable> GetDialogBranch(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).DialogBranches);
    }

    public static List<DataTable> GetDialogTopic(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).DialogTopics);
    }

    public static List<DataTable> GetDialogView(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).DialogViews);
    }

    public static List<DataTable> GetDoor(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Doors);
    }

    public static List<DataTable> GetDualCastData(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).DualCastData);
    }

    public static List<DataTable> GetEffectShader(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).EffectShaders);
    }

    public static List<DataTable> GetEncounterZone(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).EncounterZones);
    }

    public static List<DataTable> GetEquipType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).EquipTypes);
    }

    public static List<DataTable> GetExplosion(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Explosions);
    }

    public static List<DataTable> GetEyes(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Eyes);
    }

    public static List<DataTable> GetFaction(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Factions);
    }

    public static List<DataTable> GetFlora(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Florae);
    }

    public static List<DataTable> GetFootstep(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Footsteps);
    }

    public static List<DataTable> GetFootstepSet(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).FootstepSets);
    }

    public static List<DataTable> GetFormList(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).FormLists);
    }

    public static List<DataTable> GetFurniture(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Furniture);
    }

    public static List<DataTable> GetGameSetting(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).GameSettings);
    }

    public static List<DataTable> GetGlobal(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Globals);
    }

    public static List<DataTable> GetGrass(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Grasses);
    }

    public static List<DataTable> GetHair(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Hairs);
    }

    public static List<DataTable> GetHazard(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Hazards);
    }

    public static List<DataTable> GetHeadPart(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).HeadParts);
    }

    public static List<DataTable> GetIdleAnimation(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).IdleAnimations);
    }

    public static List<DataTable> GetIdleMarker(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).IdleMarkers);
    }

    public static List<DataTable> GetImageSpace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ImageSpaces);
    }

    public static List<DataTable> GetImageSpaceAdapter(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ImageSpaceAdapters);
    }

    public static List<DataTable> GetImpact(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Impacts);
    }

    public static List<DataTable> GetImpactDataSet(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ImpactDataSets);
    }

    public static List<DataTable> GetIngestible(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Ingestibles);
    }

    public static List<DataTable> GetIngredient(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Ingredients);
    }

    public static List<DataTable> GetKey(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Keys);
    }

    public static List<DataTable> GetKeyword(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Keywords);
    }

    public static List<DataTable> GetLandscapeTexture(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LandscapeTextures);
    }

    public static List<DataTable> GetLensFlare(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LensFlares);
    }

    public static List<DataTable> GetLeveledItem(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LeveledItems);
    }

    public static List<DataTable> GetLeveledNpc(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LeveledNpcs);
    }

    public static List<DataTable> GetLeveledSpell(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LeveledSpells);
    }

    public static List<DataTable> GetLight(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Lights);
    }

    public static List<DataTable> GetLightingTemplate(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LightingTemplates);
    }

    public static List<DataTable> GetLoadScreen(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LoadScreens);
    }

    public static List<DataTable> GetLocation(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Locations);
    }

    public static List<DataTable> GetLocationReferenceType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).LocationReferenceTypes);
    }

    public static List<DataTable> GetMagicEffect(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MagicEffects);
    }

    public static List<DataTable> GetMaterialObject(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MaterialObjects);
    }

    public static List<DataTable> GetMaterialType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MaterialTypes);
    }

    public static List<DataTable> GetMessage(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Messages);
    }

    public static List<DataTable> GetMiscItem(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MiscItems);
    }

    public static List<DataTable> GetMoveableStatic(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MoveableStatics);
    }

    public static List<DataTable> GetMovementType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MovementTypes);
    }

    public static List<DataTable> GetMusicTrack(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MusicTracks);
    }

    public static List<DataTable> GetMusicType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).MusicTypes);
    }

    public static List<DataTable> GetNavigationMeshInfoMap(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).NavigationMeshInfoMaps);
    }

    public static List<DataTable> GetNpc(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Npcs);
    }

    public static List<DataTable> GetObjectEffect(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ObjectEffects);
    }

    public static List<DataTable> GetOutfit(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Outfits);
    }

    public static List<DataTable> GetPackage(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Packages);
    }

    public static List<DataTable> GetPerk(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Perks);
    }

    public static List<DataTable> GetProjectile(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Projectiles);
    }

    public static List<DataTable> GetQuest(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Quests);
    }

    public static List<DataTable> GetRace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Races);
    }

    public static List<DataTable> GetRegion(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Regions);
    }

    public static List<DataTable> GetRelationship(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Relationships);
    }

    public static List<DataTable> GetReverbParameters(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ReverbParameters);
    }

    public static List<DataTable> GetScene(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Scenes);
    }

    public static List<DataTable> GetScroll(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Scrolls);
    }

    public static List<DataTable> GetShaderParticleGeometry(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).ShaderParticleGeometries);
    }

    public static List<DataTable> GetShout(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Shouts);
    }

    public static List<DataTable> GetSoulGem(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).SoulGems);
    }

    public static List<DataTable> GetSoundCategory(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).SoundCategories);
    }

    public static List<DataTable> GetSoundDescriptor(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).SoundDescriptors);
    }

    public static List<DataTable> GetSoundMarker(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).SoundMarkers);
    }

    public static List<DataTable> GetSoundOutputModel(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).SoundOutputModels);
    }

    public static List<DataTable> GetSpell(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Spells);
    }

    public static List<DataTable> GetStatic(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Statics);
    }

    public static List<DataTable> GetTalkingActivator(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).TalkingActivators);
    }

    public static List<DataTable> GetTextureSet(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).TextureSets);
    }

    public static List<DataTable> GetTree(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Trees);
    }

    public static List<DataTable> GetVisualEffect(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).VisualEffects);
    }

    public static List<DataTable> GetVoiceType(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).VoiceTypes);
    }

    public static List<DataTable> GetVolumetricLighting(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).VolumetricLightings);
    }

    public static List<DataTable> GetWater(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Waters);
    }

    public static List<DataTable> GetWeather(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Weathers);
    }

    public static List<DataTable> GetWordOfPower(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).WordsOfPower);
    }

    public static List<DataTable> GetWorldSpace(IGameEnvironment<ISkyrimMod, ISkyrimModGetter> env, string mod)
    {
        return CreateDataTable.CreateDataTables(SkyrimMod.CreateFromBinaryOverlay(Path.Combine(env.DataFolderPath, mod), SkyrimRelease.SkyrimSE).Worldspaces);
    }
}