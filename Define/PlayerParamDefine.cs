using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x0200126D RID: 4717
	[Token(Token = "0x2000C3C")]
	public static class PlayerParamDefine
	{
		// Token: 0x0401A50E RID: 107790
		[Token(Token = "0x4016F51")]
		public const int PlayerGoldMax = 2000000000;

		// Token: 0x0401A50F RID: 107791
		[Token(Token = "0x4016F52")]
		public const int PlayerGoldMin = 0;

		// Token: 0x0401A510 RID: 107792
		[Token(Token = "0x4016F53")]
		public const int PlayerSeedPointMax = 2000000000;

		// Token: 0x0401A511 RID: 107793
		[Token(Token = "0x4016F54")]
		public const int PlayerSeedPointMin = 0;

		// Token: 0x0401A512 RID: 107794
		[Token(Token = "0x4016F55")]
		public const int StoneMax = 50000;

		// Token: 0x0401A513 RID: 107795
		[Token(Token = "0x4016F56")]
		public const int StoneMin = 0;

		// Token: 0x0401A514 RID: 107796
		[Token(Token = "0x4016F57")]
		public const int LumberMax = 50000;

		// Token: 0x0401A515 RID: 107797
		[Token(Token = "0x4016F58")]
		public const int LumberMin = 0;

		// Token: 0x0401A516 RID: 107798
		[Token(Token = "0x4016F59")]
		public const int CompostMax = 50000;

		// Token: 0x0401A517 RID: 107799
		[Token(Token = "0x4016F5A")]
		public const int CompostMin = 0;

		// Token: 0x0401A518 RID: 107800
		[Token(Token = "0x4016F5B")]
		public const int EsaMax = 50000;

		// Token: 0x0401A519 RID: 107801
		[Token(Token = "0x4016F5C")]
		public const int EsaMin = 0;

		// Token: 0x0401A51A RID: 107802
		[Token(Token = "0x4016F5D")]
		public const float ContinueDay_Tier = 0.5f;

		// Token: 0x0401A51B RID: 107803
		[Token(Token = "0x4016F5E")]
		public const float ContinueDay_Sick = 0.25f;

		// Token: 0x0401A51C RID: 107804
		[Token(Token = "0x4016F5F")]
		public const int RecipeLowCapLevel = 80;

		// Token: 0x0401A51D RID: 107805
		[Token(Token = "0x4016F60")]
		public const int RecipeHighCapLevel = 100;

		// Token: 0x0401A51E RID: 107806
		[Token(Token = "0x4016F61")]
		public const int SynthesisRPMin = 10;

		// Token: 0x0401A51F RID: 107807
		[Token(Token = "0x4016F62")]
		public const int SynthesisRPMax = 99999;

		// Token: 0x0401A520 RID: 107808
		[Token(Token = "0x4016F63")]
		public const int BaseLevelMax = 150;

		// Token: 0x0401A521 RID: 107809
		[Token(Token = "0x4016F64")]
		public const int SozaiLevelMax = 200;

		// Token: 0x0401A522 RID: 107810
		[Token(Token = "0x4016F65")]
		public const int BaseSkillExp_Craft = 30;

		// Token: 0x0401A523 RID: 107811
		[Token(Token = "0x4016F66")]
		public const int SkillExp_AmountItem = 5;

		// Token: 0x0401A524 RID: 107812
		[Token(Token = "0x4016F67")]
		[FieldOffset(Offset = "0x0")]
		public static int FireExp_SuccessSynthesis;

		// Token: 0x0401A525 RID: 107813
		[Token(Token = "0x4016F68")]
		[FieldOffset(Offset = "0x4")]
		public static int FailureExpMax_Synthesis;

		// Token: 0x0401A526 RID: 107814
		[Token(Token = "0x4016F69")]
		[FieldOffset(Offset = "0x8")]
		public static int ExpMin_Synthesis;

		// Token: 0x0401A527 RID: 107815
		[Token(Token = "0x4016F6A")]
		public const int NoDropCap_Dummy = 9000;

		// Token: 0x0401A528 RID: 107816
		[Token(Token = "0x4016F6B")]
		[FieldOffset(Offset = "0x10")]
		public static ItemID[] IgnoreCapItems;

		// Token: 0x0401A529 RID: 107817
		[Token(Token = "0x4016F6C")]
		[FieldOffset(Offset = "0x18")]
		public static ItemID[] IgnoreCapSkillMagic;

		// Token: 0x0401A52A RID: 107818
		[Token(Token = "0x4016F6D")]
		[FieldOffset(Offset = "0x20")]
		public static int CategoryLotteryCount;

		// Token: 0x0401A52B RID: 107819
		[Token(Token = "0x4016F6E")]
		[FieldOffset(Offset = "0x24")]
		public static int TreasureOverCapLimit;

		// Token: 0x0401A52C RID: 107820
		[Token(Token = "0x4016F6F")]
		[FieldOffset(Offset = "0x28")]
		public static int TresureOver_AddLottery_Base;

		// Token: 0x0401A52D RID: 107821
		[Token(Token = "0x4016F70")]
		[FieldOffset(Offset = "0x2C")]
		public static int TresureOver_AddLottery;

		// Token: 0x0401A52E RID: 107822
		[Token(Token = "0x4016F71")]
		public const int GoldCapByRank_0 = 400;

		// Token: 0x0401A52F RID: 107823
		[Token(Token = "0x4016F72")]
		public const int GoldCapByRank_1 = 800;

		// Token: 0x0401A530 RID: 107824
		[Token(Token = "0x4016F73")]
		public const int GoldCapByRank_2 = 1500;

		// Token: 0x0401A531 RID: 107825
		[Token(Token = "0x4016F74")]
		public const int GoldCapByRank_3 = 3000;

		// Token: 0x0401A532 RID: 107826
		[Token(Token = "0x4016F75")]
		public const int GoldCapByRank_4 = 8000;

		// Token: 0x0401A533 RID: 107827
		[Token(Token = "0x4016F76")]
		public const int GoldCapByRank_5 = 15000;

		// Token: 0x0401A534 RID: 107828
		[Token(Token = "0x4016F77")]
		public const int NeedTradeFragmentNum = 5;

		// Token: 0x0401A535 RID: 107829
		[Token(Token = "0x4016F78")]
		public const int MaxCrystal = 9999;
	}
}
