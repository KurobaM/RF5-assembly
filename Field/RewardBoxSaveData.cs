using System;
using BinaryStream;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200113D RID: 4413
	[Token(Token = "0x2000B1C")]
	[Serializable]
	public class RewardBoxSaveData
	{
		// Token: 0x06006FAD RID: 28589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C98")]
		[Address(RVA = "0x202F690", Offset = "0x202F791", VA = "0x202F690")]
		public void Initialize()
		{
		}

		// Token: 0x06006FAE RID: 28590 RVA: 0x00026808 File Offset: 0x00024A08
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0x202F960", Offset = "0x202FA61", VA = "0x202F960")]
		public int GetOrderRewardItemCount()
		{
			return 0;
		}

		// Token: 0x06006FAF RID: 28591 RVA: 0x00026820 File Offset: 0x00024A20
		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0x202F9E0", Offset = "0x202FAE1", VA = "0x202F9E0")]
		public int GetOrderRewardRecipeCount()
		{
			return 0;
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00026838 File Offset: 0x00024A38
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x202FA60", Offset = "0x202FB61", VA = "0x202FA60")]
		public int GetWantedRewardItemCount()
		{
			return 0;
		}

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00026850 File Offset: 0x00024A50
		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x202FAE0", Offset = "0x202FBE1", VA = "0x202FAE0")]
		public int GetFestivalrRewardItemCount()
		{
			return 0;
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00026868 File Offset: 0x00024A68
		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x202FB60", Offset = "0x202FC61", VA = "0x202FB60")]
		public bool AddOrderRewardItem(int itemId, int amount, int level)
		{
			return default(bool);
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x00026880 File Offset: 0x00024A80
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x202FBF0", Offset = "0x202FCF1", VA = "0x202FBF0")]
		public bool AddOrderRewardRecipe(int id)
		{
			return default(bool);
		}

		// Token: 0x06006FB4 RID: 28596 RVA: 0x00026898 File Offset: 0x00024A98
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x202FC60", Offset = "0x202FD61", VA = "0x202FC60")]
		public bool AddWantedRewardItem(int itemId, int amount, int level)
		{
			return default(bool);
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x000268B0 File Offset: 0x00024AB0
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x202FCE0", Offset = "0x202FDE1", VA = "0x202FCE0")]
		public bool AddFestivalRewardItem(int itemId, int amount, int level)
		{
			return default(bool);
		}

		// Token: 0x06006FB6 RID: 28598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x202FD60", Offset = "0x202FE61", VA = "0x202FD60")]
		public void ClearOrderRewardItem()
		{
		}

		// Token: 0x06006FB7 RID: 28599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x202FDD0", Offset = "0x202FED1", VA = "0x202FDD0")]
		public void ClearOrderRewardRecipe()
		{
		}

		// Token: 0x06006FB8 RID: 28600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x202FE30", Offset = "0x202FF31", VA = "0x202FE30")]
		public void ClearWantedRewardItem()
		{
		}

		// Token: 0x06006FB9 RID: 28601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x202FE90", Offset = "0x202FF91", VA = "0x202FE90")]
		public void ClearFestivalReward()
		{
		}

		// Token: 0x06006FBA RID: 28602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0x202FEF0", Offset = "0x202FFF1", VA = "0x202FEF0")]
		public void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006FBB RID: 28603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x20301F0", Offset = "0x20302F1", VA = "0x20301F0")]
		public void Reader(BinaryReader reader)
		{
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0x2030620", Offset = "0x2030721", VA = "0x2030620")]
		public void Reader0010(BinaryReader reader)
		{
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0x2030A00", Offset = "0x2030B01", VA = "0x2030A00")]
		public RewardBoxSaveData()
		{
		}

		// Token: 0x04018262 RID: 98914
		[Token(Token = "0x4014CF0")]
		public const int OrderRewardItemLength = 24;

		// Token: 0x04018263 RID: 98915
		[Token(Token = "0x4014CF1")]
		public const int OrderRewardRecipeLength = 24;

		// Token: 0x04018264 RID: 98916
		[Token(Token = "0x4014CF2")]
		public const int WantedRewardItemLength = 8;

		// Token: 0x04018265 RID: 98917
		[Token(Token = "0x4014CF3")]
		public const int FestivalRewardItemLength = 4;

		// Token: 0x04018266 RID: 98918
		[Token(Token = "0x4014CF4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int Version;

		// Token: 0x04018267 RID: 98919
		[Token(Token = "0x4014CF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public RewardItemData[] OrderRewardItemData;

		// Token: 0x04018268 RID: 98920
		[Token(Token = "0x4014CF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int[] OrderRewardRecipeData;

		// Token: 0x04018269 RID: 98921
		[Token(Token = "0x4014CF7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public int OrderRewardGold;

		// Token: 0x0401826A RID: 98922
		[Token(Token = "0x4014CF8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public RewardItemData[] WantedRewardItemData;

		// Token: 0x0401826B RID: 98923
		[Token(Token = "0x4014CF9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public RewardItemData[] FestivalRewardItemData;
	}
}
