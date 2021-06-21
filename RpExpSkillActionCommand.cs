using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000DA RID: 218
[Token(Token = "0x20000B0")]
public class RpExpSkillActionCommand : ActionCommandBase
{
	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000429 RID: 1065 RVA: 0x00003840 File Offset: 0x00001A40
	[Token(Token = "0x170000EA")]
	public int Slot
	{
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x27DCCE0", Offset = "0x27DCDE1", VA = "0x27DCCE0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x170000EB")]
	public SkillActionID SkillActionID
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x27DCD00", Offset = "0x27DCE01", VA = "0x27DCD00")]
		get
		{
			return SkillActionID.ACT_EMPTY;
		}
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036D")]
	[Address(RVA = "0x27DCDA0", Offset = "0x27DCEA1", VA = "0x27DCDA0")]
	public RpExpSkillActionCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600036E")]
	[Address(RVA = "0x27DCE00", Offset = "0x27DCF01", VA = "0x27DCE00", Slot = "8")]
	public override void DoAction()
	{
	}
}
