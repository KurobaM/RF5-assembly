using System;
using Il2CppDummyDll;

// Token: 0x020000BA RID: 186
[Token(Token = "0x2000090")]
public class ApproachCommand : ToolActionCommandBase
{
	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060003A2 RID: 930 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x170000A9")]
	public float Force
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x24364B0", Offset = "0x24365B1", VA = "0x24364B0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x24364D0", Offset = "0x24365D1", VA = "0x24364D0")]
	public ApproachCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2436530", Offset = "0x2436631", VA = "0x2436530", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x000032E8 File Offset: 0x000014E8
	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x2436760", Offset = "0x2436861", VA = "0x2436760")]
	private bool IsCanBreak(HumanController character)
	{
		return default(bool);
	}
}
