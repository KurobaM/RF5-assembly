using System;
using Il2CppDummyDll;
using RF5_Sound;

// Token: 0x02000078 RID: 120
[Token(Token = "0x200005A")]
public class SECommand : ActionCommandBase
{
	// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1EF55E0", Offset = "0x1EF56E1", VA = "0x1EF55E0")]
	public SECommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1EF5640", Offset = "0x1EF5741", VA = "0x1EF5640", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1EF5790", Offset = "0x1EF5891", VA = "0x1EF5790", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x04000198 RID: 408
	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0x80")]
	private SEController LoopSEController;
}
