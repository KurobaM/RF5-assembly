using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000902 RID: 2306
[Token(Token = "0x200060C")]
public class CurveBulletBehavior : ProjectileBulletBehaviorBase
{
	// Token: 0x06003C94 RID: 15508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032EA")]
	[Address(RVA = "0x20EE1C0", Offset = "0x20EE2C1", VA = "0x20EE1C0")]
	public CurveBulletBehavior(Vector3 rot)
	{
	}

	// Token: 0x06003C95 RID: 15509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032EB")]
	[Address(RVA = "0x20EE270", Offset = "0x20EE371", VA = "0x20EE270", Slot = "10")]
	public override void UpdateVelocity()
	{
	}

	// Token: 0x04007EF1 RID: 32497
	[Token(Token = "0x400729C")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 CurveRot;
}
