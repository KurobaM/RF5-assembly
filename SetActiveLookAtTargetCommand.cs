using System;
using Il2CppDummyDll;

// Token: 0x020000A5 RID: 165
[Token(Token = "0x200007F")]
public class SetActiveLookAtTargetCommand : MonsterActionCommandBase
{
	// Token: 0x1700008A RID: 138
	// (get) Token: 0x0600032E RID: 814 RVA: 0x00003000 File Offset: 0x00001200
	[Token(Token = "0x17000087")]
	private float SpeedScale
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1E31C80", Offset = "0x1E31D81", VA = "0x1E31C80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1E31CB0", Offset = "0x1E31DB1", VA = "0x1E31CB0")]
	public SetActiveLookAtTargetCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000330 RID: 816 RVA: 0x00003018 File Offset: 0x00001218
	[Token(Token = "0x17000088")]
	public override float Duration
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1E31D10", Offset = "0x1E31E11", VA = "0x1E31D10", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x1E31D30", Offset = "0x1E31E31", VA = "0x1E31D30", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000332 RID: 818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x1E31E10", Offset = "0x1E31F11", VA = "0x1E31E10", Slot = "10")]
	public override void EndAction()
	{
	}

	// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027B")]
	[Address(RVA = "0x1E31E20", Offset = "0x1E31F21", VA = "0x1E31E20", Slot = "11")]
	public override void ActionFinal()
	{
	}
}
