using System;
using Il2CppDummyDll;

namespace Define
{
	// Token: 0x0200127A RID: 4730
	[Token(Token = "0x2000C49")]
	[Flags]
	public enum BadStatus
	{
		// Token: 0x0401B169 RID: 110953
		[Token(Token = "0x4017BAC")]
		None = 0,
		// Token: 0x0401B16A RID: 110954
		[Token(Token = "0x4017BAD")]
		Poison = 1,
		// Token: 0x0401B16B RID: 110955
		[Token(Token = "0x4017BAE")]
		Seal = 2,
		// Token: 0x0401B16C RID: 110956
		[Token(Token = "0x4017BAF")]
		Paralysis = 4,
		// Token: 0x0401B16D RID: 110957
		[Token(Token = "0x4017BB0")]
		Sleep = 8,
		// Token: 0x0401B16E RID: 110958
		[Token(Token = "0x4017BB1")]
		Tire = 16,
		// Token: 0x0401B16F RID: 110959
		[Token(Token = "0x4017BB2")]
		Sick = 32,
		// Token: 0x0401B170 RID: 110960
		[Token(Token = "0x4017BB3")]
		Stun = 64,
		// Token: 0x0401B171 RID: 110961
		[Token(Token = "0x4017BB4")]
		Death = 128,
		// Token: 0x0401B172 RID: 110962
		[Token(Token = "0x4017BB5")]
		All = 255
	}
}
