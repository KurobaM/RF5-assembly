using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001570 RID: 5488
	[Token(Token = "0x2000F1D")]
	public struct TouchScreenState1
	{
		// Token: 0x06007C27 RID: 31783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006803")]
		[Address(RVA = "0x3830E0", Offset = "0x3831E1", VA = "0x3830E0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BF93 RID: 114579
		[Token(Token = "0x40188C5")]
		public const int TouchCount = 1;

		// Token: 0x0401BF94 RID: 114580
		[Token(Token = "0x40188C6")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF95 RID: 114581
		[Token(Token = "0x40188C7")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BF96 RID: 114582
		[Token(Token = "0x40188C8")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BF97 RID: 114583
		[Token(Token = "0x40188C9")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState1.TouchStateArray1 touches;

		// Token: 0x02001571 RID: 5489
		[Token(Token = "0x20015B6")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A580", Offset = "0x15A681")]
		public struct TouchStateArray1 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EB6 RID: 3766
			// (get) Token: 0x06007C28 RID: 31784 RVA: 0x0002BE30 File Offset: 0x0002A030
			[Token(Token = "0x17000F09")]
			public int Length
			{
				[Token(Token = "0x6007E9D")]
				[Address(RVA = "0x3830F0", Offset = "0x3831F1", VA = "0x3830F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EB7 RID: 3767
			// (get) Token: 0x06007C29 RID: 31785 RVA: 0x0002BE48 File Offset: 0x0002A048
			// (set) Token: 0x06007C2A RID: 31786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F0A")]
			public TouchState Item
			{
				[Token(Token = "0x6007E9E")]
				[Address(RVA = "0x383100", Offset = "0x383201", VA = "0x383100", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007E9F")]
				[Address(RVA = "0x3831A0", Offset = "0x3832A1", VA = "0x3831A0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EB8 RID: 3768
			// (get) Token: 0x06007C2B RID: 31787 RVA: 0x0002BE60 File Offset: 0x0002A060
			[Token(Token = "0x17000F0B")]
			public int Count
			{
				[Token(Token = "0x6007EA0")]
				[Address(RVA = "0x383260", Offset = "0x383361", VA = "0x383260", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EB9 RID: 3769
			// (get) Token: 0x06007C2C RID: 31788 RVA: 0x0002BE78 File Offset: 0x0002A078
			[Token(Token = "0x17000F0C")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007EA1")]
				[Address(RVA = "0x383270", Offset = "0x383371", VA = "0x383270", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007C2D RID: 31789 RVA: 0x0002BE90 File Offset: 0x0002A090
			[Token(Token = "0x6007EA2")]
			[Address(RVA = "0x383280", Offset = "0x383381", VA = "0x383280", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C2E RID: 31790 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
			[Token(Token = "0x6007EA3")]
			[Address(RVA = "0x383370", Offset = "0x383471", VA = "0x383370", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007C2F RID: 31791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EA4")]
			[Address(RVA = "0x383460", Offset = "0x383561", VA = "0x383460", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007C30 RID: 31792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EA5")]
			[Address(RVA = "0x383470", Offset = "0x383571", VA = "0x383470", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007C31 RID: 31793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EA6")]
			[Address(RVA = "0x383500", Offset = "0x383601", VA = "0x383500", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6B60", Offset = "0x1B6C61")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C32 RID: 31794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EA7")]
			[Address(RVA = "0x3835B0", Offset = "0x3836B1", VA = "0x3835B0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C33 RID: 31795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EA8")]
			[Address(RVA = "0x383660", Offset = "0x383761", VA = "0x383660", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007C34 RID: 31796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EA9")]
			[Address(RVA = "0x383670", Offset = "0x383771", VA = "0x383670", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007C35 RID: 31797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EAA")]
			[Address(RVA = "0x383680", Offset = "0x383781", VA = "0x383680", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007C36 RID: 31798 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
			[Token(Token = "0x6007EAB")]
			[Address(RVA = "0x383690", Offset = "0x383791", VA = "0x383690", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C37 RID: 31799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EAC")]
			[Address(RVA = "0x3836A0", Offset = "0x3837A1", VA = "0x3836A0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BF98 RID: 114584
			[Token(Token = "0x401C2BF")]
			private const int _Length = 1;

			// Token: 0x0401BF99 RID: 114585
			[Token(Token = "0x401C2C0")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x02001572 RID: 5490
			[Token(Token = "0x2001670")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AEF0", Offset = "0x15AFF1")]
			private sealed class <GetEnumerator>d__15 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007C38 RID: 31800 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600810E")]
				[Address(RVA = "0x2D64990", Offset = "0x2D64A91", VA = "0x2D64990")]
				[DebuggerHidden]
				public <GetEnumerator>d__15(int <>1__state)
				{
				}

				// Token: 0x06007C39 RID: 31801 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600810F")]
				[Address(RVA = "0x2D64C50", Offset = "0x2D64D51", VA = "0x2D64C50", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007C3A RID: 31802 RVA: 0x0002BED8 File Offset: 0x0002A0D8
				[Token(Token = "0x6008110")]
				[Address(RVA = "0x2D64C60", Offset = "0x2D64D61", VA = "0x2D64C60", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EBA RID: 3770
				// (get) Token: 0x06007C3B RID: 31803 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
				[Token(Token = "0x17000F6B")]
				private TouchState Current
				{
					[Token(Token = "0x6008111")]
					[Address(RVA = "0x2D64CB0", Offset = "0x2D64DB1", VA = "0x2D64CB0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007C3C RID: 31804 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008112")]
				[Address(RVA = "0x2D64CD0", Offset = "0x2D64DD1", VA = "0x2D64CD0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EBB RID: 3771
				// (get) Token: 0x06007C3D RID: 31805 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F6C")]
				private object Current
				{
					[Token(Token = "0x6008113")]
					[Address(RVA = "0x2D64D30", Offset = "0x2D64E31", VA = "0x2D64D30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BF9A RID: 114586
				[Token(Token = "0x401C472")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BF9B RID: 114587
				[Token(Token = "0x401C473")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BF9C RID: 114588
				[Token(Token = "0x401C474")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState1.TouchStateArray1 <>4__this;
			}
		}
	}
}
