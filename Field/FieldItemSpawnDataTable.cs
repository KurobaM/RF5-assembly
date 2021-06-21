using System;
using Define;
using Il2CppDummyDll;

namespace Field
{
	// Token: 0x02001126 RID: 4390
	[Token(Token = "0x2000B09")]
	[Serializable]
	public struct FieldItemSpawnDataTable
	{
		// Token: 0x06006F00 RID: 28416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BFC")]
		[Address(RVA = "0x2DEBF0", Offset = "0x2DECF1", VA = "0x2DEBF0")]
		public int[] GetLevelAmount()
		{
			return null;
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x00026340 File Offset: 0x00024540
		[Token(Token = "0x6005BFD")]
		[Address(RVA = "0x2DEC90", Offset = "0x2DED91", VA = "0x2DEC90")]
		public bool CanSpawnSeason(Season season)
		{
			return default(bool);
		}

		// Token: 0x040181F6 RID: 98806
		[Token(Token = "0x4014C90")]
		[FieldOffset(Offset = "0x0")]
		public FieldItemSpawnID DataID;

		// Token: 0x040181F7 RID: 98807
		[Token(Token = "0x4014C91")]
		[FieldOffset(Offset = "0x4")]
		public ItemID ItemId;

		// Token: 0x040181F8 RID: 98808
		[Token(Token = "0x4014C92")]
		[FieldOffset(Offset = "0x8")]
		public int Amount;

		// Token: 0x040181F9 RID: 98809
		[Token(Token = "0x4014C93")]
		[FieldOffset(Offset = "0xC")]
		public int Level;

		// Token: 0x040181FA RID: 98810
		[Token(Token = "0x4014C94")]
		[FieldOffset(Offset = "0x10")]
		public int SpawnType;

		// Token: 0x040181FB RID: 98811
		[Token(Token = "0x4014C95")]
		[FieldOffset(Offset = "0x14")]
		public int RespawnType;

		// Token: 0x040181FC RID: 98812
		[Token(Token = "0x4014C96")]
		[FieldOffset(Offset = "0x18")]
		public int SeasonBit;

		// Token: 0x040181FD RID: 98813
		[Token(Token = "0x4014C97")]
		[FieldOffset(Offset = "0x1C")]
		public int SpawnRatio;

		// Token: 0x040181FE RID: 98814
		[Token(Token = "0x4014C98")]
		[FieldOffset(Offset = "0x20")]
		public FieldSceneId FieldId;
	}
}
