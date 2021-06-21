using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Input
{
	// Token: 0x0200103B RID: 4155
	[Token(Token = "0x2000A8A")]
	[Serializable]
	public class BindPair
	{
		// Token: 0x06006878 RID: 26744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FC")]
		[Address(RVA = "0x21700E0", Offset = "0x21701E1", VA = "0x21700E0")]
		public BindPair()
		{
		}

		// Token: 0x040170DB RID: 94427
		[Token(Token = "0x4013D59")]
		[FieldOffset(Offset = "0x10")]
		public KeyType Key;

		// Token: 0x040170DC RID: 94428
		[Token(Token = "0x4013D5A")]
		[FieldOffset(Offset = "0x14")]
		public KeyCode Code1;

		// Token: 0x040170DD RID: 94429
		[Token(Token = "0x4013D5B")]
		[FieldOffset(Offset = "0x18")]
		public KeyCode Code2;

		// Token: 0x040170DE RID: 94430
		[Token(Token = "0x4013D5C")]
		[FieldOffset(Offset = "0x1C")]
		public AxisCode Axis1;

		// Token: 0x040170DF RID: 94431
		[Token(Token = "0x4013D5D")]
		[FieldOffset(Offset = "0x20")]
		public AxisCode Axis2;

		// Token: 0x040170E0 RID: 94432
		[Token(Token = "0x4013D5E")]
		[FieldOffset(Offset = "0x24")]
		public bool Plus1;

		// Token: 0x040170E1 RID: 94433
		[Token(Token = "0x4013D5F")]
		[FieldOffset(Offset = "0x25")]
		public bool Plus2;
	}
}
