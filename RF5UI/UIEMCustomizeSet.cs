using System;
using Define;
using Il2CppDummyDll;

namespace RF5UI
{
	// Token: 0x02000E8E RID: 3726
	[Token(Token = "0x200098C")]
	public class UIEMCustomizeSet
	{
		// Token: 0x06006176 RID: 24950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050B1")]
		[Address(RVA = "0x1F2D410", Offset = "0x1F2D511", VA = "0x1F2D410")]
		public UIEMCustomizeSet()
		{
		}

		// Token: 0x0400C11F RID: 49439
		[Token(Token = "0x40090BF")]
		[FieldOffset(Offset = "0x10")]
		public int no;

		// Token: 0x0400C120 RID: 49440
		[Token(Token = "0x40090C0")]
		[FieldOffset(Offset = "0x14")]
		public UIEMDefine.EMCategory EMCategory;

		// Token: 0x0400C121 RID: 49441
		[Token(Token = "0x40090C1")]
		[FieldOffset(Offset = "0x18")]
		public bool actived;
	}
}
