using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001588 RID: 5512
	[Token(Token = "0x2000F25")]
	public struct TouchScreenState9
	{
		// Token: 0x06007CDF RID: 31967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680B")]
		[Address(RVA = "0x3878A0", Offset = "0x3879A1", VA = "0x3878A0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFFF RID: 114687
		[Token(Token = "0x40188ED")]
		public const int TouchCount = 9;

		// Token: 0x0401C000 RID: 114688
		[Token(Token = "0x40188EE")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C001 RID: 114689
		[Token(Token = "0x40188EF")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C002 RID: 114690
		[Token(Token = "0x40188F0")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C003 RID: 114691
		[Token(Token = "0x40188F1")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState9.TouchStateArray9 touches;

		// Token: 0x02001589 RID: 5513
		[Token(Token = "0x20015BE")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A780", Offset = "0x15A881")]
		public struct TouchStateArray9 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EE6 RID: 3814
			// (get) Token: 0x06007CE0 RID: 31968 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
			[Token(Token = "0x17000F29")]
			public int Length
			{
				[Token(Token = "0x6007F1D")]
				[Address(RVA = "0x3878B0", Offset = "0x3879B1", VA = "0x3878B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EE7 RID: 3815
			// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x0002C508 File Offset: 0x0002A708
			// (set) Token: 0x06007CE2 RID: 31970 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F2A")]
			public TouchState Item
			{
				[Token(Token = "0x6007F1E")]
				[Address(RVA = "0x3878C0", Offset = "0x3879C1", VA = "0x3878C0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F1F")]
				[Address(RVA = "0x387A40", Offset = "0x387B41", VA = "0x387A40", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EE8 RID: 3816
			// (get) Token: 0x06007CE3 RID: 31971 RVA: 0x0002C520 File Offset: 0x0002A720
			[Token(Token = "0x17000F2B")]
			public int Count
			{
				[Token(Token = "0x6007F20")]
				[Address(RVA = "0x387C00", Offset = "0x387D01", VA = "0x387C00", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EE9 RID: 3817
			// (get) Token: 0x06007CE4 RID: 31972 RVA: 0x0002C538 File Offset: 0x0002A738
			[Token(Token = "0x17000F2C")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F21")]
				[Address(RVA = "0x387C10", Offset = "0x387D11", VA = "0x387C10", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007CE5 RID: 31973 RVA: 0x0002C550 File Offset: 0x0002A750
			[Token(Token = "0x6007F22")]
			[Address(RVA = "0x387C20", Offset = "0x387D21", VA = "0x387C20", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CE6 RID: 31974 RVA: 0x0002C568 File Offset: 0x0002A768
			[Token(Token = "0x6007F23")]
			[Address(RVA = "0x387C60", Offset = "0x387D61", VA = "0x387C60", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007CE7 RID: 31975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F24")]
			[Address(RVA = "0x387CA0", Offset = "0x387DA1", VA = "0x387CA0", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007CE8 RID: 31976 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F25")]
			[Address(RVA = "0x387CB0", Offset = "0x387DB1", VA = "0x387CB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007CE9 RID: 31977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F26")]
			[Address(RVA = "0x387CC0", Offset = "0x387DC1", VA = "0x387CC0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6EE0", Offset = "0x1B6FE1")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CEA RID: 31978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F27")]
			[Address(RVA = "0x387D60", Offset = "0x387E61", VA = "0x387D60", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CEB RID: 31979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F28")]
			[Address(RVA = "0x387E00", Offset = "0x387F01", VA = "0x387E00", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007CEC RID: 31980 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F29")]
			[Address(RVA = "0x387E10", Offset = "0x387F11", VA = "0x387E10", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007CED RID: 31981 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F2A")]
			[Address(RVA = "0x387E20", Offset = "0x387F21", VA = "0x387E20", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007CEE RID: 31982 RVA: 0x0002C580 File Offset: 0x0002A780
			[Token(Token = "0x6007F2B")]
			[Address(RVA = "0x387E30", Offset = "0x387F31", VA = "0x387E30", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CEF RID: 31983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F2C")]
			[Address(RVA = "0x387E40", Offset = "0x387F41", VA = "0x387E40", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C004 RID: 114692
			[Token(Token = "0x401C2EB")]
			private const int _Length = 9;

			// Token: 0x0401C005 RID: 114693
			[Token(Token = "0x401C2EC")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C006 RID: 114694
			[Token(Token = "0x401C2ED")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C007 RID: 114695
			[Token(Token = "0x401C2EE")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C008 RID: 114696
			[Token(Token = "0x401C2EF")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C009 RID: 114697
			[Token(Token = "0x401C2F0")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C00A RID: 114698
			[Token(Token = "0x401C2F1")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C00B RID: 114699
			[Token(Token = "0x401C2F2")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C00C RID: 114700
			[Token(Token = "0x401C2F3")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C00D RID: 114701
			[Token(Token = "0x401C2F4")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0200158A RID: 5514
			[Token(Token = "0x2001678")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF70", Offset = "0x15B071")]
			private sealed class <GetEnumerator>d__23 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007CF0 RID: 31984 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600813E")]
				[Address(RVA = "0x2D77D50", Offset = "0x2D77E51", VA = "0x2D77D50")]
				[DebuggerHidden]
				public <GetEnumerator>d__23(int <>1__state)
				{
				}

				// Token: 0x06007CF1 RID: 31985 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600813F")]
				[Address(RVA = "0x2D78000", Offset = "0x2D78101", VA = "0x2D78000", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007CF2 RID: 31986 RVA: 0x0002C598 File Offset: 0x0002A798
				[Token(Token = "0x6008140")]
				[Address(RVA = "0x2D78010", Offset = "0x2D78111", VA = "0x2D78010", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EEA RID: 3818
				// (get) Token: 0x06007CF3 RID: 31987 RVA: 0x0002C5B0 File Offset: 0x0002A7B0
				[Token(Token = "0x17000F7B")]
				private TouchState Current
				{
					[Token(Token = "0x6008141")]
					[Address(RVA = "0x2D78190", Offset = "0x2D78291", VA = "0x2D78190", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007CF4 RID: 31988 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008142")]
				[Address(RVA = "0x2D781B0", Offset = "0x2D782B1", VA = "0x2D781B0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EEB RID: 3819
				// (get) Token: 0x06007CF5 RID: 31989 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F7C")]
				private object Current
				{
					[Token(Token = "0x6008143")]
					[Address(RVA = "0x2D78210", Offset = "0x2D78311", VA = "0x2D78210", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C00E RID: 114702
				[Token(Token = "0x401C48A")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C00F RID: 114703
				[Token(Token = "0x401C48B")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C010 RID: 114704
				[Token(Token = "0x401C48C")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState9.TouchStateArray9 <>4__this;
			}
		}
	}
}
