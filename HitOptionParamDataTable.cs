using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000378 RID: 888
[Token(Token = "0x20002A3")]
[Serializable]
public class HitOptionParamDataTable
{
	// Token: 0x060016CE RID: 5838 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143E")]
	[Address(RVA = "0x24F6BE0", Offset = "0x24F6CE1", VA = "0x24F6BE0")]
	public static HitOptionParamDataTable GetDataTable(HitOptionParamID id)
	{
		return null;
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143F")]
	[Address(RVA = "0x24F6D30", Offset = "0x24F6E31", VA = "0x24F6D30")]
	public HitOptionParamDataTable()
	{
	}

	// Token: 0x04000F31 RID: 3889
	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public HitOptionParamDataTable.LevelData DamageRate;

	// Token: 0x04000F32 RID: 3890
	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public HitOptionParamDataTable.LevelData BlowAwayRate;

	// Token: 0x04000F33 RID: 3891
	[Token(Token = "0x4000BF5")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public HitOptionParamDataTable.LevelData BlowPowerRate;

	// Token: 0x04000F34 RID: 3892
	[Token(Token = "0x4000BF6")]
	[FieldOffset(Offset = "0x88")]
	public HitOptionParamDataTable.LevelData AttackPoison;

	// Token: 0x04000F35 RID: 3893
	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0xB0")]
	public HitOptionParamDataTable.LevelData AttackParalysis;

	// Token: 0x04000F36 RID: 3894
	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0xD8")]
	public HitOptionParamDataTable.LevelData AttackSleep;

	// Token: 0x04000F37 RID: 3895
	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x100")]
	public HitOptionParamDataTable.LevelData AttackTire;

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x128")]
	public HitOptionParamDataTable.LevelData AttackSick;

	// Token: 0x04000F39 RID: 3897
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x150")]
	public HitOptionParamDataTable.LevelData AttackDeath;

	// Token: 0x04000F3A RID: 3898
	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x178")]
	public HitOptionParamDataTable.LevelData AttackHpDrain;

	// Token: 0x04000F3B RID: 3899
	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x1A0")]
	public HitOptionParamDataTable.LevelData AttackSeal;

	// Token: 0x04000F3C RID: 3900
	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	public TimeScaleID TimeScaleID;

	// Token: 0x04000F3D RID: 3901
	[Token(Token = "0x4000BFF")]
	[FieldOffset(Offset = "0x1CC")]
	[SerializeField]
	public float KnockBackRate;

	// Token: 0x04000F3E RID: 3902
	[Token(Token = "0x4000C00")]
	[FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	public HitType HitType;

	// Token: 0x04000F3F RID: 3903
	[Token(Token = "0x4000C01")]
	[FieldOffset(Offset = "0x0")]
	private static HitOptionParamDataTableArray _HitOptionParamDataTableArray;

	// Token: 0x02000379 RID: 889
	[Token(Token = "0x200105E")]
	[Serializable]
	public struct LevelData
	{
		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4018FB1")]
		[FieldOffset(Offset = "0x0")]
		public float Lv1;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4018FB2")]
		[FieldOffset(Offset = "0x4")]
		public float Lv2;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4018FB3")]
		[FieldOffset(Offset = "0x8")]
		public float Lv3;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4018FB4")]
		[FieldOffset(Offset = "0xC")]
		public float Lv4;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4018FB5")]
		[FieldOffset(Offset = "0x10")]
		public float Lv5;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4018FB6")]
		[FieldOffset(Offset = "0x14")]
		public float Lv6;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4018FB7")]
		[FieldOffset(Offset = "0x18")]
		public float Lv7;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4018FB8")]
		[FieldOffset(Offset = "0x1C")]
		public float Lv8;

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4018FB9")]
		[FieldOffset(Offset = "0x20")]
		public float Lv9;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4018FBA")]
		[FieldOffset(Offset = "0x24")]
		public float Lv10;
	}
}
