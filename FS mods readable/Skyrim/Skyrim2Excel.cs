using FS_mods_readable.Core.Excel;

namespace FS_mods_readable.Skyrim
{
    public static class Skyrim2Excel
    {
        private const int _maxLength = 32767;

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
            DataTable dataTable = GetSkyrimData.GetAcousticSpace(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }
    
        public static void FillActionRecord(string fileName)
        {
            const string sheetName = "ActionRecord";
            DataTable dataTable = GetSkyrimData.GetActionRecord(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillActivator(string fileName)
        {
            const string sheetName = "Activator";
            DataTable dataTable = GetSkyrimData.GetActivator(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillActorValueInformation(string fileName)
        {
            const string sheetName = "ActorValueInformation";
            DataTable dataTable = GetSkyrimData.GetActorValueInformation(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAddonNode(string fileName)
        {
            const string sheetName = "AddonNode";
            DataTable dataTable = GetSkyrimData.GetAddonNode(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAlchemicalApparatus(string fileName)
        {
            const string sheetName = "AlchemicalApparatus";
            DataTable dataTable = GetSkyrimData.GetAlchemicalApparatus(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAmmunition(string fileName)
        {
            const string sheetName = "Ammunition";
            DataTable dataTable = GetSkyrimData.GetAmmunition(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAnimatedObject(string fileName)
        {
            const string sheetName = "AnimatedObject";
            DataTable dataTable = GetSkyrimData.GetAnimatedObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAPlacedTrap(string fileName)
        {
            const string sheetName = "APlacedTrap";
            DataTable dataTable = GetSkyrimData.GetAPlacedTrap(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillArmor(string fileName)
        {
            const string sheetName = "Armor";
            DataTable dataTable = GetSkyrimData.GetArmor(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillArmorAddon(string fileName)
        {
            const string sheetName = "ArmorAddon";
            DataTable dataTable = GetSkyrimData.GetArmorAddon(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillArtObject(string fileName)
        {
            const string sheetName = "ArtObject";
            DataTable dataTable = GetSkyrimData.GetArtObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAssociationType(string fileName)
        {
            const string sheetName = "AssociationType";
            DataTable dataTable = GetSkyrimData.GetAssociationType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillAStoryManagerNode(string fileName)
        {
            const string sheetName = "AStoryManagerNode";
            DataTable dataTable = GetSkyrimData.GetAStoryManagerNode(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillBodyPartData(string fileName)
        {
            const string sheetName = "BodyPartData";
            DataTable dataTable = GetSkyrimData.GetBodyPartData(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillBook(string fileName)
        {
            const string sheetName = "Book";
            DataTable dataTable = GetSkyrimData.GetBook(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCameraPath(string fileName)
        {
            const string sheetName = "CameraPath";
            DataTable dataTable = GetSkyrimData.GetCameraPath(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCameraShot(string fileName)
        {
            const string sheetName = "CameraShot";
            DataTable dataTable = GetSkyrimData.GetCameraShot(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCell(string fileName)
        {
            const string sheetName = "Cell";
            DataTable dataTable = GetSkyrimData.GetCell(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillClass(string fileName)
        {
            const string sheetName = "Class";
            DataTable dataTable = GetSkyrimData.GetClass(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillClimate(string fileName)
        {
            const string sheetName = "Climate";
            DataTable dataTable = GetSkyrimData.GetClimate(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCollisionLayer(string fileName)
        {
            const string sheetName = "CollisionLayer";
            DataTable dataTable = GetSkyrimData.GetCollisionLayer(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillColorRecord(string fileName)
        {
            const string sheetName = "ColorRecord";
            DataTable dataTable = GetSkyrimData.GetColorRecord(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillCombatStyle(string fileName)
        {
            const string sheetName = "CombatStyle";
            DataTable dataTable = GetSkyrimData.GetCombatStyle(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillConstructibleObject(string fileName)
        {
            const string sheetName = "ConstructibleObject";
            DataTable dataTable = GetSkyrimData.GetConstructibleObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillContainer(string fileName)
        {
            const string sheetName = "Container";
            DataTable dataTable = GetSkyrimData.GetContainer(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDebris(string fileName)
        {
            const string sheetName = "Debris";
            DataTable dataTable = GetSkyrimData.GetDebris(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDefaultObjectManager(string fileName)
        {
            const string sheetName = "DefaultObjectManager";
            DataTable dataTable = GetSkyrimData.GetDefaultObjectManager(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogBranch(string fileName)
        {
            const string sheetName = "DialogBranch";
            DataTable dataTable = GetSkyrimData.GetDialogBranch(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogResponses(string fileName)
        {
            const string sheetName = "DialogResponses";
            DataTable dataTable = GetSkyrimData.GetDialogResponses(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogTopic(string fileName)
        {
            const string sheetName = "DialogTopic";
            DataTable dataTable = GetSkyrimData.GetDialogTopic(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDialogView(string fileName)
        {
            const string sheetName = "DialogView";
            DataTable dataTable = GetSkyrimData.GetDialogView(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDoor(string fileName)
        {
            const string sheetName = "Door";
            DataTable dataTable = GetSkyrimData.GetDoor(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillDualCastData(string fileName)
        {
            const string sheetName = "DualCastData";
            DataTable dataTable = GetSkyrimData.GetDualCastData(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEffectShader(string fileName)
        {
            const string sheetName = "EffectShader";
            DataTable dataTable = GetSkyrimData.GetEffectShader(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEncounterZone(string fileName)
        {
            const string sheetName = "EncounterZone";
            DataTable dataTable = GetSkyrimData.GetEncounterZone(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEquipType(string fileName)
        {
            const string sheetName = "EquipType";
            DataTable dataTable = GetSkyrimData.GetEquipType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillExplosion(string fileName)
        {
            const string sheetName = "Explosions";
            DataTable dataTable = GetSkyrimData.GetExplosion(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillEyes(string fileName)
        {
            const string sheetName = "Eyes";
            DataTable dataTable = GetSkyrimData.GetEyes(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFaction(string fileName)
        {
            const string sheetName = "Faction";
            DataTable dataTable = GetSkyrimData.GetFaction(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFlora(string fileName)
        {
            const string sheetName = "Flora";
            DataTable dataTable = GetSkyrimData.GetFlora(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFootstep(string fileName)
        {
            const string sheetName = "Footstep";
            DataTable dataTable = GetSkyrimData.GetFootstep(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFootstepSet(string fileName)
        {
            const string sheetName = "FootstepSet";
            DataTable dataTable = GetSkyrimData.GetFootstepSet(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFormList(string fileName)
        {
            const string sheetName = "FormList";
            DataTable dataTable = GetSkyrimData.GetFormList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillFurniture(string fileName)
        {
            const string sheetName = "Furniture";
            DataTable dataTable = GetSkyrimData.GetFurniture(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillGameSetting(string fileName)
        {
            const string sheetName = "GameSetting";
            DataTable dataTable = GetSkyrimData.GetGameSetting(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillGlobal(string fileName)
        {
            const string sheetName = "Global";
            DataTable dataTable = GetSkyrimData.GetGlobal(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillGrass(string fileName)
        {
            const string sheetName = "Grass";
            DataTable dataTable = GetSkyrimData.GetGrass(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillHair(string fileName)
        {
            const string sheetName = "Hair";
            DataTable dataTable = GetSkyrimData.GetHair(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillHazard(string fileName)
        {
            const string sheetName = "Hazard";
            DataTable dataTable = GetSkyrimData.GetHazard(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillHeadPart(string fileName)
        {
            const string sheetName = "HeadPart";
            DataTable dataTable = GetSkyrimData.GetHeadPart(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIAliasVoiceType(string fileName)
        {
            const string sheetName = "IAliasVoiceType";
            DataTable dataTable = GetSkyrimData.GetIAliasVoiceType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIBindableEquipment(string fileName)
        {
            const string sheetName = "IBindableEquipment";
            DataTable dataTable = GetSkyrimData.GetIBindableEquipment(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIComplexLocation(string fileName)
        {
            const string sheetName = "IComplexLocation";
            DataTable dataTable = GetSkyrimData.GetIComplexLocation(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIConstructible(string fileName)
        {
            const string sheetName = "IConstructible";
            DataTable dataTable = GetSkyrimData.GetIConstructible(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIdleAnimation(string fileName)
        {
            const string sheetName = "IdleAnimation";
            DataTable dataTable = GetSkyrimData.GetIdleAnimation(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIdleMarker(string fileName)
        {
            const string sheetName = "IdleMarker";
            DataTable dataTable = GetSkyrimData.GetIdleMarker(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIEffectRecord(string fileName)
        {
            const string sheetName = "IEffectRecord";
            DataTable dataTable = GetSkyrimData.GetIEffectRecord(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIEmittance(string fileName)
        {
            const string sheetName = "IEmittance";
            DataTable dataTable = GetSkyrimData.GetIEmittance(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIExplodeSpawn(string fileName)
        {
            const string sheetName = "IExplodeSpawn";
            DataTable dataTable = GetSkyrimData.GetIExplodeSpawn(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIHarvestTarget(string fileName)
        {
            const string sheetName = "IHarvestTarget";
            DataTable dataTable = GetSkyrimData.GetIHarvestTarget(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIIdleRelation(string fileName)
        {
            const string sheetName = "IIdleRelation";
            DataTable dataTable = GetSkyrimData.GetIIdleRelation(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIItem(string fileName)
        {
            const string sheetName = "IItem";
            DataTable dataTable = GetSkyrimData.GetIItem(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIItemOrList(string fileName)
        {
            const string sheetName = "IItemOrList";
            DataTable dataTable = GetSkyrimData.GetIItemOrList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIKeywordLinkedReference(string fileName)
        {
            const string sheetName = "IKeywordLinkedReference";
            DataTable dataTable = GetSkyrimData.GetIKeywordLinkedReference(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIKnowable(string fileName)
        {
            const string sheetName = "IKnowable";
            DataTable dataTable = GetSkyrimData.GetIKnowable(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillILockList(string fileName)
        {
            const string sheetName = "ILockList";
            DataTable dataTable = GetSkyrimData.GetILockList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImageSpace(string fileName)
        {
            const string sheetName = "ImageSpace";
            DataTable dataTable = GetSkyrimData.GetImageSpace(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImageSpaceAdapter(string fileName)
        {
            const string sheetName = "ImageSpaceAdapter";
            DataTable dataTable = GetSkyrimData.GetImageSpaceAdapter(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIMagicItem(string fileName)
        {
            const string sheetName = "IMagicItem";
            DataTable dataTable = GetSkyrimData.GetIMagicItem(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImpact(string fileName)
        {
            const string sheetName = "Impact";
            DataTable dataTable = GetSkyrimData.GetImpact(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillImpactDataSet(string fileName)
        {
            const string sheetName = "ImpactDataSet";
            DataTable dataTable = GetSkyrimData.GetImpactDataSet(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIngestible(string fileName)
        {
            const string sheetName = "Ingestible";
            DataTable dataTable = GetSkyrimData.GetIngestible(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIngredient(string fileName)
        {
            const string sheetName = "Ingredient";
            DataTable dataTable = GetSkyrimData.GetIngredient(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillINpcOrList(string fileName)
        {
            const string sheetName = "INpcOrList";
            DataTable dataTable = GetSkyrimData.GetINpcOrList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillINpcSpawn(string fileName)
        {
            const string sheetName = "INpcSpawn";
            DataTable dataTable = GetSkyrimData.GetINpcSpawn(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIObjectId(string fileName)
        {
            const string sheetName = "IObjectId";
            DataTable dataTable = GetSkyrimData.GetIObjectId(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIOutfitTarget(string fileName)
        {
            const string sheetName = "IOutfitTarget";
            DataTable dataTable = GetSkyrimData.GetIOutfitTarget(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIOwner(string fileName)
        {
            const string sheetName = "IOwner";
            DataTable dataTable = GetSkyrimData.GetIOwner(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlaceableObject(string fileName)
        {
            const string sheetName = "IPlaceableObject";
            DataTable dataTable = GetSkyrimData.GetIPlaceableObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlaced(string fileName)
        {
            const string sheetName = "IPlaced";
            DataTable dataTable = GetSkyrimData.GetIPlaced(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlacedSimple(string fileName)
        {
            const string sheetName = "IPlacedSimple";
            DataTable dataTable = GetSkyrimData.GetIPlacedSimple(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlacedThing(string fileName)
        {
            const string sheetName = "IPlacedThing";
            DataTable dataTable = GetSkyrimData.GetIPlacedThing(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIPlacedTrapTarget(string fileName)
        {
            const string sheetName = "IPlacedTrapTarget";
            DataTable dataTable = GetSkyrimData.GetIPlacedTrapTarget(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIReferenceableObject(string fileName)
        {
            const string sheetName = "IReferenceableObject";
            DataTable dataTable = GetSkyrimData.GetIReferenceableObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIRegionTarget(string fileName)
        {
            const string sheetName = "IRegionTarget";
            DataTable dataTable = GetSkyrimData.GetIRegionTarget(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIRelatable(string fileName)
        {
            const string sheetName = "IRelatable";
            DataTable dataTable = GetSkyrimData.GetIRelatable(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillISound(string fileName)
        {
            const string sheetName = "ISound";
            DataTable dataTable = GetSkyrimData.GetISound(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillISpellOrList(string fileName)
        {
            const string sheetName = "ISpellOrList";
            DataTable dataTable = GetSkyrimData.GetISpellOrList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillISpellRecord(string fileName)
        {
            const string sheetName = "ISpellRecord";
            DataTable dataTable = GetSkyrimData.GetISpellRecord(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIVoiceTypeOrList(string fileName)
        {
            const string sheetName = "IVoiceTypeOrList";
            DataTable dataTable = GetSkyrimData.GetIVoiceTypeOrList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIWeaponOrList(string fileName)
        {
            const string sheetName = "IWeaponOrList";
            DataTable dataTable = GetSkyrimData.GetIWeaponOrList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillIWorldspaceOrList(string fileName)
        {
            const string sheetName = "IWorldspaceOrList";
            DataTable dataTable = GetSkyrimData.GetIWorldspaceOrList(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillKey(string fileName)
        {
            const string sheetName = "Key";
            DataTable dataTable = GetSkyrimData.GetKey(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillKeyword(string fileName)
        {
            const string sheetName = "Keyword";
            DataTable dataTable = GetSkyrimData.GetKeyword(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLandscape(string fileName)
        {
            const string sheetName = "Landscape";
            DataTable dataTable = GetSkyrimData.GetLandscape(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLandscapeTexture(string fileName)
        {
            const string sheetName = "LandscapeTexture";
            DataTable dataTable = GetSkyrimData.GetLandscapeTexture(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLensFlare(string fileName)
        {
            const string sheetName = "LensFlare";
            DataTable dataTable = GetSkyrimData.GetLensFlare(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLeveledItem(string fileName)
        {
            const string sheetName = "LeveledItem";
            DataTable dataTable = GetSkyrimData.GetLeveledItem(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLeveledNpc(string fileName)
        {
            const string sheetName = "LeveledNpc";
            DataTable dataTable = GetSkyrimData.GetLeveledNpc(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLeveledSpell(string fileName)
        {
            const string sheetName = "LeveledSpell";
            DataTable dataTable = GetSkyrimData.GetLeveledSpell(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLight(string fileName)
        {
            const string sheetName = "Light";
            DataTable dataTable = GetSkyrimData.GetLight(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLightingTemplate(string fileName)
        {
            const string sheetName = "LightingTemplate";
            DataTable dataTable = GetSkyrimData.GetLightingTemplate(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLoadScreen(string fileName)
        {
            const string sheetName = "LoadScreen";
            DataTable dataTable = GetSkyrimData.GetLoadScreen(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLocation(string fileName)
        {
            const string sheetName = "Location";
            DataTable dataTable = GetSkyrimData.GetLocation(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillLocationReferenceType(string fileName)
        {
            const string sheetName = "LocationReferenceType";
            DataTable dataTable = GetSkyrimData.GetLocationReferenceType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMagicEffect(string fileName)
        {
            const string sheetName = "MagicEffect";
            DataTable dataTable = GetSkyrimData.GetMagicEffect(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMaterialObject(string fileName)
        {
            const string sheetName = "MaterialObject";
            DataTable dataTable = GetSkyrimData.GetMaterialObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMaterialType(string fileName)
        {
            const string sheetName = "MaterialType";
            DataTable dataTable = GetSkyrimData.GetMaterialType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMessage(string fileName)
        {
            const string sheetName = "Message";
            DataTable dataTable = GetSkyrimData.GetMessage(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMiscItem(string fileName)
        {
            const string sheetName = "MiscItem";
            DataTable dataTable = GetSkyrimData.GetMiscItem(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMoveableStatic(string fileName)
        {
            const string sheetName = "MoveableStatic";
            DataTable dataTable = GetSkyrimData.GetMoveableStatic(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMovementType(string fileName)
        {
            const string sheetName = "MovementType";
            DataTable dataTable = GetSkyrimData.GetMovementType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMusicTrack(string fileName)
        {
            const string sheetName = "MusicTrack";
            DataTable dataTable = GetSkyrimData.GetMusicTrack(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillMusicType(string fileName)
        {
            const string sheetName = "MusicType";
            DataTable dataTable = GetSkyrimData.GetMusicType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillNavigationMesh(string fileName)
        {
            const string sheetName = "NavigationMesh";
            DataTable dataTable = GetSkyrimData.GetNavigationMesh(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillNavigationMeshInfoMap(string fileName)
        {
            const string sheetName = "NavigationMeshInfoMap";
            DataTable dataTable = GetSkyrimData.GetNavigationMeshInfoMap(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillNpc(string fileName)
        {
            const string sheetName = "Npc";
            DataTable dataTable = GetSkyrimData.GetNpc(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillObjectEffect(string fileName)
        {
            const string sheetName = "ObjectEffect";
            DataTable dataTable = GetSkyrimData.GetObjectEffect(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillOutfit(string fileName)
        {
            const string sheetName = "Outfit";
            DataTable dataTable = GetSkyrimData.GetOutfit(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPackage(string fileName)
        {
            const string sheetName = "Package";
            DataTable dataTable = GetSkyrimData.GetPackage(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPerk(string fileName)
        {
            const string sheetName = "Perk";
            DataTable dataTable = GetSkyrimData.GetPerk(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPlacedNpc(string fileName)
        {
            const string sheetName = "PlacedNpc";
            DataTable dataTable = GetSkyrimData.GetPlacedNpc(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillPlacedObject(string fileName)
        {
            const string sheetName = "PlacedObject";
            DataTable dataTable = GetSkyrimData.GetPlacedObject(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillProjectile(string fileName)
        {
            const string sheetName = "Projectile";
            DataTable dataTable = GetSkyrimData.GetProjectile(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillQuest(string fileName)
        {
            const string sheetName = "Quest";
            DataTable dataTable = GetSkyrimData.GetQuest(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillRace(string fileName)
        {
            const string sheetName = "Race";
            DataTable dataTable = GetSkyrimData.GetRace(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillRegion(string fileName)
        {
            const string sheetName = "Region";
            DataTable dataTable = GetSkyrimData.GetRegion(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillRelationship(string fileName)
        {
            const string sheetName = "Relationship";
            DataTable dataTable = GetSkyrimData.GetRelationship(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillReverbParameters(string fileName)
        {
            const string sheetName = "ReverbParameters";
            DataTable dataTable = GetSkyrimData.GetReverbParameters(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillScene(string fileName)
        {
            const string sheetName = "Scene";
            DataTable dataTable = GetSkyrimData.GetScene(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillScroll(string fileName)
        {
            const string sheetName = "Scroll";
            DataTable dataTable = GetSkyrimData.GetScroll(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillShaderParticleGeometry(string fileName)
        {
            const string sheetName = "ShaderParticleGeometry";
            DataTable dataTable = GetSkyrimData.GetShaderParticleGeometry(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillShout(string fileName)
        {
            const string sheetName = "Shout";
            DataTable dataTable = GetSkyrimData.GetShout(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSkyrimMajorRecord(string fileName)
        {
            const string sheetName = "SkyrimMajorRecord";
            DataTable dataTable = GetSkyrimData.GetSkyrimMajorRecord(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoulGem(string fileName)
        {
            const string sheetName = "SoulGem";
            DataTable dataTable = GetSkyrimData.GetSoulGem(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundCategory(string fileName)
        {
            const string sheetName = "SoundCategory";
            DataTable dataTable = GetSkyrimData.GetSoundCategory(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundDescriptor(string fileName)
        {
            const string sheetName = "SoundDescriptor";
            DataTable dataTable = GetSkyrimData.GetSoundDescriptor(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundMarker(string fileName)
        {
            const string sheetName = "SoundMarker";
            DataTable dataTable = GetSkyrimData.GetSoundMarker(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSoundOutputModel(string fileName)
        {
            const string sheetName = "SoundOutputModel";
            DataTable dataTable = GetSkyrimData.GetSoundOutputModel(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillSpell(string fileName)
        {
            const string sheetName = "Spell";
            DataTable dataTable = GetSkyrimData.GetSpell(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillStatic(string fileName)
        {
            const string sheetName = "Static";
            DataTable dataTable = GetSkyrimData.GetStatic(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillTalkingActivator(string fileName)
        {
            const string sheetName = "TalkingActivator";
            DataTable dataTable = GetSkyrimData.GetTalkingActivator(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillTextureSet(string fileName)
        {
            const string sheetName = "TextureSet";
            DataTable dataTable = GetSkyrimData.GetTextureSet(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillTree(string fileName)
        {
            const string sheetName = "Tree";
            DataTable dataTable = GetSkyrimData.GetTree(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillVisualEffect(string fileName)
        {
            const string sheetName = "VisualEffect";
            DataTable dataTable = GetSkyrimData.GetVisualEffect(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillVoiceType(string fileName)
        {
            const string sheetName = "VoiceType";
            DataTable dataTable = GetSkyrimData.GetVoiceType(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillVolumetricLighting(string fileName)
        {
            const string sheetName = "VolumetricLighting";
            DataTable dataTable = GetSkyrimData.GetVolumetricLighting(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWater(string fileName)
        {
            const string sheetName = "Water";
            DataTable dataTable = GetSkyrimData.GetWater(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }
    
        public static void FillWeapons(string fileName)
        {
            const string sheetName = "Weapons";
            DataTable dataTable = GetSkyrimData.GetWeapon(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWeather(string fileName)
        {
            const string sheetName = "Weather";
            DataTable dataTable = GetSkyrimData.GetWeather(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWordOfPower(string fileName)
        {
            const string sheetName = "WordOfPower";
            DataTable dataTable = GetSkyrimData.GetWordOfPower(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }

        public static void FillWorldspace(string fileName)
        {
            const string sheetName = "Worldspace";
            DataTable dataTable = GetSkyrimData.GetWorldSpace(true, _maxLength);
            CreateAndFillExcelFile.CreateAndFill(fileName, sheetName, dataTable);
        }
    }
}