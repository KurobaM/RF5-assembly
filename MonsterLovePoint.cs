using System;
using Il2CppDummyDll;

// Token: 0x0200085A RID: 2138
[Token(Token = "0x200057F")]
[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x146610", Offset = "0x146711")]
public class MonsterLovePoint
{
	// Token: 0x060038A0 RID: 14496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002F24")]
	[Address(RVA = "0x1E65D20", Offset = "0x1E65E21", VA = "0x1E65D20")]
	public MonsterLovePoint()
	{
	}

	// Token: 0x060038A1 RID: 14497 RVA: 0x00013920 File Offset: 0x00011B20
	[Token(Token = "0x6002F25")]
	[Address(RVA = "0x1E65DF0", Offset = "0x1E65EF1", VA = "0x1E65DF0")]
	private int Add(int addPoint)
	{
		return 0;
	}

	// Token: 0x060038A2 RID: 14498 RVA: 0x00013938 File Offset: 0x00011B38
	[Token(Token = "0x6002F26")]
	[Address(RVA = "0x1E65E30", Offset = "0x1E65F31", VA = "0x1E65E30")]
	public bool IsLoveDrink(int itemID)
	{
		return default(bool);
	}

	// Token: 0x060038A3 RID: 14499 RVA: 0x00013950 File Offset: 0x00011B50
	[Token(Token = "0x6002F27")]
	[Address(RVA = "0x1E65E40", Offset = "0x1E65F41", VA = "0x1E65E40")]
	public int GetPoint()
	{
		return 0;
	}

	// Token: 0x060038A4 RID: 14500 RVA: 0x00013968 File Offset: 0x00011B68
	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x1E65E50", Offset = "0x1E65F51", VA = "0x1E65E50")]
	public int GetLoveLv()
	{
		return 0;
	}

	// Token: 0x060038A5 RID: 14501 RVA: 0x00013980 File Offset: 0x00011B80
	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x1E65FA0", Offset = "0x1E660A1", VA = "0x1E65FA0")]
	public ValueTuple<int, int> GetNowLv_PerNext()
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x00013998 File Offset: 0x00011B98
	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x1E662B0", Offset = "0x1E663B1", VA = "0x1E662B0")]
	public float GetNowLv_PerForUI()
	{
		return 0f;
	}

	// Token: 0x060038A7 RID: 14503 RVA: 0x000139B0 File Offset: 0x00011BB0
	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x1E66390", Offset = "0x1E66491", VA = "0x1E66390")]
	private int GetAddLovePoint(MonsterLovePoint.FluctuationType type)
	{
		return 0;
	}

	// Token: 0x060038A8 RID: 14504 RVA: 0x000139C8 File Offset: 0x00011BC8
	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x1E663D0", Offset = "0x1E664D1", VA = "0x1E663D0")]
	private int GetAddMonsterSkillLevel()
	{
		return 0;
	}

	// Token: 0x060038A9 RID: 14505 RVA: 0x000139E0 File Offset: 0x00011BE0
	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x1E66410", Offset = "0x1E66511", VA = "0x1E66410")]
	public int AddLovePoind(MonsterLovePoint.FluctuationType type, int AddLikePoint = 0)
	{
		return 0;
	}

	// Token: 0x04007B85 RID: 31621
	[Token(Token = "0x4006FA5")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "KeyAttribute", RVA = "0x16B770", Offset = "0x16B871")]
	public int LovePoint;

	// Token: 0x04007B86 RID: 31622
	[Token(Token = "0x4006FA6")]
	private const int POINT_MAX = 65535;

	// Token: 0x04007B87 RID: 31623
	[Token(Token = "0x4006FA7")]
	private const int LV_OVER_MAX = 1000;

	// Token: 0x04007B88 RID: 31624
	[Token(Token = "0x4006FA8")]
	private const int LV_MAX = 10;

	// Token: 0x04007B89 RID: 31625
	[Token(Token = "0x4006FA9")]
	private const int LV_10_EXP = 255;

	// Token: 0x04007B8A RID: 31626
	[Token(Token = "0x4006FAA")]
	private const int OVER_LV_EXP = 64;

	// Token: 0x04007B8B RID: 31627
	[Token(Token = "0x4006FAB")]
	private const int PRESENT_ITEM_PLUS_MAX = 5;

	// Token: 0x04007B8C RID: 31628
	[Token(Token = "0x4006FAC")]
	public const int CAN_FARMWORK_LV = 3;

	// Token: 0x04007B8D RID: 31629
	[Token(Token = "0x4006FAD")]
	public const int CAN_SOWINGSEED_LV = 8;

	// Token: 0x04007B8E RID: 31630
	[Token(Token = "0x4006FAE")]
	private const int LoveDrinkID = 2009;

	// Token: 0x04007B8F RID: 31631
	[Token(Token = "0x4006FAF")]
	[FieldOffset(Offset = "0x18")]
	private readonly int[] LovePointTable;

	// Token: 0x04007B90 RID: 31632
	[Token(Token = "0x4006FB0")]
	[FieldOffset(Offset = "0x20")]
	private readonly int[] LovePointRiseTable;

	// Token: 0x0200085B RID: 2139
	[Token(Token = "0x200125E")]
	public enum FluctuationType
	{
		// Token: 0x04007B92 RID: 31634
		[Token(Token = "0x4019846")]
		Present,
		// Token: 0x04007B93 RID: 31635
		[Token(Token = "0x4019847")]
		PresentFavorite,
		// Token: 0x04007B94 RID: 31636
		[Token(Token = "0x4019848")]
		Esa,
		// Token: 0x04007B95 RID: 31637
		[Token(Token = "0x4019849")]
		Partner,
		// Token: 0x04007B96 RID: 31638
		[Token(Token = "0x401984A")]
		Partner_Miss,
		// Token: 0x04007B97 RID: 31639
		[Token(Token = "0x401984B")]
		Brushing,
		// Token: 0x04007B98 RID: 31640
		[Token(Token = "0x401984C")]
		LoveDrink,
		// Token: 0x04007B99 RID: 31641
		[Token(Token = "0x401984D")]
		Debug1,
		// Token: 0x04007B9A RID: 31642
		[Token(Token = "0x401984E")]
		Debug10,
		// Token: 0x04007B9B RID: 31643
		[Token(Token = "0x401984F")]
		Debug100,
		// Token: 0x04007B9C RID: 31644
		[Token(Token = "0x4019850")]
		Debug1000,
		// Token: 0x04007B9D RID: 31645
		[Token(Token = "0x4019851")]
		Num
	}
}
