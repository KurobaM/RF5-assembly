using System;
using Il2CppDummyDll;

// Token: 0x02000080 RID: 128
[Token(Token = "0x2000062")]
public class SetLoopShotActionCommand : ActionCommandBase
{
	// Token: 0x17000066 RID: 102
	// (get) Token: 0x0600024D RID: 589 RVA: 0x00002B38 File Offset: 0x00000D38
	[Token(Token = "0x17000063")]
	public float LoopTime
	{
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1E34850", Offset = "0x1E34951", VA = "0x1E34850")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x0600024E RID: 590 RVA: 0x00002B50 File Offset: 0x00000D50
	[Token(Token = "0x17000064")]
	public float ShotSpaceTime
	{
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1E34870", Offset = "0x1E34971", VA = "0x1E34870")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1E34890", Offset = "0x1E34991", VA = "0x1E34890")]
	public SetLoopShotActionCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1E348F0", Offset = "0x1E349F1", VA = "0x1E348F0", Slot = "8")]
	public override void DoAction()
	{
	}
}
