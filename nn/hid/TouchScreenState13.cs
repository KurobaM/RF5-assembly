using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001594 RID: 5524
	[Token(Token = "0x2000F29")]
	public struct TouchScreenState13
	{
		// Token: 0x06007D3B RID: 32059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600680F")]
		[Address(RVA = "0x3842E0", Offset = "0x3843E1", VA = "0x3842E0")]
		public void SetDefault()
		{
		}

		// Token: 0x0401C04D RID: 114765
		[Token(Token = "0x4018901")]
		public const int TouchCount = 13;

		// Token: 0x0401C04E RID: 114766
		[Token(Token = "0x4018902")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401C04F RID: 114767
		[Token(Token = "0x4018903")]
		[FieldOffset(Offset = "0x8")]
		public int count;

		// Token: 0x0401C050 RID: 114768
		[Token(Token = "0x4018904")]
		[FieldOffset(Offset = "0xC")]
		private int _reserved;

		// Token: 0x0401C051 RID: 114769
		[Token(Token = "0x4018905")]
		[FieldOffset(Offset = "0x10")]
		public TouchScreenState13.TouchStateArray13 touches;

		// Token: 0x02001595 RID: 5525
		[Token(Token = "0x20015C2")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A880", Offset = "0x15A981")]
		public struct TouchStateArray13 : IList<TouchState>, ICollection<TouchState>, IEnumerable<TouchState>, IEnumerable
		{
			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x06007D3C RID: 32060 RVA: 0x0002C850 File Offset: 0x0002AA50
			[Token(Token = "0x17000F39")]
			public int Length
			{
				[Token(Token = "0x6007F5D")]
				[Address(RVA = "0x3842F0", Offset = "0x3843F1", VA = "0x3842F0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x06007D3D RID: 32061 RVA: 0x0002C868 File Offset: 0x0002AA68
			// (set) Token: 0x06007D3E RID: 32062 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F3A")]
			public TouchState Item
			{
				[Token(Token = "0x6007F5E")]
				[Address(RVA = "0x384300", Offset = "0x384401", VA = "0x384300", Slot = "4")]
				get
				{
					return default(TouchState);
				}
				[Token(Token = "0x6007F5F")]
				[Address(RVA = "0x384310", Offset = "0x384411", VA = "0x384310", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x06007D3F RID: 32063 RVA: 0x0002C880 File Offset: 0x0002AA80
			[Token(Token = "0x17000F3B")]
			public int Count
			{
				[Token(Token = "0x6007F60")]
				[Address(RVA = "0x384350", Offset = "0x384451", VA = "0x384350", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F01 RID: 3841
			// (get) Token: 0x06007D40 RID: 32064 RVA: 0x0002C898 File Offset: 0x0002AA98
			[Token(Token = "0x17000F3C")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007F61")]
				[Address(RVA = "0x384360", Offset = "0x384461", VA = "0x384360", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007D41 RID: 32065 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
			[Token(Token = "0x6007F62")]
			[Address(RVA = "0x384370", Offset = "0x384471", VA = "0x384370", Slot = "13")]
			public bool Contains(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D42 RID: 32066 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
			[Token(Token = "0x6007F63")]
			[Address(RVA = "0x384460", Offset = "0x384561", VA = "0x384460", Slot = "6")]
			public int IndexOf(TouchState item)
			{
				return 0;
			}

			// Token: 0x06007D43 RID: 32067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F64")]
			[Address(RVA = "0x384540", Offset = "0x384641", VA = "0x384540", Slot = "14")]
			public void CopyTo(TouchState[] array, int arrayIndex)
			{
			}

			// Token: 0x06007D44 RID: 32068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F65")]
			[Address(RVA = "0x384550", Offset = "0x384651", VA = "0x384550", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007D45 RID: 32069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F66")]
			[Address(RVA = "0x384560", Offset = "0x384661", VA = "0x384560", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B70A0", Offset = "0x1B71A1")]
			public IEnumerator<TouchState> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D46 RID: 32070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007F67")]
			[Address(RVA = "0x384600", Offset = "0x384701", VA = "0x384600", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007D47 RID: 32071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F68")]
			[Address(RVA = "0x3846A0", Offset = "0x3847A1", VA = "0x3846A0", Slot = "11")]
			public void Add(TouchState item)
			{
			}

			// Token: 0x06007D48 RID: 32072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F69")]
			[Address(RVA = "0x3846B0", Offset = "0x3847B1", VA = "0x3846B0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007D49 RID: 32073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F6A")]
			[Address(RVA = "0x3846C0", Offset = "0x3847C1", VA = "0x3846C0", Slot = "7")]
			public void Insert(int index, TouchState item)
			{
			}

			// Token: 0x06007D4A RID: 32074 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
			[Token(Token = "0x6007F6B")]
			[Address(RVA = "0x3846D0", Offset = "0x3847D1", VA = "0x3846D0", Slot = "15")]
			public bool Remove(TouchState item)
			{
				return default(bool);
			}

			// Token: 0x06007D4B RID: 32075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F6C")]
			[Address(RVA = "0x3846E0", Offset = "0x3847E1", VA = "0x3846E0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C052 RID: 114770
			[Token(Token = "0x401C319")]
			private const int _Length = 13;

			// Token: 0x0401C053 RID: 114771
			[Token(Token = "0x401C31A")]
			[FieldOffset(Offset = "0x0")]
			private TouchState _value0;

			// Token: 0x0401C054 RID: 114772
			[Token(Token = "0x401C31B")]
			[FieldOffset(Offset = "0x28")]
			private TouchState _value1;

			// Token: 0x0401C055 RID: 114773
			[Token(Token = "0x401C31C")]
			[FieldOffset(Offset = "0x50")]
			private TouchState _value2;

			// Token: 0x0401C056 RID: 114774
			[Token(Token = "0x401C31D")]
			[FieldOffset(Offset = "0x78")]
			private TouchState _value3;

			// Token: 0x0401C057 RID: 114775
			[Token(Token = "0x401C31E")]
			[FieldOffset(Offset = "0xA0")]
			private TouchState _value4;

			// Token: 0x0401C058 RID: 114776
			[Token(Token = "0x401C31F")]
			[FieldOffset(Offset = "0xC8")]
			private TouchState _value5;

			// Token: 0x0401C059 RID: 114777
			[Token(Token = "0x401C320")]
			[FieldOffset(Offset = "0xF0")]
			private TouchState _value6;

			// Token: 0x0401C05A RID: 114778
			[Token(Token = "0x401C321")]
			[FieldOffset(Offset = "0x118")]
			private TouchState _value7;

			// Token: 0x0401C05B RID: 114779
			[Token(Token = "0x401C322")]
			[FieldOffset(Offset = "0x140")]
			private TouchState _value8;

			// Token: 0x0401C05C RID: 114780
			[Token(Token = "0x401C323")]
			[FieldOffset(Offset = "0x168")]
			private TouchState _value9;

			// Token: 0x0401C05D RID: 114781
			[Token(Token = "0x401C324")]
			[FieldOffset(Offset = "0x190")]
			private TouchState _value10;

			// Token: 0x0401C05E RID: 114782
			[Token(Token = "0x401C325")]
			[FieldOffset(Offset = "0x1B8")]
			private TouchState _value11;

			// Token: 0x0401C05F RID: 114783
			[Token(Token = "0x401C326")]
			[FieldOffset(Offset = "0x1E0")]
			private TouchState _value12;

			// Token: 0x02001596 RID: 5526
			[Token(Token = "0x200167C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AFB0", Offset = "0x15B0B1")]
			private sealed class <GetEnumerator>d__27 : IEnumerator<TouchState>, IEnumerator, IDisposable
			{
				// Token: 0x06007D4C RID: 32076 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008156")]
				[Address(RVA = "0x2D699F0", Offset = "0x2D69AF1", VA = "0x2D699F0")]
				[DebuggerHidden]
				public <GetEnumerator>d__27(int <>1__state)
				{
				}

				// Token: 0x06007D4D RID: 32077 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008157")]
				[Address(RVA = "0x2D69CA0", Offset = "0x2D69DA1", VA = "0x2D69CA0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007D4E RID: 32078 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
				[Token(Token = "0x6008158")]
				[Address(RVA = "0x2D69CB0", Offset = "0x2D69DB1", VA = "0x2D69CB0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000F02 RID: 3842
				// (get) Token: 0x06007D4F RID: 32079 RVA: 0x0002C910 File Offset: 0x0002AB10
				[Token(Token = "0x17000F83")]
				private TouchState Current
				{
					[Token(Token = "0x6008159")]
					[Address(RVA = "0x2D69ED0", Offset = "0x2D69FD1", VA = "0x2D69ED0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(TouchState);
					}
				}

				// Token: 0x06007D50 RID: 32080 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600815A")]
				[Address(RVA = "0x2D69EF0", Offset = "0x2D69FF1", VA = "0x2D69EF0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000F03 RID: 3843
				// (get) Token: 0x06007D51 RID: 32081 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F84")]
				private object Current
				{
					[Token(Token = "0x600815B")]
					[Address(RVA = "0x2D69F50", Offset = "0x2D6A051", VA = "0x2D69F50", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C060 RID: 114784
				[Token(Token = "0x401C496")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C061 RID: 114785
				[Token(Token = "0x401C497")]
				[FieldOffset(Offset = "0x18")]
				private TouchState <>2__current;

				// Token: 0x0401C062 RID: 114786
				[Token(Token = "0x401C498")]
				[FieldOffset(Offset = "0x40")]
				public TouchScreenState13.TouchStateArray13 <>4__this;
			}
		}
	}
}
