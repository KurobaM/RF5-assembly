using System;
using Il2CppDummyDll;

namespace RF5Input
{
	// Token: 0x0200103D RID: 4157
	[Token(Token = "0x2000A8C")]
	public class PadData
	{
		// Token: 0x0600687B RID: 26747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x21716F0", Offset = "0x21717F1", VA = "0x21716F0")]
		public void Clear()
		{
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005700")]
		[Address(RVA = "0x2172CD0", Offset = "0x2172DD1", VA = "0x2172CD0")]
		public PadData()
		{
		}

		// Token: 0x040170E4 RID: 94436
		[Token(Token = "0x4013D62")]
		[FieldOffset(Offset = "0x10")]
		public Key PushData;

		// Token: 0x040170E5 RID: 94437
		[Token(Token = "0x4013D63")]
		[FieldOffset(Offset = "0x14")]
		public Key EdgeData;

		// Token: 0x040170E6 RID: 94438
		[Token(Token = "0x4013D64")]
		[FieldOffset(Offset = "0x18")]
		public Key EndData;

		// Token: 0x040170E7 RID: 94439
		[Token(Token = "0x4013D65")]
		[FieldOffset(Offset = "0x1C")]
		public Key RepeatData;

		// Token: 0x040170E8 RID: 94440
		[Token(Token = "0x4013D66")]
		[FieldOffset(Offset = "0x20")]
		public float AnalogRightX;

		// Token: 0x040170E9 RID: 94441
		[Token(Token = "0x4013D67")]
		[FieldOffset(Offset = "0x24")]
		public float AnalogRightY;

		// Token: 0x040170EA RID: 94442
		[Token(Token = "0x4013D68")]
		[FieldOffset(Offset = "0x28")]
		public float AnalogLeftX;

		// Token: 0x040170EB RID: 94443
		[Token(Token = "0x4013D69")]
		[FieldOffset(Offset = "0x2C")]
		public float AnalogLeftY;
	}
}
