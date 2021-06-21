using System;
using Il2CppDummyDll;

// Token: 0x0200024E RID: 590
[Token(Token = "0x20001DA")]
public class HumanRestraintController : CharaRestraintController<HumanController>
{
	// Token: 0x06000E60 RID: 3680 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x2227790", Offset = "0x2227891", VA = "0x2227790", Slot = "6")]
	public override void Setup()
	{
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x2227A10", Offset = "0x2227B11", VA = "0x2227A10", Slot = "8")]
	public override void OnRestraint()
	{
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x2227B00", Offset = "0x2227C01", VA = "0x2227B00", Slot = "9")]
	public override void OnRelease()
	{
	}

	// Token: 0x06000E63 RID: 3683 RVA: 0x00006858 File Offset: 0x00004A58
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x2227B70", Offset = "0x2227C71", VA = "0x2227B70", Slot = "11")]
	protected override bool ReleaseCondition()
	{
		return default(bool);
	}

	// Token: 0x06000E64 RID: 3684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x2227BD0", Offset = "0x2227CD1", VA = "0x2227BD0")]
	public HumanRestraintController()
	{
	}

	// Token: 0x04000848 RID: 2120
	[Token(Token = "0x40006AF")]
	private const float EffectScale = 1f;

	// Token: 0x04000849 RID: 2121
	[Token(Token = "0x40006B0")]
	[FieldOffset(Offset = "0x3C")]
	private float m_animatorSpeed;
}
