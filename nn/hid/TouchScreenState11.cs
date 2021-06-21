using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200158E RID: 5518
	[Token(Token = "0x2000F27")]
	public struct TouchScreenState11
	{
		// Token: 0x06007D0D RID: 32013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680D")]
		[Address(RVA = "0x383AC0", Offset = "0x383BC1", VA = "0x383AC0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C024 RID: 114724
		[Token(Token = "0x40188F7")]
		public const int TouchCount = 11;

		// Token: 0x0401C025 RID: 114725
		[Token(Token = "0x40188F8")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C026 RID: 114726
		[Token(Token = "0x40188F9")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C027 RID: 114727
		[Token(Token = "0x40188FA")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C028 RID: 114728
		[Token(Token = "0x40188FB")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState11.TouchStateArray11 touches;

		// Token: 0x0200158F RID: 5519
		[Token(Token = "0x20015C0")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A800", Offset = "0x15A901")]
		public struct TouchStateArray11 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EF2 RID: 3826
			// (get) Token: 0x06007D0E RID: 32014 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
			[Token(Token = "0x17000F31")]
			public int Length
			{
				[Token(Token = "0x6007F3D")]
				[Address(RVA = "0x383AD0", Offset = "0x383BD1", VA = "0x383AD0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EF3 RID: 3827
			// (get) Token: 0x06007D0F RID: 32015 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
			// (set) Token: 0x06007D10 RID: 32016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F32")]
			public TouchState Item
			{
				[Token(Token = "0x6007F3E")]
				[Address(RVA = "0x383AE0", Offset = "0x383BE1", VA = "0x383AE0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F3F")]
				[Address(RVA = "0x383AF0", Offset = "0x383BF1", VA = "0x383AF0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EF4 RID: 3828
			// (get) Token: 0x06007D11 RID: 32017 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
			[Token(Token = "0x17000F33")]
			public int Count
			{
				[Token(Token = "0x6007F40")]
				[Address(RVA = "0x383B30", Offset = "0x383C31", VA = "0x383B30", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x06007D12 RID: 32018 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
			[Token(Token = "0x17000F34")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F41")]
				[Address(RVA = "0x383B40", Offset = "0x383C41", VA = "0x383B40", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007D13 RID: 32019 RVA: 0x0002C700 File Offset: 0x0002A900
			[Token(Token = "0x6007F42")]
			[Address(RVA = "0x383B50", Offset = "0x383C51", VA = "0x383B50", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D14 RID: 32020 RVA: 0x0002C718 File Offset: 0x0002A918
			[Token(Token = "0x6007F43")]
			[Address(RVA = "0x383C40", Offset = "0x383D41", VA = "0x383C40", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007D15 RID: 32021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F44")]
			[Address(RVA = "0x383D20", Offset = "0x383E21", VA = "0x383D20", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007D16 RID: 32022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F45")]
			[Address(RVA = "0x383D30", Offset = "0x383E31", VA = "0x383D30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D17 RID: 32023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F46")]
			[Address(RVA = "0x383D40", Offset = "0x383E41", VA = "0x383D40", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6FC0", Offset = "0x1B70C1")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D18 RID: 32024 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F47")]
			[Address(RVA = "0x383DE0", Offset = "0x383EE1", VA = "0x383DE0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D19 RID: 32025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F48")]
			[Address(RVA = "0x383E80", Offset = "0x383F81", VA = "0x383E80", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D1A RID: 32026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F49")]
			[Address(RVA = "0x383E90", Offset = "0x383F91", VA = "0x383E90", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D1B RID: 32027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F4A")]
			[Address(RVA = "0x383EA0", Offset = "0x383FA1", VA = "0x383EA0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D1C RID: 32028 RVA: 0x0002C730 File Offset: 0x0002A930
			[Token(Token = "0x6007F4B")]
			[Address(RVA = "0x383EB0", Offset = "0x383FB1", VA = "0x383EB0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D1D RID: 32029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F4C")]
			[Address(RVA = "0x383EC0", Offset = "0x383FC1", VA = "0x383EC0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C029 RID: 114729
			[Token(Token = "0x401C300")]
			private const int _Length = 11;

			// Token: 0x0401C02A RID: 114730
			[Token(Token = "0x401C301")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C02B RID: 114731
			[Token(Token = "0x401C302")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C02C RID: 114732
			[Token(Token = "0x401C303")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C02D RID: 114733
			[Token(Token = "0x401C304")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C02E RID: 114734
			[Token(Token = "0x401C305")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C02F RID: 114735
			[Token(Token = "0x401C306")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C030 RID: 114736
			[Token(Token = "0x401C307")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C031 RID: 114737
			[Token(Token = "0x401C308")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C032 RID: 114738
			[Token(Token = "0x401C309")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C033 RID: 114739
			[Token(Token = "0x401C30A")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0401C034 RID: 114740
			[Token(Token = "0x401C30B")]
			[FieldOffset(Offset = "0x190")]
			private TouchState _value10;

			// Token: 0x02001590 RID: 5520
			[Token(Token = "0x200167A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF90", Offset = "0x15B091")]
			private sealed class <GetEnumerator>d__25 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D1E RID: 32030 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600814A")]
				[Address(RVA = "0x2D66F50", Offset = "0x2D67051", VA = "0x2D66F50")]
				[DebuggerHidden]
				public <GetEnumerator>d__25(int <>1__state)
				{
				}

				// Token: 0x06007D1F RID: 32031 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600814B")]
				[Address(RVA = "0x2D67200", Offset = "0x2D67301", VA = "0x2D67200", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D20 RID: 32032 RVA: 0x0002C748 File Offset: 0x0002A948
				[Token(Token = "0x600814C")]
				[Address(RVA = "0x2D67210", Offset = "0x2D67311", VA = "0x2D67210", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EF6 RID: 3830
				// (get) Token: 0x06007D21 RID: 32033 RVA: 0x0002C760 File Offset: 0x0002A960
				[Token(Token = "0x17000F7F")]
				private TouchState Current
				{
					[Token(Token = "0x600814D")]
					[Address(RVA = "0x2D673D0", Offset = "0x2D674D1", VA = "0x2D673D0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D22 RID: 32034 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600814E")]
				[Address(RVA = "0x2D673F0", Offset = "0x2D674F1", VA = "0x2D673F0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EF7 RID: 3831
				// (get) Token: 0x06007D23 RID: 32035 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F80")]
				private object Current
				{
					[Token(Token = "0x600814F")]
					[Address(RVA = "0x2D67450", Offset = "0x2D67551", VA = "0x2D67450", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C035 RID: 114741
				[Token(Token = "0x401C490")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C036 RID: 114742
				[Token(Token = "0x401C491")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C037 RID: 114743
				[Token(Token = "0x401C492")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState11.TouchStateArray11 <>4__this;
			}
		}
	}
}
