using FS_mods_readable.Core;
using FS_mods_readable.Core.CSV;

namespace FS_mods_readable.Skyrim;

public static class Skyrim2Csv
{
    public static void FillAllFiles()
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
	    FillIdleAnimation();
        FillIdleMarker();
	    FillImageSpace();
        FillImageSpaceAdapter();
	    FillImpact();
        FillImpactDataSet();
        FillIngestible();
        FillIngredient();
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
        var fileName = ConfigHandler.GetCsvDirectory() + "\\AcousticSpace.csv";
        var dataTable = GetSkyrimData.GetAcousticSpace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }
    
    public static void FillActionRecord()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ActionRecord.csv";
        var dataTable = GetSkyrimData.GetActionRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillActivator()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Activator.csv";
        var dataTable = GetSkyrimData.GetActivator();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillActorValueInformation()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ActorValueInformation.csv";
        var dataTable = GetSkyrimData.GetActorValueInformation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAddonNode()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\AddonNode.csv";
        var dataTable = GetSkyrimData.GetAddonNode();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAlchemicalApparatus()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\AlchemicalApparatus.csv";
        var dataTable = GetSkyrimData.GetAlchemicalApparatus();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAmmunition()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Ammunition.csv";
        var dataTable = GetSkyrimData.GetAmmunition();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAnimatedObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\AnimatedObject.csv";
        var dataTable = GetSkyrimData.GetAnimatedObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAPlacedTrap()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\APlacedTrap.csv";
        var dataTable = GetSkyrimData.GetAPlacedTrap();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillArmor()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Armor.csv";
        var dataTable = GetSkyrimData.GetArmor();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillArmorAddon()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ArmorAddon.csv";
        var dataTable = GetSkyrimData.GetArmorAddon();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillArtObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ArtObject.csv";
        var dataTable = GetSkyrimData.GetArtObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAssociationType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\AssociationType.csv";
        var dataTable = GetSkyrimData.GetAssociationType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillAStoryManagerNode()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\AStoryManagerNode.csv";
        var dataTable = GetSkyrimData.GetAStoryManagerNode();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillBodyPartData()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\BodyPartData.csv";
        var dataTable = GetSkyrimData.GetBodyPartData();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillBook()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Book.csv";
        var dataTable = GetSkyrimData.GetBook();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCameraPath()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\CameraPath.csv";
        var dataTable = GetSkyrimData.GetCameraPath();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCameraShot()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\CameraShot.csv";
        var dataTable = GetSkyrimData.GetCameraShot();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCell()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Cell.csv";
        var dataTable = GetSkyrimData.GetCell();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillClass()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Class.csv";
        var dataTable = GetSkyrimData.GetClass();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillClimate()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Climate.csv";
        var dataTable = GetSkyrimData.GetClimate();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCollisionLayer()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\CollisionLayer.csv";
        var dataTable = GetSkyrimData.GetCollisionLayer();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillColorRecord()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ColorRecord.csv";
        var dataTable = GetSkyrimData.GetColorRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillCombatStyle()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\CombatStyle.csv";
        var dataTable = GetSkyrimData.GetCombatStyle();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillConstructibleObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ConstructibleObject.csv";
        var dataTable = GetSkyrimData.GetConstructibleObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillContainer()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Container.csv";
        var dataTable = GetSkyrimData.GetContainer();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDebris()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Debris.csv";
        var dataTable = GetSkyrimData.GetDebris();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDefaultObjectManager()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\DefaultObjectManager.csv";
        var dataTable = GetSkyrimData.GetDefaultObjectManager();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogBranch()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\DialogBranch.csv";
        var dataTable = GetSkyrimData.GetDialogBranch();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogResponses()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\DialogResponses.csv";
        var dataTable = GetSkyrimData.GetDialogResponses();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogTopic()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\DialogTopic.csv";
        var dataTable = GetSkyrimData.GetDialogTopic();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDialogView()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\DialogView.csv";
        var dataTable = GetSkyrimData.GetDialogView();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDoor()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Door.csv";
        var dataTable = GetSkyrimData.GetDoor();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillDualCastData()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\DualCastData.csv";
        var dataTable = GetSkyrimData.GetDualCastData();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEffectShader()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\EffectShader.csv";
        var dataTable = GetSkyrimData.GetEffectShader();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEncounterZone()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\EncounterZone.csv";
        var dataTable = GetSkyrimData.GetEncounterZone();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEquipType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\EquipType.csv";
        var dataTable = GetSkyrimData.GetEquipType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillExplosion()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Explosion.csv";
        var dataTable = GetSkyrimData.GetExplosion();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillEyes()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Eyes.csv";
        var dataTable = GetSkyrimData.GetEyes();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFaction()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Faction.csv";
        var dataTable = GetSkyrimData.GetFaction();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFlora()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Flora.csv";
        var dataTable = GetSkyrimData.GetFlora();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFootstep()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Footstep.csv";
        var dataTable = GetSkyrimData.GetFootstep();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFootstepSet()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\FootstepSet.csv";
        var dataTable = GetSkyrimData.GetFootstepSet();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFormList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\FormList.csv";
        var dataTable = GetSkyrimData.GetFormList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillFurniture()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Furniture.csv";
        var dataTable = GetSkyrimData.GetFurniture();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillGameSetting()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\GameSetting.csv";
        var dataTable = GetSkyrimData.GetGameSetting();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillGlobal()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Global.csv";
        var dataTable = GetSkyrimData.GetGlobal();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillGrass()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Grass.csv";
        var dataTable = GetSkyrimData.GetGrass();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillHair()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Hair.csv";
        var dataTable = GetSkyrimData.GetHair();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillHazard()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Hazard.csv";
        var dataTable = GetSkyrimData.GetHazard();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillHeadPart()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\HeadPart.csv";
        var dataTable = GetSkyrimData.GetHeadPart();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIAliasVoiceType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IAliasVoiceType.csv";
        var dataTable = GetSkyrimData.GetIAliasVoiceType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIBindableEquipment()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IBindableEquipment.csv";
        var dataTable = GetSkyrimData.GetIBindableEquipment();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIComplexLocation()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IComplexLocation.csv";
        var dataTable = GetSkyrimData.GetIComplexLocation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIConstructible()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IConstructible.csv";
        var dataTable = GetSkyrimData.GetIConstructible();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIdleAnimation()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IdleAnimation.csv";
        var dataTable = GetSkyrimData.GetIdleAnimation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIdleMarker()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IdleMarker.csv";
        var dataTable = GetSkyrimData.GetIdleMarker();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIEffectRecord()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IEffectRecord.csv";
        var dataTable = GetSkyrimData.GetIEffectRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIEmittance()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IEmittance.csv";
        var dataTable = GetSkyrimData.GetIEmittance();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIExplodeSpawn()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IExplodeSpawn.csv";
        var dataTable = GetSkyrimData.GetIExplodeSpawn();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIHarvestTarget()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IHarvestTarget.csv";
        var dataTable = GetSkyrimData.GetIHarvestTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIIdleRelation()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IIdleRelation.csv";
        var dataTable = GetSkyrimData.GetIIdleRelation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIItem()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IItem.csv";
        var dataTable = GetSkyrimData.GetIItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIItemOrList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IItemOrList.csv";
        var dataTable = GetSkyrimData.GetIItemOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIKeywordLinkedReference()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IKeywordLinkedReference.csv";
        var dataTable = GetSkyrimData.GetIKeywordLinkedReference();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIKnowable()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IKnowable.csv";
        var dataTable = GetSkyrimData.GetIKnowable();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillILockList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ILockList.csv";
        var dataTable = GetSkyrimData.GetILockList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImageSpace()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ImageSpace.csv";
        var dataTable = GetSkyrimData.GetImageSpace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImageSpaceAdapter()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ImageSpaceAdapter.csv";
        var dataTable = GetSkyrimData.GetImageSpaceAdapter();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIMagicItem()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IMagicItem.csv";
        var dataTable = GetSkyrimData.GetIMagicItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImpact()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Impact.csv";
        var dataTable = GetSkyrimData.GetImpact();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillImpactDataSet()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ImpactDataSet.csv";
        var dataTable = GetSkyrimData.GetImpactDataSet();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIngestible()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Ingestible.csv";
        var dataTable = GetSkyrimData.GetIngestible();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIngredient()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Ingredient.csv";
        var dataTable = GetSkyrimData.GetIngredient();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillINpcOrList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\INpcOrList.csv";
        var dataTable = GetSkyrimData.GetINpcOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillINpcSpawn()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\INpcSpawn.csv";
        var dataTable = GetSkyrimData.GetINpcSpawn();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIObjectId()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IObjectId.csv";
        var dataTable = GetSkyrimData.GetIObjectId();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIOutfitTarget()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IOutfitTarget.csv";
        var dataTable = GetSkyrimData.GetIOutfitTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIOwner()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IOwner.csv";
        var dataTable = GetSkyrimData.GetIOwner();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlaceableObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IPlaceableObject.csv";
        var dataTable = GetSkyrimData.GetIPlaceableObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlaced()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IPlaced.csv";
        var dataTable = GetSkyrimData.GetIPlaced();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlacedSimple()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IPlacedSimple.csv";
        var dataTable = GetSkyrimData.GetIPlacedSimple();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlacedThing()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IPlacedThing.csv";
        var dataTable = GetSkyrimData.GetIPlacedThing();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIPlacedTrapTarget()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IPlacedTrapTarget.csv";
        var dataTable = GetSkyrimData.GetIPlacedTrapTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIReferenceableObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IReferenceableObject.csv";
        var dataTable = GetSkyrimData.GetIReferenceableObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIRegionTarget()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IRegionTarget.csv";
        var dataTable = GetSkyrimData.GetIRegionTarget();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIRelatable()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IRelatable.csv";
        var dataTable = GetSkyrimData.GetIRelatable();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillISound()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ISound.csv";
        var dataTable = GetSkyrimData.GetISound();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillISpellOrList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ISpellOrList.csv";
        var dataTable = GetSkyrimData.GetISpellOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillISpellRecord()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ISpellRecord.csv";
        var dataTable = GetSkyrimData.GetISpellRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIVoiceTypeOrList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IVoiceTypeOrList.csv";
        var dataTable = GetSkyrimData.GetIVoiceTypeOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIWeaponOrList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IWeaponOrList.csv";
        var dataTable = GetSkyrimData.GetIWeaponOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillIWorldspaceOrList()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\IWorldspaceOrList.csv";
        var dataTable = GetSkyrimData.GetIWorldspaceOrList();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillKey()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Key.csv";
        var dataTable = GetSkyrimData.GetKey();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillKeyword()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Keyword.csv";
        var dataTable = GetSkyrimData.GetKeyword();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLandscape()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Landscape.csv";
        var dataTable = GetSkyrimData.GetLandscape();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLandscapeTexture()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LandscapeTexture.csv";
        var dataTable = GetSkyrimData.GetLandscapeTexture();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLensFlare()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LensFlare.csv";
        var dataTable = GetSkyrimData.GetLensFlare();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLeveledItem()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LeveledItem.csv";
        var dataTable = GetSkyrimData.GetLeveledItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLeveledNpc()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LeveledNpc.csv";
        var dataTable = GetSkyrimData.GetLeveledNpc();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLeveledSpell()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LeveledSpell.csv";
        var dataTable = GetSkyrimData.GetLeveledSpell();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLight()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Light.csv";
        var dataTable = GetSkyrimData.GetLight();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLightingTemplate()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LightingTemplate.csv";
        var dataTable = GetSkyrimData.GetLightingTemplate();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLoadScreen()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LoadScreen.csv";
        var dataTable = GetSkyrimData.GetLoadScreen();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLocation()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Location.csv";
        var dataTable = GetSkyrimData.GetLocation();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillLocationReferenceType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\LocationReferenceType.csv";
        var dataTable = GetSkyrimData.GetLocationReferenceType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMagicEffect()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MagicEffect.csv";
        var dataTable = GetSkyrimData.GetMagicEffect();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMaterialObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MaterialObject.csv";
        var dataTable = GetSkyrimData.GetMaterialObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMaterialType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MaterialType.csv";
        var dataTable = GetSkyrimData.GetMaterialType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMessage()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Message.csv";
        var dataTable = GetSkyrimData.GetMessage();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMiscItem()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MiscItem.csv";
        var dataTable = GetSkyrimData.GetMiscItem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMoveableStatic()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MoveableStatic.csv";
        var dataTable = GetSkyrimData.GetMoveableStatic();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMovementType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MovementType.csv";
        var dataTable = GetSkyrimData.GetMovementType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMusicTrack()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MusicTrack.csv";
        var dataTable = GetSkyrimData.GetMusicTrack();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillMusicType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\MusicType.csv";
        var dataTable = GetSkyrimData.GetMusicType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillNavigationMesh()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\NavigationMesh.csv";
        var dataTable = GetSkyrimData.GetNavigationMesh();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillNavigationMeshInfoMap()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\NavigationMeshInfoMap.csv";
        var dataTable = GetSkyrimData.GetNavigationMeshInfoMap();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillNpc()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Npc.csv";
        var dataTable = GetSkyrimData.GetNpc();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillObjectEffect()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ObjectEffect.csv";
        var dataTable = GetSkyrimData.GetObjectEffect();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillOutfit()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Outfit.csv";
        var dataTable = GetSkyrimData.GetOutfit();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPackage()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Package.csv";
        var dataTable = GetSkyrimData.GetPackage();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPerk()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Perk.csv";
        var dataTable = GetSkyrimData.GetPerk();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPlacedNpc()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\PlacedNpc.csv";
        var dataTable = GetSkyrimData.GetPlacedNpc();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillPlacedObject()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\PlacedObject.csv";
        var dataTable = GetSkyrimData.GetPlacedObject();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillProjectile()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Projectile.csv";
        var dataTable = GetSkyrimData.GetProjectile();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillQuest()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Quest.csv";
        var dataTable = GetSkyrimData.GetQuest();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillRace()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Race.csv";
        var dataTable = GetSkyrimData.GetRace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillRegion()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Region.csv";
        var dataTable = GetSkyrimData.GetRegion();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillRelationship()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Relationship.csv";
        var dataTable = GetSkyrimData.GetRelationship();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillReverbParameters()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ReverbParameters.csv";
        var dataTable = GetSkyrimData.GetReverbParameters();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillScene()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Scene.csv";
        var dataTable = GetSkyrimData.GetScene();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillScroll()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Scroll.csv";
        var dataTable = GetSkyrimData.GetScroll();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillShaderParticleGeometry()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\ShaderParticleGeometry.csv";
        var dataTable = GetSkyrimData.GetShaderParticleGeometry();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillShout()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Shout.csv";
        var dataTable = GetSkyrimData.GetShout();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSkyrimMajorRecord()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\SkyrimMajorRecord.csv";
        var dataTable = GetSkyrimData.GetSkyrimMajorRecord();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoulGem()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\SoulGem.csv";
        var dataTable = GetSkyrimData.GetSoulGem();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundCategory()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\SoundCategory.csv";
        var dataTable = GetSkyrimData.GetSoundCategory();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundDescriptor()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\SoundDescriptor.csv";
        var dataTable = GetSkyrimData.GetSoundDescriptor();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundMarker()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\SoundMarker.csv";
        var dataTable = GetSkyrimData.GetSoundMarker();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSoundOutputModel()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\SoundOutputModel.csv";
        var dataTable = GetSkyrimData.GetSoundOutputModel();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillSpell()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Spell.csv";
        var dataTable = GetSkyrimData.GetSpell();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillStatic()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Static.csv";
        var dataTable = GetSkyrimData.GetStatic();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillTalkingActivator()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\TalkingActivator.csv";
        var dataTable = GetSkyrimData.GetTalkingActivator();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillTextureSet()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\TextureSet.csv";
        var dataTable = GetSkyrimData.GetTextureSet();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillTree()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Tree.csv";
        var dataTable = GetSkyrimData.GetTree();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillVisualEffect()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\VisualEffect.csv";
        var dataTable = GetSkyrimData.GetVisualEffect();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillVoiceType()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\VoiceType.csv";
        var dataTable = GetSkyrimData.GetVoiceType();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillVolumetricLighting()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\VolumetricLighting.csv";
        var dataTable = GetSkyrimData.GetVolumetricLighting();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWater()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Water.csv";
        var dataTable = GetSkyrimData.GetWater();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }
    
    public static void FillWeapons()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Weapon.csv";
        var dataTable = GetSkyrimData.GetWeapon();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWeather()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Weather.csv";
        var dataTable = GetSkyrimData.GetWeather();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWordOfPower()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\WordOfPower.csv";
        var dataTable = GetSkyrimData.GetWordOfPower();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }

    public static void FillWorldspace()
    {
        var fileName = ConfigHandler.GetCsvDirectory() + "\\Worldspace.csv";
        var dataTable = GetSkyrimData.GetWorldSpace();
        CreateAndFillCsvFile.CreateAndFill(fileName, dataTable);
    }
}