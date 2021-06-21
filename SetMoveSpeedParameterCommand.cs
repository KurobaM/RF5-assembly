using System;
using Il2CppDummyDll;

// Token: 0x020000A7 RID: 167
[Token(Token = "0x2000081")]
public class SetMoveSpeedParameterCommand : MonsterActionCommandBase
{
	// Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x1E34910", Offset = "0x1E34A11", VA = "0x1E34910")]
	public SetMoveSpeedParameterCommand(ActionCommandDataTable actionCommandData, MonsterActionScriptsController controller)
	{
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x0600033C RID: 828 RVA: 0x00003060 File Offset: 0x00001260
	[Token(Token = "0x1700008B")]
	public override float Duration
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1E34970", Offset = "0x1E34A71", VA = "0x1E34970", Slot = "4")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x1E34990", Offset = "0x1E34A91", VA = "0x1E34990", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x1E349C0", Offset = "0x1E34AC1", VA = "0x1E349C0")]
	private void StartMove()
	{
	}

	// Token: 0x0600033F RID: 831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x1E34AC0", Offset = "0x1E34BC1", VA = "0x1E34AC0")]
	private void UpdateMoveSpeed()
	{
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x1E34B40", Offset = "0x1E34C41", VA = "0x1E34B40", Slot = "9")]
	public override void UpdateAction(float elapsedTime)
	{
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x1E34BB0", Offset = "0x1E34CB1", VA = "0x1E34BB0", Slot = "10")]
	public override void EndAction()
	{
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x1E34BC0", Offset = "0x1E34CC1", VA = "0x1E34BC0", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x88")]
	private bool DoneUpdateMove;
}
