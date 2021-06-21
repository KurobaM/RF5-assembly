using System;
using Il2CppDummyDll;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000A4")]
public class MagicCommand : ToolActionCommandBase
{
	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060003E2 RID: 994 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x170000C0")]
	public int SlotNumber
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1F11F50", Offset = "0x1F12051", VA = "0x1F11F50")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000325")]
	[Address(RVA = "0x1F11F70", Offset = "0x1F12071", VA = "0x1F11F70")]
	public MagicCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000326")]
	[Address(RVA = "0x1F11FD0", Offset = "0x1F120D1", VA = "0x1F11FD0", Slot = "8")]
	public override void DoAction()
	{
	}
}
