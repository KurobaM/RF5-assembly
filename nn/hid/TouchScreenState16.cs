using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200159D RID: 5533
	[Token(Token = "0x2000F2C")]
	public struct TouchScreenState16
	{
		// Token: 0x06007D80 RID: 32128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006812")]
		[Address(RVA = "0x384F10", Offset = "0x385011", VA = "0x384F10")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C092 RID: 114834
		[Token(Token = "0x4018910")]
		public const int TouchCount = 16;

		// Token: 0x0401C093 RID: 114835
		[Token(Token = "0x4018911")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C094 RID: 114836
		[Token(Token = "0x4018912")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C095 RID: 114837
		[Token(Token = "0x4018913")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C096 RID: 114838
		[Token(Token = "0x4018914")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState16.TouchStateArray16 touches;

		// Token: 0x0200159E RID: 5534
		[Token(Token = "0x20015C5")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A940", Offset = "0x15AA41")]
		public struct TouchStateArray16 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000F10 RID: 3856
			// (get) Token: 0x06007D81 RID: 32129 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
			[Token(Token = "0x17000F45")]
			public int Length
			{
				[Token(Token = "0x6007F8D")]
				[Address(RVA = "0x384F20", Offset = "0x385021", VA = "0x384F20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F11 RID: 3857
			// (get) Token: 0x06007D82 RID: 32130 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
			// (set) Token: 0x06007D83 RID: 32131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F46")]
			public TouchState Item
			{
				[Token(Token = "0x6007F8E")]
				[Address(RVA = "0x384F30", Offset = "0x385031", VA = "0x384F30", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F8F")]
				[Address(RVA = "0x384F40", Offset = "0x385041", VA = "0x384F40", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000F12 RID: 3858
			// (get) Token: 0x06007D84 RID: 32132 RVA: 0x0002CB08 File Offset: 0x0002AD08
			[Token(Token = "0x17000F47")]
			public int Count
			{
				[Token(Token = "0x6007F90")]
				[Address(RVA = "0x384F80", Offset = "0x385081", VA = "0x384F80", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F13 RID: 3859
			// (get) Token: 0x06007D85 RID: 32133 RVA: 0x0002CB20 File Offset: 0x0002AD20
			[Token(Token = "0x17000F48")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F91")]
				[Address(RVA = "0x384F90", Offset = "0x385091", VA = "0x384F90", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007D86 RID: 32134 RVA: 0x0002CB38 File Offset: 0x0002AD38
			[Token(Token = "0x6007F92")]
			[Address(RVA = "0x384FA0", Offset = "0x3850A1", VA = "0x384FA0", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D87 RID: 32135 RVA: 0x0002CB50 File Offset: 0x0002AD50
			[Token(Token = "0x6007F93")]
			[Address(RVA = "0x385090", Offset = "0x385191", VA = "0x385090", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007D88 RID: 32136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F94")]
			[Address(RVA = "0x385170", Offset = "0x385271", VA = "0x385170", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007D89 RID: 32137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F95")]
			[Address(RVA = "0x385180", Offset = "0x385281", VA = "0x385180", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D8A RID: 32138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F96")]
			[Address(RVA = "0x385190", Offset = "0x385291", VA = "0x385190", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B71F0", Offset = "0x1B72F1")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D8B RID: 32139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F97")]
			[Address(RVA = "0x385230", Offset = "0x385331", VA = "0x385230", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D8C RID: 32140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F98")]
			[Address(RVA = "0x3852D0", Offset = "0x3853D1", VA = "0x3852D0", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D8D RID: 32141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F99")]
			[Address(RVA = "0x3852E0", Offset = "0x3853E1", VA = "0x3852E0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D8E RID: 32142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F9A")]
			[Address(RVA = "0x3852F0", Offset = "0x3853F1", VA = "0x3852F0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D8F RID: 32143 RVA: 0x0002CB68 File Offset: 0x0002AD68
			[Token(Token = "0x6007F9B")]
			[Address(RVA = "0x385300", Offset = "0x385401", VA = "0x385300", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D90 RID: 32144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F9C")]
			[Address(RVA = "0x385310", Offset = "0x385411", VA = "0x385310", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C097 RID: 114839
			[Token(Token = "0x401C346")]
			private const int _Length = 16;

			// Token: 0x0401C098 RID: 114840
			[Token(Token = "0x401C347")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C099 RID: 114841
			[Token(Token = "0x401C348")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C09A RID: 114842
			[Token(Token = "0x401C349")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C09B RID: 114843
			[Token(Token = "0x401C34A")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C09C RID: 114844
			[Token(Token = "0x401C34B")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C09D RID: 114845
			[Token(Token = "0x401C34C")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C09E RID: 114846
			[Token(Token = "0x401C34D")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C09F RID: 114847
			[Token(Token = "0x401C34E")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C0A0 RID: 114848
			[Token(Token = "0x401C34F")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C0A1 RID: 114849
			[Token(Token = "0x401C350")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0401C0A2 RID: 114850
			[Token(Token = "0x401C351")]
			[FieldOffset(Offset = "0x190")]
			private TouchState _value10;

			// Token: 0x0401C0A3 RID: 114851
			[Token(Token = "0x401C352")]
			[FieldOffset(Offset = "0x1B8")]
			private TouchState _value11;

			// Token: 0x0401C0A4 RID: 114852
			[Token(Token = "0x401C353")]
			[FieldOffset(Offset = "0x1E0")]
			private TouchState _value12;

			// Token: 0x0401C0A5 RID: 114853
			[Token(Token = "0x401C354")]
			[FieldOffset(Offset = "0x208")]
			private TouchState _value13;

			// Token: 0x0401C0A6 RID: 114854
			[Token(Token = "0x401C355")]
			[FieldOffset(Offset = "0x230")]
			private TouchState _value14;

			// Token: 0x0401C0A7 RID: 114855
			[Token(Token = "0x401C356")]
			[FieldOffset(Offset = "0x258")]
			private TouchState _value15;

			// Token: 0x0200159F RID: 5535
			[Token(Token = "0x200167F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AFE0", Offset = "0x15B0E1")]
			private sealed class <GetEnumerator>d__30 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D91 RID: 32145 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008168")]
				[Address(RVA = "0x2D6E180", Offset = "0x2D6E281", VA = "0x2D6E180")]
				[DebuggerHidden]
				public <GetEnumerator>d__30(int <>1__state)
				{
				}

				// Token: 0x06007D92 RID: 32146 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008169")]
				[Address(RVA = "0x2D6E430", Offset = "0x2D6E531", VA = "0x2D6E430", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D93 RID: 32147 RVA: 0x0002CB80 File Offset: 0x0002AD80
				[Token(Token = "0x600816A")]
				[Address(RVA = "0x2D6E440", Offset = "0x2D6E541", VA = "0x2D6E440", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000F14 RID: 3860
				// (get) Token: 0x06007D94 RID: 32148 RVA: 0x0002CB98 File Offset: 0x0002AD98
				[Token(Token = "0x17000F89")]
				private TouchState Current
				{
					[Token(Token = "0x600816B")]
					[Address(RVA = "0x2D6E6E0", Offset = "0x2D6E7E1", VA = "0x2D6E6E0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D95 RID: 32149 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600816C")]
				[Address(RVA = "0x2D6E700", Offset = "0x2D6E801", VA = "0x2D6E700", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000F15 RID: 3861
				// (get) Token: 0x06007D96 RID: 32150 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F8A")]
				private object Current
				{
					[Token(Token = "0x600816D")]
					[Address(RVA = "0x2D6E760", Offset = "0x2D6E861", VA = "0x2D6E760", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C0A8 RID: 114856
				[Token(Token = "0x401C49F")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C0A9 RID: 114857
				[Token(Token = "0x401C4A0")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C0AA RID: 114858
				[Token(Token = "0x401C4A1")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState16.TouchStateArray16 <>4__this;
			}
		}
	}
}
