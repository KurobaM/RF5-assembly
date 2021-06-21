using System;
using Il2CppDummyDll;

// Token: 0x020000F6 RID: 246
[Token(Token = "0x20000C1")]
[Attribute(Name = "DefaultExecutionOrder", RVA = "0x144CE0", Offset = "0x144DE1")]
public class NullBaseController : ActorController
{
	// Token: 0x0600054B RID: 1355 RVA: 0x00003ED0 File Offset: 0x000020D0
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x1F55930", Offset = "0x1F55A31", VA = "0x1F55930", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x1F559B0", Offset = "0x1F55AB1", VA = "0x1F559B0")]
	private void Update()
	{
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x1F559C0", Offset = "0x1F55AC1", VA = "0x1F559C0")]
	public NullBaseController()
	{
	}
}
