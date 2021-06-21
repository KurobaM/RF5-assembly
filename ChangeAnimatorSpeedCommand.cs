using System;
using Il2CppDummyDll;

// Token: 0x020000A4 RID: 164
[Token(Token = "0x200007E")]
public class ChangeAnimatorSpeedCommand : MonsterActionCommandBase
{
	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600032A RID: 810 RVA: 0x00002FE8 File Offset: 0x000011E8
	[Token(Token = "0x17000086")]
	public float MotionSpeed
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1E81D40", Offset = "0x1E81E41", VA = "0x1E81D40")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000273")]
	[Address(RVA = "0x1E81D60", Offset = "0x1E81E61", VA = "0x1E81D60")]
	public ChangeAnimatorSpeedCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x1E81DC0", Offset = "0x1E81EC1", VA = "0x1E81DC0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1E81E00", Offset = "0x1E81F01", VA = "0x1E81E00", Slot = "11")]
	public override void ActionFinal()
	{
	}
}
