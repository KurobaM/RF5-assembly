using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000823 RID: 2083
[Token(Token = "0x200055F")]
public interface PartnerNPCEventReceiverInterface
{
	// Token: 0x060037A2 RID: 14242
	[Token(Token = "0x6002E57")]
	void OnChangeShortPlay(bool isEnable);

	// Token: 0x060037A3 RID: 14243
	[Token(Token = "0x6002E58")]
	void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult);

	// Token: 0x060037A4 RID: 14244
	[Token(Token = "0x6002E59")]
	void OnFreeze();

	// Token: 0x060037A5 RID: 14245
	[Token(Token = "0x6002E5A")]
	void OnBlow();

	// Token: 0x060037A6 RID: 14246
	[Token(Token = "0x6002E5B")]
	void OnKnockBack();

	// Token: 0x060037A7 RID: 14247
	[Token(Token = "0x6002E5C")]
	void OnDead();

	// Token: 0x060037A8 RID: 14248
	[Token(Token = "0x6002E5D")]
	void EndDamageAction();

	// Token: 0x060037A9 RID: 14249
	[Token(Token = "0x6002E5E")]
	void OnBadStatus(BadStatus badStatus, bool isEnable);
}
