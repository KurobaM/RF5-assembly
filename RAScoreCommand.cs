using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000059")]
public class RAScoreCommand : ActionCommandBase
{
	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000238 RID: 568 RVA: 0x00002B08 File Offset: 0x00000D08
	[Token(Token = "0x17000061")]
	public ScoreType ScoreType
	{
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x216FF20", Offset = "0x2170021", VA = "0x216FF20")]
		get
		{
			return ScoreType.None;
		}
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x216FFC0", Offset = "0x21700C1", VA = "0x216FFC0")]
	public RAScoreCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x2170020", Offset = "0x2170121", VA = "0x2170020", Slot = "8")]
	public override void DoAction()
	{
	}
}
