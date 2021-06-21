using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace RenderHeads.Media.AVProMovieCapture
{
	// Token: 0x02000DB0 RID: 3504
	[Token(Token = "0x20008EE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1489E0", Offset = "0x148AE1")]
	public class CaptureFromScreen : CaptureBase
	{
		// Token: 0x06005A9E RID: 23198 RVA: 0x0001DC10 File Offset: 0x0001BE10
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x247E7E0", Offset = "0x247E8E1", VA = "0x247E7E0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		// Token: 0x06005A9F RID: 23199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x247E9B0", Offset = "0x247EAB1", VA = "0x247E9B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1ABBB0", Offset = "0x1ABCB1")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		// Token: 0x06005AA0 RID: 23200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD2")]
		[Address(RVA = "0x247EA60", Offset = "0x247EB61", VA = "0x247EA60", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		// Token: 0x06005AA1 RID: 23201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD3")]
		[Address(RVA = "0x247EB00", Offset = "0x247EC01", VA = "0x247EB00")]
		public CaptureFromScreen()
		{
		}

		// Token: 0x02000DB1 RID: 3505
		[Token(Token = "0x200142F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1597F0", Offset = "0x1598F1")]
		private sealed class <FinalRenderCapture>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005AA2 RID: 23202 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A85")]
			[Address(RVA = "0x247EA30", Offset = "0x247EB31", VA = "0x247EA30")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__1(int <>1__state)
			{
			}

			// Token: 0x06005AA3 RID: 23203 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A86")]
			[Address(RVA = "0x247EB70", Offset = "0x247EC71", VA = "0x247EB70", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005AA4 RID: 23204 RVA: 0x0001DC28 File Offset: 0x0001BE28
			[Token(Token = "0x6007A87")]
			[Address(RVA = "0x247EB80", Offset = "0x247EC81", VA = "0x247EB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06005AA5 RID: 23205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E53")]
			private object Current
			{
				[Token(Token = "0x6007A88")]
				[Address(RVA = "0x247ED10", Offset = "0x247EE11", VA = "0x247ED10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AA6 RID: 23206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A89")]
			[Address(RVA = "0x247ED20", Offset = "0x247EE21", VA = "0x247ED20", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000E54")]
			private object Current
			{
				[Token(Token = "0x6007A8A")]
				[Address(RVA = "0x247ED80", Offset = "0x247EE81", VA = "0x247ED80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400B9F6 RID: 47606
			[Token(Token = "0x401BB38")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400B9F7 RID: 47607
			[Token(Token = "0x401BB39")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400B9F8 RID: 47608
			[Token(Token = "0x401BB3A")]
			[FieldOffset(Offset = "0x20")]
			public CaptureFromScreen <>4__this;
		}
	}
}
