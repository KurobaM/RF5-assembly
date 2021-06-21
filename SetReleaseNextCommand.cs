using System;
using Il2CppDummyDll;

// Token: 0x020000E0 RID: 224
[Token(Token = "0x20000B5")]
public class SetReleaseNextCommand : ToolActionCommandBase
{
	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06000444 RID: 1092 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000F5")]
	public string NextActionCode
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1E34E60", Offset = "0x1E34F61", VA = "0x1E34E60")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000384")]
	[Address(RVA = "0x1E34E80", Offset = "0x1E34F81", VA = "0x1E34E80")]
	public SetReleaseNextCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x1E34F10", Offset = "0x1E35011", VA = "0x1E34F10", Slot = "8")]
	public override void DoAction()
	{
	}
}
