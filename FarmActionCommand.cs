using System;
using Il2CppDummyDll;

// Token: 0x020000C5 RID: 197
[Token(Token = "0x200009B")]
public class FarmActionCommand : ToolActionCommandBase
{
	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060003C3 RID: 963 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x170000B4")]
	public FarmAction FarmAction
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x21A63D0", Offset = "0x21A64D1", VA = "0x21A63D0")]
		get
		{
			return FarmAction.None;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060003C4 RID: 964 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x170000B5")]
	public bool IsCharge
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x21A64C0", Offset = "0x21A65C1", VA = "0x21A64C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000307")]
	[Address(RVA = "0x21A64E0", Offset = "0x21A65E1", VA = "0x21A64E0")]
	public FarmActionCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000308")]
	[Address(RVA = "0x21A6540", Offset = "0x21A6641", VA = "0x21A6540", Slot = "8")]
	public override void DoAction()
	{
	}
}
