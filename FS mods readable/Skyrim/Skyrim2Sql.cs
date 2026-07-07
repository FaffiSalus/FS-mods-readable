using FS_mods_readable.Core.SQL;

namespace FS_mods_readable.Skyrim;

public static class Skyrim2Sql
{
    public static void FillAllTables()
    {
        FillAcousticSpace();
        FillActionRecord();
        FillActivator();
        FillActorValueInformation();
        FillAddonNode();
        FillAlchemicalApparatus();
        FillAmmunition();
        FillAnimatedObject();
        FillAPlacedTrap();
        FillArmor();
        FillArmorAddon();
        FillArtObject();
        FillAssociationType();
        FillAStoryManagerNode();
        FillBodyPartData();
        FillBook();
        FillCameraPath();
        FillCameraShot();
        FillCell();
        FillClass();
        FillClimate();
        FillCollisionLayer();
        FillColorRecord();
        FillCombatStyle();
        FillConstructibleObject();
        FillContainer();
        FillDebris();
        FillDefaultObjectManager();
        FillDialogBranch();
        FillDialogResponses();
        FillDialogTopic();
        FillDialogView();
        FillDoor();
        FillDualCastData();
        FillEffectShader();
        FillEncounterZone();
        FillEquipType();
        FillExplosion();
        FillEyes();
        FillFaction();
        FillFlora();
        FillFootstep();
        FillFootstepSet();
        FillFormList();
        FillFurniture();
        FillGameSetting();
        FillGlobal();
        FillGrass();
        FillHair();
        FillHazard();
        FillHeadPart();
        // FillIAliasVoiceType();
        // FillIBindableEquipment();
        // FillIComplexLocation();
        // FillIConstructible();
        FillIdleAnimation();
        FillIdleMarker();
        // FillIEffectRecord();
        // FillIEmittance();
        // FillIExplodeSpawn();
        // FillIHarvestTarget();
        // FillIIdleRelation();
        // FillIItem();
        // FillIItemOrList();
        // FillIKeywordLinkedReference();
        // FillIKnowable();
        // FillILockList();
        FillImageSpace();
        FillImageSpaceAdapter();
        // FillIMagicItem();
        FillImpact();
        FillImpactDataSet();
        FillIngestible();
        FillIngredient();
        // FillINpcOrList();
        // FillINpcSpawn();
        // FillIObjectId();
        // FillIOutfitTarget();
        // FillIOwner();
        // FillIPlaceableObject();
        // FillIPlaced();
        // FillIPlacedSimple();
        // FillIPlacedThing();
        // FillIPlacedTrapTarget();
        // FillIReferenceableObject();
        // FillIRegionTarget();
        // FillIRelatable();
        // FillISound();
        // FillISpellOrList();
        // FillISpellRecord();
        // FillIVoiceTypeOrList();
        // FillIWeaponOrList();
        // FillIWorldspaceOrList();
        FillKey();
        FillKeyword();
        FillLandscape();
        FillLandscapeTexture();
        FillLensFlare();
        FillLeveledItem();
        FillLeveledNpc();
        FillLeveledSpell();
        FillLight();
        FillLightingTemplate();
        FillLoadScreen();
        FillLocation();
        FillLocationReferenceType();
        FillMagicEffect();
        FillMaterialObject();
        FillMaterialType();
        FillMessage();
        FillMiscItem();
        FillMoveableStatic();
        FillMovementType();
        FillMusicTrack();
        FillMusicType();
        FillNavigationMesh();
        FillNavigationMeshInfoMap();
        FillNpc();
        FillObjectEffect();
        FillOutfit();
        FillPackage();
        FillPerk();
        FillPlacedNpc();
        FillPlacedObject();
        FillProjectile();
        FillQuest();
        //FillRace();
        FillRegion();
        FillRelationship();
        FillReverbParameters();
        FillScene();
        FillScroll();
        FillShaderParticleGeometry();
        FillShout();
        //FillSkyrimMajorRecord();
        FillSoulGem();
        FillSoundCategory();
        FillSoundDescriptor();
        FillSoundMarker();
        FillSoundOutputModel();
        FillSpell();
        FillStatic();
        FillTalkingActivator();
        FillTextureSet();
        FillTree();
        FillVisualEffect();
        FillVoiceType();
        FillVolumetricLighting();
        FillWater();
        FillWeapons();
        FillWeather();
        FillWordOfPower();
        FillWorldspace();
    }

    public static void FillAcousticSpace()
    {
        const string tableName = "[dbo].[AcousticSpace]";
        using var dataTable = GetSkyrimData.GetAcousticSpace();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillActionRecord()
    {
        const string tableName = "[dbo].[ActionRecord]";
        using var dataTable = GetSkyrimData.GetActionRecord();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillActivator()
    {
        const string tableName = "[dbo].[Activator]";
        using var dataTable = GetSkyrimData.GetActivator();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillActorValueInformation()
    {
        const string tableName = "[dbo].[ActorValueInformation]";
        using var dataTable = GetSkyrimData.GetActorValueInformation();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAddonNode()
    {
        const string tableName = "[dbo].[AddonNode]";
        using var dataTable = GetSkyrimData.GetAddonNode();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAlchemicalApparatus()
    {
        const string tableName = "[dbo].[AlchemicalApparatus]";
        using var dataTable = GetSkyrimData.GetAlchemicalApparatus();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAmmunition()
    {
        const string tableName = "[dbo].[Ammunition]";
        using var dataTable = GetSkyrimData.GetAmmunition();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAnimatedObject()
    {
        const string tableName = "[dbo].[AnimatedObject]";
        using var dataTable = GetSkyrimData.GetAnimatedObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAPlacedTrap()
    {
        const string tableName = "[dbo].[APlacedTrap]";
        using var dataTable = GetSkyrimData.GetAPlacedTrap();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillArmor()
    {
        const string tableName = "[dbo].[Armor]";
        using var dataTable = GetSkyrimData.GetArmor();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillArmorAddon()
    {
        const string tableName = "[dbo].[ArmorAddon]";
        using var dataTable = GetSkyrimData.GetArmorAddon();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillArtObject()
    {
        const string tableName = "[dbo].[ArtObject]";
        using var dataTable = GetSkyrimData.GetArtObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAssociationType()
    {
        const string tableName = "[dbo].[AssociationType]";
        using var dataTable = GetSkyrimData.GetAssociationType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillAStoryManagerNode()
    {
        const string tableName = "[dbo].[AStoryManagerNode]";
        using var dataTable = GetSkyrimData.GetAStoryManagerNode();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillBodyPartData()
    {
        const string tableName = "[dbo].[BodyPartData]";
        using var dataTable = GetSkyrimData.GetBodyPartData();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillBook()
    {
        const string tableName = "[dbo].[Book]";
        using var dataTable = GetSkyrimData.GetBook();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillCameraPath()
    {
        const string tableName = "[dbo].[CameraPath]";
        using var dataTable = GetSkyrimData.GetCameraPath();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillCameraShot()
    {
        const string tableName = "[dbo].[CameraShot]";
        using var dataTable = GetSkyrimData.GetCameraShot();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillCell()
    {
        const string tableName = "[dbo].[Cell]";
        using var dataTable = GetSkyrimData.GetCell();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillClass()
    {
        const string tableName = "[dbo].[Class]";
        using var dataTable = GetSkyrimData.GetClass();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillClimate()
    {
        const string tableName = "[dbo].[Climate]";
        using var dataTable = GetSkyrimData.GetClimate();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillCollisionLayer()
    {
        const string tableName = "[dbo].[CollisionLayer]";
        using var dataTable = GetSkyrimData.GetCollisionLayer();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillColorRecord()
    {
        const string tableName = "[dbo].[ColorRecord]";
        using var dataTable = GetSkyrimData.GetColorRecord();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillCombatStyle()
    {
        const string tableName = "[dbo].[CombatStyle]";
        using var dataTable = GetSkyrimData.GetCombatStyle();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillConstructibleObject()
    {
        const string tableName = "[dbo].[ConstructibleObject]";
        using var dataTable = GetSkyrimData.GetConstructibleObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillContainer()
    {
        const string tableName = "[dbo].[Container]";
        using var dataTable = GetSkyrimData.GetContainer();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDebris()
    {
        const string tableName = "[dbo].[Debris]";
        using var dataTable = GetSkyrimData.GetDebris();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDefaultObjectManager()
    {
        const string tableName = "[dbo].[DefaultObjectManager]";
        using var dataTable = GetSkyrimData.GetDefaultObjectManager();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDialogBranch()
    {
        const string tableName = "[dbo].[DialogBranch]";
        using var dataTable = GetSkyrimData.GetDialogBranch();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDialogResponses()
    {
        const string tableName = "[dbo].[DialogResponses]";
        using var dataTable = GetSkyrimData.GetDialogResponses();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDialogTopic()
    {
        const string tableName = "[dbo].[DialogTopic]";
        using var dataTable = GetSkyrimData.GetDialogTopic();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDialogView()
    {
        const string tableName = "[dbo].[DialogView]";
        using var dataTable = GetSkyrimData.GetDialogView();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDoor()
    {
        const string tableName = "[dbo].[Door]";
        using var dataTable = GetSkyrimData.GetDoor();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillDualCastData()
    {
        const string tableName = "[dbo].[DualCastData]";
        using var dataTable = GetSkyrimData.GetDualCastData();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillEffectShader()
    {
        const string tableName = "[dbo].[EffectShader]";
        using var dataTable = GetSkyrimData.GetEffectShader();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillEncounterZone()
    {
        const string tableName = "[dbo].[EncounterZone]";
        using var dataTable = GetSkyrimData.GetEncounterZone();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillEquipType()
    {
        const string tableName = "[dbo].[EquipType]";
        using var dataTable = GetSkyrimData.GetEquipType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillExplosion()
    {
        const string tableName = "[dbo].[Explosion]";
        using var dataTable = GetSkyrimData.GetExplosion();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillEyes()
    {
        const string tableName = "[dbo].[Eyes]";
        using var dataTable = GetSkyrimData.GetEyes();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillFaction()
    {
        const string tableName = "[dbo].[Faction]";
        using var dataTable = GetSkyrimData.GetFaction();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillFlora()
    {
        const string tableName = "[dbo].[Flora]";
        using var dataTable = GetSkyrimData.GetFlora();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillFootstep()
    {
        const string tableName = "[dbo].[Footstep]";
        using var dataTable = GetSkyrimData.GetFootstep();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillFootstepSet()
    {
        const string tableName = "[dbo].[FootstepSet]";
        using var dataTable = GetSkyrimData.GetFootstepSet();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillFormList()
    {
        const string tableName = "[dbo].[FormList]";
        using var dataTable = GetSkyrimData.GetFormList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillFurniture()
    {
        const string tableName = "[dbo].[Furniture]";
        using var dataTable = GetSkyrimData.GetFurniture();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillGameSetting()
    {
        const string tableName = "[dbo].[GameSetting]";
        using var dataTable = GetSkyrimData.GetGameSetting();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillGlobal()
    {
        const string tableName = "[dbo].[Global]";
        using var dataTable = GetSkyrimData.GetGlobal();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillGrass()
    {
        const string tableName = "[dbo].[Grass]";
        using var dataTable = GetSkyrimData.GetGrass();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillHair()
    {
        const string tableName = "[dbo].[Hair]";
        using var dataTable = GetSkyrimData.GetHair();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillHazard()
    {
        const string tableName = "[dbo].[Hazard]";
        using var dataTable = GetSkyrimData.GetHazard();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillHeadPart()
    {
        const string tableName = "[dbo].[HeadPart]";
        using var dataTable = GetSkyrimData.GetHeadPart();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIAliasVoiceType()
    {
        const string tableName = "[dbo].[IAliasVoiceType]";
        using var dataTable = GetSkyrimData.GetIAliasVoiceType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIBindableEquipment()
    {
        const string tableName = "[dbo].[IBindableEquipment]";
        using var dataTable = GetSkyrimData.GetIBindableEquipment();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIComplexLocation()
    {
        const string tableName = "[dbo].[IComplexLocation]";
        using var dataTable = GetSkyrimData.GetIComplexLocation();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIConstructible()
    {
        const string tableName = "[dbo].[IConstructible]";
        using var dataTable = GetSkyrimData.GetIConstructible();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIdleAnimation()
    {
        const string tableName = "[dbo].[IdleAnimation]";
        using var dataTable = GetSkyrimData.GetIdleAnimation();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIdleMarker()
    {
        const string tableName = "[dbo].[IdleMarker]";
        using var dataTable = GetSkyrimData.GetIdleMarker();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIEffectRecord()
    {
        const string tableName = "[dbo].[IEffectRecord]";
        using var dataTable = GetSkyrimData.GetIEffectRecord();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIEmittance()
    {
        const string tableName = "[dbo].[IEmittance]";
        using var dataTable = GetSkyrimData.GetIEmittance();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIExplodeSpawn()
    {
        const string tableName = "[dbo].[IExplodeSpawn]";
        using var dataTable = GetSkyrimData.GetIExplodeSpawn();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIHarvestTarget()
    {
        const string tableName = "[dbo].[IHarvestTarget]";
        using var dataTable = GetSkyrimData.GetIHarvestTarget();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIIdleRelation()
    {
        const string tableName = "[dbo].[IIdleRelation]";
        using var dataTable = GetSkyrimData.GetIIdleRelation();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIItem()
    {
        const string tableName = "[dbo].[IItem]";
        using var dataTable = GetSkyrimData.GetIItem();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIItemOrList()
    {
        const string tableName = "[dbo].[IItemOrList]";
        using var dataTable = GetSkyrimData.GetIItemOrList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIKeywordLinkedReference()
    {
        const string tableName = "[dbo].[IKeywordLinkedReference]";
        using var dataTable = GetSkyrimData.GetIKeywordLinkedReference();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIKnowable()
    {
        const string tableName = "[dbo].[IKnowable]";
        using var dataTable = GetSkyrimData.GetIKnowable();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillILockList()
    {
        const string tableName = "[dbo].[ILockList]";
        using var dataTable = GetSkyrimData.GetILockList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillImageSpace()
    {
        const string tableName = "[dbo].[ImageSpace]";
        using var dataTable = GetSkyrimData.GetImageSpace();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillImageSpaceAdapter()
    {
        const string tableName = "[dbo].[ImageSpaceAdapter]";
        using var dataTable = GetSkyrimData.GetImageSpaceAdapter();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIMagicItem()
    {
        const string tableName = "[dbo].[IMagicItem]";
        using var dataTable = GetSkyrimData.GetIMagicItem();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillImpact()
    {
        const string tableName = "[dbo].[Impact]";
        using var dataTable = GetSkyrimData.GetImpact();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillImpactDataSet()
    {
        const string tableName = "[dbo].[ImpactDataSet]";
        using var dataTable = GetSkyrimData.GetImpactDataSet();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIngestible()
    {
        const string tableName = "[dbo].[Ingestible]";
        using var dataTable = GetSkyrimData.GetIngestible();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIngredient()
    {
        const string tableName = "[dbo].[Ingredient]";
        using var dataTable = GetSkyrimData.GetIngredient();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillINpcOrList()
    {
        const string tableName = "[dbo].[INpcOrList]";
        using var dataTable = GetSkyrimData.GetINpcOrList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillINpcSpawn()
    {
        const string tableName = "[dbo].[INpcSpawn]";
        using var dataTable = GetSkyrimData.GetINpcSpawn();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIObjectId()
    {
        const string tableName = "[dbo].[IObjectId]";
        using var dataTable = GetSkyrimData.GetIObjectId();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIOutfitTarget()
    {
        const string tableName = "[dbo].[IOutfitTarget]";
        using var dataTable = GetSkyrimData.GetIOutfitTarget();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIOwner()
    {
        const string tableName = "[dbo].[IOwner]";
        using var dataTable = GetSkyrimData.GetIOwner();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIPlaceableObject()
    {
        const string tableName = "[dbo].[IPlaceableObject]";
        using var dataTable = GetSkyrimData.GetIPlaceableObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIPlaced()
    {
        const string tableName = "[dbo].[IPlaced]";
        using var dataTable = GetSkyrimData.GetIPlaced();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIPlacedSimple()
    {
        const string tableName = "[dbo].[IPlacedSimple]";
        using var dataTable = GetSkyrimData.GetIPlacedSimple();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIPlacedThing()
    {
        const string tableName = "[dbo].[IPlacedThing]";
        using var dataTable = GetSkyrimData.GetIPlacedThing();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIPlacedTrapTarget()
    {
        const string tableName = "[dbo].[IPlacedTrapTarget]";
        using var dataTable = GetSkyrimData.GetIPlacedTrapTarget();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIReferenceableObject()
    {
        const string tableName = "[dbo].[IReferenceableObject]";
        using var dataTable = GetSkyrimData.GetIReferenceableObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIRegionTarget()
    {
        const string tableName = "[dbo].[IRegionTarget]";
        using var dataTable = GetSkyrimData.GetIRegionTarget();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIRelatable()
    {
        const string tableName = "[dbo].[IRelatable]";
        using var dataTable = GetSkyrimData.GetIRelatable();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillISound()
    {
        const string tableName = "[dbo].[ISound]";
        using var dataTable = GetSkyrimData.GetISound();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillISpellOrList()
    {
        const string tableName = "[dbo].[ISpellOrList]";
        using var dataTable = GetSkyrimData.GetISpellOrList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillISpellRecord()
    {
        const string tableName = "[dbo].[ISpellRecord]";
        using var dataTable = GetSkyrimData.GetISpellRecord();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIVoiceTypeOrList()
    {
        const string tableName = "[dbo].[IVoiceTypeOrList]";
        using var dataTable = GetSkyrimData.GetIVoiceTypeOrList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIWeaponOrList()
    {
        const string tableName = "[dbo].[IWeaponOrList]";
        using var dataTable = GetSkyrimData.GetIWeaponOrList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillIWorldspaceOrList()
    {
        const string tableName = "[dbo].[IWorldspaceOrList]";
        using var dataTable = GetSkyrimData.GetIWorldspaceOrList();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillKey()
    {
        const string tableName = "[dbo].[Key]";
        using var dataTable = GetSkyrimData.GetKey();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillKeyword()
    {
        const string tableName = "[dbo].[Keyword]";
        using var dataTable = GetSkyrimData.GetKeyword();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLandscape()
    {
        const string tableName = "[dbo].[Landscape]";
        using var dataTable = GetSkyrimData.GetLandscape();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLandscapeTexture()
    {
        const string tableName = "[dbo].[LandscapeTexture]";
        using var dataTable = GetSkyrimData.GetLandscapeTexture();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLensFlare()
    {
        const string tableName = "[dbo].[LensFlare]";
        using var dataTable = GetSkyrimData.GetLensFlare();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLeveledItem()
    {
        const string tableName = "[dbo].[LeveledItem]";
        using var dataTable = GetSkyrimData.GetLeveledItem();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLeveledNpc()
    {
        const string tableName = "[dbo].[LeveledNpc]";
        using var dataTable = GetSkyrimData.GetLeveledNpc();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLeveledSpell()
    {
        const string tableName = "[dbo].[LeveledSpell]";
        using var dataTable = GetSkyrimData.GetLeveledSpell();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLight()
    {
        const string tableName = "[dbo].[Light]";
        using var dataTable = GetSkyrimData.GetLight();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLightingTemplate()
    {
        const string tableName = "[dbo].[LightingTemplate]";
        using var dataTable = GetSkyrimData.GetLightingTemplate();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLoadScreen()
    {
        const string tableName = "[dbo].[LoadScreen]";
        using var dataTable = GetSkyrimData.GetLoadScreen();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLocation()
    {
        const string tableName = "[dbo].[Location]";
        using var dataTable = GetSkyrimData.GetLocation();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillLocationReferenceType()
    {
        const string tableName = "[dbo].[LocationReferenceType]";
        using var dataTable = GetSkyrimData.GetLocationReferenceType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMagicEffect()
    {
        const string tableName = "[dbo].[MagicEffect]";
        using var dataTable = GetSkyrimData.GetMagicEffect();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMaterialObject()
    {
        const string tableName = "[dbo].[MaterialObject]";
        using var dataTable = GetSkyrimData.GetMaterialObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMaterialType()
    {
        const string tableName = "[dbo].[MaterialType]";
        using var dataTable = GetSkyrimData.GetMaterialType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMessage()
    {
        const string tableName = "[dbo].[Message]";
        using var dataTable = GetSkyrimData.GetMessage();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMiscItem()
    {
        const string tableName = "[dbo].[MiscItem]";
        using var dataTable = GetSkyrimData.GetMiscItem();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMoveableStatic()
    {
        const string tableName = "[dbo].[MoveableStatic]";
        using var dataTable = GetSkyrimData.GetMoveableStatic();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMovementType()
    {
        const string tableName = "[dbo].[MovementType]";
        using var dataTable = GetSkyrimData.GetMovementType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMusicTrack()
    {
        const string tableName = "[dbo].[MusicTrack]";
        using var dataTable = GetSkyrimData.GetMusicTrack();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillMusicType()
    {
        const string tableName = "[dbo].[MusicType]";
        using var dataTable = GetSkyrimData.GetMusicType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillNavigationMesh()
    {
        const string tableName = "[dbo].[NavigationMesh]";
        using var dataTable = GetSkyrimData.GetNavigationMesh();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillNavigationMeshInfoMap()
    {
        const string tableName = "[dbo].[NavigationMeshInfoMap]";
        using var dataTable = GetSkyrimData.GetNavigationMeshInfoMap();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillNpc()
    {
        const string tableName = "[dbo].[Npc]";
        using var dataTable = GetSkyrimData.GetNpc();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillObjectEffect()
    {
        const string tableName = "[dbo].[ObjectEffect]";
        using var dataTable = GetSkyrimData.GetObjectEffect();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillOutfit()
    {
        const string tableName = "[dbo].[Outfit]";
        using var dataTable = GetSkyrimData.GetOutfit();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillPackage()
    {
        const string tableName = "[dbo].[Package]";
        using var dataTable = GetSkyrimData.GetPackage();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillPerk()
    {
        const string tableName = "[dbo].[Perk]";
        using var dataTable = GetSkyrimData.GetPerk();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillPlacedNpc()
    {
        const string tableName = "[dbo].[PlacedNpc]";
        using var dataTable = GetSkyrimData.GetPlacedNpc();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillPlacedObject()
    {
        const string tableName = "[dbo].[PlacedObject]";
        using var dataTable = GetSkyrimData.GetPlacedObject();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillProjectile()
    {
        const string tableName = "[dbo].[Projectile]";
        using var dataTable = GetSkyrimData.GetProjectile();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillQuest()
    {
        const string tableName = "[dbo].[Quest]";
        using var dataTable = GetSkyrimData.GetQuest();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillRace()
    {
        const string tableName = "[dbo].[Race]";
        using var dataTable = GetSkyrimData.GetRace();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillRegion()
    {
        const string tableName = "[dbo].[Region]";
        using var dataTable = GetSkyrimData.GetRegion();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillRelationship()
    {
        const string tableName = "[dbo].[Relationship]";
        using var dataTable = GetSkyrimData.GetRelationship();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillReverbParameters()
    {
        const string tableName = "[dbo].[ReverbParameters]";
        using var dataTable = GetSkyrimData.GetReverbParameters();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillScene()
    {
        const string tableName = "[dbo].[Scene]";
        using var dataTable = GetSkyrimData.GetScene();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillScroll()
    {
        const string tableName = "[dbo].[Scroll]";
        using var dataTable = GetSkyrimData.GetScroll();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillShaderParticleGeometry()
    {
        const string tableName = "[dbo].[ShaderParticleGeometry]";
        using var dataTable = GetSkyrimData.GetShaderParticleGeometry();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillShout()
    {
        const string tableName = "[dbo].[Shout]";
        using var dataTable = GetSkyrimData.GetShout();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSkyrimMajorRecord()
    {
        const string tableName = "[dbo].[SkyrimMajorRecord]";
        using var dataTable = GetSkyrimData.GetSkyrimMajorRecord();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSoulGem()
    {
        const string tableName = "[dbo].[SoulGem]";
        using var dataTable = GetSkyrimData.GetSoulGem();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSoundCategory()
    {
        const string tableName = "[dbo].[SoundCategory]";
        using var dataTable = GetSkyrimData.GetSoundCategory();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSoundDescriptor()
    {
        const string tableName = "[dbo].[SoundDescriptor]";
        using var dataTable = GetSkyrimData.GetSoundDescriptor();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSoundMarker()
    {
        const string tableName = "[dbo].[SoundMarker]";
        using var dataTable = GetSkyrimData.GetSoundMarker();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSoundOutputModel()
    {
        const string tableName = "[dbo].[SoundOutputModel]";
        using var dataTable = GetSkyrimData.GetSoundOutputModel();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillSpell()
    {
        const string tableName = "[dbo].[Spell]";
        using var dataTable = GetSkyrimData.GetSpell();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillStatic()
    {
        const string tableName = "[dbo].[Static]";
        using var dataTable = GetSkyrimData.GetStatic();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillTalkingActivator()
    {
        const string tableName = "[dbo].[TalkingActivator]";
        using var dataTable = GetSkyrimData.GetTalkingActivator();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillTextureSet()
    {
        const string tableName = "[dbo].[TextureSet]";
        using var dataTable = GetSkyrimData.GetTextureSet();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillTree()
    {
        const string tableName = "[dbo].[Tree]";
        using var dataTable = GetSkyrimData.GetTree();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillVisualEffect()
    {
        const string tableName = "[dbo].[VisualEffect]";
        using var dataTable = GetSkyrimData.GetVisualEffect();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillVoiceType()
    {
        const string tableName = "[dbo].[VoiceType]";
        using var dataTable = GetSkyrimData.GetVoiceType();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillVolumetricLighting()
    {
        const string tableName = "[dbo].[VolumetricLighting]";
        using var dataTable = GetSkyrimData.GetVolumetricLighting();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillWater()
    {
        const string tableName = "[dbo].[Water]";
        using var dataTable = GetSkyrimData.GetWater();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillWeapons()
    {
        const string tableName = "[dbo].[Weapon]";
        using var dataTable = GetSkyrimData.GetWeapon();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillWeather()
    {
        const string tableName = "[dbo].[Weather]";
        using var dataTable = GetSkyrimData.GetWeather();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillWordOfPower()
    {
        const string tableName = "[dbo].[WordOfPower]";
        using var dataTable = GetSkyrimData.GetWordOfPower();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }

    public static void FillWorldspace()
    {
        const string tableName = "[dbo].[Worldspace]";
        using var dataTable = GetSkyrimData.GetWorldSpace();
        CreateAndFillTables.CreateTable(tableName, dataTable);
        CreateAndFillTables.FillTable(tableName, dataTable);
    }
}