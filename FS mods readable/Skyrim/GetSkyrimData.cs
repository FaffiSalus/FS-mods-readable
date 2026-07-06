using FS_mods_readable.Core;

namespace FS_mods_readable.Skyrim;

public static class GetSkyrimData
{
    public static DataTable GetWeapon(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Weapon().WinningOverrides(), trimString, maxLength);
    }

    public static DataTable GetAcousticSpace(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AcousticSpace().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetActionRecord(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ActionRecord().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetActivator(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Activator().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetActorValueInformation(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ActorValueInformation().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAddonNode(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AddonNode().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAlchemicalApparatus(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AlchemicalApparatus().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAmmunition(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Ammunition().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAnimatedObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AnimatedObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAPlacedTrap(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.APlacedTrap().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetArmor(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Armor().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetArmorAddon(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ArmorAddon().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetArtObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ArtObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAssociationType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AssociationType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetAStoryManagerNode(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AStoryManagerNode().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetBodyPartData(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.BodyPartData().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetBook(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Book().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetCameraPath(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CameraPath().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetCameraShot(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CameraShot().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetCell(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Cell().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetClass(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Class().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetClimate(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Climate().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetCollisionLayer(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CollisionLayer().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetColorRecord(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ColorRecord().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetCombatStyle(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CombatStyle().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetConstructibleObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ConstructibleObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetContainer(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Container().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDebris(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Debris().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDefaultObjectManager(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DefaultObjectManager().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDialogBranch(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogBranch().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDialogResponses(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogResponses().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDialogTopic(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogTopic().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDialogView(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogView().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDoor(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Door().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetDualCastData(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DualCastData().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetEffectShader(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.EffectShader().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetEncounterZone(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.EncounterZone().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetEquipType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.EquipType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetExplosion(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Explosion().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetEyes(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Eyes().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetFaction(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Faction().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetFlora(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Flora().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetFootstep(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Footstep().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetFootstepSet(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.FootstepSet().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetFormList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.FormList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetFurniture(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Furniture().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetGameSetting(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.GameSetting().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetGlobal(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Global().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetGrass(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Grass().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetHair(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Hair().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetHazard(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Hazard().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetHeadPart(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.HeadPart().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIAliasVoiceType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IAliasVoiceType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIBindableEquipment(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IBindableEquipment().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIComplexLocation(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IComplexLocation().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIConstructible(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IConstructible().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIdleAnimation(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IdleAnimation().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIdleMarker(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IdleMarker().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIEffectRecord(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IEffectRecord().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIEmittance(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IEmittance().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIExplodeSpawn(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IExplodeSpawn().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIHarvestTarget(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IHarvestTarget().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIIdleRelation(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IIdleRelation().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIItem(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IItem().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIItemOrList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IItemOrList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIKeywordLinkedReference(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IKeywordLinkedReference().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIKnowable(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IKnowable().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetILockList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ILockList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetImageSpace(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ImageSpace().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetImageSpaceAdapter(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ImageSpaceAdapter().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIMagicItem(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IMagicItem().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetImpact(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Impact().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetImpactDataSet(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ImpactDataSet().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIngestible(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Ingestible().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIngredient(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Ingredient().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetINpcOrList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.INpcOrList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetINpcSpawn(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.INpcSpawn().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIObjectId(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IObjectId().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIOutfitTarget(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IOutfitTarget().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIOwner(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IOwner().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIPlaceableObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlaceableObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIPlaced(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlaced().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIPlacedSimple(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlacedSimple().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIPlacedThing(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlacedThing().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIPlacedTrapTarget(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlacedTrapTarget().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIReferenceableObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IReferenceableObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIRegionTarget(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IRegionTarget().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIRelatable(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IRelatable().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetISound(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ISound().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetISpellOrList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ISpellOrList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetISpellRecord(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ISpellRecord().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIVoiceTypeOrList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IVoiceTypeOrList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIWeaponOrList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IWeaponOrList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetIWorldspaceOrList(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IWorldspaceOrList().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetKey(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Key().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetKeyword(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Keyword().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLandscape(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Landscape().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLandscapeTexture(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LandscapeTexture().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLensFlare(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LensFlare().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLeveledItem(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLeveledNpc(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LeveledNpc().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLeveledSpell(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LeveledSpell().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLight(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Light().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLightingTemplate(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LightingTemplate().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLoadScreen(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LoadScreen().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLocation(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Location().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetLocationReferenceType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LocationReferenceType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMagicEffect(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MagicEffect().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMaterialObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MaterialObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMaterialType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MaterialType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMessage(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Message().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMiscItem(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MiscItem().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMoveableStatic(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MoveableStatic().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMovementType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MovementType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMusicTrack(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MusicTrack().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetMusicType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MusicType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetNavigationMesh(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.NavigationMesh().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetNavigationMeshInfoMap(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.NavigationMeshInfoMap().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetNpc(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Npc().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetObjectEffect(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ObjectEffect().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetOutfit(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Outfit().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetPackage(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Package().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetPerk(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Perk().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetPlacedNpc(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.PlacedNpc().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetPlacedObject(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.PlacedObject().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetProjectile(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Projectile().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetQuest(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Quest().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetRace(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Race().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetRegion(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Region().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetRelationship(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Relationship().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetReverbParameters(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ReverbParameters().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetScene(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Scene().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetScroll(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Scroll().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetShaderParticleGeometry(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ShaderParticleGeometry().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetShout(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Shout().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSkyrimMajorRecord(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SkyrimMajorRecord().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSoulGem(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoulGem().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSoundCategory(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundCategory().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSoundDescriptor(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundDescriptor().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSoundMarker(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundMarker().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSoundOutputModel(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundOutputModel().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetSpell(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Spell().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetStatic(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Static().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetTalkingActivator(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.TalkingActivator().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetTextureSet(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.TextureSet().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetTree(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Tree().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetVisualEffect(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.VisualEffect().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetVoiceType(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.VoiceType().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetVolumetricLighting(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.VolumetricLighting().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetWater(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Water().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetWeather(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Weather().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetWordOfPower(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.WordOfPower().WinningOverrides(), trimString, maxLength);
    }
    
    public static DataTable GetWorldSpace(bool trimString = false, int maxLength = 0)
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Worldspace().WinningOverrides(), trimString, maxLength);
    }

}