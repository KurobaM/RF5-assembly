using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using nn.util;

namespace nn.hid
{
	// Token: 0x0200154B RID: 5451
	[Token(Token = "0x2000EFA")]
	public struct GestureState
	{
		// Token: 0x06007BA9 RID: 31657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600679B")]
		[Address(RVA = "0x366B90", Offset = "0x366C91", VA = "0x366B90")]
		public void SetDefault()
		{
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		[Token(Token = "0x17000B4E")]
		public GestureType type
		{
			[Token(Token = "0x600679C")]
			[Address(RVA = "0x366BA0", Offset = "0x366CA1", VA = "0x366BA0")]
			get
			{
				return GestureType.Idle;
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		[Token(Token = "0x17000B4F")]
		public GestureDirection direction
		{
			[Token(Token = "0x600679D")]
			[Address(RVA = "0x366BB0", Offset = "0x366CB1", VA = "0x366BB0")]
			get
			{
				return GestureDirection.None;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		[Token(Token = "0x17000B50")]
		public bool isDoubleTap
		{
			[Token(Token = "0x600679E")]
			[Address(RVA = "0x366BC0", Offset = "0x366CC1", VA = "0x366BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600679F")]
		[Address(RVA = "0x366BD0", Offset = "0x366CD1", VA = "0x366BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BEE7 RID: 114407
		[Token(Token = "0x4018821")]
		[FieldOffset(Offset = "0x0")]
		public long eventNumber;

		// Token: 0x0401BEE8 RID: 114408
		[Token(Token = "0x4018822")]
		[FieldOffset(Offset = "0x8")]
		public long contextNumber;

		// Token: 0x0401BEE9 RID: 114409
		[Token(Token = "0x4018823")]
		[FieldOffset(Offset = "0x10")]
		public int _type;

		// Token: 0x0401BEEA RID: 114410
		[Token(Token = "0x4018824")]
		[FieldOffset(Offset = "0x14")]
		public int _direction;

		// Token: 0x0401BEEB RID: 114411
		[Token(Token = "0x4018825")]
		[FieldOffset(Offset = "0x18")]
		public int x;

		// Token: 0x0401BEEC RID: 114412
		[Token(Token = "0x4018826")]
		[FieldOffset(Offset = "0x1C")]
		public int y;

		// Token: 0x0401BEED RID: 114413
		[Token(Token = "0x4018827")]
		[FieldOffset(Offset = "0x20")]
		public int deltaX;

		// Token: 0x0401BEEE RID: 114414
		[Token(Token = "0x4018828")]
		[FieldOffset(Offset = "0x24")]
		public int deltaY;

		// Token: 0x0401BEEF RID: 114415
		[Token(Token = "0x4018829")]
		[FieldOffset(Offset = "0x28")]
		public Float2 velocity;

		// Token: 0x0401BEF0 RID: 114416
		[Token(Token = "0x401882A")]
		[FieldOffset(Offset = "0x30")]
		public GestureAttribute attributes;

		// Token: 0x0401BEF1 RID: 114417
		[Token(Token = "0x401882B")]
		[FieldOffset(Offset = "0x34")]
		public float scale;

		// Token: 0x0401BEF2 RID: 114418
		[Token(Token = "0x401882C")]
		[FieldOffset(Offset = "0x38")]
		public float rotationAngle;

		// Token: 0x0401BEF3 RID: 114419
		[Token(Token = "0x401882D")]
		[FieldOffset(Offset = "0x3C")]
		public int pointCount;

		// Token: 0x0401BEF4 RID: 114420
		[Token(Token = "0x401882E")]
		[FieldOffset(Offset = "0x40")]
		public GestureState.GesturePointArray4 points;

		// Token: 0x0200154C RID: 5452
		[Token(Token = "0x20015B5")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x15A540", Offset = "0x15A641")]
		public struct GesturePointArray4 : IList<GesturePoint>, ICollection<GesturePoint>, IEnumerable<GesturePoint>, IEnumerable
		{
			// Token: 0x17000EAB RID: 3755
			// (get) Token: 0x06007BAE RID: 31662 RVA: 0x0002BC08 File Offset: 0x00029E08
			[Token(Token = "0x17000F05")]
			public int Length
			{
				[Token(Token = "0x6007E8D")]
				[Address(RVA = "0x366BE0", Offset = "0x366CE1", VA = "0x366BE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EAC RID: 3756
			// (get) Token: 0x06007BAF RID: 31663 RVA: 0x0002BC20 File Offset: 0x00029E20
			// (set) Token: 0x06007BB0 RID: 31664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000F06")]
			public GesturePoint Item
			{
				[Token(Token = "0x6007E8E")]
				[Address(RVA = "0x366BF0", Offset = "0x366CF1", VA = "0x366BF0", Slot = "4")]
				get
				{
					return default(GesturePoint);
				}
				[Token(Token = "0x6007E8F")]
				[Address(RVA = "0x366CB0", Offset = "0x366DB1", VA = "0x366CB0", Slot = "5")]
				set
				{
				}
			}

			// Token: 0x17000EAD RID: 3757
			// (get) Token: 0x06007BB1 RID: 31665 RVA: 0x0002BC38 File Offset: 0x00029E38
			[Token(Token = "0x17000F07")]
			public int Count
			{
				[Token(Token = "0x6007E90")]
				[Address(RVA = "0x366D80", Offset = "0x366E81", VA = "0x366D80", Slot = "9")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000EAE RID: 3758
			// (get) Token: 0x06007BB2 RID: 31666 RVA: 0x0002BC50 File Offset: 0x00029E50
			[Token(Token = "0x17000F08")]
			public bool IsReadOnly
			{
				[Token(Token = "0x6007E91")]
				[Address(RVA = "0x366D90", Offset = "0x366E91", VA = "0x366D90", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06007BB3 RID: 31667 RVA: 0x0002BC68 File Offset: 0x00029E68
			[Token(Token = "0x6007E92")]
			[Address(RVA = "0x366DA0", Offset = "0x366EA1", VA = "0x366DA0", Slot = "13")]
			public bool Contains(GesturePoint item)
			{
				return default(bool);
			}

			// Token: 0x06007BB4 RID: 31668 RVA: 0x0002BC80 File Offset: 0x00029E80
			[Token(Token = "0x6007E93")]
			[Address(RVA = "0x366E90", Offset = "0x366F91", VA = "0x366E90", Slot = "6")]
			public int IndexOf(GesturePoint item)
			{
				return 0;
			}

			// Token: 0x06007BB5 RID: 31669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E94")]
			[Address(RVA = "0x366F80", Offset = "0x367081", VA = "0x366F80", Slot = "14")]
			public void CopyTo(GesturePoint[] array, int arrayIndex)
			{
			}

			// Token: 0x06007BB6 RID: 31670 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E95")]
			[Address(RVA = "0x366F90", Offset = "0x367091", VA = "0x366F90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06007BB7 RID: 31671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E96")]
			[Address(RVA = "0x366FA0", Offset = "0x3670A1", VA = "0x366FA0", Slot = "16")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1B6AF0", Offset = "0x1B6BF1")]
			public IEnumerator<GesturePoint> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007BB8 RID: 31672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007E97")]
			[Address(RVA = "0x367040", Offset = "0x367141", VA = "0x367040", Slot = "17")]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x06007BB9 RID: 31673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E98")]
			[Address(RVA = "0x3670E0", Offset = "0x3671E1", VA = "0x3670E0", Slot = "11")]
			public void Add(GesturePoint item)
			{
			}

			// Token: 0x06007BBA RID: 31674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E99")]
			[Address(RVA = "0x3670F0", Offset = "0x3671F1", VA = "0x3670F0", Slot = "12")]
			public void Clear()
			{
			}

			// Token: 0x06007BBB RID: 31675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E9A")]
			[Address(RVA = "0x367100", Offset = "0x367201", VA = "0x367100", Slot = "7")]
			public void Insert(int index, GesturePoint item)
			{
			}

			// Token: 0x06007BBC RID: 31676 RVA: 0x0002BC98 File Offset: 0x00029E98
			[Token(Token = "0x6007E9B")]
			[Address(RVA = "0x367110", Offset = "0x367211", VA = "0x367110", Slot = "15")]
			public bool Remove(GesturePoint item)
			{
				return default(bool);
			}

			// Token: 0x06007BBD RID: 31677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007E9C")]
			[Address(RVA = "0x367120", Offset = "0x367221", VA = "0x367120", Slot = "8")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x0401BEF5 RID: 114421
			[Token(Token = "0x401C2BA")]
			private const int _Length = 4;

			// Token: 0x0401BEF6 RID: 114422
			[Token(Token = "0x401C2BB")]
			[FieldOffset(Offset = "0x0")]
			private GesturePoint _value0;

			// Token: 0x0401BEF7 RID: 114423
			[Token(Token = "0x401C2BC")]
			[FieldOffset(Offset = "0x8")]
			private GesturePoint _value1;

			// Token: 0x0401BEF8 RID: 114424
			[Token(Token = "0x401C2BD")]
			[FieldOffset(Offset = "0x10")]
			private GesturePoint _value2;

			// Token: 0x0401BEF9 RID: 114425
			[Token(Token = "0x401C2BE")]
			[FieldOffset(Offset = "0x18")]
			private GesturePoint _value3;

			// Token: 0x0200154D RID: 5453
			[Token(Token = "0x200166F")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AEE0", Offset = "0x15AFE1")]
			private sealed class <GetEnumerator>d__18 : IEnumerator<GesturePoint>, IEnumerator, IDisposable
			{
				// Token: 0x06007BBE RID: 31678 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008108")]
				[Address(RVA = "0x285D340", Offset = "0x285D441", VA = "0x285D340")]
				[DebuggerHidden]
				public <GetEnumerator>d__18(int <>1__state)
				{
				}

				// Token: 0x06007BBF RID: 31679 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6008109")]
				[Address(RVA = "0x285D5F0", Offset = "0x285D6F1", VA = "0x285D5F0", Slot = "5")]
				[DebuggerHidden]
				private void Dispose()
				{
				}

				// Token: 0x06007BC0 RID: 31680 RVA: 0x0002BCB0 File Offset: 0x00029EB0
				[Token(Token = "0x600810A")]
				[Address(RVA = "0x285D600", Offset = "0x285D701", VA = "0x285D600", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x17000EAF RID: 3759
				// (get) Token: 0x06007BC1 RID: 31681 RVA: 0x0002BCC8 File Offset: 0x00029EC8
				[Token(Token = "0x17000F69")]
				private GesturePoint Current
				{
					[Token(Token = "0x600810B")]
					[Address(RVA = "0x285D670", Offset = "0x285D771", VA = "0x285D670", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return default(GesturePoint);
					}
				}

				// Token: 0x06007BC2 RID: 31682 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600810C")]
				[Address(RVA = "0x285D680", Offset = "0x285D781", VA = "0x285D680", Slot = "8")]
				[DebuggerHidden]
				private void Reset()
				{
				}

				// Token: 0x17000EB0 RID: 3760
				// (get) Token: 0x06007BC3 RID: 31683 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000F6A")]
				private object Current
				{
					[Token(Token = "0x600810D")]
					[Address(RVA = "0x285D6E0", Offset = "0x285D7E1", VA = "0x285D6E0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				// Token: 0x0401BEFA RID: 114426
				[Token(Token = "0x401C46F")]
				[FieldOffset(Offset = "0x10")]
				private int <>1__state;

				// Token: 0x0401BEFB RID: 114427
				[Token(Token = "0x401C470")]
				[FieldOffset(Offset = "0x14")]
				private GesturePoint <>2__current;

				// Token: 0x0401BEFC RID: 114428
				[Token(Token = "0x401C471")]
				[FieldOffset(Offset = "0x1C")]
				public GestureState.GesturePointArray4 <>4__this;
			}
		}
	}
}
