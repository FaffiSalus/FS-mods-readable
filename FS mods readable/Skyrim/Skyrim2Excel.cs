using FS_mods_readable.Core.Excel;

namespace FS_mods_readable.Skyrim;

public static class Skyrim2Excel
{
    public static void FillAllFiles(string filePath)
    {
        string fileName = filePath + "\\Mods.xlsx";
        FillAcousticSpace(fileName);
        FillActionRecord(fileName);
        FillActivator(fileName);
        FillActorValueInformation(fileName);
        FillAddonNode(fileName);
        FillAlchemicalApparatus(fileName);
        FillAmmunition(fileName);
        FillAnimatedObject(fileName);
        FillAPlacedTrap(fileName);
        FillArmor(fileName);
        FillArmorAddon(fileName);
        FillArtObject(fileName);
        FillAssociationType(fileName);
        FillAStoryManagerNode(fileName);
        FillBodyPartData(fileName);
        //FillBook(fileName); Cells cannot hold enough characters
        FillCameraPath(fileName);
        FillCameraShot(fileName);
        FillCell(fileName);
        FillClass(fileName);
        FillClimate(fileName);
        FillCollisionLayer(fileName);
        FillColorRecord(fileName);
        FillCombatStyle(fileName);
        FillConstructibleObject(fileName);
        FillContainer(fileName);
        FillDebris(fileName);
        FillDefaultObjectManager(fileName);
        FillDialogBranch(fileName);
        FillDialogResponses(fileName);
        FillDialogTopic(fileName);
        FillDialogView(fileName);
        FillDoor(fileName);
        FillDualCastData(fileName);
        FillEffectShader(fileName);
        FillEncounterZone(fileName);
        FillEquipType(fileName);
        FillExplosion(fileName);
        FillEyes(fileName);
        FillFaction(fileName);
        FillFlora(fileName);
        FillFootstep(fileName);
        FillFootstepSet(fileName);
        FillFormList(fileName);
        FillFurniture(fileName);
        FillGameSetting(fileName);
        FillGlobal(fileName);
        FillGrass(fileName);
        FillHair(fileName);
        FillHazard(fileName);
        FillHeadPart(fileName);
	    FillIdleAnimation(fileName);
        FillIdleMarker(fileName);
	    FillImageSpace(fileName);
        FillImageSpaceAdapter(fileName);
	    FillImpact(fileName);
        FillImpactDataSet(fileName);
        FillIngestible(fileName);
        FillIngredient(fileName);
	    FillKey(fileName);
        FillKeyword(fileName);
        FillLandscape(fileName);
        FillLandscapeTexture(fileName);
        FillLensFlare(fileName);
        FillLeveledItem(fileName);
        FillLeveledNpc(fileName);
        FillLeveledSpell(fileName);
        FillLight(fileName);
        FillLightingTemplate(fileName);
        FillLoadScreen(fileName);
        FillLocation(fileName);
        FillLocationReferenceType(fileName);
        FillMagicEffect(fileName);
        FillMaterialObject(fileName);
        FillMaterialType(fileName);
        FillMessage(fileName);
        FillMiscItem(fileName);
        FillMoveableStatic(fileName);
        FillMovementType(fileName);
        FillMusicTrack(fileName);
        FillMusicType(fileName);
        FillNavigationMesh(fileName);
        FillNavigationMeshInfoMap(fileName);
        FillNpc(fileName);
        FillObjectEffect(fileName);
        FillOutfit(fileName);
        FillPackage(fileName);
        FillPerk(fileName);
        FillPlacedNpc(fileName);
        FillPlacedObject(fileName);
        FillProjectile(fileName);
        FillQuest(fileName);
        //FillRace(fileName);
        FillRegion(fileName);
        FillRelationship(fileName);
        FillReverbParameters(fileName);
        FillScene(fileName);
        FillScroll(fileName);
        FillShaderParticleGeometry(fileName);
        FillShout(fileName);
	    FillSoulGem(fileName);
        FillSoundCategory(fileName);
        FillSoundDescriptor(fileName);
        FillSoundMarker(fileName);
        FillSoundOutputModel(fileName);
        FillSpell(fileName);
        FillStatic(fileName);
        FillTalkingActivator(fileName);
        FillTextureSet(fileName);
        FillTree(fileName);
        FillVisualEffect(fileName);
        FillVoiceType(fileName);
        FillVolumetricLighting(fileName);
        FillWater(fileName);
        FillWeapons(fileName);
        FillWeather(fileName);
        FillWordOfPower(fileName);
        FillWorldspace(fileName);
    }
    
    public static void FillAcousticSpace(string fileName)
    {
        const string sheetName = "AcousticSpace";
        DataTable dataTable = GetSkyrimData.GetAcousticSpace();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }
    
    public static void FillActionRecord(string fileName)
    {
        const string sheetName = "ActionRecord";
        DataTable dataTable = GetSkyrimData.GetActionRecord();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillActivator(string fileName)
    {
        const string sheetName = "Activator";
        DataTable dataTable = GetSkyrimData.GetActivator();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillActorValueInformation(string fileName)
    {
        const string sheetName = "ActorValueInformation";
        DataTable dataTable = GetSkyrimData.GetActorValueInformation();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAddonNode(string fileName)
    {
        const string sheetName = "AddonNode";
        DataTable dataTable = GetSkyrimData.GetAddonNode();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAlchemicalApparatus(string fileName)
    {
        const string sheetName = "AlchemicalApparatus";
        DataTable dataTable = GetSkyrimData.GetAlchemicalApparatus();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAmmunition(string fileName)
    {
        const string sheetName = "Ammunition";
        DataTable dataTable = GetSkyrimData.GetAmmunition();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAnimatedObject(string fileName)
    {
        const string sheetName = "AnimatedObject";
        DataTable dataTable = GetSkyrimData.GetAnimatedObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAPlacedTrap(string fileName)
    {
        const string sheetName = "APlacedTrap";
        DataTable dataTable = GetSkyrimData.GetAPlacedTrap();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillArmor(string fileName)
    {
        const string sheetName = "Armor";
        DataTable dataTable = GetSkyrimData.GetArmor();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillArmorAddon(string fileName)
    {
        const string sheetName = "ArmorAddon";
        DataTable dataTable = GetSkyrimData.GetArmorAddon();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillArtObject(string fileName)
    {
        const string sheetName = "ArtObject";
        DataTable dataTable = GetSkyrimData.GetArtObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAssociationType(string fileName)
    {
        const string sheetName = "AssociationType";
        DataTable dataTable = GetSkyrimData.GetAssociationType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillAStoryManagerNode(string fileName)
    {
        const string sheetName = "AStoryManagerNode";
        DataTable dataTable = GetSkyrimData.GetAStoryManagerNode();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillBodyPartData(string fileName)
    {
        const string sheetName = "BodyPartData";
        DataTable dataTable = GetSkyrimData.GetBodyPartData();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillBook(string fileName)
    {
        const string sheetName = "Book";
        DataTable dataTable = GetSkyrimData.GetBook();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillCameraPath(string fileName)
    {
        const string sheetName = "CameraPath";
        DataTable dataTable = GetSkyrimData.GetCameraPath();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillCameraShot(string fileName)
    {
        const string sheetName = "CameraShot";
        DataTable dataTable = GetSkyrimData.GetCameraShot();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillCell(string fileName)
    {
        const string sheetName = "Cell";
        DataTable dataTable = GetSkyrimData.GetCell();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillClass(string fileName)
    {
        const string sheetName = "Class";
        DataTable dataTable = GetSkyrimData.GetClass();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillClimate(string fileName)
    {
        const string sheetName = "Climate";
        DataTable dataTable = GetSkyrimData.GetClimate();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillCollisionLayer(string fileName)
    {
        const string sheetName = "CollisionLayer";
        DataTable dataTable = GetSkyrimData.GetCollisionLayer();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillColorRecord(string fileName)
    {
        const string sheetName = "ColorRecord";
        DataTable dataTable = GetSkyrimData.GetColorRecord();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillCombatStyle(string fileName)
    {
        const string sheetName = "CombatStyle";
        DataTable dataTable = GetSkyrimData.GetCombatStyle();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillConstructibleObject(string fileName)
    {
        const string sheetName = "ConstructibleObject";
        DataTable dataTable = GetSkyrimData.GetConstructibleObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillContainer(string fileName)
    {
        const string sheetName = "Container";
        DataTable dataTable = GetSkyrimData.GetContainer();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDebris(string fileName)
    {
        const string sheetName = "Debris";
        DataTable dataTable = GetSkyrimData.GetDebris();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDefaultObjectManager(string fileName)
    {
        const string sheetName = "DefaultObjectManager";
        DataTable dataTable = GetSkyrimData.GetDefaultObjectManager();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDialogBranch(string fileName)
    {
        const string sheetName = "DialogBranch";
        DataTable dataTable = GetSkyrimData.GetDialogBranch();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDialogResponses(string fileName)
    {
        const string sheetName = "DialogResponses";
        DataTable dataTable = GetSkyrimData.GetDialogResponses();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDialogTopic(string fileName)
    {
        const string sheetName = "DialogTopic";
        DataTable dataTable = GetSkyrimData.GetDialogTopic();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDialogView(string fileName)
    {
        const string sheetName = "DialogView";
        DataTable dataTable = GetSkyrimData.GetDialogView();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDoor(string fileName)
    {
        const string sheetName = "Door";
        DataTable dataTable = GetSkyrimData.GetDoor();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillDualCastData(string fileName)
    {
        const string sheetName = "DualCastData";
        DataTable dataTable = GetSkyrimData.GetDualCastData();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillEffectShader(string fileName)
    {
        const string sheetName = "EffectShader";
        DataTable dataTable = GetSkyrimData.GetEffectShader();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillEncounterZone(string fileName)
    {
        const string sheetName = "EncounterZone";
        DataTable dataTable = GetSkyrimData.GetEncounterZone();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillEquipType(string fileName)
    {
        const string sheetName = "EquipType";
        DataTable dataTable = GetSkyrimData.GetEquipType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillExplosion(string fileName)
    {
        const string sheetName = "Explosions";
        DataTable dataTable = GetSkyrimData.GetExplosion();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillEyes(string fileName)
    {
        const string sheetName = "Eyes";
        DataTable dataTable = GetSkyrimData.GetEyes();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillFaction(string fileName)
    {
        const string sheetName = "Faction";
        DataTable dataTable = GetSkyrimData.GetFaction();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillFlora(string fileName)
    {
        const string sheetName = "Flora";
        DataTable dataTable = GetSkyrimData.GetFlora();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillFootstep(string fileName)
    {
        const string sheetName = "Footstep";
        DataTable dataTable = GetSkyrimData.GetFootstep();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillFootstepSet(string fileName)
    {
        const string sheetName = "FootstepSet";
        DataTable dataTable = GetSkyrimData.GetFootstepSet();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillFormList(string fileName)
    {
        const string sheetName = "FormList";
        DataTable dataTable = GetSkyrimData.GetFormList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillFurniture(string fileName)
    {
        const string sheetName = "Furniture";
        DataTable dataTable = GetSkyrimData.GetFurniture();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillGameSetting(string fileName)
    {
        const string sheetName = "GameSetting";
        DataTable dataTable = GetSkyrimData.GetGameSetting();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillGlobal(string fileName)
    {
        const string sheetName = "Global";
        DataTable dataTable = GetSkyrimData.GetGlobal();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillGrass(string fileName)
    {
        const string sheetName = "Grass";
        DataTable dataTable = GetSkyrimData.GetGrass();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillHair(string fileName)
    {
        const string sheetName = "Hair";
        DataTable dataTable = GetSkyrimData.GetHair();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillHazard(string fileName)
    {
        const string sheetName = "Hazard";
        DataTable dataTable = GetSkyrimData.GetHazard();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillHeadPart(string fileName)
    {
        const string sheetName = "HeadPart";
        DataTable dataTable = GetSkyrimData.GetHeadPart();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIAliasVoiceType(string fileName)
    {
        const string sheetName = "IAliasVoiceType";
        DataTable dataTable = GetSkyrimData.GetIAliasVoiceType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIBindableEquipment(string fileName)
    {
        const string sheetName = "IBindableEquipment";
        DataTable dataTable = GetSkyrimData.GetIBindableEquipment();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIComplexLocation(string fileName)
    {
        const string sheetName = "IComplexLocation";
        DataTable dataTable = GetSkyrimData.GetIComplexLocation();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIConstructible(string fileName)
    {
        const string sheetName = "IConstructible";
        DataTable dataTable = GetSkyrimData.GetIConstructible();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIdleAnimation(string fileName)
    {
        const string sheetName = "IdleAnimation";
        DataTable dataTable = GetSkyrimData.GetIdleAnimation();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIdleMarker(string fileName)
    {
        const string sheetName = "IdleMarker";
        DataTable dataTable = GetSkyrimData.GetIdleMarker();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIEffectRecord(string fileName)
    {
        const string sheetName = "IEffectRecord";
        DataTable dataTable = GetSkyrimData.GetIEffectRecord();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIEmittance(string fileName)
    {
        const string sheetName = "IEmittance";
        DataTable dataTable = GetSkyrimData.GetIEmittance();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIExplodeSpawn(string fileName)
    {
        const string sheetName = "IExplodeSpawn";
        DataTable dataTable = GetSkyrimData.GetIExplodeSpawn();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIHarvestTarget(string fileName)
    {
        const string sheetName = "IHarvestTarget";
        DataTable dataTable = GetSkyrimData.GetIHarvestTarget();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIIdleRelation(string fileName)
    {
        const string sheetName = "IIdleRelation";
        DataTable dataTable = GetSkyrimData.GetIIdleRelation();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIItem(string fileName)
    {
        const string sheetName = "IItem";
        DataTable dataTable = GetSkyrimData.GetIItem();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIItemOrList(string fileName)
    {
        const string sheetName = "IItemOrList";
        DataTable dataTable = GetSkyrimData.GetIItemOrList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIKeywordLinkedReference(string fileName)
    {
        const string sheetName = "IKeywordLinkedReference";
        DataTable dataTable = GetSkyrimData.GetIKeywordLinkedReference();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIKnowable(string fileName)
    {
        const string sheetName = "IKnowable";
        DataTable dataTable = GetSkyrimData.GetIKnowable();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillILockList(string fileName)
    {
        const string sheetName = "ILockList";
        DataTable dataTable = GetSkyrimData.GetILockList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillImageSpace(string fileName)
    {
        const string sheetName = "ImageSpace";
        DataTable dataTable = GetSkyrimData.GetImageSpace();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillImageSpaceAdapter(string fileName)
    {
        const string sheetName = "ImageSpaceAdapter";
        DataTable dataTable = GetSkyrimData.GetImageSpaceAdapter();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIMagicItem(string fileName)
    {
        const string sheetName = "IMagicItem";
        DataTable dataTable = GetSkyrimData.GetIMagicItem();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillImpact(string fileName)
    {
        const string sheetName = "Impact";
        DataTable dataTable = GetSkyrimData.GetImpact();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillImpactDataSet(string fileName)
    {
        const string sheetName = "ImpactDataSet";
        DataTable dataTable = GetSkyrimData.GetImpactDataSet();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIngestible(string fileName)
    {
        const string sheetName = "Ingestible";
        DataTable dataTable = GetSkyrimData.GetIngestible();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIngredient(string fileName)
    {
        const string sheetName = "Ingredient";
        DataTable dataTable = GetSkyrimData.GetIngredient();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillINpcOrList(string fileName)
    {
        const string sheetName = "INpcOrList";
        DataTable dataTable = GetSkyrimData.GetINpcOrList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillINpcSpawn(string fileName)
    {
        const string sheetName = "INpcSpawn";
        DataTable dataTable = GetSkyrimData.GetINpcSpawn();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIObjectId(string fileName)
    {
        const string sheetName = "IObjectId";
        DataTable dataTable = GetSkyrimData.GetIObjectId();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIOutfitTarget(string fileName)
    {
        const string sheetName = "IOutfitTarget";
        DataTable dataTable = GetSkyrimData.GetIOutfitTarget();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIOwner(string fileName)
    {
        const string sheetName = "IOwner";
        DataTable dataTable = GetSkyrimData.GetIOwner();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIPlaceableObject(string fileName)
    {
        const string sheetName = "IPlaceableObject";
        DataTable dataTable = GetSkyrimData.GetIPlaceableObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIPlaced(string fileName)
    {
        const string sheetName = "IPlaced";
        DataTable dataTable = GetSkyrimData.GetIPlaced();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIPlacedSimple(string fileName)
    {
        const string sheetName = "IPlacedSimple";
        DataTable dataTable = GetSkyrimData.GetIPlacedSimple();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIPlacedThing(string fileName)
    {
        const string sheetName = "IPlacedThing";
        DataTable dataTable = GetSkyrimData.GetIPlacedThing();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIPlacedTrapTarget(string fileName)
    {
        const string sheetName = "IPlacedTrapTarget";
        DataTable dataTable = GetSkyrimData.GetIPlacedTrapTarget();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIReferenceableObject(string fileName)
    {
        const string sheetName = "IReferenceableObject";
        DataTable dataTable = GetSkyrimData.GetIReferenceableObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIRegionTarget(string fileName)
    {
        const string sheetName = "IRegionTarget";
        DataTable dataTable = GetSkyrimData.GetIRegionTarget();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIRelatable(string fileName)
    {
        const string sheetName = "IRelatable";
        DataTable dataTable = GetSkyrimData.GetIRelatable();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillISound(string fileName)
    {
        const string sheetName = "ISound";
        DataTable dataTable = GetSkyrimData.GetISound();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillISpellOrList(string fileName)
    {
        const string sheetName = "ISpellOrList";
        DataTable dataTable = GetSkyrimData.GetISpellOrList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillISpellRecord(string fileName)
    {
        const string sheetName = "ISpellRecord";
        DataTable dataTable = GetSkyrimData.GetISpellRecord();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIVoiceTypeOrList(string fileName)
    {
        const string sheetName = "IVoiceTypeOrList";
        DataTable dataTable = GetSkyrimData.GetIVoiceTypeOrList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIWeaponOrList(string fileName)
    {
        const string sheetName = "IWeaponOrList";
        DataTable dataTable = GetSkyrimData.GetIWeaponOrList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillIWorldspaceOrList(string fileName)
    {
        const string sheetName = "IWorldspaceOrList";
        DataTable dataTable = GetSkyrimData.GetIWorldspaceOrList();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillKey(string fileName)
    {
        const string sheetName = "Key";
        DataTable dataTable = GetSkyrimData.GetKey();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillKeyword(string fileName)
    {
        const string sheetName = "Keyword";
        DataTable dataTable = GetSkyrimData.GetKeyword();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLandscape(string fileName)
    {
        const string sheetName = "Landscape";
        DataTable dataTable = GetSkyrimData.GetLandscape();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLandscapeTexture(string fileName)
    {
        const string sheetName = "LandscapeTexture";
        DataTable dataTable = GetSkyrimData.GetLandscapeTexture();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLensFlare(string fileName)
    {
        const string sheetName = "LensFlare";
        DataTable dataTable = GetSkyrimData.GetLensFlare();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLeveledItem(string fileName)
    {
        const string sheetName = "LeveledItem";
        DataTable dataTable = GetSkyrimData.GetLeveledItem();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLeveledNpc(string fileName)
    {
        const string sheetName = "LeveledNpc";
        DataTable dataTable = GetSkyrimData.GetLeveledNpc();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLeveledSpell(string fileName)
    {
        const string sheetName = "LeveledSpell";
        DataTable dataTable = GetSkyrimData.GetLeveledSpell();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLight(string fileName)
    {
        const string sheetName = "Light";
        DataTable dataTable = GetSkyrimData.GetLight();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLightingTemplate(string fileName)
    {
        const string sheetName = "LightingTemplate";
        DataTable dataTable = GetSkyrimData.GetLightingTemplate();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLoadScreen(string fileName)
    {
        const string sheetName = "LoadScreen";
        DataTable dataTable = GetSkyrimData.GetLoadScreen();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLocation(string fileName)
    {
        const string sheetName = "Location";
        DataTable dataTable = GetSkyrimData.GetLocation();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillLocationReferenceType(string fileName)
    {
        const string sheetName = "LocationReferenceType";
        DataTable dataTable = GetSkyrimData.GetLocationReferenceType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMagicEffect(string fileName)
    {
        const string sheetName = "MagicEffect";
        DataTable dataTable = GetSkyrimData.GetMagicEffect();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMaterialObject(string fileName)
    {
        const string sheetName = "MaterialObject";
        DataTable dataTable = GetSkyrimData.GetMaterialObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMaterialType(string fileName)
    {
        const string sheetName = "MaterialType";
        DataTable dataTable = GetSkyrimData.GetMaterialType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMessage(string fileName)
    {
        const string sheetName = "Message";
        DataTable dataTable = GetSkyrimData.GetMessage();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMiscItem(string fileName)
    {
        const string sheetName = "MiscItem";
        DataTable dataTable = GetSkyrimData.GetMiscItem();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMoveableStatic(string fileName)
    {
        const string sheetName = "MoveableStatic";
        DataTable dataTable = GetSkyrimData.GetMoveableStatic();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMovementType(string fileName)
    {
        const string sheetName = "MovementType";
        DataTable dataTable = GetSkyrimData.GetMovementType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMusicTrack(string fileName)
    {
        const string sheetName = "MusicTrack";
        DataTable dataTable = GetSkyrimData.GetMusicTrack();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillMusicType(string fileName)
    {
        const string sheetName = "MusicType";
        DataTable dataTable = GetSkyrimData.GetMusicType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillNavigationMesh(string fileName)
    {
        const string sheetName = "NavigationMesh";
        DataTable dataTable = GetSkyrimData.GetNavigationMesh();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillNavigationMeshInfoMap(string fileName)
    {
        const string sheetName = "NavigationMeshInfoMap";
        DataTable dataTable = GetSkyrimData.GetNavigationMeshInfoMap();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillNpc(string fileName)
    {
        const string sheetName = "Npc";
        DataTable dataTable = GetSkyrimData.GetNpc();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillObjectEffect(string fileName)
    {
        const string sheetName = "ObjectEffect";
        DataTable dataTable = GetSkyrimData.GetObjectEffect();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillOutfit(string fileName)
    {
        const string sheetName = "Outfit";
        DataTable dataTable = GetSkyrimData.GetOutfit();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillPackage(string fileName)
    {
        const string sheetName = "Package";
        DataTable dataTable = GetSkyrimData.GetPackage();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillPerk(string fileName)
    {
        const string sheetName = "Perk";
        DataTable dataTable = GetSkyrimData.GetPerk();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillPlacedNpc(string fileName)
    {
        const string sheetName = "PlacedNpc";
        DataTable dataTable = GetSkyrimData.GetPlacedNpc();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillPlacedObject(string fileName)
    {
        const string sheetName = "PlacedObject";
        DataTable dataTable = GetSkyrimData.GetPlacedObject();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillProjectile(string fileName)
    {
        const string sheetName = "Projectile";
        DataTable dataTable = GetSkyrimData.GetProjectile();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillQuest(string fileName)
    {
        const string sheetName = "Quest";
        DataTable dataTable = GetSkyrimData.GetQuest();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillRace(string fileName)
    {
        const string sheetName = "Race";
        DataTable dataTable = GetSkyrimData.GetRace();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillRegion(string fileName)
    {
        const string sheetName = "Region";
        DataTable dataTable = GetSkyrimData.GetRegion();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillRelationship(string fileName)
    {
        const string sheetName = "Relationship";
        DataTable dataTable = GetSkyrimData.GetRelationship();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillReverbParameters(string fileName)
    {
        const string sheetName = "ReverbParameters";
        DataTable dataTable = GetSkyrimData.GetReverbParameters();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillScene(string fileName)
    {
        const string sheetName = "Scene";
        DataTable dataTable = GetSkyrimData.GetScene();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillScroll(string fileName)
    {
        const string sheetName = "Scroll";
        DataTable dataTable = GetSkyrimData.GetScroll();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillShaderParticleGeometry(string fileName)
    {
        const string sheetName = "ShaderParticleGeometry";
        DataTable dataTable = GetSkyrimData.GetShaderParticleGeometry();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillShout(string fileName)
    {
        const string sheetName = "Shout";
        DataTable dataTable = GetSkyrimData.GetShout();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSkyrimMajorRecord(string fileName)
    {
        const string sheetName = "SkyrimMajorRecord";
        DataTable dataTable = GetSkyrimData.GetSkyrimMajorRecord();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSoulGem(string fileName)
    {
        const string sheetName = "SoulGem";
        DataTable dataTable = GetSkyrimData.GetSoulGem();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSoundCategory(string fileName)
    {
        const string sheetName = "SoundCategory";
        DataTable dataTable = GetSkyrimData.GetSoundCategory();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSoundDescriptor(string fileName)
    {
        const string sheetName = "SoundDescriptor";
        DataTable dataTable = GetSkyrimData.GetSoundDescriptor();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSoundMarker(string fileName)
    {
        const string sheetName = "SoundMarker";
        DataTable dataTable = GetSkyrimData.GetSoundMarker();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSoundOutputModel(string fileName)
    {
        const string sheetName = "SoundOutputModel";
        DataTable dataTable = GetSkyrimData.GetSoundOutputModel();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillSpell(string fileName)
    {
        const string sheetName = "Spell";
        DataTable dataTable = GetSkyrimData.GetSpell();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillStatic(string fileName)
    {
        const string sheetName = "Static";
        DataTable dataTable = GetSkyrimData.GetStatic();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillTalkingActivator(string fileName)
    {
        const string sheetName = "TalkingActivator";
        DataTable dataTable = GetSkyrimData.GetTalkingActivator();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillTextureSet(string fileName)
    {
        const string sheetName = "TextureSet";
        DataTable dataTable = GetSkyrimData.GetTextureSet();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillTree(string fileName)
    {
        const string sheetName = "Tree";
        DataTable dataTable = GetSkyrimData.GetTree();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillVisualEffect(string fileName)
    {
        const string sheetName = "VisualEffect";
        DataTable dataTable = GetSkyrimData.GetVisualEffect();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillVoiceType(string fileName)
    {
        const string sheetName = "VoiceType";
        DataTable dataTable = GetSkyrimData.GetVoiceType();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillVolumetricLighting(string fileName)
    {
        const string sheetName = "VolumetricLighting";
        DataTable dataTable = GetSkyrimData.GetVolumetricLighting();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillWater(string fileName)
    {
        const string sheetName = "Water";
        DataTable dataTable = GetSkyrimData.GetWater();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }
    
    public static void FillWeapons(string fileName)
    {
        const string sheetName = "Weapons";
        DataTable dataTable = GetSkyrimData.GetWeapon();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillWeather(string fileName)
    {
        const string sheetName = "Weather";
        DataTable dataTable = GetSkyrimData.GetWeather();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillWordOfPower(string fileName)
    {
        const string sheetName = "WordOfPower";
        DataTable dataTable = GetSkyrimData.GetWordOfPower();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }

    public static void FillWorldspace(string fileName)
    {
        const string sheetName = "Worldspace";
        DataTable dataTable = GetSkyrimData.GetWorldSpace();
        CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
    }
}