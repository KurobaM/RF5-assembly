using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000842 RID: 2114
[Token(Token = "0x200056C")]
public static class DrawArrow
{
	// Token: 0x06003828 RID: 14376 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB8")]
	[Address(RVA = "0x1E01FA0", Offset = "0x1E020A1", VA = "0x1E01FA0")]
	public static void ForGizmo(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}

	// Token: 0x06003829 RID: 14377 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0x1E022E0", Offset = "0x1E023E1", VA = "0x1E022E0")]
	public static void ForGizmo(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}

	// Token: 0x0600382A RID: 14378 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x1E02620", Offset = "0x1E02721", VA = "0x1E02620")]
	public static void ForDebug(Vector3 pos, Vector3 direction, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}

	// Token: 0x0600382B RID: 14379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x1E02980", Offset = "0x1E02A81", VA = "0x1E02980")]
	public static void ForDebug(Vector3 pos, Vector3 direction, Color color, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}

	// Token: 0x0600382C RID: 14380 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x1E02D00", Offset = "0x1E02E01", VA = "0x1E02D00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A5CC0", Offset = "0x1A5DC1")]
	public static IEnumerator DrawCoroutine(float duration, Vector3 pos, Vector3 direction, Color color)
	{
		return null;
	}

	// Token: 0x02000843 RID: 2115
	[Token(Token = "0x2001259")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158CD0", Offset = "0x158DD1")]
	private sealed class <DrawCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600382D RID: 14381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007457")]
		[Address(RVA = "0x1E02DE0", Offset = "0x1E02EE1", VA = "0x1E02DE0")]
		[DebuggerHidden]
		public <DrawCoroutine>d__4(int <>1__state)
		{
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007458")]
		[Address(RVA = "0x1E02E10", Offset = "0x1E02F11", VA = "0x1E02E10", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x6007459")]
		[Address(RVA = "0x1E02E20", Offset = "0x1E02F21", VA = "0x1E02E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D76")]
		private object Current
		{
			[Token(Token = "0x600745A")]
			[Address(RVA = "0x1E02F00", Offset = "0x1E03001", VA = "0x1E02F00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600745B")]
		[Address(RVA = "0x1E02F10", Offset = "0x1E03011", VA = "0x1E02F10", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D77")]
		private object Current
		{
			[Token(Token = "0x600745C")]
			[Address(RVA = "0x1E02F70", Offset = "0x1E03071", VA = "0x1E02F70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04007B3E RID: 31550
		[Token(Token = "0x4019832")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04007B3F RID: 31551
		[Token(Token = "0x4019833")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04007B40 RID: 31552
		[Token(Token = "0x4019834")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 direction;

		// Token: 0x04007B41 RID: 31553
		[Token(Token = "0x4019835")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 pos;

		// Token: 0x04007B42 RID: 31554
		[Token(Token = "0x4019836")]
		[FieldOffset(Offset = "0x38")]
		public Color color;

		// Token: 0x04007B43 RID: 31555
		[Token(Token = "0x4019837")]
		[FieldOffset(Offset = "0x48")]
		public float duration;

		// Token: 0x04007B44 RID: 31556
		[Token(Token = "0x4019838")]
		[FieldOffset(Offset = "0x4C")]
		private float <time>5__2;
	}
}
