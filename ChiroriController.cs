using System;
using Il2CppDummyDll;

// Token: 0x020006DA RID: 1754
[Token(Token = "0x20004D9")]
public class ChiroriController : MonsterControllerBase
{
	// Token: 0x06002B07 RID: 11015 RVA: 0x00010758 File Offset: 0x0000E958
	[Token(Token = "0x600243D")]
	[Address(RVA = "0x1EA03B0", Offset = "0x1EA04B1", VA = "0x1EA03B0")]
	private static bool IsKosekiChirori(MonsterID monsterId)
	{
		return default(bool);
	}

	// Token: 0x06002B08 RID: 11016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600243E")]
	[Address(RVA = "0x1EA03C0", Offset = "0x1EA04C1", VA = "0x1EA03C0", Slot = "109")]
	public override void SetStatusController(MonsterStatusBase statusController)
	{
	}

	// Token: 0x06002B09 RID: 11017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600243F")]
	[Address(RVA = "0x1EA0430", Offset = "0x1EA0531", VA = "0x1EA0430", Slot = "153")]
	protected override void OnUseItem(ItemData item)
	{
	}

	// Token: 0x06002B0A RID: 11018 RVA: 0x00010770 File Offset: 0x0000E970
	[Token(Token = "0x6002440")]
	[Address(RVA = "0x1EA05C0", Offset = "0x1EA06C1", VA = "0x1EA05C0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x06002B0B RID: 11019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002441")]
	[Address(RVA = "0x1EA08E0", Offset = "0x1EA09E1", VA = "0x1EA08E0")]
	public ChiroriController()
	{
	}

	// Token: 0x040072A9 RID: 29353
	[Token(Token = "0x4006A1C")]
	private const int MaxHp = 4;

	// Token: 0x040072AA RID: 29354
	[Token(Token = "0x4006A1D")]
	private const int JubaitetuPercent = 32;
}
