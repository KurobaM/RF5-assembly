using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000071 RID: 113
[Token(Token = "0x2000054")]
public class MagicPlayCommand : ActionCommandBase
{
	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000215 RID: 533 RVA: 0x00002A18 File Offset: 0x00000C18
	[Token(Token = "0x1700004E")]
	public MagicID MagicID
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1F14720", Offset = "0x1F14821", VA = "0x1F14720")]
		get
		{
			return MagicID.None;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000216 RID: 534 RVA: 0x00002A30 File Offset: 0x00000C30
	[Token(Token = "0x1700004F")]
	public Vector3 Offset
	{
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1F14810", Offset = "0x1F14911", VA = "0x1F14810")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1F14830", Offset = "0x1F14931", VA = "0x1F14830")]
	public MagicPlayCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1F14890", Offset = "0x1F14991", VA = "0x1F14890", Slot = "8")]
	public override void DoAction()
	{
	}
}
