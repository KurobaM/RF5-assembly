using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using nn.util;

namespace nn.hid
{
	// Token: 0x0200153B RID: 5435
	[Token(Token = "0x2000EEC")]
	public struct ControllerSupportArg
	{
		// Token: 0x06007B78 RID: 31608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006780")]
		[Address(RVA = "0x366400", Offset = "0x366501", VA = "0x366400")]
		public void SetDefault()
		{
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006781")]
		[Address(RVA = "0x3664A0", Offset = "0x3665A1", VA = "0x3664A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BE96 RID: 114326
		[Token(Token = "0x40187DC")]
		private const int ExplainTextSize = 1032;

		// Token: 0x0401BE97 RID: 114327
		[Token(Token = "0x40187DD")]
		[FieldOffset(Offset = "0x0")]
		public byte playerCountMin;

		// Token: 0x0401BE98 RID: 114328
		[Token(Token = "0x40187DE")]
		[FieldOffset(Offset = "0x1")]
		public byte playerCountMax;

		// Token: 0x0401BE99 RID: 114329
		[Token(Token = "0x40187DF")]
		[FieldOffset(Offset = "0x2")]
		public bool enableTakeOverConnection;

		// Token: 0x0401BE9A RID: 114330
		[Token(Token = "0x40187E0")]
		[FieldOffset(Offset = "0x3")]
		public bool enableLeftJustify;

		// Token: 0x0401BE9B RID: 114331
		[Token(Token = "0x40187E1")]
		[FieldOffset(Offset = "0x4")]
		public bool enablePermitJoyDual;

		// Token: 0x0401BE9C RID: 114332
		[Token(Token = "0x40187E2")]
		[FieldOffset(Offset = "0x5")]
		public bool enableSingleMode;

		// Token: 0x0401BE9D RID: 114333
		[Token(Token = "0x40187E3")]
		[FieldOffset(Offset = "0x6")]
		public bool enableIdentificationColor;

		// Token: 0x0401BE9E RID: 114334
		[Token(Token = "0x40187E4")]
		[FieldOffset(Offset = "0x7")]
		public ControllerSupportArg.Color4u8Array8 identificationColor;

		// Token: 0x0401BE9F RID: 114335
		[Token(Token = "0x40187E5")]
		[FieldOffset(Offset = "0x27")]
		public bool enableExplainText;

		// Token: 0x0401BEA0 RID: 114336
		[Token(Token = "0x40187E6")]
		[FieldOffset(Offset = "0x28")]
		private byte[] explainText;

		// Token: 0x0200153C RID: 5436
		[Token(Token = "0x20015B4")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A500", Offset = "0x15A601")]
		public struct Color4u8Array8 : IList<Color4u8>, ICollection<Color4u8>, IEnumerable<Color4u8>, IEnumerable
		{
			// Token: 0x17000E9E RID: 3742
			// (get) Token: 0x06007B7A RID: 31610 RVA: 0x0002B998 File Offset: 0x00029B98
			[Token(Token = "0x17000F01")]
			public int Length
			{
				[Token(Token = "0x6007E7D")]
				[Address(RVA = "0x3664B0", Offset = "0x3665B1", VA = "0x3664B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E9F RID: 3743
			// (get) Token: 0x06007B7B RID: 31611 RVA: 0x0002B9B0 File Offset: 0x00029BB0
			// (set) Token: 0x06007B7C RID: 31612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F02")]
			public Color4u8 Item
			{
				[Token(Token = "0x6007E7E")]
				[Address(RVA = "0x3664C0", Offset = "0x3665C1", VA = "0x3664C0", Slot = "4")]
				get
				{
					return default(Color4u8);
				}
				[Token(Token = "0x6007E7F")]
				[Address(RVA = "0x3665A0", Offset = "0x3666A1", VA = "0x3665A0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EA0 RID: 3744
			// (get) Token: 0x06007B7D RID: 31613 RVA: 0x0002B9C8 File Offset: 0x00029BC8
			[Token(Token = "0x17000F03")]
			public int Count
			{
				[Token(Token = "0x6007E80")]
				[Address(RVA = "0x3666E0", Offset = "0x3667E1", VA = "0x3666E0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EA1 RID: 3745
			// (get) Token: 0x06007B7E RID: 31614 RVA: 0x0002B9E0 File Offset: 0x00029BE0
			[Token(Token = "0x17000F04")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E81")]
				[Address(RVA = "0x3666F0", Offset = "0x3667F1", VA = "0x3666F0", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007B7F RID: 31615 RVA: 0x0002B9F8 File Offset: 0x00029BF8
			[Token(Token = "0x6007E82")]
			[Address(RVA = "0x366700", Offset = "0x366801", VA = "0x366700", Slot = "13")]
			public bool Contains(Color4u8 item)
			{
				return default(bool);
			}

			// Token: 0x06007B80 RID: 31616 RVA: 0x0002BA10 File Offset: 0x00029C10
			[Token(Token = "0x6007E83")]
			[Address(RVA = "0x366710", Offset = "0x366811", VA = "0x366710", Slot = "6")]
			public int IndexOf(Color4u8 item)
			{
				return 0;
			}

			// Token: 0x06007B81 RID: 31617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E84")]
			[Address(RVA = "0x366720", Offset = "0x366821", VA = "0x366720", Slot = "14")]
			public void CopyTo(Color4u8[] array, int arrayIndex)
			{
			}

			// Token: 0x06007B82 RID: 31618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E85")]
			[Address(RVA = "0x366730", Offset = "0x366831", VA = "0x366730", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007B83 RID: 31619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E86")]
			[Address(RVA = "0x366740", Offset = "0x366841", VA = "0x366740", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6A80", Offset = "0x1B6B81")]
			public IEnumerator<Color4u8> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007B84 RID: 31620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E87")]
			[Address(RVA = "0x3667E0", Offset = "0x3668E1", VA = "0x3667E0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007B85 RID: 31621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E88")]
			[Address(RVA = "0x366880", Offset = "0x366981", VA = "0x366880", Slot = "11")]
			public void Add(Color4u8 item)
			{
			}

			// Token: 0x06007B86 RID: 31622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E89")]
			[Address(RVA = "0x366890", Offset = "0x366991", VA = "0x366890", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007B87 RID: 31623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E8A")]
			[Address(RVA = "0x3668A0", Offset = "0x3669A1", VA = "0x3668A0", Slot = "7")]
			public void Insert(int index, Color4u8 item)
			{
			}

			// Token: 0x06007B88 RID: 31624 RVA: 0x0002BA28 File Offset: 0x00029C28
			[Token(Token = "0x6007E8B")]
			[Address(RVA = "0x3668B0", Offset = "0x3669B1", VA = "0x3668B0", Slot = "15")]
			public bool Remove(Color4u8 item)
			{
				return default(bool);
			}

			// Token: 0x06007B89 RID: 31625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E8C")]
			[Address(RVA = "0x3668C0", Offset = "0x3669C1", VA = "0x3668C0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BEA1 RID: 114337
			[Token(Token = "0x401C2B1")]
			private const int _Length = 8;

			// Token: 0x0401BEA2 RID: 114338
			[Token(Token = "0x401C2B2")]
			[FieldOffset(Offset = "0x0")]
			private Color4u8 _value0;

			// Token: 0x0401BEA3 RID: 114339
			[Token(Token = "0x401C2B3")]
			[FieldOffset(Offset = "0x4")]
			private Color4u8 _value1;

			// Token: 0x0401BEA4 RID: 114340
			[Token(Token = "0x401C2B4")]
			[FieldOffset(Offset = "0x8")]
			private Color4u8 _value2;

			// Token: 0x0401BEA5 RID: 114341
			[Token(Token = "0x401C2B5")]
			[FieldOffset(Offset = "0xC")]
			private Color4u8 _value3;

			// Token: 0x0401BEA6 RID: 114342
			[Token(Token = "0x401C2B6")]
			[FieldOffset(Offset = "0x10")]
			private Color4u8 _value4;

			// Token: 0x0401BEA7 RID: 114343
			[Token(Token = "0x401C2B7")]
			[FieldOffset(Offset = "0x14")]
			private Color4u8 _value5;

			// Token: 0x0401BEA8 RID: 114344
			[Token(Token = "0x401C2B8")]
			[FieldOffset(Offset = "0x18")]
			private Color4u8 _value6;

			// Token: 0x0401BEA9 RID: 114345
			[Token(Token = "0x401C2B9")]
			[FieldOffset(Offset = "0x1C")]
			private Color4u8 _value7;

			// Token: 0x0200153D RID: 5437
			[Token(Token = "0x200166E")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AED0", Offset = "0x15AFD1")]
			private sealed class <GetEnumerator>d__22 : IEnumerator<Color4u8>, IEnumerator, IDisposable
			{
				// Token: 0x06007B8A RID: 31626 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008102")]
				[Address(RVA = "0x285B960", Offset = "0x285BA61", VA = "0x285B960")]
				[DebuggerHidden]
				public <GetEnumerator>d__22(int <>1__state)
				{
				}

				// Token: 0x06007B8B RID: 31627 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008103")]
				[Address(RVA = "0x285BC10", Offset = "0x285BD11", VA = "0x285BC10", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007B8C RID: 31628 RVA: 0x0002BA40 File Offset: 0x00029C40
				[Token(Token = "0x6008104")]
				[Address(RVA = "0x285BC20", Offset = "0x285BD21", VA = "0x285BC20", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EA2 RID: 3746
				// (get) Token: 0x06007B8D RID: 31629 RVA: 0x0002BA58 File Offset: 0x00029C58
				[Token(Token = "0x17000F67")]
				private Color4u8 Current
				{
					[Token(Token = "0x6008105")]
					[Address(RVA = "0x285BCC0", Offset = "0x285BDC1", VA = "0x285BCC0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(Color4u8);
					}
				}

				// Token: 0x06007B8E RID: 31630 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008106")]
				[Address(RVA = "0x285BCD0", Offset = "0x285BDD1", VA = "0x285BCD0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EA3 RID: 3747
				// (get) Token: 0x06007B8F RID: 31631 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F68")]
				private object Current
				{
					[Token(Token = "0x6008107")]
					[Address(RVA = "0x285BD30", Offset = "0x285BE31", VA = "0x285BD30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BEAA RID: 114346
				[Token(Token = "0x401C46C")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BEAB RID: 114347
				[Token(Token = "0x401C46D")]
				[FieldOffset(Offset = "0x14")]
				private Color4u8 <>2__current;

				// Token: 0x0401BEAC RID: 114348
				[Token(Token = "0x401C46E")]
				[FieldOffset(Offset = "0x18")]
				public ControllerSupportArg.Color4u8Array8 <>4__this;
			}
		}
	}
}
