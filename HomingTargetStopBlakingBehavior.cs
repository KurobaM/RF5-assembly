using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000904 RID: 2308
[Token(Token = "0x200060E")]
public class HomingTargetStopBlakingBehavior : HomingProjectileBulletBehavior
{
	// Token: 0x06003C99 RID: 15513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032EF")]
	[Address(RVA = "0x2093310", Offset = "0x2093411", VA = "0x2093310")]
	public HomingTargetStopBlakingBehavior(Collider targetCollider, float angleSpeed, float startBrakeTime, float stopTime)
	{
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F0")]
	[Address(RVA = "0x2093360", Offset = "0x2093461", VA = "0x2093360", Slot = "7")]
	public override void Start()
	{
	}

	// Token: 0x06003C9B RID: 15515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F1")]
	[Address(RVA = "0x2093390", Offset = "0x2093491", VA = "0x2093390", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x06003C9C RID: 15516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032F2")]
	[Address(RVA = "0x2093410", Offset = "0x2093511", VA = "0x2093410", Slot = "10")]
	public override void UpdateVelocity()
	{
	}

	// Token: 0x04007EF3 RID: 32499
	[Token(Token = "0x400729E")]
	[FieldOffset(Offset = "0x34")]
	protected float StartBrakeTime;

	// Token: 0x04007EF4 RID: 32500
	[Token(Token = "0x400729F")]
	[FieldOffset(Offset = "0x38")]
	protected float StopTime;

	// Token: 0x04007EF5 RID: 32501
	[Token(Token = "0x40072A0")]
	[FieldOffset(Offset = "0x3C")]
	private float Timer;
}
