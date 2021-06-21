using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001138 RID: 4408
	[Token(Token = "0x2000B17")]
	public class FieldRewardTreasureBoxData : FieldTreasureBoxData
	{
		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06006F9C RID: 28572 RVA: 0x00026790 File Offset: 0x00024990
		// (set) Token: 0x06006F9D RID: 28573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B14")]
		public FieldRewardTreasureBoxSpawnID FieldRewardBoxSpawnID
		{
			[Token(Token = "0x6005C87")]
			[Address(RVA = "0x1F88A30", Offset = "0x1F88B31", VA = "0x1F88A30")]
			get
			{
				return FieldRewardTreasureBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005C88")]
			[Address(RVA = "0x1F88A40", Offset = "0x1F88B41", VA = "0x1F88A40")]
			set
			{
			}
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x1F88A50", Offset = "0x1F88B51", VA = "0x1F88A50", Slot = "4")]
		public override void SetDataId(int id)
		{
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x000267A8 File Offset: 0x000249A8
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x1F88A60", Offset = "0x1F88B61", VA = "0x1F88A60", Slot = "10")]
		public override bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x000267C0 File Offset: 0x000249C0
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x1F88A70", Offset = "0x1F88B71", VA = "0x1F88A70", Slot = "11")]
		public override bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x1F88A80", Offset = "0x1F88B81", VA = "0x1F88A80", Slot = "12")]
		public override FieldTreasureBoxDropItem[] GetDropItems()
		{
			return null;
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x1F88A90", Offset = "0x1F88B91", VA = "0x1F88A90")]
		public void AddDropItem(int id, int amount, int level)
		{
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x1F88D00", Offset = "0x1F88E01", VA = "0x1F88D00", Slot = "13")]
		public override FieldTreasureBoxDropRecipe[] GetDropRecipes()
		{
			return null;
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x1F88D10", Offset = "0x1F88E11", VA = "0x1F88D10")]
		public void AddDropRecipe(int id)
		{
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x000267D8 File Offset: 0x000249D8
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x1F88F70", Offset = "0x1F89071", VA = "0x1F88F70", Slot = "14")]
		public override int GetDropGold()
		{
			return 0;
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x1F88F80", Offset = "0x1F89081", VA = "0x1F88F80")]
		public void AddDropGold(int value)
		{
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x000267F0 File Offset: 0x000249F0
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x1F88F90", Offset = "0x1F89091", VA = "0x1F88F90", Slot = "15")]
		public override bool CanSpawnSeason(Season season)
		{
			return default(bool);
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x1F88FA0", Offset = "0x1F890A1", VA = "0x1F88FA0")]
		public FieldRewardTreasureBoxData()
		{
		}

		// Token: 0x04018240 RID: 98880
		[Token(Token = "0x4014CCE")]
		private const int RewardBoxItemSlotMax = 10;

		// Token: 0x04018241 RID: 98881
		[Token(Token = "0x4014CCF")]
		private const int RewardBoxRecipeSlotMax = 10;

		// Token: 0x04018242 RID: 98882
		[Token(Token = "0x4014CD0")]
		[FieldOffset(Offset = "0x30")]
		protected int gold;

		// Token: 0x04018243 RID: 98883
		[Token(Token = "0x4014CD1")]
		[FieldOffset(Offset = "0x34")]
		private FieldRewardTreasureBoxSpawnID _FieldRewardBoxSpawnID;
	}
}
