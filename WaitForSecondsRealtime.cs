using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DD RID: 733
[Token(Token = "0x200023D")]
public sealed class WaitForSecondsRealtime : CustomYieldInstruction
{
	// Token: 0x1700037A RID: 890
	// (get) Token: 0x0600138C RID: 5004 RVA: 0x00008D48 File Offset: 0x00006F48
	[Token(Token = "0x17000342")]
	public override bool keepWaiting
	{
		[Token(Token = "0x60011C3")]
		[Address(RVA = "0x1E4BE90", Offset = "0x1E4BF91", VA = "0x1E4BE90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x1E4BEC0", Offset = "0x1E4BFC1", VA = "0x1E4BEC0")]
	public WaitForSecondsRealtime(float time)
	{
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x1E4BF00", Offset = "0x1E4C001", VA = "0x1E4BF00")]
	public void SetWaitForSecondsRealtime(float time)
	{
	}

	// Token: 0x04000AF4 RID: 2804
	[Token(Token = "0x4000890")]
	[FieldOffset(Offset = "0x10")]
	private float waitTime;
}
