using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001591 RID: 5521
	[Token(Token = "0x2000F28")]
	public struct TouchScreenState12
	{
		// Token: 0x06007D24 RID: 32036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680E")]
		[Address(RVA = "0x383ED0", Offset = "0x383FD1", VA = "0x383ED0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C038 RID: 114744
		[Token(Token = "0x40188FC")]
		public const int TouchCount = 12;

		// Token: 0x0401C039 RID: 114745
		[Token(Token = "0x40188FD")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C03A RID: 114746
		[Token(Token = "0x40188FE")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C03B RID: 114747
		[Token(Token = "0x40188FF")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C03C RID: 114748
		[Token(Token = "0x4018900")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState12.TouchStateArray12 touches;

		// Token: 0x02001592 RID: 5522
		[Token(Token = "0x20015C1")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A840", Offset = "0x15A941")]
		public struct TouchStateArray12 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x06007D25 RID: 32037 RVA: 0x0002C778 File Offset: 0x0002A978
			[Token(Token = "0x17000F35")]
			public int Length
			{
				[Token(Token = "0x6007F4D")]
				[Address(RVA = "0x383EE0", Offset = "0x383FE1", VA = "0x383EE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EF9 RID: 3833
			// (get) Token: 0x06007D26 RID: 32038 RVA: 0x0002C790 File Offset: 0x0002A990
			// (set) Token: 0x06007D27 RID: 32039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F36")]
			public TouchState Item
			{
				[Token(Token = "0x6007F4E")]
				[Address(RVA = "0x383EF0", Offset = "0x383FF1", VA = "0x383EF0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F4F")]
				[Address(RVA = "0x383F00", Offset = "0x384001", VA = "0x383F00", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EFA RID: 3834
			// (get) Token: 0x06007D28 RID: 32040 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
			[Token(Token = "0x17000F37")]
			public int Count
			{
				[Token(Token = "0x6007F50")]
				[Address(RVA = "0x383F40", Offset = "0x384041", VA = "0x383F40", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EFB RID: 3835
			// (get) Token: 0x06007D29 RID: 32041 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
			[Token(Token = "0x17000F38")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F51")]
				[Address(RVA = "0x383F50", Offset = "0x384051", VA = "0x383F50", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007D2A RID: 32042 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
			[Token(Token = "0x6007F52")]
			[Address(RVA = "0x383F60", Offset = "0x384061", VA = "0x383F60", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D2B RID: 32043 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
			[Token(Token = "0x6007F53")]
			[Address(RVA = "0x384050", Offset = "0x384151", VA = "0x384050", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007D2C RID: 32044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F54")]
			[Address(RVA = "0x384130", Offset = "0x384231", VA = "0x384130", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007D2D RID: 32045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F55")]
			[Address(RVA = "0x384140", Offset = "0x384241", VA = "0x384140", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D2E RID: 32046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F56")]
			[Address(RVA = "0x384150", Offset = "0x384251", VA = "0x384150", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B7030", Offset = "0x1B7131")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D2F RID: 32047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F57")]
			[Address(RVA = "0x3841F0", Offset = "0x3842F1", VA = "0x3841F0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D30 RID: 32048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F58")]
			[Address(RVA = "0x384290", Offset = "0x384391", VA = "0x384290", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D31 RID: 32049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F59")]
			[Address(RVA = "0x3842A0", Offset = "0x3843A1", VA = "0x3842A0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D32 RID: 32050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F5A")]
			[Address(RVA = "0x3842B0", Offset = "0x3843B1", VA = "0x3842B0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D33 RID: 32051 RVA: 0x0002C808 File Offset: 0x0002AA08
			[Token(Token = "0x6007F5B")]
			[Address(RVA = "0x3842C0", Offset = "0x3843C1", VA = "0x3842C0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D34 RID: 32052 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F5C")]
			[Address(RVA = "0x3842D0", Offset = "0x3843D1", VA = "0x3842D0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C03D RID: 114749
			[Token(Token = "0x401C30C")]
			private const int _Length = 12;

			// Token: 0x0401C03E RID: 114750
			[Token(Token = "0x401C30D")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C03F RID: 114751
			[Token(Token = "0x401C30E")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C040 RID: 114752
			[Token(Token = "0x401C30F")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C041 RID: 114753
			[Token(Token = "0x401C310")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C042 RID: 114754
			[Token(Token = "0x401C311")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C043 RID: 114755
			[Token(Token = "0x401C312")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C044 RID: 114756
			[Token(Token = "0x401C313")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C045 RID: 114757
			[Token(Token = "0x401C314")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C046 RID: 114758
			[Token(Token = "0x401C315")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C047 RID: 114759
			[Token(Token = "0x401C316")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0401C048 RID: 114760
			[Token(Token = "0x401C317")]
			[FieldOffset(Offset = "0x190")]
			private TouchState _value10;

			// Token: 0x0401C049 RID: 114761
			[Token(Token = "0x401C318")]
			[FieldOffset(Offset = "0x1B8")]
			private TouchState _value11;

			// Token: 0x02001593 RID: 5523
			[Token(Token = "0x200167B")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AFA0", Offset = "0x15B0A1")]
			private sealed class <GetEnumerator>d__26 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D35 RID: 32053 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008150")]
				[Address(RVA = "0x2D68420", Offset = "0x2D68521", VA = "0x2D68420")]
				[DebuggerHidden]
				public <GetEnumerator>d__26(int <>1__state)
				{
				}

				// Token: 0x06007D36 RID: 32054 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008151")]
				[Address(RVA = "0x2D686D0", Offset = "0x2D687D1", VA = "0x2D686D0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D37 RID: 32055 RVA: 0x0002C820 File Offset: 0x0002AA20
				[Token(Token = "0x6008152")]
				[Address(RVA = "0x2D686E0", Offset = "0x2D687E1", VA = "0x2D686E0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EFC RID: 3836
				// (get) Token: 0x06007D38 RID: 32056 RVA: 0x0002C838 File Offset: 0x0002AA38
				[Token(Token = "0x17000F81")]
				private TouchState Current
				{
					[Token(Token = "0x6008153")]
					[Address(RVA = "0x2D688D0", Offset = "0x2D689D1", VA = "0x2D688D0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D39 RID: 32057 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008154")]
				[Address(RVA = "0x2D688F0", Offset = "0x2D689F1", VA = "0x2D688F0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EFD RID: 3837
				// (get) Token: 0x06007D3A RID: 32058 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F82")]
				private object Current
				{
					[Token(Token = "0x6008155")]
					[Address(RVA = "0x2D68950", Offset = "0x2D68A51", VA = "0x2D68950", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C04A RID: 114762
				[Token(Token = "0x401C493")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C04B RID: 114763
				[Token(Token = "0x401C494")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C04C RID: 114764
				[Token(Token = "0x401C495")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState12.TouchStateArray12 <>4__this;
			}
		}
	}
}
