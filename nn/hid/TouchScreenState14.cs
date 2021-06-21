using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001597 RID: 5527
	[Token(Token = "0x2000F2A")]
	public struct TouchScreenState14
	{
		// Token: 0x06007D52 RID: 32082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006810")]
		[Address(RVA = "0x3846F0", Offset = "0x3847F1", VA = "0x3846F0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C063 RID: 114787
		[Token(Token = "0x4018906")]
		public const int TouchCount = 14;

		// Token: 0x0401C064 RID: 114788
		[Token(Token = "0x4018907")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C065 RID: 114789
		[Token(Token = "0x4018908")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C066 RID: 114790
		[Token(Token = "0x4018909")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C067 RID: 114791
		[Token(Token = "0x401890A")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState14.TouchStateArray14 touches;

		// Token: 0x02001598 RID: 5528
		[Token(Token = "0x20015C3")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A8C0", Offset = "0x15A9C1")]
		public struct TouchStateArray14 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000F04 RID: 3844
			// (get) Token: 0x06007D53 RID: 32083 RVA: 0x0002C928 File Offset: 0x0002AB28
			[Token(Token = "0x17000F3D")]
			public int Length
			{
				[Token(Token = "0x6007F6D")]
				[Address(RVA = "0x384700", Offset = "0x384801", VA = "0x384700")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F05 RID: 3845
			// (get) Token: 0x06007D54 RID: 32084 RVA: 0x0002C940 File Offset: 0x0002AB40
			// (set) Token: 0x06007D55 RID: 32085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F3E")]
			public TouchState Item
			{
				[Token(Token = "0x6007F6E")]
				[Address(RVA = "0x384710", Offset = "0x384811", VA = "0x384710", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F6F")]
				[Address(RVA = "0x384720", Offset = "0x384821", VA = "0x384720", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000F06 RID: 3846
			// (get) Token: 0x06007D56 RID: 32086 RVA: 0x0002C958 File Offset: 0x0002AB58
			[Token(Token = "0x17000F3F")]
			public int Count
			{
				[Token(Token = "0x6007F70")]
				[Address(RVA = "0x384760", Offset = "0x384861", VA = "0x384760", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F07 RID: 3847
			// (get) Token: 0x06007D57 RID: 32087 RVA: 0x0002C970 File Offset: 0x0002AB70
			[Token(Token = "0x17000F40")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F71")]
				[Address(RVA = "0x384770", Offset = "0x384871", VA = "0x384770", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007D58 RID: 32088 RVA: 0x0002C988 File Offset: 0x0002AB88
			[Token(Token = "0x6007F72")]
			[Address(RVA = "0x384780", Offset = "0x384881", VA = "0x384780", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D59 RID: 32089 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
			[Token(Token = "0x6007F73")]
			[Address(RVA = "0x384870", Offset = "0x384971", VA = "0x384870", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007D5A RID: 32090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F74")]
			[Address(RVA = "0x384950", Offset = "0x384A51", VA = "0x384950", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007D5B RID: 32091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F75")]
			[Address(RVA = "0x384960", Offset = "0x384A61", VA = "0x384960", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D5C RID: 32092 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F76")]
			[Address(RVA = "0x384970", Offset = "0x384A71", VA = "0x384970", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B7110", Offset = "0x1B7211")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D5D RID: 32093 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F77")]
			[Address(RVA = "0x384A10", Offset = "0x384B11", VA = "0x384A10", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D5E RID: 32094 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F78")]
			[Address(RVA = "0x384AB0", Offset = "0x384BB1", VA = "0x384AB0", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D5F RID: 32095 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F79")]
			[Address(RVA = "0x384AC0", Offset = "0x384BC1", VA = "0x384AC0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D60 RID: 32096 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F7A")]
			[Address(RVA = "0x384AD0", Offset = "0x384BD1", VA = "0x384AD0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D61 RID: 32097 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
			[Token(Token = "0x6007F7B")]
			[Address(RVA = "0x384AE0", Offset = "0x384BE1", VA = "0x384AE0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D62 RID: 32098 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F7C")]
			[Address(RVA = "0x384AF0", Offset = "0x384BF1", VA = "0x384AF0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C068 RID: 114792
			[Token(Token = "0x401C327")]
			private const int _Length = 14;

			// Token: 0x0401C069 RID: 114793
			[Token(Token = "0x401C328")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C06A RID: 114794
			[Token(Token = "0x401C329")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C06B RID: 114795
			[Token(Token = "0x401C32A")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C06C RID: 114796
			[Token(Token = "0x401C32B")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C06D RID: 114797
			[Token(Token = "0x401C32C")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C06E RID: 114798
			[Token(Token = "0x401C32D")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C06F RID: 114799
			[Token(Token = "0x401C32E")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C070 RID: 114800
			[Token(Token = "0x401C32F")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C071 RID: 114801
			[Token(Token = "0x401C330")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C072 RID: 114802
			[Token(Token = "0x401C331")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0401C073 RID: 114803
			[Token(Token = "0x401C332")]
			[FieldOffset(Offset = "0x190")]
			private TouchState _value10;

			// Token: 0x0401C074 RID: 114804
			[Token(Token = "0x401C333")]
			[FieldOffset(Offset = "0x1B8")]
			private TouchState _value11;

			// Token: 0x0401C075 RID: 114805
			[Token(Token = "0x401C334")]
			[FieldOffset(Offset = "0x1E0")]
			private TouchState _value12;

			// Token: 0x0401C076 RID: 114806
			[Token(Token = "0x401C335")]
			[FieldOffset(Offset = "0x208")]
			private TouchState _value13;

			// Token: 0x02001599 RID: 5529
			[Token(Token = "0x200167D")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AFC0", Offset = "0x15B0C1")]
			private sealed class <GetEnumerator>d__28 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D63 RID: 32099 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600815C")]
				[Address(RVA = "0x2D6B0C0", Offset = "0x2D6B1C1", VA = "0x2D6B0C0")]
				[DebuggerHidden]
				public <GetEnumerator>d__28(int <>1__state)
				{
				}

				// Token: 0x06007D64 RID: 32100 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600815D")]
				[Address(RVA = "0x2D6B370", Offset = "0x2D6B471", VA = "0x2D6B370", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D65 RID: 32101 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
				[Token(Token = "0x600815E")]
				[Address(RVA = "0x2D6B380", Offset = "0x2D6B481", VA = "0x2D6B380", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000F08 RID: 3848
				// (get) Token: 0x06007D66 RID: 32102 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
				[Token(Token = "0x17000F85")]
				private TouchState Current
				{
					[Token(Token = "0x600815F")]
					[Address(RVA = "0x2D6B5C0", Offset = "0x2D6B6C1", VA = "0x2D6B5C0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D67 RID: 32103 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008160")]
				[Address(RVA = "0x2D6B5E0", Offset = "0x2D6B6E1", VA = "0x2D6B5E0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000F09 RID: 3849
				// (get) Token: 0x06007D68 RID: 32104 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F86")]
				private object Current
				{
					[Token(Token = "0x6008161")]
					[Address(RVA = "0x2D6B640", Offset = "0x2D6B741", VA = "0x2D6B640", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C077 RID: 114807
				[Token(Token = "0x401C499")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C078 RID: 114808
				[Token(Token = "0x401C49A")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C079 RID: 114809
				[Token(Token = "0x401C49B")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState14.TouchStateArray14 <>4__this;
			}
		}
	}
}
