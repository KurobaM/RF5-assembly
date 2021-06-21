using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

namespace RF5SHOP
{
	// Token: 0x02000E64 RID: 3684
	[Token(Token = "0x200096F")]
	[Serializable]
	public class ShopItem
	{
		// Token: 0x060060DC RID: 24796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005034")]
		[Address(RVA = "0x2179F60", Offset = "0x217A061", VA = "0x2179F60")]
		public ShopItem()
		{
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x00020688 File Offset: 0x0001E888
		[Token(Token = "0x6005035")]
		[Address(RVA = "0x2179F90", Offset = "0x217A091", VA = "0x2179F90")]
		public int GetPrices()
		{
			return 0;
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x000206A0 File Offset: 0x0001E8A0
		[Token(Token = "0x6005036")]
		[Address(RVA = "0x2179FF0", Offset = "0x217A0F1", VA = "0x2179FF0")]
		private ItemID GetRandItemId(int id)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005037")]
		[Address(RVA = "0x217A290", Offset = "0x217A391", VA = "0x217A290")]
		private void CheckDropCap()
		{
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x217A340", Offset = "0x217A441", VA = "0x217A340")]
		private void CheckShipment()
		{
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x217A3B0", Offset = "0x217A4B1", VA = "0x217A3B0")]
		private void CheckGet()
		{
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x217A400", Offset = "0x217A501", VA = "0x217A400")]
		private UIShopRandomItemTable.RandomIdList GetRandomList(int id)
		{
			return null;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x000206B8 File Offset: 0x0001E8B8
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x217A540", Offset = "0x217A641", VA = "0x217A540")]
		public ItemID CheckRandItem(int RandCnt, List<int> randItems)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503C")]
		[Address(RVA = "0x2179580", Offset = "0x2179681", VA = "0x2179580")]
		public void CheckCropSeed()
		{
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503D")]
		[Address(RVA = "0x217A900", Offset = "0x217AA01", VA = "0x217A900")]
		public ItemData GetItemData()
		{
			return null;
		}

		// Token: 0x0400BFD4 RID: 49108
		[Token(Token = "0x4008F8F")]
		[FieldOffset(Offset = "0x10")]
		public ItemID ItemId;

		// Token: 0x0400BFD5 RID: 49109
		[Token(Token = "0x4008F90")]
		[FieldOffset(Offset = "0x14")]
		public int itemLv;

		// Token: 0x0400BFD6 RID: 49110
		[Token(Token = "0x4008F91")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x0400BFD7 RID: 49111
		[Token(Token = "0x4008F92")]
		[FieldOffset(Offset = "0x1C")]
		public int prices;

		// Token: 0x0400BFD8 RID: 49112
		[Token(Token = "0x4008F93")]
		[FieldOffset(Offset = "0x20")]
		public List<ulong> conditions;

		// Token: 0x0400BFD9 RID: 49113
		[Token(Token = "0x4008F94")]
		[FieldOffset(Offset = "0x28")]
		public GameFlagData storyLineFrag;

		// Token: 0x0400BFDA RID: 49114
		[Token(Token = "0x4008F95")]
		[FieldOffset(Offset = "0x2C")]
		public int shopLv;

		// Token: 0x02000E65 RID: 3685
		[Token(Token = "0x2001461")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159950", Offset = "0x159A51")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x060060E6 RID: 24806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B57")]
			[Address(RVA = "0x217A180", Offset = "0x217A281", VA = "0x217A180")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x060060E7 RID: 24807 RVA: 0x000206D0 File Offset: 0x0001E8D0
			[Token(Token = "0x6007B58")]
			[Address(RVA = "0x217A940", Offset = "0x217AA41", VA = "0x217A940")]
			internal bool <GetRandItemId>b__0(UIShopRandomItemTable.Datas a)
			{
				return default(bool);
			}

			// Token: 0x0400BFDB RID: 49115
			[Token(Token = "0x401BC51")]
			[FieldOffset(Offset = "0x10")]
			public int id;
		}

		// Token: 0x02000E66 RID: 3686
		[Token(Token = "0x2001462")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159960", Offset = "0x159A61")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x060060E8 RID: 24808 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B59")]
			[Address(RVA = "0x217A530", Offset = "0x217A631", VA = "0x217A530")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x060060E9 RID: 24809 RVA: 0x000206E8 File Offset: 0x0001E8E8
			[Token(Token = "0x6007B5A")]
			[Address(RVA = "0x217A910", Offset = "0x217AA11", VA = "0x217A910")]
			internal bool <GetRandomList>b__0(UIShopRandomItemTable.RandomIdList a)
			{
				return default(bool);
			}

			// Token: 0x0400BFDC RID: 49116
			[Token(Token = "0x401BC52")]
			[FieldOffset(Offset = "0x10")]
			public int id;
		}
	}
}
