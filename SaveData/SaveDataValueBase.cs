using System;
using BinaryStream;
using Il2CppDummyDll;

namespace SaveData
{
	// Token: 0x02000EF1 RID: 3825
	[Token(Token = "0x20009CB")]
	public abstract class SaveDataValueBase
	{
		// Token: 0x06006434 RID: 25652
		[Token(Token = "0x6005340")]
		public abstract void Initialize();

		// Token: 0x06006435 RID: 25653
		[Token(Token = "0x6005341")]
		public abstract void BeforeSave();

		// Token: 0x06006436 RID: 25654
		[Token(Token = "0x6005342")]
		public abstract void AfterLoad();

		// Token: 0x06006437 RID: 25655
		[Token(Token = "0x6005343")]
		public abstract void Writer(BinaryWriter writer);

		// Token: 0x06006438 RID: 25656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005344")]
		[Address(RVA = "0x21D2980", Offset = "0x21D2A81", VA = "0x21D2980")]
		protected SaveDataValueBase()
		{
		}
	}
}
