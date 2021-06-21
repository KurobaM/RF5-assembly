using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001517 RID: 5399
	[Token(Token = "0x2000ED2")]
	public struct Hand : IEquatable<Hand>
	{
		// Token: 0x06007AB0 RID: 31408 RVA: 0x0002B0B0 File Offset: 0x000292B0
		[Token(Token = "0x6006726")]
		[Address(RVA = "0x2D7D460", Offset = "0x2D7D561", VA = "0x2D7D460")]
		public static bool operator ==(Hand lhs, Hand rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x0002B0C8 File Offset: 0x000292C8
		[Token(Token = "0x6006727")]
		[Address(RVA = "0x2D7DBC0", Offset = "0x2D7DCC1", VA = "0x2D7DBC0")]
		public static bool operator !=(Hand lhs, Hand rhs)
		{
			return default(bool);
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x0002B0E0 File Offset: 0x000292E0
		[Token(Token = "0x6006728")]
		[Address(RVA = "0x388CF0", Offset = "0x388DF1", VA = "0x388CF0", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x0002B0F8 File Offset: 0x000292F8
		[Token(Token = "0x6006729")]
		[Address(RVA = "0x388DC0", Offset = "0x388EC1", VA = "0x388DC0", Slot = "4")]
		public bool Equals(Hand other)
		{
			return default(bool);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x0002B110 File Offset: 0x00029310
		[Token(Token = "0x600672A")]
		[Address(RVA = "0x388E30", Offset = "0x388F31", VA = "0x388E30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BDB7 RID: 114103
		[Token(Token = "0x4018760")]
		[FieldOffset(Offset = "0x0")]
		public int shapeId;

		// Token: 0x0401BDB8 RID: 114104
		[Token(Token = "0x4018761")]
		[FieldOffset(Offset = "0x4")]
		public int protrusionCount;

		// Token: 0x0401BDB9 RID: 114105
		[Token(Token = "0x4018762")]
		[FieldOffset(Offset = "0x8")]
		public Hand.ProtrusionArray8 protrusions;

		// Token: 0x0401BDBA RID: 114106
		[Token(Token = "0x4018763")]
		[FieldOffset(Offset = "0x48")]
		public HandChirality chirality;

		// Token: 0x0401BDBB RID: 114107
		[Token(Token = "0x4018764")]
		[FieldOffset(Offset = "0x4C")]
		public Hand.Fingers fingers;

		// Token: 0x0401BDBC RID: 114108
		[Token(Token = "0x4018765")]
		[FieldOffset(Offset = "0xD8")]
		public bool areIndexMiddleFingersTouching;

		// Token: 0x0401BDBD RID: 114109
		[Token(Token = "0x4018766")]
		[FieldOffset(Offset = "0xD9")]
		public bool areMiddleRingFingersTouching;

		// Token: 0x0401BDBE RID: 114110
		[Token(Token = "0x4018767")]
		[FieldOffset(Offset = "0xDA")]
		public bool areRingLittleFingersTouching;

		// Token: 0x0401BDBF RID: 114111
		[Token(Token = "0x4018768")]
		[FieldOffset(Offset = "0xDC")]
		public Palm palm;

		// Token: 0x0401BDC0 RID: 114112
		[Token(Token = "0x4018769")]
		[FieldOffset(Offset = "0xEC")]
		public Arm arm;

		// Token: 0x02001518 RID: 5400
		[Token(Token = "0x20015AF")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A3C0", Offset = "0x15A4C1")]
		public struct ProtrusionArray8 : IList<Protrusion>, ICollection<Protrusion>, IEnumerable<Protrusion>, IEnumerable
		{
			// Token: 0x17000E72 RID: 3698
			// (get) Token: 0x06007AB5 RID: 31413 RVA: 0x0002B128 File Offset: 0x00029328
			[Token(Token = "0x17000EED")]
			public int Length
			{
				[Token(Token = "0x6007E2D")]
				[Address(RVA = "0x39E3A0", Offset = "0x39E4A1", VA = "0x39E3A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E73 RID: 3699
			// (get) Token: 0x06007AB6 RID: 31414 RVA: 0x0002B140 File Offset: 0x00029340
			// (set) Token: 0x06007AB7 RID: 31415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EEE")]
			public Protrusion Item
			{
				[Token(Token = "0x6007E2E")]
				[Address(RVA = "0x39E3B0", Offset = "0x39E4B1", VA = "0x39E3B0", Slot = "4")]
				get
				{
					return default(Protrusion);
				}
				[Token(Token = "0x6007E2F")]
				[Address(RVA = "0x39E490", Offset = "0x39E591", VA = "0x39E490", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E74 RID: 3700
			// (get) Token: 0x06007AB8 RID: 31416 RVA: 0x0002B158 File Offset: 0x00029358
			[Token(Token = "0x17000EEF")]
			public int Count
			{
				[Token(Token = "0x6007E30")]
				[Address(RVA = "0x39E580", Offset = "0x39E681", VA = "0x39E580", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E75 RID: 3701
			// (get) Token: 0x06007AB9 RID: 31417 RVA: 0x0002B170 File Offset: 0x00029370
			[Token(Token = "0x17000EF0")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E31")]
				[Address(RVA = "0x39E590", Offset = "0x39E691", VA = "0x39E590", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007ABA RID: 31418 RVA: 0x0002B188 File Offset: 0x00029388
			[Token(Token = "0x6007E32")]
			[Address(RVA = "0x39E5A0", Offset = "0x39E6A1", VA = "0x39E5A0", Slot = "13")]
			public bool Contains(Protrusion item)
			{
				return default(bool);
			}

			// Token: 0x06007ABB RID: 31419 RVA: 0x0002B1A0 File Offset: 0x000293A0
			[Token(Token = "0x6007E33")]
			[Address(RVA = "0x39E5B0", Offset = "0x39E6B1", VA = "0x39E5B0", Slot = "6")]
			public int IndexOf(Protrusion item)
			{
				return 0;
			}

			// Token: 0x06007ABC RID: 31420 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E34")]
			[Address(RVA = "0x39E5C0", Offset = "0x39E6C1", VA = "0x39E5C0", Slot = "14")]
			public void CopyTo(Protrusion[] array, int arrayIndex)
			{
			}

			// Token: 0x06007ABD RID: 31421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E35")]
			[Address(RVA = "0x39E5D0", Offset = "0x39E6D1", VA = "0x39E5D0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007ABE RID: 31422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E36")]
			[Address(RVA = "0x39E5E0", Offset = "0x39E6E1", VA = "0x39E5E0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6850", Offset = "0x1B6951")]
			public IEnumerator<Protrusion> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007ABF RID: 31423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E37")]
			[Address(RVA = "0x39E6B0", Offset = "0x39E7B1", VA = "0x39E6B0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007AC0 RID: 31424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E38")]
			[Address(RVA = "0x39E780", Offset = "0x39E881", VA = "0x39E780", Slot = "11")]
			public void Add(Protrusion item)
			{
			}

			// Token: 0x06007AC1 RID: 31425 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E39")]
			[Address(RVA = "0x39E790", Offset = "0x39E891", VA = "0x39E790", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007AC2 RID: 31426 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3A")]
			[Address(RVA = "0x39E7A0", Offset = "0x39E8A1", VA = "0x39E7A0", Slot = "7")]
			public void Insert(int index, Protrusion item)
			{
			}

			// Token: 0x06007AC3 RID: 31427 RVA: 0x0002B1B8 File Offset: 0x000293B8
			[Token(Token = "0x6007E3B")]
			[Address(RVA = "0x39E7B0", Offset = "0x39E8B1", VA = "0x39E7B0", Slot = "15")]
			public bool Remove(Protrusion item)
			{
				return default(bool);
			}

			// Token: 0x06007AC4 RID: 31428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E3C")]
			[Address(RVA = "0x39E7C0", Offset = "0x39E8C1", VA = "0x39E7C0", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BDC1 RID: 114113
			[Token(Token = "0x401C25D")]
			private const int _Length = 8;

			// Token: 0x0401BDC2 RID: 114114
			[Token(Token = "0x401C25E")]
			[FieldOffset(Offset = "0x0")]
			private Protrusion _value0;

			// Token: 0x0401BDC3 RID: 114115
			[Token(Token = "0x401C25F")]
			[FieldOffset(Offset = "0x8")]
			private Protrusion _value1;

			// Token: 0x0401BDC4 RID: 114116
			[Token(Token = "0x401C260")]
			[FieldOffset(Offset = "0x10")]
			private Protrusion _value2;

			// Token: 0x0401BDC5 RID: 114117
			[Token(Token = "0x401C261")]
			[FieldOffset(Offset = "0x18")]
			private Protrusion _value3;

			// Token: 0x0401BDC6 RID: 114118
			[Token(Token = "0x401C262")]
			[FieldOffset(Offset = "0x20")]
			private Protrusion _value4;

			// Token: 0x0401BDC7 RID: 114119
			[Token(Token = "0x401C263")]
			[FieldOffset(Offset = "0x28")]
			private Protrusion _value5;

			// Token: 0x0401BDC8 RID: 114120
			[Token(Token = "0x401C264")]
			[FieldOffset(Offset = "0x30")]
			private Protrusion _value6;

			// Token: 0x0401BDC9 RID: 114121
			[Token(Token = "0x401C265")]
			[FieldOffset(Offset = "0x38")]
			private Protrusion _value7;

			// Token: 0x02001519 RID: 5401
			[Token(Token = "0x2001669")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE80", Offset = "0x15AF81")]
			private sealed class <GetEnumerator>d__22 : IEnumerator<Protrusion>, IEnumerator, IDisposable
			{
				// Token: 0x06007AC5 RID: 31429 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080E4")]
				[Address(RVA = "0x34D97F0", Offset = "0x34D98F1", VA = "0x34D97F0")]
				[DebuggerHidden]
				public <GetEnumerator>d__22(int <>1__state)
				{
				}

				// Token: 0x06007AC6 RID: 31430 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080E5")]
				[Address(RVA = "0x34D9AD0", Offset = "0x34D9BD1", VA = "0x34D9AD0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007AC7 RID: 31431 RVA: 0x0002B1D0 File Offset: 0x000293D0
				[Token(Token = "0x60080E6")]
				[Address(RVA = "0x34D9AE0", Offset = "0x34D9BE1", VA = "0x34D9AE0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E76 RID: 3702
				// (get) Token: 0x06007AC8 RID: 31432 RVA: 0x0002B1E8 File Offset: 0x000293E8
				[Token(Token = "0x17000F5D")]
				private Protrusion Current
				{
					[Token(Token = "0x60080E7")]
					[Address(RVA = "0x34D9B80", Offset = "0x34D9C81", VA = "0x34D9B80", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(Protrusion);
					}
				}

				// Token: 0x06007AC9 RID: 31433 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080E8")]
				[Address(RVA = "0x34D9B90", Offset = "0x34D9C91", VA = "0x34D9B90", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E77 RID: 3703
				// (get) Token: 0x06007ACA RID: 31434 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F5E")]
				private object Current
				{
					[Token(Token = "0x60080E9")]
					[Address(RVA = "0x34D9BF0", Offset = "0x34D9CF1", VA = "0x34D9BF0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BDCA RID: 114122
				[Token(Token = "0x401C45D")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BDCB RID: 114123
				[Token(Token = "0x401C45E")]
				[FieldOffset(Offset = "0x14")]
				private Protrusion <>2__current;

				// Token: 0x0401BDCC RID: 114124
				[Token(Token = "0x401C45F")]
				[FieldOffset(Offset = "0x1C")]
				public Hand.ProtrusionArray8 <>4__this;
			}
		}

		// Token: 0x0200151A RID: 5402
		[Token(Token = "0x20015B0")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A400", Offset = "0x15A501")]
		public struct Fingers : IList<Finger>, ICollection<Finger>, IEnumerable<Finger>, IEnumerable
		{
			// Token: 0x17000E78 RID: 3704
			// (get) Token: 0x06007ACB RID: 31435 RVA: 0x0002B200 File Offset: 0x00029400
			[Token(Token = "0x17000EF1")]
			public int Length
			{
				[Token(Token = "0x6007E3D")]
				[Address(RVA = "0x388EC0", Offset = "0x388FC1", VA = "0x388EC0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E79 RID: 3705
			// (get) Token: 0x06007ACC RID: 31436 RVA: 0x0002B218 File Offset: 0x00029418
			// (set) Token: 0x06007ACD RID: 31437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF2")]
			public Finger Item
			{
				[Token(Token = "0x6007E3E")]
				[Address(RVA = "0x388ED0", Offset = "0x388FD1", VA = "0x388ED0", Slot = "4")]
				get
				{
					return default(Finger);
				}
				[Token(Token = "0x6007E3F")]
				[Address(RVA = "0x388FF0", Offset = "0x3890F1", VA = "0x388FF0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E7A RID: 3706
			// (get) Token: 0x06007ACE RID: 31438 RVA: 0x0002B230 File Offset: 0x00029430
			[Token(Token = "0x17000EF3")]
			public int Count
			{
				[Token(Token = "0x6007E40")]
				[Address(RVA = "0x389150", Offset = "0x389251", VA = "0x389150", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E7B RID: 3707
			// (get) Token: 0x06007ACF RID: 31439 RVA: 0x0002B248 File Offset: 0x00029448
			[Token(Token = "0x17000EF4")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E41")]
				[Address(RVA = "0x389160", Offset = "0x389261", VA = "0x389160", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007AD0 RID: 31440 RVA: 0x0002B260 File Offset: 0x00029460
			[Token(Token = "0x6007E42")]
			[Address(RVA = "0x389170", Offset = "0x389271", VA = "0x389170", Slot = "13")]
			public bool Contains(Finger item)
			{
				return default(bool);
			}

			// Token: 0x06007AD1 RID: 31441 RVA: 0x0002B278 File Offset: 0x00029478
			[Token(Token = "0x6007E43")]
			[Address(RVA = "0x3891B0", Offset = "0x3892B1", VA = "0x3891B0", Slot = "6")]
			public int IndexOf(Finger item)
			{
				return 0;
			}

			// Token: 0x06007AD2 RID: 31442 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E44")]
			[Address(RVA = "0x3891F0", Offset = "0x3892F1", VA = "0x3891F0", Slot = "14")]
			public void CopyTo(Finger[] array, int arrayIndex)
			{
			}

			// Token: 0x06007AD3 RID: 31443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E45")]
			[Address(RVA = "0x389200", Offset = "0x389301", VA = "0x389200", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007AD4 RID: 31444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E46")]
			[Address(RVA = "0x389210", Offset = "0x389311", VA = "0x389210", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B68C0", Offset = "0x1B69C1")]
			public IEnumerator<Finger> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007AD5 RID: 31445 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E47")]
			[Address(RVA = "0x3892B0", Offset = "0x3893B1", VA = "0x3892B0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007AD6 RID: 31446 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E48")]
			[Address(RVA = "0x389350", Offset = "0x389451", VA = "0x389350", Slot = "11")]
			public void Add(Finger item)
			{
			}

			// Token: 0x06007AD7 RID: 31447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E49")]
			[Address(RVA = "0x389360", Offset = "0x389461", VA = "0x389360", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007AD8 RID: 31448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E4A")]
			[Address(RVA = "0x389370", Offset = "0x389471", VA = "0x389370", Slot = "7")]
			public void Insert(int index, Finger item)
			{
			}

			// Token: 0x06007AD9 RID: 31449 RVA: 0x0002B290 File Offset: 0x00029490
			[Token(Token = "0x6007E4B")]
			[Address(RVA = "0x389380", Offset = "0x389481", VA = "0x389380", Slot = "15")]
			public bool Remove(Finger item)
			{
				return default(bool);
			}

			// Token: 0x06007ADA RID: 31450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E4C")]
			[Address(RVA = "0x389390", Offset = "0x389491", VA = "0x389390", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BDCD RID: 114125
			[Token(Token = "0x401C266")]
			private const int _Length = 5;

			// Token: 0x0401BDCE RID: 114126
			[Token(Token = "0x401C267")]
			[FieldOffset(Offset = "0x0")]
			public Finger thumb;

			// Token: 0x0401BDCF RID: 114127
			[Token(Token = "0x401C268")]
			[FieldOffset(Offset = "0x1C")]
			public Finger index;

			// Token: 0x0401BDD0 RID: 114128
			[Token(Token = "0x401C269")]
			[FieldOffset(Offset = "0x38")]
			public Finger middle;

			// Token: 0x0401BDD1 RID: 114129
			[Token(Token = "0x401C26A")]
			[FieldOffset(Offset = "0x54")]
			public Finger ring;

			// Token: 0x0401BDD2 RID: 114130
			[Token(Token = "0x401C26B")]
			[FieldOffset(Offset = "0x70")]
			public Finger little;

			// Token: 0x0200151B RID: 5403
			[Token(Token = "0x200166A")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE90", Offset = "0x15AF91")]
			private sealed class <GetEnumerator>d__19 : IEnumerator<Finger>, IEnumerator, IDisposable
			{
				// Token: 0x06007ADB RID: 31451 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080EA")]
				[Address(RVA = "0x34D8AE0", Offset = "0x34D8BE1", VA = "0x34D8AE0")]
				[DebuggerHidden]
				public <GetEnumerator>d__19(int <>1__state)
				{
				}

				// Token: 0x06007ADC RID: 31452 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080EB")]
				[Address(RVA = "0x34D8B10", Offset = "0x34D8C11", VA = "0x34D8B10", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007ADD RID: 31453 RVA: 0x0002B2A8 File Offset: 0x000294A8
				[Token(Token = "0x60080EC")]
				[Address(RVA = "0x34D8B20", Offset = "0x34D8C21", VA = "0x34D8B20", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E7C RID: 3708
				// (get) Token: 0x06007ADE RID: 31454 RVA: 0x0002B2C0 File Offset: 0x000294C0
				[Token(Token = "0x17000F5F")]
				private Finger Current
				{
					[Token(Token = "0x60080ED")]
					[Address(RVA = "0x34D8C20", Offset = "0x34D8D21", VA = "0x34D8C20", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(Finger);
					}
				}

				// Token: 0x06007ADF RID: 31455 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080EE")]
				[Address(RVA = "0x34D8C40", Offset = "0x34D8D41", VA = "0x34D8C40", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E7D RID: 3709
				// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F60")]
				private object Current
				{
					[Token(Token = "0x60080EF")]
					[Address(RVA = "0x34D8CA0", Offset = "0x34D8DA1", VA = "0x34D8CA0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BDD3 RID: 114131
				[Token(Token = "0x401C460")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BDD4 RID: 114132
				[Token(Token = "0x401C461")]
				[FieldOffset(Offset = "0x14")]
				private Finger <>2__current;

				// Token: 0x0401BDD5 RID: 114133
				[Token(Token = "0x401C462")]
				[FieldOffset(Offset = "0x30")]
				public Hand.Fingers <>4__this;
			}
		}
	}
}
