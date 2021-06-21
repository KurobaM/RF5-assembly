using System;
using Il2CppDummyDll;

// Token: 0x020000C3 RID: 195
[Token(Token = "0x2000099")]
public class DamageCheckStartCommand : ToolActionCommandBase
{
	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B1")]
	public string NextActionCode1
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1DA1360", Offset = "0x1DA1461", VA = "0x1DA1360")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060003BF RID: 959 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x170000B2")]
	public bool IsAcceptAngle
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1DA1380", Offset = "0x1DA1481", VA = "0x1DA1380")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060003C0 RID: 960 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x170000B3")]
	public float AcceptAngle
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1DA13A0", Offset = "0x1DA14A1", VA = "0x1DA13A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000303")]
	[Address(RVA = "0x1DA13C0", Offset = "0x1DA14C1", VA = "0x1DA13C0")]
	public DamageCheckStartCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000304")]
	[Address(RVA = "0x1DA1450", Offset = "0x1DA1551", VA = "0x1DA1450", Slot = "8")]
	public override void DoAction()
	{
	}
}
