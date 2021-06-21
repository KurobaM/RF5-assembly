using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B9 RID: 185
[Token(Token = "0x200008F")]
public class AddForceCommand : ToolActionCommandBase
{
	// Token: 0x170000AA RID: 170
	// (get) Token: 0x0600039E RID: 926 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x170000A7")]
	public Vector3 Direction
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1D56C80", Offset = "0x1D56D81", VA = "0x1D56C80")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x0600039F RID: 927 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x170000A8")]
	public float Power
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1D56CA0", Offset = "0x1D56DA1", VA = "0x1D56CA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x1D56CC0", Offset = "0x1D56DC1", VA = "0x1D56CC0")]
	public AddForceCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x1D56D20", Offset = "0x1D56E21", VA = "0x1D56D20", Slot = "8")]
	public override void DoAction()
	{
	}
}
