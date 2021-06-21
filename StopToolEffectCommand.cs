using System;
using Il2CppDummyDll;

// Token: 0x020000E1 RID: 225
[Token(Token = "0x20000B6")]
public class StopToolEffectCommand : ToolActionCommandBase
{
	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06000447 RID: 1095 RVA: 0x00003930 File Offset: 0x00001B30
	[Token(Token = "0x170000F6")]
	public int Slot
	{
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x238BB30", Offset = "0x238BC31", VA = "0x238BB30")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000448 RID: 1096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x238BB50", Offset = "0x238BC51", VA = "0x238BB50")]
	public StopToolEffectCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x06000449 RID: 1097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x238BBB0", Offset = "0x238BCB1", VA = "0x238BBB0", Slot = "8")]
	public override void DoAction()
	{
	}
}
