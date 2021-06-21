using System;
using Il2CppDummyDll;

// Token: 0x02000254 RID: 596
[Token(Token = "0x20001DF")]
public class HumanThrottleController : CharaThrottleController<HumanController>
{
	// Token: 0x06000E6E RID: 3694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x222ACD0", Offset = "0x222ADD1", VA = "0x222ACD0", Slot = "8")]
	public override void OnUpdate()
	{
	}

	// Token: 0x06000E6F RID: 3695 RVA: 0x00006888 File Offset: 0x00004A88
	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x222AE20", Offset = "0x222AF21", VA = "0x222AE20", Slot = "9")]
	public override bool DoPlay(ThrottleID throttleID)
	{
		return default(bool);
	}

	// Token: 0x06000E70 RID: 3696 RVA: 0x000068A0 File Offset: 0x00004AA0
	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x222B7B0", Offset = "0x222B8B1", VA = "0x222B7B0", Slot = "10")]
	public override bool DoStop()
	{
		return default(bool);
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x222B990", Offset = "0x222BA91", VA = "0x222B990")]
	public HumanThrottleController()
	{
	}

	// Token: 0x04000850 RID: 2128
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x28")]
	private int m_RepeatCount;

	// Token: 0x04000851 RID: 2129
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_isStopped;
}
