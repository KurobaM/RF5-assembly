using System;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EEA RID: 3818
	[Token(Token = "0x20009C5")]
	public static class SaveDataDefine
	{
		// Token: 0x060063FC RID: 25596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005308")]
		[Address(RVA = "0x21D0160", Offset = "0x21D0261", VA = "0x21D0160")]
		public static string GameDataFileName(int no)
		{
			return null;
		}

		// Token: 0x0400C3C8 RID: 50120
		[Token(Token = "0x40092A7")]
		public const string SYSTEM_DATA_NAME = "rf5_system";

		// Token: 0x0400C3C9 RID: 50121
		[Token(Token = "0x40092A8")]
		public const string GAME_DATA_NAME = "rf5_gm";

		// Token: 0x0400C3CA RID: 50122
		[Token(Token = "0x40092A9")]
		public const string THUMB_DATA_NAME = "rf5_tm";

		// Token: 0x0400C3CB RID: 50123
		[Token(Token = "0x40092AA")]
		public const ulong UID = 5928484577496981504UL;

		// Token: 0x0400C3CC RID: 50124
		[Token(Token = "0x40092AB")]
		public const ulong RF4SP_ApplicationId = 72100543920185344UL;

		// Token: 0x0400C3CD RID: 50125
		[Token(Token = "0x40092AC")]
		public const int SAVEDATA_SLOT_MAX = 21;

		// Token: 0x0400C3CE RID: 50126
		[Token(Token = "0x40092AD")]
		public const float SAVEDATA_WAITTIME = 1f;

		// Token: 0x0400C3CF RID: 50127
		[Token(Token = "0x40092AE")]
		public const int PLAYER_NAME_LENGTH = 32;

		// Token: 0x0400C3D0 RID: 50128
		[Token(Token = "0x40092AF")]
		public const int FARM_NAME_LENGTH = 32;

		// Token: 0x0400C3D1 RID: 50129
		[Token(Token = "0x40092B0")]
		public const int MONSTER_NAME_LENGTH = 32;

		// Token: 0x0400C3D2 RID: 50130
		[Token(Token = "0x40092B1")]
		public const int MONSTERFARM_NAME_LENGTH = 32;
	}
}
