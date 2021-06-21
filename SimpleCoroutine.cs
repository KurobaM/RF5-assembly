using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine.Events;

// Token: 0x020004CE RID: 1230
[Token(Token = "0x200038B")]
public static class SimpleCoroutine
{
	// Token: 0x06001E49 RID: 7753 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x1DE3C50", Offset = "0x1DE3D51", VA = "0x1DE3C50")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F290", Offset = "0x19F391")]
	public static IEnumerator WaitForSeconds(UnityAction action, float waitTime)
	{
		return null;
	}

	// Token: 0x06001E4A RID: 7754 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A21")]
	[Address(RVA = "0x1DE3D10", Offset = "0x1DE3E11", VA = "0x1DE3D10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19F300", Offset = "0x19F401")]
	public static IEnumerator NextUpdate(UnityAction action)
	{
		return null;
	}

	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20010CC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B40", Offset = "0x157C41")]
	private sealed class <WaitForSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E4B RID: 7755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0x1DE3CE0", Offset = "0x1DE3DE1", VA = "0x1DE3CE0")]
		[DebuggerHidden]
		public <WaitForSeconds>d__0(int <>1__state)
		{
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0x1DE3ED0", Offset = "0x1DE3FD1", VA = "0x1DE3ED0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x6006F16")]
		[Address(RVA = "0x1DE3EE0", Offset = "0x1DE3FE1", VA = "0x1DE3EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C89")]
		private object Current
		{
			[Token(Token = "0x6006F17")]
			[Address(RVA = "0x1DE3FB0", Offset = "0x1DE40B1", VA = "0x1DE3FB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F18")]
		[Address(RVA = "0x1DE3FC0", Offset = "0x1DE40C1", VA = "0x1DE3FC0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8A")]
		private object Current
		{
			[Token(Token = "0x6006F19")]
			[Address(RVA = "0x1DE4020", Offset = "0x1DE4121", VA = "0x1DE4020", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006448 RID: 25672
		[Token(Token = "0x40191C3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006449 RID: 25673
		[Token(Token = "0x40191C4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400644A RID: 25674
		[Token(Token = "0x40191C5")]
		[FieldOffset(Offset = "0x20")]
		public float waitTime;

		// Token: 0x0400644B RID: 25675
		[Token(Token = "0x40191C6")]
		[FieldOffset(Offset = "0x28")]
		public UnityAction action;
	}

	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20010CD")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B50", Offset = "0x157C51")]
	private sealed class <NextUpdate>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1A")]
		[Address(RVA = "0x1DE3D90", Offset = "0x1DE3E91", VA = "0x1DE3D90")]
		[DebuggerHidden]
		public <NextUpdate>d__1(int <>1__state)
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1B")]
		[Address(RVA = "0x1DE3DC0", Offset = "0x1DE3EC1", VA = "0x1DE3DC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x6006F1C")]
		[Address(RVA = "0x1DE3DD0", Offset = "0x1DE3ED1", VA = "0x1DE3DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8B")]
		private object Current
		{
			[Token(Token = "0x6006F1D")]
			[Address(RVA = "0x1DE3E50", Offset = "0x1DE3F51", VA = "0x1DE3E50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F1E")]
		[Address(RVA = "0x1DE3E60", Offset = "0x1DE3F61", VA = "0x1DE3E60", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8C")]
		private object Current
		{
			[Token(Token = "0x6006F1F")]
			[Address(RVA = "0x1DE3EC0", Offset = "0x1DE3FC1", VA = "0x1DE3EC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400644C RID: 25676
		[Token(Token = "0x40191C7")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400644D RID: 25677
		[Token(Token = "0x40191C8")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400644E RID: 25678
		[Token(Token = "0x40191C9")]
		[FieldOffset(Offset = "0x20")]
		public UnityAction action;
	}
}
