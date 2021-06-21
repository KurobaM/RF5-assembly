using System;
using Il2CppDummyDll;

namespace RF5SHOP
{
	// Token: 0x02000E63 RID: 3683
	[Token(Token = "0x200096E")]
	public class ShopRandom
	{
		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x00020628 File Offset: 0x0001E828
		// (set) Token: 0x060060CE RID: 24782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E5")]
		public static uint FixShopRandSeed
		{
			[Token(Token = "0x6005025")]
			[Address(RVA = "0x217B2C0", Offset = "0x217B3C1", VA = "0x217B2C0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6005026")]
			[Address(RVA = "0x217B2F0", Offset = "0x217B3F1", VA = "0x217B2F0")]
			set
			{
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x060060CF RID: 24783 RVA: 0x00020640 File Offset: 0x0001E840
		// (set) Token: 0x060060D0 RID: 24784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E6")]
		public static uint NowShopRandSeed
		{
			[Token(Token = "0x6005027")]
			[Address(RVA = "0x217B320", Offset = "0x217B421", VA = "0x217B320")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6005028")]
			[Address(RVA = "0x217B350", Offset = "0x217B451", VA = "0x217B350")]
			set
			{
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x00020658 File Offset: 0x0001E858
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E7")]
		public static int LastOpenDay
		{
			[Token(Token = "0x6005029")]
			[Address(RVA = "0x217B380", Offset = "0x217B481", VA = "0x217B380")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600502A")]
			[Address(RVA = "0x217B3B0", Offset = "0x217B4B1", VA = "0x217B3B0")]
			set
			{
			}
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502B")]
		[Address(RVA = "0x217B3E0", Offset = "0x217B4E1", VA = "0x217B3E0")]
		public static void LoadGame()
		{
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502C")]
		[Address(RVA = "0x217B450", Offset = "0x217B551", VA = "0x217B450")]
		public static void InitGame()
		{
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502D")]
		[Address(RVA = "0x217B5F0", Offset = "0x217B6F1", VA = "0x217B5F0")]
		private static void CheckRenewalRandSeed(int _randSeed)
		{
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502E")]
		[Address(RVA = "0x217B770", Offset = "0x217B871", VA = "0x217B770")]
		public static void ResetSeed(int startCount)
		{
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600502F")]
		[Address(RVA = "0x217B580", Offset = "0x217B681", VA = "0x217B580")]
		public static void rf4Interface4Menu_SetRandomizeSeed4ShopSetting(uint randomizeSeed)
		{
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005030")]
		[Address(RVA = "0x217B890", Offset = "0x217B991", VA = "0x217B890")]
		public static void rf4Interface4Menu_GetRandom4ShopTakeRand()
		{
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x00020670 File Offset: 0x0001E870
		[Token(Token = "0x6005031")]
		[Address(RVA = "0x217A190", Offset = "0x217A291", VA = "0x217A190")]
		public static uint rf4Interface4Menu_GetRandom4ShopSetting(uint limit)
		{
			return 0U;
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005032")]
		[Address(RVA = "0x217B920", Offset = "0x217BA21", VA = "0x217B920")]
		public ShopRandom()
		{
		}

		// Token: 0x0400BFD3 RID: 49107
		[Token(Token = "0x4008F8E")]
		[FieldOffset(Offset = "0x0")]
		private static ulong shop_random_work;
	}
}
