using System;
using Il2CppDummyDll;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000B4")]
public class SetFarmRangeCommand : ToolActionCommandBase
{
	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x170000F3")]
	public FarmRange FarmRange
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1E345F0", Offset = "0x1E346F1", VA = "0x1E345F0")]
		get
		{
			return FarmRange.None;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06000441 RID: 1089 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x170000F4")]
	public FarmAction FarmAction
	{
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1E346E0", Offset = "0x1E347E1", VA = "0x1E346E0")]
		get
		{
			return FarmAction.None;
		}
	}

	// Token: 0x06000442 RID: 1090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000381")]
	[Address(RVA = "0x1E347D0", Offset = "0x1E348D1", VA = "0x1E347D0")]
	public SetFarmRangeCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x06000443 RID: 1091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000382")]
	[Address(RVA = "0x1E34830", Offset = "0x1E34931", VA = "0x1E34830", Slot = "8")]
	public override void DoAction()
	{
	}
}
