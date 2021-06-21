using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001573 RID: 5491
	[Token(Token = "0x2000F1E")]
	public struct TouchScreenState2
	{
		// Token: 0x06007C3E RID: 31806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006804")]
		[Address(RVA = "0x385320", Offset = "0x385421", VA = "0x385320")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BF9D RID: 114589
		[Token(Token = "0x40188CA")]
		public const int TouchCount = 2;

		// Token: 0x0401BF9E RID: 114590
		[Token(Token = "0x40188CB")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF9F RID: 114591
		[Token(Token = "0x40188CC")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFA0 RID: 114592
		[Token(Token = "0x40188CD")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFA1 RID: 114593
		[Token(Token = "0x40188CE")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState2.TouchStateArray2 touches;

		// Token: 0x02001574 RID: 5492
		[Token(Token = "0x20015B7")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A5C0", Offset = "0x15A6C1")]
		public struct TouchStateArray2 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EBC RID: 3772
			// (get) Token: 0x06007C3F RID: 31807 RVA: 0x0002BF08 File Offset: 0x0002A108
			[Token(Token = "0x17000F0D")]
			public int Length
			{
				[Token(Token = "0x6007EAD")]
				[Address(RVA = "0x385340", Offset = "0x385441", VA = "0x385340")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EBD RID: 3773
			// (get) Token: 0x06007C40 RID: 31808 RVA: 0x0002BF20 File Offset: 0x0002A120
			// (set) Token: 0x06007C41 RID: 31809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F0E")]
			public TouchState Item
			{
				[Token(Token = "0x6007EAE")]
				[Address(RVA = "0x385350", Offset = "0x385451", VA = "0x385350", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007EAF")]
				[Address(RVA = "0x385420", Offset = "0x385521", VA = "0x385420", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EBE RID: 3774
			// (get) Token: 0x06007C42 RID: 31810 RVA: 0x0002BF38 File Offset: 0x0002A138
			[Token(Token = "0x17000F0F")]
			public int Count
			{
				[Token(Token = "0x6007EB0")]
				[Address(RVA = "0x385500", Offset = "0x385601", VA = "0x385500", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EBF RID: 3775
			// (get) Token: 0x06007C43 RID: 31811 RVA: 0x0002BF50 File Offset: 0x0002A150
			[Token(Token = "0x17000F10")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007EB1")]
				[Address(RVA = "0x385510", Offset = "0x385611", VA = "0x385510", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007C44 RID: 31812 RVA: 0x0002BF68 File Offset: 0x0002A168
			[Token(Token = "0x6007EB2")]
			[Address(RVA = "0x385520", Offset = "0x385621", VA = "0x385520", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C45 RID: 31813 RVA: 0x0002BF80 File Offset: 0x0002A180
			[Token(Token = "0x6007EB3")]
			[Address(RVA = "0x385560", Offset = "0x385661", VA = "0x385560", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007C46 RID: 31814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EB4")]
			[Address(RVA = "0x3855A0", Offset = "0x3856A1", VA = "0x3855A0", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007C47 RID: 31815 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EB5")]
			[Address(RVA = "0x3855B0", Offset = "0x3856B1", VA = "0x3855B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007C48 RID: 31816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EB6")]
			[Address(RVA = "0x385680", Offset = "0x385781", VA = "0x385680", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6BD0", Offset = "0x1B6CD1")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C49 RID: 31817 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EB7")]
			[Address(RVA = "0x385750", Offset = "0x385851", VA = "0x385750", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C4A RID: 31818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EB8")]
			[Address(RVA = "0x385820", Offset = "0x385921", VA = "0x385820", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007C4B RID: 31819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EB9")]
			[Address(RVA = "0x385830", Offset = "0x385931", VA = "0x385830", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007C4C RID: 31820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EBA")]
			[Address(RVA = "0x385840", Offset = "0x385941", VA = "0x385840", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007C4D RID: 31821 RVA: 0x0002BF98 File Offset: 0x0002A198
			[Token(Token = "0x6007EBB")]
			[Address(RVA = "0x385850", Offset = "0x385951", VA = "0x385850", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C4E RID: 31822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EBC")]
			[Address(RVA = "0x385860", Offset = "0x385961", VA = "0x385860", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFA2 RID: 114594
			[Token(Token = "0x401C2C1")]
			private const int _Length = 2;

			// Token: 0x0401BFA3 RID: 114595
			[Token(Token = "0x401C2C2")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFA4 RID: 114596
			[Token(Token = "0x401C2C3")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x02001575 RID: 5493
			[Token(Token = "0x2001671")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF00", Offset = "0x15B001")]
			private sealed class <GetEnumerator>d__16 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007C4F RID: 31823 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008114")]
				[Address(RVA = "0x2D6EF60", Offset = "0x2D6F061", VA = "0x2D6EF60")]
				[DebuggerHidden]
				public <GetEnumerator>d__16(int <>1__state)
				{
				}

				// Token: 0x06007C50 RID: 31824 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008115")]
				[Address(RVA = "0x2D6F240", Offset = "0x2D6F341", VA = "0x2D6F240", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007C51 RID: 31825 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
				[Token(Token = "0x6008116")]
				[Address(RVA = "0x2D6F250", Offset = "0x2D6F351", VA = "0x2D6F250", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EC0 RID: 3776
				// (get) Token: 0x06007C52 RID: 31826 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
				[Token(Token = "0x17000F6D")]
				private TouchState Current
				{
					[Token(Token = "0x6008117")]
					[Address(RVA = "0x2D6F2D0", Offset = "0x2D6F3D1", VA = "0x2D6F2D0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007C53 RID: 31827 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008118")]
				[Address(RVA = "0x2D6F2F0", Offset = "0x2D6F3F1", VA = "0x2D6F2F0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EC1 RID: 3777
				// (get) Token: 0x06007C54 RID: 31828 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F6E")]
				private object Current
				{
					[Token(Token = "0x6008119")]
					[Address(RVA = "0x2D6F350", Offset = "0x2D6F451", VA = "0x2D6F350", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFA5 RID: 114597
				[Token(Token = "0x401C475")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFA6 RID: 114598
				[Token(Token = "0x401C476")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFA7 RID: 114599
				[Token(Token = "0x401C477")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState2.TouchStateArray2 <>4__this;
			}
		}
	}
}
