using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000BB9 RID: 3001
[Token(Token = "0x20007CA")]
public class UILoadingStreamer : MonoBehaviour
{
	// Token: 0x06004CC2 RID: 19650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600405F")]
	[Address(RVA = "0x201F210", Offset = "0x201F311", VA = "0x201F210")]
	private void Awake()
	{
	}

	// Token: 0x06004CC3 RID: 19651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004060")]
	[Address(RVA = "0x201F2B0", Offset = "0x201F3B1", VA = "0x201F2B0")]
	private void Update()
	{
	}

	// Token: 0x06004CC4 RID: 19652 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6004061")]
	[Address(RVA = "0x201F470", Offset = "0x201F571", VA = "0x201F470")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A8E80", Offset = "0x1A8F81")]
	public IEnumerator TurnOff()
	{
		return null;
	}

	// Token: 0x06004CC5 RID: 19653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004062")]
	[Address(RVA = "0x201F520", Offset = "0x201F621", VA = "0x201F520")]
	public void Show()
	{
	}

	// Token: 0x06004CC6 RID: 19654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004063")]
	[Address(RVA = "0x201F5A0", Offset = "0x201F6A1", VA = "0x201F5A0")]
	public void Hide()
	{
	}

	// Token: 0x06004CC7 RID: 19655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6004064")]
	[Address(RVA = "0x201F670", Offset = "0x201F771", VA = "0x201F670")]
	public UILoadingStreamer()
	{
	}

	// Token: 0x0400AE5C RID: 44636
	[Token(Token = "0x400837C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x1768D0", Offset = "0x1769D1")]
	public Streamer[] streamers;

	// Token: 0x0400AE5D RID: 44637
	[Token(Token = "0x400837D")]
	[FieldOffset(Offset = "0x20")]
	public Image progressImg;

	// Token: 0x0400AE5E RID: 44638
	[Token(Token = "0x400837E")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x176910", Offset = "0x176A11")]
	public float waitTime;

	// Token: 0x0400AE5F RID: 44639
	[Token(Token = "0x400837F")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onDone;

	// Token: 0x0400AE60 RID: 44640
	[Token(Token = "0x4008380")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine TurnOffCoroutine;

	// Token: 0x02000BBA RID: 3002
	[Token(Token = "0x200136F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1594B0", Offset = "0x1595B1")]
	private sealed class <TurnOff>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06004CC8 RID: 19656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007745")]
		[Address(RVA = "0x201F4F0", Offset = "0x201F5F1", VA = "0x201F4F0")]
		[DebuggerHidden]
		public <TurnOff>d__7(int <>1__state)
		{
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007746")]
		[Address(RVA = "0x201F680", Offset = "0x201F781", VA = "0x201F680", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00018660 File Offset: 0x00016860
		[Token(Token = "0x6007747")]
		[Address(RVA = "0x201F690", Offset = "0x201F791", VA = "0x201F690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06004CCB RID: 19659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC5")]
		private object Current
		{
			[Token(Token = "0x6007748")]
			[Address(RVA = "0x201F790", Offset = "0x201F891", VA = "0x201F790", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007749")]
		[Address(RVA = "0x201F7A0", Offset = "0x201F8A1", VA = "0x201F7A0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06004CCD RID: 19661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DC6")]
		private object Current
		{
			[Token(Token = "0x600774A")]
			[Address(RVA = "0x201F800", Offset = "0x201F901", VA = "0x201F800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0400AE61 RID: 44641
		[Token(Token = "0x401B739")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x0400AE62 RID: 44642
		[Token(Token = "0x401B73A")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x0400AE63 RID: 44643
		[Token(Token = "0x401B73B")]
		[FieldOffset(Offset = "0x20")]
		public UILoadingStreamer <>4__this;
	}
}
