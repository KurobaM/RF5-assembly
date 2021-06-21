using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000906 RID: 2310
[Token(Token = "0x2000610")]
public class MoveTransformStraightProjectilleBulletBehavior : ProjectileBulletBehaviorBase
{
	// Token: 0x06003CA8 RID: 15528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032FE")]
	[Address(RVA = "0x1E117B0", Offset = "0x1E118B1", VA = "0x1E117B0")]
	public MoveTransformStraightProjectilleBulletBehavior(Transform moveTransform, Transform targetCharacterTransform, float duration, float endSpeed, float waitTime)
	{
	}

	// Token: 0x06003CA9 RID: 15529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032FF")]
	[Address(RVA = "0x1E118D0", Offset = "0x1E119D1", VA = "0x1E118D0", Slot = "6")]
	public override void Setup(ProjectileBulletBase projectileBulletBase)
	{
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003300")]
	[Address(RVA = "0x1E119F0", Offset = "0x1E11AF1", VA = "0x1E119F0", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x04007F0A RID: 32522
	[Token(Token = "0x40072B5")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 MovePosition;

	// Token: 0x04007F0B RID: 32523
	[Token(Token = "0x40072B6")]
	[FieldOffset(Offset = "0x24")]
	private float Duration;

	// Token: 0x04007F0C RID: 32524
	[Token(Token = "0x40072B7")]
	[FieldOffset(Offset = "0x28")]
	private float EndSpeed;

	// Token: 0x04007F0D RID: 32525
	[Token(Token = "0x40072B8")]
	[FieldOffset(Offset = "0x2C")]
	private float WaitTime;

	// Token: 0x04007F0E RID: 32526
	[Token(Token = "0x40072B9")]
	[FieldOffset(Offset = "0x30")]
	private MoveTransformStraightProjectilleBulletBehavior.State IsWait;

	// Token: 0x04007F0F RID: 32527
	[Token(Token = "0x40072BA")]
	[FieldOffset(Offset = "0x38")]
	private Transform TargetCharacterTransform;

	// Token: 0x02000907 RID: 2311
	[Token(Token = "0x2001279")]
	private enum State
	{
		// Token: 0x04007F11 RID: 32529
		[Token(Token = "0x40198BB")]
		Init,
		// Token: 0x04007F12 RID: 32530
		[Token(Token = "0x40198BC")]
		Waiting,
		// Token: 0x04007F13 RID: 32531
		[Token(Token = "0x40198BD")]
		Update
	}

	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x200127A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158DD0", Offset = "0x158ED1")]
	private sealed class <>c__DisplayClass8_0
	{
		// Token: 0x06003CAB RID: 15531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007491")]
		[Address(RVA = "0x1E119E0", Offset = "0x1E11AE1", VA = "0x1E119E0")]
		public <>c__DisplayClass8_0()
		{
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007492")]
		[Address(RVA = "0x1E11B50", Offset = "0x1E11C51", VA = "0x1E11B50")]
		internal void <Setup>b__0()
		{
		}

		// Token: 0x04007F14 RID: 32532
		[Token(Token = "0x40198BE")]
		[FieldOffset(Offset = "0x10")]
		public ProjectileBulletBase projectileBulletBase;

		// Token: 0x04007F15 RID: 32533
		[Token(Token = "0x40198BF")]
		[FieldOffset(Offset = "0x18")]
		public MoveTransformStraightProjectilleBulletBehavior <>4__this;
	}
}
