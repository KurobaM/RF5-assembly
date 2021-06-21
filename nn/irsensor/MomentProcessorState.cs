using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001536 RID: 5430
	[Token(Token = "0x2000EE9")]
	public struct MomentProcessorState
	{
		// Token: 0x0401BE57 RID: 114263
		[Token(Token = "0x40187D1")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BE58 RID: 114264
		[Token(Token = "0x40187D2")]
		[FieldOffset(Offset = "0x8")]
		public long deltaTimeNanoSeconds;

		// Token: 0x0401BE59 RID: 114265
		[Token(Token = "0x40187D3")]
		[FieldOffset(Offset = "0x10")]
		public IrCameraAmbientNoiseLevel ambientNoiseLevel;

		// Token: 0x0401BE5A RID: 114266
		[Token(Token = "0x40187D4")]
		[FieldOffset(Offset = "0x14")]
		private byte _reserved0;

		// Token: 0x0401BE5B RID: 114267
		[Token(Token = "0x40187D5")]
		[FieldOffset(Offset = "0x15")]
		private byte _reserved1;

		// Token: 0x0401BE5C RID: 114268
		[Token(Token = "0x40187D6")]
		[FieldOffset(Offset = "0x16")]
		private byte _reserved2;

		// Token: 0x0401BE5D RID: 114269
		[Token(Token = "0x40187D7")]
		[FieldOffset(Offset = "0x17")]
		private byte _reserved3;

		// Token: 0x0401BE5E RID: 114270
		[Token(Token = "0x40187D8")]
		[FieldOffset(Offset = "0x18")]
		public MomentProcessorState.MomentStatisticArray48 blocks;

		// Token: 0x02001537 RID: 5431
		[Token(Token = "0x20015B3")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A4C0", Offset = "0x15A5C1")]
		public struct MomentStatisticArray48 : IList<MomentStatistic>, ICollection<MomentStatistic>, IEnumerable<MomentStatistic>, IEnumerable
		{
			// Token: 0x17000E8C RID: 3724
			// (get) Token: 0x06007B54 RID: 31572 RVA: 0x0002B7A0 File Offset: 0x000299A0
			[Token(Token = "0x17000EFD")]
			public int Length
			{
				[Token(Token = "0x6007E6D")]
				[Address(RVA = "0x39F680", Offset = "0x39F781", VA = "0x39F680")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E8D RID: 3725
			// (get) Token: 0x06007B55 RID: 31573 RVA: 0x0002B7B8 File Offset: 0x000299B8
			// (set) Token: 0x06007B56 RID: 31574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EFE")]
			public MomentStatistic Item
			{
				[Token(Token = "0x6007E6E")]
				[Address(RVA = "0x39F690", Offset = "0x39F791", VA = "0x39F690", Slot = "4")]
				get
				{
					return default(MomentStatistic);
				}
				[Token(Token = "0x6007E6F")]
				[Address(RVA = "0x39F6A0", Offset = "0x39F7A1", VA = "0x39F6A0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E8E RID: 3726
			// (get) Token: 0x06007B57 RID: 31575 RVA: 0x0002B7D0 File Offset: 0x000299D0
			[Token(Token = "0x17000EFF")]
			public int Count
			{
				[Token(Token = "0x6007E70")]
				[Address(RVA = "0x39F6B0", Offset = "0x39F7B1", VA = "0x39F6B0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E8F RID: 3727
			// (get) Token: 0x06007B58 RID: 31576 RVA: 0x0002B7E8 File Offset: 0x000299E8
			[Token(Token = "0x17000F00")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E71")]
				[Address(RVA = "0x39F6C0", Offset = "0x39F7C1", VA = "0x39F6C0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007B59 RID: 31577 RVA: 0x0002B800 File Offset: 0x00029A00
			[Token(Token = "0x6007E72")]
			[Address(RVA = "0x39F6D0", Offset = "0x39F7D1", VA = "0x39F6D0", Slot = "13")]
			public bool Contains(MomentStatistic item)
			{
				return default(bool);
			}

			// Token: 0x06007B5A RID: 31578 RVA: 0x0002B818 File Offset: 0x00029A18
			[Token(Token = "0x6007E73")]
			[Address(RVA = "0x39F740", Offset = "0x39F841", VA = "0x39F740", Slot = "6")]
			public int IndexOf(MomentStatistic item)
			{
				return 0;
			}

			// Token: 0x06007B5B RID: 31579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E74")]
			[Address(RVA = "0x39F7C0", Offset = "0x39F8C1", VA = "0x39F7C0", Slot = "14")]
			public void CopyTo(MomentStatistic[] array, int arrayIndex)
			{
			}

			// Token: 0x06007B5C RID: 31580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E75")]
			[Address(RVA = "0x39F7D0", Offset = "0x39F8D1", VA = "0x39F7D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007B5D RID: 31581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E76")]
			[Address(RVA = "0x39F7E0", Offset = "0x39F8E1", VA = "0x39F7E0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6A10", Offset = "0x1B6B11")]
			public IEnumerator<MomentStatistic> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007B5E RID: 31582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E77")]
			[Address(RVA = "0x39F880", Offset = "0x39F981", VA = "0x39F880", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007B5F RID: 31583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E78")]
			[Address(RVA = "0x39F920", Offset = "0x39FA21", VA = "0x39F920", Slot = "11")]
			public void Add(MomentStatistic item)
			{
			}

			// Token: 0x06007B60 RID: 31584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E79")]
			[Address(RVA = "0x39F930", Offset = "0x39FA31", VA = "0x39F930", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007B61 RID: 31585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E7A")]
			[Address(RVA = "0x39F940", Offset = "0x39FA41", VA = "0x39F940", Slot = "7")]
			public void Insert(int index, MomentStatistic item)
			{
			}

			// Token: 0x06007B62 RID: 31586 RVA: 0x0002B830 File Offset: 0x00029A30
			[Token(Token = "0x6007E7B")]
			[Address(RVA = "0x39F950", Offset = "0x39FA51", VA = "0x39F950", Slot = "15")]
			public bool Remove(MomentStatistic item)
			{
				return default(bool);
			}

			// Token: 0x06007B63 RID: 31587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E7C")]
			[Address(RVA = "0x39F960", Offset = "0x39FA61", VA = "0x39F960", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BE5F RID: 114271
			[Token(Token = "0x401C280")]
			private const int _Length = 48;

			// Token: 0x0401BE60 RID: 114272
			[Token(Token = "0x401C281")]
			[FieldOffset(Offset = "0x0")]
			private MomentStatistic _value0;

			// Token: 0x0401BE61 RID: 114273
			[Token(Token = "0x401C282")]
			[FieldOffset(Offset = "0xC")]
			private MomentStatistic _value1;

			// Token: 0x0401BE62 RID: 114274
			[Token(Token = "0x401C283")]
			[FieldOffset(Offset = "0x18")]
			private MomentStatistic _value2;

			// Token: 0x0401BE63 RID: 114275
			[Token(Token = "0x401C284")]
			[FieldOffset(Offset = "0x24")]
			private MomentStatistic _value3;

			// Token: 0x0401BE64 RID: 114276
			[Token(Token = "0x401C285")]
			[FieldOffset(Offset = "0x30")]
			private MomentStatistic _value4;

			// Token: 0x0401BE65 RID: 114277
			[Token(Token = "0x401C286")]
			[FieldOffset(Offset = "0x3C")]
			private MomentStatistic _value5;

			// Token: 0x0401BE66 RID: 114278
			[Token(Token = "0x401C287")]
			[FieldOffset(Offset = "0x48")]
			private MomentStatistic _value6;

			// Token: 0x0401BE67 RID: 114279
			[Token(Token = "0x401C288")]
			[FieldOffset(Offset = "0x54")]
			private MomentStatistic _value7;

			// Token: 0x0401BE68 RID: 114280
			[Token(Token = "0x401C289")]
			[FieldOffset(Offset = "0x60")]
			private MomentStatistic _value8;

			// Token: 0x0401BE69 RID: 114281
			[Token(Token = "0x401C28A")]
			[FieldOffset(Offset = "0x6C")]
			private MomentStatistic _value9;

			// Token: 0x0401BE6A RID: 114282
			[Token(Token = "0x401C28B")]
			[FieldOffset(Offset = "0x78")]
			private MomentStatistic _value10;

			// Token: 0x0401BE6B RID: 114283
			[Token(Token = "0x401C28C")]
			[FieldOffset(Offset = "0x84")]
			private MomentStatistic _value11;

			// Token: 0x0401BE6C RID: 114284
			[Token(Token = "0x401C28D")]
			[FieldOffset(Offset = "0x90")]
			private MomentStatistic _value12;

			// Token: 0x0401BE6D RID: 114285
			[Token(Token = "0x401C28E")]
			[FieldOffset(Offset = "0x9C")]
			private MomentStatistic _value13;

			// Token: 0x0401BE6E RID: 114286
			[Token(Token = "0x401C28F")]
			[FieldOffset(Offset = "0xA8")]
			private MomentStatistic _value14;

			// Token: 0x0401BE6F RID: 114287
			[Token(Token = "0x401C290")]
			[FieldOffset(Offset = "0xB4")]
			private MomentStatistic _value15;

			// Token: 0x0401BE70 RID: 114288
			[Token(Token = "0x401C291")]
			[FieldOffset(Offset = "0xC0")]
			private MomentStatistic _value16;

			// Token: 0x0401BE71 RID: 114289
			[Token(Token = "0x401C292")]
			[FieldOffset(Offset = "0xCC")]
			private MomentStatistic _value17;

			// Token: 0x0401BE72 RID: 114290
			[Token(Token = "0x401C293")]
			[FieldOffset(Offset = "0xD8")]
			private MomentStatistic _value18;

			// Token: 0x0401BE73 RID: 114291
			[Token(Token = "0x401C294")]
			[FieldOffset(Offset = "0xE4")]
			private MomentStatistic _value19;

			// Token: 0x0401BE74 RID: 114292
			[Token(Token = "0x401C295")]
			[FieldOffset(Offset = "0xF0")]
			private MomentStatistic _value20;

			// Token: 0x0401BE75 RID: 114293
			[Token(Token = "0x401C296")]
			[FieldOffset(Offset = "0xFC")]
			private MomentStatistic _value21;

			// Token: 0x0401BE76 RID: 114294
			[Token(Token = "0x401C297")]
			[FieldOffset(Offset = "0x108")]
			private MomentStatistic _value22;

			// Token: 0x0401BE77 RID: 114295
			[Token(Token = "0x401C298")]
			[FieldOffset(Offset = "0x114")]
			private MomentStatistic _value23;

			// Token: 0x0401BE78 RID: 114296
			[Token(Token = "0x401C299")]
			[FieldOffset(Offset = "0x120")]
			private MomentStatistic _value24;

			// Token: 0x0401BE79 RID: 114297
			[Token(Token = "0x401C29A")]
			[FieldOffset(Offset = "0x12C")]
			private MomentStatistic _value25;

			// Token: 0x0401BE7A RID: 114298
			[Token(Token = "0x401C29B")]
			[FieldOffset(Offset = "0x138")]
			private MomentStatistic _value26;

			// Token: 0x0401BE7B RID: 114299
			[Token(Token = "0x401C29C")]
			[FieldOffset(Offset = "0x144")]
			private MomentStatistic _value27;

			// Token: 0x0401BE7C RID: 114300
			[Token(Token = "0x401C29D")]
			[FieldOffset(Offset = "0x150")]
			private MomentStatistic _value28;

			// Token: 0x0401BE7D RID: 114301
			[Token(Token = "0x401C29E")]
			[FieldOffset(Offset = "0x15C")]
			private MomentStatistic _value29;

			// Token: 0x0401BE7E RID: 114302
			[Token(Token = "0x401C29F")]
			[FieldOffset(Offset = "0x168")]
			private MomentStatistic _value30;

			// Token: 0x0401BE7F RID: 114303
			[Token(Token = "0x401C2A0")]
			[FieldOffset(Offset = "0x174")]
			private MomentStatistic _value31;

			// Token: 0x0401BE80 RID: 114304
			[Token(Token = "0x401C2A1")]
			[FieldOffset(Offset = "0x180")]
			private MomentStatistic _value32;

			// Token: 0x0401BE81 RID: 114305
			[Token(Token = "0x401C2A2")]
			[FieldOffset(Offset = "0x18C")]
			private MomentStatistic _value33;

			// Token: 0x0401BE82 RID: 114306
			[Token(Token = "0x401C2A3")]
			[FieldOffset(Offset = "0x198")]
			private MomentStatistic _value34;

			// Token: 0x0401BE83 RID: 114307
			[Token(Token = "0x401C2A4")]
			[FieldOffset(Offset = "0x1A4")]
			private MomentStatistic _value35;

			// Token: 0x0401BE84 RID: 114308
			[Token(Token = "0x401C2A5")]
			[FieldOffset(Offset = "0x1B0")]
			private MomentStatistic _value36;

			// Token: 0x0401BE85 RID: 114309
			[Token(Token = "0x401C2A6")]
			[FieldOffset(Offset = "0x1BC")]
			private MomentStatistic _value37;

			// Token: 0x0401BE86 RID: 114310
			[Token(Token = "0x401C2A7")]
			[FieldOffset(Offset = "0x1C8")]
			private MomentStatistic _value38;

			// Token: 0x0401BE87 RID: 114311
			[Token(Token = "0x401C2A8")]
			[FieldOffset(Offset = "0x1D4")]
			private MomentStatistic _value39;

			// Token: 0x0401BE88 RID: 114312
			[Token(Token = "0x401C2A9")]
			[FieldOffset(Offset = "0x1E0")]
			private MomentStatistic _value40;

			// Token: 0x0401BE89 RID: 114313
			[Token(Token = "0x401C2AA")]
			[FieldOffset(Offset = "0x1EC")]
			private MomentStatistic _value41;

			// Token: 0x0401BE8A RID: 114314
			[Token(Token = "0x401C2AB")]
			[FieldOffset(Offset = "0x1F8")]
			private MomentStatistic _value42;

			// Token: 0x0401BE8B RID: 114315
			[Token(Token = "0x401C2AC")]
			[FieldOffset(Offset = "0x204")]
			private MomentStatistic _value43;

			// Token: 0x0401BE8C RID: 114316
			[Token(Token = "0x401C2AD")]
			[FieldOffset(Offset = "0x210")]
			private MomentStatistic _value44;

			// Token: 0x0401BE8D RID: 114317
			[Token(Token = "0x401C2AE")]
			[FieldOffset(Offset = "0x21C")]
			private MomentStatistic _value45;

			// Token: 0x0401BE8E RID: 114318
			[Token(Token = "0x401C2AF")]
			[FieldOffset(Offset = "0x228")]
			private MomentStatistic _value46;

			// Token: 0x0401BE8F RID: 114319
			[Token(Token = "0x401C2B0")]
			[FieldOffset(Offset = "0x234")]
			private MomentStatistic _value47;

			// Token: 0x02001538 RID: 5432
			[Token(Token = "0x200166D")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AEC0", Offset = "0x15AFC1")]
			private sealed class <GetEnumerator>d__62 : IEnumerator<MomentStatistic>, IEnumerator, IDisposable
			{
				// Token: 0x06007B64 RID: 31588 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080FC")]
				[Address(RVA = "0x34DF580", Offset = "0x34DF681", VA = "0x34DF580")]
				[DebuggerHidden]
				public <GetEnumerator>d__62(int <>1__state)
				{
				}

				// Token: 0x06007B65 RID: 31589 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080FD")]
				[Address(RVA = "0x34DF830", Offset = "0x34DF931", VA = "0x34DF830", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007B66 RID: 31590 RVA: 0x0002B848 File Offset: 0x00029A48
				[Token(Token = "0x60080FE")]
				[Address(RVA = "0x34DF840", Offset = "0x34DF941", VA = "0x34DF840", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E90 RID: 3728
				// (get) Token: 0x06007B67 RID: 31591 RVA: 0x0002B860 File Offset: 0x00029A60
				[Token(Token = "0x17000F65")]
				private MomentStatistic Current
				{
					[Token(Token = "0x60080FF")]
					[Address(RVA = "0x34DFC50", Offset = "0x34DFD51", VA = "0x34DFC50", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(MomentStatistic);
					}
				}

				// Token: 0x06007B68 RID: 31592 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008100")]
				[Address(RVA = "0x34DFC60", Offset = "0x34DFD61", VA = "0x34DFC60", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E91 RID: 3729
				// (get) Token: 0x06007B69 RID: 31593 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F66")]
				private object Current
				{
					[Token(Token = "0x6008101")]
					[Address(RVA = "0x34DFCC0", Offset = "0x34DFDC1", VA = "0x34DFCC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BE90 RID: 114320
				[Token(Token = "0x401C469")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BE91 RID: 114321
				[Token(Token = "0x401C46A")]
				[FieldOffset(Offset = "0x14")]
				private MomentStatistic <>2__current;

				// Token: 0x0401BE92 RID: 114322
				[Token(Token = "0x401C46B")]
				[FieldOffset(Offset = "0x20")]
				public MomentProcessorState.MomentStatisticArray48 <>4__this;
			}
		}
	}
}
