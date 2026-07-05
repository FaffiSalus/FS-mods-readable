using FS_mods_readable.Core;
using FS_mods_readable.Core.SQL;

namespace FS_mods_readable.Skyrim;

public static class Skyrim2Sql
{
    public static void FillAllTables(string server, string db)
    {
        FillAcousticSpace(server, db);
        FillActionRecord(server, db);
        FillActivator(server, db);
        FillActorValueInformation(server, db);
        FillAddonNode(server, db);
        FillAlchemicalApparatus(server, db);
        FillAmmunition(server, db);
        FillAnimatedObject(server, db);
        FillAPlacedTrap(server, db);
        FillArmor(server, db);
        FillArmorAddon(server, db);
        FillArtObject(server, db);
        FillAssociationType(server, db);
        FillAStoryManagerNode(server, db);
        FillBodyPartData(server, db);
        FillBook(server, db);
        FillCameraPath(server, db);
        FillCameraShot(server, db);
        FillCell(server, db);
        FillClass(server, db);
        FillClimate(server, db);
        FillCollisionLayer(server, db);
        FillColorRecord(server, db);
        FillCombatStyle(server, db);
        FillConstructibleObject(server, db);
        FillContainer(server, db);
        FillDebris(server, db);
        FillDefaultObjectManager(server, db);
        FillDialogBranch(server, db);
        FillDialogResponses(server, db);
        FillDialogTopic(server, db);
        FillDialogView(server, db);
        FillDoor(server, db);
        FillDualCastData(server, db);
        FillEffectShader(server, db);
        FillEncounterZone(server, db);
        FillEquipType(server, db);
        FillExplosion(server, db);
        FillEyes(server, db);
        FillFaction(server, db);
        FillFlora(server, db);
        FillFootstep(server, db);
        FillFootstepSet(server, db);
        FillFormList(server, db);
        FillFurniture(server, db);
        FillGameSetting(server, db);
        FillGlobal(server, db);
        FillGrass(server, db);
        FillHair(server, db);
        FillHazard(server, db);
        FillHeadPart(server, db);
        // FillIAliasVoiceType(server, db);
        // FillIBindableEquipment(server, db);
        // FillIComplexLocation(server, db);
        // FillIConstructible(server, db);
        FillIdleAnimation(server, db);
        FillIdleMarker(server, db);
        // FillIEffectRecord(server, db);
        // FillIEmittance(server, db);
        // FillIExplodeSpawn(server, db);
        // FillIHarvestTarget(server, db);
        // FillIIdleRelation(server, db);
        // FillIItem(server, db);
        // FillIItemOrList(server, db);
        // FillIKeywordLinkedReference(server, db);
        // FillIKnowable(server, db);
        // FillILockList(server, db);
        FillImageSpace(server, db);
        FillImageSpaceAdapter(server, db);
        // FillIMagicItem(server, db);
        FillImpact(server, db);
        FillImpactDataSet(server, db);
        FillIngestible(server, db);
        FillIngredient(server, db);
        // FillINpcOrList(server, db);
        // FillINpcSpawn(server, db);
        // FillIObjectId(server, db);
        // FillIOutfitTarget(server, db);
        // FillIOwner(server, db);
        // FillIPlaceableObject(server, db);
        // FillIPlaced(server, db);
        // FillIPlacedSimple(server, db);
        // FillIPlacedThing(server, db);
        // FillIPlacedTrapTarget(server, db);
        // FillIReferenceableObject(server, db);
        // FillIRegionTarget(server, db);
        // FillIRelatable(server, db);
        // FillISound(server, db);
        // FillISpellOrList(server, db);
        // FillISpellRecord(server, db);
        // FillIVoiceTypeOrList(server, db);
        // FillIWeaponOrList(server, db);
        // FillIWorldspaceOrList(server, db);
        FillKey(server, db);
        FillKeyword(server, db);
        FillLandscape(server, db);
        FillLandscapeTexture(server, db);
        FillLensFlare(server, db);
        FillLeveledItem(server, db);
        FillLeveledNpc(server, db);
        FillLeveledSpell(server, db);
        FillLight(server, db);
        FillLightingTemplate(server, db);
        FillLoadScreen(server, db);
        FillLocation(server, db);
        FillLocationReferenceType(server, db);
        FillMagicEffect(server, db);
        FillMaterialObject(server, db);
        FillMaterialType(server, db);
        FillMessage(server, db);
        FillMiscItem(server, db);
        FillMoveableStatic(server, db);
        FillMovementType(server, db);
        FillMusicTrack(server, db);
        FillMusicType(server, db);
        FillNavigationMesh(server, db);
        FillNavigationMeshInfoMap(server, db);
        FillNpc(server, db);
        FillObjectEffect(server, db);
        FillOutfit(server, db);
        FillPackage(server, db);
        FillPerk(server, db);
        FillPlacedNpc(server, db);
        FillPlacedObject(server, db);
        FillProjectile(server, db);
        FillQuest(server, db);
        //FillRace(server, db);
        FillRegion(server, db);
        FillRelationship(server, db);
        FillReverbParameters(server, db);
        FillScene(server, db);
        FillScroll(server, db);
        FillShaderParticleGeometry(server, db);
        FillShout(server, db);
        //FillSkyrimMajorRecord(server, db);
        FillSoulGem(server, db);
        FillSoundCategory(server, db);
        FillSoundDescriptor(server, db);
        FillSoundMarker(server, db);
        FillSoundOutputModel(server, db);
        FillSpell(server, db);
        FillStatic(server, db);
        FillTalkingActivator(server, db);
        FillTextureSet(server, db);
        FillTree(server, db);
        FillVisualEffect(server, db);
        FillVoiceType(server, db);
        FillVolumetricLighting(server, db);
        FillWater(server, db);
        FillWeapons(server, db);
        FillWeather(server, db);
        FillWordOfPower(server, db);
        FillWorldspace(server, db);
    }
    
    public static void FillAcousticSpace(string server, string db)
    {
        const string tableName = "[dbo].[AcousticSpace]";
        DataTable dataTable = GetSkyrimData.GetAcousticSpace();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillActionRecord(string server, string db)
    {
        const string tableName = "[dbo].[ActionRecord]";
        DataTable dataTable = GetSkyrimData.GetActionRecord();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillActivator(string server, string db)
    {
        const string tableName = "[dbo].[Activator]";
        DataTable dataTable = GetSkyrimData.GetActivator();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillActorValueInformation(string server, string db)
    {
        const string tableName = "[dbo].[ActorValueInformation]";
        DataTable dataTable = GetSkyrimData.GetActorValueInformation();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAddonNode(string server, string db)
    {
        const string tableName = "[dbo].[AddonNode]";
        DataTable dataTable = GetSkyrimData.GetAddonNode();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAlchemicalApparatus(string server, string db)
    {
        const string tableName = "[dbo].[AlchemicalApparatus]";
        DataTable dataTable = GetSkyrimData.GetAlchemicalApparatus();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAmmunition(string server, string db)
    {
        const string tableName = "[dbo].[Ammunition]";
        DataTable dataTable = GetSkyrimData.GetAmmunition();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAnimatedObject(string server, string db)
    {
        const string tableName = "[dbo].[AnimatedObject]";
        DataTable dataTable = GetSkyrimData.GetAnimatedObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAPlacedTrap(string server, string db)
    {
        const string tableName = "[dbo].[APlacedTrap]";
        DataTable dataTable = GetSkyrimData.GetAPlacedTrap();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillArmor(string server, string db)
    {
        const string tableName = "[dbo].[Armor]";
        DataTable dataTable = GetSkyrimData.GetArmor();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillArmorAddon(string server, string db)
    {
        const string tableName = "[dbo].[ArmorAddon]";
        DataTable dataTable = GetSkyrimData.GetArmorAddon();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillArtObject(string server, string db)
    {
        const string tableName = "[dbo].[ArtObject]";
        DataTable dataTable = GetSkyrimData.GetArtObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAssociationType(string server, string db)
    {
        const string tableName = "[dbo].[AssociationType]";
        DataTable dataTable = GetSkyrimData.GetAssociationType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillAStoryManagerNode(string server, string db)
    {
        const string tableName = "[dbo].[AStoryManagerNode]";
        DataTable dataTable = GetSkyrimData.GetAStoryManagerNode();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillBodyPartData(string server, string db)
    {
        const string tableName = "[dbo].[BodyPartData]";
        DataTable dataTable = GetSkyrimData.GetBodyPartData();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillBook(string server, string db)
    {
        const string tableName = "[dbo].[Book]";
        DataTable dataTable = GetSkyrimData.GetBook();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillCameraPath(string server, string db)
    {
        const string tableName = "[dbo].[CameraPath]";
        DataTable dataTable = GetSkyrimData.GetCameraPath();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillCameraShot(string server, string db)
    {
        const string tableName = "[dbo].[CameraShot]";
        DataTable dataTable = GetSkyrimData.GetCameraShot();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillCell(string server, string db)
    {
        const string tableName = "[dbo].[Cell]";
        DataTable dataTable = GetSkyrimData.GetCell();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillClass(string server, string db)
    {
        const string tableName = "[dbo].[Class]";
        DataTable dataTable = GetSkyrimData.GetClass();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillClimate(string server, string db)
    {
        const string tableName = "[dbo].[Climate]";
        DataTable dataTable = GetSkyrimData.GetClimate();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillCollisionLayer(string server, string db)
    {
        const string tableName = "[dbo].[CollisionLayer]";
        DataTable dataTable = GetSkyrimData.GetCollisionLayer();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillColorRecord(string server, string db)
    {
        const string tableName = "[dbo].[ColorRecord]";
        DataTable dataTable = GetSkyrimData.GetColorRecord();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillCombatStyle(string server, string db)
    {
        const string tableName = "[dbo].[CombatStyle]";
        DataTable dataTable = GetSkyrimData.GetCombatStyle();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillConstructibleObject(string server, string db)
    {
        const string tableName = "[dbo].[ConstructibleObject]";
        DataTable dataTable = GetSkyrimData.GetConstructibleObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillContainer(string server, string db)
    {
        const string tableName = "[dbo].[Container]";
        DataTable dataTable = GetSkyrimData.GetContainer();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDebris(string server, string db)
    {
        const string tableName = "[dbo].[Debris]";
        DataTable dataTable = GetSkyrimData.GetDebris();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDefaultObjectManager(string server, string db)
    {
        const string tableName = "[dbo].[DefaultObjectManager]";
        DataTable dataTable = GetSkyrimData.GetDefaultObjectManager();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDialogBranch(string server, string db)
    {
        const string tableName = "[dbo].[DialogBranch]";
        DataTable dataTable = GetSkyrimData.GetDialogBranch();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDialogResponses(string server, string db)
    {
        const string tableName = "[dbo].[DialogResponses]";
        DataTable dataTable = GetSkyrimData.GetDialogResponses();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDialogTopic(string server, string db)
    {
        const string tableName = "[dbo].[DialogTopic]";
        DataTable dataTable = GetSkyrimData.GetDialogTopic();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDialogView(string server, string db)
    {
        const string tableName = "[dbo].[DialogView]";
        DataTable dataTable = GetSkyrimData.GetDialogView();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDoor(string server, string db)
    {
        const string tableName = "[dbo].[Door]";
        DataTable dataTable = GetSkyrimData.GetDoor();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillDualCastData(string server, string db)
    {
        const string tableName = "[dbo].[DualCastData]";
        DataTable dataTable = GetSkyrimData.GetDualCastData();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillEffectShader(string server, string db)
    {
        const string tableName = "[dbo].[EffectShader]";
        DataTable dataTable = GetSkyrimData.GetEffectShader();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillEncounterZone(string server, string db)
    {
        const string tableName = "[dbo].[EncounterZone]";
        DataTable dataTable = GetSkyrimData.GetEncounterZone();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillEquipType(string server, string db)
    {
        const string tableName = "[dbo].[EquipType]";
        DataTable dataTable = GetSkyrimData.GetEquipType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillExplosion(string server, string db)
    {
        const string tableName = "[dbo].[Explosion]";
        DataTable dataTable = GetSkyrimData.GetExplosion();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillEyes(string server, string db)
    {
        const string tableName = "[dbo].[Eyes]";
        DataTable dataTable = GetSkyrimData.GetEyes();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillFaction(string server, string db)
    {
        const string tableName = "[dbo].[Faction]";
        DataTable dataTable = GetSkyrimData.GetFaction();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillFlora(string server, string db)
    {
        const string tableName = "[dbo].[Flora]";
        DataTable dataTable = GetSkyrimData.GetFlora();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillFootstep(string server, string db)
    {
        const string tableName = "[dbo].[Footstep]";
        DataTable dataTable = GetSkyrimData.GetFootstep();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillFootstepSet(string server, string db)
    {
        const string tableName = "[dbo].[FootstepSet]";
        DataTable dataTable = GetSkyrimData.GetFootstepSet();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillFormList(string server, string db)
    {
        const string tableName = "[dbo].[FormList]";
        DataTable dataTable = GetSkyrimData.GetFormList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillFurniture(string server, string db)
    {
        const string tableName = "[dbo].[Furniture]";
        DataTable dataTable = GetSkyrimData.GetFurniture();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillGameSetting(string server, string db)
    {
        const string tableName = "[dbo].[GameSetting]";
        DataTable dataTable = GetSkyrimData.GetGameSetting();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillGlobal(string server, string db)
    {
        const string tableName = "[dbo].[Global]";
        DataTable dataTable = GetSkyrimData.GetGlobal();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillGrass(string server, string db)
    {
        const string tableName = "[dbo].[Grass]";
        DataTable dataTable = GetSkyrimData.GetGrass();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillHair(string server, string db)
    {
        const string tableName = "[dbo].[Hair]";
        DataTable dataTable = GetSkyrimData.GetHair();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillHazard(string server, string db)
    {
        const string tableName = "[dbo].[Hazard]";
        DataTable dataTable = GetSkyrimData.GetHazard();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillHeadPart(string server, string db)
    {
        const string tableName = "[dbo].[HeadPart]";
        DataTable dataTable = GetSkyrimData.GetHeadPart();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIAliasVoiceType(string server, string db)
    {
        const string tableName = "[dbo].[IAliasVoiceType]";
        DataTable dataTable = GetSkyrimData.GetIAliasVoiceType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIBindableEquipment(string server, string db)
    {
        const string tableName = "[dbo].[IBindableEquipment]";
        DataTable dataTable = GetSkyrimData.GetIBindableEquipment();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIComplexLocation(string server, string db)
    {
        const string tableName = "[dbo].[IComplexLocation]";
        DataTable dataTable = GetSkyrimData.GetIComplexLocation();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIConstructible(string server, string db)
    {
        const string tableName = "[dbo].[IConstructible]";
        DataTable dataTable = GetSkyrimData.GetIConstructible();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIdleAnimation(string server, string db)
    {
        const string tableName = "[dbo].[IdleAnimation]";
        DataTable dataTable = GetSkyrimData.GetIdleAnimation();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIdleMarker(string server, string db)
    {
        const string tableName = "[dbo].[IdleMarker]";
        DataTable dataTable = GetSkyrimData.GetIdleMarker();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIEffectRecord(string server, string db)
    {
        const string tableName = "[dbo].[IEffectRecord]";
        DataTable dataTable = GetSkyrimData.GetIEffectRecord();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIEmittance(string server, string db)
    {
        const string tableName = "[dbo].[IEmittance]";
        DataTable dataTable = GetSkyrimData.GetIEmittance();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIExplodeSpawn(string server, string db)
    {
        const string tableName = "[dbo].[IExplodeSpawn]";
        DataTable dataTable = GetSkyrimData.GetIExplodeSpawn();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIHarvestTarget(string server, string db)
    {
        const string tableName = "[dbo].[IHarvestTarget]";
        DataTable dataTable = GetSkyrimData.GetIHarvestTarget();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIIdleRelation(string server, string db)
    {
        const string tableName = "[dbo].[IIdleRelation]";
        DataTable dataTable = GetSkyrimData.GetIIdleRelation();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIItem(string server, string db)
    {
        const string tableName = "[dbo].[IItem]";
        DataTable dataTable = GetSkyrimData.GetIItem();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIItemOrList(string server, string db)
    {
        const string tableName = "[dbo].[IItemOrList]";
        DataTable dataTable = GetSkyrimData.GetIItemOrList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIKeywordLinkedReference(string server, string db)
    {
        const string tableName = "[dbo].[IKeywordLinkedReference]";
        DataTable dataTable = GetSkyrimData.GetIKeywordLinkedReference();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIKnowable(string server, string db)
    {
        const string tableName = "[dbo].[IKnowable]";
        DataTable dataTable = GetSkyrimData.GetIKnowable();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillILockList(string server, string db)
    {
        const string tableName = "[dbo].[ILockList]";
        DataTable dataTable = GetSkyrimData.GetILockList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillImageSpace(string server, string db)
    {
        const string tableName = "[dbo].[ImageSpace]";
        DataTable dataTable = GetSkyrimData.GetImageSpace();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillImageSpaceAdapter(string server, string db)
    {
        const string tableName = "[dbo].[ImageSpaceAdapter]";
        DataTable dataTable = GetSkyrimData.GetImageSpaceAdapter();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIMagicItem(string server, string db)
    {
        const string tableName = "[dbo].[IMagicItem]";
        DataTable dataTable = GetSkyrimData.GetIMagicItem();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillImpact(string server, string db)
    {
        const string tableName = "[dbo].[Impact]";
        DataTable dataTable = GetSkyrimData.GetImpact();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillImpactDataSet(string server, string db)
    {
        const string tableName = "[dbo].[ImpactDataSet]";
        DataTable dataTable = GetSkyrimData.GetImpactDataSet();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIngestible(string server, string db)
    {
        const string tableName = "[dbo].[Ingestible]";
        DataTable dataTable = GetSkyrimData.GetIngestible();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIngredient(string server, string db)
    {
        const string tableName = "[dbo].[Ingredient]";
        DataTable dataTable = GetSkyrimData.GetIngredient();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillINpcOrList(string server, string db)
    {
        const string tableName = "[dbo].[INpcOrList]";
        DataTable dataTable = GetSkyrimData.GetINpcOrList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillINpcSpawn(string server, string db)
    {
        const string tableName = "[dbo].[INpcSpawn]";
        DataTable dataTable = GetSkyrimData.GetINpcSpawn();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIObjectId(string server, string db)
    {
        const string tableName = "[dbo].[IObjectId]";
        DataTable dataTable = GetSkyrimData.GetIObjectId();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIOutfitTarget(string server, string db)
    {
        const string tableName = "[dbo].[IOutfitTarget]";
        DataTable dataTable = GetSkyrimData.GetIOutfitTarget();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIOwner(string server, string db)
    {
        const string tableName = "[dbo].[IOwner]";
        DataTable dataTable = GetSkyrimData.GetIOwner();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIPlaceableObject(string server, string db)
    {
        const string tableName = "[dbo].[IPlaceableObject]";
        DataTable dataTable = GetSkyrimData.GetIPlaceableObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIPlaced(string server, string db)
    {
        const string tableName = "[dbo].[IPlaced]";
        DataTable dataTable = GetSkyrimData.GetIPlaced();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIPlacedSimple(string server, string db)
    {
        const string tableName = "[dbo].[IPlacedSimple]";
        DataTable dataTable = GetSkyrimData.GetIPlacedSimple();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIPlacedThing(string server, string db)
    {
        const string tableName = "[dbo].[IPlacedThing]";
        DataTable dataTable = GetSkyrimData.GetIPlacedThing();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIPlacedTrapTarget(string server, string db)
    {
        const string tableName = "[dbo].[IPlacedTrapTarget]";
        DataTable dataTable = GetSkyrimData.GetIPlacedTrapTarget();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIReferenceableObject(string server, string db)
    {
        const string tableName = "[dbo].[IReferenceableObject]";
        DataTable dataTable = GetSkyrimData.GetIReferenceableObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIRegionTarget(string server, string db)
    {
        const string tableName = "[dbo].[IRegionTarget]";
        DataTable dataTable = GetSkyrimData.GetIRegionTarget();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIRelatable(string server, string db)
    {
        const string tableName = "[dbo].[IRelatable]";
        DataTable dataTable = GetSkyrimData.GetIRelatable();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillISound(string server, string db)
    {
        const string tableName = "[dbo].[ISound]";
        DataTable dataTable = GetSkyrimData.GetISound();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillISpellOrList(string server, string db)
    {
        const string tableName = "[dbo].[ISpellOrList]";
        DataTable dataTable = GetSkyrimData.GetISpellOrList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillISpellRecord(string server, string db)
    {
        const string tableName = "[dbo].[ISpellRecord]";
        DataTable dataTable = GetSkyrimData.GetISpellRecord();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIVoiceTypeOrList(string server, string db)
    {
        const string tableName = "[dbo].[IVoiceTypeOrList]";
        DataTable dataTable = GetSkyrimData.GetIVoiceTypeOrList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIWeaponOrList(string server, string db)
    {
        const string tableName = "[dbo].[IWeaponOrList]";
        DataTable dataTable = GetSkyrimData.GetIWeaponOrList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillIWorldspaceOrList(string server, string db)
    {
        const string tableName = "[dbo].[IWorldspaceOrList]";
        DataTable dataTable = GetSkyrimData.GetIWorldspaceOrList();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillKey(string server, string db)
    {
        const string tableName = "[dbo].[Key]";
        DataTable dataTable = GetSkyrimData.GetKey();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillKeyword(string server, string db)
    {
        const string tableName = "[dbo].[Keyword]";
        DataTable dataTable = GetSkyrimData.GetKeyword();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLandscape(string server, string db)
    {
        const string tableName = "[dbo].[Landscape]";
        DataTable dataTable = GetSkyrimData.GetLandscape();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLandscapeTexture(string server, string db)
    {
        const string tableName = "[dbo].[LandscapeTexture]";
        DataTable dataTable = GetSkyrimData.GetLandscapeTexture();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLensFlare(string server, string db)
    {
        const string tableName = "[dbo].[LensFlare]";
        DataTable dataTable = GetSkyrimData.GetLensFlare();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLeveledItem(string server, string db)
    {
        const string tableName = "[dbo].[LeveledItem]";
        DataTable dataTable = GetSkyrimData.GetLeveledItem();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLeveledNpc(string server, string db)
    {
        const string tableName = "[dbo].[LeveledNpc]";
        DataTable dataTable = GetSkyrimData.GetLeveledNpc();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLeveledSpell(string server, string db)
    {
        const string tableName = "[dbo].[LeveledSpell]";
        DataTable dataTable = GetSkyrimData.GetLeveledSpell();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLight(string server, string db)
    {
        const string tableName = "[dbo].[Light]";
        DataTable dataTable = GetSkyrimData.GetLight();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLightingTemplate(string server, string db)
    {
        const string tableName = "[dbo].[LightingTemplate]";
        DataTable dataTable = GetSkyrimData.GetLightingTemplate();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLoadScreen(string server, string db)
    {
        const string tableName = "[dbo].[LoadScreen]";
        DataTable dataTable = GetSkyrimData.GetLoadScreen();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLocation(string server, string db)
    {
        const string tableName = "[dbo].[Location]";
        DataTable dataTable = GetSkyrimData.GetLocation();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillLocationReferenceType(string server, string db)
    {
        const string tableName = "[dbo].[LocationReferenceType]";
        DataTable dataTable = GetSkyrimData.GetLocationReferenceType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMagicEffect(string server, string db)
    {
        const string tableName = "[dbo].[MagicEffect]";
        DataTable dataTable = GetSkyrimData.GetMagicEffect();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMaterialObject(string server, string db)
    {
        const string tableName = "[dbo].[MaterialObject]";
        DataTable dataTable = GetSkyrimData.GetMaterialObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMaterialType(string server, string db)
    {
        const string tableName = "[dbo].[MaterialType]";
        DataTable dataTable = GetSkyrimData.GetMaterialType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMessage(string server, string db)
    {
        const string tableName = "[dbo].[Message]";
        DataTable dataTable = GetSkyrimData.GetMessage();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMiscItem(string server, string db)
    {
        const string tableName = "[dbo].[MiscItem]";
        DataTable dataTable = GetSkyrimData.GetMiscItem();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMoveableStatic(string server, string db)
    {
        const string tableName = "[dbo].[MoveableStatic]";
        DataTable dataTable = GetSkyrimData.GetMoveableStatic();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMovementType(string server, string db)
    {
        const string tableName = "[dbo].[MovementType]";
        DataTable dataTable = GetSkyrimData.GetMovementType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMusicTrack(string server, string db)
    {
        const string tableName = "[dbo].[MusicTrack]";
        DataTable dataTable = GetSkyrimData.GetMusicTrack();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillMusicType(string server, string db)
    {
        const string tableName = "[dbo].[MusicType]";
        DataTable dataTable = GetSkyrimData.GetMusicType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillNavigationMesh(string server, string db)
    {
        const string tableName = "[dbo].[NavigationMesh]";
        DataTable dataTable = GetSkyrimData.GetNavigationMesh();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillNavigationMeshInfoMap(string server, string db)
    {
        const string tableName = "[dbo].[NavigationMeshInfoMap]";
        DataTable dataTable = GetSkyrimData.GetNavigationMeshInfoMap();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillNpc(string server, string db)
    {
        const string tableName = "[dbo].[Npc]";
        DataTable dataTable = GetSkyrimData.GetNpc();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillObjectEffect(string server, string db)
    {
        const string tableName = "[dbo].[ObjectEffect]";
        DataTable dataTable = GetSkyrimData.GetObjectEffect();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillOutfit(string server, string db)
    {
        const string tableName = "[dbo].[Outfit]";
        DataTable dataTable = GetSkyrimData.GetOutfit();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillPackage(string server, string db)
    {
        const string tableName = "[dbo].[Package]";
        DataTable dataTable = GetSkyrimData.GetPackage();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillPerk(string server, string db)
    {
        const string tableName = "[dbo].[Perk]";
        DataTable dataTable = GetSkyrimData.GetPerk();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillPlacedNpc(string server, string db)
    {
        const string tableName = "[dbo].[PlacedNpc]";
        DataTable dataTable = GetSkyrimData.GetPlacedNpc();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillPlacedObject(string server, string db)
    {
        const string tableName = "[dbo].[PlacedObject]";
        DataTable dataTable = GetSkyrimData.GetPlacedObject();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillProjectile(string server, string db)
    {
        const string tableName = "[dbo].[Projectile]";
        DataTable dataTable = GetSkyrimData.GetProjectile();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillQuest(string server, string db)
    {
        const string tableName = "[dbo].[Quest]";
        DataTable dataTable = GetSkyrimData.GetQuest();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillRace(string server, string db)
    {
        const string tableName = "[dbo].[Race]";
        DataTable dataTable = GetSkyrimData.GetRace();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillRegion(string server, string db)
    {
        const string tableName = "[dbo].[Region]";
        DataTable dataTable = GetSkyrimData.GetRegion();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillRelationship(string server, string db)
    {
        const string tableName = "[dbo].[Relationship]";
        DataTable dataTable = GetSkyrimData.GetRelationship();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillReverbParameters(string server, string db)
    {
        const string tableName = "[dbo].[ReverbParameters]";
        DataTable dataTable = GetSkyrimData.GetReverbParameters();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillScene(string server, string db)
    {
        const string tableName = "[dbo].[Scene]";
        DataTable dataTable = GetSkyrimData.GetScene();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillScroll(string server, string db)
    {
        const string tableName = "[dbo].[Scroll]";
        DataTable dataTable = GetSkyrimData.GetScroll();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillShaderParticleGeometry(string server, string db)
    {
        const string tableName = "[dbo].[ShaderParticleGeometry]";
        DataTable dataTable = GetSkyrimData.GetShaderParticleGeometry();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillShout(string server, string db)
    {
        const string tableName = "[dbo].[Shout]";
        DataTable dataTable = GetSkyrimData.GetShout();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSkyrimMajorRecord(string server, string db)
    {
        const string tableName = "[dbo].[SkyrimMajorRecord]";
        DataTable dataTable = GetSkyrimData.GetSkyrimMajorRecord();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSoulGem(string server, string db)
    {
        const string tableName = "[dbo].[SoulGem]";
        DataTable dataTable = GetSkyrimData.GetSoulGem();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSoundCategory(string server, string db)
    {
        const string tableName = "[dbo].[SoundCategory]";
        DataTable dataTable = GetSkyrimData.GetSoundCategory();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSoundDescriptor(string server, string db)
    {
        const string tableName = "[dbo].[SoundDescriptor]";
        DataTable dataTable = GetSkyrimData.GetSoundDescriptor();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSoundMarker(string server, string db)
    {
        const string tableName = "[dbo].[SoundMarker]";
        DataTable dataTable = GetSkyrimData.GetSoundMarker();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSoundOutputModel(string server, string db)
    {
        const string tableName = "[dbo].[SoundOutputModel]";
        DataTable dataTable = GetSkyrimData.GetSoundOutputModel();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillSpell(string server, string db)
    {
        const string tableName = "[dbo].[Spell]";
        DataTable dataTable = GetSkyrimData.GetSpell();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillStatic(string server, string db)
    {
        const string tableName = "[dbo].[Static]";
        DataTable dataTable = GetSkyrimData.GetStatic();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillTalkingActivator(string server, string db)
    {
        const string tableName = "[dbo].[TalkingActivator]";
        DataTable dataTable = GetSkyrimData.GetTalkingActivator();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillTextureSet(string server, string db)
    {
        const string tableName = "[dbo].[TextureSet]";
        DataTable dataTable = GetSkyrimData.GetTextureSet();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillTree(string server, string db)
    {
        const string tableName = "[dbo].[Tree]";
        DataTable dataTable = GetSkyrimData.GetTree();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillVisualEffect(string server, string db)
    {
        const string tableName = "[dbo].[VisualEffect]";
        DataTable dataTable = GetSkyrimData.GetVisualEffect();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillVoiceType(string server, string db)
    {
        const string tableName = "[dbo].[VoiceType]";
        DataTable dataTable = GetSkyrimData.GetVoiceType();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillVolumetricLighting(string server, string db)
    {
        const string tableName = "[dbo].[VolumetricLighting]";
        DataTable dataTable = GetSkyrimData.GetVolumetricLighting();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillWater(string server, string db)
    {
        const string tableName = "[dbo].[Water]";
        DataTable dataTable = GetSkyrimData.GetWater();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }
    
    public static void FillWeapons(string server, string db)
    {
        const string tableName = "[dbo].[Weapon]";
        DataTable dataTable = GetSkyrimData.GetWeapon();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillWeather(string server, string db)
    {
        const string tableName = "[dbo].[Weather]";
        DataTable dataTable = GetSkyrimData.GetWeather();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillWordOfPower(string server, string db)
    {
        const string tableName = "[dbo].[WordOfPower]";
        DataTable dataTable = GetSkyrimData.GetWordOfPower();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }

    public static void FillWorldspace(string server, string db)
    {
        const string tableName = "[dbo].[Worldspace]";
        DataTable dataTable = GetSkyrimData.GetWorldSpace();
        CreateAndFillTables.CreateTable(server, db, tableName, dataTable);
        CreateAndFillTables.FillTable(server, db, tableName, dataTable);
    }
}