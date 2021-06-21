using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000023 RID: 35
[Token(Token = "0x2000022")]
public class ActionBehaviorController
{
	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1FD4D50", Offset = "0x1FD4E51", VA = "0x1FD4D50")]
	public ActionBehaviorController(AIInput owner)
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1FD4D90", Offset = "0x1FD4E91", VA = "0x1FD4D90")]
	private ActionBehaviorCommandBase CreateActionBehaviorCommand(ActionBehaviorCommandInformation commandinfo)
	{
		return null;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1FD4EC0", Offset = "0x1FD4FC1", VA = "0x1FD4EC0")]
	public int GetLotteryIndex(List<int> percentList)
	{
		return 0;
	}

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x10")]
	public AIInput Owner;
}
