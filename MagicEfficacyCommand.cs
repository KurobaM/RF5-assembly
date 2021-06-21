using System;
using Define;
using Il2CppDummyDll;

// Token: 0x0200006F RID: 111
[Token(Token = "0x2000052")]
public class MagicEfficacyCommand : ActionCommandBase
{
	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600020D RID: 525 RVA: 0x000029B8 File Offset: 0x00000BB8
	[Token(Token = "0x1700004A")]
	public MagicParamID MagicParamID
	{
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1F12710", Offset = "0x1F12811", VA = "0x1F12710")]
		get
		{
			return MagicParamID.EMPTY;
		}
	}

	// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1F12800", Offset = "0x1F12901", VA = "0x1F12800")]
	public MagicEfficacyCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600020F RID: 527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1F12860", Offset = "0x1F12961", VA = "0x1F12860", Slot = "8")]
	public override void DoAction()
	{
	}
}
