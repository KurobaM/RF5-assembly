using System;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001149 RID: 4425
	[Token(Token = "0x2000B21")]
	[Serializable]
	public struct FieldRandomTreasureBoxSpawnDataTable
	{
		// Token: 0x06007043 RID: 28739 RVA: 0x00026BE0 File Offset: 0x00024DE0
		[Token(Token = "0x6005D0A")]
		[Address(RVA = "0x2DEDE0", Offset = "0x2DEEE1", VA = "0x2DEDE0")]
		public int GetRatiosLength()
		{
			return 0;
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x00026BF8 File Offset: 0x00024DF8
		[Token(Token = "0x6005D0B")]
		[Address(RVA = "0x2DEE00", Offset = "0x2DEF01", VA = "0x2DEE00")]
		public bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x00026C10 File Offset: 0x00024E10
		[Token(Token = "0x6005D0C")]
		[Address(RVA = "0x2DEE10", Offset = "0x2DEF11", VA = "0x2DEE10")]
		public bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x040182B1 RID: 98993
		[Token(Token = "0x4014D25")]
		[FieldOffset(Offset = "0x0")]
		public FieldRandomTreasureBoxSpawnID DataID;

		// Token: 0x040182B2 RID: 98994
		[Token(Token = "0x4014D26")]
		[FieldOffset(Offset = "0x4")]
		public int BoxType;

		// Token: 0x040182B3 RID: 98995
		[Token(Token = "0x4014D27")]
		[FieldOffset(Offset = "0x8")]
		public int SpawnRatio;

		// Token: 0x040182B4 RID: 98996
		[Token(Token = "0x4014D28")]
		[FieldOffset(Offset = "0x10")]
		public int[] Ratios;

		// Token: 0x040182B5 RID: 98997
		[Token(Token = "0x4014D29")]
		[FieldOffset(Offset = "0x18")]
		public int SeasonBit;

		// Token: 0x040182B6 RID: 98998
		[Token(Token = "0x4014D2A")]
		[FieldOffset(Offset = "0x1C")]
		public FieldSceneId FieldId;
	}
}
