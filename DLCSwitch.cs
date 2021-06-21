using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

// Token: 0x02000337 RID: 823
[Token(Token = "0x2000269")]
public class DLCSwitch : DLC
{
	// Token: 0x06001627 RID: 5671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013A3")]
	[Address(RVA = "0x1D9D950", Offset = "0x1D9DA51", VA = "0x1D9D950")]
	public DLCSwitch()
	{
	}

	// Token: 0x06001628 RID: 5672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013A4")]
	[Address(RVA = "0x1D9E1D0", Offset = "0x1D9E2D1", VA = "0x1D9E1D0", Slot = "6")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D3A0", Offset = "0x19D4A1")]
	public override IEnumerator Update()
	{
		return null;
	}

	// Token: 0x04000CC2 RID: 3266
	[Token(Token = "0x40009AC")]
	private const int MaxListupCount = 256;

	// Token: 0x02000338 RID: 824
	[Token(Token = "0x2001057")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157560", Offset = "0x157661")]
	private sealed class <Update>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001629 RID: 5673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D6F")]
		[Address(RVA = "0x1D9E250", Offset = "0x1D9E351", VA = "0x1D9E250")]
		[DebuggerHidden]
		public <Update>d__2(int <>1__state)
		{
		}

		// Token: 0x0600162A RID: 5674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D70")]
		[Address(RVA = "0x1D9E280", Offset = "0x1D9E381", VA = "0x1D9E280", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x6006D71")]
		[Address(RVA = "0x1D9E290", Offset = "0x1D9E391", VA = "0x1D9E290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C25")]
		private object Current
		{
			[Token(Token = "0x6006D72")]
			[Address(RVA = "0x1D9E5C0", Offset = "0x1D9E6C1", VA = "0x1D9E5C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D73")]
		[Address(RVA = "0x1D9E5D0", Offset = "0x1D9E6D1", VA = "0x1D9E5D0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C26")]
		private object Current
		{
			[Token(Token = "0x6006D74")]
			[Address(RVA = "0x1D9E630", Offset = "0x1D9E731", VA = "0x1D9E630", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000CC3 RID: 3267
		[Token(Token = "0x4018F89")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000CC4 RID: 3268
		[Token(Token = "0x4018F8A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000CC5 RID: 3269
		[Token(Token = "0x4018F8B")]
		[FieldOffset(Offset = "0x20")]
		public DLCSwitch <>4__this;
	}
}
