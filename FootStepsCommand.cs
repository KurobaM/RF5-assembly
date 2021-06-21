using System;
using Il2CppDummyDll;

// Token: 0x0200006D RID: 109
[Token(Token = "0x2000050")]
public class FootStepsCommand : ActionCommandBase
{
	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000207 RID: 519 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x17000048")]
	public int FootIndex
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1ECE7D0", Offset = "0x1ECE8D1", VA = "0x1ECE7D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000208 RID: 520 RVA: 0x000029A0 File Offset: 0x00000BA0
	[Token(Token = "0x17000049")]
	public bool EffectPlay
	{
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1ECE7F0", Offset = "0x1ECE8F1", VA = "0x1ECE7F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000209 RID: 521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1ECE810", Offset = "0x1ECE911", VA = "0x1ECE810")]
	public FootStepsCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1ECE870", Offset = "0x1ECE971", VA = "0x1ECE870", Slot = "8")]
	public override void DoAction()
	{
	}
}
