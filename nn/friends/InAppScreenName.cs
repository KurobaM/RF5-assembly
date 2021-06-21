using System;
using Il2CppDummyDll;

namespace nn.friends
{
	// Token: 0x020015C9 RID: 5577
	[Token(Token = "0x2000F52")]
	public struct InAppScreenName
	{
		// Token: 0x06007EC5 RID: 32453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692A")]
		[Address(RVA = "0x365B90", Offset = "0x365C91", VA = "0x365B90")]
		public InAppScreenName(string name, string language = "")
		{
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007EC7 RID: 32455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B8A")]
		public string Name
		{
			[Token(Token = "0x600692B")]
			[Address(RVA = "0x365BA0", Offset = "0x365CA1", VA = "0x365BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600692C")]
			[Address(RVA = "0x365C30", Offset = "0x365D31", VA = "0x365C30")]
			set
			{
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06007EC8 RID: 32456 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007EC9 RID: 32457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B8B")]
		public string Language
		{
			[Token(Token = "0x600692D")]
			[Address(RVA = "0x365C40", Offset = "0x365D41", VA = "0x365C40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600692E")]
			[Address(RVA = "0x365C50", Offset = "0x365D51", VA = "0x365C50")]
			set
			{
			}
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600692F")]
		[Address(RVA = "0x365C60", Offset = "0x365D61", VA = "0x365C60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C118 RID: 114968
		[Token(Token = "0x4018971")]
		[FieldOffset(Offset = "0x0")]
		private byte[] name;

		// Token: 0x0401C119 RID: 114969
		[Token(Token = "0x4018972")]
		[FieldOffset(Offset = "0x8")]
		private char[] language;
	}
}
