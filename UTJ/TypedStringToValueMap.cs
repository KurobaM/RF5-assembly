using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UTJ
{
	// Token: 0x02000C0F RID: 3087
	[Token(Token = "0x20007F1")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x147600", Offset = "0x147701")]
	public class TypedStringToValueMap
	{
		// Token: 0x06004E94 RID: 20116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600416D")]
		[Address(RVA = "0x23B6720", Offset = "0x23B6821", VA = "0x23B6720")]
		public TypedStringToValueMap(Type inputType, Dictionary<string, object> inputMap, object inputDefaultValue)
		{
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600416E")]
		public static TypedStringToValueMap Create<T>(Dictionary<string, T> inputMap, T inputDefaultValue)
		{
			return null;
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600416F")]
		public static TypedStringToValueMap Create<T>(Dictionary<string, T> inputMap)
		{
			return null;
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06004E97 RID: 20119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004E98 RID: 20120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FD")]
		public Type Type
		{
			[Token(Token = "0x6004170")]
			[Address(RVA = "0x23B6790", Offset = "0x23B6891", VA = "0x23B6790")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8EF0", Offset = "0x1A8FF1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004171")]
			[Address(RVA = "0x23B67A0", Offset = "0x23B68A1", VA = "0x23B67A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8F00", Offset = "0x1A9001")]
			private set
			{
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06004E99 RID: 20121 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004E9A RID: 20122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FE")]
		public object DefaultValue
		{
			[Token(Token = "0x6004172")]
			[Address(RVA = "0x23B67B0", Offset = "0x23B68B1", VA = "0x23B67B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8F10", Offset = "0x1A9011")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004173")]
			[Address(RVA = "0x23B67C0", Offset = "0x23B68C1", VA = "0x23B67C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8F20", Offset = "0x1A9021")]
			private set
			{
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06004E9B RID: 20123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FF")]
		public object Item
		{
			[Token(Token = "0x6004174")]
			[Address(RVA = "0x23B43B0", Offset = "0x23B44B1", VA = "0x23B43B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004175")]
		[Address(RVA = "0x23B67D0", Offset = "0x23B68D1", VA = "0x23B67D0")]
		public string GetKey(object value)
		{
			return null;
		}

		// Token: 0x0400AFB0 RID: 44976
		[Token(Token = "0x400842E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x176E90", Offset = "0x176F91")]
		private Type <Type>k__BackingField;

		// Token: 0x0400AFB1 RID: 44977
		[Token(Token = "0x400842F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x176EA0", Offset = "0x176FA1")]
		private object <DefaultValue>k__BackingField;

		// Token: 0x0400AFB2 RID: 44978
		[Token(Token = "0x4008430")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, object> map;

		// Token: 0x02000C10 RID: 3088
		[Token(Token = "0x2001399")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1595B0", Offset = "0x1596B1")]
		[Serializable]
		private sealed class <>c__1<T>
		{
			// Token: 0x06004E9E RID: 20126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077F6")]
			public <>c__1()
			{
			}

			// Token: 0x06004E9F RID: 20127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077F7")]
			internal string <Create>b__1_0(KeyValuePair<string, T> item)
			{
				return null;
			}

			// Token: 0x06004EA0 RID: 20128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077F8")]
			internal object <Create>b__1_1(KeyValuePair<string, T> item)
			{
				return null;
			}

			// Token: 0x0400AFB3 RID: 44979
			[Token(Token = "0x401B7CC")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TypedStringToValueMap.<>c__1<T> <>9;

			// Token: 0x0400AFB4 RID: 44980
			[Token(Token = "0x401B7CD")]
			[FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<string, T>, string> <>9__1_0;

			// Token: 0x0400AFB5 RID: 44981
			[Token(Token = "0x401B7CE")]
			[FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<string, T>, object> <>9__1_1;
		}

		// Token: 0x02000C11 RID: 3089
		[Token(Token = "0x200139A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1595C0", Offset = "0x1596C1")]
		[Serializable]
		private sealed class <>c__2<T>
		{
			// Token: 0x06004EA2 RID: 20130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077FA")]
			public <>c__2()
			{
			}

			// Token: 0x06004EA3 RID: 20131 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077FB")]
			internal string <Create>b__2_0(KeyValuePair<string, T> item)
			{
				return null;
			}

			// Token: 0x06004EA4 RID: 20132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077FC")]
			internal object <Create>b__2_1(KeyValuePair<string, T> item)
			{
				return null;
			}

			// Token: 0x0400AFB6 RID: 44982
			[Token(Token = "0x401B7CF")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TypedStringToValueMap.<>c__2<T> <>9;

			// Token: 0x0400AFB7 RID: 44983
			[Token(Token = "0x401B7D0")]
			[FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<string, T>, string> <>9__2_0;

			// Token: 0x0400AFB8 RID: 44984
			[Token(Token = "0x401B7D1")]
			[FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<string, T>, object> <>9__2_1;
		}

		// Token: 0x02000C12 RID: 3090
		[Token(Token = "0x200139B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1595D0", Offset = "0x1596D1")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004EA5 RID: 20133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077FD")]
			[Address(RVA = "0x23B6990", Offset = "0x23B6A91", VA = "0x23B6990")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06004EA6 RID: 20134 RVA: 0x00019128 File Offset: 0x00017328
			[Token(Token = "0x60077FE")]
			[Address(RVA = "0x23B6A70", Offset = "0x23B6B71", VA = "0x23B6A70")]
			internal bool <GetKey>b__0(KeyValuePair<string, object> item)
			{
				return default(bool);
			}

			// Token: 0x0400AFB9 RID: 44985
			[Token(Token = "0x401B7D2")]
			[FieldOffset(Offset = "0x10")]
			public object value;
		}

		// Token: 0x02000C13 RID: 3091
		[Token(Token = "0x200139C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1595E0", Offset = "0x1596E1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004EA8 RID: 20136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007800")]
			[Address(RVA = "0x23B6A10", Offset = "0x23B6B11", VA = "0x23B6A10")]
			public <>c()
			{
			}

			// Token: 0x06004EA9 RID: 20137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007801")]
			[Address(RVA = "0x23B6A20", Offset = "0x23B6B21", VA = "0x23B6A20")]
			internal string <GetKey>b__13_1(KeyValuePair<string, object> item)
			{
				return null;
			}

			// Token: 0x0400AFBA RID: 44986
			[Token(Token = "0x401B7D3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly TypedStringToValueMap.<>c <>9;

			// Token: 0x0400AFBB RID: 44987
			[Token(Token = "0x401B7D4")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, object>, string> <>9__13_1;
		}
	}
}
