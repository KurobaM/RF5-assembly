using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003C1 RID: 961
[Token(Token = "0x20002E4")]
[Serializable]
public class SkillActionDataTable
{
	// Token: 0x06001773 RID: 6003 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x1DE7670", Offset = "0x1DE7771", VA = "0x1DE7670")]
	public static SkillActionDataTable GetDataTable(SkillActionID id)
	{
		return null;
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x0000A3E0 File Offset: 0x000085E0
	[Token(Token = "0x60014D8")]
	[Address(RVA = "0x1DE77B0", Offset = "0x1DE78B1", VA = "0x1DE77B0")]
	public static bool HasDataTable(SkillActionID id)
	{
		return default(bool);
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D9")]
	[Address(RVA = "0x1DE78F0", Offset = "0x1DE79F1", VA = "0x1DE78F0")]
	public SkillActionDataTable()
	{
	}

	// Token: 0x04001098 RID: 4248
	[Token(Token = "0x4000D3C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int SkillRP;

	// Token: 0x04001099 RID: 4249
	[Token(Token = "0x4000D3D")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int SkillRP_02;

	// Token: 0x0400109A RID: 4250
	[Token(Token = "0x4000D3E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int SkillRP_03;

	// Token: 0x0400109B RID: 4251
	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int SkillRP_04;

	// Token: 0x0400109C RID: 4252
	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int SkillRP_05;

	// Token: 0x0400109D RID: 4253
	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int SkillRP_06;

	// Token: 0x0400109E RID: 4254
	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int SkillRP_07;

	// Token: 0x0400109F RID: 4255
	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int SkillRP_08;

	// Token: 0x040010A0 RID: 4256
	[Token(Token = "0x4000D44")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int SkillRP_09;

	// Token: 0x040010A1 RID: 4257
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int SkillRP_10;

	// Token: 0x040010A2 RID: 4258
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int SkillRpRate;

	// Token: 0x040010A3 RID: 4259
	[Token(Token = "0x4000D47")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int SkillRpRate_02;

	// Token: 0x040010A4 RID: 4260
	[Token(Token = "0x4000D48")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int SkillRpRate_03;

	// Token: 0x040010A5 RID: 4261
	[Token(Token = "0x4000D49")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public int SkillRpRate_04;

	// Token: 0x040010A6 RID: 4262
	[Token(Token = "0x4000D4A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int SkillRpRate_05;

	// Token: 0x040010A7 RID: 4263
	[Token(Token = "0x4000D4B")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int SkillRpRate_06;

	// Token: 0x040010A8 RID: 4264
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public int SkillRpRate_07;

	// Token: 0x040010A9 RID: 4265
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public int SkillRpRate_08;

	// Token: 0x040010AA RID: 4266
	[Token(Token = "0x4000D4E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public int SkillRpRate_09;

	// Token: 0x040010AB RID: 4267
	[Token(Token = "0x4000D4F")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public int SkillRpRate_10;

	// Token: 0x040010AC RID: 4268
	[Token(Token = "0x4000D50")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int NeedSkillLevel;

	// Token: 0x040010AD RID: 4269
	[Token(Token = "0x4000D51")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public ItemCategory[] WeaponCategoryArray;

	// Token: 0x040010AE RID: 4270
	[Token(Token = "0x4000D52")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public SkillID TargetSkill1;

	// Token: 0x040010AF RID: 4271
	[Token(Token = "0x4000D53")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public int SkillExp1;

	// Token: 0x040010B0 RID: 4272
	[Token(Token = "0x4000D54")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public SkillID TargetSkill2;

	// Token: 0x040010B1 RID: 4273
	[Token(Token = "0x4000D55")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public int SkillExp2;

	// Token: 0x040010B2 RID: 4274
	[Token(Token = "0x4000D56")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public SkillID TargetSkill3;

	// Token: 0x040010B3 RID: 4275
	[Token(Token = "0x4000D57")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public int SkillExp3;

	// Token: 0x040010B4 RID: 4276
	[Token(Token = "0x4000D58")]
	[FieldOffset(Offset = "0x0")]
	private static SkillActionDataTableArray _SkillActionDataTableArray;
}
