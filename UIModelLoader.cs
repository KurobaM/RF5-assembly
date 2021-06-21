using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B21 RID: 2849
[Token(Token = "0x200076D")]
public class UIModelLoader : MonoBehaviour
{
	// Token: 0x170009BD RID: 2493
	// (get) Token: 0x060049A4 RID: 18852 RVA: 0x00017BC8 File Offset: 0x00015DC8
	// (set) Token: 0x060049A5 RID: 18853 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007BF")]
	public UIModelLoader.POINT NowPoint
	{
		[Token(Token = "0x6003D96")]
		[Address(RVA = "0x2026F20", Offset = "0x2027021", VA = "0x2026F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8A00", Offset = "0x1A8B01")]
		get
		{
			return UIModelLoader.POINT.None;
		}
		[Token(Token = "0x6003D97")]
		[Address(RVA = "0x2026F30", Offset = "0x2027031", VA = "0x2026F30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8A10", Offset = "0x1A8B11")]
		private set
		{
		}
	}

	// Token: 0x170009BE RID: 2494
	// (get) Token: 0x060049A6 RID: 18854 RVA: 0x00017BE0 File Offset: 0x00015DE0
	// (set) Token: 0x060049A7 RID: 18855 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007C0")]
	public bool IsActive
	{
		[Token(Token = "0x6003D98")]
		[Address(RVA = "0x2026F40", Offset = "0x2027041", VA = "0x2026F40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8A20", Offset = "0x1A8B21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003D99")]
		[Address(RVA = "0x2026F50", Offset = "0x2027051", VA = "0x2026F50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8A30", Offset = "0x1A8B31")]
		private set
		{
		}
	}

	// Token: 0x060049A8 RID: 18856 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D9A")]
	[Address(RVA = "0x2026F60", Offset = "0x2027061", VA = "0x2026F60")]
	public void ChangePoint(UIModelLoader.POINT nextPoint, ActorID _actorID = ActorID.None)
	{
	}

	// Token: 0x060049A9 RID: 18857 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D9B")]
	[Address(RVA = "0x2027300", Offset = "0x2027401", VA = "0x2027300")]
	public void Open(ActorID actor_id, bool isViewer = false)
	{
	}

	// Token: 0x060049AA RID: 18858 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D9C")]
	[Address(RVA = "0x2027510", Offset = "0x2027611", VA = "0x2027510")]
	private void DoOpenMonster(MonsterDataID id, GameObject _MonsterObject)
	{
	}

	// Token: 0x060049AB RID: 18859 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D9D")]
	[Address(RVA = "0x2027380", Offset = "0x2027481", VA = "0x2027380")]
	private void EndMonster()
	{
	}

	// Token: 0x060049AC RID: 18860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D9E")]
	[Address(RVA = "0x2027750", Offset = "0x2027851", VA = "0x2027750")]
	public void Open(MonsterDataID monsterDataID, bool isViewer = false)
	{
	}

	// Token: 0x060049AD RID: 18861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D9F")]
	[Address(RVA = "0x2027860", Offset = "0x2027961", VA = "0x2027860")]
	public void Close()
	{
	}

	// Token: 0x060049AE RID: 18862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA0")]
	[Address(RVA = "0x20278A0", Offset = "0x20279A1", VA = "0x20278A0")]
	private void InitActorCache()
	{
	}

	// Token: 0x060049AF RID: 18863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA1")]
	[Address(RVA = "0x20278B0", Offset = "0x20279B1", VA = "0x20278B0")]
	private void SetupActor()
	{
	}

	// Token: 0x060049B0 RID: 18864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA2")]
	[Address(RVA = "0x20278C0", Offset = "0x20279C1", VA = "0x20278C0")]
	private void TakeoverActor(Actor actor)
	{
	}

	// Token: 0x060049B1 RID: 18865 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA3")]
	[Address(RVA = "0x2027460", Offset = "0x2027561", VA = "0x2027460")]
	private void ReturnActor()
	{
	}

	// Token: 0x060049B2 RID: 18866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA4")]
	[Address(RVA = "0x2027A20", Offset = "0x2027B21", VA = "0x2027A20")]
	public void ResetEquip(EquipSlotType equipSlotType = EquipSlotType.Max)
	{
	}

	// Token: 0x060049B3 RID: 18867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA5")]
	[Address(RVA = "0x2027B50", Offset = "0x2027C51", VA = "0x2027B50")]
	private void Update()
	{
	}

	// Token: 0x060049B4 RID: 18868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DA6")]
	[Address(RVA = "0x2027BA0", Offset = "0x2027CA1", VA = "0x2027BA0")]
	public UIModelLoader()
	{
	}

	// Token: 0x0400A976 RID: 43382
	[Token(Token = "0x4007FAB")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform[] PointObjects;

	// Token: 0x0400A977 RID: 43383
	[Token(Token = "0x4007FAC")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174680", Offset = "0x174781")]
	private UIModelLoader.POINT <NowPoint>k__BackingField;

	// Token: 0x0400A978 RID: 43384
	[Token(Token = "0x4007FAD")]
	[FieldOffset(Offset = "0x24")]
	private ActorID actorId;

	// Token: 0x0400A979 RID: 43385
	[Token(Token = "0x4007FAE")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x174690", Offset = "0x174791")]
	private bool <IsActive>k__BackingField;

	// Token: 0x0400A97A RID: 43386
	[Token(Token = "0x4007FAF")]
	[FieldOffset(Offset = "0x2C")]
	private MonsterDataID usingMonsterDataId;

	// Token: 0x0400A97B RID: 43387
	[Token(Token = "0x4007FB0")]
	[FieldOffset(Offset = "0x30")]
	private GameObject MonsterObject;

	// Token: 0x0400A97C RID: 43388
	[Token(Token = "0x4007FB1")]
	[FieldOffset(Offset = "0x38")]
	private ModelScaleDataTable ModelScaleDataTable;

	// Token: 0x02000B22 RID: 2850
	[Token(Token = "0x2001336")]
	public enum POINT
	{
		// Token: 0x0400A97E RID: 43390
		[Token(Token = "0x401B62F")]
		None,
		// Token: 0x0400A97F RID: 43391
		[Token(Token = "0x401B630")]
		Player,
		// Token: 0x0400A980 RID: 43392
		[Token(Token = "0x401B631")]
		Npc,
		// Token: 0x0400A981 RID: 43393
		[Token(Token = "0x401B632")]
		Monster,
		// Token: 0x0400A982 RID: 43394
		[Token(Token = "0x401B633")]
		PlayerViewer,
		// Token: 0x0400A983 RID: 43395
		[Token(Token = "0x401B634")]
		NpcViewer,
		// Token: 0x0400A984 RID: 43396
		[Token(Token = "0x401B635")]
		MonsterViewer,
		// Token: 0x0400A985 RID: 43397
		[Token(Token = "0x401B636")]
		Max
	}
}
