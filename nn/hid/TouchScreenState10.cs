using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200158B RID: 5515
	[Token(Token = "0x2000F26")]
	public struct TouchScreenState10
	{
		// Token: 0x06007CF6 RID: 31990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680C")]
		[Address(RVA = "0x3836B0", Offset = "0x3837B1", VA = "0x3836B0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C011 RID: 114705
		[Token(Token = "0x40188F2")]
		public const int TouchCount = 10;

		// Token: 0x0401C012 RID: 114706
		[Token(Token = "0x40188F3")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C013 RID: 114707
		[Token(Token = "0x40188F4")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C014 RID: 114708
		[Token(Token = "0x40188F5")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C015 RID: 114709
		[Token(Token = "0x40188F6")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState10.TouchStateArray10 touches;

		// Token: 0x0200158C RID: 5516
		[Token(Token = "0x20015BF")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A7C0", Offset = "0x15A8C1")]
		public struct TouchStateArray10 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EEC RID: 3820
			// (get) Token: 0x06007CF7 RID: 31991 RVA: 0x0002C5C8 File Offset: 0x0002A7C8
			[Token(Token = "0x17000F2D")]
			public int Length
			{
				[Token(Token = "0x6007F2D")]
				[Address(RVA = "0x3836C0", Offset = "0x3837C1", VA = "0x3836C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EED RID: 3821
			// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
			// (set) Token: 0x06007CF9 RID: 31993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F2E")]
			public TouchState Item
			{
				[Token(Token = "0x6007F2E")]
				[Address(RVA = "0x3836D0", Offset = "0x3837D1", VA = "0x3836D0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F2F")]
				[Address(RVA = "0x3836E0", Offset = "0x3837E1", VA = "0x3836E0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EEE RID: 3822
			// (get) Token: 0x06007CFA RID: 31994 RVA: 0x0002C5F8 File Offset: 0x0002A7F8
			[Token(Token = "0x17000F2F")]
			public int Count
			{
				[Token(Token = "0x6007F30")]
				[Address(RVA = "0x383720", Offset = "0x383821", VA = "0x383720", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EEF RID: 3823
			// (get) Token: 0x06007CFB RID: 31995 RVA: 0x0002C610 File Offset: 0x0002A810
			[Token(Token = "0x17000F30")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F31")]
				[Address(RVA = "0x383730", Offset = "0x383831", VA = "0x383730", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007CFC RID: 31996 RVA: 0x0002C628 File Offset: 0x0002A828
			[Token(Token = "0x6007F32")]
			[Address(RVA = "0x383740", Offset = "0x383841", VA = "0x383740", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CFD RID: 31997 RVA: 0x0002C640 File Offset: 0x0002A840
			[Token(Token = "0x6007F33")]
			[Address(RVA = "0x383830", Offset = "0x383931", VA = "0x383830", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007CFE RID: 31998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F34")]
			[Address(RVA = "0x383910", Offset = "0x383A11", VA = "0x383910", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007CFF RID: 31999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F35")]
			[Address(RVA = "0x383920", Offset = "0x383A21", VA = "0x383920", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D00 RID: 32000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F36")]
			[Address(RVA = "0x383930", Offset = "0x383A31", VA = "0x383930", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6F50", Offset = "0x1B7051")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D01 RID: 32001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F37")]
			[Address(RVA = "0x3839D0", Offset = "0x383AD1", VA = "0x3839D0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D02 RID: 32002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F38")]
			[Address(RVA = "0x383A70", Offset = "0x383B71", VA = "0x383A70", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D03 RID: 32003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F39")]
			[Address(RVA = "0x383A80", Offset = "0x383B81", VA = "0x383A80", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D04 RID: 32004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F3A")]
			[Address(RVA = "0x383A90", Offset = "0x383B91", VA = "0x383A90", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D05 RID: 32005 RVA: 0x0002C658 File Offset: 0x0002A858
			[Token(Token = "0x6007F3B")]
			[Address(RVA = "0x383AA0", Offset = "0x383BA1", VA = "0x383AA0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D06 RID: 32006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F3C")]
			[Address(RVA = "0x383AB0", Offset = "0x383BB1", VA = "0x383AB0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C016 RID: 114710
			[Token(Token = "0x401C2F5")]
			private const int _Length = 10;

			// Token: 0x0401C017 RID: 114711
			[Token(Token = "0x401C2F6")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C018 RID: 114712
			[Token(Token = "0x401C2F7")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C019 RID: 114713
			[Token(Token = "0x401C2F8")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C01A RID: 114714
			[Token(Token = "0x401C2F9")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C01B RID: 114715
			[Token(Token = "0x401C2FA")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C01C RID: 114716
			[Token(Token = "0x401C2FB")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C01D RID: 114717
			[Token(Token = "0x401C2FC")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C01E RID: 114718
			[Token(Token = "0x401C2FD")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C01F RID: 114719
			[Token(Token = "0x401C2FE")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C020 RID: 114720
			[Token(Token = "0x401C2FF")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0200158D RID: 5517
			[Token(Token = "0x2001679")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF80", Offset = "0x15B081")]
			private sealed class <GetEnumerator>d__24 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D07 RID: 32007 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008144")]
				[Address(RVA = "0x2D65B60", Offset = "0x2D65C61", VA = "0x2D65B60")]
				[DebuggerHidden]
				public <GetEnumerator>d__24(int <>1__state)
				{
				}

				// Token: 0x06007D08 RID: 32008 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008145")]
				[Address(RVA = "0x2D65E10", Offset = "0x2D65F11", VA = "0x2D65E10", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D09 RID: 32009 RVA: 0x0002C670 File Offset: 0x0002A870
				[Token(Token = "0x6008146")]
				[Address(RVA = "0x2D65E20", Offset = "0x2D65F21", VA = "0x2D65E20", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EF0 RID: 3824
				// (get) Token: 0x06007D0A RID: 32010 RVA: 0x0002C688 File Offset: 0x0002A888
				[Token(Token = "0x17000F7D")]
				private TouchState Current
				{
					[Token(Token = "0x6008147")]
					[Address(RVA = "0x2D65FC0", Offset = "0x2D660C1", VA = "0x2D65FC0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D0B RID: 32011 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008148")]
				[Address(RVA = "0x2D65FE0", Offset = "0x2D660E1", VA = "0x2D65FE0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EF1 RID: 3825
				// (get) Token: 0x06007D0C RID: 32012 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F7E")]
				private object Current
				{
					[Token(Token = "0x6008149")]
					[Address(RVA = "0x2D66040", Offset = "0x2D66141", VA = "0x2D66040", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C021 RID: 114721
				[Token(Token = "0x401C48D")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C022 RID: 114722
				[Token(Token = "0x401C48E")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C023 RID: 114723
				[Token(Token = "0x401C48F")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState10.TouchStateArray10 <>4__this;
			}
		}
	}
}
