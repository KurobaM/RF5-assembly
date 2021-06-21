using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001137 RID: 4407
	[Token(Token = "0x2000B16")]
	public class FieldWoodBoxData : FieldTreasureBoxData
	{
		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06006F90 RID: 28560 RVA: 0x00026700 File Offset: 0x00024900
		// (set) Token: 0x06006F91 RID: 28561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B12")]
		public FieldWoodBoxSpawnID FieldWoodBoxSpawnID
		{
			[Token(Token = "0x6005C7B")]
			[Address(RVA = "0x1F927F0", Offset = "0x1F928F1", VA = "0x1F927F0")]
			get
			{
				return FieldWoodBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005C7C")]
			[Address(RVA = "0x1F8CFC0", Offset = "0x1F8D0C1", VA = "0x1F8CFC0")]
			set
			{
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06006F92 RID: 28562 RVA: 0x00026718 File Offset: 0x00024918
		// (set) Token: 0x06006F93 RID: 28563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B13")]
		public FieldWoodBoxSpawnDataTable WoodBoxSpawnData
		{
			[Token(Token = "0x6005C7D")]
			[Address(RVA = "0x1F92800", Offset = "0x1F92901", VA = "0x1F92800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF130", Offset = "0x1AF231")]
			get
			{
				return default(FieldWoodBoxSpawnDataTable);
			}
			[Token(Token = "0x6005C7E")]
			[Address(RVA = "0x1F92820", Offset = "0x1F92921", VA = "0x1F92820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF140", Offset = "0x1AF241")]
			set
			{
			}
		}

		// Token: 0x06006F94 RID: 28564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0x1F92840", Offset = "0x1F92941", VA = "0x1F92840", Slot = "4")]
		public override void SetDataId(int id)
		{
		}

		// Token: 0x06006F95 RID: 28565 RVA: 0x00026730 File Offset: 0x00024930
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0x1F92850", Offset = "0x1F92951", VA = "0x1F92850", Slot = "10")]
		public override bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x00026748 File Offset: 0x00024948
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x1F92860", Offset = "0x1F92961", VA = "0x1F92860", Slot = "11")]
		public override bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x1F92870", Offset = "0x1F92971", VA = "0x1F92870", Slot = "12")]
		public override FieldTreasureBoxDropItem[] GetDropItems()
		{
			return null;
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x1F92880", Offset = "0x1F92981", VA = "0x1F92880", Slot = "13")]
		public override FieldTreasureBoxDropRecipe[] GetDropRecipes()
		{
			return null;
		}

		// Token: 0x06006F99 RID: 28569 RVA: 0x00026760 File Offset: 0x00024960
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x1F92890", Offset = "0x1F92991", VA = "0x1F92890", Slot = "14")]
		public override int GetDropGold()
		{
			return 0;
		}

		// Token: 0x06006F9A RID: 28570 RVA: 0x00026778 File Offset: 0x00024978
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x1F928A0", Offset = "0x1F929A1", VA = "0x1F928A0", Slot = "15")]
		public override bool CanSpawnSeason(Season season)
		{
			return default(bool);
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0x1F8CFB0", Offset = "0x1F8D0B1", VA = "0x1F8CFB0")]
		public FieldWoodBoxData()
		{
		}

		// Token: 0x0401823E RID: 98878
		[Token(Token = "0x4014CCC")]
		[FieldOffset(Offset = "0x30")]
		private FieldWoodBoxSpawnID _FieldWoodBoxSpawnID;

		// Token: 0x0401823F RID: 98879
		[Token(Token = "0x4014CCD")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181610", Offset = "0x181711")]
		private FieldWoodBoxSpawnDataTable <WoodBoxSpawnData>k__BackingField;
	}
}
