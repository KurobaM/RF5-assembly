using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;

// Token: 0x02000335 RID: 821
[Token(Token = "0x2000268")]
public class DLCSteam : DLC
{
	// Token: 0x0600161E RID: 5662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A0")]
	[Address(RVA = "0x1D9DF70", Offset = "0x1D9E071", VA = "0x1D9DF70")]
	public DLCSteam()
	{
	}

	// Token: 0x0600161F RID: 5663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A1")]
	[Address(RVA = "0x1D9DFF0", Offset = "0x1D9E0F1", VA = "0x1D9DFF0", Slot = "5")]
	public override void CheckContents(Action<DLCID[]> onComplete)
	{
	}

	// Token: 0x06001620 RID: 5664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A2")]
	[Address(RVA = "0x1D9E090", Offset = "0x1D9E191", VA = "0x1D9E090", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D330", Offset = "0x19D431")]
	public override IEnumerator Update()
	{
		return null;
	}

	// Token: 0x02000336 RID: 822
	[Token(Token = "0x2001056")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157550", Offset = "0x157651")]
	private sealed class <Update>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001621 RID: 5665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D69")]
		[Address(RVA = "0x1D9E0F0", Offset = "0x1D9E1F1", VA = "0x1D9E0F0")]
		[DebuggerHidden]
		public <Update>d__2(int <>1__state)
		{
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6A")]
		[Address(RVA = "0x1D9E120", Offset = "0x1D9E221", VA = "0x1D9E120", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x6006D6B")]
		[Address(RVA = "0x1D9E130", Offset = "0x1D9E231", VA = "0x1D9E130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C23")]
		private object Current
		{
			[Token(Token = "0x6006D6C")]
			[Address(RVA = "0x1D9E150", Offset = "0x1D9E251", VA = "0x1D9E150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6D")]
		[Address(RVA = "0x1D9E160", Offset = "0x1D9E261", VA = "0x1D9E160", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C24")]
		private object Current
		{
			[Token(Token = "0x6006D6E")]
			[Address(RVA = "0x1D9E1C0", Offset = "0x1D9E2C1", VA = "0x1D9E1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CC0 RID: 3264
		[Token(Token = "0x4018F87")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000CC1 RID: 3265
		[Token(Token = "0x4018F88")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}
}
