using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000070 RID: 112
[Token(Token = "0x2000053")]
public class MagicMediCommand : ActionCommandBase
{
	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000210 RID: 528 RVA: 0x000029D0 File Offset: 0x00000BD0
	[Token(Token = "0x1700004B")]
	public MagicParamID MagicParamID1
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1F13E70", Offset = "0x1F13F71", VA = "0x1F13E70")]
		get
		{
			return MagicParamID.EMPTY;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000211 RID: 529 RVA: 0x000029E8 File Offset: 0x00000BE8
	[Token(Token = "0x1700004C")]
	public MagicParamID MagicParamID2
	{
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1F13F60", Offset = "0x1F14061", VA = "0x1F13F60")]
		get
		{
			return MagicParamID.EMPTY;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000212 RID: 530 RVA: 0x00002A00 File Offset: 0x00000C00
	[Token(Token = "0x1700004D")]
	public MagicParamID MagicParamID3
	{
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1F14050", Offset = "0x1F14151", VA = "0x1F14050")]
		get
		{
			return MagicParamID.EMPTY;
		}
	}

	// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1F14140", Offset = "0x1F14241", VA = "0x1F14140")]
	public MagicMediCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1F141A0", Offset = "0x1F142A1", VA = "0x1F141A0", Slot = "8")]
	public override void DoAction()
	{
	}
}
