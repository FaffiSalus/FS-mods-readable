using FS_mods_readable.Core;
using FS_mods_readable.Core.Excel;

namespace FS_mods_readable.Skyrim
{
    public static class Skyrim2Excel
    {
        public static void FillAllFiles()
        {
            var fileName = ConfigHandler.GetExcelDirectory() + "\\" + ConfigHandler.GetExcelFileName() + ".xlsx";
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
            FillBook(fileName); 
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
            var dataTable = GetSkyrimData.GetAcousticSpace(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }
    
        public static void FillActionRecord(string fileName)
        {
            const string sheetName = "ActionRecord";
            var dataTable = GetSkyrimData.GetActionRecord(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillActivator(string fileName)
        {
            const string sheetName = "Activator";
            var dataTable = GetSkyrimData.GetActivator(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillActorValueInformation(string fileName)
        {
            const string sheetName = "ActorValueInformation";
            var dataTable = GetSkyrimData.GetActorValueInformation(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAddonNode(string fileName)
        {
            const string sheetName = "AddonNode";
            var dataTable = GetSkyrimData.GetAddonNode(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAlchemicalApparatus(string fileName)
        {
            const string sheetName = "AlchemicalApparatus";
            var dataTable = GetSkyrimData.GetAlchemicalApparatus(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAmmunition(string fileName)
        {
            const string sheetName = "Ammunition";
            var dataTable = GetSkyrimData.GetAmmunition(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAnimatedObject(string fileName)
        {
            const string sheetName = "AnimatedObject";
            var dataTable = GetSkyrimData.GetAnimatedObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAPlacedTrap(string fileName)
        {
            const string sheetName = "APlacedTrap";
            var dataTable = GetSkyrimData.GetAPlacedTrap(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillArmor(string fileName)
        {
            const string sheetName = "Armor";
            var dataTable = GetSkyrimData.GetArmor(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillArmorAddon(string fileName)
        {
            const string sheetName = "ArmorAddon";
            var dataTable = GetSkyrimData.GetArmorAddon(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillArtObject(string fileName)
        {
            const string sheetName = "ArtObject";
            var dataTable = GetSkyrimData.GetArtObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAssociationType(string fileName)
        {
            const string sheetName = "AssociationType";
            var dataTable = GetSkyrimData.GetAssociationType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAStoryManagerNode(string fileName)
        {
            const string sheetName = "AStoryManagerNode";
            var dataTable = GetSkyrimData.GetAStoryManagerNode(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillBodyPartData(string fileName)
        {
            const string sheetName = "BodyPartData";
            var dataTable = GetSkyrimData.GetBodyPartData(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillBook(string fileName)
        {
            const string sheetName = "Book";
            var dataTable = GetSkyrimData.GetBook(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCameraPath(string fileName)
        {
            const string sheetName = "CameraPath";
            var dataTable = GetSkyrimData.GetCameraPath(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCameraShot(string fileName)
        {
            const string sheetName = "CameraShot";
            var dataTable = GetSkyrimData.GetCameraShot(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCell(string fileName)
        {
            const string sheetName = "Cell";
            var dataTable = GetSkyrimData.GetCell(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillClass(string fileName)
        {
            const string sheetName = "Class";
            var dataTable = GetSkyrimData.GetClass(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillClimate(string fileName)
        {
            const string sheetName = "Climate";
            var dataTable = GetSkyrimData.GetClimate(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCollisionLayer(string fileName)
        {
            const string sheetName = "CollisionLayer";
            var dataTable = GetSkyrimData.GetCollisionLayer(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillColorRecord(string fileName)
        {
            const string sheetName = "ColorRecord";
            var dataTable = GetSkyrimData.GetColorRecord(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCombatStyle(string fileName)
        {
            const string sheetName = "CombatStyle";
            var dataTable = GetSkyrimData.GetCombatStyle(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillConstructibleObject(string fileName)
        {
            const string sheetName = "ConstructibleObject";
            var dataTable = GetSkyrimData.GetConstructibleObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillContainer(string fileName)
        {
            const string sheetName = "Container";
            var dataTable = GetSkyrimData.GetContainer(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDebris(string fileName)
        {
            const string sheetName = "Debris";
            var dataTable = GetSkyrimData.GetDebris(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDefaultObjectManager(string fileName)
        {
            const string sheetName = "DefaultObjectManager";
            var dataTable = GetSkyrimData.GetDefaultObjectManager(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogBranch(string fileName)
        {
            const string sheetName = "DialogBranch";
            var dataTable = GetSkyrimData.GetDialogBranch(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogResponses(string fileName)
        {
            const string sheetName = "DialogResponses";
            var dataTable = GetSkyrimData.GetDialogResponses(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogTopic(string fileName)
        {
            const string sheetName = "DialogTopic";
            var dataTable = GetSkyrimData.GetDialogTopic(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogView(string fileName)
        {
            const string sheetName = "DialogView";
            var dataTable = GetSkyrimData.GetDialogView(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDoor(string fileName)
        {
            const string sheetName = "Door";
            var dataTable = GetSkyrimData.GetDoor(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDualCastData(string fileName)
        {
            const string sheetName = "DualCastData";
            var dataTable = GetSkyrimData.GetDualCastData(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEffectShader(string fileName)
        {
            const string sheetName = "EffectShader";
            var dataTable = GetSkyrimData.GetEffectShader(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEncounterZone(string fileName)
        {
            const string sheetName = "EncounterZone";
            var dataTable = GetSkyrimData.GetEncounterZone(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEquipType(string fileName)
        {
            const string sheetName = "EquipType";
            var dataTable = GetSkyrimData.GetEquipType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillExplosion(string fileName)
        {
            const string sheetName = "Explosions";
            var dataTable = GetSkyrimData.GetExplosion(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEyes(string fileName)
        {
            const string sheetName = "Eyes";
            var dataTable = GetSkyrimData.GetEyes(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFaction(string fileName)
        {
            const string sheetName = "Faction";
            var dataTable = GetSkyrimData.GetFaction(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFlora(string fileName)
        {
            const string sheetName = "Flora";
            var dataTable = GetSkyrimData.GetFlora(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFootstep(string fileName)
        {
            const string sheetName = "Footstep";
            var dataTable = GetSkyrimData.GetFootstep(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFootstepSet(string fileName)
        {
            const string sheetName = "FootstepSet";
            var dataTable = GetSkyrimData.GetFootstepSet(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFormList(string fileName)
        {
            const string sheetName = "FormList";
            var dataTable = GetSkyrimData.GetFormList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFurniture(string fileName)
        {
            const string sheetName = "Furniture";
            var dataTable = GetSkyrimData.GetFurniture(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillGameSetting(string fileName)
        {
            const string sheetName = "GameSetting";
            var dataTable = GetSkyrimData.GetGameSetting(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillGlobal(string fileName)
        {
            const string sheetName = "Global";
            var dataTable = GetSkyrimData.GetGlobal(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillGrass(string fileName)
        {
            const string sheetName = "Grass";
            var dataTable = GetSkyrimData.GetGrass(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillHair(string fileName)
        {
            const string sheetName = "Hair";
            var dataTable = GetSkyrimData.GetHair(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillHazard(string fileName)
        {
            const string sheetName = "Hazard";
            var dataTable = GetSkyrimData.GetHazard(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillHeadPart(string fileName)
        {
            const string sheetName = "HeadPart";
            var dataTable = GetSkyrimData.GetHeadPart(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIAliasVoiceType(string fileName)
        {
            const string sheetName = "IAliasVoiceType";
            var dataTable = GetSkyrimData.GetIAliasVoiceType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIBindableEquipment(string fileName)
        {
            const string sheetName = "IBindableEquipment";
            var dataTable = GetSkyrimData.GetIBindableEquipment(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIComplexLocation(string fileName)
        {
            const string sheetName = "IComplexLocation";
            var dataTable = GetSkyrimData.GetIComplexLocation(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIConstructible(string fileName)
        {
            const string sheetName = "IConstructible";
            var dataTable = GetSkyrimData.GetIConstructible(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIdleAnimation(string fileName)
        {
            const string sheetName = "IdleAnimation";
            var dataTable = GetSkyrimData.GetIdleAnimation(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIdleMarker(string fileName)
        {
            const string sheetName = "IdleMarker";
            var dataTable = GetSkyrimData.GetIdleMarker(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIEffectRecord(string fileName)
        {
            const string sheetName = "IEffectRecord";
            var dataTable = GetSkyrimData.GetIEffectRecord(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIEmittance(string fileName)
        {
            const string sheetName = "IEmittance";
            var dataTable = GetSkyrimData.GetIEmittance(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIExplodeSpawn(string fileName)
        {
            const string sheetName = "IExplodeSpawn";
            var dataTable = GetSkyrimData.GetIExplodeSpawn(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIHarvestTarget(string fileName)
        {
            const string sheetName = "IHarvestTarget";
            var dataTable = GetSkyrimData.GetIHarvestTarget(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIIdleRelation(string fileName)
        {
            const string sheetName = "IIdleRelation";
            var dataTable = GetSkyrimData.GetIIdleRelation(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIItem(string fileName)
        {
            const string sheetName = "IItem";
            var dataTable = GetSkyrimData.GetIItem(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIItemOrList(string fileName)
        {
            const string sheetName = "IItemOrList";
            var dataTable = GetSkyrimData.GetIItemOrList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIKeywordLinkedReference(string fileName)
        {
            const string sheetName = "IKeywordLinkedReference";
            var dataTable = GetSkyrimData.GetIKeywordLinkedReference(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIKnowable(string fileName)
        {
            const string sheetName = "IKnowable";
            var dataTable = GetSkyrimData.GetIKnowable(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillILockList(string fileName)
        {
            const string sheetName = "ILockList";
            var dataTable = GetSkyrimData.GetILockList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImageSpace(string fileName)
        {
            const string sheetName = "ImageSpace";
            var dataTable = GetSkyrimData.GetImageSpace(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImageSpaceAdapter(string fileName)
        {
            const string sheetName = "ImageSpaceAdapter";
            var dataTable = GetSkyrimData.GetImageSpaceAdapter(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIMagicItem(string fileName)
        {
            const string sheetName = "IMagicItem";
            var dataTable = GetSkyrimData.GetIMagicItem(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImpact(string fileName)
        {
            const string sheetName = "Impact";
            var dataTable = GetSkyrimData.GetImpact(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImpactDataSet(string fileName)
        {
            const string sheetName = "ImpactDataSet";
            var dataTable = GetSkyrimData.GetImpactDataSet(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIngestible(string fileName)
        {
            const string sheetName = "Ingestible";
            var dataTable = GetSkyrimData.GetIngestible(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIngredient(string fileName)
        {
            const string sheetName = "Ingredient";
            var dataTable = GetSkyrimData.GetIngredient(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillINpcOrList(string fileName)
        {
            const string sheetName = "INpcOrList";
            var dataTable = GetSkyrimData.GetINpcOrList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillINpcSpawn(string fileName)
        {
            const string sheetName = "INpcSpawn";
            var dataTable = GetSkyrimData.GetINpcSpawn(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIObjectId(string fileName)
        {
            const string sheetName = "IObjectId";
            var dataTable = GetSkyrimData.GetIObjectId(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIOutfitTarget(string fileName)
        {
            const string sheetName = "IOutfitTarget";
            var dataTable = GetSkyrimData.GetIOutfitTarget(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIOwner(string fileName)
        {
            const string sheetName = "IOwner";
            var dataTable = GetSkyrimData.GetIOwner(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlaceableObject(string fileName)
        {
            const string sheetName = "IPlaceableObject";
            var dataTable = GetSkyrimData.GetIPlaceableObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlaced(string fileName)
        {
            const string sheetName = "IPlaced";
            var dataTable = GetSkyrimData.GetIPlaced(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlacedSimple(string fileName)
        {
            const string sheetName = "IPlacedSimple";
            var dataTable = GetSkyrimData.GetIPlacedSimple(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlacedThing(string fileName)
        {
            const string sheetName = "IPlacedThing";
            var dataTable = GetSkyrimData.GetIPlacedThing(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlacedTrapTarget(string fileName)
        {
            const string sheetName = "IPlacedTrapTarget";
            var dataTable = GetSkyrimData.GetIPlacedTrapTarget(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIReferenceableObject(string fileName)
        {
            const string sheetName = "IReferenceableObject";
            var dataTable = GetSkyrimData.GetIReferenceableObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIRegionTarget(string fileName)
        {
            const string sheetName = "IRegionTarget";
            var dataTable = GetSkyrimData.GetIRegionTarget(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIRelatable(string fileName)
        {
            const string sheetName = "IRelatable";
            var dataTable = GetSkyrimData.GetIRelatable(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillISound(string fileName)
        {
            const string sheetName = "ISound";
            var dataTable = GetSkyrimData.GetISound(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillISpellOrList(string fileName)
        {
            const string sheetName = "ISpellOrList";
            var dataTable = GetSkyrimData.GetISpellOrList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillISpellRecord(string fileName)
        {
            const string sheetName = "ISpellRecord";
            var dataTable = GetSkyrimData.GetISpellRecord(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIVoiceTypeOrList(string fileName)
        {
            const string sheetName = "IVoiceTypeOrList";
            var dataTable = GetSkyrimData.GetIVoiceTypeOrList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIWeaponOrList(string fileName)
        {
            const string sheetName = "IWeaponOrList";
            var dataTable = GetSkyrimData.GetIWeaponOrList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIWorldspaceOrList(string fileName)
        {
            const string sheetName = "IWorldspaceOrList";
            var dataTable = GetSkyrimData.GetIWorldspaceOrList(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillKey(string fileName)
        {
            const string sheetName = "Key";
            var dataTable = GetSkyrimData.GetKey(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillKeyword(string fileName)
        {
            const string sheetName = "Keyword";
            var dataTable = GetSkyrimData.GetKeyword(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLandscape(string fileName)
        {
            const string sheetName = "Landscape";
            var dataTable = GetSkyrimData.GetLandscape(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLandscapeTexture(string fileName)
        {
            const string sheetName = "LandscapeTexture";
            var dataTable = GetSkyrimData.GetLandscapeTexture(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLensFlare(string fileName)
        {
            const string sheetName = "LensFlare";
            var dataTable = GetSkyrimData.GetLensFlare(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLeveledItem(string fileName)
        {
            const string sheetName = "LeveledItem";
            var dataTable = GetSkyrimData.GetLeveledItem(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLeveledNpc(string fileName)
        {
            const string sheetName = "LeveledNpc";
            var dataTable = GetSkyrimData.GetLeveledNpc(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLeveledSpell(string fileName)
        {
            const string sheetName = "LeveledSpell";
            var dataTable = GetSkyrimData.GetLeveledSpell(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLight(string fileName)
        {
            const string sheetName = "Light";
            var dataTable = GetSkyrimData.GetLight(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLightingTemplate(string fileName)
        {
            const string sheetName = "LightingTemplate";
            var dataTable = GetSkyrimData.GetLightingTemplate(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLoadScreen(string fileName)
        {
            const string sheetName = "LoadScreen";
            var dataTable = GetSkyrimData.GetLoadScreen(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLocation(string fileName)
        {
            const string sheetName = "Location";
            var dataTable = GetSkyrimData.GetLocation(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLocationReferenceType(string fileName)
        {
            const string sheetName = "LocationReferenceType";
            var dataTable = GetSkyrimData.GetLocationReferenceType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMagicEffect(string fileName)
        {
            const string sheetName = "MagicEffect";
            var dataTable = GetSkyrimData.GetMagicEffect(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMaterialObject(string fileName)
        {
            const string sheetName = "MaterialObject";
            var dataTable = GetSkyrimData.GetMaterialObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMaterialType(string fileName)
        {
            const string sheetName = "MaterialType";
            var dataTable = GetSkyrimData.GetMaterialType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMessage(string fileName)
        {
            const string sheetName = "Message";
            var dataTable = GetSkyrimData.GetMessage(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMiscItem(string fileName)
        {
            const string sheetName = "MiscItem";
            var dataTable = GetSkyrimData.GetMiscItem(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMoveableStatic(string fileName)
        {
            const string sheetName = "MoveableStatic";
            var dataTable = GetSkyrimData.GetMoveableStatic(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMovementType(string fileName)
        {
            const string sheetName = "MovementType";
            var dataTable = GetSkyrimData.GetMovementType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMusicTrack(string fileName)
        {
            const string sheetName = "MusicTrack";
            var dataTable = GetSkyrimData.GetMusicTrack(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMusicType(string fileName)
        {
            const string sheetName = "MusicType";
            var dataTable = GetSkyrimData.GetMusicType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillNavigationMesh(string fileName)
        {
            const string sheetName = "NavigationMesh";
            var dataTable = GetSkyrimData.GetNavigationMesh(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillNavigationMeshInfoMap(string fileName)
        {
            const string sheetName = "NavigationMeshInfoMap";
            var dataTable = GetSkyrimData.GetNavigationMeshInfoMap(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillNpc(string fileName)
        {
            const string sheetName = "Npc";
            var dataTable = GetSkyrimData.GetNpc(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillObjectEffect(string fileName)
        {
            const string sheetName = "ObjectEffect";
            var dataTable = GetSkyrimData.GetObjectEffect(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillOutfit(string fileName)
        {
            const string sheetName = "Outfit";
            var dataTable = GetSkyrimData.GetOutfit(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPackage(string fileName)
        {
            const string sheetName = "Package";
            var dataTable = GetSkyrimData.GetPackage(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPerk(string fileName)
        {
            const string sheetName = "Perk";
            var dataTable = GetSkyrimData.GetPerk(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPlacedNpc(string fileName)
        {
            const string sheetName = "PlacedNpc";
            var dataTable = GetSkyrimData.GetPlacedNpc(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPlacedObject(string fileName)
        {
            const string sheetName = "PlacedObject";
            var dataTable = GetSkyrimData.GetPlacedObject(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillProjectile(string fileName)
        {
            const string sheetName = "Projectile";
            var dataTable = GetSkyrimData.GetProjectile(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillQuest(string fileName)
        {
            const string sheetName = "Quest";
            var dataTable = GetSkyrimData.GetQuest(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillRace(string fileName)
        {
            const string sheetName = "Race";
            var dataTable = GetSkyrimData.GetRace(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillRegion(string fileName)
        {
            const string sheetName = "Region";
            var dataTable = GetSkyrimData.GetRegion(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillRelationship(string fileName)
        {
            const string sheetName = "Relationship";
            var dataTable = GetSkyrimData.GetRelationship(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillReverbParameters(string fileName)
        {
            const string sheetName = "ReverbParameters";
            var dataTable = GetSkyrimData.GetReverbParameters(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillScene(string fileName)
        {
            const string sheetName = "Scene";
            var dataTable = GetSkyrimData.GetScene(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillScroll(string fileName)
        {
            const string sheetName = "Scroll";
            var dataTable = GetSkyrimData.GetScroll(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillShaderParticleGeometry(string fileName)
        {
            const string sheetName = "ShaderParticleGeometry";
            var dataTable = GetSkyrimData.GetShaderParticleGeometry(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillShout(string fileName)
        {
            const string sheetName = "Shout";
            var dataTable = GetSkyrimData.GetShout(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSkyrimMajorRecord(string fileName)
        {
            const string sheetName = "SkyrimMajorRecord";
            var dataTable = GetSkyrimData.GetSkyrimMajorRecord(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoulGem(string fileName)
        {
            const string sheetName = "SoulGem";
            var dataTable = GetSkyrimData.GetSoulGem(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundCategory(string fileName)
        {
            const string sheetName = "SoundCategory";
            var dataTable = GetSkyrimData.GetSoundCategory(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundDescriptor(string fileName)
        {
            const string sheetName = "SoundDescriptor";
            var dataTable = GetSkyrimData.GetSoundDescriptor(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundMarker(string fileName)
        {
            const string sheetName = "SoundMarker";
            var dataTable = GetSkyrimData.GetSoundMarker(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundOutputModel(string fileName)
        {
            const string sheetName = "SoundOutputModel";
            var dataTable = GetSkyrimData.GetSoundOutputModel(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSpell(string fileName)
        {
            const string sheetName = "Spell";
            var dataTable = GetSkyrimData.GetSpell(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillStatic(string fileName)
        {
            const string sheetName = "Static";
            var dataTable = GetSkyrimData.GetStatic(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillTalkingActivator(string fileName)
        {
            const string sheetName = "TalkingActivator";
            var dataTable = GetSkyrimData.GetTalkingActivator(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillTextureSet(string fileName)
        {
            const string sheetName = "TextureSet";
            var dataTable = GetSkyrimData.GetTextureSet(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillTree(string fileName)
        {
            const string sheetName = "Tree";
            var dataTable = GetSkyrimData.GetTree(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillVisualEffect(string fileName)
        {
            const string sheetName = "VisualEffect";
            var dataTable = GetSkyrimData.GetVisualEffect(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillVoiceType(string fileName)
        {
            const string sheetName = "VoiceType";
            var dataTable = GetSkyrimData.GetVoiceType(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillVolumetricLighting(string fileName)
        {
            const string sheetName = "VolumetricLighting";
            var dataTable = GetSkyrimData.GetVolumetricLighting(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWater(string fileName)
        {
            const string sheetName = "Water";
            var dataTable = GetSkyrimData.GetWater(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }
    
        public static void FillWeapons(string fileName)
        {
            const string sheetName = "Weapons";
            var dataTable = GetSkyrimData.GetWeapon(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWeather(string fileName)
        {
            const string sheetName = "Weather";
            var dataTable = GetSkyrimData.GetWeather(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWordOfPower(string fileName)
        {
            const string sheetName = "WordOfPower";
            var dataTable = GetSkyrimData.GetWordOfPower(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWorldspace(string fileName)
        {
            const string sheetName = "Worldspace";
            var dataTable = GetSkyrimData.GetWorldSpace(true, int.Parse(ConfigHandler.GetExcelCellLimit() ?? "0"));
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }
    }
}