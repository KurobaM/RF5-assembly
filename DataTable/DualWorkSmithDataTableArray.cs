using System;
using Il2CppDummyDll;

namespace DataTable
{
	// Token: 0x02001169 RID: 4457
	[Token(Token = "0x2000B40")]
	[Serializable]
	public class DualWorkSmithDataTableArray : DataTableArrayBase<int, DualWorkSmithDataTable, SerializeDualWorkSmithDataTable>
	{
		// Token: 0x17000E47 RID: 3655
		// (get) Token: 0x0600708F RID: 28815 RVA: 0x00026DC0 File Offset: 0x00024FC0
		// (set) Token: 0x06007090 RID: 28816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B23")]
		public int Min
		{
			[Token(Token = "0x6005D52")]
			[Address(RVA = "0x1DA4160", Offset = "0x1DA4261", VA = "0x1DA4160")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF400", Offset = "0x1AF501")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D53")]
			[Address(RVA = "0x1DA4170", Offset = "0x1DA4271", VA = "0x1DA4170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF410", Offset = "0x1AF511")]
			private set
			{
			}
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06007091 RID: 28817 RVA: 0x00026DD8 File Offset: 0x00024FD8
		// (set) Token: 0x06007092 RID: 28818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B24")]
		public int Max
		{
			[Token(Token = "0x6005D54")]
			[Address(RVA = "0x1DA4180", Offset = "0x1DA4281", VA = "0x1DA4180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF420", Offset = "0x1AF521")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D55")]
			[Address(RVA = "0x1DA4190", Offset = "0x1DA4291", VA = "0x1DA4190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF430", Offset = "0x1AF531")]
			private set
			{
			}
		}

		// Token: 0x06007093 RID: 28819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D56")]
		[Address(RVA = "0x1DA41A0", Offset = "0x1DA42A1", VA = "0x1DA41A0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06007094 RID: 28820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D57")]
		[Address(RVA = "0x1DA4390", Offset = "0x1DA4491", VA = "0x1DA4390")]
		public DualWorkSmithDataTableArray()
		{
		}

		// Token: 0x040182D6 RID: 99030
		[Token(Token = "0x4014D47")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1817D0", Offset = "0x1818D1")]
		private int <Min>k__BackingField;

		// Token: 0x040182D7 RID: 99031
		[Token(Token = "0x4014D48")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1817E0", Offset = "0x1818E1")]
		private int <Max>k__BackingField;

		// Token: 0x0200116A RID: 4458
		[Token(Token = "0x2001595")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A2D0", Offset = "0x15A3D1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007096 RID: 28822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DED")]
			[Address(RVA = "0x1DA4450", Offset = "0x1DA4551", VA = "0x1DA4450")]
			public <>c()
			{
			}

			// Token: 0x06007097 RID: 28823 RVA: 0x00026DF0 File Offset: 0x00024FF0
			[Token(Token = "0x6007DEE")]
			[Address(RVA = "0x1DA4460", Offset = "0x1DA4561", VA = "0x1DA4460")]
			internal int <Init>b__8_0(SerializeDualWorkSmithDataTable d)
			{
				return 0;
			}

			// Token: 0x06007098 RID: 28824 RVA: 0x00026E08 File Offset: 0x00025008
			[Token(Token = "0x6007DEF")]
			[Address(RVA = "0x1DA4480", Offset = "0x1DA4581", VA = "0x1DA4480")]
			internal int <Init>b__8_1(SerializeDualWorkSmithDataTable d)
			{
				return 0;
			}

			// Token: 0x040182D8 RID: 99032
			[Token(Token = "0x401C19B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DualWorkSmithDataTableArray.<>c <>9;

			// Token: 0x040182D9 RID: 99033
			[Token(Token = "0x401C19C")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SerializeDualWorkSmithDataTable, int> <>9__8_0;

			// Token: 0x040182DA RID: 99034
			[Token(Token = "0x401C19D")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SerializeDualWorkSmithDataTable, int> <>9__8_1;
		}
	}
}
