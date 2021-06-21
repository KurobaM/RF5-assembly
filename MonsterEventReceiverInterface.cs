using System;
using Define;
using Il2CppDummyDll;

// Token: 0x020007DC RID: 2012
[Token(Token = "0x2000535")]
public interface MonsterEventReceiverInterface
{
	// Token: 0x06003488 RID: 13448
	[Token(Token = "0x6002BAA")]
	void TameStart();

	// Token: 0x06003489 RID: 13449
	[Token(Token = "0x6002BAB")]
	void TameEnd();

	// Token: 0x0600348A RID: 13450
	[Token(Token = "0x6002BAC")]
	void OnRestraint();

	// Token: 0x0600348B RID: 13451
	[Token(Token = "0x6002BAD")]
	void OnRelease();

	// Token: 0x0600348C RID: 13452
	[Token(Token = "0x6002BAE")]
	void OnHearFootSteps();

	// Token: 0x0600348D RID: 13453
	[Token(Token = "0x6002BAF")]
	void OnHitAttack();

	// Token: 0x0600348E RID: 13454
	[Token(Token = "0x6002BB0")]
	void BeforeTakeDamage(ref DamageInfo damageInfo);

	// Token: 0x0600348F RID: 13455
	[Token(Token = "0x6002BB1")]
	void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult);

	// Token: 0x06003490 RID: 13456
	[Token(Token = "0x6002BB2")]
	void OnChangeModel();

	// Token: 0x06003491 RID: 13457
	[Token(Token = "0x6002BB3")]
	void OnFreeze();

	// Token: 0x06003492 RID: 13458
	[Token(Token = "0x6002BB4")]
	void OnBlow();

	// Token: 0x06003493 RID: 13459
	[Token(Token = "0x6002BB5")]
	void OnKnockBack();

	// Token: 0x06003494 RID: 13460
	[Token(Token = "0x6002BB6")]
	void OnDead();

	// Token: 0x06003495 RID: 13461
	[Token(Token = "0x6002BB7")]
	void OnBadStatus(BadStatus badStatus, bool isEnable);

	// Token: 0x06003496 RID: 13462
	[Token(Token = "0x6002BB8")]
	void OnEndActionScript();

	// Token: 0x06003497 RID: 13463
	[Token(Token = "0x6002BB9")]
	void OnEndAnimEventDamageState();

	// Token: 0x06003498 RID: 13464
	[Token(Token = "0x6002BBA")]
	void OnEndAnimEventDeadState();

	// Token: 0x06003499 RID: 13465
	[Token(Token = "0x6002BBB")]
	void OnEndAnimEventGetupState();

	// Token: 0x0600349A RID: 13466
	[Token(Token = "0x6002BBC")]
	void OnEndAnimEventJumpStart();

	// Token: 0x0600349B RID: 13467
	[Token(Token = "0x6002BBD")]
	void OnEndAnimEventJumpEnd();

	// Token: 0x0600349C RID: 13468
	[Token(Token = "0x6002BBE")]
	void OnEndAnimEventMadnessState();

	// Token: 0x0600349D RID: 13469
	[Token(Token = "0x6002BBF")]
	void OnEndAnimEventHappyState();

	// Token: 0x0600349E RID: 13470
	[Token(Token = "0x6002BC0")]
	void OnEndAnimEventWait_2State();

	// Token: 0x0600349F RID: 13471
	[Token(Token = "0x6002BC1")]
	void OnEndAnimEventSleepStart();

	// Token: 0x060034A0 RID: 13472
	[Token(Token = "0x6002BC2")]
	void OnEndAnimEventSleepEnd();
}
