using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x0200151D RID: 5405
	[Token(Token = "0x2000ED4")]
	public struct HandAnalysisSilhouetteState
	{
		// Token: 0x0401BDDA RID: 114138
		[Token(Token = "0x401876E")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BDDB RID: 114139
		[Token(Token = "0x401876F")]
		[FieldOffset(Offset = "0x8")]
		public IrCameraAmbientNoiseLevel ambientNoiseLevel;

		// Token: 0x0401BDDC RID: 114140
		[Token(Token = "0x4018770")]
		[FieldOffset(Offset = "0xC")]
		public int shapeCount;

		// Token: 0x0401BDDD RID: 114141
		[Token(Token = "0x4018771")]
		[FieldOffset(Offset = "0x10")]
		public HandAnalysisSilhouetteState.ShapeArray16 shapes;

		// Token: 0x0401BDDE RID: 114142
		[Token(Token = "0x4018772")]
		[FieldOffset(Offset = "0x150")]
		public int handCount;

		// Token: 0x0401BDDF RID: 114143
		[Token(Token = "0x4018773")]
		[FieldOffset(Offset = "0x154")]
		public HandAnalysisSilhouetteState.HandArray2 hands;

		// Token: 0x0200151E RID: 5406
		[Token(Token = "0x20015B1")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A440", Offset = "0x15A541")]
		public struct ShapeArray16 : IList<Shape>, ICollection<Shape>, IEnumerable<Shape>, IEnumerable
		{
			// Token: 0x17000E7E RID: 3710
			// (get) Token: 0x06007AE7 RID: 31463 RVA: 0x0002B350 File Offset: 0x00029550
			[Token(Token = "0x17000EF5")]
			public int Length
			{
				[Token(Token = "0x6007E4D")]
				[Address(RVA = "0x39EF90", Offset = "0x39F091", VA = "0x39EF90")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E7F RID: 3711
			// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x0002B368 File Offset: 0x00029568
			// (set) Token: 0x06007AE9 RID: 31465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EF6")]
			public Shape Item
			{
				[Token(Token = "0x6007E4E")]
				[Address(RVA = "0x39EFA0", Offset = "0x39F0A1", VA = "0x39EFA0", Slot = "4")]
				get
				{
					return default(Shape);
				}
				[Token(Token = "0x6007E4F")]
				[Address(RVA = "0x39EFB0", Offset = "0x39F0B1", VA = "0x39EFB0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E80 RID: 3712
			// (get) Token: 0x06007AEA RID: 31466 RVA: 0x0002B380 File Offset: 0x00029580
			[Token(Token = "0x17000EF7")]
			public int Count
			{
				[Token(Token = "0x6007E50")]
				[Address(RVA = "0x39EFF0", Offset = "0x39F0F1", VA = "0x39EFF0", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E81 RID: 3713
			// (get) Token: 0x06007AEB RID: 31467 RVA: 0x0002B398 File Offset: 0x00029598
			[Token(Token = "0x17000EF8")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E51")]
				[Address(RVA = "0x39F000", Offset = "0x39F101", VA = "0x39F000", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007AEC RID: 31468 RVA: 0x0002B3B0 File Offset: 0x000295B0
			[Token(Token = "0x6007E52")]
			[Address(RVA = "0x39F010", Offset = "0x39F111", VA = "0x39F010", Slot = "13")]
			public bool Contains(Shape item)
			{
				return default(bool);
			}

			// Token: 0x06007AED RID: 31469 RVA: 0x0002B3C8 File Offset: 0x000295C8
			[Token(Token = "0x6007E53")]
			[Address(RVA = "0x39F0B0", Offset = "0x39F1B1", VA = "0x39F0B0", Slot = "6")]
			public int IndexOf(Shape item)
			{
				return 0;
			}

			// Token: 0x06007AEE RID: 31470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E54")]
			[Address(RVA = "0x39F160", Offset = "0x39F261", VA = "0x39F160", Slot = "14")]
			public void CopyTo(Shape[] array, int arrayIndex)
			{
			}

			// Token: 0x06007AEF RID: 31471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E55")]
			[Address(RVA = "0x39F170", Offset = "0x39F271", VA = "0x39F170", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007AF0 RID: 31472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E56")]
			[Address(RVA = "0x39F180", Offset = "0x39F281", VA = "0x39F180", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6930", Offset = "0x1B6A31")]
			public IEnumerator<Shape> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007AF1 RID: 31473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E57")]
			[Address(RVA = "0x39F220", Offset = "0x39F321", VA = "0x39F220", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007AF2 RID: 31474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E58")]
			[Address(RVA = "0x39F2C0", Offset = "0x39F3C1", VA = "0x39F2C0", Slot = "11")]
			public void Add(Shape item)
			{
			}

			// Token: 0x06007AF3 RID: 31475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E59")]
			[Address(RVA = "0x39F2D0", Offset = "0x39F3D1", VA = "0x39F2D0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007AF4 RID: 31476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E5A")]
			[Address(RVA = "0x39F2E0", Offset = "0x39F3E1", VA = "0x39F2E0", Slot = "7")]
			public void Insert(int index, Shape item)
			{
			}

			// Token: 0x06007AF5 RID: 31477 RVA: 0x0002B3E0 File Offset: 0x000295E0
			[Token(Token = "0x6007E5B")]
			[Address(RVA = "0x39F2F0", Offset = "0x39F3F1", VA = "0x39F2F0", Slot = "15")]
			public bool Remove(Shape item)
			{
				return default(bool);
			}

			// Token: 0x06007AF6 RID: 31478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E5C")]
			[Address(RVA = "0x39F300", Offset = "0x39F401", VA = "0x39F300", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BDE0 RID: 114144
			[Token(Token = "0x401C26C")]
			private const int _Length = 16;

			// Token: 0x0401BDE1 RID: 114145
			[Token(Token = "0x401C26D")]
			[FieldOffset(Offset = "0x0")]
			private Shape _value0;

			// Token: 0x0401BDE2 RID: 114146
			[Token(Token = "0x401C26E")]
			[FieldOffset(Offset = "0x14")]
			private Shape _value1;

			// Token: 0x0401BDE3 RID: 114147
			[Token(Token = "0x401C26F")]
			[FieldOffset(Offset = "0x28")]
			private Shape _value2;

			// Token: 0x0401BDE4 RID: 114148
			[Token(Token = "0x401C270")]
			[FieldOffset(Offset = "0x3C")]
			private Shape _value3;

			// Token: 0x0401BDE5 RID: 114149
			[Token(Token = "0x401C271")]
			[FieldOffset(Offset = "0x50")]
			private Shape _value4;

			// Token: 0x0401BDE6 RID: 114150
			[Token(Token = "0x401C272")]
			[FieldOffset(Offset = "0x64")]
			private Shape _value5;

			// Token: 0x0401BDE7 RID: 114151
			[Token(Token = "0x401C273")]
			[FieldOffset(Offset = "0x78")]
			private Shape _value6;

			// Token: 0x0401BDE8 RID: 114152
			[Token(Token = "0x401C274")]
			[FieldOffset(Offset = "0x8C")]
			private Shape _value7;

			// Token: 0x0401BDE9 RID: 114153
			[Token(Token = "0x401C275")]
			[FieldOffset(Offset = "0xA0")]
			private Shape _value8;

			// Token: 0x0401BDEA RID: 114154
			[Token(Token = "0x401C276")]
			[FieldOffset(Offset = "0xB4")]
			private Shape _value9;

			// Token: 0x0401BDEB RID: 114155
			[Token(Token = "0x401C277")]
			[FieldOffset(Offset = "0xC8")]
			private Shape _value10;

			// Token: 0x0401BDEC RID: 114156
			[Token(Token = "0x401C278")]
			[FieldOffset(Offset = "0xDC")]
			private Shape _value11;

			// Token: 0x0401BDED RID: 114157
			[Token(Token = "0x401C279")]
			[FieldOffset(Offset = "0xF0")]
			private Shape _value12;

			// Token: 0x0401BDEE RID: 114158
			[Token(Token = "0x401C27A")]
			[FieldOffset(Offset = "0x104")]
			private Shape _value13;

			// Token: 0x0401BDEF RID: 114159
			[Token(Token = "0x401C27B")]
			[FieldOffset(Offset = "0x118")]
			private Shape _value14;

			// Token: 0x0401BDF0 RID: 114160
			[Token(Token = "0x401C27C")]
			[FieldOffset(Offset = "0x12C")]
			private Shape _value15;

			// Token: 0x0200151F RID: 5407
			[Token(Token = "0x200166B")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AEA0", Offset = "0x15AFA1")]
			private sealed class <GetEnumerator>d__30 : IEnumerator<Shape>, IEnumerator, IDisposable
			{
				// Token: 0x06007AF7 RID: 31479 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080F0")]
				[Address(RVA = "0x34DBD70", Offset = "0x34DBE71", VA = "0x34DBD70")]
				[DebuggerHidden]
				public <GetEnumerator>d__30(int <>1__state)
				{
				}

				// Token: 0x06007AF8 RID: 31480 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080F1")]
				[Address(RVA = "0x34DC020", Offset = "0x34DC121", VA = "0x34DC020", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007AF9 RID: 31481 RVA: 0x0002B3F8 File Offset: 0x000295F8
				[Token(Token = "0x60080F2")]
				[Address(RVA = "0x34DC030", Offset = "0x34DC131", VA = "0x34DC030", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E82 RID: 3714
				// (get) Token: 0x06007AFA RID: 31482 RVA: 0x0002B410 File Offset: 0x00029610
				[Token(Token = "0x17000F61")]
				private Shape Current
				{
					[Token(Token = "0x60080F3")]
					[Address(RVA = "0x34DC2A0", Offset = "0x34DC3A1", VA = "0x34DC2A0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(Shape);
					}
				}

				// Token: 0x06007AFB RID: 31483 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080F4")]
				[Address(RVA = "0x34DC2C0", Offset = "0x34DC3C1", VA = "0x34DC2C0", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E83 RID: 3715
				// (get) Token: 0x06007AFC RID: 31484 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F62")]
				private object Current
				{
					[Token(Token = "0x60080F5")]
					[Address(RVA = "0x34DC320", Offset = "0x34DC421", VA = "0x34DC320", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BDF1 RID: 114161
				[Token(Token = "0x401C463")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BDF2 RID: 114162
				[Token(Token = "0x401C464")]
				[FieldOffset(Offset = "0x14")]
				private Shape <>2__current;

				// Token: 0x0401BDF3 RID: 114163
				[Token(Token = "0x401C465")]
				[FieldOffset(Offset = "0x28")]
				public HandAnalysisSilhouetteState.ShapeArray16 <>4__this;
			}
		}

		// Token: 0x02001520 RID: 5408
		[Token(Token = "0x20015B2")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A480", Offset = "0x15A581")]
		public struct HandArray2 : IList<Hand>, ICollection<Hand>, IEnumerable<Hand>, IEnumerable
		{
			// Token: 0x17000E84 RID: 3716
			// (get) Token: 0x06007AFD RID: 31485 RVA: 0x0002B428 File Offset: 0x00029628
			[Token(Token = "0x17000EF9")]
			public int Length
			{
				[Token(Token = "0x6007E5D")]
				[Address(RVA = "0x39E990", Offset = "0x39EA91", VA = "0x39E990")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E85 RID: 3717
			// (get) Token: 0x06007AFE RID: 31486 RVA: 0x0002B440 File Offset: 0x00029640
			// (set) Token: 0x06007AFF RID: 31487 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EFA")]
			public Hand Item
			{
				[Token(Token = "0x6007E5E")]
				[Address(RVA = "0x39E9A0", Offset = "0x39EAA1", VA = "0x39E9A0", Slot = "4")]
				get
				{
					return default(Hand);
				}
				[Token(Token = "0x6007E5F")]
				[Address(RVA = "0x39EA40", Offset = "0x39EB41", VA = "0x39EA40", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000E86 RID: 3718
			// (get) Token: 0x06007B00 RID: 31488 RVA: 0x0002B458 File Offset: 0x00029658
			[Token(Token = "0x17000EFB")]
			public int Count
			{
				[Token(Token = "0x6007E60")]
				[Address(RVA = "0x39EB00", Offset = "0x39EC01", VA = "0x39EB00", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000E87 RID: 3719
			// (get) Token: 0x06007B01 RID: 31489 RVA: 0x0002B470 File Offset: 0x00029670
			[Token(Token = "0x17000EFC")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E61")]
				[Address(RVA = "0x39EB10", Offset = "0x39EC11", VA = "0x39EB10", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007B02 RID: 31490 RVA: 0x0002B488 File Offset: 0x00029688
			[Token(Token = "0x6007E62")]
			[Address(RVA = "0x39EB20", Offset = "0x39EC21", VA = "0x39EB20", Slot = "13")]
			public bool Contains(Hand item)
			{
				return default(bool);
			}

			// Token: 0x06007B03 RID: 31491 RVA: 0x0002B4A0 File Offset: 0x000296A0
			[Token(Token = "0x6007E63")]
			[Address(RVA = "0x39EC20", Offset = "0x39ED21", VA = "0x39EC20", Slot = "6")]
			public int IndexOf(Hand item)
			{
				return 0;
			}

			// Token: 0x06007B04 RID: 31492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E64")]
			[Address(RVA = "0x39ED30", Offset = "0x39EE31", VA = "0x39ED30", Slot = "14")]
			public void CopyTo(Hand[] array, int arrayIndex)
			{
			}

			// Token: 0x06007B05 RID: 31493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E65")]
			[Address(RVA = "0x39ED40", Offset = "0x39EE41", VA = "0x39ED40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007B06 RID: 31494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E66")]
			[Address(RVA = "0x39EE00", Offset = "0x39EF01", VA = "0x39EE00", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B69A0", Offset = "0x1B6AA1")]
			public IEnumerator<Hand> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007B07 RID: 31495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E67")]
			[Address(RVA = "0x39EEA0", Offset = "0x39EFA1", VA = "0x39EEA0", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007B08 RID: 31496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E68")]
			[Address(RVA = "0x39EF40", Offset = "0x39F041", VA = "0x39EF40", Slot = "11")]
			public void Add(Hand item)
			{
			}

			// Token: 0x06007B09 RID: 31497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E69")]
			[Address(RVA = "0x39EF50", Offset = "0x39F051", VA = "0x39EF50", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007B0A RID: 31498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E6A")]
			[Address(RVA = "0x39EF60", Offset = "0x39F061", VA = "0x39EF60", Slot = "7")]
			public void Insert(int index, Hand item)
			{
			}

			// Token: 0x06007B0B RID: 31499 RVA: 0x0002B4B8 File Offset: 0x000296B8
			[Token(Token = "0x6007E6B")]
			[Address(RVA = "0x39EF70", Offset = "0x39F071", VA = "0x39EF70", Slot = "15")]
			public bool Remove(Hand item)
			{
				return default(bool);
			}

			// Token: 0x06007B0C RID: 31500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E6C")]
			[Address(RVA = "0x39EF80", Offset = "0x39F081", VA = "0x39EF80", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BDF4 RID: 114164
			[Token(Token = "0x401C27D")]
			private const int _Length = 2;

			// Token: 0x0401BDF5 RID: 114165
			[Token(Token = "0x401C27E")]
			[FieldOffset(Offset = "0x0")]
			private Hand _value0;

			// Token: 0x0401BDF6 RID: 114166
			[Token(Token = "0x401C27F")]
			[FieldOffset(Offset = "0x104")]
			private Hand _value1;

			// Token: 0x02001521 RID: 5409
			[Token(Token = "0x200166C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AEB0", Offset = "0x15AFB1")]
			private sealed class <GetEnumerator>d__16 : IEnumerator<Hand>, IEnumerator, IDisposable
			{
				// Token: 0x06007B0D RID: 31501 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080F6")]
				[Address(RVA = "0x34DA6F0", Offset = "0x34DA7F1", VA = "0x34DA6F0")]
				[DebuggerHidden]
				public <GetEnumerator>d__16(int <>1__state)
				{
				}

				// Token: 0x06007B0E RID: 31502 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080F7")]
				[Address(RVA = "0x34DA9A0", Offset = "0x34DAAA1", VA = "0x34DA9A0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007B0F RID: 31503 RVA: 0x0002B4D0 File Offset: 0x000296D0
				[Token(Token = "0x60080F8")]
				[Address(RVA = "0x34DA9B0", Offset = "0x34DAAB1", VA = "0x34DA9B0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000E88 RID: 3720
				// (get) Token: 0x06007B10 RID: 31504 RVA: 0x0002B4E8 File Offset: 0x000296E8
				[Token(Token = "0x17000F63")]
				private Hand Current
				{
					[Token(Token = "0x60080F9")]
					[Address(RVA = "0x34DAA30", Offset = "0x34DAB31", VA = "0x34DAA30", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(Hand);
					}
				}

				// Token: 0x06007B11 RID: 31505 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080FA")]
				[Address(RVA = "0x34DAA40", Offset = "0x34DAB41", VA = "0x34DAA40", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000E89 RID: 3721
				// (get) Token: 0x06007B12 RID: 31506 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F64")]
				private object Current
				{
					[Token(Token = "0x60080FB")]
					[Address(RVA = "0x34DAAA0", Offset = "0x34DABA1", VA = "0x34DAAA0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BDF7 RID: 114167
				[Token(Token = "0x401C466")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BDF8 RID: 114168
				[Token(Token = "0x401C467")]
				[FieldOffset(Offset = "0x14")]
				private Hand <>2__current;

				// Token: 0x0401BDF9 RID: 114169
				[Token(Token = "0x401C468")]
				[FieldOffset(Offset = "0x118")]
				public HandAnalysisSilhouetteState.HandArray2 <>4__this;
			}
		}
	}
}
