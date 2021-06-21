using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E2E RID: 3630
	[Token(Token = "0x2000949")]
	[Serializable]
	public struct Coord
	{
		// Token: 0x06005F14 RID: 24340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EB9")]
		[Address(RVA = "0x2E1F60", Offset = "0x2E2061", VA = "0x2E1F60")]
		public Coord(int x, int z)
		{
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0001FA40 File Offset: 0x0001DC40
		[Token(Token = "0x6004EBA")]
		[Address(RVA = "0x22BC8F0", Offset = "0x22BC9F1", VA = "0x22BC8F0")]
		public static bool operator >(Coord c1, Coord c2)
		{
			return default(bool);
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x0001FA58 File Offset: 0x0001DC58
		[Token(Token = "0x6004EBB")]
		[Address(RVA = "0x22BC910", Offset = "0x22BCA11", VA = "0x22BC910")]
		public static bool operator <(Coord c1, Coord c2)
		{
			return default(bool);
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x0001FA70 File Offset: 0x0001DC70
		[Token(Token = "0x6004EBC")]
		[Address(RVA = "0x22BC930", Offset = "0x22BCA31", VA = "0x22BC930")]
		public static bool operator ==(Coord c1, Coord c2)
		{
			return default(bool);
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x22BC950", Offset = "0x22BCA51", VA = "0x22BC950")]
		public static bool operator !=(Coord c1, Coord c2)
		{
			return default(bool);
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x22BC970", Offset = "0x22BCA71", VA = "0x22BC970")]
		public static Coord operator +(Coord c, int s)
		{
			return default(Coord);
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		[Token(Token = "0x6004EBF")]
		[Address(RVA = "0x22BC990", Offset = "0x22BCA91", VA = "0x22BC990")]
		public static Coord operator +(Coord c1, Coord c2)
		{
			return default(Coord);
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		[Token(Token = "0x6004EC0")]
		[Address(RVA = "0x22BC9B0", Offset = "0x22BCAB1", VA = "0x22BC9B0")]
		public static Coord operator -(Coord c, int s)
		{
			return default(Coord);
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[Token(Token = "0x6004EC1")]
		[Address(RVA = "0x22BC9D0", Offset = "0x22BCAD1", VA = "0x22BC9D0")]
		public static Coord operator -(Coord c1, Coord c2)
		{
			return default(Coord);
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x0001FB00 File Offset: 0x0001DD00
		[Token(Token = "0x6004EC2")]
		[Address(RVA = "0x22BC9F0", Offset = "0x22BCAF1", VA = "0x22BC9F0")]
		public static Coord operator *(Coord c, int s)
		{
			return default(Coord);
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x0001FB18 File Offset: 0x0001DD18
		[Token(Token = "0x6004EC3")]
		[Address(RVA = "0x22BCA10", Offset = "0x22BCB11", VA = "0x22BCA10")]
		public static Vector2 operator *(Coord c, Vector2 s)
		{
			return default(Vector2);
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x0001FB30 File Offset: 0x0001DD30
		[Token(Token = "0x6004EC4")]
		[Address(RVA = "0x22BCA50", Offset = "0x22BCB51", VA = "0x22BCA50")]
		public static Vector3 operator *(Coord c, Vector3 s)
		{
			return default(Vector3);
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x0001FB48 File Offset: 0x0001DD48
		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x22BCAA0", Offset = "0x22BCBA1", VA = "0x22BCAA0")]
		public static Coord operator *(Coord c, float s)
		{
			return default(Coord);
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x0001FB60 File Offset: 0x0001DD60
		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x22BCAD0", Offset = "0x22BCBD1", VA = "0x22BCAD0")]
		public static Coord operator /(Coord c, int s)
		{
			return default(Coord);
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x0001FB78 File Offset: 0x0001DD78
		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x22BCAF0", Offset = "0x22BCBF1", VA = "0x22BCAF0")]
		public static Coord operator /(Coord c, float s)
		{
			return default(Coord);
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x0001FB90 File Offset: 0x0001DD90
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x2E1F70", Offset = "0x2E2071", VA = "0x2E1F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x2E1FF0", Offset = "0x2E20F1", VA = "0x2E1FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x06005F25 RID: 24357 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		[Token(Token = "0x170009BB")]
		public int Minimal
		{
			[Token(Token = "0x6004ECA")]
			[Address(RVA = "0x2E2010", Offset = "0x2E2111", VA = "0x2E2010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06005F26 RID: 24358 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[Token(Token = "0x170009BC")]
		public int SqrMagnitude
		{
			[Token(Token = "0x6004ECB")]
			[Address(RVA = "0x2E2080", Offset = "0x2E2181", VA = "0x2E2080")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06005F27 RID: 24359 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		[Token(Token = "0x170009BD")]
		public Vector3 vector3
		{
			[Token(Token = "0x6004ECC")]
			[Address(RVA = "0x2E2090", Offset = "0x2E2191", VA = "0x2E2090")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06005F28 RID: 24360 RVA: 0x0001FC08 File Offset: 0x0001DE08
		[Token(Token = "0x170009BE")]
		public static Coord zero
		{
			[Token(Token = "0x6004ECD")]
			[Address(RVA = "0x22BCC90", Offset = "0x22BCD91", VA = "0x22BCC90")]
			get
			{
				return default(Coord);
			}
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECE")]
		[Address(RVA = "0x2E20E0", Offset = "0x2E21E1", VA = "0x2E20E0")]
		public void Round(int val, bool ceil = false)
		{
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECF")]
		[Address(RVA = "0x2E20F0", Offset = "0x2E21F1", VA = "0x2E20F0")]
		public void Round(Coord c, bool ceil = false)
		{
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED0")]
		[Address(RVA = "0x2E2100", Offset = "0x2E2201", VA = "0x2E2100")]
		public void ClampPositive()
		{
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED1")]
		[Address(RVA = "0x2E2190", Offset = "0x2E2291", VA = "0x2E2190")]
		public void ClampByRect(CoordRect rect)
		{
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x0001FC20 File Offset: 0x0001DE20
		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x22BD000", Offset = "0x22BD101", VA = "0x22BD000")]
		public static Coord Min(Coord c1, Coord c2)
		{
			return default(Coord);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0001FC38 File Offset: 0x0001DE38
		[Token(Token = "0x6004ED3")]
		[Address(RVA = "0x22BD0B0", Offset = "0x22BD1B1", VA = "0x22BD0B0")]
		public static Coord Max(Coord c1, Coord c2)
		{
			return default(Coord);
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x0001FC50 File Offset: 0x0001DE50
		[Token(Token = "0x6004ED4")]
		[Address(RVA = "0x22BD160", Offset = "0x22BD261", VA = "0x22BD160")]
		public static float Distance(Coord c1, Coord c2)
		{
			return 0f;
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x0001FC68 File Offset: 0x0001DE68
		[Token(Token = "0x6004ED5")]
		[Address(RVA = "0x22BD210", Offset = "0x22BD311", VA = "0x22BD210")]
		public static float Distance(Coord c1, int x, int z)
		{
			return 0f;
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x2E2200", Offset = "0x2E2301", VA = "0x2E2200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x2E2210", Offset = "0x2E2311", VA = "0x2E2210")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC3A0", Offset = "0x1AC4A1")]
		public IEnumerable<Coord> DistanceStep(int i, int dist)
		{
			return null;
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED8")]
		[Address(RVA = "0x2E22A0", Offset = "0x2E23A1", VA = "0x2E22A0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC410", Offset = "0x1AC511")]
		public IEnumerable<Coord> DistancePerimeter(int dist)
		{
			return null;
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ED9")]
		[Address(RVA = "0x2E2330", Offset = "0x2E2431", VA = "0x2E2330")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC480", Offset = "0x1AC581")]
		public IEnumerable<Coord> DistanceArea(int maxDist)
		{
			return null;
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDA")]
		[Address(RVA = "0x2E23C0", Offset = "0x2E24C1", VA = "0x2E23C0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC4F0", Offset = "0x1AC5F1")]
		public IEnumerable<Coord> DistanceArea(CoordRect rect)
		{
			return null;
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EDB")]
		[Address(RVA = "0x22BD730", Offset = "0x22BD831", VA = "0x22BD730")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1AC560", Offset = "0x1AC661")]
		public static IEnumerable<Coord> MultiDistanceArea(Coord[] coords, int maxDist)
		{
			return null;
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x0001FC80 File Offset: 0x0001DE80
		[Token(Token = "0x6004EDC")]
		[Address(RVA = "0x2E2450", Offset = "0x2E2551", VA = "0x2E2450")]
		public Vector3 ToVector3(float cellSize)
		{
			return default(Vector3);
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x0001FC98 File Offset: 0x0001DE98
		[Token(Token = "0x6004EDD")]
		[Address(RVA = "0x2E24A0", Offset = "0x2E25A1", VA = "0x2E24A0")]
		public Vector2 ToVector2(float cellSize)
		{
			return default(Vector2);
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		[Token(Token = "0x6004EDE")]
		[Address(RVA = "0x2E24F0", Offset = "0x2E25F1", VA = "0x2E24F0")]
		public Rect ToRect(float cellSize)
		{
			return default(Rect);
		}

		// Token: 0x0400BE91 RID: 48785
		[Token(Token = "0x4008EA7")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0400BE92 RID: 48786
		[Token(Token = "0x4008EA8")]
		[FieldOffset(Offset = "0x4")]
		public int z;

		// Token: 0x02000E2F RID: 3631
		[Token(Token = "0x2001451")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1598A0", Offset = "0x1599A1")]
		private sealed class <DistanceStep>d__36 : IEnumerable<Coord>, IEnumerable, IEnumerator<Coord>, IEnumerator, IDisposable
		{
			// Token: 0x06005F3A RID: 24378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B0A")]
			[Address(RVA = "0x2C1C010", Offset = "0x2C1C111", VA = "0x2C1C010")]
			[DebuggerHidden]
			public <DistanceStep>d__36(int <>1__state)
			{
			}

			// Token: 0x06005F3B RID: 24379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B0B")]
			[Address(RVA = "0x2C1C050", Offset = "0x2C1C151", VA = "0x2C1C050", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005F3C RID: 24380 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
			[Token(Token = "0x6007B0C")]
			[Address(RVA = "0x2C1C060", Offset = "0x2C1C161", VA = "0x2C1C060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x06005F3D RID: 24381 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
			[Token(Token = "0x17000E6D")]
			private Coord Current
			{
				[Token(Token = "0x6007B0D")]
				[Address(RVA = "0x2C1C2D0", Offset = "0x2C1C3D1", VA = "0x2C1C2D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Coord);
				}
			}

			// Token: 0x06005F3E RID: 24382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B0E")]
			[Address(RVA = "0x2C1C2E0", Offset = "0x2C1C3E1", VA = "0x2C1C2E0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x06005F3F RID: 24383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E6E")]
			private object Current
			{
				[Token(Token = "0x6007B0F")]
				[Address(RVA = "0x2C1C340", Offset = "0x2C1C441", VA = "0x2C1C340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F40 RID: 24384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B10")]
			[Address(RVA = "0x2C1C3B0", Offset = "0x2C1C4B1", VA = "0x2C1C3B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Coord> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005F41 RID: 24385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B11")]
			[Address(RVA = "0x2C1C470", Offset = "0x2C1C571", VA = "0x2C1C470", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BE93 RID: 48787
			[Token(Token = "0x401BBF6")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BE94 RID: 48788
			[Token(Token = "0x401BBF7")]
			[FieldOffset(Offset = "0x14")]
			private Coord <>2__current;

			// Token: 0x0400BE95 RID: 48789
			[Token(Token = "0x401BBF8")]
			[FieldOffset(Offset = "0x1C")]
			private int <>l__initialThreadId;

			// Token: 0x0400BE96 RID: 48790
			[Token(Token = "0x401BBF9")]
			[FieldOffset(Offset = "0x20")]
			public Coord <>4__this;

			// Token: 0x0400BE97 RID: 48791
			[Token(Token = "0x401BBFA")]
			[FieldOffset(Offset = "0x28")]
			public Coord <>3__<>4__this;

			// Token: 0x0400BE98 RID: 48792
			[Token(Token = "0x401BBFB")]
			[FieldOffset(Offset = "0x30")]
			private int i;

			// Token: 0x0400BE99 RID: 48793
			[Token(Token = "0x401BBFC")]
			[FieldOffset(Offset = "0x34")]
			public int <>3__i;

			// Token: 0x0400BE9A RID: 48794
			[Token(Token = "0x401BBFD")]
			[FieldOffset(Offset = "0x38")]
			private int dist;

			// Token: 0x0400BE9B RID: 48795
			[Token(Token = "0x401BBFE")]
			[FieldOffset(Offset = "0x3C")]
			public int <>3__dist;
		}

		// Token: 0x02000E30 RID: 3632
		[Token(Token = "0x2001452")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1598B0", Offset = "0x1599B1")]
		private sealed class <DistancePerimeter>d__37 : IEnumerable<Coord>, IEnumerable, IEnumerator<Coord>, IEnumerator, IDisposable
		{
			// Token: 0x06005F42 RID: 24386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B12")]
			[Address(RVA = "0x2C1B890", Offset = "0x2C1B991", VA = "0x2C1B890")]
			[DebuggerHidden]
			public <DistancePerimeter>d__37(int <>1__state)
			{
			}

			// Token: 0x06005F43 RID: 24387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B13")]
			[Address(RVA = "0x2C1B8D0", Offset = "0x2C1B9D1", VA = "0x2C1B8D0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005F44 RID: 24388 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
			[Token(Token = "0x6007B14")]
			[Address(RVA = "0x2C1BA60", Offset = "0x2C1BB61", VA = "0x2C1BA60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005F45 RID: 24389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B15")]
			[Address(RVA = "0x2C1B9A0", Offset = "0x2C1BAA1", VA = "0x2C1B9A0")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x06005F46 RID: 24390 RVA: 0x0001FD10 File Offset: 0x0001DF10
			[Token(Token = "0x17000E6F")]
			private Coord Current
			{
				[Token(Token = "0x6007B16")]
				[Address(RVA = "0x2C1BE60", Offset = "0x2C1BF61", VA = "0x2C1BE60", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Coord);
				}
			}

			// Token: 0x06005F47 RID: 24391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B17")]
			[Address(RVA = "0x2C1BE70", Offset = "0x2C1BF71", VA = "0x2C1BE70", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x06005F48 RID: 24392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E70")]
			private object Current
			{
				[Token(Token = "0x6007B18")]
				[Address(RVA = "0x2C1BED0", Offset = "0x2C1BFD1", VA = "0x2C1BED0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F49 RID: 24393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B19")]
			[Address(RVA = "0x2C1BF40", Offset = "0x2C1C041", VA = "0x2C1BF40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Coord> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005F4A RID: 24394 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B1A")]
			[Address(RVA = "0x2C1C000", Offset = "0x2C1C101", VA = "0x2C1C000", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BE9C RID: 48796
			[Token(Token = "0x401BBFF")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BE9D RID: 48797
			[Token(Token = "0x401BC00")]
			[FieldOffset(Offset = "0x14")]
			private Coord <>2__current;

			// Token: 0x0400BE9E RID: 48798
			[Token(Token = "0x401BC01")]
			[FieldOffset(Offset = "0x1C")]
			private int <>l__initialThreadId;

			// Token: 0x0400BE9F RID: 48799
			[Token(Token = "0x401BC02")]
			[FieldOffset(Offset = "0x20")]
			public Coord <>4__this;

			// Token: 0x0400BEA0 RID: 48800
			[Token(Token = "0x401BC03")]
			[FieldOffset(Offset = "0x28")]
			public Coord <>3__<>4__this;

			// Token: 0x0400BEA1 RID: 48801
			[Token(Token = "0x401BC04")]
			[FieldOffset(Offset = "0x30")]
			private int dist;

			// Token: 0x0400BEA2 RID: 48802
			[Token(Token = "0x401BC05")]
			[FieldOffset(Offset = "0x34")]
			public int <>3__dist;

			// Token: 0x0400BEA3 RID: 48803
			[Token(Token = "0x401BC06")]
			[FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			// Token: 0x0400BEA4 RID: 48804
			[Token(Token = "0x401BC07")]
			[FieldOffset(Offset = "0x40")]
			private IEnumerator<Coord> <>7__wrap2;
		}

		// Token: 0x02000E31 RID: 3633
		[Token(Token = "0x2001453")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1598C0", Offset = "0x1599C1")]
		private sealed class <DistanceArea>d__38 : IEnumerable<Coord>, IEnumerable, IEnumerator<Coord>, IEnumerator, IDisposable
		{
			// Token: 0x06005F4B RID: 24395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B1B")]
			[Address(RVA = "0x2C1A6F0", Offset = "0x2C1A7F1", VA = "0x2C1A6F0")]
			[DebuggerHidden]
			public <DistanceArea>d__38(int <>1__state)
			{
			}

			// Token: 0x06005F4C RID: 24396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B1C")]
			[Address(RVA = "0x2C1A730", Offset = "0x2C1A831", VA = "0x2C1A730", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005F4D RID: 24397 RVA: 0x0001FD28 File Offset: 0x0001DF28
			[Token(Token = "0x6007B1D")]
			[Address(RVA = "0x2C1A8C0", Offset = "0x2C1A9C1", VA = "0x2C1A8C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005F4E RID: 24398 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B1E")]
			[Address(RVA = "0x2C1A800", Offset = "0x2C1A901", VA = "0x2C1A800")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000C75 RID: 3189
			// (get) Token: 0x06005F4F RID: 24399 RVA: 0x0001FD40 File Offset: 0x0001DF40
			[Token(Token = "0x17000E71")]
			private Coord Current
			{
				[Token(Token = "0x6007B1F")]
				[Address(RVA = "0x2C1ACE0", Offset = "0x2C1ADE1", VA = "0x2C1ACE0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Coord);
				}
			}

			// Token: 0x06005F50 RID: 24400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B20")]
			[Address(RVA = "0x2C1ACF0", Offset = "0x2C1ADF1", VA = "0x2C1ACF0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C76 RID: 3190
			// (get) Token: 0x06005F51 RID: 24401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E72")]
			private object Current
			{
				[Token(Token = "0x6007B21")]
				[Address(RVA = "0x2C1AD50", Offset = "0x2C1AE51", VA = "0x2C1AD50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F52 RID: 24402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B22")]
			[Address(RVA = "0x2C1ADC0", Offset = "0x2C1AEC1", VA = "0x2C1ADC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Coord> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005F53 RID: 24403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B23")]
			[Address(RVA = "0x2C1AE80", Offset = "0x2C1AF81", VA = "0x2C1AE80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BEA5 RID: 48805
			[Token(Token = "0x401BC08")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BEA6 RID: 48806
			[Token(Token = "0x401BC09")]
			[FieldOffset(Offset = "0x14")]
			private Coord <>2__current;

			// Token: 0x0400BEA7 RID: 48807
			[Token(Token = "0x401BC0A")]
			[FieldOffset(Offset = "0x1C")]
			private int <>l__initialThreadId;

			// Token: 0x0400BEA8 RID: 48808
			[Token(Token = "0x401BC0B")]
			[FieldOffset(Offset = "0x20")]
			public Coord <>4__this;

			// Token: 0x0400BEA9 RID: 48809
			[Token(Token = "0x401BC0C")]
			[FieldOffset(Offset = "0x28")]
			public Coord <>3__<>4__this;

			// Token: 0x0400BEAA RID: 48810
			[Token(Token = "0x401BC0D")]
			[FieldOffset(Offset = "0x30")]
			private int maxDist;

			// Token: 0x0400BEAB RID: 48811
			[Token(Token = "0x401BC0E")]
			[FieldOffset(Offset = "0x34")]
			public int <>3__maxDist;

			// Token: 0x0400BEAC RID: 48812
			[Token(Token = "0x401BC0F")]
			[FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			// Token: 0x0400BEAD RID: 48813
			[Token(Token = "0x401BC10")]
			[FieldOffset(Offset = "0x40")]
			private IEnumerator<Coord> <>7__wrap2;
		}

		// Token: 0x02000E32 RID: 3634
		[Token(Token = "0x2001454")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1598D0", Offset = "0x1599D1")]
		private sealed class <DistanceArea>d__39 : IEnumerable<Coord>, IEnumerable, IEnumerator<Coord>, IEnumerator, IDisposable
		{
			// Token: 0x06005F54 RID: 24404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B24")]
			[Address(RVA = "0x2C1AE90", Offset = "0x2C1AF91", VA = "0x2C1AE90")]
			[DebuggerHidden]
			public <DistanceArea>d__39(int <>1__state)
			{
			}

			// Token: 0x06005F55 RID: 24405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B25")]
			[Address(RVA = "0x2C1AED0", Offset = "0x2C1AFD1", VA = "0x2C1AED0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005F56 RID: 24406 RVA: 0x0001FD58 File Offset: 0x0001DF58
			[Token(Token = "0x6007B26")]
			[Address(RVA = "0x2C1B060", Offset = "0x2C1B161", VA = "0x2C1B060", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005F57 RID: 24407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B27")]
			[Address(RVA = "0x2C1AFA0", Offset = "0x2C1B0A1", VA = "0x2C1AFA0")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000C77 RID: 3191
			// (get) Token: 0x06005F58 RID: 24408 RVA: 0x0001FD70 File Offset: 0x0001DF70
			[Token(Token = "0x17000E73")]
			private Coord Current
			{
				[Token(Token = "0x6007B28")]
				[Address(RVA = "0x2C1B6E0", Offset = "0x2C1B7E1", VA = "0x2C1B6E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Coord);
				}
			}

			// Token: 0x06005F59 RID: 24409 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B29")]
			[Address(RVA = "0x2C1B6F0", Offset = "0x2C1B7F1", VA = "0x2C1B6F0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C78 RID: 3192
			// (get) Token: 0x06005F5A RID: 24410 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E74")]
			private object Current
			{
				[Token(Token = "0x6007B2A")]
				[Address(RVA = "0x2C1B750", Offset = "0x2C1B851", VA = "0x2C1B750", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F5B RID: 24411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B2B")]
			[Address(RVA = "0x2C1B7C0", Offset = "0x2C1B8C1", VA = "0x2C1B7C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Coord> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005F5C RID: 24412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B2C")]
			[Address(RVA = "0x2C1B880", Offset = "0x2C1B981", VA = "0x2C1B880", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BEAE RID: 48814
			[Token(Token = "0x401BC11")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BEAF RID: 48815
			[Token(Token = "0x401BC12")]
			[FieldOffset(Offset = "0x14")]
			private Coord <>2__current;

			// Token: 0x0400BEB0 RID: 48816
			[Token(Token = "0x401BC13")]
			[FieldOffset(Offset = "0x1C")]
			private int <>l__initialThreadId;

			// Token: 0x0400BEB1 RID: 48817
			[Token(Token = "0x401BC14")]
			[FieldOffset(Offset = "0x20")]
			public Coord <>4__this;

			// Token: 0x0400BEB2 RID: 48818
			[Token(Token = "0x401BC15")]
			[FieldOffset(Offset = "0x28")]
			public Coord <>3__<>4__this;

			// Token: 0x0400BEB3 RID: 48819
			[Token(Token = "0x401BC16")]
			[FieldOffset(Offset = "0x30")]
			private CoordRect rect;

			// Token: 0x0400BEB4 RID: 48820
			[Token(Token = "0x401BC17")]
			[FieldOffset(Offset = "0x40")]
			public CoordRect <>3__rect;

			// Token: 0x0400BEB5 RID: 48821
			[Token(Token = "0x401BC18")]
			[FieldOffset(Offset = "0x50")]
			private int <maxDist>5__2;

			// Token: 0x0400BEB6 RID: 48822
			[Token(Token = "0x401BC19")]
			[FieldOffset(Offset = "0x54")]
			private int <i>5__3;

			// Token: 0x0400BEB7 RID: 48823
			[Token(Token = "0x401BC1A")]
			[FieldOffset(Offset = "0x58")]
			private IEnumerator<Coord> <>7__wrap3;
		}

		// Token: 0x02000E33 RID: 3635
		[Token(Token = "0x2001455")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1598E0", Offset = "0x1599E1")]
		private sealed class <MultiDistanceArea>d__40 : IEnumerable<Coord>, IEnumerable, IEnumerator<Coord>, IEnumerator, IDisposable
		{
			// Token: 0x06005F5D RID: 24413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B2D")]
			[Address(RVA = "0x2C1C480", Offset = "0x2C1C581", VA = "0x2C1C480")]
			[DebuggerHidden]
			public <MultiDistanceArea>d__40(int <>1__state)
			{
			}

			// Token: 0x06005F5E RID: 24414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B2E")]
			[Address(RVA = "0x2C1C4C0", Offset = "0x2C1C5C1", VA = "0x2C1C4C0", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005F5F RID: 24415 RVA: 0x0001FD88 File Offset: 0x0001DF88
			[Token(Token = "0x6007B2F")]
			[Address(RVA = "0x2C1C650", Offset = "0x2C1C751", VA = "0x2C1C650", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06005F60 RID: 24416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B30")]
			[Address(RVA = "0x2C1C590", Offset = "0x2C1C691", VA = "0x2C1C590")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x06005F61 RID: 24417 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
			[Token(Token = "0x17000E75")]
			private Coord Current
			{
				[Token(Token = "0x6007B31")]
				[Address(RVA = "0x2C1CB90", Offset = "0x2C1CC91", VA = "0x2C1CB90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(Coord);
				}
			}

			// Token: 0x06005F62 RID: 24418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007B32")]
			[Address(RVA = "0x2C1CBA0", Offset = "0x2C1CCA1", VA = "0x2C1CBA0", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x06005F63 RID: 24419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E76")]
			private object Current
			{
				[Token(Token = "0x6007B33")]
				[Address(RVA = "0x2C1CC00", Offset = "0x2C1CD01", VA = "0x2C1CC00", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005F64 RID: 24420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B34")]
			[Address(RVA = "0x2C1CC70", Offset = "0x2C1CD71", VA = "0x2C1CC70", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Coord> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005F65 RID: 24421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007B35")]
			[Address(RVA = "0x2C1CD30", Offset = "0x2C1CE31", VA = "0x2C1CD30", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400BEB8 RID: 48824
			[Token(Token = "0x401BC1B")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BEB9 RID: 48825
			[Token(Token = "0x401BC1C")]
			[FieldOffset(Offset = "0x14")]
			private Coord <>2__current;

			// Token: 0x0400BEBA RID: 48826
			[Token(Token = "0x401BC1D")]
			[FieldOffset(Offset = "0x1C")]
			private int <>l__initialThreadId;

			// Token: 0x0400BEBB RID: 48827
			[Token(Token = "0x401BC1E")]
			[FieldOffset(Offset = "0x20")]
			private Coord[] coords;

			// Token: 0x0400BEBC RID: 48828
			[Token(Token = "0x401BC1F")]
			[FieldOffset(Offset = "0x28")]
			public Coord[] <>3__coords;

			// Token: 0x0400BEBD RID: 48829
			[Token(Token = "0x401BC20")]
			[FieldOffset(Offset = "0x30")]
			private int maxDist;

			// Token: 0x0400BEBE RID: 48830
			[Token(Token = "0x401BC21")]
			[FieldOffset(Offset = "0x34")]
			public int <>3__maxDist;

			// Token: 0x0400BEBF RID: 48831
			[Token(Token = "0x401BC22")]
			[FieldOffset(Offset = "0x38")]
			private int <c>5__2;

			// Token: 0x0400BEC0 RID: 48832
			[Token(Token = "0x401BC23")]
			[FieldOffset(Offset = "0x3C")]
			private int <i>5__3;

			// Token: 0x0400BEC1 RID: 48833
			[Token(Token = "0x401BC24")]
			[FieldOffset(Offset = "0x40")]
			private int <c>5__4;

			// Token: 0x0400BEC2 RID: 48834
			[Token(Token = "0x401BC25")]
			[FieldOffset(Offset = "0x48")]
			private IEnumerator<Coord> <>7__wrap4;
		}
	}
}
