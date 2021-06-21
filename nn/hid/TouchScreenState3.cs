using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001576 RID: 5494
	[Token(Token = "0x2000F1F")]
	public struct TouchScreenState3
	{
		// Token: 0x06007C55 RID: 31829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006805")]
		[Address(RVA = "0x385870", Offset = "0x385971", VA = "0x385870")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFA8 RID: 114600
		[Token(Token = "0x40188CF")]
		public const int TouchCount = 3;

		// Token: 0x0401BFA9 RID: 114601
		[Token(Token = "0x40188D0")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BFAA RID: 114602
		[Token(Token = "0x40188D1")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFAB RID: 114603
		[Token(Token = "0x40188D2")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFAC RID: 114604
		[Token(Token = "0x40188D3")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState3.TouchStateArray3 touches;

		// Token: 0x02001577 RID: 5495
		[Token(Token = "0x20015B8")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A600", Offset = "0x15A701")]
		public struct TouchStateArray3 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x06007C56 RID: 31830 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
			[Token(Token = "0x17000F11")]
			public int Length
			{
				[Token(Token = "0x6007EBD")]
				[Address(RVA = "0x3858A0", Offset = "0x3859A1", VA = "0x3858A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x06007C57 RID: 31831 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
			// (set) Token: 0x06007C58 RID: 31832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F12")]
			public TouchState Item
			{
				[Token(Token = "0x6007EBE")]
				[Address(RVA = "0x3858B0", Offset = "0x3859B1", VA = "0x3858B0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007EBF")]
				[Address(RVA = "0x3859A0", Offset = "0x385AA1", VA = "0x3859A0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06007C59 RID: 31833 RVA: 0x0002C010 File Offset: 0x0002A210
			[Token(Token = "0x17000F13")]
			public int Count
			{
				[Token(Token = "0x6007EC0")]
				[Address(RVA = "0x385AB0", Offset = "0x385BB1", VA = "0x385AB0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x06007C5A RID: 31834 RVA: 0x0002C028 File Offset: 0x0002A228
			[Token(Token = "0x17000F14")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007EC1")]
				[Address(RVA = "0x385AC0", Offset = "0x385BC1", VA = "0x385AC0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007C5B RID: 31835 RVA: 0x0002C040 File Offset: 0x0002A240
			[Token(Token = "0x6007EC2")]
			[Address(RVA = "0x385AD0", Offset = "0x385BD1", VA = "0x385AD0", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C5C RID: 31836 RVA: 0x0002C058 File Offset: 0x0002A258
			[Token(Token = "0x6007EC3")]
			[Address(RVA = "0x385B10", Offset = "0x385C11", VA = "0x385B10", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007C5D RID: 31837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EC4")]
			[Address(RVA = "0x385B50", Offset = "0x385C51", VA = "0x385B50", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007C5E RID: 31838 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EC5")]
			[Address(RVA = "0x385B60", Offset = "0x385C61", VA = "0x385B60", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007C5F RID: 31839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EC6")]
			[Address(RVA = "0x385C50", Offset = "0x385D51", VA = "0x385C50", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6C40", Offset = "0x1B6D41")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C60 RID: 31840 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007EC7")]
			[Address(RVA = "0x385D50", Offset = "0x385E51", VA = "0x385D50", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C61 RID: 31841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EC8")]
			[Address(RVA = "0x385E50", Offset = "0x385F51", VA = "0x385E50", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007C62 RID: 31842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EC9")]
			[Address(RVA = "0x385E60", Offset = "0x385F61", VA = "0x385E60", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007C63 RID: 31843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ECA")]
			[Address(RVA = "0x385E70", Offset = "0x385F71", VA = "0x385E70", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007C64 RID: 31844 RVA: 0x0002C070 File Offset: 0x0002A270
			[Token(Token = "0x6007ECB")]
			[Address(RVA = "0x385E80", Offset = "0x385F81", VA = "0x385E80", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C65 RID: 31845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ECC")]
			[Address(RVA = "0x385E90", Offset = "0x385F91", VA = "0x385E90", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFAD RID: 114605
			[Token(Token = "0x401C2C4")]
			private const int _Length = 3;

			// Token: 0x0401BFAE RID: 114606
			[Token(Token = "0x401C2C5")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFAF RID: 114607
			[Token(Token = "0x401C2C6")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401BFB0 RID: 114608
			[Token(Token = "0x401C2C7")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x02001578 RID: 5496
			[Token(Token = "0x2001672")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF10", Offset = "0x15B011")]
			private sealed class <GetEnumerator>d__17 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007C66 RID: 31846 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600811A")]
				[Address(RVA = "0x2D6FD40", Offset = "0x2D6FE41", VA = "0x2D6FD40")]
				[DebuggerHidden]
				public <GetEnumerator>d__17(int <>1__state)
				{
				}

				// Token: 0x06007C67 RID: 31847 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600811B")]
				[Address(RVA = "0x2D70050", Offset = "0x2D70151", VA = "0x2D70050", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007C68 RID: 31848 RVA: 0x0002C088 File Offset: 0x0002A288
				[Token(Token = "0x600811C")]
				[Address(RVA = "0x2D70060", Offset = "0x2D70161", VA = "0x2D70060", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EC6 RID: 3782
				// (get) Token: 0x06007C69 RID: 31849 RVA: 0x0002C0A0 File Offset: 0x0002A2A0
				[Token(Token = "0x17000F6F")]
				private TouchState Current
				{
					[Token(Token = "0x600811D")]
					[Address(RVA = "0x2D70100", Offset = "0x2D70201", VA = "0x2D70100", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007C6A RID: 31850 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600811E")]
				[Address(RVA = "0x2D70120", Offset = "0x2D70221", VA = "0x2D70120", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EC7 RID: 3783
				// (get) Token: 0x06007C6B RID: 31851 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F70")]
				private object Current
				{
					[Token(Token = "0x600811F")]
					[Address(RVA = "0x2D70180", Offset = "0x2D70281", VA = "0x2D70180", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFB1 RID: 114609
				[Token(Token = "0x401C478")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFB2 RID: 114610
				[Token(Token = "0x401C479")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFB3 RID: 114611
				[Token(Token = "0x401C47A")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState3.TouchStateArray3 <>4__this;
			}
		}
	}
}
