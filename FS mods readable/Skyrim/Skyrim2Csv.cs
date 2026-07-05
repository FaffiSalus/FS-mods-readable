using FS_mods_readable.Core.CSV;

namespace FS_mods_readable.Skyrim;

public static class Skyrim2Csv
{
    public static void FillAllFiles(string filePath)
    {
        FillAcousticSpace(filePath);
        FillActionRecord(filePath);
        FillActivator(filePath);
        FillActorValueInformation(filePath);
        FillAddonNode(filePath);
        FillAlchemicalApparatus(filePath);
        FillAmmunition(filePath);
        FillAnimatedObject(filePath);
        FillAPlacedTrap(filePath);
        FillArmor(filePath);
        FillArmorAddon(filePath);
        FillArtObject(filePath);
        FillAssociationType(filePath);
        FillAStoryManagerNode(filePath);
        FillBodyPartData(filePath);
        FillBook(filePath);
        FillCameraPath(filePath);
        FillCameraShot(filePath);
        FillCell(filePath);
        FillClass(filePath);
        FillClimate(filePath);
        FillCollisionLayer(filePath);
        FillColorRecord(filePath);
        FillCombatStyle(filePath);
        FillConstructibleObject(filePath);
        FillContainer(filePath);
        FillDebris(filePath);
        FillDefaultObjectManager(filePath);
        FillDialogBranch(filePath);
        FillDialogResponses(filePath);
        FillDialogTopic(filePath);
        FillDialogView(filePath);
        FillDoor(filePath);
        FillDualCastData(filePath);
        FillEffectShader(filePath);
        FillEncounterZone(filePath);
        FillEquipType(filePath);
        FillExplosion(filePath);
        FillEyes(filePath);
        FillFaction(filePath);
        FillFlora(filePath);
        FillFootstep(filePath);
        FillFootstepSet(filePath);
        FillFormList(filePath);
        FillFurniture(filePath);
        FillGameSetting(filePath);
        FillGlobal(filePath);
        FillGrass(filePath);
        FillHair(filePath);
        FillHazard(filePath);
        FillHeadPart(filePath);
	    FillIdleAnimation(filePath);
        FillIdleMarker(filePath);
	    FillImageSpace(filePath);
        FillImageSpaceAdapter(filePath);
	    FillImpact(filePath);
        FillImpactDataSet(filePath);
        FillIngestible(filePath);
        FillIngredient(filePath);
	    FillKey(filePath);
        FillKeyword(filePath);
        FillLandscape(filePath);
        FillLandscapeTexture(filePath);
        FillLensFlare(filePath);
        FillLeveledItem(filePath);
        FillLeveledNpc(filePath);
        FillLeveledSpell(filePath);
        FillLight(filePath);
        FillLightingTemplate(filePath);
        FillLoadScreen(filePath);
        FillLocation(filePath);
        FillLocationReferenceType(filePath);
        FillMagicEffect(filePath);
        FillMaterialObject(filePath);
        FillMaterialType(filePath);
        FillMessage(filePath);
        FillMiscItem(filePath);
        FillMoveableStatic(filePath);
        FillMovementType(filePath);
        FillMusicTrack(filePath);
        FillMusicType(filePath);
        FillNavigationMesh(filePath);
        FillNavigationMeshInfoMap(filePath);
        FillNpc(filePath);
        FillObjectEffect(filePath);
        FillOutfit(filePath);
        FillPackage(filePath);
        FillPerk(filePath);
        FillPlacedNpc(filePath);
        FillPlacedObject(filePath);
        FillProjectile(filePath);
        FillQuest(filePath);
        //FillRace(filePath);
        FillRegion(filePath);
        FillRelationship(filePath);
        FillReverbParameters(filePath);
        FillScene(filePath);
        FillScroll(filePath);
        FillShaderParticleGeometry(filePath);
        FillShout(filePath);
	    FillSoulGem(filePath);
        FillSoundCategory(filePath);
        FillSoundDescriptor(filePath);
        FillSoundMarker(filePath);
        FillSoundOutputModel(filePath);
        FillSpell(filePath);
        FillStatic(filePath);
        FillTalkingActivator(filePath);
        FillTextureSet(filePath);
        FillTree(filePath);
        FillVisualEffect(filePath);
        FillVoiceType(filePath);
        FillVolumetricLighting(filePath);
        FillWater(filePath);
        FillWeapons(filePath);
        FillWeather(filePath);
        FillWordOfPower(filePath);
        FillWorldspace(filePath);
    }
    
    public static void FillAcousticSpace(string filePath)
    {
        string fileName = filePath + "\\AcousticSpace.csv";
        DataTable dataTable = GetSkyrimData.GetAcousticSpace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }
    
    public static void FillActionRecord(string filePath)
    {
        string fileName = filePath + "\\ActionRecord.csv";
        DataTable dataTable = GetSkyrimData.GetActionRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillActivator(string filePath)
    {
        string fileName = filePath + "\\Activator.csv";
        DataTable dataTable = GetSkyrimData.GetActivator();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillActorValueInformation(string filePath)
    {
        string fileName = filePath + "\\ActorValueInformation.csv";
        DataTable dataTable = GetSkyrimData.GetActorValueInformation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAddonNode(string filePath)
    {
        string fileName = filePath + "\\AddonNode.csv";
        DataTable dataTable = GetSkyrimData.GetAddonNode();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAlchemicalApparatus(string filePath)
    {
        string fileName = filePath + "\\AlchemicalApparatus.csv";
        DataTable dataTable = GetSkyrimData.GetAlchemicalApparatus();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAmmunition(string filePath)
    {
        string fileName = filePath + "\\Ammunition.csv";
        DataTable dataTable = GetSkyrimData.GetAmmunition();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAnimatedObject(string filePath)
    {
        string fileName = filePath + "\\AnimatedObject.csv";
        DataTable dataTable = GetSkyrimData.GetAnimatedObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAPlacedTrap(string filePath)
    {
        string fileName = filePath + "\\APlacedTrap.csv";
        DataTable dataTable = GetSkyrimData.GetAPlacedTrap();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillArmor(string filePath)
    {
        string fileName = filePath + "\\Armor.csv";
        DataTable dataTable = GetSkyrimData.GetArmor();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillArmorAddon(string filePath)
    {
        string fileName = filePath + "\\ArmorAddon.csv";
        DataTable dataTable = GetSkyrimData.GetArmorAddon();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillArtObject(string filePath)
    {
        string fileName = filePath + "\\ArtObject.csv";
        DataTable dataTable = GetSkyrimData.GetArtObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAssociationType(string filePath)
    {
        string fileName = filePath + "\\AssociationType.csv";
        DataTable dataTable = GetSkyrimData.GetAssociationType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAStoryManagerNode(string filePath)
    {
        string fileName = filePath + "\\AStoryManagerNode.csv";
        DataTable dataTable = GetSkyrimData.GetAStoryManagerNode();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillBodyPartData(string filePath)
    {
        string fileName = filePath + "\\BodyPartData.csv";
        DataTable dataTable = GetSkyrimData.GetBodyPartData();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillBook(string filePath)
    {
        string fileName = filePath + "\\Book.csv";
        DataTable dataTable = GetSkyrimData.GetBook();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCameraPath(string filePath)
    {
        string fileName = filePath + "\\CameraPath.csv";
        DataTable dataTable = GetSkyrimData.GetCameraPath();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCameraShot(string filePath)
    {
        string fileName = filePath + "\\CameraShot.csv";
        DataTable dataTable = GetSkyrimData.GetCameraShot();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCell(string filePath)
    {
        string fileName = filePath + "\\Cell.csv";
        DataTable dataTable = GetSkyrimData.GetCell();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillClass(string filePath)
    {
        string fileName = filePath + "\\Class.csv";
        DataTable dataTable = GetSkyrimData.GetClass();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillClimate(string filePath)
    {
        string fileName = filePath + "\\Climate.csv";
        DataTable dataTable = GetSkyrimData.GetClimate();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCollisionLayer(string filePath)
    {
        string fileName = filePath + "\\CollisionLayer.csv";
        DataTable dataTable = GetSkyrimData.GetCollisionLayer();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillColorRecord(string filePath)
    {
        string fileName = filePath + "\\ColorRecord.csv";
        DataTable dataTable = GetSkyrimData.GetColorRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCombatStyle(string filePath)
    {
        string fileName = filePath + "\\CombatStyle.csv";
        DataTable dataTable = GetSkyrimData.GetCombatStyle();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillConstructibleObject(string filePath)
    {
        string fileName = filePath + "\\ConstructibleObject.csv";
        DataTable dataTable = GetSkyrimData.GetConstructibleObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillContainer(string filePath)
    {
        string fileName = filePath + "\\Container.csv";
        DataTable dataTable = GetSkyrimData.GetContainer();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDebris(string filePath)
    {
        string fileName = filePath + "\\Debris.csv";
        DataTable dataTable = GetSkyrimData.GetDebris();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDefaultObjectManager(string filePath)
    {
        string fileName = filePath + "\\DefaultObjectManager.csv";
        DataTable dataTable = GetSkyrimData.GetDefaultObjectManager();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogBranch(string filePath)
    {
        string fileName = filePath + "\\DialogBranch.csv";
        DataTable dataTable = GetSkyrimData.GetDialogBranch();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogResponses(string filePath)
    {
        string fileName = filePath + "\\DialogResponses.csv";
        DataTable dataTable = GetSkyrimData.GetDialogResponses();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogTopic(string filePath)
    {
        string fileName = filePath + "\\DialogTopic.csv";
        DataTable dataTable = GetSkyrimData.GetDialogTopic();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogView(string filePath)
    {
        string fileName = filePath + "\\DialogView.csv";
        DataTable dataTable = GetSkyrimData.GetDialogView();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDoor(string filePath)
    {
        string fileName = filePath + "\\Door.csv";
        DataTable dataTable = GetSkyrimData.GetDoor();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDualCastData(string filePath)
    {
        string fileName = filePath + "\\DualCastData.csv";
        DataTable dataTable = GetSkyrimData.GetDualCastData();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEffectShader(string filePath)
    {
        string fileName = filePath + "\\EffectShader.csv";
        DataTable dataTable = GetSkyrimData.GetEffectShader();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEncounterZone(string filePath)
    {
        string fileName = filePath + "\\EncounterZone.csv";
        DataTable dataTable = GetSkyrimData.GetEncounterZone();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEquipType(string filePath)
    {
        string fileName = filePath + "\\EquipType.csv";
        DataTable dataTable = GetSkyrimData.GetEquipType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillExplosion(string filePath)
    {
        string fileName = filePath + "\\Explosion.csv";
        DataTable dataTable = GetSkyrimData.GetExplosion();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEyes(string filePath)
    {
        string fileName = filePath + "\\Eyes.csv";
        DataTable dataTable = GetSkyrimData.GetEyes();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFaction(string filePath)
    {
        string fileName = filePath + "\\Faction.csv";
        DataTable dataTable = GetSkyrimData.GetFaction();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFlora(string filePath)
    {
        string fileName = filePath + "\\Flora.csv";
        DataTable dataTable = GetSkyrimData.GetFlora();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFootstep(string filePath)
    {
        string fileName = filePath + "\\Footstep.csv";
        DataTable dataTable = GetSkyrimData.GetFootstep();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFootstepSet(string filePath)
    {
        string fileName = filePath + "\\FootstepSet.csv";
        DataTable dataTable = GetSkyrimData.GetFootstepSet();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFormList(string filePath)
    {
        string fileName = filePath + "\\FormList.csv";
        DataTable dataTable = GetSkyrimData.GetFormList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFurniture(string filePath)
    {
        string fileName = filePath + "\\Furniture.csv";
        DataTable dataTable = GetSkyrimData.GetFurniture();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillGameSetting(string filePath)
    {
        string fileName = filePath + "\\GameSetting.csv";
        DataTable dataTable = GetSkyrimData.GetGameSetting();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillGlobal(string filePath)
    {
        string fileName = filePath + "\\Global.csv";
        DataTable dataTable = GetSkyrimData.GetGlobal();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillGrass(string filePath)
    {
        string fileName = filePath + "\\Grass.csv";
        DataTable dataTable = GetSkyrimData.GetGrass();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillHair(string filePath)
    {
        string fileName = filePath + "\\Hair.csv";
        DataTable dataTable = GetSkyrimData.GetHair();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillHazard(string filePath)
    {
        string fileName = filePath + "\\Hazard.csv";
        DataTable dataTable = GetSkyrimData.GetHazard();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillHeadPart(string filePath)
    {
        string fileName = filePath + "\\HeadPart.csv";
        DataTable dataTable = GetSkyrimData.GetHeadPart();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIAliasVoiceType(string filePath)
    {
        string fileName = filePath + "\\IAliasVoiceType.csv";
        DataTable dataTable = GetSkyrimData.GetIAliasVoiceType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIBindableEquipment(string filePath)
    {
        string fileName = filePath + "\\IBindableEquipment.csv";
        DataTable dataTable = GetSkyrimData.GetIBindableEquipment();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIComplexLocation(string filePath)
    {
        string fileName = filePath + "\\IComplexLocation.csv";
        DataTable dataTable = GetSkyrimData.GetIComplexLocation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIConstructible(string filePath)
    {
        string fileName = filePath + "\\IConstructible.csv";
        DataTable dataTable = GetSkyrimData.GetIConstructible();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIdleAnimation(string filePath)
    {
        string fileName = filePath + "\\IdleAnimation.csv";
        DataTable dataTable = GetSkyrimData.GetIdleAnimation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIdleMarker(string filePath)
    {
        string fileName = filePath + "\\IdleMarker.csv";
        DataTable dataTable = GetSkyrimData.GetIdleMarker();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIEffectRecord(string filePath)
    {
        string fileName = filePath + "\\IEffectRecord.csv";
        DataTable dataTable = GetSkyrimData.GetIEffectRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIEmittance(string filePath)
    {
        string fileName = filePath + "\\IEmittance.csv";
        DataTable dataTable = GetSkyrimData.GetIEmittance();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIExplodeSpawn(string filePath)
    {
        string fileName = filePath + "\\IExplodeSpawn.csv";
        DataTable dataTable = GetSkyrimData.GetIExplodeSpawn();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIHarvestTarget(string filePath)
    {
        string fileName = filePath + "\\IHarvestTarget.csv";
        DataTable dataTable = GetSkyrimData.GetIHarvestTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIIdleRelation(string filePath)
    {
        string fileName = filePath + "\\IIdleRelation.csv";
        DataTable dataTable = GetSkyrimData.GetIIdleRelation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIItem(string filePath)
    {
        string fileName = filePath + "\\IItem.csv";
        DataTable dataTable = GetSkyrimData.GetIItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIItemOrList(string filePath)
    {
        string fileName = filePath + "\\IItemOrList.csv";
        DataTable dataTable = GetSkyrimData.GetIItemOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIKeywordLinkedReference(string filePath)
    {
        string fileName = filePath + "\\IKeywordLinkedReference.csv";
        DataTable dataTable = GetSkyrimData.GetIKeywordLinkedReference();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIKnowable(string filePath)
    {
        string fileName = filePath + "\\IKnowable.csv";
        DataTable dataTable = GetSkyrimData.GetIKnowable();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillILockList(string filePath)
    {
        string fileName = filePath + "\\ILockList.csv";
        DataTable dataTable = GetSkyrimData.GetILockList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImageSpace(string filePath)
    {
        string fileName = filePath + "\\ImageSpace.csv";
        DataTable dataTable = GetSkyrimData.GetImageSpace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImageSpaceAdapter(string filePath)
    {
        string fileName = filePath + "\\ImageSpaceAdapter.csv";
        DataTable dataTable = GetSkyrimData.GetImageSpaceAdapter();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIMagicItem(string filePath)
    {
        string fileName = filePath + "\\IMagicItem.csv";
        DataTable dataTable = GetSkyrimData.GetIMagicItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImpact(string filePath)
    {
        string fileName = filePath + "\\Impact.csv";
        DataTable dataTable = GetSkyrimData.GetImpact();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImpactDataSet(string filePath)
    {
        string fileName = filePath + "\\ImpactDataSet.csv";
        DataTable dataTable = GetSkyrimData.GetImpactDataSet();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIngestible(string filePath)
    {
        string fileName = filePath + "\\Ingestible.csv";
        DataTable dataTable = GetSkyrimData.GetIngestible();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIngredient(string filePath)
    {
        string fileName = filePath + "\\Ingredient.csv";
        DataTable dataTable = GetSkyrimData.GetIngredient();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillINpcOrList(string filePath)
    {
        string fileName = filePath + "\\INpcOrList.csv";
        DataTable dataTable = GetSkyrimData.GetINpcOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillINpcSpawn(string filePath)
    {
        string fileName = filePath + "\\INpcSpawn.csv";
        DataTable dataTable = GetSkyrimData.GetINpcSpawn();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIObjectId(string filePath)
    {
        string fileName = filePath + "\\IObjectId.csv";
        DataTable dataTable = GetSkyrimData.GetIObjectId();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIOutfitTarget(string filePath)
    {
        string fileName = filePath + "\\IOutfitTarget.csv";
        DataTable dataTable = GetSkyrimData.GetIOutfitTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIOwner(string filePath)
    {
        string fileName = filePath + "\\IOwner.csv";
        DataTable dataTable = GetSkyrimData.GetIOwner();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlaceableObject(string filePath)
    {
        string fileName = filePath + "\\IPlaceableObject.csv";
        DataTable dataTable = GetSkyrimData.GetIPlaceableObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlaced(string filePath)
    {
        string fileName = filePath + "\\IPlaced.csv";
        DataTable dataTable = GetSkyrimData.GetIPlaced();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlacedSimple(string filePath)
    {
        string fileName = filePath + "\\IPlacedSimple.csv";
        DataTable dataTable = GetSkyrimData.GetIPlacedSimple();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlacedThing(string filePath)
    {
        string fileName = filePath + "\\IPlacedThing.csv";
        DataTable dataTable = GetSkyrimData.GetIPlacedThing();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlacedTrapTarget(string filePath)
    {
        string fileName = filePath + "\\IPlacedTrapTarget.csv";
        DataTable dataTable = GetSkyrimData.GetIPlacedTrapTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIReferenceableObject(string filePath)
    {
        string fileName = filePath + "\\IReferenceableObject.csv";
        DataTable dataTable = GetSkyrimData.GetIReferenceableObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIRegionTarget(string filePath)
    {
        string fileName = filePath + "\\IRegionTarget.csv";
        DataTable dataTable = GetSkyrimData.GetIRegionTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIRelatable(string filePath)
    {
        string fileName = filePath + "\\IRelatable.csv";
        DataTable dataTable = GetSkyrimData.GetIRelatable();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillISound(string filePath)
    {
        string fileName = filePath + "\\ISound.csv";
        DataTable dataTable = GetSkyrimData.GetISound();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillISpellOrList(string filePath)
    {
        string fileName = filePath + "\\ISpellOrList.csv";
        DataTable dataTable = GetSkyrimData.GetISpellOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillISpellRecord(string filePath)
    {
        string fileName = filePath + "\\ISpellRecord.csv";
        DataTable dataTable = GetSkyrimData.GetISpellRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIVoiceTypeOrList(string filePath)
    {
        string fileName = filePath + "\\IVoiceTypeOrList.csv";
        DataTable dataTable = GetSkyrimData.GetIVoiceTypeOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIWeaponOrList(string filePath)
    {
        string fileName = filePath + "\\IWeaponOrList.csv";
        DataTable dataTable = GetSkyrimData.GetIWeaponOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIWorldspaceOrList(string filePath)
    {
        string fileName = filePath + "\\IWorldspaceOrList.csv";
        DataTable dataTable = GetSkyrimData.GetIWorldspaceOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillKey(string filePath)
    {
        string fileName = filePath + "\\Key.csv";
        DataTable dataTable = GetSkyrimData.GetKey();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillKeyword(string filePath)
    {
        string fileName = filePath + "\\Keyword.csv";
        DataTable dataTable = GetSkyrimData.GetKeyword();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLandscape(string filePath)
    {
        string fileName = filePath + "\\Landscape.csv";
        DataTable dataTable = GetSkyrimData.GetLandscape();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLandscapeTexture(string filePath)
    {
        string fileName = filePath + "\\LandscapeTexture.csv";
        DataTable dataTable = GetSkyrimData.GetLandscapeTexture();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLensFlare(string filePath)
    {
        string fileName = filePath + "\\LensFlare.csv";
        DataTable dataTable = GetSkyrimData.GetLensFlare();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLeveledItem(string filePath)
    {
        string fileName = filePath + "\\LeveledItem.csv";
        DataTable dataTable = GetSkyrimData.GetLeveledItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLeveledNpc(string filePath)
    {
        string fileName = filePath + "\\LeveledNpc.csv";
        DataTable dataTable = GetSkyrimData.GetLeveledNpc();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLeveledSpell(string filePath)
    {
        string fileName = filePath + "\\LeveledSpell.csv";
        DataTable dataTable = GetSkyrimData.GetLeveledSpell();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLight(string filePath)
    {
        string fileName = filePath + "\\Light.csv";
        DataTable dataTable = GetSkyrimData.GetLight();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLightingTemplate(string filePath)
    {
        string fileName = filePath + "\\LightingTemplate.csv";
        DataTable dataTable = GetSkyrimData.GetLightingTemplate();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLoadScreen(string filePath)
    {
        string fileName = filePath + "\\LoadScreen.csv";
        DataTable dataTable = GetSkyrimData.GetLoadScreen();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLocation(string filePath)
    {
        string fileName = filePath + "\\Location.csv";
        DataTable dataTable = GetSkyrimData.GetLocation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLocationReferenceType(string filePath)
    {
        string fileName = filePath + "\\LocationReferenceType.csv";
        DataTable dataTable = GetSkyrimData.GetLocationReferenceType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMagicEffect(string filePath)
    {
        string fileName = filePath + "\\MagicEffect.csv";
        DataTable dataTable = GetSkyrimData.GetMagicEffect();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMaterialObject(string filePath)
    {
        string fileName = filePath + "\\MaterialObject.csv";
        DataTable dataTable = GetSkyrimData.GetMaterialObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMaterialType(string filePath)
    {
        string fileName = filePath + "\\MaterialType.csv";
        DataTable dataTable = GetSkyrimData.GetMaterialType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMessage(string filePath)
    {
        string fileName = filePath + "\\Message.csv";
        DataTable dataTable = GetSkyrimData.GetMessage();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMiscItem(string filePath)
    {
        string fileName = filePath + "\\MiscItem.csv";
        DataTable dataTable = GetSkyrimData.GetMiscItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMoveableStatic(string filePath)
    {
        string fileName = filePath + "\\MoveableStatic.csv";
        DataTable dataTable = GetSkyrimData.GetMoveableStatic();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMovementType(string filePath)
    {
        string fileName = filePath + "\\MovementType.csv";
        DataTable dataTable = GetSkyrimData.GetMovementType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMusicTrack(string filePath)
    {
        string fileName = filePath + "\\MusicTrack.csv";
        DataTable dataTable = GetSkyrimData.GetMusicTrack();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMusicType(string filePath)
    {
        string fileName = filePath + "\\MusicType.csv";
        DataTable dataTable = GetSkyrimData.GetMusicType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillNavigationMesh(string filePath)
    {
        string fileName = filePath + "\\NavigationMesh.csv";
        DataTable dataTable = GetSkyrimData.GetNavigationMesh();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillNavigationMeshInfoMap(string filePath)
    {
        string fileName = filePath + "\\NavigationMeshInfoMap.csv";
        DataTable dataTable = GetSkyrimData.GetNavigationMeshInfoMap();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillNpc(string filePath)
    {
        string fileName = filePath + "\\Npc.csv";
        DataTable dataTable = GetSkyrimData.GetNpc();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillObjectEffect(string filePath)
    {
        string fileName = filePath + "\\ObjectEffect.csv";
        DataTable dataTable = GetSkyrimData.GetObjectEffect();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillOutfit(string filePath)
    {
        string fileName = filePath + "\\Outfit.csv";
        DataTable dataTable = GetSkyrimData.GetOutfit();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPackage(string filePath)
    {
        string fileName = filePath + "\\Package.csv";
        DataTable dataTable = GetSkyrimData.GetPackage();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPerk(string filePath)
    {
        string fileName = filePath + "\\Perk.csv";
        DataTable dataTable = GetSkyrimData.GetPerk();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPlacedNpc(string filePath)
    {
        string fileName = filePath + "\\PlacedNpc.csv";
        DataTable dataTable = GetSkyrimData.GetPlacedNpc();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPlacedObject(string filePath)
    {
        string fileName = filePath + "\\PlacedObject.csv";
        DataTable dataTable = GetSkyrimData.GetPlacedObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillProjectile(string filePath)
    {
        string fileName = filePath + "\\Projectile.csv";
        DataTable dataTable = GetSkyrimData.GetProjectile();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillQuest(string filePath)
    {
        string fileName = filePath + "\\Quest.csv";
        DataTable dataTable = GetSkyrimData.GetQuest();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillRace(string filePath)
    {
        string fileName = filePath + "\\Race.csv";
        DataTable dataTable = GetSkyrimData.GetRace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillRegion(string filePath)
    {
        string fileName = filePath + "\\Region.csv";
        DataTable dataTable = GetSkyrimData.GetRegion();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillRelationship(string filePath)
    {
        string fileName = filePath + "\\Relationship.csv";
        DataTable dataTable = GetSkyrimData.GetRelationship();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillReverbParameters(string filePath)
    {
        string fileName = filePath + "\\ReverbParameters.csv";
        DataTable dataTable = GetSkyrimData.GetReverbParameters();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillScene(string filePath)
    {
        string fileName = filePath + "\\Scene.csv";
        DataTable dataTable = GetSkyrimData.GetScene();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillScroll(string filePath)
    {
        string fileName = filePath + "\\Scroll.csv";
        DataTable dataTable = GetSkyrimData.GetScroll();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillShaderParticleGeometry(string filePath)
    {
        string fileName = filePath + "\\ShaderParticleGeometry.csv";
        DataTable dataTable = GetSkyrimData.GetShaderParticleGeometry();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillShout(string filePath)
    {
        string fileName = filePath + "\\Shout.csv";
        DataTable dataTable = GetSkyrimData.GetShout();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSkyrimMajorRecord(string filePath)
    {
        string fileName = filePath + "\\SkyrimMajorRecord.csv";
        DataTable dataTable = GetSkyrimData.GetSkyrimMajorRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoulGem(string filePath)
    {
        string fileName = filePath + "\\SoulGem.csv";
        DataTable dataTable = GetSkyrimData.GetSoulGem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundCategory(string filePath)
    {
        string fileName = filePath + "\\SoundCategory.csv";
        DataTable dataTable = GetSkyrimData.GetSoundCategory();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundDescriptor(string filePath)
    {
        string fileName = filePath + "\\SoundDescriptor.csv";
        DataTable dataTable = GetSkyrimData.GetSoundDescriptor();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundMarker(string filePath)
    {
        string fileName = filePath + "\\SoundMarker.csv";
        DataTable dataTable = GetSkyrimData.GetSoundMarker();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundOutputModel(string filePath)
    {
        string fileName = filePath + "\\SoundOutputModel.csv";
        DataTable dataTable = GetSkyrimData.GetSoundOutputModel();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSpell(string filePath)
    {
        string fileName = filePath + "\\Spell.csv";
        DataTable dataTable = GetSkyrimData.GetSpell();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillStatic(string filePath)
    {
        string fileName = filePath + "\\Static.csv";
        DataTable dataTable = GetSkyrimData.GetStatic();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillTalkingActivator(string filePath)
    {
        string fileName = filePath + "\\TalkingActivator.csv";
        DataTable dataTable = GetSkyrimData.GetTalkingActivator();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillTextureSet(string filePath)
    {
        string fileName = filePath + "\\TextureSet.csv";
        DataTable dataTable = GetSkyrimData.GetTextureSet();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillTree(string filePath)
    {
        string fileName = filePath + "\\Tree.csv";
        DataTable dataTable = GetSkyrimData.GetTree();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillVisualEffect(string filePath)
    {
        string fileName = filePath + "\\VisualEffect.csv";
        DataTable dataTable = GetSkyrimData.GetVisualEffect();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillVoiceType(string filePath)
    {
        string fileName = filePath + "\\VoiceType.csv";
        DataTable dataTable = GetSkyrimData.GetVoiceType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillVolumetricLighting(string filePath)
    {
        string fileName = filePath + "\\VolumetricLighting.csv";
        DataTable dataTable = GetSkyrimData.GetVolumetricLighting();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWater(string filePath)
    {
        string fileName = filePath + "\\Water.csv";
        DataTable dataTable = GetSkyrimData.GetWater();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }
    
    public static void FillWeapons(string filePath)
    {
        string fileName = filePath + "\\Weapon.csv";
        DataTable dataTable = GetSkyrimData.GetWeapon();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWeather(string filePath)
    {
        string fileName = filePath + "\\Weather.csv";
        DataTable dataTable = GetSkyrimData.GetWeather();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWordOfPower(string filePath)
    {
        string fileName = filePath + "\\WordOfPower.csv";
        DataTable dataTable = GetSkyrimData.GetWordOfPower();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWorldspace(string filePath)
    {
        string fileName = filePath + "\\Worldspace.csv";
        DataTable dataTable = GetSkyrimData.GetWorldSpace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }
}