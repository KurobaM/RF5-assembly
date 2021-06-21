using System;
using Il2CppDummyDll;

// Token: 0x020001C1 RID: 449
[Token(Token = "0x2000161")]
[Serializable]
public class CharacterAnimationParam
{
	// Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081E")]
	[Address(RVA = "0x1E8CFF0", Offset = "0x1E8D0F1", VA = "0x1E8CFF0")]
	public void Init()
	{
	}

	// Token: 0x0600096C RID: 2412 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600081F")]
	[Address(RVA = "0x1E8CF50", Offset = "0x1E8D051", VA = "0x1E8CF50")]
	public CharacterAnimationParam()
	{
	}

	// Token: 0x040005D3 RID: 1491
	[Token(Token = "0x4000480")]
	[FieldOffset(Offset = "0x10")]
	public bool enableMove;

	// Token: 0x040005D4 RID: 1492
	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x11")]
	public bool enableRotate;

	// Token: 0x040005D5 RID: 1493
	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x12")]
	public bool enableAvoid;

	// Token: 0x040005D6 RID: 1494
	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x13")]
	public bool enableAttack;

	// Token: 0x040005D7 RID: 1495
	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x14")]
	public bool enableHandCuffs;

	// Token: 0x040005D8 RID: 1496
	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x15")]
	public bool enableHandCuffsThrow;

	// Token: 0x040005D9 RID: 1497
	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x16")]
	public bool enableRuneAbility;

	// Token: 0x040005DA RID: 1498
	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x17")]
	public bool enableRunStart;

	// Token: 0x040005DB RID: 1499
	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x18")]
	public bool enableBraking;

	// Token: 0x040005DC RID: 1500
	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x19")]
	public bool enableDamage;

	// Token: 0x040005DD RID: 1501
	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x1A")]
	public bool enableItemUse;

	// Token: 0x040005DE RID: 1502
	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x1B")]
	public bool enableItemHold;

	// Token: 0x040005DF RID: 1503
	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x1C")]
	public bool enableWeaponChange;

	// Token: 0x040005E0 RID: 1504
	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x1D")]
	public bool enableSuperArmor;

	// Token: 0x040005E1 RID: 1505
	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x1E")]
	public bool enableSpeedLimit;

	// Token: 0x040005E2 RID: 1506
	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x1F")]
	public bool enableItemVisible;

	// Token: 0x040005E3 RID: 1507
	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x20")]
	public bool enableWeaponVisible;

	// Token: 0x040005E4 RID: 1508
	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0x21")]
	public bool enableShieldVisible;

	// Token: 0x040005E5 RID: 1509
	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x22")]
	public bool enableInteraction;

	// Token: 0x040005E6 RID: 1510
	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x23")]
	public bool enableGravity;

	// Token: 0x040005E7 RID: 1511
	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x24")]
	public bool enableNavMesh;

	// Token: 0x040005E8 RID: 1512
	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x25")]
	public bool enableYawn;

	// Token: 0x040005E9 RID: 1513
	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0x26")]
	public bool enableDualSkill;

	// Token: 0x040005EA RID: 1514
	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x28")]
	public float moveSpeedRate;

	// Token: 0x040005EB RID: 1515
	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x2C")]
	public float moveAccelRate;

	// Token: 0x040005EC RID: 1516
	[Token(Token = "0x4000499")]
	[FieldOffset(Offset = "0x30")]
	public float moveDecelRate;

	// Token: 0x040005ED RID: 1517
	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x34")]
	public float rotateSpeedRate;

	// Token: 0x040005EE RID: 1518
	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CC00", Offset = "0x15CD01")]
	public float weightLookIK;

	// Token: 0x040005EF RID: 1519
	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x3C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CC20", Offset = "0x15CD21")]
	public float weightGrounderIK;

	// Token: 0x040005F0 RID: 1520
	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "RangeAttribute", RVA = "0x15CC40", Offset = "0x15CD41")]
	public float weightItemLayer;

	// Token: 0x040005F1 RID: 1521
	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x44")]
	public float cameraTargetLerpSpeedXZ;

	// Token: 0x040005F2 RID: 1522
	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x48")]
	public float cameraTargetLerpSpeedY;

	// Token: 0x040005F3 RID: 1523
	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x4C")]
	public bool disableOpenMenu;
}
