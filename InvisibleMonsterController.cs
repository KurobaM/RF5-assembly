using System;
using Il2CppDummyDll;

// Token: 0x02000716 RID: 1814
[Token(Token = "0x20004F5")]
public class InvisibleMonsterController : MonsterControllerBase
{
	// Token: 0x170006BF RID: 1727
	// (get) Token: 0x06002DBD RID: 11709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000561")]
	private SimpleHpBar SimpleHpBar
	{
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x2234C40", Offset = "0x2234D41", VA = "0x2234C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x170006C0 RID: 1728
	// (get) Token: 0x06002DBE RID: 11710 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000562")]
	private BadStatusEffectController BadStatusEffectController
	{
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x2234CF0", Offset = "0x2234DF1", VA = "0x2234CF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002694")]
	[Address(RVA = "0x2234DA0", Offset = "0x2234EA1", VA = "0x2234DA0", Slot = "109")]
	public override void SetStatusController(MonsterStatusBase statusController)
	{
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002695")]
	[Address(RVA = "0x2234E00", Offset = "0x2234F01", VA = "0x2234E00")]
	private void EndInvisible()
	{
	}

	// Token: 0x06002DC1 RID: 11713 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002696")]
	[Address(RVA = "0x2235060", Offset = "0x2235161", VA = "0x2235060", Slot = "140")]
	protected override void OnStartClearFadeOut()
	{
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002697")]
	[Address(RVA = "0x2235070", Offset = "0x2235171", VA = "0x2235070", Slot = "128")]
	protected override void OnDeadEvent()
	{
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x00010BA8 File Offset: 0x0000EDA8
	[Token(Token = "0x6002698")]
	[Address(RVA = "0x22350A0", Offset = "0x22351A1", VA = "0x22350A0")]
	private bool IsInvisible()
	{
		return default(bool);
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002699")]
	[Address(RVA = "0x2235250", Offset = "0x2235351", VA = "0x2235250")]
	private void UpdateInvisible()
	{
	}

	// Token: 0x06002DC5 RID: 11717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600269A")]
	[Address(RVA = "0x2235550", Offset = "0x2235651", VA = "0x2235550", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x06002DC6 RID: 11718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600269B")]
	[Address(RVA = "0x2235590", Offset = "0x2235691", VA = "0x2235590")]
	public InvisibleMonsterController()
	{
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600269C")]
	[Address(RVA = "0x2235600", Offset = "0x2235701", VA = "0x2235600")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A35A0", Offset = "0x1A36A1")]
	private void <UpdateInvisible>b__13_0()
	{
	}

	// Token: 0x0400741E RID: 29726
	[Token(Token = "0x4006AFD")]
	private const float InvisibleVelocity = 0.1f;

	// Token: 0x0400741F RID: 29727
	[Token(Token = "0x4006AFE")]
	[FieldOffset(Offset = "0x4E8")]
	private bool CanInvisible;

	// Token: 0x04007420 RID: 29728
	[Token(Token = "0x4006AFF")]
	[FieldOffset(Offset = "0x4F0")]
	private SimpleHpBar _SimpleHpBar;

	// Token: 0x04007421 RID: 29729
	[Token(Token = "0x4006B00")]
	[FieldOffset(Offset = "0x4F8")]
	private BadStatusEffectController _BadStatusEffectController;
}
