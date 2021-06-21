using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RF5SHOP
{
	// Token: 0x02000E6B RID: 3691
	[Token(Token = "0x2000974")]
	public class SeedShopItemDataTable
	{
		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x060060F1 RID: 24817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060060F2 RID: 24818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009E8")]
		public List<SeedShopItemDataTable.SeedShopItemData> Datas
		{
			[Token(Token = "0x6005045")]
			[Address(RVA = "0x2178A00", Offset = "0x2178B01", VA = "0x2178A00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC750", Offset = "0x1AC851")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005046")]
			[Address(RVA = "0x2178A10", Offset = "0x2178B11", VA = "0x2178A10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AC760", Offset = "0x1AC861")]
			private set
			{
			}
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005047")]
		[Address(RVA = "0x2178A20", Offset = "0x2178B21", VA = "0x2178A20")]
		private List<SeedShopItemDataTable.SeedShopItemData> GetSeedShopItemDatas(NpcShopType shopType)
		{
			return null;
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005048")]
		[Address(RVA = "0x2179650", Offset = "0x2179751", VA = "0x2179650")]
		public void InitData()
		{
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005049")]
		[Address(RVA = "0x21798B0", Offset = "0x21799B1", VA = "0x21798B0")]
		public void GetCanBuySeedData(int money, out List<SeedShopItemDataTable.SeedShopItemData> list)
		{
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504A")]
		[Address(RVA = "0x21799B0", Offset = "0x2179AB1", VA = "0x21799B0")]
		public SeedShopItemDataTable()
		{
		}

		// Token: 0x0400BFEB RID: 49131
		[Token(Token = "0x4008FA4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17EAF0", Offset = "0x17EBF1")]
		private List<SeedShopItemDataTable.SeedShopItemData> <Datas>k__BackingField;

		// Token: 0x02000E6C RID: 3692
		[Token(Token = "0x2001463")]
		public class SeedShopItemData
		{
			// Token: 0x060060F7 RID: 24823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B5B")]
			[Address(RVA = "0x21795F0", Offset = "0x21796F1", VA = "0x21795F0")]
			public SeedShopItemData(ItemID id, int lv)
			{
			}

			// Token: 0x0400BFEC RID: 49132
			[Token(Token = "0x401BC53")]
			[FieldOffset(Offset = "0x10")]
			public ItemID itemID;

			// Token: 0x0400BFED RID: 49133
			[Token(Token = "0x401BC54")]
			[FieldOffset(Offset = "0x14")]
			public int itemLv;

			// Token: 0x0400BFEE RID: 49134
			[Token(Token = "0x401BC55")]
			[FieldOffset(Offset = "0x18")]
			public int shopPrice;
		}

		// Token: 0x02000E6D RID: 3693
		[Token(Token = "0x2001464")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159970", Offset = "0x159A71")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060060F9 RID: 24825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B5D")]
			[Address(RVA = "0x2179A50", Offset = "0x2179B51", VA = "0x2179A50")]
			public <>c()
			{
			}

			// Token: 0x060060FA RID: 24826 RVA: 0x00020778 File Offset: 0x0001E978
			[Token(Token = "0x6007B5E")]
			[Address(RVA = "0x2179A60", Offset = "0x2179B61", VA = "0x2179A60")]
			internal bool <InitData>b__6_0(SeedShopItemDataTable.SeedShopItemData a)
			{
				return default(bool);
			}

			// Token: 0x060060FB RID: 24827 RVA: 0x00020790 File Offset: 0x0001E990
			[Token(Token = "0x6007B5F")]
			[Address(RVA = "0x2179AA0", Offset = "0x2179BA1", VA = "0x2179AA0")]
			internal int <InitData>b__6_1(SeedShopItemDataTable.SeedShopItemData a, SeedShopItemDataTable.SeedShopItemData b)
			{
				return 0;
			}

			// Token: 0x0400BFEF RID: 49135
			[Token(Token = "0x401BC56")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SeedShopItemDataTable.<>c <>9;

			// Token: 0x0400BFF0 RID: 49136
			[Token(Token = "0x401BC57")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<SeedShopItemDataTable.SeedShopItemData> <>9__6_0;

			// Token: 0x0400BFF1 RID: 49137
			[Token(Token = "0x401BC58")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<SeedShopItemDataTable.SeedShopItemData> <>9__6_1;
		}
	}
}
