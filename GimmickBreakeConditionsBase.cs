using System;
using Il2CppDummyDll;

// Token: 0x020005CE RID: 1486
[Token(Token = "0x200042E")]
public class GimmickBreakeConditionsBase : CharacterBase
{
	// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0x1FA8F10", Offset = "0x1FA9011", VA = "0x1FA8F10", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x0600247A RID: 9338 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x1FA8F90", Offset = "0x1FA9091", VA = "0x1FA8F90", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x1FA8F00", Offset = "0x1FA9001", VA = "0x1FA8F00")]
	public GimmickBreakeConditionsBase()
	{
	}

	// Token: 0x04006BE5 RID: 27621
	[Token(Token = "0x4006535")]
	[FieldOffset(Offset = "0x68")]
	protected GimmickBreakeObject Object;
}
