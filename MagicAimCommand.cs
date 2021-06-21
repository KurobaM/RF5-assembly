using System;
using Il2CppDummyDll;

// Token: 0x020000CC RID: 204
[Token(Token = "0x20000A2")]
public class MagicAimCommand : ToolActionCommandBase
{
	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x060003DA RID: 986 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x170000BD")]
	public int SlotNumber
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1F11A80", Offset = "0x1F11B81", VA = "0x1F11A80")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031D")]
	[Address(RVA = "0x1F11AA0", Offset = "0x1F11BA1", VA = "0x1F11AA0")]
	public MagicAimCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600031E")]
	[Address(RVA = "0x1F11B00", Offset = "0x1F11C01", VA = "0x1F11B00", Slot = "8")]
	public override void DoAction()
	{
	}
}
