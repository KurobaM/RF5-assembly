using System;
using Il2CppDummyDll;

// Token: 0x020000CF RID: 207
[Token(Token = "0x20000A5")]
public class MagicMotionCommand : ToolActionCommandBase
{
	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060003E5 RID: 997 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x170000C1")]
	public int MotionNo
	{
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1F14210", Offset = "0x1F14311", VA = "0x1F14210")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060003E6 RID: 998 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x170000C2")]
	public HumanMagicMotionType HumanMagicMotionType
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1F14230", Offset = "0x1F14331", VA = "0x1F14230")]
		get
		{
			return HumanMagicMotionType.None;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x060003E7 RID: 999 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x170000C3")]
	public int SlotNumber
	{
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1F142D0", Offset = "0x1F143D1", VA = "0x1F142D0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032A")]
	[Address(RVA = "0x1F142F0", Offset = "0x1F143F1", VA = "0x1F142F0")]
	public MagicMotionCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600032B")]
	[Address(RVA = "0x1F14350", Offset = "0x1F14451", VA = "0x1F14350", Slot = "8")]
	public override void DoAction()
	{
	}
}
