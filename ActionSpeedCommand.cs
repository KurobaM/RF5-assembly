using System;
using Il2CppDummyDll;

// Token: 0x020000B8 RID: 184
[Token(Token = "0x200008E")]
public class ActionSpeedCommand : ToolActionCommandBase
{
	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600039A RID: 922 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x170000A5")]
	public float Speed
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1D45A10", Offset = "0x1D45B11", VA = "0x1D45A10")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600039B RID: 923 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x170000A6")]
	public float Time
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1D45A30", Offset = "0x1D45B31", VA = "0x1D45A30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x1D45A50", Offset = "0x1D45B51", VA = "0x1D45A50")]
	public ActionSpeedCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1D45AB0", Offset = "0x1D45BB1", VA = "0x1D45AB0", Slot = "8")]
	public override void DoAction()
	{
	}
}
