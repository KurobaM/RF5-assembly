using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C9E RID: 3230
	[Token(Token = "0x2000844")]
	public class LargeHeader : PropertyAttribute
	{
		// Token: 0x06005339 RID: 21305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x27D7D20", Offset = "0x27D7E21", VA = "0x27D7D20")]
		public LargeHeader(string name)
		{
		}

		// Token: 0x0600533A RID: 21306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x27D7DB0", Offset = "0x27D7EB1", VA = "0x27D7DB0")]
		public LargeHeader(string name, string color)
		{
		}

		// Token: 0x0400B21A RID: 45594
		[Token(Token = "0x400859F")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400B21B RID: 45595
		[Token(Token = "0x40085A0")]
		[FieldOffset(Offset = "0x20")]
		public string color;
	}
}
