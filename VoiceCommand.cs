using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000082 RID: 130
[Token(Token = "0x2000064")]
public class VoiceCommand : ActionCommandBase
{
	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06000253 RID: 595 RVA: 0x00002B68 File Offset: 0x00000D68
	[Token(Token = "0x17000065")]
	public VoiceGroup VoiceGroup
	{
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1E47C60", Offset = "0x1E47D61", VA = "0x1E47C60")]
		get
		{
			return VoiceGroup.Attack;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x06000254 RID: 596 RVA: 0x00002B80 File Offset: 0x00000D80
	[Token(Token = "0x17000066")]
	public ActorID OverrideActorID
	{
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1E47D30", Offset = "0x1E47E31", VA = "0x1E47D30")]
		get
		{
			return ActorID.act000;
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1E47E00", Offset = "0x1E47F01", VA = "0x1E47E00")]
	public VoiceCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1E47E60", Offset = "0x1E47F61", VA = "0x1E47E60", Slot = "8")]
	public override void DoAction()
	{
	}
}
