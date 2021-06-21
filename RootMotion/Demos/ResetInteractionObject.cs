using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CD5 RID: 3285
	[Token(Token = "0x2000872")]
	public class ResetInteractionObject : MonoBehaviour
	{
		// Token: 0x06005427 RID: 21543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x2861620", Offset = "0x2861721", VA = "0x2861620")]
		private void Start()
		{
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x28616F0", Offset = "0x28617F1", VA = "0x28616F0")]
		private void OnPickUp(Transform t)
		{
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x28617A0", Offset = "0x28618A1", VA = "0x28617A0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A9740", Offset = "0x1A9841")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x2861860", Offset = "0x2861961", VA = "0x2861860")]
		public ResetInteractionObject()
		{
		}

		// Token: 0x0400B350 RID: 45904
		[Token(Token = "0x40086AE")]
		[FieldOffset(Offset = "0x18")]
		public float resetDelay;

		// Token: 0x0400B351 RID: 45905
		[Token(Token = "0x40086AF")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		// Token: 0x0400B352 RID: 45906
		[Token(Token = "0x40086B0")]
		[FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		// Token: 0x0400B353 RID: 45907
		[Token(Token = "0x40086B1")]
		[FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		// Token: 0x0400B354 RID: 45908
		[Token(Token = "0x40086B2")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		// Token: 0x02000CD6 RID: 3286
		[Token(Token = "0x20013DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159740", Offset = "0x159841")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600542B RID: 21547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C3")]
			[Address(RVA = "0x2861830", Offset = "0x2861931", VA = "0x2861830")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			// Token: 0x0600542C RID: 21548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C4")]
			[Address(RVA = "0x2861870", Offset = "0x2861971", VA = "0x2861870", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600542D RID: 21549 RVA: 0x0001BC60 File Offset: 0x00019E60
			[Token(Token = "0x60078C5")]
			[Address(RVA = "0x2861880", Offset = "0x2861981", VA = "0x2861880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000AD5 RID: 2773
			// (get) Token: 0x0600542E RID: 21550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF7")]
			private object Current
			{
				[Token(Token = "0x60078C6")]
				[Address(RVA = "0x2861A50", Offset = "0x2861B51", VA = "0x2861A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600542F RID: 21551 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C7")]
			[Address(RVA = "0x2861A60", Offset = "0x2861B61", VA = "0x2861A60", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000AD6 RID: 2774
			// (get) Token: 0x06005430 RID: 21552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF8")]
			private object Current
			{
				[Token(Token = "0x60078C8")]
				[Address(RVA = "0x2861AC0", Offset = "0x2861BC1", VA = "0x2861AC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B355 RID: 45909
			[Token(Token = "0x401B8E6")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B356 RID: 45910
			[Token(Token = "0x401B8E7")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B357 RID: 45911
			[Token(Token = "0x401B8E8")]
			[FieldOffset(Offset = "0x20")]
			public float resetTime;

			// Token: 0x0400B358 RID: 45912
			[Token(Token = "0x401B8E9")]
			[FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;
		}
	}
}
