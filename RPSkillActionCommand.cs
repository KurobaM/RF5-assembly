using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000AE")]
public class RPSkillActionCommand : ActionCommandBase
{
	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x170000E5")]
	public SkillActionID SkillActionID
	{
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1F39F30", Offset = "0x1F3A031", VA = "0x1F39F30")]
		get
		{
			return SkillActionID.ACT_EMPTY;
		}
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000363")]
	[Address(RVA = "0x1F39FD0", Offset = "0x1F3A0D1", VA = "0x1F39FD0")]
	public RPSkillActionCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000364")]
	[Address(RVA = "0x1F3A030", Offset = "0x1F3A131", VA = "0x1F3A030", Slot = "8")]
	public override void DoAction()
	{
	}
}
