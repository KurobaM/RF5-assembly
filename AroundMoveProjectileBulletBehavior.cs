using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008FD RID: 2301
[Token(Token = "0x2000607")]
public class AroundMoveProjectileBulletBehavior : ProjectileBulletBehaviorBase
{
	// Token: 0x06003C65 RID: 15461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032BB")]
	[Address(RVA = "0x24434E0", Offset = "0x24435E1", VA = "0x24434E0")]
	public AroundMoveProjectileBulletBehavior(float length)
	{
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032BC")]
	[Address(RVA = "0x2443520", Offset = "0x2443621", VA = "0x2443520", Slot = "6")]
	public override void Setup(ProjectileBulletBase projectileBulletBase)
	{
	}

	// Token: 0x06003C67 RID: 15463 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032BD")]
	[Address(RVA = "0x24436C0", Offset = "0x24437C1", VA = "0x24436C0", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x06003C68 RID: 15464 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032BE")]
	[Address(RVA = "0x2443990", Offset = "0x2443A91", VA = "0x2443990", Slot = "10")]
	public override void UpdateVelocity()
	{
	}

	// Token: 0x04007ED4 RID: 32468
	[Token(Token = "0x400727F")]
	[FieldOffset(Offset = "0x18")]
	private float Length;

	// Token: 0x04007ED5 RID: 32469
	[Token(Token = "0x4007280")]
	[FieldOffset(Offset = "0x1C")]
	private float SwingTime;

	// Token: 0x04007ED6 RID: 32470
	[Token(Token = "0x4007281")]
	[FieldOffset(Offset = "0x20")]
	private float Elapsed;

	// Token: 0x04007ED7 RID: 32471
	[Token(Token = "0x4007282")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 PrePosition;
}
