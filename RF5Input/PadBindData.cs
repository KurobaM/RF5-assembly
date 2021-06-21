using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5Input
{
	// Token: 0x0200103C RID: 4156
	[Token(Token = "0x2000A8B")]
	[Serializable]
	public class PadBindData
	{
		// Token: 0x06006879 RID: 26745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FD")]
		[Address(RVA = "0x2172CE0", Offset = "0x2172DE1", VA = "0x2172CE0")]
		public PadBindData()
		{
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x2172EF0", Offset = "0x2172FF1", VA = "0x2172EF0")]
		public PadBindData(PadBindData copy)
		{
		}

		// Token: 0x040170E2 RID: 94434
		[Token(Token = "0x4013D60")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string JoystickName;

		// Token: 0x040170E3 RID: 94435
		[Token(Token = "0x4013D61")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public BindPair[] Bind;
	}
}
