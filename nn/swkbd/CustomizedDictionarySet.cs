using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.swkbd
{
	// Token: 0x020014F9 RID: 5369
	[Token(Token = "0x2000EBC")]
	public struct CustomizedDictionarySet
	{
		// Token: 0x0401BD24 RID: 113956
		[Token(Token = "0x4018716")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr pDictionaries;

		// Token: 0x0401BD25 RID: 113957
		[Token(Token = "0x4018717")]
		[FieldOffset(Offset = "0x8")]
		public uint dictionariesSize;

		// Token: 0x0401BD26 RID: 113958
		[Token(Token = "0x4018718")]
		[FieldOffset(Offset = "0xC")]
		public CustomizedDictionarySet.DictionaryInfoArray24 dicInfoList;

		// Token: 0x0401BD27 RID: 113959
		[Token(Token = "0x4018719")]
		[FieldOffset(Offset = "0xCC")]
		public ushort count;

		// Token: 0x020014FA RID: 5370
		[Token(Token = "0x20015A9")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A330", Offset = "0x15A431")]
		public struct DictionaryInfoArray24 : IList<DictionaryInfo>, ICollection<DictionaryInfo>, IEnumerable<DictionaryInfo>, IEnumerable
		{
			// Token: 0x17000E62 RID: 3682
			// (get) Token: 0x06007A2F RID: 31279 RVA: 0x0002AB28 File Offset: 0x00028D28
			[Token(Token = "0x17000EE5")]
			public int Length
			{
				[Token(Token = "0x6007E0D")]
				[Address(RVA = "0x3A04E0", Offset = "0x3A05E1", VA = "0x3A04E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E63 RID: 3683
			// (get) Token: 0x06007A30 RID: 31280 RVA: 0x0002AB40 File Offset: 0x00028D40
			// (set) Token: 0x06007A31 RID: 31281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EE6")]
			public DictionaryInfo Item
			{
				[Token(Token = "0x6007E0E")]
				[Address(RVA = "0x3A04F0", Offset = "0x3A05F1", VA = "0x3A04F0", Slot = "4")]
				get
				{
					return default(DictionaryInfo);
				}
				[Token(Token = "0x6007E0F")]
				[Address(RVA = "0x3A0500", Offset = "0x3A0601", VA = "0x3A0500", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E64 RID: 3684
			// (get) Token: 0x06007A32 RID: 31282 RVA: 0x0002AB58 File Offset: 0x00028D58
			[Token(Token = "0x17000EE7")]
			public int Count
			{
				[Token(Token = "0x6007E10")]
				[Address(RVA = "0x3A0510", Offset = "0x3A0611", VA = "0x3A0510", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E65 RID: 3685
			// (get) Token: 0x06007A33 RID: 31283 RVA: 0x0002AB70 File Offset: 0x00028D70
			[Token(Token = "0x17000EE8")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E11")]
				[Address(RVA = "0x3A0520", Offset = "0x3A0621", VA = "0x3A0520", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007A34 RID: 31284 RVA: 0x0002AB88 File Offset: 0x00028D88
			[Token(Token = "0x6007E12")]
			[Address(RVA = "0x3A0530", Offset = "0x3A0631", VA = "0x3A0530", Slot = "13")]
			public bool Contains(DictionaryInfo item)
			{
				return default(bool);
			}

			// Token: 0x06007A35 RID: 31285 RVA: 0x0002ABA0 File Offset: 0x00028DA0
			[Token(Token = "0x6007E13")]
			[Address(RVA = "0x3A05B0", Offset = "0x3A06B1", VA = "0x3A05B0", Slot = "6")]
			public int IndexOf(DictionaryInfo item)
			{
				return 0;
			}

			// Token: 0x06007A36 RID: 31286 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E14")]
			[Address(RVA = "0x3A0630", Offset = "0x3A0731", VA = "0x3A0630", Slot = "14")]
			public void CopyTo(DictionaryInfo[] array, int arrayIndex)
			{
			}

			// Token: 0x06007A37 RID: 31287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E15")]
			[Address(RVA = "0x3A0640", Offset = "0x3A0741", VA = "0x3A0640", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007A38 RID: 31288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E16")]
			[Address(RVA = "0x3A0650", Offset = "0x3A0751", VA = "0x3A0650", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6770", Offset = "0x1B6871")]
			public IEnumerator<DictionaryInfo> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007A39 RID: 31289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E17")]
			[Address(RVA = "0x3A06F0", Offset = "0x3A07F1", VA = "0x3A06F0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007A3A RID: 31290 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E18")]
			[Address(RVA = "0x3A0790", Offset = "0x3A0891", VA = "0x3A0790", Slot = "11")]
			public void Add(DictionaryInfo item)
			{
			}

			// Token: 0x06007A3B RID: 31291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E19")]
			[Address(RVA = "0x3A07A0", Offset = "0x3A08A1", VA = "0x3A07A0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007A3C RID: 31292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1A")]
			[Address(RVA = "0x3A07B0", Offset = "0x3A08B1", VA = "0x3A07B0", Slot = "7")]
			public void Insert(int index, DictionaryInfo item)
			{
			}

			// Token: 0x06007A3D RID: 31293 RVA: 0x0002ABB8 File Offset: 0x00028DB8
			[Token(Token = "0x6007E1B")]
			[Address(RVA = "0x3A07C0", Offset = "0x3A08C1", VA = "0x3A07C0", Slot = "15")]
			public bool Remove(DictionaryInfo item)
			{
				return default(bool);
			}

			// Token: 0x06007A3E RID: 31294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E1C")]
			[Address(RVA = "0x3A07D0", Offset = "0x3A08D1", VA = "0x3A07D0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BD28 RID: 113960
			[Token(Token = "0x401C21A")]
			private const int _Length = 24;

			// Token: 0x0401BD29 RID: 113961
			[Token(Token = "0x401C21B")]
			[FieldOffset(Offset = "0x0")]
			private DictionaryInfo _value0;

			// Token: 0x0401BD2A RID: 113962
			[Token(Token = "0x401C21C")]
			[FieldOffset(Offset = "0x8")]
			private DictionaryInfo _value1;

			// Token: 0x0401BD2B RID: 113963
			[Token(Token = "0x401C21D")]
			[FieldOffset(Offset = "0x10")]
			private DictionaryInfo _value2;

			// Token: 0x0401BD2C RID: 113964
			[Token(Token = "0x401C21E")]
			[FieldOffset(Offset = "0x18")]
			private DictionaryInfo _value3;

			// Token: 0x0401BD2D RID: 113965
			[Token(Token = "0x401C21F")]
			[FieldOffset(Offset = "0x20")]
			private DictionaryInfo _value4;

			// Token: 0x0401BD2E RID: 113966
			[Token(Token = "0x401C220")]
			[FieldOffset(Offset = "0x28")]
			private DictionaryInfo _value5;

			// Token: 0x0401BD2F RID: 113967
			[Token(Token = "0x401C221")]
			[FieldOffset(Offset = "0x30")]
			private DictionaryInfo _value6;

			// Token: 0x0401BD30 RID: 113968
			[Token(Token = "0x401C222")]
			[FieldOffset(Offset = "0x38")]
			private DictionaryInfo _value7;

			// Token: 0x0401BD31 RID: 113969
			[Token(Token = "0x401C223")]
			[FieldOffset(Offset = "0x40")]
			private DictionaryInfo _value8;

			// Token: 0x0401BD32 RID: 113970
			[Token(Token = "0x401C224")]
			[FieldOffset(Offset = "0x48")]
			private DictionaryInfo _value9;

			// Token: 0x0401BD33 RID: 113971
			[Token(Token = "0x401C225")]
			[FieldOffset(Offset = "0x50")]
			private DictionaryInfo _value10;

			// Token: 0x0401BD34 RID: 113972
			[Token(Token = "0x401C226")]
			[FieldOffset(Offset = "0x58")]
			private DictionaryInfo _value11;

			// Token: 0x0401BD35 RID: 113973
			[Token(Token = "0x401C227")]
			[FieldOffset(Offset = "0x60")]
			private DictionaryInfo _value12;

			// Token: 0x0401BD36 RID: 113974
			[Token(Token = "0x401C228")]
			[FieldOffset(Offset = "0x68")]
			private DictionaryInfo _value13;

			// Token: 0x0401BD37 RID: 113975
			[Token(Token = "0x401C229")]
			[FieldOffset(Offset = "0x70")]
			private DictionaryInfo _value14;

			// Token: 0x0401BD38 RID: 113976
			[Token(Token = "0x401C22A")]
			[FieldOffset(Offset = "0x78")]
			private DictionaryInfo _value15;

			// Token: 0x0401BD39 RID: 113977
			[Token(Token = "0x401C22B")]
			[FieldOffset(Offset = "0x80")]
			private DictionaryInfo _value16;

			// Token: 0x0401BD3A RID: 113978
			[Token(Token = "0x401C22C")]
			[FieldOffset(Offset = "0x88")]
			private DictionaryInfo _value17;

			// Token: 0x0401BD3B RID: 113979
			[Token(Token = "0x401C22D")]
			[FieldOffset(Offset = "0x90")]
			private DictionaryInfo _value18;

			// Token: 0x0401BD3C RID: 113980
			[Token(Token = "0x401C22E")]
			[FieldOffset(Offset = "0x98")]
			private DictionaryInfo _value19;

			// Token: 0x0401BD3D RID: 113981
			[Token(Token = "0x401C22F")]
			[FieldOffset(Offset = "0xA0")]
			private DictionaryInfo _value20;

			// Token: 0x0401BD3E RID: 113982
			[Token(Token = "0x401C230")]
			[FieldOffset(Offset = "0xA8")]
			private DictionaryInfo _value21;

			// Token: 0x0401BD3F RID: 113983
			[Token(Token = "0x401C231")]
			[FieldOffset(Offset = "0xB0")]
			private DictionaryInfo _value22;

			// Token: 0x0401BD40 RID: 113984
			[Token(Token = "0x401C232")]
			[FieldOffset(Offset = "0xB8")]
			private DictionaryInfo _value23;

			// Token: 0x020014FB RID: 5371
			[Token(Token = "0x2001667")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE60", Offset = "0x15AF61")]
			private sealed class <GetEnumerator>d__38 : IEnumerator<DictionaryInfo>, IEnumerator, IDisposable
			{
				// Token: 0x06007A3F RID: 31295 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080D8")]
				[Address(RVA = "0x34E29D0", Offset = "0x34E2AD1", VA = "0x34E29D0")]
				[DebuggerHidden]
				public <GetEnumerator>d__38(int <>1__state)
				{
				}

				// Token: 0x06007A40 RID: 31296 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080D9")]
				[Address(RVA = "0x34E2C80", Offset = "0x34E2D81", VA = "0x34E2C80", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007A41 RID: 31297 RVA: 0x0002ABD0 File Offset: 0x00028DD0
				[Token(Token = "0x60080DA")]
				[Address(RVA = "0x34E2C90", Offset = "0x34E2D91", VA = "0x34E2C90", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E66 RID: 3686
				// (get) Token: 0x06007A42 RID: 31298 RVA: 0x0002ABE8 File Offset: 0x00028DE8
				[Token(Token = "0x17000F59")]
				private DictionaryInfo Current
				{
					[Token(Token = "0x60080DB")]
					[Address(RVA = "0x34E2DF0", Offset = "0x34E2EF1", VA = "0x34E2DF0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(DictionaryInfo);
					}
				}

				// Token: 0x06007A43 RID: 31299 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080DC")]
				[Address(RVA = "0x34E2E00", Offset = "0x34E2F01", VA = "0x34E2E00", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E67 RID: 3687
				// (get) Token: 0x06007A44 RID: 31300 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F5A")]
				private object Current
				{
					[Token(Token = "0x60080DD")]
					[Address(RVA = "0x34E2E60", Offset = "0x34E2F61", VA = "0x34E2E60", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BD41 RID: 113985
				[Token(Token = "0x401C457")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BD42 RID: 113986
				[Token(Token = "0x401C458")]
				[FieldOffset(Offset = "0x14")]
				private DictionaryInfo <>2__current;

				// Token: 0x0401BD43 RID: 113987
				[Token(Token = "0x401C459")]
				[FieldOffset(Offset = "0x1C")]
				public CustomizedDictionarySet.DictionaryInfoArray24 <>4__this;
			}
		}
	}
}
