using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CD7 RID: 3287
	[Token(Token = "0x2000873")]
	[Attribute(Name = "RequireComponent", RVA = "0x147BF0", Offset = "0x147CF1")]
	public class SoccerDemo : MonoBehaviour
	{
		// Token: 0x06005431 RID: 21553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004632")]
		[Address(RVA = "0x2863170", Offset = "0x2863271", VA = "0x2863170")]
		private void Start()
		{
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004633")]
		[Address(RVA = "0x2863280", Offset = "0x2863381", VA = "0x2863280")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A97B0", Offset = "0x1A98B1")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004634")]
		[Address(RVA = "0x2863330", Offset = "0x2863431", VA = "0x2863330")]
		public SoccerDemo()
		{
		}

		// Token: 0x0400B359 RID: 45913
		[Token(Token = "0x40086B3")]
		[FieldOffset(Offset = "0x18")]
		private Animator animator;

		// Token: 0x0400B35A RID: 45914
		[Token(Token = "0x40086B4")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		// Token: 0x0400B35B RID: 45915
		[Token(Token = "0x40086B5")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		// Token: 0x02000CD8 RID: 3288
		[Token(Token = "0x20013DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159750", Offset = "0x159851")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005434 RID: 21556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C9")]
			[Address(RVA = "0x2863300", Offset = "0x2863401", VA = "0x2863300")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			// Token: 0x06005435 RID: 21557 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078CA")]
			[Address(RVA = "0x2863340", Offset = "0x2863441", VA = "0x2863340", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005436 RID: 21558 RVA: 0x0001BC78 File Offset: 0x00019E78
			[Token(Token = "0x60078CB")]
			[Address(RVA = "0x2863350", Offset = "0x2863451", VA = "0x2863350", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000AD7 RID: 2775
			// (get) Token: 0x06005437 RID: 21559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF9")]
			private object Current
			{
				[Token(Token = "0x60078CC")]
				[Address(RVA = "0x2863490", Offset = "0x2863591", VA = "0x2863490", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005438 RID: 21560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078CD")]
			[Address(RVA = "0x28634A0", Offset = "0x28635A1", VA = "0x28634A0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000AD8 RID: 2776
			// (get) Token: 0x06005439 RID: 21561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DFA")]
			private object Current
			{
				[Token(Token = "0x60078CE")]
				[Address(RVA = "0x2863500", Offset = "0x2863601", VA = "0x2863500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B35C RID: 45916
			[Token(Token = "0x401B8EA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B35D RID: 45917
			[Token(Token = "0x401B8EB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B35E RID: 45918
			[Token(Token = "0x401B8EC")]
			[FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;
		}
	}
}
