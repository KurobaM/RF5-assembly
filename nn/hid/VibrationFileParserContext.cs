using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015A8 RID: 5544
	[Token(Token = "0x2000F35")]
	public struct VibrationFileParserContext
	{
		// Token: 0x0401C0C5 RID: 114885
		[Token(Token = "0x401892F")]
		[FieldOffset(Offset = "0x0")]
		public VibrationFileParserContext.IntPtrArray10 _storage;

		// Token: 0x020015A9 RID: 5545
		[Token(Token = "0x20015C6")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A980", Offset = "0x15AA81")]
		public struct IntPtrArray10 : IList<IntPtr>, ICollection<IntPtr>, IEnumerable<IntPtr>, IEnumerable
		{
			// Token: 0x17000F16 RID: 3862
			// (get) Token: 0x06007DC1 RID: 32193 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
			[Token(Token = "0x17000F49")]
			public int Length
			{
				[Token(Token = "0x6007F9D")]
				[Address(RVA = "0x388150", Offset = "0x388251", VA = "0x388150")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F17 RID: 3863
			// (get) Token: 0x06007DC2 RID: 32194 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
			// (set) Token: 0x06007DC3 RID: 32195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F4A")]
			public IntPtr Item
			{
				[Token(Token = "0x6007F9E")]
				[Address(RVA = "0x388160", Offset = "0x388261", VA = "0x388160", Slot = "4")]
				get
				{
					return 0;
				}
				[Token(Token = "0x6007F9F")]
				[Address(RVA = "0x388250", Offset = "0x388351", VA = "0x388250", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000F18 RID: 3864
			// (get) Token: 0x06007DC4 RID: 32196 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
			[Token(Token = "0x17000F4B")]
			public int Count
			{
				[Token(Token = "0x6007FA0")]
				[Address(RVA = "0x388260", Offset = "0x388361", VA = "0x388260", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000F19 RID: 3865
			// (get) Token: 0x06007DC5 RID: 32197 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
			[Token(Token = "0x17000F4C")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007FA1")]
				[Address(RVA = "0x388270", Offset = "0x388371", VA = "0x388270", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007DC6 RID: 32198 RVA: 0x0002CC10 File Offset: 0x0002AE10
			[Token(Token = "0x6007FA2")]
			[Address(RVA = "0x388280", Offset = "0x388381", VA = "0x388280", Slot = "13")]
			public bool Contains(IntPtr item)
			{
				return default(bool);
			}

			// Token: 0x06007DC7 RID: 32199 RVA: 0x0002CC28 File Offset: 0x0002AE28
			[Token(Token = "0x6007FA3")]
			[Address(RVA = "0x388290", Offset = "0x388391", VA = "0x388290", Slot = "6")]
			public int IndexOf(IntPtr item)
			{
				return 0;
			}

			// Token: 0x06007DC8 RID: 32200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FA4")]
			[Address(RVA = "0x3882A0", Offset = "0x3883A1", VA = "0x3882A0", Slot = "14")]
			public void CopyTo(IntPtr[] array, int arrayIndex)
			{
			}

			// Token: 0x06007DC9 RID: 32201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FA5")]
			[Address(RVA = "0x3882B0", Offset = "0x3883B1", VA = "0x3882B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007DCA RID: 32202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FA6")]
			[Address(RVA = "0x3882C0", Offset = "0x3883C1", VA = "0x3882C0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B7260", Offset = "0x1B7361")]
			public IEnumerator<IntPtr> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007DCB RID: 32203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007FA7")]
			[Address(RVA = "0x388390", Offset = "0x388491", VA = "0x388390", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007DCC RID: 32204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FA8")]
			[Address(RVA = "0x388460", Offset = "0x388561", VA = "0x388460", Slot = "11")]
			public void Add(IntPtr item)
			{
			}

			// Token: 0x06007DCD RID: 32205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FA9")]
			[Address(RVA = "0x388470", Offset = "0x388571", VA = "0x388470", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007DCE RID: 32206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FAA")]
			[Address(RVA = "0x388480", Offset = "0x388581", VA = "0x388480", Slot = "7")]
			public void Insert(int index, IntPtr item)
			{
			}

			// Token: 0x06007DCF RID: 32207 RVA: 0x0002CC40 File Offset: 0x0002AE40
			[Token(Token = "0x6007FAB")]
			[Address(RVA = "0x388490", Offset = "0x388591", VA = "0x388490", Slot = "15")]
			public bool Remove(IntPtr item)
			{
				return default(bool);
			}

			// Token: 0x06007DD0 RID: 32208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FAC")]
			[Address(RVA = "0x3884A0", Offset = "0x3885A1", VA = "0x3884A0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401C0C6 RID: 114886
			[Token(Token = "0x401C357")]
			private const int _Length = 10;

			// Token: 0x0401C0C7 RID: 114887
			[Token(Token = "0x401C358")]
			[FieldOffset(Offset = "0x0")]
			private IntPtr _value0;

			// Token: 0x0401C0C8 RID: 114888
			[Token(Token = "0x401C359")]
			[FieldOffset(Offset = "0x8")]
			private IntPtr _value1;

			// Token: 0x0401C0C9 RID: 114889
			[Token(Token = "0x401C35A")]
			[FieldOffset(Offset = "0x10")]
			private IntPtr _value2;

			// Token: 0x0401C0CA RID: 114890
			[Token(Token = "0x401C35B")]
			[FieldOffset(Offset = "0x18")]
			private IntPtr _value3;

			// Token: 0x0401C0CB RID: 114891
			[Token(Token = "0x401C35C")]
			[FieldOffset(Offset = "0x20")]
			private IntPtr _value4;

			// Token: 0x0401C0CC RID: 114892
			[Token(Token = "0x401C35D")]
			[FieldOffset(Offset = "0x28")]
			private IntPtr _value5;

			// Token: 0x0401C0CD RID: 114893
			[Token(Token = "0x401C35E")]
			[FieldOffset(Offset = "0x30")]
			private IntPtr _value6;

			// Token: 0x0401C0CE RID: 114894
			[Token(Token = "0x401C35F")]
			[FieldOffset(Offset = "0x38")]
			private IntPtr _value7;

			// Token: 0x0401C0CF RID: 114895
			[Token(Token = "0x401C360")]
			[FieldOffset(Offset = "0x40")]
			private IntPtr _value8;

			// Token: 0x0401C0D0 RID: 114896
			[Token(Token = "0x401C361")]
			[FieldOffset(Offset = "0x48")]
			private IntPtr _value9;

			// Token: 0x020015AA RID: 5546
			[Token(Token = "0x2001680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AFF0", Offset = "0x15B0F1")]
			private sealed class <GetEnumerator>d__24 : IEnumerator<IntPtr>, IEnumerator, IDisposable
			{
				// Token: 0x06007DD1 RID: 32209 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600816E")]
				[Address(RVA = "0x2D79BE0", Offset = "0x2D79CE1", VA = "0x2D79BE0")]
				[DebuggerHidden]
				public <GetEnumerator>d__24(int <>1__state)
				{
				}

				// Token: 0x06007DD2 RID: 32210 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600816F")]
				[Address(RVA = "0x2D79EC0", Offset = "0x2D79FC1", VA = "0x2D79EC0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007DD3 RID: 32211 RVA: 0x0002CC58 File Offset: 0x0002AE58
				[Token(Token = "0x6008170")]
				[Address(RVA = "0x2D79ED0", Offset = "0x2D79FD1", VA = "0x2D79ED0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000F1A RID: 3866
				// (get) Token: 0x06007DD4 RID: 32212 RVA: 0x0002CC70 File Offset: 0x0002AE70
				[Token(Token = "0x17000F8B")]
				private IntPtr Current
				{
					[Token(Token = "0x6008171")]
					[Address(RVA = "0x2D79F90", Offset = "0x2D7A091", VA = "0x2D79F90", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return 0;
					}
				}

				// Token: 0x06007DD5 RID: 32213 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008172")]
				[Address(RVA = "0x2D79FA0", Offset = "0x2D7A0A1", VA = "0x2D79FA0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000F1B RID: 3867
				// (get) Token: 0x06007DD6 RID: 32214 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F8C")]
				private object Current
				{
					[Token(Token = "0x6008173")]
					[Address(RVA = "0x2D7A000", Offset = "0x2D7A101", VA = "0x2D7A000", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401C0D1 RID: 114897
				[Token(Token = "0x401C4A2")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401C0D2 RID: 114898
				[Token(Token = "0x401C4A3")]
				[FieldOffset(Offset = "0x18")]
				private IntPtr <>2__current;

				// Token: 0x0401C0D3 RID: 114899
				[Token(Token = "0x401C4A4")]
				[FieldOffset(Offset = "0x20")]
				public VibrationFileParserContext.IntPtrArray10 <>4__this;
			}
		}
	}
}
