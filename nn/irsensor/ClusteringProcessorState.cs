using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x0200150A RID: 5386
	[Token(Token = "0x2000EC7")]
	public struct ClusteringProcessorState
	{
		// Token: 0x06007A70 RID: 31344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FC")]
		[Address(RVA = "0x388790", Offset = "0x388891", VA = "0x388790")]
		public void SetDefault()
		{
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066FD")]
		[Address(RVA = "0x3887A0", Offset = "0x3888A1", VA = "0x3887A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BD6F RID: 114031
		[Token(Token = "0x401872C")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BD70 RID: 114032
		[Token(Token = "0x401872D")]
		[FieldOffset(Offset = "0x8")]
		public long timeStampNanoSeconds;

		// Token: 0x0401BD71 RID: 114033
		[Token(Token = "0x401872E")]
		[FieldOffset(Offset = "0x10")]
		public sbyte objectCount;

		// Token: 0x0401BD72 RID: 114034
		[Token(Token = "0x401872F")]
		[FieldOffset(Offset = "0x11")]
		public byte _reserved0;

		// Token: 0x0401BD73 RID: 114035
		[Token(Token = "0x4018730")]
		[FieldOffset(Offset = "0x12")]
		public byte _reserved1;

		// Token: 0x0401BD74 RID: 114036
		[Token(Token = "0x4018731")]
		[FieldOffset(Offset = "0x13")]
		public byte _reserved2;

		// Token: 0x0401BD75 RID: 114037
		[Token(Token = "0x4018732")]
		[FieldOffset(Offset = "0x14")]
		public IrCameraAmbientNoiseLevel ambientNoiseLevel;

		// Token: 0x0401BD76 RID: 114038
		[Token(Token = "0x4018733")]
		[FieldOffset(Offset = "0x18")]
		public ClusteringProcessorState.ClusteringDataArray16 objects;

		// Token: 0x0200150B RID: 5387
		[Token(Token = "0x20015AE")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A380", Offset = "0x15A481")]
		public struct ClusteringDataArray16 : IList<ClusteringData>, ICollection<ClusteringData>, IEnumerable<ClusteringData>, IEnumerable
		{
			// Token: 0x17000E6C RID: 3692
			// (get) Token: 0x06007A72 RID: 31346 RVA: 0x0002AD38 File Offset: 0x00028F38
			[Token(Token = "0x17000EE9")]
			public int Length
			{
				[Token(Token = "0x6007E1D")]
				[Address(RVA = "0x3887B0", Offset = "0x3888B1", VA = "0x3887B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E6D RID: 3693
			// (get) Token: 0x06007A73 RID: 31347 RVA: 0x0002AD50 File Offset: 0x00028F50
			// (set) Token: 0x06007A74 RID: 31348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EEA")]
			public ClusteringData Item
			{
				[Token(Token = "0x6007E1E")]
				[Address(RVA = "0x3887C0", Offset = "0x3888C1", VA = "0x3887C0", Slot = "4")]
				get
				{
					return default(ClusteringData);
				}
				[Token(Token = "0x6007E1F")]
				[Address(RVA = "0x3887D0", Offset = "0x3888D1", VA = "0x3887D0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E6E RID: 3694
			// (get) Token: 0x06007A75 RID: 31349 RVA: 0x0002AD68 File Offset: 0x00028F68
			[Token(Token = "0x17000EEB")]
			public int Count
			{
				[Token(Token = "0x6007E20")]
				[Address(RVA = "0x388810", Offset = "0x388911", VA = "0x388810", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E6F RID: 3695
			// (get) Token: 0x06007A76 RID: 31350 RVA: 0x0002AD80 File Offset: 0x00028F80
			[Token(Token = "0x17000EEC")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E21")]
				[Address(RVA = "0x388820", Offset = "0x388921", VA = "0x388820", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007A77 RID: 31351 RVA: 0x0002AD98 File Offset: 0x00028F98
			[Token(Token = "0x6007E22")]
			[Address(RVA = "0x388830", Offset = "0x388931", VA = "0x388830", Slot = "13")]
			public bool Contains(ClusteringData item)
			{
				return default(bool);
			}

			// Token: 0x06007A78 RID: 31352 RVA: 0x0002ADB0 File Offset: 0x00028FB0
			[Token(Token = "0x6007E23")]
			[Address(RVA = "0x388900", Offset = "0x388A01", VA = "0x388900", Slot = "6")]
			public int IndexOf(ClusteringData item)
			{
				return 0;
			}

			// Token: 0x06007A79 RID: 31353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E24")]
			[Address(RVA = "0x3889D0", Offset = "0x388AD1", VA = "0x3889D0", Slot = "14")]
			public void CopyTo(ClusteringData[] array, int arrayIndex)
			{
			}

			// Token: 0x06007A7A RID: 31354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E25")]
			[Address(RVA = "0x3889E0", Offset = "0x388AE1", VA = "0x3889E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007A7B RID: 31355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E26")]
			[Address(RVA = "0x3889F0", Offset = "0x388AF1", VA = "0x3889F0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B67E0", Offset = "0x1B68E1")]
			public IEnumerator<ClusteringData> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007A7C RID: 31356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E27")]
			[Address(RVA = "0x388A90", Offset = "0x388B91", VA = "0x388A90", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007A7D RID: 31357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E28")]
			[Address(RVA = "0x388B30", Offset = "0x388C31", VA = "0x388B30", Slot = "11")]
			public void Add(ClusteringData item)
			{
			}

			// Token: 0x06007A7E RID: 31358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E29")]
			[Address(RVA = "0x388B40", Offset = "0x388C41", VA = "0x388B40", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007A7F RID: 31359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E2A")]
			[Address(RVA = "0x388B50", Offset = "0x388C51", VA = "0x388B50", Slot = "7")]
			public void Insert(int index, ClusteringData item)
			{
			}

			// Token: 0x06007A80 RID: 31360 RVA: 0x0002ADC8 File Offset: 0x00028FC8
			[Token(Token = "0x6007E2B")]
			[Address(RVA = "0x388B60", Offset = "0x388C61", VA = "0x388B60", Slot = "15")]
			public bool Remove(ClusteringData item)
			{
				return default(bool);
			}

			// Token: 0x06007A81 RID: 31361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E2C")]
			[Address(RVA = "0x388B70", Offset = "0x388C71", VA = "0x388B70", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BD77 RID: 114039
			[Token(Token = "0x401C24C")]
			private const int _Length = 16;

			// Token: 0x0401BD78 RID: 114040
			[Token(Token = "0x401C24D")]
			[FieldOffset(Offset = "0x0")]
			private ClusteringData _value0;

			// Token: 0x0401BD79 RID: 114041
			[Token(Token = "0x401C24E")]
			[FieldOffset(Offset = "0x18")]
			private ClusteringData _value1;

			// Token: 0x0401BD7A RID: 114042
			[Token(Token = "0x401C24F")]
			[FieldOffset(Offset = "0x30")]
			private ClusteringData _value2;

			// Token: 0x0401BD7B RID: 114043
			[Token(Token = "0x401C250")]
			[FieldOffset(Offset = "0x48")]
			private ClusteringData _value3;

			// Token: 0x0401BD7C RID: 114044
			[Token(Token = "0x401C251")]
			[FieldOffset(Offset = "0x60")]
			private ClusteringData _value4;

			// Token: 0x0401BD7D RID: 114045
			[Token(Token = "0x401C252")]
			[FieldOffset(Offset = "0x78")]
			private ClusteringData _value5;

			// Token: 0x0401BD7E RID: 114046
			[Token(Token = "0x401C253")]
			[FieldOffset(Offset = "0x90")]
			private ClusteringData _value6;

			// Token: 0x0401BD7F RID: 114047
			[Token(Token = "0x401C254")]
			[FieldOffset(Offset = "0xA8")]
			private ClusteringData _value7;

			// Token: 0x0401BD80 RID: 114048
			[Token(Token = "0x401C255")]
			[FieldOffset(Offset = "0xC0")]
			private ClusteringData _value8;

			// Token: 0x0401BD81 RID: 114049
			[Token(Token = "0x401C256")]
			[FieldOffset(Offset = "0xD8")]
			private ClusteringData _value9;

			// Token: 0x0401BD82 RID: 114050
			[Token(Token = "0x401C257")]
			[FieldOffset(Offset = "0xF0")]
			private ClusteringData _value10;

			// Token: 0x0401BD83 RID: 114051
			[Token(Token = "0x401C258")]
			[FieldOffset(Offset = "0x108")]
			private ClusteringData _value11;

			// Token: 0x0401BD84 RID: 114052
			[Token(Token = "0x401C259")]
			[FieldOffset(Offset = "0x120")]
			private ClusteringData _value12;

			// Token: 0x0401BD85 RID: 114053
			[Token(Token = "0x401C25A")]
			[FieldOffset(Offset = "0x138")]
			private ClusteringData _value13;

			// Token: 0x0401BD86 RID: 114054
			[Token(Token = "0x401C25B")]
			[FieldOffset(Offset = "0x150")]
			private ClusteringData _value14;

			// Token: 0x0401BD87 RID: 114055
			[Token(Token = "0x401C25C")]
			[FieldOffset(Offset = "0x168")]
			private ClusteringData _value15;

			// Token: 0x0200150C RID: 5388
			[Token(Token = "0x2001668")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE70", Offset = "0x15AF71")]
			private sealed class <GetEnumerator>d__30 : IEnumerator<ClusteringData>, IEnumerator, IDisposable
			{
				// Token: 0x06007A82 RID: 31362 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080DE")]
				[Address(RVA = "0x2D7C7B0", Offset = "0x2D7C8B1", VA = "0x2D7C7B0")]
				[DebuggerHidden]
				public <GetEnumerator>d__30(int <>1__state)
				{
				}

				// Token: 0x06007A83 RID: 31363 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080DF")]
				[Address(RVA = "0x2D7CA60", Offset = "0x2D7CB61", VA = "0x2D7CA60", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007A84 RID: 31364 RVA: 0x0002ADE0 File Offset: 0x00028FE0
				[Token(Token = "0x60080E0")]
				[Address(RVA = "0x2D7CA70", Offset = "0x2D7CB71", VA = "0x2D7CA70", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E70 RID: 3696
				// (get) Token: 0x06007A85 RID: 31365 RVA: 0x0002ADF8 File Offset: 0x00028FF8
				[Token(Token = "0x17000F5B")]
				private ClusteringData Current
				{
					[Token(Token = "0x60080E1")]
					[Address(RVA = "0x2D7CD40", Offset = "0x2D7CE41", VA = "0x2D7CD40", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(ClusteringData);
					}
				}

				// Token: 0x06007A86 RID: 31366 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080E2")]
				[Address(RVA = "0x2D7CD60", Offset = "0x2D7CE61", VA = "0x2D7CD60", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E71 RID: 3697
				// (get) Token: 0x06007A87 RID: 31367 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F5C")]
				private object Current
				{
					[Token(Token = "0x60080E3")]
					[Address(RVA = "0x2D7CDC0", Offset = "0x2D7CEC1", VA = "0x2D7CDC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BD88 RID: 114056
				[Token(Token = "0x401C45A")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BD89 RID: 114057
				[Token(Token = "0x401C45B")]
				[FieldOffset(Offset = "0x14")]
				private ClusteringData <>2__current;

				// Token: 0x0401BD8A RID: 114058
				[Token(Token = "0x401C45C")]
				[FieldOffset(Offset = "0x2C")]
				public ClusteringProcessorState.ClusteringDataArray16 <>4__this;
			}
		}
	}
}
