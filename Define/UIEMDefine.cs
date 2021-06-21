using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x0200128C RID: 4748
	[Token(Token = "0x2000C5B")]
	public class UIEMDefine
	{
		// Token: 0x06007178 RID: 29048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0x1DF9340", Offset = "0x1DF9441", VA = "0x1DF9340")]
		public UIEMDefine()
		{
		}

		// Token: 0x0401B44A RID: 111690
		[Token(Token = "0x4017E8D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly UIEMDefine.CategoryDataSet[] categoryDataSets;

		// Token: 0x0401B44B RID: 111691
		[Token(Token = "0x4017E8E")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int[] DefaultCustomizeCategories;

		// Token: 0x0401B44C RID: 111692
		[Token(Token = "0x4017E8F")]
		[FieldOffset(Offset = "0x10")]
		public static readonly int[] DefaultQuckCategories;

		// Token: 0x0401B44D RID: 111693
		[Token(Token = "0x4017E90")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int[] DefaultCampCategoriesNoRune;

		// Token: 0x0401B44E RID: 111694
		[Token(Token = "0x4017E91")]
		[FieldOffset(Offset = "0x20")]
		public static readonly int[] DefaultCampCategories;

		// Token: 0x0200128D RID: 4749
		[Token(Token = "0x200159D")]
		public enum EMCategory
		{
			// Token: 0x0401B450 RID: 111696
			[Token(Token = "0x401C1CA")]
			Accessary,
			// Token: 0x0401B451 RID: 111697
			[Token(Token = "0x401C1CB")]
			Body,
			// Token: 0x0401B452 RID: 111698
			[Token(Token = "0x401C1CC")]
			Head,
			// Token: 0x0401B453 RID: 111699
			[Token(Token = "0x401C1CD")]
			RuneRX,
			// Token: 0x0401B454 RID: 111700
			[Token(Token = "0x401C1CE")]
			RuneRY,
			// Token: 0x0401B455 RID: 111701
			[Token(Token = "0x401C1CF")]
			RuneRB,
			// Token: 0x0401B456 RID: 111702
			[Token(Token = "0x401C1D0")]
			RuneRA,
			// Token: 0x0401B457 RID: 111703
			[Token(Token = "0x401C1D1")]
			RuneA,
			// Token: 0x0401B458 RID: 111704
			[Token(Token = "0x401C1D2")]
			RuneB,
			// Token: 0x0401B459 RID: 111705
			[Token(Token = "0x401C1D3")]
			Shield,
			// Token: 0x0401B45A RID: 111706
			[Token(Token = "0x401C1D4")]
			Shoes,
			// Token: 0x0401B45B RID: 111707
			[Token(Token = "0x401C1D5")]
			Tool,
			// Token: 0x0401B45C RID: 111708
			[Token(Token = "0x401C1D6")]
			Weapon,
			// Token: 0x0401B45D RID: 111709
			[Token(Token = "0x401C1D7")]
			Crop,
			// Token: 0x0401B45E RID: 111710
			[Token(Token = "0x401C1D8")]
			Fish,
			// Token: 0x0401B45F RID: 111711
			[Token(Token = "0x401C1D9")]
			Collect,
			// Token: 0x0401B460 RID: 111712
			[Token(Token = "0x401C1DA")]
			Food,
			// Token: 0x0401B461 RID: 111713
			[Token(Token = "0x401C1DB")]
			Drug,
			// Token: 0x0401B462 RID: 111714
			[Token(Token = "0x401C1DC")]
			Hand,
			// Token: 0x0401B463 RID: 111715
			[Token(Token = "0x401C1DD")]
			Max,
			// Token: 0x0401B464 RID: 111716
			[Token(Token = "0x401C1DE")]
			None
		}

		// Token: 0x0200128E RID: 4750
		[Token(Token = "0x200159E")]
		public readonly struct CategoryDataSet
		{
			// Token: 0x0600717A RID: 29050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DFA")]
			[Address(RVA = "0x2DDF40", Offset = "0x2DE041", VA = "0x2DDF40")]
			public CategoryDataSet(UIEMDefine.EMCategory _category, string _Text, EquipSlotType _slotType, ItemCategory[] _itemCategories)
			{
			}

			// Token: 0x0401B465 RID: 111717
			[Token(Token = "0x401C1DF")]
			[FieldOffset(Offset = "0x0")]
			public readonly UIEMDefine.EMCategory category;

			// Token: 0x0401B466 RID: 111718
			[Token(Token = "0x401C1E0")]
			[FieldOffset(Offset = "0x8")]
			public readonly string Text;

			// Token: 0x0401B467 RID: 111719
			[Token(Token = "0x401C1E1")]
			[FieldOffset(Offset = "0x10")]
			public readonly EquipSlotType slotType;

			// Token: 0x0401B468 RID: 111720
			[Token(Token = "0x401C1E2")]
			[FieldOffset(Offset = "0x18")]
			public readonly ItemCategory[] itemCategories;
		}
	}
}
