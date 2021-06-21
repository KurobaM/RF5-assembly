using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005D0 RID: 1488
[Token(Token = "0x2000430")]
public class GimmickBreakeMushroomConditions : GimmickBreakeConditionsBase
{
	// Token: 0x0600247F RID: 9343 RVA: 0x0000EC28 File Offset: 0x0000CE28
	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x1FA9530", Offset = "0x1FA9631", VA = "0x1FA9530", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x06002480 RID: 9344 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x1FA96F0", Offset = "0x1FA97F1", VA = "0x1FA96F0")]
	public GimmickBreakeMushroomConditions()
	{
	}

	// Token: 0x04006BEA RID: 27626
	[Token(Token = "0x400653A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public int Hp;
}
