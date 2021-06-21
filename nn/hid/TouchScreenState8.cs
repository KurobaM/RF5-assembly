using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001585 RID: 5509
	[Token(Token = "0x2000F24")]
	public struct TouchScreenState8
	{
		// Token: 0x06007CC8 RID: 31944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680A")]
		[Address(RVA = "0x387330", Offset = "0x387431", VA = "0x387330")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFEE RID: 114670
		[Token(Token = "0x40188E8")]
		public const int TouchCount = 8;

		// Token: 0x0401BFEF RID: 114671
		[Token(Token = "0x40188E9")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BFF0 RID: 114672
		[Token(Token = "0x40188EA")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFF1 RID: 114673
		[Token(Token = "0x40188EB")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFF2 RID: 114674
		[Token(Token = "0x40188EC")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState8.TouchStateArray8 touches;

		// Token: 0x02001586 RID: 5510
		[Token(Token = "0x20015BD")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A740", Offset = "0x15A841")]
		public struct TouchStateArray8 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EE0 RID: 3808
			// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x0002C418 File Offset: 0x0002A618
			[Token(Token = "0x17000F25")]
			public int Length
			{
				[Token(Token = "0x6007F0D")]
				[Address(RVA = "0x387340", Offset = "0x387441", VA = "0x387340")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EE1 RID: 3809
			// (get) Token: 0x06007CCA RID: 31946 RVA: 0x0002C430 File Offset: 0x0002A630
			// (set) Token: 0x06007CCB RID: 31947 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F26")]
			public TouchState Item
			{
				[Token(Token = "0x6007F0E")]
				[Address(RVA = "0x387350", Offset = "0x387451", VA = "0x387350", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F0F")]
				[Address(RVA = "0x3874B0", Offset = "0x3875B1", VA = "0x3874B0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EE2 RID: 3810
			// (get) Token: 0x06007CCC RID: 31948 RVA: 0x0002C448 File Offset: 0x0002A648
			[Token(Token = "0x17000F27")]
			public int Count
			{
				[Token(Token = "0x6007F10")]
				[Address(RVA = "0x387650", Offset = "0x387751", VA = "0x387650", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EE3 RID: 3811
			// (get) Token: 0x06007CCD RID: 31949 RVA: 0x0002C460 File Offset: 0x0002A660
			[Token(Token = "0x17000F28")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F11")]
				[Address(RVA = "0x387660", Offset = "0x387761", VA = "0x387660", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007CCE RID: 31950 RVA: 0x0002C478 File Offset: 0x0002A678
			[Token(Token = "0x6007F12")]
			[Address(RVA = "0x387670", Offset = "0x387771", VA = "0x387670", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CCF RID: 31951 RVA: 0x0002C490 File Offset: 0x0002A690
			[Token(Token = "0x6007F13")]
			[Address(RVA = "0x3876B0", Offset = "0x3877B1", VA = "0x3876B0", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007CD0 RID: 31952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F14")]
			[Address(RVA = "0x3876F0", Offset = "0x3877F1", VA = "0x3876F0", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007CD1 RID: 31953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F15")]
			[Address(RVA = "0x387700", Offset = "0x387801", VA = "0x387700", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007CD2 RID: 31954 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F16")]
			[Address(RVA = "0x387710", Offset = "0x387811", VA = "0x387710", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6E70", Offset = "0x1B6F71")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CD3 RID: 31955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F17")]
			[Address(RVA = "0x3877B0", Offset = "0x3878B1", VA = "0x3877B0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CD4 RID: 31956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F18")]
			[Address(RVA = "0x387850", Offset = "0x387951", VA = "0x387850", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007CD5 RID: 31957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F19")]
			[Address(RVA = "0x387860", Offset = "0x387961", VA = "0x387860", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007CD6 RID: 31958 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F1A")]
			[Address(RVA = "0x387870", Offset = "0x387971", VA = "0x387870", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007CD7 RID: 31959 RVA: 0x0002C4A8 File Offset: 0x0002A6A8
			[Token(Token = "0x6007F1B")]
			[Address(RVA = "0x387880", Offset = "0x387981", VA = "0x387880", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CD8 RID: 31960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F1C")]
			[Address(RVA = "0x387890", Offset = "0x387991", VA = "0x387890", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFF3 RID: 114675
			[Token(Token = "0x401C2E2")]
			private const int _Length = 8;

			// Token: 0x0401BFF4 RID: 114676
			[Token(Token = "0x401C2E3")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFF5 RID: 114677
			[Token(Token = "0x401C2E4")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401BFF6 RID: 114678
			[Token(Token = "0x401C2E5")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401BFF7 RID: 114679
			[Token(Token = "0x401C2E6")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401BFF8 RID: 114680
			[Token(Token = "0x401C2E7")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401BFF9 RID: 114681
			[Token(Token = "0x401C2E8")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401BFFA RID: 114682
			[Token(Token = "0x401C2E9")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401BFFB RID: 114683
			[Token(Token = "0x401C2EA")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x02001587 RID: 5511
			[Token(Token = "0x2001677")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF60", Offset = "0x15B061")]
			private sealed class <GetEnumerator>d__22 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007CD9 RID: 31961 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008138")]
				[Address(RVA = "0x2D762E0", Offset = "0x2D763E1", VA = "0x2D762E0")]
				[DebuggerHidden]
				public <GetEnumerator>d__22(int <>1__state)
				{
				}

				// Token: 0x06007CDA RID: 31962 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008139")]
				[Address(RVA = "0x2D76590", Offset = "0x2D76691", VA = "0x2D76590", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007CDB RID: 31963 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
				[Token(Token = "0x600813A")]
				[Address(RVA = "0x2D765A0", Offset = "0x2D766A1", VA = "0x2D765A0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EE4 RID: 3812
				// (get) Token: 0x06007CDC RID: 31964 RVA: 0x0002C4D8 File Offset: 0x0002A6D8
				[Token(Token = "0x17000F79")]
				private TouchState Current
				{
					[Token(Token = "0x600813B")]
					[Address(RVA = "0x2D76700", Offset = "0x2D76801", VA = "0x2D76700", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007CDD RID: 31965 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600813C")]
				[Address(RVA = "0x2D76720", Offset = "0x2D76821", VA = "0x2D76720", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EE5 RID: 3813
				// (get) Token: 0x06007CDE RID: 31966 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F7A")]
				private object Current
				{
					[Token(Token = "0x600813D")]
					[Address(RVA = "0x2D76780", Offset = "0x2D76881", VA = "0x2D76780", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFFC RID: 114684
				[Token(Token = "0x401C487")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFFD RID: 114685
				[Token(Token = "0x401C488")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFFE RID: 114686
				[Token(Token = "0x401C489")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState8.TouchStateArray8 <>4__this;
			}
		}
	}
}
