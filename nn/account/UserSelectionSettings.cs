using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.account
{
	// Token: 0x020015EB RID: 5611
	[Token(Token = "0x2000F70")]
	public struct UserSelectionSettings : IEquatable<UserSelectionSettings>
	{
		// Token: 0x06007FE5 RID: 32741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A39")]
		[Address(RVA = "0x363F20", Offset = "0x364021", VA = "0x363F20")]
		public void SetDefault()
		{
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A3A")]
		[Address(RVA = "0x363F50", Offset = "0x364051", VA = "0x363F50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[Token(Token = "0x6006A3B")]
		[Address(RVA = "0x363F60", Offset = "0x364061", VA = "0x363F60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x0002DE10 File Offset: 0x0002C010
		[Token(Token = "0x6006A3C")]
		[Address(RVA = "0x364030", Offset = "0x364131", VA = "0x364030", Slot = "4")]
		public bool Equals(UserSelectionSettings other)
		{
			return default(bool);
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x0002DE28 File Offset: 0x0002C028
		[Token(Token = "0x6006A3D")]
		[Address(RVA = "0x3640A0", Offset = "0x3641A1", VA = "0x3640A0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x0002DE40 File Offset: 0x0002C040
		[Token(Token = "0x6006A3E")]
		[Address(RVA = "0x28515B0", Offset = "0x28516B1", VA = "0x28515B0")]
		public static bool operator ==(UserSelectionSettings lhs, UserSelectionSettings rhs)
		{
			return default(bool);
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x0002DE58 File Offset: 0x0002C058
		[Token(Token = "0x6006A3F")]
		[Address(RVA = "0x28518A0", Offset = "0x28519A1", VA = "0x28518A0")]
		public static bool operator !=(UserSelectionSettings lhs, UserSelectionSettings rhs)
		{
			return default(bool);
		}

		// Token: 0x0401C16A RID: 115050
		[Token(Token = "0x40189A7")]
		[FieldOffset(Offset = "0x0")]
		public UserSelectionSettings.UidArray8 invalidUidList;

		// Token: 0x0401C16B RID: 115051
		[Token(Token = "0x40189A8")]
		[FieldOffset(Offset = "0x80")]
		public bool isSkipEnabled;

		// Token: 0x0401C16C RID: 115052
		[Token(Token = "0x40189A9")]
		[FieldOffset(Offset = "0x81")]
		public bool isNetworkServiceAccountRequired;

		// Token: 0x0401C16D RID: 115053
		[Token(Token = "0x40189AA")]
		[FieldOffset(Offset = "0x82")]
		public bool showSkipButton;

		// Token: 0x0401C16E RID: 115054
		[Token(Token = "0x40189AB")]
		[FieldOffset(Offset = "0x83")]
		public bool additionalSelect;

		// Token: 0x0401C16F RID: 115055
		[Token(Token = "0x40189AC")]
		[FieldOffset(Offset = "0x84")]
		public bool isUnqualifiedUserSelectable;

		// Token: 0x020015EC RID: 5612
		[Token(Token = "0x20015CD")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A9C0", Offset = "0x15AAC1")]
		public struct UidArray8 : IList<Uid>, ICollection<Uid>, IEnumerable<Uid>, IEnumerable
		{
			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06007FEC RID: 32748 RVA: 0x0002DE70 File Offset: 0x0002C070
			[Token(Token = "0x17000F4D")]
			public int Length
			{
				[Token(Token = "0x6007FBF")]
				[Address(RVA = "0x364120", Offset = "0x364221", VA = "0x364120")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x06007FED RID: 32749 RVA: 0x0002DE88 File Offset: 0x0002C088
			// (set) Token: 0x06007FEE RID: 32750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F4E")]
			public Uid Item
			{
				[Token(Token = "0x6007FC0")]
				[Address(RVA = "0x364130", Offset = "0x364231", VA = "0x364130", Slot = "4")]
				get
				{
					return default(Uid);
				}
				[Token(Token = "0x6007FC1")]
				[Address(RVA = "0x364240", Offset = "0x364341", VA = "0x364240", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x06007FEF RID: 32751 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
			[Token(Token = "0x17000F4F")]
			public int Count
			{
				[Token(Token = "0x6007FC2")]
				[Address(RVA = "0x364250", Offset = "0x364351", VA = "0x364250", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x06007FF0 RID: 32752 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
			[Token(Token = "0x17000F50")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007FC3")]
				[Address(RVA = "0x364260", Offset = "0x364361", VA = "0x364260", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007FF1 RID: 32753 RVA: 0x0002DED0 File Offset: 0x0002C0D0
			[Token(Token = "0x6007FC4")]
			[Address(RVA = "0x364270", Offset = "0x364371", VA = "0x364270", Slot = "13")]
			public bool Contains(Uid item)
			{
				return default(bool);
			}

			// Token: 0x06007FF2 RID: 32754 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
			[Token(Token = "0x6007FC5")]
			[Address(RVA = "0x364280", Offset = "0x364381", VA = "0x364280", Slot = "6")]
			public int IndexOf(Uid item)
			{
				return 0;
			}

			// Token: 0x06007FF3 RID: 32755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FC6")]
			[Address(RVA = "0x364290", Offset = "0x364391", VA = "0x364290", Slot = "14")]
			public void CopyTo(Uid[] array, int arrayIndex)
			{
			}

			// Token: 0x06007FF4 RID: 32756 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FC7")]
			[Address(RVA = "0x3642A0", Offset = "0x3643A1", VA = "0x3642A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007FF5 RID: 32757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FC8")]
			[Address(RVA = "0x3642B0", Offset = "0x3643B1", VA = "0x3642B0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B72D0", Offset = "0x1B73D1")]
			public IEnumerator<Uid> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007FF6 RID: 32758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FC9")]
			[Address(RVA = "0x3643B0", Offset = "0x3644B1", VA = "0x3643B0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007FF7 RID: 32759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FCA")]
			[Address(RVA = "0x3644B0", Offset = "0x3645B1", VA = "0x3644B0", Slot = "11")]
			public void Add(Uid item)
			{
			}

			// Token: 0x06007FF8 RID: 32760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FCB")]
			[Address(RVA = "0x3644C0", Offset = "0x3645C1", VA = "0x3644C0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007FF9 RID: 32761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FCC")]
			[Address(RVA = "0x3644D0", Offset = "0x3645D1", VA = "0x3644D0", Slot = "7")]
			public void Insert(int index, Uid item)
			{
			}

			// Token: 0x06007FFA RID: 32762 RVA: 0x0002DF00 File Offset: 0x0002C100
			[Token(Token = "0x6007FCD")]
			[Address(RVA = "0x3644E0", Offset = "0x3645E1", VA = "0x3644E0", Slot = "15")]
			public bool Remove(Uid item)
			{
				return default(bool);
			}

			// Token: 0x06007FFB RID: 32763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FCE")]
			[Address(RVA = "0x3644F0", Offset = "0x3645F1", VA = "0x3644F0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C170 RID: 115056
			[Token(Token = "0x401C381")]
			private const int _Length = 8;

			// Token: 0x0401C171 RID: 115057
			[Token(Token = "0x401C382")]
			[FieldOffset(Offset = "0x0")]
			private Uid _value0;

			// Token: 0x0401C172 RID: 115058
			[Token(Token = "0x401C383")]
			[FieldOffset(Offset = "0x10")]
			private Uid _value1;

			// Token: 0x0401C173 RID: 115059
			[Token(Token = "0x401C384")]
			[FieldOffset(Offset = "0x20")]
			private Uid _value2;

			// Token: 0x0401C174 RID: 115060
			[Token(Token = "0x401C385")]
			[FieldOffset(Offset = "0x30")]
			private Uid _value3;

			// Token: 0x0401C175 RID: 115061
			[Token(Token = "0x401C386")]
			[FieldOffset(Offset = "0x40")]
			private Uid _value4;

			// Token: 0x0401C176 RID: 115062
			[Token(Token = "0x401C387")]
			[FieldOffset(Offset = "0x50")]
			private Uid _value5;

			// Token: 0x0401C177 RID: 115063
			[Token(Token = "0x401C388")]
			[FieldOffset(Offset = "0x60")]
			private Uid _value6;

			// Token: 0x0401C178 RID: 115064
			[Token(Token = "0x401C389")]
			[FieldOffset(Offset = "0x70")]
			private Uid _value7;

			// Token: 0x020015ED RID: 5613
			[Token(Token = "0x2001681")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B000", Offset = "0x15B101")]
			private sealed class <GetEnumerator>d__22 : IEnumerator<Uid>, IEnumerator, IDisposable
			{
				// Token: 0x06007FFC RID: 32764 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008174")]
				[Address(RVA = "0x2852310", Offset = "0x2852411", VA = "0x2852310")]
				[DebuggerHidden]
				public <GetEnumerator>d__22(int <>1__state)
				{
				}

				// Token: 0x06007FFD RID: 32765 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008175")]
				[Address(RVA = "0x2852620", Offset = "0x2852721", VA = "0x2852620", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007FFE RID: 32766 RVA: 0x0002DF18 File Offset: 0x0002C118
				[Token(Token = "0x6008176")]
				[Address(RVA = "0x2852630", Offset = "0x2852731", VA = "0x2852630", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000F80 RID: 3968
				// (get) Token: 0x06007FFF RID: 32767 RVA: 0x0002DF30 File Offset: 0x0002C130
				[Token(Token = "0x17000F8D")]
				private Uid Current
				{
					[Token(Token = "0x6008177")]
					[Address(RVA = "0x2852700", Offset = "0x2852801", VA = "0x2852700", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(Uid);
					}
				}

				// Token: 0x06008000 RID: 32768 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008178")]
				[Address(RVA = "0x2852710", Offset = "0x2852811", VA = "0x2852710", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000F81 RID: 3969
				// (get) Token: 0x06008001 RID: 32769 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F8E")]
				private object Current
				{
					[Token(Token = "0x6008179")]
					[Address(RVA = "0x2852770", Offset = "0x2852871", VA = "0x2852770", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C179 RID: 115065
				[Token(Token = "0x401C4A5")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C17A RID: 115066
				[Token(Token = "0x401C4A6")]
				[FieldOffset(Offset = "0x18")]
				private Uid <>2__current;

				// Token: 0x0401C17B RID: 115067
				[Token(Token = "0x401C4A7")]
				[FieldOffset(Offset = "0x28")]
				public UserSelectionSettings.UidArray8 <>4__this;
			}
		}
	}
}
