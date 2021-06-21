using System;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015E4 RID: 5604
	[Token(Token = "0x2000F6A")]
	public struct ConsumableId
	{
		// Token: 0x06007FA8 RID: 32680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FC")]
		[Address(RVA = "0x364550", Offset = "0x364651", VA = "0x364550")]
		public ConsumableId(string _value)
		{
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069FD")]
		[Address(RVA = "0x364560", Offset = "0x364661", VA = "0x364560", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C15C RID: 115036
		[Token(Token = "0x401899E")]
		public const int MaxStringLength = 16;

		// Token: 0x0401C15D RID: 115037
		[Token(Token = "0x401899F")]
		[FieldOffset(Offset = "0x0")]
		public string value;
	}
}
