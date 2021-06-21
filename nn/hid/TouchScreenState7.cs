using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001582 RID: 5506
	[Token(Token = "0x2000F23")]
	public struct TouchScreenState7
	{
		// Token: 0x06007CB1 RID: 31921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006809")]
		[Address(RVA = "0x386DE0", Offset = "0x386EE1", VA = "0x386DE0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFDE RID: 114654
		[Token(Token = "0x40188E3")]
		public const int TouchCount = 7;

		// Token: 0x0401BFDF RID: 114655
		[Token(Token = "0x40188E4")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BFE0 RID: 114656
		[Token(Token = "0x40188E5")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFE1 RID: 114657
		[Token(Token = "0x40188E6")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFE2 RID: 114658
		[Token(Token = "0x40188E7")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState7.TouchStateArray7 touches;

		// Token: 0x02001583 RID: 5507
		[Token(Token = "0x20015BC")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A700", Offset = "0x15A801")]
		public struct TouchStateArray7 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EDA RID: 3802
			// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x0002C340 File Offset: 0x0002A540
			[Token(Token = "0x17000F21")]
			public int Length
			{
				[Token(Token = "0x6007EFD")]
				[Address(RVA = "0x386DF0", Offset = "0x386EF1", VA = "0x386DF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EDB RID: 3803
			// (get) Token: 0x06007CB3 RID: 31923 RVA: 0x0002C358 File Offset: 0x0002A558
			// (set) Token: 0x06007CB4 RID: 31924 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F22")]
			public TouchState Item
			{
				[Token(Token = "0x6007EFE")]
				[Address(RVA = "0x386E00", Offset = "0x386F01", VA = "0x386E00", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007EFF")]
				[Address(RVA = "0x386F50", Offset = "0x387051", VA = "0x386F50", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EDC RID: 3804
			// (get) Token: 0x06007CB5 RID: 31925 RVA: 0x0002C370 File Offset: 0x0002A570
			[Token(Token = "0x17000F23")]
			public int Count
			{
				[Token(Token = "0x6007F00")]
				[Address(RVA = "0x3870E0", Offset = "0x3871E1", VA = "0x3870E0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EDD RID: 3805
			// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x0002C388 File Offset: 0x0002A588
			[Token(Token = "0x17000F24")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F01")]
				[Address(RVA = "0x3870F0", Offset = "0x3871F1", VA = "0x3870F0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007CB7 RID: 31927 RVA: 0x0002C3A0 File Offset: 0x0002A5A0
			[Token(Token = "0x6007F02")]
			[Address(RVA = "0x387100", Offset = "0x387201", VA = "0x387100", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CB8 RID: 31928 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
			[Token(Token = "0x6007F03")]
			[Address(RVA = "0x387140", Offset = "0x387241", VA = "0x387140", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007CB9 RID: 31929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F04")]
			[Address(RVA = "0x387180", Offset = "0x387281", VA = "0x387180", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007CBA RID: 31930 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F05")]
			[Address(RVA = "0x387190", Offset = "0x387291", VA = "0x387190", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007CBB RID: 31931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F06")]
			[Address(RVA = "0x3871A0", Offset = "0x3872A1", VA = "0x3871A0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6E00", Offset = "0x1B6F01")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CBC RID: 31932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F07")]
			[Address(RVA = "0x387240", Offset = "0x387341", VA = "0x387240", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007CBD RID: 31933 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F08")]
			[Address(RVA = "0x3872E0", Offset = "0x3873E1", VA = "0x3872E0", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007CBE RID: 31934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F09")]
			[Address(RVA = "0x3872F0", Offset = "0x3873F1", VA = "0x3872F0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007CBF RID: 31935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F0A")]
			[Address(RVA = "0x387300", Offset = "0x387401", VA = "0x387300", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007CC0 RID: 31936 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
			[Token(Token = "0x6007F0B")]
			[Address(RVA = "0x387310", Offset = "0x387411", VA = "0x387310", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007CC1 RID: 31937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F0C")]
			[Address(RVA = "0x387320", Offset = "0x387421", VA = "0x387320", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFE3 RID: 114659
			[Token(Token = "0x401C2DA")]
			private const int _Length = 7;

			// Token: 0x0401BFE4 RID: 114660
			[Token(Token = "0x401C2DB")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFE5 RID: 114661
			[Token(Token = "0x401C2DC")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401BFE6 RID: 114662
			[Token(Token = "0x401C2DD")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401BFE7 RID: 114663
			[Token(Token = "0x401C2DE")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401BFE8 RID: 114664
			[Token(Token = "0x401C2DF")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401BFE9 RID: 114665
			[Token(Token = "0x401C2E0")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401BFEA RID: 114666
			[Token(Token = "0x401C2E1")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x02001584 RID: 5508
			[Token(Token = "0x2001676")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF50", Offset = "0x15B051")]
			private sealed class <GetEnumerator>d__21 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007CC2 RID: 31938 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008132")]
				[Address(RVA = "0x2D74A30", Offset = "0x2D74B31", VA = "0x2D74A30")]
				[DebuggerHidden]
				public <GetEnumerator>d__21(int <>1__state)
				{
				}

				// Token: 0x06007CC3 RID: 31939 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008133")]
				[Address(RVA = "0x2D74CE0", Offset = "0x2D74DE1", VA = "0x2D74CE0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007CC4 RID: 31940 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
				[Token(Token = "0x6008134")]
				[Address(RVA = "0x2D74CF0", Offset = "0x2D74DF1", VA = "0x2D74CF0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EDE RID: 3806
				// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x0002C400 File Offset: 0x0002A600
				[Token(Token = "0x17000F77")]
				private TouchState Current
				{
					[Token(Token = "0x6008135")]
					[Address(RVA = "0x2D74E20", Offset = "0x2D74F21", VA = "0x2D74E20", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007CC6 RID: 31942 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008136")]
				[Address(RVA = "0x2D74E40", Offset = "0x2D74F41", VA = "0x2D74E40", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EDF RID: 3807
				// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F78")]
				private object Current
				{
					[Token(Token = "0x6008137")]
					[Address(RVA = "0x2D74EA0", Offset = "0x2D74FA1", VA = "0x2D74EA0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFEB RID: 114667
				[Token(Token = "0x401C484")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFEC RID: 114668
				[Token(Token = "0x401C485")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFED RID: 114669
				[Token(Token = "0x401C486")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState7.TouchStateArray7 <>4__this;
			}
		}
	}
}
