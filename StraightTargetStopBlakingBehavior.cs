using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200090B RID: 2315
[Token(Token = "0x2000613")]
public class StraightTargetStopBlakingBehavior : ProjectileBulletBehaviorTargetBase
{
	// Token: 0x06003CB3 RID: 15539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003307")]
	[Address(RVA = "0x238BBE0", Offset = "0x238BCE1", VA = "0x238BBE0")]
	public StraightTargetStopBlakingBehavior(Collider targetCollider, float startBrakeTime, float stopTime)
	{
	}

	// Token: 0x06003CB4 RID: 15540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003308")]
	[Address(RVA = "0x238BC20", Offset = "0x238BD21", VA = "0x238BC20", Slot = "7")]
	public override void Start()
	{
	}

	// Token: 0x06003CB5 RID: 15541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003309")]
	[Address(RVA = "0x238BC90", Offset = "0x238BD91", VA = "0x238BC90", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x06003CB6 RID: 15542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600330A")]
	[Address(RVA = "0x238BCD0", Offset = "0x238BDD1", VA = "0x238BCD0", Slot = "10")]
	public override void UpdateVelocity()
	{
	}

	// Token: 0x04007F1A RID: 32538
	[Token(Token = "0x40072BF")]
	[FieldOffset(Offset = "0x30")]
	protected float StartBrakeTime;

	// Token: 0x04007F1B RID: 32539
	[Token(Token = "0x40072C0")]
	[FieldOffset(Offset = "0x34")]
	protected float StopTime;

	// Token: 0x04007F1C RID: 32540
	[Token(Token = "0x40072C1")]
	[FieldOffset(Offset = "0x38")]
	private float Timer;
}
