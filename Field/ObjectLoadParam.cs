using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001109 RID: 4361
	[Token(Token = "0x2000AFB")]
	public class ObjectLoadParam
	{
		// Token: 0x06006E53 RID: 28243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0x202ED10", Offset = "0x202EE11", VA = "0x202ED10")]
		public ObjectLoadParam()
		{
		}

		// Token: 0x040180F2 RID: 98546
		[Token(Token = "0x4014BC8")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x040180F3 RID: 98547
		[Token(Token = "0x4014BC9")]
		[FieldOffset(Offset = "0x14")]
		public bool visible;

		// Token: 0x040180F4 RID: 98548
		[Token(Token = "0x4014BCA")]
		[FieldOffset(Offset = "0x18")]
		public Action<GameObject> action;
	}
}
