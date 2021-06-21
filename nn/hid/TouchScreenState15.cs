using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200159A RID: 5530
	[Token(Token = "0x2000F2B")]
	public struct TouchScreenState15
	{
		// Token: 0x06007D69 RID: 32105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006811")]
		[Address(RVA = "0x384B00", Offset = "0x384C01", VA = "0x384B00")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C07A RID: 114810
		[Token(Token = "0x401890B")]
		public const int TouchCount = 15;

		// Token: 0x0401C07B RID: 114811
		[Token(Token = "0x401890C")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C07C RID: 114812
		[Token(Token = "0x401890D")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C07D RID: 114813
		[Token(Token = "0x401890E")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C07E RID: 114814
		[Token(Token = "0x401890F")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState15.TouchStateArray15 touches;

		// Token: 0x0200159B RID: 5531
		[Token(Token = "0x20015C4")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A900", Offset = "0x15AA01")]
		public struct TouchStateArray15 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000F0A RID: 3850
			// (get) Token: 0x06007D6A RID: 32106 RVA: 0x0002CA00 File Offset: 0x0002AC00
			[Token(Token = "0x17000F41")]
			public int Length
			{
				[Token(Token = "0x6007F7D")]
				[Address(RVA = "0x384B10", Offset = "0x384C11", VA = "0x384B10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x06007D6B RID: 32107 RVA: 0x0002CA18 File Offset: 0x0002AC18
			// (set) Token: 0x06007D6C RID: 32108 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F42")]
			public TouchState Item
			{
				[Token(Token = "0x6007F7E")]
				[Address(RVA = "0x384B20", Offset = "0x384C21", VA = "0x384B20", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F7F")]
				[Address(RVA = "0x384B30", Offset = "0x384C31", VA = "0x384B30", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000F0C RID: 3852
			// (get) Token: 0x06007D6D RID: 32109 RVA: 0x0002CA30 File Offset: 0x0002AC30
			[Token(Token = "0x17000F43")]
			public int Count
			{
				[Token(Token = "0x6007F80")]
				[Address(RVA = "0x384B70", Offset = "0x384C71", VA = "0x384B70", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F0D RID: 3853
			// (get) Token: 0x06007D6E RID: 32110 RVA: 0x0002CA48 File Offset: 0x0002AC48
			[Token(Token = "0x17000F44")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F81")]
				[Address(RVA = "0x384B80", Offset = "0x384C81", VA = "0x384B80", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007D6F RID: 32111 RVA: 0x0002CA60 File Offset: 0x0002AC60
			[Token(Token = "0x6007F82")]
			[Address(RVA = "0x384B90", Offset = "0x384C91", VA = "0x384B90", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D70 RID: 32112 RVA: 0x0002CA78 File Offset: 0x0002AC78
			[Token(Token = "0x6007F83")]
			[Address(RVA = "0x384C80", Offset = "0x384D81", VA = "0x384C80", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007D71 RID: 32113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F84")]
			[Address(RVA = "0x384D60", Offset = "0x384E61", VA = "0x384D60", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007D72 RID: 32114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F85")]
			[Address(RVA = "0x384D70", Offset = "0x384E71", VA = "0x384D70", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D73 RID: 32115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F86")]
			[Address(RVA = "0x384D80", Offset = "0x384E81", VA = "0x384D80", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B7180", Offset = "0x1B7281")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D74 RID: 32116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F87")]
			[Address(RVA = "0x384E20", Offset = "0x384F21", VA = "0x384E20", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D75 RID: 32117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F88")]
			[Address(RVA = "0x384EC0", Offset = "0x384FC1", VA = "0x384EC0", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D76 RID: 32118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F89")]
			[Address(RVA = "0x384ED0", Offset = "0x384FD1", VA = "0x384ED0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D77 RID: 32119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F8A")]
			[Address(RVA = "0x384EE0", Offset = "0x384FE1", VA = "0x384EE0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D78 RID: 32120 RVA: 0x0002CA90 File Offset: 0x0002AC90
			[Token(Token = "0x6007F8B")]
			[Address(RVA = "0x384EF0", Offset = "0x384FF1", VA = "0x384EF0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D79 RID: 32121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F8C")]
			[Address(RVA = "0x384F00", Offset = "0x385001", VA = "0x384F00", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C07F RID: 114815
			[Token(Token = "0x401C336")]
			private const int _Length = 15;

			// Token: 0x0401C080 RID: 114816
			[Token(Token = "0x401C337")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C081 RID: 114817
			[Token(Token = "0x401C338")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C082 RID: 114818
			[Token(Token = "0x401C339")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C083 RID: 114819
			[Token(Token = "0x401C33A")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C084 RID: 114820
			[Token(Token = "0x401C33B")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C085 RID: 114821
			[Token(Token = "0x401C33C")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C086 RID: 114822
			[Token(Token = "0x401C33D")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C087 RID: 114823
			[Token(Token = "0x401C33E")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C088 RID: 114824
			[Token(Token = "0x401C33F")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C089 RID: 114825
			[Token(Token = "0x401C340")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0401C08A RID: 114826
			[Token(Token = "0x401C341")]
			[FieldOffset(Offset = "0x190")]
			private TouchState _value10;

			// Token: 0x0401C08B RID: 114827
			[Token(Token = "0x401C342")]
			[FieldOffset(Offset = "0x1B8")]
			private TouchState _value11;

			// Token: 0x0401C08C RID: 114828
			[Token(Token = "0x401C343")]
			[FieldOffset(Offset = "0x1E0")]
			private TouchState _value12;

			// Token: 0x0401C08D RID: 114829
			[Token(Token = "0x401C344")]
			[FieldOffset(Offset = "0x208")]
			private TouchState _value13;

			// Token: 0x0401C08E RID: 114830
			[Token(Token = "0x401C345")]
			[FieldOffset(Offset = "0x230")]
			private TouchState _value14;

			// Token: 0x0200159C RID: 5532
			[Token(Token = "0x200167E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AFD0", Offset = "0x15B0D1")]
			private sealed class <GetEnumerator>d__29 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D7A RID: 32122 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008162")]
				[Address(RVA = "0x2D6C8A0", Offset = "0x2D6C9A1", VA = "0x2D6C8A0")]
				[DebuggerHidden]
				public <GetEnumerator>d__29(int <>1__state)
				{
				}

				// Token: 0x06007D7B RID: 32123 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008163")]
				[Address(RVA = "0x2D6CB50", Offset = "0x2D6CC51", VA = "0x2D6CB50", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D7C RID: 32124 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
				[Token(Token = "0x6008164")]
				[Address(RVA = "0x2D6CB60", Offset = "0x2D6CC61", VA = "0x2D6CB60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000F0E RID: 3854
				// (get) Token: 0x06007D7D RID: 32125 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
				[Token(Token = "0x17000F87")]
				private TouchState Current
				{
					[Token(Token = "0x6008165")]
					[Address(RVA = "0x2D6CDD0", Offset = "0x2D6CED1", VA = "0x2D6CDD0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D7E RID: 32126 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008166")]
				[Address(RVA = "0x2D6CDF0", Offset = "0x2D6CEF1", VA = "0x2D6CDF0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000F0F RID: 3855
				// (get) Token: 0x06007D7F RID: 32127 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F88")]
				private object Current
				{
					[Token(Token = "0x6008167")]
					[Address(RVA = "0x2D6CE50", Offset = "0x2D6CF51", VA = "0x2D6CE50", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C08F RID: 114831
				[Token(Token = "0x401C49C")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C090 RID: 114832
				[Token(Token = "0x401C49D")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C091 RID: 114833
				[Token(Token = "0x401C49E")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState15.TouchStateArray15 <>4__this;
			}
		}
	}
}
