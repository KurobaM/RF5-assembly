using System;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001148 RID: 4424
	[Token(Token = "0x2000B20")]
	[Serializable]
	public struct FieldUniqueTreasureBoxSpawnDataTable
	{
		// Token: 0x06007040 RID: 28736 RVA: 0x00026B98 File Offset: 0x00024D98
		[Token(Token = "0x6005D07")]
		[Address(RVA = "0x2DF2F0", Offset = "0x2DF3F1", VA = "0x2DF2F0")]
		public int GetItemDataLength()
		{
			return 0;
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x00026BB0 File Offset: 0x00024DB0
		[Token(Token = "0x6005D08")]
		[Address(RVA = "0x2DF310", Offset = "0x2DF411", VA = "0x2DF310")]
		public bool IsRespawn()
		{
			return default(bool);
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x00026BC8 File Offset: 0x00024DC8
		[Token(Token = "0x6005D09")]
		[Address(RVA = "0x2DF320", Offset = "0x2DF421", VA = "0x2DF320")]
		public bool IsTakeDamege()
		{
			return default(bool);
		}

		// Token: 0x040182A9 RID: 98985
		[Token(Token = "0x4014D1D")]
		[FieldOffset(Offset = "0x0")]
		public FieldUniqueTreasureBoxSpawnID DataID;

		// Token: 0x040182AA RID: 98986
		[Token(Token = "0x4014D1E")]
		[FieldOffset(Offset = "0x8")]
		public FieldTreasureBoxItemData[] ItemDatas;

		// Token: 0x040182AB RID: 98987
		[Token(Token = "0x4014D1F")]
		[FieldOffset(Offset = "0x10")]
		public RecipeId[] RecipeIds;

		// Token: 0x040182AC RID: 98988
		[Token(Token = "0x4014D20")]
		[FieldOffset(Offset = "0x18")]
		public int Gold;

		// Token: 0x040182AD RID: 98989
		[Token(Token = "0x4014D21")]
		[FieldOffset(Offset = "0x1C")]
		public int BoxType;

		// Token: 0x040182AE RID: 98990
		[Token(Token = "0x4014D22")]
		[FieldOffset(Offset = "0x20")]
		public int SpawnRatio;

		// Token: 0x040182AF RID: 98991
		[Token(Token = "0x4014D23")]
		[FieldOffset(Offset = "0x24")]
		public int SeasonBit;

		// Token: 0x040182B0 RID: 98992
		[Token(Token = "0x4014D24")]
		[FieldOffset(Offset = "0x28")]
		public FieldSceneId FieldId;
	}
}
