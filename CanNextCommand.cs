using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020000BF RID: 191
[Token(Token = "0x2000095")]
public class CanNextCommand : ToolActionCommandBase
{
	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000AA")]
	public string NextActionCode1
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1E7D090", Offset = "0x1E7D191", VA = "0x1E7D090")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000AB")]
	public string NextActionCode2
	{
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1E7D0B0", Offset = "0x1E7D1B1", VA = "0x1E7D0B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060003B0 RID: 944 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x170000AC")]
	public bool DisableInputStart
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1E7D0D0", Offset = "0x1E7D1D1", VA = "0x1E7D0D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060003B1 RID: 945 RVA: 0x00003318 File Offset: 0x00001518
	[Token(Token = "0x170000AD")]
	public SkillID SkillID
	{
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1E7D0F0", Offset = "0x1E7D1F1", VA = "0x1E7D0F0")]
		get
		{
			return SkillID.SKILL_EMPTY;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x060003B2 RID: 946 RVA: 0x00003330 File Offset: 0x00001530
	[Token(Token = "0x170000AE")]
	public int SkillLevel
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1E7D190", Offset = "0x1E7D291", VA = "0x1E7D190")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x060003B3 RID: 947 RVA: 0x00003348 File Offset: 0x00001548
	[Token(Token = "0x170000AF")]
	public int PressCount
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1E7D1B0", Offset = "0x1E7D2B1", VA = "0x1E7D1B0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1E7D1D0", Offset = "0x1E7D2D1", VA = "0x1E7D1D0")]
	public CanNextCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1E7D290", Offset = "0x1E7D391", VA = "0x1E7D290", Slot = "7")]
	public override void ActionInitial()
	{
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x1E7D2E0", Offset = "0x1E7D3E1", VA = "0x1E7D2E0", Slot = "8")]
	public override void DoAction()
	{
	}
}
