using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000365 RID: 869
[Token(Token = "0x2000293")]
[Serializable]
public class DualSmithActorDataTable
{
	// Token: 0x060016A2 RID: 5794 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001413")]
	[Address(RVA = "0x1E062C0", Offset = "0x1E063C1", VA = "0x1E062C0")]
	private static DualSmithActorDataTable GetDataTable(ActorID id)
	{
		return null;
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0000A0B0 File Offset: 0x000082B0
	[Token(Token = "0x6001414")]
	[Address(RVA = "0x1E06400", Offset = "0x1E06501", VA = "0x1E06400")]
	public static DualSmithActorDataTable.LotteryType LotteryBonusType(ActorID subActor)
	{
		return DualSmithActorDataTable.LotteryType.Critical;
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001415")]
	[Address(RVA = "0x1E06590", Offset = "0x1E06691", VA = "0x1E06590")]
	public DualSmithActorDataTable()
	{
	}

	// Token: 0x04000EA0 RID: 3744
	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float Critical;

	// Token: 0x04000EA1 RID: 3745
	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float Stun;

	// Token: 0x04000EA2 RID: 3746
	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Attack;

	// Token: 0x04000EA3 RID: 3747
	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float Str;

	// Token: 0x04000EA4 RID: 3748
	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float Vit;

	// Token: 0x04000EA5 RID: 3749
	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float Int;

	// Token: 0x04000EA6 RID: 3750
	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public float DefFire;

	// Token: 0x04000EA7 RID: 3751
	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public float DefWater;

	// Token: 0x04000EA8 RID: 3752
	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public float DefEarth;

	// Token: 0x04000EA9 RID: 3753
	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float DefWind;

	// Token: 0x04000EAA RID: 3754
	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float DefShine;

	// Token: 0x04000EAB RID: 3755
	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public float DefDark;

	// Token: 0x04000EAC RID: 3756
	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0x0")]
	private static DualSmithActorDataTableArray _DualSmithActorDataTableArray;

	// Token: 0x02000366 RID: 870
	[Token(Token = "0x200105B")]
	public enum LotteryType
	{
		// Token: 0x04000EAE RID: 3758
		[Token(Token = "0x4018F95")]
		Critical,
		// Token: 0x04000EAF RID: 3759
		[Token(Token = "0x4018F96")]
		Stun,
		// Token: 0x04000EB0 RID: 3760
		[Token(Token = "0x4018F97")]
		Attack,
		// Token: 0x04000EB1 RID: 3761
		[Token(Token = "0x4018F98")]
		Str,
		// Token: 0x04000EB2 RID: 3762
		[Token(Token = "0x4018F99")]
		Vit,
		// Token: 0x04000EB3 RID: 3763
		[Token(Token = "0x4018F9A")]
		Int,
		// Token: 0x04000EB4 RID: 3764
		[Token(Token = "0x4018F9B")]
		DefFire,
		// Token: 0x04000EB5 RID: 3765
		[Token(Token = "0x4018F9C")]
		DefWater,
		// Token: 0x04000EB6 RID: 3766
		[Token(Token = "0x4018F9D")]
		DefEarth,
		// Token: 0x04000EB7 RID: 3767
		[Token(Token = "0x4018F9E")]
		DefWind,
		// Token: 0x04000EB8 RID: 3768
		[Token(Token = "0x4018F9F")]
		DefShine,
		// Token: 0x04000EB9 RID: 3769
		[Token(Token = "0x4018FA0")]
		DefDark
	}
}
