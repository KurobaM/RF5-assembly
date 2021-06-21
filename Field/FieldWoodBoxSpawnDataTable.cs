using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x0200114A RID: 4426
	[Token(Token = "0x2000B22")]
	[Serializable]
	public struct FieldWoodBoxSpawnDataTable
	{
		// Token: 0x06007046 RID: 28742 RVA: 0x00026C28 File Offset: 0x00024E28
		[Token(Token = "0x6005D0D")]
		[Address(RVA = "0x2DF330", Offset = "0x2DF431", VA = "0x2DF330")]
		public bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x00026C40 File Offset: 0x00024E40
		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0x2DF340", Offset = "0x2DF441", VA = "0x2DF340")]
		public bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x040182B7 RID: 98999
		[Token(Token = "0x4014D2B")]
		[FieldOffset(Offset = "0x0")]
		public FieldWoodBoxSpawnID DataID;

		// Token: 0x040182B8 RID: 99000
		[Token(Token = "0x4014D2C")]
		[FieldOffset(Offset = "0x4")]
		public int BoxType;

		// Token: 0x040182B9 RID: 99001
		[Token(Token = "0x4014D2D")]
		[FieldOffset(Offset = "0x8")]
		public ItemLotteryID LotteryID;

		// Token: 0x040182BA RID: 99002
		[Token(Token = "0x4014D2E")]
		[FieldOffset(Offset = "0xC")]
		public int SpawnRatio;

		// Token: 0x040182BB RID: 99003
		[Token(Token = "0x4014D2F")]
		[FieldOffset(Offset = "0x10")]
		public int SeasonBit;

		// Token: 0x040182BC RID: 99004
		[Token(Token = "0x4014D30")]
		[FieldOffset(Offset = "0x14")]
		public FieldSceneId FieldId;
	}
}
