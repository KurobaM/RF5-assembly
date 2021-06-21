using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000069 RID: 105
[Token(Token = "0x200004C")]
public class CallBitCommand : ActionCommandBase
{
	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002880 File Offset: 0x00000A80
	[Token(Token = "0x1700003B")]
	public BitID BitID
	{
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1E75210", Offset = "0x1E75311", VA = "0x1E75210")]
		get
		{
			return BitID.None;
		}
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1E75300", Offset = "0x1E75401", VA = "0x1E75300")]
	public CallBitCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1E75360", Offset = "0x1E75461", VA = "0x1E75360", Slot = "8")]
	public override void DoAction()
	{
	}
}
