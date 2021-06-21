using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001134 RID: 4404
	[Token(Token = "0x2000B13")]
	public abstract class FieldTreasureBoxData
	{
		// Token: 0x06006F6A RID: 28522
		[Token(Token = "0x6005C55")]
		public abstract void SetDataId(int id);

		// Token: 0x06006F6B RID: 28523 RVA: 0x00026598 File Offset: 0x00024798
		[Token(Token = "0x6005C56")]
		[Address(RVA = "0x1F8C880", Offset = "0x1F8C981", VA = "0x1F8C880", Slot = "5")]
		public virtual int GetDataId()
		{
			return 0;
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C57")]
		[Address(RVA = "0x1F8C890", Offset = "0x1F8C991", VA = "0x1F8C890", Slot = "6")]
		public virtual void SetDataType(FieldTreasureBoxDataType type)
		{
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x000265B0 File Offset: 0x000247B0
		[Token(Token = "0x6005C58")]
		[Address(RVA = "0x1F8C8A0", Offset = "0x1F8C9A1", VA = "0x1F8C8A0", Slot = "7")]
		public virtual FieldTreasureBoxDataType GetDataType()
		{
			return FieldTreasureBoxDataType.None;
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x000265C8 File Offset: 0x000247C8
		[Token(Token = "0x6005C59")]
		[Address(RVA = "0x1F8C8B0", Offset = "0x1F8C9B1", VA = "0x1F8C8B0", Slot = "8")]
		public virtual int GetModelType()
		{
			return 0;
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5A")]
		[Address(RVA = "0x1F8C8C0", Offset = "0x1F8C9C1", VA = "0x1F8C8C0", Slot = "9")]
		public virtual void SetModelType(int modelId)
		{
		}

		// Token: 0x06006F70 RID: 28528
		[Token(Token = "0x6005C5B")]
		public abstract bool IsRespawn();

		// Token: 0x06006F71 RID: 28529
		[Token(Token = "0x6005C5C")]
		public abstract bool IsTakeDamege();

		// Token: 0x06006F72 RID: 28530
		[Token(Token = "0x6005C5D")]
		public abstract FieldTreasureBoxDropItem[] GetDropItems();

		// Token: 0x06006F73 RID: 28531
		[Token(Token = "0x6005C5E")]
		public abstract FieldTreasureBoxDropRecipe[] GetDropRecipes();

		// Token: 0x06006F74 RID: 28532
		[Token(Token = "0x6005C5F")]
		public abstract int GetDropGold();

		// Token: 0x06006F75 RID: 28533
		[Token(Token = "0x6005C60")]
		public abstract bool CanSpawnSeason(Season season);

		// Token: 0x06006F76 RID: 28534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x1F8C8D0", Offset = "0x1F8C9D1", VA = "0x1F8C8D0", Slot = "16")]
		public virtual void Clear()
		{
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C62")]
		[Address(RVA = "0x1F86670", Offset = "0x1F86771", VA = "0x1F86670")]
		protected FieldTreasureBoxData()
		{
		}

		// Token: 0x04018230 RID: 98864
		[Token(Token = "0x4014CBE")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x04018231 RID: 98865
		[Token(Token = "0x4014CBF")]
		[FieldOffset(Offset = "0x14")]
		public int modelId;

		// Token: 0x04018232 RID: 98866
		[Token(Token = "0x4014CC0")]
		[FieldOffset(Offset = "0x18")]
		public FieldTreasureBoxDataType boxDataType;

		// Token: 0x04018233 RID: 98867
		[Token(Token = "0x4014CC1")]
		[FieldOffset(Offset = "0x20")]
		public FieldTreasureBoxDropItem[] dropItems;

		// Token: 0x04018234 RID: 98868
		[Token(Token = "0x4014CC2")]
		[FieldOffset(Offset = "0x28")]
		public FieldTreasureBoxDropRecipe[] dropRecipes;
	}
}
