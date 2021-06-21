using System;
using Il2CppDummyDll;

namespace nn.ec
{
	// Token: 0x020015E3 RID: 5603
	[Token(Token = "0x2000F69")]
	public struct CourseId
	{
		// Token: 0x06007FA6 RID: 32678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069FA")]
		[Address(RVA = "0x364680", Offset = "0x364781", VA = "0x364680")]
		public CourseId(string _value)
		{
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60069FB")]
		[Address(RVA = "0x364690", Offset = "0x364791", VA = "0x364690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C15A RID: 115034
		[Token(Token = "0x401899C")]
		public const int MaxStringLength = 16;

		// Token: 0x0401C15B RID: 115035
		[Token(Token = "0x401899D")]
		[FieldOffset(Offset = "0x0")]
		public string value;
	}
}
