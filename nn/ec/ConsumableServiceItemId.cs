using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015D8 RID: 5592
	[Token(Token = "0x2000F60")]
	public struct ConsumableServiceItemId
	{
		// Token: 0x06007F50 RID: 32592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069B5")]
		[Address(RVA = "0x3645C0", Offset = "0x3646C1", VA = "0x3645C0")]
		public ConsumableServiceItemId(string _value)
		{
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069B6")]
		[Address(RVA = "0x3645D0", Offset = "0x3646D1", VA = "0x3645D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x0002D990 File Offset: 0x0002BB90
		[Token(Token = "0x60069B7")]
		[Address(RVA = "0x3645E0", Offset = "0x3646E1", VA = "0x3645E0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06007F53 RID: 32595
		[Token(Token = "0x60069B8")]
		[Address(RVA = "0x28530D0", Offset = "0x28531D1", VA = "0x28530D0")]
		[PreserveSig]
		private static extern bool IsValid(ConsumableServiceItemId itemId);

		// Token: 0x0401C142 RID: 115010
		[Token(Token = "0x4018989")]
		public const int Length = 16;

		// Token: 0x0401C143 RID: 115011
		[Token(Token = "0x401898A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string value;
	}
}
