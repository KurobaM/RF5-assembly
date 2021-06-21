using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CD RID: 461
[Token(Token = "0x200016B")]
public class CollapseLandingObserve : NormalizedTimeObserve
{
	// Token: 0x170001C8 RID: 456
	// (get) Token: 0x0600098E RID: 2446 RVA: 0x00004FB0 File Offset: 0x000031B0
	[Token(Token = "0x170001AB")]
	protected override bool IsUseClamp
	{
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1EA1F30", Offset = "0x1EA2031", VA = "0x1EA1F30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600098F RID: 2447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x1EA1F40", Offset = "0x1EA2041", VA = "0x1EA1F40", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	// Token: 0x06000990 RID: 2448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x1EA2000", Offset = "0x1EA2101", VA = "0x1EA2000", Slot = "19")]
	public override void DoEvent()
	{
	}

	// Token: 0x06000991 RID: 2449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x1EA20D0", Offset = "0x1EA21D1", VA = "0x1EA20D0")]
	public CollapseLandingObserve()
	{
	}

	// Token: 0x04000610 RID: 1552
	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x28")]
	private Character Character;
}
