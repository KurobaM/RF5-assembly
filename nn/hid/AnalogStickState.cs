using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200153A RID: 5434
	[Token(Token = "0x2000EEB")]
	public struct AnalogStickState
	{
		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x0002B968 File Offset: 0x00029B68
		[Token(Token = "0x17000B48")]
		public float fx
		{
			[Token(Token = "0x600677C")]
			[Address(RVA = "0x3660D0", Offset = "0x3661D1", VA = "0x3660D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06007B75 RID: 31605 RVA: 0x0002B980 File Offset: 0x00029B80
		[Token(Token = "0x17000B49")]
		public float fy
		{
			[Token(Token = "0x600677D")]
			[Address(RVA = "0x3660F0", Offset = "0x3661F1", VA = "0x3660F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600677E")]
		[Address(RVA = "0x366110", Offset = "0x366211", VA = "0x366110")]
		public void Clear()
		{
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600677F")]
		[Address(RVA = "0x366120", Offset = "0x366221", VA = "0x366120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BE93 RID: 114323
		[Token(Token = "0x40187D9")]
		public const int Max = 32767;

		// Token: 0x0401BE94 RID: 114324
		[Token(Token = "0x40187DA")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0401BE95 RID: 114325
		[Token(Token = "0x40187DB")]
		[FieldOffset(Offset = "0x4")]
		public int y;
	}
}
