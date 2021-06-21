using System;
using Il2CppDummyDll;

// Token: 0x020000E2 RID: 226
[Token(Token = "0x20000B7")]
public class SuperArmorCommand : ToolActionCommandBase
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x0600044A RID: 1098 RVA: 0x00003948 File Offset: 0x00001B48
	[Token(Token = "0x170000F7")]
	public float Time
	{
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1FAB490", Offset = "0x1FAB591", VA = "0x1FAB490")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600044B RID: 1099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1FAB4B0", Offset = "0x1FAB5B1", VA = "0x1FAB4B0")]
	public SuperArmorCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x0600044C RID: 1100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x1FAB510", Offset = "0x1FAB611", VA = "0x1FAB510", Slot = "8")]
	public override void DoAction()
	{
	}
}
