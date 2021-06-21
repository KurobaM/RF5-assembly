using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02001609 RID: 5641
	[Token(Token = "0x2000F7E")]
	public static class DOTweenModulePhysics2D
	{
		// Token: 0x0600807B RID: 32891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A94")]
		[Address(RVA = "0x1D95050", Offset = "0x1D95151", VA = "0x1D95050")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A95")]
		[Address(RVA = "0x1D951E0", Offset = "0x1D952E1", VA = "0x1D951E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A96")]
		[Address(RVA = "0x1D95380", Offset = "0x1D95481", VA = "0x1D95380")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A97")]
		[Address(RVA = "0x1D95520", Offset = "0x1D95621", VA = "0x1D95520")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		// Token: 0x0600807F RID: 32895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A98")]
		[Address(RVA = "0x1D95680", Offset = "0x1D95781", VA = "0x1D95680")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0200160A RID: 5642
		[Token(Token = "0x20015DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AAE0", Offset = "0x15ABE1")]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x06008080 RID: 32896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FF4")]
			[Address(RVA = "0x1D951D0", Offset = "0x1D952D1", VA = "0x1D951D0")]
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x06008081 RID: 32897 RVA: 0x0002E338 File Offset: 0x0002C538
			[Token(Token = "0x6007FF5")]
			[Address(RVA = "0x1D95A40", Offset = "0x1D95B41", VA = "0x1D95A40")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}

			// Token: 0x0401C1BF RID: 115135
			[Token(Token = "0x401C3A1")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;
		}

		// Token: 0x0200160B RID: 5643
		[Token(Token = "0x20015DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AAF0", Offset = "0x15ABF1")]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06008082 RID: 32898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FF6")]
			[Address(RVA = "0x1D95370", Offset = "0x1D95471", VA = "0x1D95370")]
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06008083 RID: 32899 RVA: 0x0002E350 File Offset: 0x0002C550
			[Token(Token = "0x6007FF7")]
			[Address(RVA = "0x1D95A60", Offset = "0x1D95B61", VA = "0x1D95A60")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}

			// Token: 0x0401C1C0 RID: 115136
			[Token(Token = "0x401C3A2")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;
		}

		// Token: 0x0200160C RID: 5644
		[Token(Token = "0x20015DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AB00", Offset = "0x15AC01")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06008084 RID: 32900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FF8")]
			[Address(RVA = "0x1D95510", Offset = "0x1D95611", VA = "0x1D95510")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06008085 RID: 32901 RVA: 0x0002E368 File Offset: 0x0002C568
			[Token(Token = "0x6007FF9")]
			[Address(RVA = "0x1D95A80", Offset = "0x1D95B81", VA = "0x1D95A80")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}

			// Token: 0x0401C1C1 RID: 115137
			[Token(Token = "0x401C3A3")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;
		}

		// Token: 0x0200160D RID: 5645
		[Token(Token = "0x20015DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AB10", Offset = "0x15AC11")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06008086 RID: 32902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FFA")]
			[Address(RVA = "0x1D95670", Offset = "0x1D95771", VA = "0x1D95670")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06008087 RID: 32903 RVA: 0x0002E380 File Offset: 0x0002C580
			[Token(Token = "0x6007FFB")]
			[Address(RVA = "0x1D95AA0", Offset = "0x1D95BA1", VA = "0x1D95AA0")]
			internal float <DORotate>b__0()
			{
				return 0f;
			}

			// Token: 0x0401C1C2 RID: 115138
			[Token(Token = "0x401C3A4")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;
		}

		// Token: 0x0200160E RID: 5646
		[Token(Token = "0x20015E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AB20", Offset = "0x15AC21")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06008088 RID: 32904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FFC")]
			[Address(RVA = "0x1D95A30", Offset = "0x1D95B31", VA = "0x1D95A30")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06008089 RID: 32905 RVA: 0x0002E398 File Offset: 0x0002C598
			[Token(Token = "0x6007FFD")]
			[Address(RVA = "0x1D95AC0", Offset = "0x1D95BC1", VA = "0x1D95AC0")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			// Token: 0x0600808A RID: 32906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FFE")]
			[Address(RVA = "0x1D95AE0", Offset = "0x1D95BE1", VA = "0x1D95AE0")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			// Token: 0x0600808B RID: 32907 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FFF")]
			[Address(RVA = "0x1D95B00", Offset = "0x1D95C01", VA = "0x1D95B00")]
			internal void <DOJump>b__2()
			{
			}

			// Token: 0x0600808C RID: 32908 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
			[Token(Token = "0x6008000")]
			[Address(RVA = "0x1D95B40", Offset = "0x1D95C41", VA = "0x1D95B40")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			// Token: 0x0600808D RID: 32909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008001")]
			[Address(RVA = "0x1D95B60", Offset = "0x1D95C61", VA = "0x1D95B60")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			// Token: 0x0600808E RID: 32910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008002")]
			[Address(RVA = "0x1D95B80", Offset = "0x1D95C81", VA = "0x1D95B80")]
			internal void <DOJump>b__5()
			{
			}

			// Token: 0x0401C1C3 RID: 115139
			[Token(Token = "0x401C3A5")]
			[FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			// Token: 0x0401C1C4 RID: 115140
			[Token(Token = "0x401C3A6")]
			[FieldOffset(Offset = "0x18")]
			public float startPosY;

			// Token: 0x0401C1C5 RID: 115141
			[Token(Token = "0x401C3A7")]
			[FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			// Token: 0x0401C1C6 RID: 115142
			[Token(Token = "0x401C3A8")]
			[FieldOffset(Offset = "0x20")]
			public float offsetY;

			// Token: 0x0401C1C7 RID: 115143
			[Token(Token = "0x401C3A9")]
			[FieldOffset(Offset = "0x28")]
			public Sequence s;

			// Token: 0x0401C1C8 RID: 115144
			[Token(Token = "0x401C3AA")]
			[FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			// Token: 0x0401C1C9 RID: 115145
			[Token(Token = "0x401C3AB")]
			[FieldOffset(Offset = "0x38")]
			public Tween yTween;
		}
	}
}
