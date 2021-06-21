using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000634 RID: 1588
[Token(Token = "0x2000479")]
public interface HoldableInterface : InteractionInterface, FocusInterface
{
	// Token: 0x0600272F RID: 10031
	[Token(Token = "0x6002115")]
	void OnHold();

	// Token: 0x06002730 RID: 10032
	[Token(Token = "0x6002116")]
	void OnPutOn();

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x06002731 RID: 10033
	[Token(Token = "0x170004FC")]
	ThrowController ThrowController { [Token(Token = "0x6002117")] get; }

	// Token: 0x06002732 RID: 10034
	[Token(Token = "0x6002118")]
	bool CanThrow();

	// Token: 0x06002733 RID: 10035
	[Token(Token = "0x6002119")]
	void OnThrow();

	// Token: 0x06002734 RID: 10036
	[Token(Token = "0x600211A")]
	bool HitCheck(HitResult result, ThrowController throwController);

	// Token: 0x06002735 RID: 10037
	[Token(Token = "0x600211B")]
	void OnPutOnByThrow();

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x06002736 RID: 10038
	[Token(Token = "0x170004FD")]
	HoldMotionType HoldMotionType { [Token(Token = "0x600211C")] get; }

	// Token: 0x06002737 RID: 10039
	[Token(Token = "0x600211D")]
	bool CanPuton();

	// Token: 0x06002738 RID: 10040
	[Token(Token = "0x600211E")]
	bool CanRuckIn();

	// Token: 0x06002739 RID: 10041
	[Token(Token = "0x600211F")]
	bool OnTakeDamage(DamageResult result);

	// Token: 0x0600273A RID: 10042
	[Token(Token = "0x6002120")]
	ButtonInteractType GetInteractButtonType(FocusInterface focusInterface, ButtonInteractID buttonInteractID);

	// Token: 0x0600273B RID: 10043
	[Token(Token = "0x6002121")]
	void SetAlpha(float alpha);
}
