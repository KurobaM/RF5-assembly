using System;
using Il2CppDummyDll;

namespace nn
{
	// Token: 0x020014E5 RID: 5349
	[Token(Token = "0x2000EA8")]
	public struct ErrorRange
	{
		// Token: 0x060079E0 RID: 31200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006682")]
		[Address(RVA = "0x363880", Offset = "0x363981", VA = "0x363880")]
		internal ErrorRange(int Module, int DescriptionBegin, int DescriptionEnd)
		{
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x060079E1 RID: 31201 RVA: 0x0002A7E0 File Offset: 0x000289E0
		[Token(Token = "0x17000B34")]
		public int Module
		{
			[Token(Token = "0x6006683")]
			[Address(RVA = "0x363890", Offset = "0x363991", VA = "0x363890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x0002A7F8 File Offset: 0x000289F8
		[Token(Token = "0x17000B35")]
		public int DescriptionBegin
		{
			[Token(Token = "0x6006684")]
			[Address(RVA = "0x3638A0", Offset = "0x3639A1", VA = "0x3638A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x060079E3 RID: 31203 RVA: 0x0002A810 File Offset: 0x00028A10
		[Token(Token = "0x17000B36")]
		public int DescriptionEnd
		{
			[Token(Token = "0x6006685")]
			[Address(RVA = "0x3638B0", Offset = "0x3639B1", VA = "0x3638B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060079E4 RID: 31204 RVA: 0x0002A828 File Offset: 0x00028A28
		[Token(Token = "0x6006686")]
		[Address(RVA = "0x3638C0", Offset = "0x3639C1", VA = "0x3638C0")]
		public bool Includes(Result result)
		{
			return default(bool);
		}

		// Token: 0x0401BC9C RID: 113820
		[Token(Token = "0x401868E")]
		[FieldOffset(Offset = "0x0")]
		private int _module;

		// Token: 0x0401BC9D RID: 113821
		[Token(Token = "0x401868F")]
		[FieldOffset(Offset = "0x4")]
		private int _descriptionBegin;

		// Token: 0x0401BC9E RID: 113822
		[Token(Token = "0x4018690")]
		[FieldOffset(Offset = "0x8")]
		private int _descriptionEnd;
	}
}
