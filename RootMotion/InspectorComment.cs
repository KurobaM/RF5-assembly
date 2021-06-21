using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C9B RID: 3227
	[Token(Token = "0x2000841")]
	public class InspectorComment : PropertyAttribute
	{
		// Token: 0x06005318 RID: 21272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x27D6B50", Offset = "0x27D6C51", VA = "0x27D6B50")]
		public InspectorComment(string name)
		{
		}

		// Token: 0x06005319 RID: 21273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x27D6BE0", Offset = "0x27D6CE1", VA = "0x27D6BE0")]
		public InspectorComment(string name, string color)
		{
		}

		// Token: 0x0400B1FC RID: 45564
		[Token(Token = "0x4008581")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400B1FD RID: 45565
		[Token(Token = "0x4008582")]
		[FieldOffset(Offset = "0x20")]
		public string color;
	}
}
