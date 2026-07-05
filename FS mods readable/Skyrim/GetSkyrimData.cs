using FS_mods_readable.Core;

namespace FS_mods_readable.Skyrim;

public static class GetSkyrimData
{
    public static DataTable GetWeapon()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Weapon().WinningOverrides());
    }

    public static DataTable GetAcousticSpace()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AcousticSpace().WinningOverrides());
    }
    
    public static DataTable GetActionRecord()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ActionRecord().WinningOverrides());
    }
    
    public static DataTable GetActivator()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Activator().WinningOverrides());
    }
    
    public static DataTable GetActorValueInformation()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ActorValueInformation().WinningOverrides());
    }
    
    public static DataTable GetAddonNode()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AddonNode().WinningOverrides());
    }
    
    public static DataTable GetAlchemicalApparatus()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AlchemicalApparatus().WinningOverrides());
    }
    
    public static DataTable GetAmmunition()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Ammunition().WinningOverrides());
    }
    
    public static DataTable GetAnimatedObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AnimatedObject().WinningOverrides());
    }
    
    public static DataTable GetAPlacedTrap()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.APlacedTrap().WinningOverrides());
    }
    
    public static DataTable GetArmor()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Armor().WinningOverrides());
    }
    
    public static DataTable GetArmorAddon()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ArmorAddon().WinningOverrides());
    }
    
    public static DataTable GetArtObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ArtObject().WinningOverrides());
    }
    
    public static DataTable GetAssociationType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AssociationType().WinningOverrides());
    }
    
    public static DataTable GetAStoryManagerNode()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.AStoryManagerNode().WinningOverrides());
    }
    
    public static DataTable GetBodyPartData()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.BodyPartData().WinningOverrides());
    }
    
    public static DataTable GetBook()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Book().WinningOverrides());
    }
    
    public static DataTable GetCameraPath()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CameraPath().WinningOverrides());
    }
    
    public static DataTable GetCameraShot()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CameraShot().WinningOverrides());
    }
    
    public static DataTable GetCell()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Cell().WinningOverrides());
    }
    
    public static DataTable GetClass()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Class().WinningOverrides());
    }
    
    public static DataTable GetClimate()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Climate().WinningOverrides());
    }
    
    public static DataTable GetCollisionLayer()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CollisionLayer().WinningOverrides());
    }
    
    public static DataTable GetColorRecord()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ColorRecord().WinningOverrides());
    }
    
    public static DataTable GetCombatStyle()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.CombatStyle().WinningOverrides());
    }
    
    public static DataTable GetConstructibleObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ConstructibleObject().WinningOverrides());
    }
    
    public static DataTable GetContainer()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Container().WinningOverrides());
    }
    
    public static DataTable GetDebris()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Debris().WinningOverrides());
    }
    
    public static DataTable GetDefaultObjectManager()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DefaultObjectManager().WinningOverrides());
    }
    
    public static DataTable GetDialogBranch()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogBranch().WinningOverrides());
    }
    
    public static DataTable GetDialogResponses()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogResponses().WinningOverrides());
    }
    
    public static DataTable GetDialogTopic()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogTopic().WinningOverrides());
    }
    
    public static DataTable GetDialogView()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DialogView().WinningOverrides());
    }
    
    public static DataTable GetDoor()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Door().WinningOverrides());
    }
    
    public static DataTable GetDualCastData()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.DualCastData().WinningOverrides());
    }
    
    public static DataTable GetEffectShader()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.EffectShader().WinningOverrides());
    }
    
    public static DataTable GetEncounterZone()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.EncounterZone().WinningOverrides());
    }
    
    public static DataTable GetEquipType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.EquipType().WinningOverrides());
    }
    
    public static DataTable GetExplosion()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Explosion().WinningOverrides());
    }
    
    public static DataTable GetEyes()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Eyes().WinningOverrides());
    }
    
    public static DataTable GetFaction()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Faction().WinningOverrides());
    }
    
    public static DataTable GetFlora()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Flora().WinningOverrides());
    }
    
    public static DataTable GetFootstep()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Footstep().WinningOverrides());
    }
    
    public static DataTable GetFootstepSet()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.FootstepSet().WinningOverrides());
    }
    
    public static DataTable GetFormList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.FormList().WinningOverrides());
    }
    
    public static DataTable GetFurniture()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Furniture().WinningOverrides());
    }
    
    public static DataTable GetGameSetting()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.GameSetting().WinningOverrides());
    }
    
    public static DataTable GetGlobal()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Global().WinningOverrides());
    }
    
    public static DataTable GetGrass()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Grass().WinningOverrides());
    }
    
    public static DataTable GetHair()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Hair().WinningOverrides());
    }
    
    public static DataTable GetHazard()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Hazard().WinningOverrides());
    }
    
    public static DataTable GetHeadPart()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.HeadPart().WinningOverrides());
    }
    
    public static DataTable GetIAliasVoiceType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IAliasVoiceType().WinningOverrides());
    }
    
    public static DataTable GetIBindableEquipment()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IBindableEquipment().WinningOverrides());
    }
    
    public static DataTable GetIComplexLocation()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IComplexLocation().WinningOverrides());
    }
    
    public static DataTable GetIConstructible()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IConstructible().WinningOverrides());
    }
    
    public static DataTable GetIdleAnimation()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IdleAnimation().WinningOverrides());
    }
    
    public static DataTable GetIdleMarker()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IdleMarker().WinningOverrides());
    }
    
    public static DataTable GetIEffectRecord()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IEffectRecord().WinningOverrides());
    }
    
    public static DataTable GetIEmittance()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IEmittance().WinningOverrides());
    }
    
    public static DataTable GetIExplodeSpawn()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IExplodeSpawn().WinningOverrides());
    }
    
    public static DataTable GetIHarvestTarget()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IHarvestTarget().WinningOverrides());
    }
    
    public static DataTable GetIIdleRelation()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IIdleRelation().WinningOverrides());
    }
    
    public static DataTable GetIItem()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IItem().WinningOverrides());
    }
    
    public static DataTable GetIItemOrList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IItemOrList().WinningOverrides());
    }
    
    public static DataTable GetIKeywordLinkedReference()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IKeywordLinkedReference().WinningOverrides());
    }
    
    public static DataTable GetIKnowable()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IKnowable().WinningOverrides());
    }
    
    public static DataTable GetILockList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ILockList().WinningOverrides());
    }
    
    public static DataTable GetImageSpace()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ImageSpace().WinningOverrides());
    }
    
    public static DataTable GetImageSpaceAdapter()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ImageSpaceAdapter().WinningOverrides());
    }
    
    public static DataTable GetIMagicItem()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IMagicItem().WinningOverrides());
    }
    
    public static DataTable GetImpact()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Impact().WinningOverrides());
    }
    
    public static DataTable GetImpactDataSet()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ImpactDataSet().WinningOverrides());
    }
    
    public static DataTable GetIngestible()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Ingestible().WinningOverrides());
    }
    
    public static DataTable GetIngredient()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Ingredient().WinningOverrides());
    }
    
    public static DataTable GetINpcOrList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.INpcOrList().WinningOverrides());
    }
    
    public static DataTable GetINpcSpawn()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.INpcSpawn().WinningOverrides());
    }
    
    public static DataTable GetIObjectId()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IObjectId().WinningOverrides());
    }
    
    public static DataTable GetIOutfitTarget()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IOutfitTarget().WinningOverrides());
    }
    
    public static DataTable GetIOwner()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IOwner().WinningOverrides());
    }
    
    public static DataTable GetIPlaceableObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlaceableObject().WinningOverrides());
    }
    
    public static DataTable GetIPlaced()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlaced().WinningOverrides());
    }
    
    public static DataTable GetIPlacedSimple()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlacedSimple().WinningOverrides());
    }
    
    public static DataTable GetIPlacedThing()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlacedThing().WinningOverrides());
    }
    
    public static DataTable GetIPlacedTrapTarget()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IPlacedTrapTarget().WinningOverrides());
    }
    
    public static DataTable GetIReferenceableObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IReferenceableObject().WinningOverrides());
    }
    
    public static DataTable GetIRegionTarget()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IRegionTarget().WinningOverrides());
    }
    
    public static DataTable GetIRelatable()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IRelatable().WinningOverrides());
    }
    
    public static DataTable GetISound()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ISound().WinningOverrides());
    }
    
    public static DataTable GetISpellOrList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ISpellOrList().WinningOverrides());
    }
    
    public static DataTable GetISpellRecord()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ISpellRecord().WinningOverrides());
    }
    
    public static DataTable GetIVoiceTypeOrList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IVoiceTypeOrList().WinningOverrides());
    }
    
    public static DataTable GetIWeaponOrList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IWeaponOrList().WinningOverrides());
    }
    
    public static DataTable GetIWorldspaceOrList()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.IWorldspaceOrList().WinningOverrides());
    }
    
    public static DataTable GetKey()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Key().WinningOverrides());
    }
    
    public static DataTable GetKeyword()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Keyword().WinningOverrides());
    }
    
    public static DataTable GetLandscape()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Landscape().WinningOverrides());
    }
    
    public static DataTable GetLandscapeTexture()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LandscapeTexture().WinningOverrides());
    }
    
    public static DataTable GetLensFlare()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LensFlare().WinningOverrides());
    }
    
    public static DataTable GetLeveledItem()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides());
    }
    
    public static DataTable GetLeveledNpc()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LeveledNpc().WinningOverrides());
    }
    
    public static DataTable GetLeveledSpell()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LeveledSpell().WinningOverrides());
    }
    
    public static DataTable GetLight()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Light().WinningOverrides());
    }
    
    public static DataTable GetLightingTemplate()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LightingTemplate().WinningOverrides());
    }
    
    public static DataTable GetLoadScreen()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LoadScreen().WinningOverrides());
    }
    
    public static DataTable GetLocation()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Location().WinningOverrides());
    }
    
    public static DataTable GetLocationReferenceType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.LocationReferenceType().WinningOverrides());
    }
    
    public static DataTable GetMagicEffect()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MagicEffect().WinningOverrides());
    }
    
    public static DataTable GetMaterialObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MaterialObject().WinningOverrides());
    }
    
    public static DataTable GetMaterialType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MaterialType().WinningOverrides());
    }
    
    public static DataTable GetMessage()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Message().WinningOverrides());
    }
    
    public static DataTable GetMiscItem()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MiscItem().WinningOverrides());
    }
    
    public static DataTable GetMoveableStatic()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MoveableStatic().WinningOverrides());
    }
    
    public static DataTable GetMovementType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MovementType().WinningOverrides());
    }
    
    public static DataTable GetMusicTrack()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MusicTrack().WinningOverrides());
    }
    
    public static DataTable GetMusicType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.MusicType().WinningOverrides());
    }
    
    public static DataTable GetNavigationMesh()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.NavigationMesh().WinningOverrides());
    }
    
    public static DataTable GetNavigationMeshInfoMap()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.NavigationMeshInfoMap().WinningOverrides());
    }
    
    public static DataTable GetNpc()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Npc().WinningOverrides());
    }
    
    public static DataTable GetObjectEffect()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ObjectEffect().WinningOverrides());
    }
    
    public static DataTable GetOutfit()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Outfit().WinningOverrides());
    }
    
    public static DataTable GetPackage()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Package().WinningOverrides());
    }
    
    public static DataTable GetPerk()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Perk().WinningOverrides());
    }
    
    public static DataTable GetPlacedNpc()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.PlacedNpc().WinningOverrides());
    }
    
    public static DataTable GetPlacedObject()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.PlacedObject().WinningOverrides());
    }
    
    public static DataTable GetProjectile()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Projectile().WinningOverrides());
    }
    
    public static DataTable GetQuest()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Quest().WinningOverrides());
    }
    
    public static DataTable GetRace()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Race().WinningOverrides());
    }
    
    public static DataTable GetRegion()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Region().WinningOverrides());
    }
    
    public static DataTable GetRelationship()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Relationship().WinningOverrides());
    }
    
    public static DataTable GetReverbParameters()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ReverbParameters().WinningOverrides());
    }
    
    public static DataTable GetScene()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Scene().WinningOverrides());
    }
    
    public static DataTable GetScroll()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Scroll().WinningOverrides());
    }
    
    public static DataTable GetShaderParticleGeometry()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.ShaderParticleGeometry().WinningOverrides());
    }
    
    public static DataTable GetShout()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Shout().WinningOverrides());
    }
    
    public static DataTable GetSkyrimMajorRecord()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SkyrimMajorRecord().WinningOverrides());
    }
    
    public static DataTable GetSoulGem()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoulGem().WinningOverrides());
    }
    
    public static DataTable GetSoundCategory()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundCategory().WinningOverrides());
    }
    
    public static DataTable GetSoundDescriptor()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundDescriptor().WinningOverrides());
    }
    
    public static DataTable GetSoundMarker()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundMarker().WinningOverrides());
    }
    
    public static DataTable GetSoundOutputModel()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.SoundOutputModel().WinningOverrides());
    }
    
    public static DataTable GetSpell()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Spell().WinningOverrides());
    }
    
    public static DataTable GetStatic()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Static().WinningOverrides());
    }
    
    public static DataTable GetTalkingActivator()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.TalkingActivator().WinningOverrides());
    }
    
    public static DataTable GetTextureSet()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.TextureSet().WinningOverrides());
    }
    
    public static DataTable GetTree()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Tree().WinningOverrides());
    }
    
    public static DataTable GetVisualEffect()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.VisualEffect().WinningOverrides());
    }
    
    public static DataTable GetVoiceType()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.VoiceType().WinningOverrides());
    }
    
    public static DataTable GetVolumetricLighting()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.VolumetricLighting().WinningOverrides());
    }
    
    public static DataTable GetWater()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Water().WinningOverrides());
    }
    
    public static DataTable GetWeather()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Weather().WinningOverrides());
    }
    
    public static DataTable GetWordOfPower()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.WordOfPower().WinningOverrides());
    }
    
    public static DataTable GetWorldSpace()
    {
        using var env = GameEnvironment.Typical.Skyrim(SkyrimRelease.SkyrimSE);
        return CreateDataTable.CreateTable(env.LoadOrder.PriorityOrder.Worldspace().WinningOverrides());
    }
}