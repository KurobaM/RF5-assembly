using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001579 RID: 5497
	[Token(Token = "0x2000F20")]
	public struct TouchScreenState4
	{
		// Token: 0x06007C6C RID: 31852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006806")]
		[Address(RVA = "0x385EA0", Offset = "0x385FA1", VA = "0x385EA0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401BFB4 RID: 114612
		[Token(Token = "0x40188D4")]
		public const int TouchCount = 4;

		// Token: 0x0401BFB5 RID: 114613
		[Token(Token = "0x40188D5")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BFB6 RID: 114614
		[Token(Token = "0x40188D6")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401BFB7 RID: 114615
		[Token(Token = "0x40188D7")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401BFB8 RID: 114616
		[Token(Token = "0x40188D8")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState4.TouchStateArray4 touches;

		// Token: 0x0200157A RID: 5498
		[Token(Token = "0x20015B9")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A640", Offset = "0x15A741")]
		public struct TouchStateArray4 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06007C6D RID: 31853 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
			[Token(Token = "0x17000F15")]
			public int Length
			{
				[Token(Token = "0x6007ECD")]
				[Address(RVA = "0x385ED0", Offset = "0x385FD1", VA = "0x385ED0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x06007C6E RID: 31854 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
			// (set) Token: 0x06007C6F RID: 31855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F16")]
			public TouchState Item
			{
				[Token(Token = "0x6007ECE")]
				[Address(RVA = "0x385EE0", Offset = "0x385FE1", VA = "0x385EE0", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007ECF")]
				[Address(RVA = "0x385FF0", Offset = "0x3860F1", VA = "0x385FF0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000ECA RID: 3786
			// (get) Token: 0x06007C70 RID: 31856 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
			[Token(Token = "0x17000F17")]
			public int Count
			{
				[Token(Token = "0x6007ED0")]
				[Address(RVA = "0x386120", Offset = "0x386221", VA = "0x386120", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000ECB RID: 3787
			// (get) Token: 0x06007C71 RID: 31857 RVA: 0x0002C100 File Offset: 0x0002A300
			[Token(Token = "0x17000F18")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007ED1")]
				[Address(RVA = "0x386130", Offset = "0x386231", VA = "0x386130", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007C72 RID: 31858 RVA: 0x0002C118 File Offset: 0x0002A318
			[Token(Token = "0x6007ED2")]
			[Address(RVA = "0x386140", Offset = "0x386241", VA = "0x386140", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C73 RID: 31859 RVA: 0x0002C130 File Offset: 0x0002A330
			[Token(Token = "0x6007ED3")]
			[Address(RVA = "0x386180", Offset = "0x386281", VA = "0x386180", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007C74 RID: 31860 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ED4")]
			[Address(RVA = "0x3861C0", Offset = "0x3862C1", VA = "0x3861C0", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007C75 RID: 31861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007ED5")]
			[Address(RVA = "0x3861D0", Offset = "0x3862D1", VA = "0x3861D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007C76 RID: 31862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007ED6")]
			[Address(RVA = "0x3861E0", Offset = "0x3862E1", VA = "0x3861E0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6CB0", Offset = "0x1B6DB1")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C77 RID: 31863 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007ED7")]
			[Address(RVA = "0x386280", Offset = "0x386381", VA = "0x386280", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007C78 RID: 31864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ED8")]
			[Address(RVA = "0x386320", Offset = "0x386421", VA = "0x386320", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007C79 RID: 31865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007ED9")]
			[Address(RVA = "0x386330", Offset = "0x386431", VA = "0x386330", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007C7A RID: 31866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EDA")]
			[Address(RVA = "0x386340", Offset = "0x386441", VA = "0x386340", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007C7B RID: 31867 RVA: 0x0002C148 File Offset: 0x0002A348
			[Token(Token = "0x6007EDB")]
			[Address(RVA = "0x386350", Offset = "0x386451", VA = "0x386350", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007C7C RID: 31868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007EDC")]
			[Address(RVA = "0x386360", Offset = "0x386461", VA = "0x386360", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BFB9 RID: 114617
			[Token(Token = "0x401C2C8")]
			private const int _Length = 4;

			// Token: 0x0401BFBA RID: 114618
			[Token(Token = "0x401C2C9")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401BFBB RID: 114619
			[Token(Token = "0x401C2CA")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401BFBC RID: 114620
			[Token(Token = "0x401C2CB")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401BFBD RID: 114621
			[Token(Token = "0x401C2CC")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0200157B RID: 5499
			[Token(Token = "0x2001673")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AF20", Offset = "0x15B021")]
			private sealed class <GetEnumerator>d__18 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007C7D RID: 31869 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008120")]
				[Address(RVA = "0x2D70DA0", Offset = "0x2D70EA1", VA = "0x2D70DA0")]
				[DebuggerHidden]
				public <GetEnumerator>d__18(int <>1__state)
				{
				}

				// Token: 0x06007C7E RID: 31870 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008121")]
				[Address(RVA = "0x2D71050", Offset = "0x2D71151", VA = "0x2D71050", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007C7F RID: 31871 RVA: 0x0002C160 File Offset: 0x0002A360
				[Token(Token = "0x6008122")]
				[Address(RVA = "0x2D71060", Offset = "0x2D71161", VA = "0x2D71060", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000ECC RID: 3788
				// (get) Token: 0x06007C80 RID: 31872 RVA: 0x0002C178 File Offset: 0x0002A378
				[Token(Token = "0x17000F71")]
				private TouchState Current
				{
					[Token(Token = "0x6008123")]
					[Address(RVA = "0x2D71130", Offset = "0x2D71231", VA = "0x2D71130", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007C81 RID: 31873 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008124")]
				[Address(RVA = "0x2D71150", Offset = "0x2D71251", VA = "0x2D71150", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000ECD RID: 3789
				// (get) Token: 0x06007C82 RID: 31874 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F72")]
				private object Current
				{
					[Token(Token = "0x6008125")]
					[Address(RVA = "0x2D711B0", Offset = "0x2D712B1", VA = "0x2D711B0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BFBE RID: 114622
				[Token(Token = "0x401C47B")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BFBF RID: 114623
				[Token(Token = "0x401C47C")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401BFC0 RID: 114624
				[Token(Token = "0x401C47D")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState4.TouchStateArray4 <>4__this;
			}
		}
	}
}
