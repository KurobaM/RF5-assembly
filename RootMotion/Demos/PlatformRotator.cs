using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CDF RID: 3295
	[Token(Token = "0x2000879")]
	public class PlatformRotator : MonoBehaviour
	{
		// Token: 0x06005455 RID: 21589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004647")]
		[Address(RVA = "0x2860980", Offset = "0x2860A81", VA = "0x2860980")]
		private void Start()
		{
		}

		// Token: 0x06005456 RID: 21590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004648")]
		[Address(RVA = "0x2860B80", Offset = "0x2860C81", VA = "0x2860B80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005457 RID: 21591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004649")]
		[Address(RVA = "0x2860B00", Offset = "0x2860C01", VA = "0x2860B00")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A9820", Offset = "0x1A9921")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464A")]
		[Address(RVA = "0x2860DE0", Offset = "0x2860EE1", VA = "0x2860DE0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464B")]
		[Address(RVA = "0x2860EC0", Offset = "0x2860FC1", VA = "0x2860EC0")]
		private void OnCollisionExit(Collision collision)
		{
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600464C")]
		[Address(RVA = "0x2860FA0", Offset = "0x28610A1", VA = "0x2860FA0")]
		public PlatformRotator()
		{
		}

		// Token: 0x0400B381 RID: 45953
		[Token(Token = "0x40086C4")]
		[FieldOffset(Offset = "0x18")]
		public float maxAngle;

		// Token: 0x0400B382 RID: 45954
		[Token(Token = "0x40086C5")]
		[FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		// Token: 0x0400B383 RID: 45955
		[Token(Token = "0x40086C6")]
		[FieldOffset(Offset = "0x20")]
		public float random;

		// Token: 0x0400B384 RID: 45956
		[Token(Token = "0x40086C7")]
		[FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		// Token: 0x0400B385 RID: 45957
		[Token(Token = "0x40086C8")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		// Token: 0x0400B386 RID: 45958
		[Token(Token = "0x40086C9")]
		[FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		// Token: 0x0400B387 RID: 45959
		[Token(Token = "0x40086CA")]
		[FieldOffset(Offset = "0x38")]
		public int characterLayer;

		// Token: 0x0400B388 RID: 45960
		[Token(Token = "0x40086CB")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		// Token: 0x0400B389 RID: 45961
		[Token(Token = "0x40086CC")]
		[FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		// Token: 0x0400B38A RID: 45962
		[Token(Token = "0x40086CD")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		// Token: 0x0400B38B RID: 45963
		[Token(Token = "0x40086CE")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		// Token: 0x0400B38C RID: 45964
		[Token(Token = "0x40086CF")]
		[FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		// Token: 0x02000CE0 RID: 3296
		[Token(Token = "0x20013DF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159760", Offset = "0x159861")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600545B RID: 21595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D8")]
			[Address(RVA = "0x2860DB0", Offset = "0x2860EB1", VA = "0x2860DB0")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			// Token: 0x0600545C RID: 21596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078D9")]
			[Address(RVA = "0x2860FD0", Offset = "0x28610D1", VA = "0x2860FD0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600545D RID: 21597 RVA: 0x0001BCA8 File Offset: 0x00019EA8
			[Token(Token = "0x60078DA")]
			[Address(RVA = "0x2860FE0", Offset = "0x28610E1", VA = "0x2860FE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000AD9 RID: 2777
			// (get) Token: 0x0600545E RID: 21598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DFB")]
			private object Current
			{
				[Token(Token = "0x60078DB")]
				[Address(RVA = "0x2861130", Offset = "0x2861231", VA = "0x2861130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600545F RID: 21599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078DC")]
			[Address(RVA = "0x2861140", Offset = "0x2861241", VA = "0x2861140", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000ADA RID: 2778
			// (get) Token: 0x06005460 RID: 21600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DFC")]
			private object Current
			{
				[Token(Token = "0x60078DD")]
				[Address(RVA = "0x28611A0", Offset = "0x28612A1", VA = "0x28611A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B38D RID: 45965
			[Token(Token = "0x401B901")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B38E RID: 45966
			[Token(Token = "0x401B902")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B38F RID: 45967
			[Token(Token = "0x401B903")]
			[FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;
		}
	}
}
