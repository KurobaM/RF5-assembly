using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200059E RID: 1438
[Token(Token = "0x2000400")]
public class TeleportCheckFunc : PlayerTeleportButton
{
	// Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x1F69C40", Offset = "0x1F69D41", VA = "0x1F69C40", Slot = "19")]
	public override void DoInteraction(HumanController character)
	{
	}

	// Token: 0x0600235D RID: 9053 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x1F69D40", Offset = "0x1F69E41", VA = "0x1F69D40", Slot = "21")]
	protected override void Awake()
	{
	}

	// Token: 0x0600235E RID: 9054 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
	[Token(Token = "0x6001DA4")]
	[Address(RVA = "0x1F69CD0", Offset = "0x1F69DD1", VA = "0x1F69CD0")]
	private bool CheckCanTeleportFunc()
	{
		return default(bool);
	}

	// Token: 0x0600235F RID: 9055 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA5")]
	[Address(RVA = "0x1F69D50", Offset = "0x1F69E51", VA = "0x1F69D50", Slot = "20")]
	protected override void OnTriggerEnter(Collider collision)
	{
	}

	// Token: 0x06002360 RID: 9056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA6")]
	[Address(RVA = "0x1F69E20", Offset = "0x1F69F21", VA = "0x1F69E20", Slot = "23")]
	protected override void TeleportScene()
	{
	}

	// Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DA7")]
	[Address(RVA = "0x1F69E30", Offset = "0x1F69F31", VA = "0x1F69E30")]
	public TeleportCheckFunc()
	{
	}

	// Token: 0x04006B1B RID: 27419
	[Token(Token = "0x4006472")]
	[FieldOffset(Offset = "0xA0")]
	public Func<bool> CanTeleportFunc;
}
