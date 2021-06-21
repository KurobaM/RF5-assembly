using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E34 RID: 3636
	[Token(Token = "0x200094A")]
	[Serializable]
	public struct CoordRect
	{
		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06005F66 RID: 24422 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		[Token(Token = "0x170009BF")]
		public bool isZero
		{
			[Token(Token = "0x6004EDF")]
			[Address(RVA = "0x37BF30", Offset = "0x37C031", VA = "0x37BF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE0")]
		[Address(RVA = "0x37BF50", Offset = "0x37C051", VA = "0x37BF50")]
		public CoordRect(Coord offset, Coord size)
		{
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE1")]
		[Address(RVA = "0x37BF60", Offset = "0x37C061", VA = "0x37BF60")]
		public CoordRect(int offsetX, int offsetZ, int sizeX, int sizeZ)
		{
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE2")]
		[Address(RVA = "0x37BFD0", Offset = "0x37C0D1", VA = "0x37BFD0")]
		public CoordRect(float offsetX, float offsetZ, float sizeX, float sizeZ)
		{
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EE3")]
		[Address(RVA = "0x37C050", Offset = "0x37C151", VA = "0x37C050")]
		public CoordRect(Rect r)
		{
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
		[Token(Token = "0x6004EE4")]
		[Address(RVA = "0x37C100", Offset = "0x37C201", VA = "0x37C100")]
		public int GetPos(int x, int z)
		{
			return 0;
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06005F6C RID: 24428 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		// (set) Token: 0x06005F6D RID: 24429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C0")]
		public Coord Max
		{
			[Token(Token = "0x6004EE5")]
			[Address(RVA = "0x37C120", Offset = "0x37C221", VA = "0x37C120")]
			get
			{
				return default(Coord);
			}
			[Token(Token = "0x6004EE6")]
			[Address(RVA = "0x37C130", Offset = "0x37C231", VA = "0x37C130")]
			set
			{
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06005F6E RID: 24430 RVA: 0x0001FE00 File Offset: 0x0001E000
		// (set) Token: 0x06005F6F RID: 24431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009C1")]
		public Coord Min
		{
			[Token(Token = "0x6004EE7")]
			[Address(RVA = "0x37C170", Offset = "0x37C271", VA = "0x37C170")]
			get
			{
				return default(Coord);
			}
			[Token(Token = "0x6004EE8")]
			[Address(RVA = "0x37C180", Offset = "0x37C281", VA = "0x37C180")]
			set
			{
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06005F70 RID: 24432 RVA: 0x0001FE18 File Offset: 0x0001E018
		[Token(Token = "0x170009C2")]
		public Coord Center
		{
			[Token(Token = "0x6004EE9")]
			[Address(RVA = "0x37C190", Offset = "0x37C291", VA = "0x37C190")]
			get
			{
				return default(Coord);
			}
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x0001FE30 File Offset: 0x0001E030
		[Token(Token = "0x6004EEA")]
		[Address(RVA = "0x2C1CFD0", Offset = "0x2C1D0D1", VA = "0x2C1CFD0")]
		public static bool operator >(CoordRect c1, CoordRect c2)
		{
			return default(bool);
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x0001FE48 File Offset: 0x0001E048
		[Token(Token = "0x6004EEB")]
		[Address(RVA = "0x2C1CFE0", Offset = "0x2C1D0E1", VA = "0x2C1CFE0")]
		public static bool operator <(CoordRect c1, CoordRect c2)
		{
			return default(bool);
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x0001FE60 File Offset: 0x0001E060
		[Token(Token = "0x6004EEC")]
		[Address(RVA = "0x2C1CFF0", Offset = "0x2C1D0F1", VA = "0x2C1CFF0")]
		public static bool operator ==(CoordRect c1, CoordRect c2)
		{
			return default(bool);
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x0001FE78 File Offset: 0x0001E078
		[Token(Token = "0x6004EED")]
		[Address(RVA = "0x2C1D040", Offset = "0x2C1D141", VA = "0x2C1D040")]
		public static bool operator !=(CoordRect c1, CoordRect c2)
		{
			return default(bool);
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x0001FE90 File Offset: 0x0001E090
		[Token(Token = "0x6004EEE")]
		[Address(RVA = "0x2C1D090", Offset = "0x2C1D191", VA = "0x2C1D090")]
		public static CoordRect operator *(CoordRect c, int s)
		{
			return default(CoordRect);
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
		[Token(Token = "0x6004EEF")]
		[Address(RVA = "0x2C1D0E0", Offset = "0x2C1D1E1", VA = "0x2C1D0E0")]
		public static CoordRect operator *(CoordRect c, float s)
		{
			return default(CoordRect);
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		[Token(Token = "0x6004EF0")]
		[Address(RVA = "0x2C1D130", Offset = "0x2C1D231", VA = "0x2C1D130")]
		public static CoordRect operator /(CoordRect c, int s)
		{
			return default(CoordRect);
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		[Token(Token = "0x6004EF1")]
		[Address(RVA = "0x37C1D0", Offset = "0x37C2D1", VA = "0x37C1D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[Token(Token = "0x6004EF2")]
		[Address(RVA = "0x37C260", Offset = "0x37C361", VA = "0x37C260", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF3")]
		[Address(RVA = "0x37C290", Offset = "0x37C391", VA = "0x37C290")]
		public void Round(int val, bool inscribed = false)
		{
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF4")]
		[Address(RVA = "0x37C2E0", Offset = "0x37C3E1", VA = "0x37C2E0")]
		public void Round(CoordRect r, bool inscribed = false)
		{
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EF5")]
		[Address(RVA = "0x37C330", Offset = "0x37C431", VA = "0x37C330")]
		public void Clamp(Coord min, Coord max)
		{
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0001FF08 File Offset: 0x0001E108
		[Token(Token = "0x6004EF6")]
		[Address(RVA = "0x2C1D380", Offset = "0x2C1D481", VA = "0x2C1D380")]
		public static CoordRect Intersect(CoordRect c1, CoordRect c2)
		{
			return default(CoordRect);
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x0001FF20 File Offset: 0x0001E120
		[Token(Token = "0x6004EF7")]
		[Address(RVA = "0x37C3D0", Offset = "0x37C4D1", VA = "0x37C3D0")]
		public Coord CoordByNum(int num)
		{
			return default(Coord);
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x0001FF38 File Offset: 0x0001E138
		[Token(Token = "0x6004EF8")]
		[Address(RVA = "0x37C420", Offset = "0x37C521", VA = "0x37C420")]
		public bool CheckInRange(int x, int z)
		{
			return default(bool);
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x0001FF50 File Offset: 0x0001E150
		[Token(Token = "0x6004EF9")]
		[Address(RVA = "0x37C470", Offset = "0x37C571", VA = "0x37C470")]
		public bool CheckInRange(Coord coord)
		{
			return default(bool);
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x0001FF68 File Offset: 0x0001E168
		[Token(Token = "0x6004EFA")]
		[Address(RVA = "0x37C4D0", Offset = "0x37C5D1", VA = "0x37C4D0")]
		public bool CheckInRangeAndBounds(int x, int z)
		{
			return default(bool);
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x0001FF80 File Offset: 0x0001E180
		[Token(Token = "0x6004EFB")]
		[Address(RVA = "0x37C530", Offset = "0x37C631", VA = "0x37C530")]
		public bool CheckInRangeAndBounds(Coord coord)
		{
			return default(bool);
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x0001FF98 File Offset: 0x0001E198
		[Token(Token = "0x6004EFC")]
		[Address(RVA = "0x37C590", Offset = "0x37C691", VA = "0x37C590")]
		public bool Divisible(float factor)
		{
			return default(bool);
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EFD")]
		[Address(RVA = "0x37C660", Offset = "0x37C761", VA = "0x37C660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[Token(Token = "0x6004EFE")]
		[Address(RVA = "0x37C670", Offset = "0x37C771", VA = "0x37C670")]
		public Vector2 ToWorldspace(Coord coord, Rect worldRect)
		{
			return default(Vector2);
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		[Token(Token = "0x6004EFF")]
		[Address(RVA = "0x37C760", Offset = "0x37C861", VA = "0x37C760")]
		public Coord ToLocalspace(Vector2 pos, Rect worldRect)
		{
			return default(Coord);
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F00")]
		[Address(RVA = "0x37C850", Offset = "0x37C951", VA = "0x37C850")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC5D0", Offset = "0x1AC6D1")]
		public IEnumerable<Coord> Cells(int cellSize)
		{
			return null;
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		[Token(Token = "0x6004F01")]
		[Address(RVA = "0x37C8F0", Offset = "0x37C9F1", VA = "0x37C8F0")]
		public CoordRect Expand(int n)
		{
			return default(CoordRect);
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		[Token(Token = "0x6004F02")]
		[Address(RVA = "0x37C940", Offset = "0x37CA41", VA = "0x37C940")]
		public CoordRect Approximate(int val)
		{
			return default(CoordRect);
		}

		// Token: 0x0400BEC3 RID: 48835
		[Token(Token = "0x4008EA9")]
		[FieldOffset(Offset = "0x0")]
		public Coord offset;

		// Token: 0x0400BEC4 RID: 48836
		[Token(Token = "0x4008EAA")]
		[FieldOffset(Offset = "0x8")]
		public Coord size;

		// Token: 0x02000E35 RID: 3637
		[Token(Token = "0x2001456")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1598F0", Offset = "0x1599F1")]
		private sealed class <Cells>d__39 : IEnumerable<Coord>, IEnumerable, IEnumerator<Coord>, IEnumerator, IDisposable
		{
			// Token: 0x06005F8A RID: 24458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B36")]
			[Address(RVA = "0x2C1DC70", Offset = "0x2C1DD71", VA = "0x2C1DC70")]
			[DebuggerHidden]
			public <Cells>d__39(int <>1__state)
			{
			}

			// Token: 0x06005F8B RID: 24459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B37")]
			[Address(RVA = "0x2C1DD80", Offset = "0x2C1DE81", VA = "0x2C1DD80", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005F8C RID: 24460 RVA: 0x00020010 File Offset: 0x0001E210
			[Token(Token = "0x6007B38")]
			[Address(RVA = "0x2C1DD90", Offset = "0x2C1DE91", VA = "0x2C1DD90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x06005F8D RID: 24461 RVA: 0x00020028 File Offset: 0x0001E228
			[Token(Token = "0x17000E77")]
			private Coord Current
			{
				[Token(Token = "0x6007B39")]
				[Address(RVA = "0x2C1DEA0", Offset = "0x2C1DFA1", VA = "0x2C1DEA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Coord);
				}
			}

			// Token: 0x06005F8E RID: 24462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B3A")]
			[Address(RVA = "0x2C1DEB0", Offset = "0x2C1DFB1", VA = "0x2C1DEB0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x06005F8F RID: 24463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E78")]
			private object Current
			{
				[Token(Token = "0x6007B3B")]
				[Address(RVA = "0x2C1DF10", Offset = "0x2C1E011", VA = "0x2C1DF10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F90 RID: 24464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B3C")]
			[Address(RVA = "0x2C1DF80", Offset = "0x2C1E081", VA = "0x2C1DF80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Coord> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005F91 RID: 24465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B3D")]
			[Address(RVA = "0x2C1E040", Offset = "0x2C1E141", VA = "0x2C1E040", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BEC5 RID: 48837
			[Token(Token = "0x401BC26")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BEC6 RID: 48838
			[Token(Token = "0x401BC27")]
			[FieldOffset(Offset = "0x14")]
			private Coord <>2__current;

			// Token: 0x0400BEC7 RID: 48839
			[Token(Token = "0x401BC28")]
			[FieldOffset(Offset = "0x1C")]
			private int <>l__initialThreadId;

			// Token: 0x0400BEC8 RID: 48840
			[Token(Token = "0x401BC29")]
			[FieldOffset(Offset = "0x20")]
			public CoordRect <>4__this;

			// Token: 0x0400BEC9 RID: 48841
			[Token(Token = "0x401BC2A")]
			[FieldOffset(Offset = "0x30")]
			public CoordRect <>3__<>4__this;

			// Token: 0x0400BECA RID: 48842
			[Token(Token = "0x401BC2B")]
			[FieldOffset(Offset = "0x40")]
			private int cellSize;

			// Token: 0x0400BECB RID: 48843
			[Token(Token = "0x401BC2C")]
			[FieldOffset(Offset = "0x44")]
			public int <>3__cellSize;

			// Token: 0x0400BECC RID: 48844
			[Token(Token = "0x401BC2D")]
			[FieldOffset(Offset = "0x48")]
			private Coord <min>5__2;

			// Token: 0x0400BECD RID: 48845
			[Token(Token = "0x401BC2E")]
			[FieldOffset(Offset = "0x50")]
			private Coord <max>5__3;

			// Token: 0x0400BECE RID: 48846
			[Token(Token = "0x401BC2F")]
			[FieldOffset(Offset = "0x58")]
			private int <x>5__4;

			// Token: 0x0400BECF RID: 48847
			[Token(Token = "0x401BC30")]
			[FieldOffset(Offset = "0x5C")]
			private int <z>5__5;
		}
	}
}
