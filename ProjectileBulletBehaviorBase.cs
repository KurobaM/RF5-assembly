using System;
using Il2CppDummyDll;

// Token: 0x020008FF RID: 2303
[Token(Token = "0x2000609")]
public class ProjectileBulletBehaviorBase
{
	// Token: 0x06003C82 RID: 15490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D8")]
	[Address(RVA = "0x216FB80", Offset = "0x216FC81", VA = "0x216FB80", Slot = "4")]
	public virtual void OnHit()
	{
	}

	// Token: 0x06003C83 RID: 15491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x216FB90", Offset = "0x216FC91", VA = "0x216FB90", Slot = "5")]
	public virtual void OnHitGround()
	{
	}

	// Token: 0x06003C84 RID: 15492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x216FBA0", Offset = "0x216FCA1", VA = "0x216FBA0", Slot = "6")]
	public virtual void Setup(ProjectileBulletBase projectileBulletBase)
	{
	}

	// Token: 0x06003C85 RID: 15493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x216FBB0", Offset = "0x216FCB1", VA = "0x216FBB0", Slot = "7")]
	public virtual void Start()
	{
	}

	// Token: 0x06003C86 RID: 15494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x216FBC0", Offset = "0x216FCC1", VA = "0x216FBC0", Slot = "8")]
	public virtual void BeginUpdate()
	{
	}

	// Token: 0x06003C87 RID: 15495 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x216FC00", Offset = "0x216FD01", VA = "0x216FC00", Slot = "9")]
	public virtual void EndUpdate()
	{
	}

	// Token: 0x06003C88 RID: 15496 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x216FC10", Offset = "0x216FD11", VA = "0x216FC10", Slot = "10")]
	public virtual void UpdateVelocity()
	{
	}

	// Token: 0x06003C89 RID: 15497 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x216FCC0", Offset = "0x216FDC1", VA = "0x216FCC0", Slot = "11")]
	public virtual void UpdateRotationByVelocity()
	{
	}

	// Token: 0x06003C8A RID: 15498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x216FCE0", Offset = "0x216FDE1", VA = "0x216FCE0")]
	public ProjectileBulletBehaviorBase()
	{
	}

	// Token: 0x04007EED RID: 32493
	[Token(Token = "0x4007298")]
	[FieldOffset(Offset = "0x10")]
	protected ProjectileBulletBase ProjectileBulletBase;
}
