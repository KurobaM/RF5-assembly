using System;
using Define;
using Il2CppDummyDll;
using SaveData;
using UnityEngine.Events;

namespace DualWork
{
	// Token: 0x020010BE RID: 4286
	[Token(Token = "0x2000AC0")]
	public static class DualWorkManager
	{
		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x00025668 File Offset: 0x00023868
		// (set) Token: 0x06006CBA RID: 27834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD0")]
		public static DualWorkType WorkType
		{
			[Token(Token = "0x6005A2F")]
			[Address(RVA = "0x1E06DF0", Offset = "0x1E06EF1", VA = "0x1E06DF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE480", Offset = "0x1AE581")]
			get
			{
				return DualWorkType.BlackSmith;
			}
			[Token(Token = "0x6005A30")]
			[Address(RVA = "0x1E06E60", Offset = "0x1E06F61", VA = "0x1E06E60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE490", Offset = "0x1AE591")]
			set
			{
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06006CBB RID: 27835 RVA: 0x00025680 File Offset: 0x00023880
		// (set) Token: 0x06006CBC RID: 27836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD1")]
		public static ActorID SubActor
		{
			[Token(Token = "0x6005A31")]
			[Address(RVA = "0x1E06ED0", Offset = "0x1E06FD1", VA = "0x1E06ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE4A0", Offset = "0x1AE5A1")]
			get
			{
				return ActorID.act000;
			}
			[Token(Token = "0x6005A32")]
			[Address(RVA = "0x1E06F40", Offset = "0x1E07041", VA = "0x1E06F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE4B0", Offset = "0x1AE5B1")]
			set
			{
			}
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06006CBD RID: 27837 RVA: 0x00025698 File Offset: 0x00023898
		// (set) Token: 0x06006CBE RID: 27838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD2")]
		public static int LoveLevel
		{
			[Token(Token = "0x6005A33")]
			[Address(RVA = "0x1E06FB0", Offset = "0x1E070B1", VA = "0x1E06FB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE4C0", Offset = "0x1AE5C1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005A34")]
			[Address(RVA = "0x1E07020", Offset = "0x1E07121", VA = "0x1E07020")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE4D0", Offset = "0x1AE5D1")]
			set
			{
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CC0 RID: 27840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD3")]
		public static ItemData[] DualworkTmp
		{
			[Token(Token = "0x6005A35")]
			[Address(RVA = "0x1E07090", Offset = "0x1E07191", VA = "0x1E07090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE4E0", Offset = "0x1AE5E1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A36")]
			[Address(RVA = "0x1E07100", Offset = "0x1E07201", VA = "0x1E07100")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE4F0", Offset = "0x1AE5F1")]
			set
			{
			}
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06006CC1 RID: 27841 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CC2 RID: 27842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD4")]
		private static DualWorkObject DualWorkObject
		{
			[Token(Token = "0x6005A37")]
			[Address(RVA = "0x1E07170", Offset = "0x1E07271", VA = "0x1E07170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE500", Offset = "0x1AE601")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A38")]
			[Address(RVA = "0x1E071E0", Offset = "0x1E072E1", VA = "0x1E071E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE510", Offset = "0x1AE611")]
			set
			{
			}
		}

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x06006CC3 RID: 27843 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006CC4 RID: 27844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AD5")]
		private static UnityAction<bool> EndCallBack
		{
			[Token(Token = "0x6005A39")]
			[Address(RVA = "0x1E07250", Offset = "0x1E07351", VA = "0x1E07250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE520", Offset = "0x1AE621")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005A3A")]
			[Address(RVA = "0x1E072C0", Offset = "0x1E073C1", VA = "0x1E072C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE530", Offset = "0x1AE631")]
			set
			{
			}
		}

		// Token: 0x06006CC5 RID: 27845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x1E07330", Offset = "0x1E07431", VA = "0x1E07330")]
		public static void StartDualWork(DualWorkObject dualWorkObject, ActorID subActor, int loveLevel, UnityAction<bool> endCallBack)
		{
		}

		// Token: 0x06006CC6 RID: 27846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x1E07D90", Offset = "0x1E07E91", VA = "0x1E07D90")]
		private static void CloseUICraft()
		{
		}

		// Token: 0x06006CC7 RID: 27847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x1E08070", Offset = "0x1E08171", VA = "0x1E08070")]
		private static void OnEndMiniGame(bool isSuccess)
		{
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x1E06680", Offset = "0x1E06781", VA = "0x1E06680")]
		public static string GetDualWorkTypeScreenName(DualWorkType type)
		{
			return null;
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x1E087E0", Offset = "0x1E088E1", VA = "0x1E087E0")]
		public static string GetDualWorkTypeForScript(DualWorkType type)
		{
			return null;
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x000256B0 File Offset: 0x000238B0
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0x1E08850", Offset = "0x1E08951", VA = "0x1E08850")]
		public static RF5SaveData.FLAG GetDualworkDoneFlagID(DualWorkType type)
		{
			return RF5SaveData.FLAG.IsGameCleared;
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A41")]
		[Address(RVA = "0x1E08870", Offset = "0x1E08971", VA = "0x1E08870")]
		public static string GetCurrentDualWorkName()
		{
			return null;
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A42")]
		[Address(RVA = "0x1E08750", Offset = "0x1E08851", VA = "0x1E08750")]
		public static void DoneDualWork(DualWorkType type)
		{
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A43")]
		[Address(RVA = "0x1E08A30", Offset = "0x1E08B31", VA = "0x1E08A30")]
		public static void DoneDualWork()
		{
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x000256C8 File Offset: 0x000238C8
		[Token(Token = "0x6005A44")]
		[Address(RVA = "0x1E08B00", Offset = "0x1E08C01", VA = "0x1E08B00")]
		public static bool IsDoneDualWork(DualWorkType currentDualTypeWork)
		{
			return default(bool);
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A45")]
		[Address(RVA = "0x1E08B90", Offset = "0x1E08C91", VA = "0x1E08B90")]
		public static void ApplySmith(ItemData itemData)
		{
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x000256E0 File Offset: 0x000238E0
		[Token(Token = "0x6005A46")]
		[Address(RVA = "0x1E08E80", Offset = "0x1E08F81", VA = "0x1E08E80")]
		public static int GetMaxLoveLevel()
		{
			return 0;
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x000256F8 File Offset: 0x000238F8
		[Token(Token = "0x6005A47")]
		[Address(RVA = "0x1E09180", Offset = "0x1E09281", VA = "0x1E09180")]
		private static ActorID CalcLottery()
		{
			return ActorID.act000;
		}

		// Token: 0x06006CD2 RID: 27858 RVA: 0x00025710 File Offset: 0x00023910
		[Token(Token = "0x6005A48")]
		[Address(RVA = "0x1E097C0", Offset = "0x1E098C1", VA = "0x1E097C0")]
		public static int DoLotteryNPC(DualWorkType workType)
		{
			return 0;
		}

		// Token: 0x040174D2 RID: 95442
		[Token(Token = "0x4013FDE")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180F90", Offset = "0x181091")]
		private static DualWorkType <WorkType>k__BackingField;

		// Token: 0x040174D3 RID: 95443
		[Token(Token = "0x4013FDF")]
		[FieldOffset(Offset = "0x4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FA0", Offset = "0x1810A1")]
		private static ActorID <SubActor>k__BackingField;

		// Token: 0x040174D4 RID: 95444
		[Token(Token = "0x4013FE0")]
		[FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FB0", Offset = "0x1810B1")]
		private static int <LoveLevel>k__BackingField;

		// Token: 0x040174D5 RID: 95445
		[Token(Token = "0x4013FE1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FC0", Offset = "0x1810C1")]
		private static ItemData[] <DualworkTmp>k__BackingField;

		// Token: 0x040174D6 RID: 95446
		[Token(Token = "0x4013FE2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FD0", Offset = "0x1810D1")]
		private static DualWorkObject <DualWorkObject>k__BackingField;

		// Token: 0x040174D7 RID: 95447
		[Token(Token = "0x4013FE3")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x180FE0", Offset = "0x1810E1")]
		private static UnityAction<bool> <EndCallBack>k__BackingField;

		// Token: 0x040174D8 RID: 95448
		[Token(Token = "0x4013FE4")]
		[FieldOffset(Offset = "0x28")]
		public static DualWorkManager.CraftInfoData CraftInfo;

		// Token: 0x040174D9 RID: 95449
		[Token(Token = "0x4013FE5")]
		[FieldOffset(Offset = "0x40")]
		private static readonly ActorID[] LotteryBase;

		// Token: 0x020010BF RID: 4287
		[Token(Token = "0x200156A")]
		public struct CraftInfoData
		{
			// Token: 0x040174DA RID: 95450
			[Token(Token = "0x401C100")]
			[FieldOffset(Offset = "0x0")]
			public CraftCategoryId craftCategoryId;

			// Token: 0x040174DB RID: 95451
			[Token(Token = "0x401C101")]
			[FieldOffset(Offset = "0x4")]
			public RecipeId recipeId;

			// Token: 0x040174DC RID: 95452
			[Token(Token = "0x401C102")]
			[FieldOffset(Offset = "0x8")]
			public ItemData[] materialItemData;

			// Token: 0x040174DD RID: 95453
			[Token(Token = "0x401C103")]
			[FieldOffset(Offset = "0x10")]
			public int craftNum;
		}

		// Token: 0x020010C0 RID: 4288
		[Token(Token = "0x200156B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A050", Offset = "0x15A151")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006CD5 RID: 27861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D3A")]
			[Address(RVA = "0x1E09D40", Offset = "0x1E09E41", VA = "0x1E09D40")]
			public <>c()
			{
			}

			// Token: 0x06006CD6 RID: 27862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D3B")]
			[Address(RVA = "0x1E09D50", Offset = "0x1E09E51", VA = "0x1E09D50")]
			internal void <StartDualWork>b__26_0()
			{
			}

			// Token: 0x06006CD7 RID: 27863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D3C")]
			[Address(RVA = "0x1E09DC0", Offset = "0x1E09EC1", VA = "0x1E09DC0")]
			internal void <StartDualWork>b__26_1()
			{
			}

			// Token: 0x040174DE RID: 95454
			[Token(Token = "0x401C104")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DualWorkManager.<>c <>9;

			// Token: 0x040174DF RID: 95455
			[Token(Token = "0x401C105")]
			[FieldOffset(Offset = "0x8")]
			public static UnityAction <>9__26_0;

			// Token: 0x040174E0 RID: 95456
			[Token(Token = "0x401C106")]
			[FieldOffset(Offset = "0x10")]
			public static UnityAction <>9__26_1;
		}
	}
}
