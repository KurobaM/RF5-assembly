using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200157F RID: 5503
	[Token(Token = "0x2000F22")]
	public struct TouchScreenState6
	{
		// Token: 0x06007C9A RID: 31898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006808")]
		[Address(RVA = "0x386890", Offset = "0x386991", VA = "0x386890")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFCF RID: 114639
		[Token(Token = "0x40188DE")]
		public const int TouchCount = 6;

		// Token: 0x0401BFD0 RID: 114640
		[Token(Token = "0x40188DF")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BFD1 RID: 114641
		[Token(Token = "0x40188E0")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFD2 RID: 114642
		[Token(Token = "0x40188E1")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFD3 RID: 114643
		[Token(Token = "0x40188E2")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState6.TouchStateArray6 touches;

		// Token: 0x02001580 RID: 5504
		[Token(Token = "0x20015BB")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A6C0", Offset = "0x15A7C1")]
		public struct TouchStateArray6 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000ED4 RID: 3796
			// (get) Token: 0x06007C9B RID: 31899 RVA: 0x0002C268 File Offset: 0x0002A468
			[Token(Token = "0x17000F1D")]
			public int Length
			{
				[Token(Token = "0x6007EED")]
				[Address(RVA = "0x3868D0", Offset = "0x3869D1", VA = "0x3868D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000ED5 RID: 3797
			// (get) Token: 0x06007C9C RID: 31900 RVA: 0x0002C280 File Offset: 0x0002A480
			// (set) Token: 0x06007C9D RID: 31901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F1E")]
			public TouchState Item
			{
				[Token(Token = "0x6007EEE")]
				[Address(RVA = "0x3868E0", Offset = "0x3869E1", VA = "0x3868E0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007EEF")]
				[Address(RVA = "0x386A20", Offset = "0x386B21", VA = "0x386A20", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000ED6 RID: 3798
			// (get) Token: 0x06007C9E RID: 31902 RVA: 0x0002C298 File Offset: 0x0002A498
			[Token(Token = "0x17000F1F")]
			public int Count
			{
				[Token(Token = "0x6007EF0")]
				[Address(RVA = "0x386B90", Offset = "0x386C91", VA = "0x386B90", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000ED7 RID: 3799
			// (get) Token: 0x06007C9F RID: 31903 RVA: 0x0002C2B0 File Offset: 0x0002A4B0
			[Token(Token = "0x17000F20")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007EF1")]
				[Address(RVA = "0x386BA0", Offset = "0x386CA1", VA = "0x386BA0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007CA0 RID: 31904 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
			[Token(Token = "0x6007EF2")]
			[Address(RVA = "0x386BB0", Offset = "0x386CB1", VA = "0x386BB0", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CA1 RID: 31905 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
			[Token(Token = "0x6007EF3")]
			[Address(RVA = "0x386BF0", Offset = "0x386CF1", VA = "0x386BF0", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007CA2 RID: 31906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EF4")]
			[Address(RVA = "0x386C30", Offset = "0x386D31", VA = "0x386C30", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007CA3 RID: 31907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EF5")]
			[Address(RVA = "0x386C40", Offset = "0x386D41", VA = "0x386C40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007CA4 RID: 31908 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EF6")]
			[Address(RVA = "0x386C50", Offset = "0x386D51", VA = "0x386C50", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6D90", Offset = "0x1B6E91")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CA5 RID: 31909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EF7")]
			[Address(RVA = "0x386CF0", Offset = "0x386DF1", VA = "0x386CF0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CA6 RID: 31910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EF8")]
			[Address(RVA = "0x386D90", Offset = "0x386E91", VA = "0x386D90", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007CA7 RID: 31911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EF9")]
			[Address(RVA = "0x386DA0", Offset = "0x386EA1", VA = "0x386DA0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007CA8 RID: 31912 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EFA")]
			[Address(RVA = "0x386DB0", Offset = "0x386EB1", VA = "0x386DB0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007CA9 RID: 31913 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
			[Token(Token = "0x6007EFB")]
			[Address(RVA = "0x386DC0", Offset = "0x386EC1", VA = "0x386DC0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CAA RID: 31914 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EFC")]
			[Address(RVA = "0x386DD0", Offset = "0x386ED1", VA = "0x386DD0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFD4 RID: 114644
			[Token(Token = "0x401C2D3")]
			private const int _Length = 6;

			// Token: 0x0401BFD5 RID: 114645
			[Token(Token = "0x401C2D4")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFD6 RID: 114646
			[Token(Token = "0x401C2D5")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401BFD7 RID: 114647
			[Token(Token = "0x401C2D6")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401BFD8 RID: 114648
			[Token(Token = "0x401C2D7")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401BFD9 RID: 114649
			[Token(Token = "0x401C2D8")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401BFDA RID: 114650
			[Token(Token = "0x401C2D9")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x02001581 RID: 5505
			[Token(Token = "0x2001675")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF40", Offset = "0x15B041")]
			private sealed class <GetEnumerator>d__20 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007CAB RID: 31915 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600812C")]
				[Address(RVA = "0x2D73330", Offset = "0x2D73431", VA = "0x2D73330")]
				[DebuggerHidden]
				public <GetEnumerator>d__20(int <>1__state)
				{
				}

				// Token: 0x06007CAC RID: 31916 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600812D")]
				[Address(RVA = "0x2D735E0", Offset = "0x2D736E1", VA = "0x2D735E0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007CAD RID: 31917 RVA: 0x0002C310 File Offset: 0x0002A510
				[Token(Token = "0x600812E")]
				[Address(RVA = "0x2D735F0", Offset = "0x2D736F1", VA = "0x2D735F0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000ED8 RID: 3800
				// (get) Token: 0x06007CAE RID: 31918 RVA: 0x0002C328 File Offset: 0x0002A528
				[Token(Token = "0x17000F75")]
				private TouchState Current
				{
					[Token(Token = "0x600812F")]
					[Address(RVA = "0x2D73700", Offset = "0x2D73801", VA = "0x2D73700", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007CAF RID: 31919 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008130")]
				[Address(RVA = "0x2D73720", Offset = "0x2D73821", VA = "0x2D73720", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000ED9 RID: 3801
				// (get) Token: 0x06007CB0 RID: 31920 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F76")]
				private object Current
				{
					[Token(Token = "0x6008131")]
					[Address(RVA = "0x2D73780", Offset = "0x2D73881", VA = "0x2D73780", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFDB RID: 114651
				[Token(Token = "0x401C481")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFDC RID: 114652
				[Token(Token = "0x401C482")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFDD RID: 114653
				[Token(Token = "0x401C483")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState6.TouchStateArray6 <>4__this;
			}
		}
	}
}
