using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200090A RID: 2314
[Token(Token = "0x2000612")]
public class RiseStraightBehavior : ProjectileBulletBehaviorBase
{
	// Token: 0x06003CAF RID: 15535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003303")]
	[Address(RVA = "0x2492FA0", Offset = "0x24930A1", VA = "0x2492FA0")]
	public RiseStraightBehavior(Collider targetCollider, float riseHeight, float riseTime)
	{
	}

	// Token: 0x06003CB0 RID: 15536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003304")]
	[Address(RVA = "0x2492FF0", Offset = "0x24930F1", VA = "0x2492FF0", Slot = "6")]
	public override void Setup(ProjectileBulletBase projectileBulletBase)
	{
	}

	// Token: 0x06003CB1 RID: 15537 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003305")]
	[Address(RVA = "0x24930C0", Offset = "0x24931C1", VA = "0x24930C0", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x06003CB2 RID: 15538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003306")]
	[Address(RVA = "0x24930E0", Offset = "0x24931E1", VA = "0x24930E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6B40", Offset = "0x1A6C41")]
	private void <Setup>b__5_0()
	{
	}

	// Token: 0x04007F16 RID: 32534
	[Token(Token = "0x40072BB")]
	[FieldOffset(Offset = "0x18")]
	private Collider TargetCollider;

	// Token: 0x04007F17 RID: 32535
	[Token(Token = "0x40072BC")]
	[FieldOffset(Offset = "0x20")]
	private bool IsRise;

	// Token: 0x04007F18 RID: 32536
	[Token(Token = "0x40072BD")]
	[FieldOffset(Offset = "0x24")]
	private float RiseHeight;

	// Token: 0x04007F19 RID: 32537
	[Token(Token = "0x40072BE")]
	[FieldOffset(Offset = "0x28")]
	private float RiseTime;
}
