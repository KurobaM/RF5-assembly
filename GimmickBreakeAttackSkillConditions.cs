using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005CD RID: 1485
[Token(Token = "0x200042D")]
public class GimmickBreakeAttackSkillConditions : GimmickBreakeConditionsBase
{
	// Token: 0x06002477 RID: 9335 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
	[Token(Token = "0x6001EBD")]
	[Address(RVA = "0x1FA8C50", Offset = "0x1FA8D51", VA = "0x1FA8C50", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage)
	{
		return default(bool);
	}

	// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0x1FA8EF0", Offset = "0x1FA8FF1", VA = "0x1FA8EF0")]
	public GimmickBreakeAttackSkillConditions()
	{
	}

	// Token: 0x04006BE2 RID: 27618
	[Token(Token = "0x4006532")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public ItemCategory[] itemCategories;

	// Token: 0x04006BE3 RID: 27619
	[Token(Token = "0x4006533")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public SkillID SkillID;

	// Token: 0x04006BE4 RID: 27620
	[Token(Token = "0x4006534")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public int SkillLevel;
}
