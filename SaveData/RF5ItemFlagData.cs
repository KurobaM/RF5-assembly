using System;
using BinaryStream;
using Define;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000ED1 RID: 3793
	[Token(Token = "0x20009B4")]
	public class RF5ItemFlagData : SaveDataValueBase
	{
		// Token: 0x06006327 RID: 25383 RVA: 0x00021450 File Offset: 0x0001F650
		[Token(Token = "0x6005238")]
		[Address(RVA = "0x1F02790", Offset = "0x1F02891", VA = "0x1F02790")]
		public bool CheckItemGet(ItemID itemID)
		{
			return default(bool);
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005239")]
		[Address(RVA = "0x1F02800", Offset = "0x1F02901", VA = "0x1F02800")]
		public void SetItemGet(bool value, ItemID itemID)
		{
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x00021468 File Offset: 0x0001F668
		[Token(Token = "0x600523A")]
		[Address(RVA = "0x1F02870", Offset = "0x1F02971", VA = "0x1F02870")]
		public bool CheckRecipeRelease(RecipeRelease recipeId)
		{
			return default(bool);
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523B")]
		[Address(RVA = "0x1F02890", Offset = "0x1F02991", VA = "0x1F02890")]
		public void SetRecipeRelease(bool value, RecipeRelease recipeId)
		{
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x00021480 File Offset: 0x0001F680
		[Token(Token = "0x600523C")]
		[Address(RVA = "0x1F028F0", Offset = "0x1F029F1", VA = "0x1F028F0")]
		public bool IsFirstRecipeGet()
		{
			return default(bool);
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x00021498 File Offset: 0x0001F698
		[Token(Token = "0x600523D")]
		[Address(RVA = "0x1F02910", Offset = "0x1F02A11", VA = "0x1F02910")]
		public bool CheckClothShop(ClothShopID id)
		{
			return default(bool);
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600523E")]
		[Address(RVA = "0x1F02930", Offset = "0x1F02A31", VA = "0x1F02930")]
		public void SetClothShop(bool value, ClothShopID id)
		{
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x000214B0 File Offset: 0x0001F6B0
		[Token(Token = "0x600523F")]
		[Address(RVA = "0x1F027E0", Offset = "0x1F028E1", VA = "0x1F027E0")]
		private bool GetSaveFlag(RF5ItemFlagData.FLAG id)
		{
			return default(bool);
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x1F02850", Offset = "0x1F02951", VA = "0x1F02850")]
		private void SetSaveFlag(RF5ItemFlagData.FLAG id, bool value)
		{
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005241")]
		[Address(RVA = "0x1F02960", Offset = "0x1F02A61", VA = "0x1F02960")]
		public RF5ItemFlagData()
		{
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005242")]
		[Address(RVA = "0x1F02A20", Offset = "0x1F02B21", VA = "0x1F02A20", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005243")]
		[Address(RVA = "0x1F02A40", Offset = "0x1F02B41", VA = "0x1F02A40", Slot = "5")]
		public override void BeforeSave()
		{
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x1F02A50", Offset = "0x1F02B51", VA = "0x1F02A50", Slot = "6")]
		public override void AfterLoad()
		{
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x1F02A60", Offset = "0x1F02B61", VA = "0x1F02A60", Slot = "7")]
		public override void Writer(BinaryWriter writer)
		{
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x1F02AB0", Offset = "0x1F02BB1", VA = "0x1F02AB0")]
		public void Reader0000(BinaryReader reader)
		{
		}

		// Token: 0x0400C302 RID: 49922
		[Token(Token = "0x4009224")]
		[FieldOffset(Offset = "0x10")]
		public SaveFlagStorage SaveFlag;

		// Token: 0x0400C303 RID: 49923
		[Token(Token = "0x4009225")]
		[FieldOffset(Offset = "0x18")]
		public SaveFlagStorage ClothFlag;

		// Token: 0x02000ED2 RID: 3794
		[Token(Token = "0x2001489")]
		public enum FLAG
		{
			// Token: 0x0400C305 RID: 49925
			[Token(Token = "0x401BCEB")]
			ItemGet_Head,
			// Token: 0x0400C306 RID: 49926
			[Token(Token = "0x401BCEC")]
			ItemGet_Last = 1175,
			// Token: 0x0400C307 RID: 49927
			[Token(Token = "0x401BCED")]
			FirstRecipeGet,
			// Token: 0x0400C308 RID: 49928
			[Token(Token = "0x401BCEE")]
			RecipeGet_Head,
			// Token: 0x0400C309 RID: 49929
			[Token(Token = "0x401BCEF")]
			RecipeGet_Last = 1822,
			// Token: 0x0400C30A RID: 49930
			[Token(Token = "0x401BCF0")]
			Length
		}
	}
}
