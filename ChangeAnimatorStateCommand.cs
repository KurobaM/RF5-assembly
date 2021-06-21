using System;
using Il2CppDummyDll;

// Token: 0x020000A3 RID: 163
[Token(Token = "0x200007D")]
public class ChangeAnimatorStateCommand : MonsterActionCommandBase
{
	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000325 RID: 805 RVA: 0x00002FB8 File Offset: 0x000011B8
	[Token(Token = "0x17000084")]
	public float MotionSpeed
	{
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1E81E30", Offset = "0x1E81F31", VA = "0x1E81E30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000326 RID: 806 RVA: 0x00002FD0 File Offset: 0x000011D0
	[Token(Token = "0x17000085")]
	public float FadeTime
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1E81E50", Offset = "0x1E81F51", VA = "0x1E81E50")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1E81E70", Offset = "0x1E81F71", VA = "0x1E81E70")]
	public ChangeAnimatorStateCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1E81ED0", Offset = "0x1E81FD1", VA = "0x1E81ED0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1E81F70", Offset = "0x1E82071", VA = "0x1E81F70", Slot = "11")]
	public override void ActionFinal()
	{
	}
}
