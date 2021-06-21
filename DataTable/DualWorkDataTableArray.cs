using System;
using Il2CppDummyDll;

namespace DataTable
{
	// Token: 0x02001166 RID: 4454
	[Token(Token = "0x2000B3E")]
	[Serializable]
	public class DualWorkDataTableArray : DataTableArrayBase<int, DualWorkDataTable, SerializeDualWorkDataTable>
	{
		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06007084 RID: 28804 RVA: 0x00026D60 File Offset: 0x00024F60
		// (set) Token: 0x06007085 RID: 28805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B21")]
		public int Min
		{
			[Token(Token = "0x6005D4B")]
			[Address(RVA = "0x1DA3E20", Offset = "0x1DA3F21", VA = "0x1DA3E20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF3C0", Offset = "0x1AF4C1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D4C")]
			[Address(RVA = "0x1DA3E30", Offset = "0x1DA3F31", VA = "0x1DA3E30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF3D0", Offset = "0x1AF4D1")]
			private set
			{
			}
		}

		// Token: 0x17000E46 RID: 3654
		// (get) Token: 0x06007086 RID: 28806 RVA: 0x00026D78 File Offset: 0x00024F78
		// (set) Token: 0x06007087 RID: 28807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B22")]
		public int Max
		{
			[Token(Token = "0x6005D4D")]
			[Address(RVA = "0x1DA3E40", Offset = "0x1DA3F41", VA = "0x1DA3E40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF3E0", Offset = "0x1AF4E1")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005D4E")]
			[Address(RVA = "0x1DA3E50", Offset = "0x1DA3F51", VA = "0x1DA3E50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF3F0", Offset = "0x1AF4F1")]
			private set
			{
			}
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0x1DA3E60", Offset = "0x1DA3F61", VA = "0x1DA3E60", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D50")]
		[Address(RVA = "0x1DA4050", Offset = "0x1DA4151", VA = "0x1DA4050")]
		public DualWorkDataTableArray()
		{
		}

		// Token: 0x040182D1 RID: 99025
		[Token(Token = "0x4014D45")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1817B0", Offset = "0x1818B1")]
		private int <Min>k__BackingField;

		// Token: 0x040182D2 RID: 99026
		[Token(Token = "0x4014D46")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1817C0", Offset = "0x1818C1")]
		private int <Max>k__BackingField;

		// Token: 0x02001167 RID: 4455
		[Token(Token = "0x2001594")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A2C0", Offset = "0x15A3C1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600708B RID: 28811 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007DE9")]
			[Address(RVA = "0x1DA4110", Offset = "0x1DA4211", VA = "0x1DA4110")]
			public <>c()
			{
			}

			// Token: 0x0600708C RID: 28812 RVA: 0x00026D90 File Offset: 0x00024F90
			[Token(Token = "0x6007DEA")]
			[Address(RVA = "0x1DA4120", Offset = "0x1DA4221", VA = "0x1DA4120")]
			internal int <Init>b__8_0(SerializeDualWorkDataTable d)
			{
				return 0;
			}

			// Token: 0x0600708D RID: 28813 RVA: 0x00026DA8 File Offset: 0x00024FA8
			[Token(Token = "0x6007DEB")]
			[Address(RVA = "0x1DA4140", Offset = "0x1DA4241", VA = "0x1DA4140")]
			internal int <Init>b__8_1(SerializeDualWorkDataTable d)
			{
				return 0;
			}

			// Token: 0x040182D3 RID: 99027
			[Token(Token = "0x401C198")]
			[FieldOffset(Offset = "0x0")]
			public static readonly DualWorkDataTableArray.<>c <>9;

			// Token: 0x040182D4 RID: 99028
			[Token(Token = "0x401C199")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SerializeDualWorkDataTable, int> <>9__8_0;

			// Token: 0x040182D5 RID: 99029
			[Token(Token = "0x401C19A")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SerializeDualWorkDataTable, int> <>9__8_1;
		}
	}
}
