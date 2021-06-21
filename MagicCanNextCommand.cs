using System;
using Il2CppDummyDll;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000A3")]
public class MagicCanNextCommand : ToolActionCommandBase
{
	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BE")]
	public string NextActionCode
	{
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1F11DF0", Offset = "0x1F11EF1", VA = "0x1F11DF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x060003DE RID: 990 RVA: 0x00003480 File Offset: 0x00001680
	[Token(Token = "0x170000BF")]
	public int SlotNumber
	{
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1F11E10", Offset = "0x1F11F11", VA = "0x1F11E10")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000321")]
	[Address(RVA = "0x1F11E30", Offset = "0x1F11F31", VA = "0x1F11E30")]
	public MagicCanNextCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000322")]
	[Address(RVA = "0x1F11EC0", Offset = "0x1F11FC1", VA = "0x1F11EC0", Slot = "7")]
	public override void ActionInitial()
	{
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000323")]
	[Address(RVA = "0x1F11F10", Offset = "0x1F12011", VA = "0x1F11F10", Slot = "8")]
	public override void DoAction()
	{
	}
}
