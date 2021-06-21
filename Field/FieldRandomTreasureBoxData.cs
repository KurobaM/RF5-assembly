using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001136 RID: 4406
	[Token(Token = "0x2000B15")]
	public class FieldRandomTreasureBoxData : FieldTreasureBoxData
	{
		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06006F84 RID: 28548 RVA: 0x00026670 File Offset: 0x00024870
		// (set) Token: 0x06006F85 RID: 28549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B10")]
		public FieldRandomTreasureBoxSpawnID FieldRandomBoxSpawnID
		{
			[Token(Token = "0x6005C6F")]
			[Address(RVA = "0x1F86150", Offset = "0x1F86251", VA = "0x1F86150")]
			get
			{
				return FieldRandomTreasureBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005C70")]
			[Address(RVA = "0x1F86160", Offset = "0x1F86261", VA = "0x1F86160")]
			set
			{
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06006F86 RID: 28550 RVA: 0x00026688 File Offset: 0x00024888
		// (set) Token: 0x06006F87 RID: 28551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B11")]
		public FieldRandomTreasureBoxSpawnDataTable RandomBoxSpawnData
		{
			[Token(Token = "0x6005C71")]
			[Address(RVA = "0x1F86170", Offset = "0x1F86271", VA = "0x1F86170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF110", Offset = "0x1AF211")]
			get
			{
				return default(FieldRandomTreasureBoxSpawnDataTable);
			}
			[Token(Token = "0x6005C72")]
			[Address(RVA = "0x1F86190", Offset = "0x1F86291", VA = "0x1F86190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF120", Offset = "0x1AF221")]
			set
			{
			}
		}

		// Token: 0x06006F88 RID: 28552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C73")]
		[Address(RVA = "0x1F861B0", Offset = "0x1F862B1", VA = "0x1F861B0", Slot = "4")]
		public override void SetDataId(int id)
		{
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x000266A0 File Offset: 0x000248A0
		[Token(Token = "0x6005C74")]
		[Address(RVA = "0x1F861C0", Offset = "0x1F862C1", VA = "0x1F861C0", Slot = "10")]
		public override bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x000266B8 File Offset: 0x000248B8
		[Token(Token = "0x6005C75")]
		[Address(RVA = "0x1F861D0", Offset = "0x1F862D1", VA = "0x1F861D0", Slot = "11")]
		public override bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C76")]
		[Address(RVA = "0x1F861E0", Offset = "0x1F862E1", VA = "0x1F861E0", Slot = "12")]
		public override FieldTreasureBoxDropItem[] GetDropItems()
		{
			return null;
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C77")]
		[Address(RVA = "0x1F86630", Offset = "0x1F86731", VA = "0x1F86630", Slot = "13")]
		public override FieldTreasureBoxDropRecipe[] GetDropRecipes()
		{
			return null;
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x000266D0 File Offset: 0x000248D0
		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x1F86640", Offset = "0x1F86741", VA = "0x1F86640", Slot = "14")]
		public override int GetDropGold()
		{
			return 0;
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x000266E8 File Offset: 0x000248E8
		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x1F86650", Offset = "0x1F86751", VA = "0x1F86650", Slot = "15")]
		public override bool CanSpawnSeason(Season season)
		{
			return default(bool);
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7A")]
		[Address(RVA = "0x1F86660", Offset = "0x1F86761", VA = "0x1F86660")]
		public FieldRandomTreasureBoxData()
		{
		}

		// Token: 0x04018237 RID: 98871
		[Token(Token = "0x4014CC5")]
		private const int ItemDropRate = 100;

		// Token: 0x04018238 RID: 98872
		[Token(Token = "0x4014CC6")]
		private const int ItemDrop2Rate = 75;

		// Token: 0x04018239 RID: 98873
		[Token(Token = "0x4014CC7")]
		private const int ItemDrop3Rate = 50;

		// Token: 0x0401823A RID: 98874
		[Token(Token = "0x4014CC8")]
		private const int ItemDrop4Rate = 50;

		// Token: 0x0401823B RID: 98875
		[Token(Token = "0x4014CC9")]
		[FieldOffset(Offset = "0x30")]
		private FieldRandomTreasureBoxSpawnID _FieldRandomBoxSpawnID;

		// Token: 0x0401823C RID: 98876
		[Token(Token = "0x4014CCA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181600", Offset = "0x181701")]
		private FieldRandomTreasureBoxSpawnDataTable <RandomBoxSpawnData>k__BackingField;

		// Token: 0x0401823D RID: 98877
		[Token(Token = "0x4014CCB")]
		[FieldOffset(Offset = "0x58")]
		public int LotteryType;
	}
}
