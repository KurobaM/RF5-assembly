using System;
using Define;
using Il2CppDummyDll;
using Loader;
using UnityEngine;

// Token: 0x020005D1 RID: 1489
[Token(Token = "0x2000431")]
public class GimmickBreakeMushroomObject : GimmickBreakeObject
{
	// Token: 0x06002481 RID: 9345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0x1FA9700", Offset = "0x1FA9801", VA = "0x1FA9700", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06002482 RID: 9346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0x1FA97D0", Offset = "0x1FA98D1", VA = "0x1FA97D0", Slot = "12")]
	protected override void Awake()
	{
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x1FA9850", Offset = "0x1FA9951", VA = "0x1FA9850", Slot = "11")]
	protected override void SetEnableCollider(bool isEnable)
	{
	}

	// Token: 0x06002484 RID: 9348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x1FA98E0", Offset = "0x1FA99E1", VA = "0x1FA98E0", Slot = "13")]
	public override void SetGimmickFlag(bool setValue)
	{
	}

	// Token: 0x06002485 RID: 9349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x1FA98F0", Offset = "0x1FA99F1", VA = "0x1FA98F0", Slot = "14")]
	public override void Breake(Vector3 hitPoint)
	{
	}

	// Token: 0x06002486 RID: 9350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x1FA9920", Offset = "0x1FA9A21", VA = "0x1FA9920")]
	private void OnBroken()
	{
	}

	// Token: 0x06002487 RID: 9351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0x1FA9A20", Offset = "0x1FA9B21", VA = "0x1FA9A20")]
	private void SpawnGimmickObject(GameObject baseObj)
	{
	}

	// Token: 0x06002488 RID: 9352 RVA: 0x0000EC40 File Offset: 0x0000CE40
	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0x1FA9C40", Offset = "0x1FA9D41", VA = "0x1FA9C40")]
	private DamageInfo SetDamageInfo()
	{
		return default(DamageInfo);
	}

	// Token: 0x06002489 RID: 9353 RVA: 0x0000EC58 File Offset: 0x0000CE58
	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x1FA9F40", Offset = "0x1FAA041", VA = "0x1FA9F40")]
	public static int LotteryWeight(int[] weight)
	{
		return 0;
	}

	// Token: 0x0600248A RID: 9354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x1FA9FD0", Offset = "0x1FAA0D1", VA = "0x1FA9FD0")]
	public GimmickBreakeMushroomObject()
	{
	}

	// Token: 0x0600248B RID: 9355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x1FA9FE0", Offset = "0x1FAA0E1", VA = "0x1FA9FE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1340", Offset = "0x1A1441")]
	private void <OnBroken>b__15_0(AssetHandle<GameObject> handle)
	{
	}

	// Token: 0x04006BEB RID: 27627
	[Token(Token = "0x400653B")]
	private const int loaderId = 16338;

	// Token: 0x04006BEC RID: 27628
	[Token(Token = "0x400653C")]
	private const int SporeDamage = 10;

	// Token: 0x04006BED RID: 27629
	[Token(Token = "0x400653D")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private int HealHp;

	// Token: 0x04006BEE RID: 27630
	[Token(Token = "0x400653E")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private BadStatus[] BadStatuses;

	// Token: 0x04006BEF RID: 27631
	[Token(Token = "0x400653F")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private int[] BadStatusesWeight;

	// Token: 0x04006BF0 RID: 27632
	[Token(Token = "0x4006540")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private int Power;

	// Token: 0x04006BF1 RID: 27633
	[Token(Token = "0x4006541")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float SporeRadius;

	// Token: 0x04006BF2 RID: 27634
	[Token(Token = "0x4006542")]
	[FieldOffset(Offset = "0xA8")]
	private DamageInfo DamageInfo;

	// Token: 0x04006BF3 RID: 27635
	[Token(Token = "0x4006543")]
	[FieldOffset(Offset = "0x128")]
	protected Collider[] Colliders;

	// Token: 0x04006BF4 RID: 27636
	[Token(Token = "0x4006544")]
	[FieldOffset(Offset = "0x130")]
	private GameObject LoadPrefab;
}
