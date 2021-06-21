using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001135 RID: 4405
	[Token(Token = "0x2000B14")]
	public class FieldUniqueTreasureBoxData : FieldTreasureBoxData
	{
		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06006F78 RID: 28536 RVA: 0x000265E0 File Offset: 0x000247E0
		// (set) Token: 0x06006F79 RID: 28537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0E")]
		public FieldUniqueTreasureBoxSpawnID FieldUniqueBoxSpawnID
		{
			[Token(Token = "0x6005C63")]
			[Address(RVA = "0x1F91B10", Offset = "0x1F91C11", VA = "0x1F91B10")]
			get
			{
				return FieldUniqueTreasureBoxSpawnID.EMPTY;
			}
			[Token(Token = "0x6005C64")]
			[Address(RVA = "0x1F8CEA0", Offset = "0x1F8CFA1", VA = "0x1F8CEA0")]
			set
			{
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x000265F8 File Offset: 0x000247F8
		// (set) Token: 0x06006F7B RID: 28539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B0F")]
		public FieldUniqueTreasureBoxSpawnDataTable UniqueBoxSpawnData
		{
			[Token(Token = "0x6005C65")]
			[Address(RVA = "0x1F91B20", Offset = "0x1F91C21", VA = "0x1F91B20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF0F0", Offset = "0x1AF1F1")]
			get
			{
				return default(FieldUniqueTreasureBoxSpawnDataTable);
			}
			[Token(Token = "0x6005C66")]
			[Address(RVA = "0x1F91B40", Offset = "0x1F91C41", VA = "0x1F91B40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF100", Offset = "0x1AF201")]
			set
			{
			}
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C67")]
		[Address(RVA = "0x1F91B70", Offset = "0x1F91C71", VA = "0x1F91B70", Slot = "4")]
		public override void SetDataId(int id)
		{
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x00026610 File Offset: 0x00024810
		[Token(Token = "0x6005C68")]
		[Address(RVA = "0x1F91B80", Offset = "0x1F91C81", VA = "0x1F91B80", Slot = "10")]
		public override bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x00026628 File Offset: 0x00024828
		[Token(Token = "0x6005C69")]
		[Address(RVA = "0x1F91B90", Offset = "0x1F91C91", VA = "0x1F91B90", Slot = "11")]
		public override bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6A")]
		[Address(RVA = "0x1F91BA0", Offset = "0x1F91CA1", VA = "0x1F91BA0", Slot = "12")]
		public override FieldTreasureBoxDropItem[] GetDropItems()
		{
			return null;
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C6B")]
		[Address(RVA = "0x1F91E30", Offset = "0x1F91F31", VA = "0x1F91E30", Slot = "13")]
		public override FieldTreasureBoxDropRecipe[] GetDropRecipes()
		{
			return null;
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x00026640 File Offset: 0x00024840
		[Token(Token = "0x6005C6C")]
		[Address(RVA = "0x1F920B0", Offset = "0x1F921B1", VA = "0x1F920B0", Slot = "14")]
		public override int GetDropGold()
		{
			return 0;
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x00026658 File Offset: 0x00024858
		[Token(Token = "0x6005C6D")]
		[Address(RVA = "0x1F920C0", Offset = "0x1F921C1", VA = "0x1F920C0", Slot = "15")]
		public override bool CanSpawnSeason(Season season)
		{
			return default(bool);
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x1F8CE90", Offset = "0x1F8CF91", VA = "0x1F8CE90")]
		public FieldUniqueTreasureBoxData()
		{
		}

		// Token: 0x04018235 RID: 98869
		[Token(Token = "0x4014CC3")]
		[FieldOffset(Offset = "0x30")]
		private FieldUniqueTreasureBoxSpawnID _FieldUniqueBoxSpawnID;

		// Token: 0x04018236 RID: 98870
		[Token(Token = "0x4014CC4")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1815F0", Offset = "0x1816F1")]
		private FieldUniqueTreasureBoxSpawnDataTable <UniqueBoxSpawnData>k__BackingField;
	}
}
