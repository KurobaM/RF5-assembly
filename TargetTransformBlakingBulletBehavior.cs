using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200090C RID: 2316
[Token(Token = "0x2000614")]
public class TargetTransformBlakingBulletBehavior : ProjectileBulletBehaviorBase
{
	// Token: 0x06003CB7 RID: 15543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600330B")]
	[Address(RVA = "0x1F5E8D0", Offset = "0x1F5E9D1", VA = "0x1F5E8D0")]
	public TargetTransformBlakingBulletBehavior(Transform targetTransform)
	{
	}

	// Token: 0x06003CB8 RID: 15544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600330C")]
	[Address(RVA = "0x1F5E9B0", Offset = "0x1F5EAB1", VA = "0x1F5E9B0", Slot = "6")]
	public override void Setup(ProjectileBulletBase projectileBulletBase)
	{
	}

	// Token: 0x06003CB9 RID: 15545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600330D")]
	[Address(RVA = "0x1F5EAE0", Offset = "0x1F5EBE1", VA = "0x1F5EAE0", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x04007F1D RID: 32541
	[Token(Token = "0x40072C2")]
	private const float NEAERANGE = 1f;

	// Token: 0x04007F1E RID: 32542
	[Token(Token = "0x40072C3")]
	[FieldOffset(Offset = "0x18")]
	private bool IsNear;

	// Token: 0x04007F1F RID: 32543
	[Token(Token = "0x40072C4")]
	[FieldOffset(Offset = "0x20")]
	private ProjectileBulletBase Projectile;

	// Token: 0x04007F20 RID: 32544
	[Token(Token = "0x40072C5")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 TargetPosition;
}
