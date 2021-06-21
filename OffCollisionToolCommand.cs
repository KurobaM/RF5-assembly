using System;
using Il2CppDummyDll;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000A8")]
public class OffCollisionToolCommand : ToolActionCommandBase
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x060003F9 RID: 1017 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x170000CB")]
	internal AttachHand AttachHand
	{
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1F57710", Offset = "0x1F57811", VA = "0x1F57710")]
		get
		{
			return AttachHand.Right;
		}
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033C")]
	[Address(RVA = "0x1F57720", Offset = "0x1F57821", VA = "0x1F57720")]
	public OffCollisionToolCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600033D")]
	[Address(RVA = "0x1F57780", Offset = "0x1F57881", VA = "0x1F57780", Slot = "8")]
	public override void DoAction()
	{
	}
}
