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

    public static void FillCameraPath(string server, string db)
    {
        const string tablename = "[dbo].[CameraPath]";
        DataTable dataTable = GetData.GetCameraPath();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillCameraShot(string server, string db)
    {
        const string tablename = "[dbo].[CameraShot]";
        DataTable dataTable = GetData.GetCameraShot();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillCell(string server, string db)
    {
        const string tablename = "[dbo].[Cell]";
        DataTable dataTable = GetData.GetCell();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillClass(string server, string db)
    {
        const string tablename = "[dbo].[Class]";
        DataTable dataTable = GetData.GetClass();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillClimate(string server, string db)
    {
        const string tablename = "[dbo].[Climate]";
        DataTable dataTable = GetData.GetClimate();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillCollisionLayer(string server, string db)
    {
        const string tablename = "[dbo].[CollisionLayer]";
        DataTable dataTable = GetData.GetCollisionLayer();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillColorRecord(string server, string db)
    {
        const string tablename = "[dbo].[ColorRecord]";
        DataTable dataTable = GetData.GetColorRecord();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillCombatStyle(string server, string db)
    {
        const string tablename = "[dbo].[CombatStyle]";
        DataTable dataTable = GetData.GetCombatStyle();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillConstructibleObject(string server, string db)
    {
        const string tablename = "[dbo].[ConstructibleObject]";
        DataTable dataTable = GetData.GetConstructibleObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillContainer(string server, string db)
    {
        const string tablename = "[dbo].[Container]";
        DataTable dataTable = GetData.GetContainer();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDebris(string server, string db)
    {
        const string tablename = "[dbo].[Debris]";
        DataTable dataTable = GetData.GetDebris();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDefaultObjectManager(string server, string db)
    {
        const string tablename = "[dbo].[DefaultObjectManager]";
        DataTable dataTable = GetData.GetDefaultObjectManager();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDialogBranch(string server, string db)
    {
        const string tablename = "[dbo].[DialogBranch]";
        DataTable dataTable = GetData.GetDialogBranch();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDialogResponses(string server, string db)
    {
        const string tablename = "[dbo].[DialogResponses]";
        DataTable dataTable = GetData.GetDialogResponses();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDialogTopic(string server, string db)
    {
        const string tablename = "[dbo].[DialogTopic]";
        DataTable dataTable = GetData.GetDialogTopic();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDialogView(string server, string db)
    {
        const string tablename = "[dbo].[DialogView]";
        DataTable dataTable = GetData.GetDialogView();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDoor(string server, string db)
    {
        const string tablename = "[dbo].[Door]";
        DataTable dataTable = GetData.GetDoor();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillDualCastData(string server, string db)
    {
        const string tablename = "[dbo].[DualCastData]";
        DataTable dataTable = GetData.GetDualCastData();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillEffectShader(string server, string db)
    {
        const string tablename = "[dbo].[EffectShader]";
        DataTable dataTable = GetData.GetEffectShader();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillEncounterZone(string server, string db)
    {
        const string tablename = "[dbo].[EncounterZone]";
        DataTable dataTable = GetData.GetEncounterZone();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillEquipType(string server, string db)
    {
        const string tablename = "[dbo].[EquipType]";
        DataTable dataTable = GetData.GetEquipType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillExplosion(string server, string db)
    {
        const string tablename = "[dbo].[Explosion]";
        DataTable dataTable = GetData.GetExplosion();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillEyes(string server, string db)
    {
        const string tablename = "[dbo].[Eyes]";
        DataTable dataTable = GetData.GetEyes();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillFaction(string server, string db)
    {
        const string tablename = "[dbo].[Faction]";
        DataTable dataTable = GetData.GetFaction();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillFlora(string server, string db)
    {
        const string tablename = "[dbo].[Flora]";
        DataTable dataTable = GetData.GetFlora();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillFootstep(string server, string db)
    {
        const string tablename = "[dbo].[Footstep]";
        DataTable dataTable = GetData.GetFootstep();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillFootstepSet(string server, string db)
    {
        const string tablename = "[dbo].[FootstepSet]";
        DataTable dataTable = GetData.GetFootstepSet();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillFormList(string server, string db)
    {
        const string tablename = "[dbo].[FormList]";
        DataTable dataTable = GetData.GetFormList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillFurniture(string server, string db)
    {
        const string tablename = "[dbo].[Furniture]";
        DataTable dataTable = GetData.GetFurniture();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillGameSetting(string server, string db)
    {
        const string tablename = "[dbo].[GameSetting]";
        DataTable dataTable = GetData.GetGameSetting();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillGlobal(string server, string db)
    {
        const string tablename = "[dbo].[Global]";
        DataTable dataTable = GetData.GetGlobal();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillGrass(string server, string db)
    {
        const string tablename = "[dbo].[Grass]";
        DataTable dataTable = GetData.GetGrass();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillHair(string server, string db)
    {
        const string tablename = "[dbo].[Hair]";
        DataTable dataTable = GetData.GetHair();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillHazard(string server, string db)
    {
        const string tablename = "[dbo].[Hazard]";
        DataTable dataTable = GetData.GetHazard();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillHeadPart(string server, string db)
    {
        const string tablename = "[dbo].[HeadPart]";
        DataTable dataTable = GetData.GetHeadPart();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIAliasVoiceType(string server, string db)
    {
        const string tablename = "[dbo].[IAliasVoiceType]";
        DataTable dataTable = GetData.GetIAliasVoiceType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIBindableEquipment(string server, string db)
    {
        const string tablename = "[dbo].[IBindableEquipment]";
        DataTable dataTable = GetData.GetIBindableEquipment();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIComplexLocation(string server, string db)
    {
        const string tablename = "[dbo].[IComplexLocation]";
        DataTable dataTable = GetData.GetIComplexLocation();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIConstructible(string server, string db)
    {
        const string tablename = "[dbo].[IConstructible]";
        DataTable dataTable = GetData.GetIConstructible();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIdleAnimation(string server, string db)
    {
        const string tablename = "[dbo].[IdleAnimation]";
        DataTable dataTable = GetData.GetIdleAnimation();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIdleMarker(string server, string db)
    {
        const string tablename = "[dbo].[IdleMarker]";
        DataTable dataTable = GetData.GetIdleMarker();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIEffectRecord(string server, string db)
    {
        const string tablename = "[dbo].[IEffectRecord]";
        DataTable dataTable = GetData.GetIEffectRecord();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIEmittance(string server, string db)
    {
        const string tablename = "[dbo].[IEmittance]";
        DataTable dataTable = GetData.GetIEmittance();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIExplodeSpawn(string server, string db)
    {
        const string tablename = "[dbo].[IExplodeSpawn]";
        DataTable dataTable = GetData.GetIExplodeSpawn();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIHarvestTarget(string server, string db)
    {
        const string tablename = "[dbo].[IHarvestTarget]";
        DataTable dataTable = GetData.GetIHarvestTarget();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIIdleRelation(string server, string db)
    {
        const string tablename = "[dbo].[IIdleRelation]";
        DataTable dataTable = GetData.GetIIdleRelation();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIItem(string server, string db)
    {
        const string tablename = "[dbo].[IItem]";
        DataTable dataTable = GetData.GetIItem();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIItemOrList(string server, string db)
    {
        const string tablename = "[dbo].[IItemOrList]";
        DataTable dataTable = GetData.GetIItemOrList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIKeywordLinkedReference(string server, string db)
    {
        const string tablename = "[dbo].[IKeywordLinkedReference]";
        DataTable dataTable = GetData.GetIKeywordLinkedReference();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIKnowable(string server, string db)
    {
        const string tablename = "[dbo].[IKnowable]";
        DataTable dataTable = GetData.GetIKnowable();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillILockList(string server, string db)
    {
        const string tablename = "[dbo].[ILockList]";
        DataTable dataTable = GetData.GetILockList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillImageSpace(string server, string db)
    {
        const string tablename = "[dbo].[ImageSpace]";
        DataTable dataTable = GetData.GetImageSpace();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillImageSpaceAdapter(string server, string db)
    {
        const string tablename = "[dbo].[ImageSpaceAdapter]";
        DataTable dataTable = GetData.GetImageSpaceAdapter();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIMagicItem(string server, string db)
    {
        const string tablename = "[dbo].[IMagicItem]";
        DataTable dataTable = GetData.GetIMagicItem();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillImpact(string server, string db)
    {
        const string tablename = "[dbo].[Impact]";
        DataTable dataTable = GetData.GetImpact();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillImpactDataSet(string server, string db)
    {
        const string tablename = "[dbo].[ImpactDataSet]";
        DataTable dataTable = GetData.GetImpactDataSet();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIngestible(string server, string db)
    {
        const string tablename = "[dbo].[Ingestible]";
        DataTable dataTable = GetData.GetIngestible();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIngredient(string server, string db)
    {
        const string tablename = "[dbo].[Ingredient]";
        DataTable dataTable = GetData.GetIngredient();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillINpcOrList(string server, string db)
    {
        const string tablename = "[dbo].[INpcOrList]";
        DataTable dataTable = GetData.GetINpcOrList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillINpcSpawn(string server, string db)
    {
        const string tablename = "[dbo].[INpcSpawn]";
        DataTable dataTable = GetData.GetINpcSpawn();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIObjectId(string server, string db)
    {
        const string tablename = "[dbo].[IObjectId]";
        DataTable dataTable = GetData.GetIObjectId();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIOutfitTarget(string server, string db)
    {
        const string tablename = "[dbo].[IOutfitTarget]";
        DataTable dataTable = GetData.GetIOutfitTarget();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIOwner(string server, string db)
    {
        const string tablename = "[dbo].[IOwner]";
        DataTable dataTable = GetData.GetIOwner();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIPlaceableObject(string server, string db)
    {
        const string tablename = "[dbo].[IPlaceableObject]";
        DataTable dataTable = GetData.GetIPlaceableObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIPlaced(string server, string db)
    {
        const string tablename = "[dbo].[IPlaced]";
        DataTable dataTable = GetData.GetIPlaced();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIPlacedSimple(string server, string db)
    {
        const string tablename = "[dbo].[IPlacedSimple]";
        DataTable dataTable = GetData.GetIPlacedSimple();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIPlacedThing(string server, string db)
    {
        const string tablename = "[dbo].[IPlacedThing]";
        DataTable dataTable = GetData.GetIPlacedThing();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIPlacedTrapTarget(string server, string db)
    {
        const string tablename = "[dbo].[IPlacedTrapTarget]";
        DataTable dataTable = GetData.GetIPlacedTrapTarget();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIReferenceableObject(string server, string db)
    {
        const string tablename = "[dbo].[IReferenceableObject]";
        DataTable dataTable = GetData.GetIReferenceableObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIRegionTarget(string server, string db)
    {
        const string tablename = "[dbo].[IRegionTarget]";
        DataTable dataTable = GetData.GetIRegionTarget();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIRelatable(string server, string db)
    {
        const string tablename = "[dbo].[IRelatable]";
        DataTable dataTable = GetData.GetIRelatable();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillISound(string server, string db)
    {
        const string tablename = "[dbo].[ISound]";
        DataTable dataTable = GetData.GetISound();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillISpellOrList(string server, string db)
    {
        const string tablename = "[dbo].[ISpellOrList]";
        DataTable dataTable = GetData.GetISpellOrList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillISpellRecord(string server, string db)
    {
        const string tablename = "[dbo].[ISpellRecord]";
        DataTable dataTable = GetData.GetISpellRecord();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIVoiceTypeOrList(string server, string db)
    {
        const string tablename = "[dbo].[IVoiceTypeOrList]";
        DataTable dataTable = GetData.GetIVoiceTypeOrList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIWeaponOrList(string server, string db)
    {
        const string tablename = "[dbo].[IWeaponOrList]";
        DataTable dataTable = GetData.GetIWeaponOrList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillIWorldspaceOrList(string server, string db)
    {
        const string tablename = "[dbo].[IWorldspaceOrList]";
        DataTable dataTable = GetData.GetIWorldspaceOrList();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillKey(string server, string db)
    {
        const string tablename = "[dbo].[Key]";
        DataTable dataTable = GetData.GetKey();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillKeyword(string server, string db)
    {
        const string tablename = "[dbo].[Keyword]";
        DataTable dataTable = GetData.GetKeyword();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLandscape(string server, string db)
    {
        const string tablename = "[dbo].[Landscape]";
        DataTable dataTable = GetData.GetLandscape();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLandscapeTexture(string server, string db)
    {
        const string tablename = "[dbo].[LandscapeTexture]";
        DataTable dataTable = GetData.GetLandscapeTexture();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLensFlare(string server, string db)
    {
        const string tablename = "[dbo].[LensFlare]";
        DataTable dataTable = GetData.GetLensFlare();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLeveledItem(string server, string db)
    {
        const string tablename = "[dbo].[LeveledItem]";
        DataTable dataTable = GetData.GetLeveledItem();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLeveledNpc(string server, string db)
    {
        const string tablename = "[dbo].[LeveledNpc]";
        DataTable dataTable = GetData.GetLeveledNpc();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLeveledSpell(string server, string db)
    {
        const string tablename = "[dbo].[LeveledSpell]";
        DataTable dataTable = GetData.GetLeveledSpell();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLight(string server, string db)
    {
        const string tablename = "[dbo].[Light]";
        DataTable dataTable = GetData.GetLight();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLightingTemplate(string server, string db)
    {
        const string tablename = "[dbo].[LightingTemplate]";
        DataTable dataTable = GetData.GetLightingTemplate();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLoadScreen(string server, string db)
    {
        const string tablename = "[dbo].[LoadScreen]";
        DataTable dataTable = GetData.GetLoadScreen();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLocation(string server, string db)
    {
        const string tablename = "[dbo].[Location]";
        DataTable dataTable = GetData.GetLocation();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillLocationReferenceType(string server, string db)
    {
        const string tablename = "[dbo].[LocationReferenceType]";
        DataTable dataTable = GetData.GetLocationReferenceType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMagicEffect(string server, string db)
    {
        const string tablename = "[dbo].[MagicEffect]";
        DataTable dataTable = GetData.GetMagicEffect();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMaterialObject(string server, string db)
    {
        const string tablename = "[dbo].[MaterialObject]";
        DataTable dataTable = GetData.GetMaterialObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMaterialType(string server, string db)
    {
        const string tablename = "[dbo].[MaterialType]";
        DataTable dataTable = GetData.GetMaterialType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMessage(string server, string db)
    {
        const string tablename = "[dbo].[Message]";
        DataTable dataTable = GetData.GetMessage();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMiscItem(string server, string db)
    {
        const string tablename = "[dbo].[MiscItem]";
        DataTable dataTable = GetData.GetMiscItem();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMoveableStatic(string server, string db)
    {
        const string tablename = "[dbo].[MoveableStatic]";
        DataTable dataTable = GetData.GetMoveableStatic();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMovementType(string server, string db)
    {
        const string tablename = "[dbo].[MovementType]";
        DataTable dataTable = GetData.GetMovementType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMusicTrack(string server, string db)
    {
        const string tablename = "[dbo].[MusicTrack]";
        DataTable dataTable = GetData.GetMusicTrack();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillMusicType(string server, string db)
    {
        const string tablename = "[dbo].[MusicType]";
        DataTable dataTable = GetData.GetMusicType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillNavigationMesh(string server, string db)
    {
        const string tablename = "[dbo].[NavigationMesh]";
        DataTable dataTable = GetData.GetNavigationMesh();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillNavigationMeshInfoMap(string server, string db)
    {
        const string tablename = "[dbo].[NavigationMeshInfoMap]";
        DataTable dataTable = GetData.GetNavigationMeshInfoMap();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillNpc(string server, string db)
    {
        const string tablename = "[dbo].[Npc]";
        DataTable dataTable = GetData.GetNpc();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillObjectEffect(string server, string db)
    {
        const string tablename = "[dbo].[ObjectEffect]";
        DataTable dataTable = GetData.GetObjectEffect();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillOutfit(string server, string db)
    {
        const string tablename = "[dbo].[Outfit]";
        DataTable dataTable = GetData.GetOutfit();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillPackage(string server, string db)
    {
        const string tablename = "[dbo].[Package]";
        DataTable dataTable = GetData.GetPackage();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillPerk(string server, string db)
    {
        const string tablename = "[dbo].[Perk]";
        DataTable dataTable = GetData.GetPerk();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillPlacedNpc(string server, string db)
    {
        const string tablename = "[dbo].[PlacedNpc]";
        DataTable dataTable = GetData.GetPlacedNpc();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillPlacedObject(string server, string db)
    {
        const string tablename = "[dbo].[PlacedObject]";
        DataTable dataTable = GetData.GetPlacedObject();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillProjectile(string server, string db)
    {
        const string tablename = "[dbo].[Projectile]";
        DataTable dataTable = GetData.GetProjectile();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillQuest(string server, string db)
    {
        const string tablename = "[dbo].[Quest]";
        DataTable dataTable = GetData.GetQuest();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillRace(string server, string db)
    {
        const string tablename = "[dbo].[Race]";
        DataTable dataTable = GetData.GetRace();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillRegion(string server, string db)
    {
        const string tablename = "[dbo].[Region]";
        DataTable dataTable = GetData.GetRegion();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillRelationship(string server, string db)
    {
        const string tablename = "[dbo].[Relationship]";
        DataTable dataTable = GetData.GetRelationship();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillReverbParameters(string server, string db)
    {
        const string tablename = "[dbo].[ReverbParameters]";
        DataTable dataTable = GetData.GetReverbParameters();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillScene(string server, string db)
    {
        const string tablename = "[dbo].[Scene]";
        DataTable dataTable = GetData.GetScene();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillScroll(string server, string db)
    {
        const string tablename = "[dbo].[Scroll]";
        DataTable dataTable = GetData.GetScroll();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillShaderParticleGeometry(string server, string db)
    {
        const string tablename = "[dbo].[ShaderParticleGeometry]";
        DataTable dataTable = GetData.GetShaderParticleGeometry();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillShout(string server, string db)
    {
        const string tablename = "[dbo].[Shout]";
        DataTable dataTable = GetData.GetShout();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSkyrimMajorRecord(string server, string db)
    {
        const string tablename = "[dbo].[SkyrimMajorRecord]";
        DataTable dataTable = GetData.GetSkyrimMajorRecord();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSoulGem(string server, string db)
    {
        const string tablename = "[dbo].[SoulGem]";
        DataTable dataTable = GetData.GetSoulGem();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSoundCategory(string server, string db)
    {
        const string tablename = "[dbo].[SoundCategory]";
        DataTable dataTable = GetData.GetSoundCategory();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSoundDescriptor(string server, string db)
    {
        const string tablename = "[dbo].[SoundDescriptor]";
        DataTable dataTable = GetData.GetSoundDescriptor();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSoundMarker(string server, string db)
    {
        const string tablename = "[dbo].[SoundMarker]";
        DataTable dataTable = GetData.GetSoundMarker();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSoundOutputModel(string server, string db)
    {
        const string tablename = "[dbo].[SoundOutputModel]";
        DataTable dataTable = GetData.GetSoundOutputModel();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillSpell(string server, string db)
    {
        const string tablename = "[dbo].[Spell]";
        DataTable dataTable = GetData.GetSpell();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillStatic(string server, string db)
    {
        const string tablename = "[dbo].[Static]";
        DataTable dataTable = GetData.GetStatic();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillTalkingActivator(string server, string db)
    {
        const string tablename = "[dbo].[TalkingActivator]";
        DataTable dataTable = GetData.GetTalkingActivator();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillTextureSet(string server, string db)
    {
        const string tablename = "[dbo].[TextureSet]";
        DataTable dataTable = GetData.GetTextureSet();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillTree(string server, string db)
    {
        const string tablename = "[dbo].[Tree]";
        DataTable dataTable = GetData.GetTree();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillVisualEffect(string server, string db)
    {
        const string tablename = "[dbo].[VisualEffect]";
        DataTable dataTable = GetData.GetVisualEffect();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillVoiceType(string server, string db)
    {
        const string tablename = "[dbo].[VoiceType]";
        DataTable dataTable = GetData.GetVoiceType();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillVolumetricLighting(string server, string db)
    {
        const string tablename = "[dbo].[VolumetricLighting]";
        DataTable dataTable = GetData.GetVolumetricLighting();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillWater(string server, string db)
    {
        const string tablename = "[dbo].[Water]";
        DataTable dataTable = GetData.GetWater();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillWeather(string server, string db)
    {
        const string tablename = "[dbo].[Weather]";
        DataTable dataTable = GetData.GetWeather();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillWordOfPower(string server, string db)
    {
        const string tablename = "[dbo].[WordOfPower]";
        DataTable dataTable = GetData.GetWordOfPower();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }

    public static void FillWorldspace(string server, string db)
    {
        const string tablename = "[dbo].[Worldspace]";
        DataTable dataTable = GetData.GetWorldSpace();
        CreateAndFillTables.CreateTable(server, db, tablename, dataTable);
        CreateAndFillTables.FillTable(server, db, tablename, dataTable);
    }
}