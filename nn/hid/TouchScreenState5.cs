using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200157C RID: 5500
	[Token(Token = "0x2000F21")]
	public struct TouchScreenState5
	{
		// Token: 0x06007C83 RID: 31875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006807")]
		[Address(RVA = "0x386370", Offset = "0x386471", VA = "0x386370")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFC1 RID: 114625
		[Token(Token = "0x40188D9")]
		public const int TouchCount = 5;

		// Token: 0x0401BFC2 RID: 114626
		[Token(Token = "0x40188DA")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BFC3 RID: 114627
		[Token(Token = "0x40188DB")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFC4 RID: 114628
		[Token(Token = "0x40188DC")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFC5 RID: 114629
		[Token(Token = "0x40188DD")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState5.TouchStateArray5 touches;

		// Token: 0x0200157D RID: 5501
		[Token(Token = "0x20015BA")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A680", Offset = "0x15A781")]
		public struct TouchStateArray5 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000ECE RID: 3790
			// (get) Token: 0x06007C84 RID: 31876 RVA: 0x0002C190 File Offset: 0x0002A390
			[Token(Token = "0x17000F19")]
			public int Length
			{
				[Token(Token = "0x6007EDD")]
				[Address(RVA = "0x3863B0", Offset = "0x3864B1", VA = "0x3863B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000ECF RID: 3791
			// (get) Token: 0x06007C85 RID: 31877 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
			// (set) Token: 0x06007C86 RID: 31878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F1A")]
			public TouchState Item
			{
				[Token(Token = "0x6007EDE")]
				[Address(RVA = "0x3863C0", Offset = "0x3864C1", VA = "0x3863C0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007EDF")]
				[Address(RVA = "0x3864F0", Offset = "0x3865F1", VA = "0x3864F0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000ED0 RID: 3792
			// (get) Token: 0x06007C87 RID: 31879 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
			[Token(Token = "0x17000F1B")]
			public int Count
			{
				[Token(Token = "0x6007EE0")]
				[Address(RVA = "0x386640", Offset = "0x386741", VA = "0x386640", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x06007C88 RID: 31880 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
			[Token(Token = "0x17000F1C")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007EE1")]
				[Address(RVA = "0x386650", Offset = "0x386751", VA = "0x386650", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007C89 RID: 31881 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
			[Token(Token = "0x6007EE2")]
			[Address(RVA = "0x386660", Offset = "0x386761", VA = "0x386660", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C8A RID: 31882 RVA: 0x0002C208 File Offset: 0x0002A408
			[Token(Token = "0x6007EE3")]
			[Address(RVA = "0x3866A0", Offset = "0x3867A1", VA = "0x3866A0", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007C8B RID: 31883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EE4")]
			[Address(RVA = "0x3866E0", Offset = "0x3867E1", VA = "0x3866E0", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007C8C RID: 31884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EE5")]
			[Address(RVA = "0x3866F0", Offset = "0x3867F1", VA = "0x3866F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007C8D RID: 31885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EE6")]
			[Address(RVA = "0x386700", Offset = "0x386801", VA = "0x386700", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6D20", Offset = "0x1B6E21")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C8E RID: 31886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EE7")]
			[Address(RVA = "0x3867A0", Offset = "0x3868A1", VA = "0x3867A0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C8F RID: 31887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EE8")]
			[Address(RVA = "0x386840", Offset = "0x386941", VA = "0x386840", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007C90 RID: 31888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EE9")]
			[Address(RVA = "0x386850", Offset = "0x386951", VA = "0x386850", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007C91 RID: 31889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EEA")]
			[Address(RVA = "0x386860", Offset = "0x386961", VA = "0x386860", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007C92 RID: 31890 RVA: 0x0002C220 File Offset: 0x0002A420
			[Token(Token = "0x6007EEB")]
			[Address(RVA = "0x386870", Offset = "0x386971", VA = "0x386870", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C93 RID: 31891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EEC")]
			[Address(RVA = "0x386880", Offset = "0x386981", VA = "0x386880", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFC6 RID: 114630
			[Token(Token = "0x401C2CD")]
			private const int _Length = 5;

			// Token: 0x0401BFC7 RID: 114631
			[Token(Token = "0x401C2CE")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFC8 RID: 114632
			[Token(Token = "0x401C2CF")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401BFC9 RID: 114633
			[Token(Token = "0x401C2D0")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401BFCA RID: 114634
			[Token(Token = "0x401C2D1")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401BFCB RID: 114635
			[Token(Token = "0x401C2D2")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0200157E RID: 5502
			[Token(Token = "0x2001674")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF30", Offset = "0x15B031")]
			private sealed class <GetEnumerator>d__19 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007C94 RID: 31892 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008126")]
				[Address(RVA = "0x2D71F80", Offset = "0x2D72081", VA = "0x2D71F80")]
				[DebuggerHidden]
				public <GetEnumerator>d__19(int <>1__state)
				{
				}

				// Token: 0x06007C95 RID: 31893 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008127")]
				[Address(RVA = "0x2D72230", Offset = "0x2D72331", VA = "0x2D72230", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007C96 RID: 31894 RVA: 0x0002C238 File Offset: 0x0002A438
				[Token(Token = "0x6008128")]
				[Address(RVA = "0x2D72240", Offset = "0x2D72341", VA = "0x2D72240", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000ED2 RID: 3794
				// (get) Token: 0x06007C97 RID: 31895 RVA: 0x0002C250 File Offset: 0x0002A450
				[Token(Token = "0x17000F73")]
				private TouchState Current
				{
					[Token(Token = "0x6008129")]
					[Address(RVA = "0x2D72330", Offset = "0x2D72431", VA = "0x2D72330", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007C98 RID: 31896 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600812A")]
				[Address(RVA = "0x2D72350", Offset = "0x2D72451", VA = "0x2D72350", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000ED3 RID: 3795
				// (get) Token: 0x06007C99 RID: 31897 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F74")]
				private object Current
				{
					[Token(Token = "0x600812B")]
					[Address(RVA = "0x2D723B0", Offset = "0x2D724B1", VA = "0x2D723B0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFCC RID: 114636
				[Token(Token = "0x401C47E")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFCD RID: 114637
				[Token(Token = "0x401C47F")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFCE RID: 114638
				[Token(Token = "0x401C480")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState5.TouchStateArray5 <>4__this;
			}
		}
	}
}
