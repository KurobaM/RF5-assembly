using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using SaveData;

namespace RF5SHIPPING
{
	// Token: 0x02000E7A RID: 3706
	[Token(Token = "0x2000981")]
	public class ShippingManager : SingletonMonoBehaviour<ShippingManager>
	{
		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06006108 RID: 24840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E9")]
		public RF5ShippingData ShippingSaveDatas
		{
			[Token(Token = "0x6005057")]
			[Address(RVA = "0x2176950", Offset = "0x2176A51", VA = "0x2176950")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x000207A8 File Offset: 0x0001E9A8
		[Token(Token = "0x6005058")]
		[Address(RVA = "0x21769F0", Offset = "0x2176AF1", VA = "0x21769F0")]
		public long GetTotalIncome()
		{
			return 0L;
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x000207C0 File Offset: 0x0001E9C0
		[Token(Token = "0x6005059")]
		[Address(RVA = "0x2176A10", Offset = "0x2176B11", VA = "0x2176A10")]
		public int CalTotalPriceInBox()
		{
			return 0;
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505A")]
		[Address(RVA = "0x2176B70", Offset = "0x2176C71", VA = "0x2176B70")]
		public void SetFishingCrown(ItemID itemid, CROWNTYPE crownType)
		{
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505B")]
		[Address(RVA = "0x2176CF0", Offset = "0x2176DF1", VA = "0x2176CF0")]
		private void DoShipping()
		{
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505C")]
		[Address(RVA = "0x2177CC0", Offset = "0x2177DC1", VA = "0x2177CC0")]
		private void CheckShipping()
		{
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505D")]
		[Address(RVA = "0x2177E10", Offset = "0x2177F11", VA = "0x2177E10")]
		private void Update()
		{
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x2177EA0", Offset = "0x2177FA1", VA = "0x2177EA0")]
		private void InitShippingCategoryItemMax()
		{
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x000207D8 File Offset: 0x0001E9D8
		[Token(Token = "0x600505F")]
		[Address(RVA = "0x2178050", Offset = "0x2178151", VA = "0x2178050")]
		public int GetShippingCategoryItemMax(ShippingCategory shippingCategory)
		{
			return 0;
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[Token(Token = "0x6005060")]
		[Address(RVA = "0x2178020", Offset = "0x2178121", VA = "0x2178020")]
		private ShippingCategory GetShippingCategory(ItemCategory itemCategory)
		{
			return ShippingCategory.Crop;
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x00020808 File Offset: 0x0001EA08
		[Token(Token = "0x6005061")]
		[Address(RVA = "0x2177290", Offset = "0x2177391", VA = "0x2177290")]
		private int AddItemRecord(ItemData itemData)
		{
			return 0;
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x00020820 File Offset: 0x0001EA20
		[Token(Token = "0x6005062")]
		[Address(RVA = "0x21780F0", Offset = "0x21781F1", VA = "0x21780F0")]
		public CROWNTYPE rf3ShipmentRecord_GetCrownTypeFromAmount(ItemID item_id, long amount)
		{
			return CROWNTYPE.NONE;
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005063")]
		[Address(RVA = "0x2178190", Offset = "0x2178291", VA = "0x2178190")]
		public string GetShippingCategoryStr(ShippingCategory shippingCategory)
		{
			return null;
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x00020838 File Offset: 0x0001EA38
		[Token(Token = "0x6005064")]
		[Address(RVA = "0x21782B0", Offset = "0x21783B1", VA = "0x21782B0")]
		public bool CheckShipmentData(ItemID itemID)
		{
			return default(bool);
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x00020850 File Offset: 0x0001EA50
		[Token(Token = "0x6005065")]
		[Address(RVA = "0x2178400", Offset = "0x2178501", VA = "0x2178400")]
		public int CalTotalCompletePercent()
		{
			return 0;
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x00020868 File Offset: 0x0001EA68
		[Token(Token = "0x6005066")]
		[Address(RVA = "0x21778D0", Offset = "0x21779D1", VA = "0x21778D0")]
		private int DoCalTotalCompletePercent()
		{
			return 0;
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x00020880 File Offset: 0x0001EA80
		[Token(Token = "0x6005067")]
		[Address(RVA = "0x2178450", Offset = "0x2178551", VA = "0x2178450")]
		public int GetSeedMaxLv(ItemID itemID)
		{
			return 0;
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005068")]
		[Address(RVA = "0x2178580", Offset = "0x2178681", VA = "0x2178580")]
		public ShippingManager()
		{
		}

		// Token: 0x0400C0CB RID: 49355
		[Token(Token = "0x400907E")]
		private const int ShippingTime = 8;

		// Token: 0x0400C0CC RID: 49356
		[Token(Token = "0x400907F")]
		private const long ShipMoneyMax = 9999999999L;

		// Token: 0x0400C0CD RID: 49357
		[Token(Token = "0x4009080")]
		[FieldOffset(Offset = "0x18")]
		private List<int> ShippingCategoryItemMax;

		// Token: 0x0400C0CE RID: 49358
		[Token(Token = "0x4009081")]
		private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_COPPER = 20;

		// Token: 0x0400C0CF RID: 49359
		[Token(Token = "0x4009082")]
		private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_COPPER = 49;

		// Token: 0x0400C0D0 RID: 49360
		[Token(Token = "0x4009083")]
		private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_SILVER = 50;

		// Token: 0x0400C0D1 RID: 49361
		[Token(Token = "0x4009084")]
		private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MAX_AMOUNT_SILVER = 99;

		// Token: 0x0400C0D2 RID: 49362
		[Token(Token = "0x4009085")]
		private const int RF3_SHIPMENTRECORD_CROWNTHRESHOLD_MIN_AMOUNT_GOLD = 100;

		// Token: 0x0400C0D3 RID: 49363
		[Token(Token = "0x4009086")]
		[FieldOffset(Offset = "0x20")]
		private readonly string[] ShippingCategoryStrTable;

		// Token: 0x02000E7B RID: 3707
		[Token(Token = "0x2001465")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159980", Offset = "0x159A81")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600611A RID: 24858 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B60")]
			[Address(RVA = "0x2176CE0", Offset = "0x2176DE1", VA = "0x2176CE0")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600611B RID: 24859 RVA: 0x00020898 File Offset: 0x0001EA98
			[Token(Token = "0x6007B61")]
			[Address(RVA = "0x21789C0", Offset = "0x2178AC1", VA = "0x21789C0")]
			internal bool <SetFishingCrown>b__0(FishShipmentRecords a)
			{
				return default(bool);
			}

			// Token: 0x0400C0D4 RID: 49364
			[Token(Token = "0x401BC59")]
			[FieldOffset(Offset = "0x10")]
			public ItemID itemid;
		}

		// Token: 0x02000E7C RID: 3708
		[Token(Token = "0x2001466")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159990", Offset = "0x159A91")]
		private sealed class <>c__DisplayClass14_0
		{
			// Token: 0x0600611C RID: 24860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B62")]
			[Address(RVA = "0x21780E0", Offset = "0x21781E1", VA = "0x21780E0")]
			public <>c__DisplayClass14_0()
			{
			}

			// Token: 0x0600611D RID: 24861 RVA: 0x000208B0 File Offset: 0x0001EAB0
			[Token(Token = "0x6007B63")]
			[Address(RVA = "0x21788A0", Offset = "0x21789A1", VA = "0x21788A0")]
			internal bool <AddItemRecord>b__0(ShipmentItemRecords a)
			{
				return default(bool);
			}

			// Token: 0x0600611E RID: 24862 RVA: 0x000208C8 File Offset: 0x0001EAC8
			[Token(Token = "0x6007B64")]
			[Address(RVA = "0x21788D0", Offset = "0x21789D1", VA = "0x21788D0")]
			internal bool <AddItemRecord>b__1(FishShipmentRecords a)
			{
				return default(bool);
			}

			// Token: 0x0600611F RID: 24863 RVA: 0x000208E0 File Offset: 0x0001EAE0
			[Token(Token = "0x6007B65")]
			[Address(RVA = "0x2178900", Offset = "0x2178A01", VA = "0x2178900")]
			internal bool <AddItemRecord>b__2(SeedLevelRecords a)
			{
				return default(bool);
			}

			// Token: 0x06006120 RID: 24864 RVA: 0x000208F8 File Offset: 0x0001EAF8
			[Token(Token = "0x6007B66")]
			[Address(RVA = "0x2178930", Offset = "0x2178A31", VA = "0x2178930")]
			internal bool <AddItemRecord>b__3(FishShipmentRecords a)
			{
				return default(bool);
			}

			// Token: 0x0400C0D5 RID: 49365
			[Token(Token = "0x401BC5A")]
			[FieldOffset(Offset = "0x10")]
			public ItemData itemData;

			// Token: 0x0400C0D6 RID: 49366
			[Token(Token = "0x401BC5B")]
			[FieldOffset(Offset = "0x18")]
			public ItemID seedID;
		}

		// Token: 0x02000E7D RID: 3709
		[Token(Token = "0x2001467")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1599A0", Offset = "0x159AA1")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06006121 RID: 24865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B67")]
			[Address(RVA = "0x21783F0", Offset = "0x21784F1", VA = "0x21783F0")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06006122 RID: 24866 RVA: 0x00020910 File Offset: 0x0001EB10
			[Token(Token = "0x6007B68")]
			[Address(RVA = "0x2178960", Offset = "0x2178A61", VA = "0x2178960")]
			internal bool <CheckShipmentData>b__0(ShipmentItemRecords a)
			{
				return default(bool);
			}

			// Token: 0x0400C0D7 RID: 49367
			[Token(Token = "0x401BC5C")]
			[FieldOffset(Offset = "0x10")]
			public ItemID itemID;
		}

		// Token: 0x02000E7E RID: 3710
		[Token(Token = "0x2001468")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1599B0", Offset = "0x159AB1")]
		private sealed class <>c__DisplayClass26_0
		{
			// Token: 0x06006123 RID: 24867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B69")]
			[Address(RVA = "0x2178570", Offset = "0x2178671", VA = "0x2178570")]
			public <>c__DisplayClass26_0()
			{
			}

			// Token: 0x06006124 RID: 24868 RVA: 0x00020928 File Offset: 0x0001EB28
			[Token(Token = "0x6007B6A")]
			[Address(RVA = "0x2178990", Offset = "0x2178A91", VA = "0x2178990")]
			internal bool <GetSeedMaxLv>b__0(SeedLevelRecords s)
			{
				return default(bool);
			}

			// Token: 0x0400C0D8 RID: 49368
			[Token(Token = "0x401BC5D")]
			[FieldOffset(Offset = "0x10")]
			public CropDataTable cropDataTable;
		}
	}
}
