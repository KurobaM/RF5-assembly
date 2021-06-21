using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B33 RID: 2867
[Token(Token = "0x200077D")]
public class KyubiFireball : ProjectileBulletBase
{
	// Token: 0x06004A03 RID: 18947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DF5")]
	[Address(RVA = "0x22FA440", Offset = "0x22FA541", VA = "0x22FA440")]
	public void StartReadyAttack(Vector3 readyAttackPosition)
	{
	}

	// Token: 0x06004A04 RID: 18948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DF6")]
	[Address(RVA = "0x22FC3D0", Offset = "0x22FC4D1", VA = "0x22FC3D0")]
	private void UpdateMoveTarget()
	{
	}

	// Token: 0x06004A05 RID: 18949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DF7")]
	[Address(RVA = "0x22FC7F0", Offset = "0x22FC8F1", VA = "0x22FC7F0")]
	private void UpdateReadyAttackMove()
	{
	}

	// Token: 0x06004A06 RID: 18950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DF8")]
	[Address(RVA = "0x22FC900", Offset = "0x22FCA01", VA = "0x22FC900", Slot = "6")]
	protected override void UpdateBehavior()
	{
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DF9")]
	[Address(RVA = "0x22FC9C0", Offset = "0x22FCAC1", VA = "0x22FC9C0")]
	public KyubiFireball()
	{
	}

	// Token: 0x0400AA25 RID: 43557
	[Token(Token = "0x400804B")]
	[FieldOffset(Offset = "0x110")]
	public Collider Target;

	// Token: 0x0400AA26 RID: 43558
	[Token(Token = "0x400804C")]
	[FieldOffset(Offset = "0x118")]
	private float MaxCurve;

	// Token: 0x0400AA27 RID: 43559
	[Token(Token = "0x400804D")]
	[FieldOffset(Offset = "0x11C")]
	private float ReadyAttackTime;

	// Token: 0x0400AA28 RID: 43560
	[Token(Token = "0x400804E")]
	[FieldOffset(Offset = "0x120")]
	private bool IsReadyAttack;

	// Token: 0x0400AA29 RID: 43561
	[Token(Token = "0x400804F")]
	[FieldOffset(Offset = "0x124")]
	private Vector3 ReadyAttackPosition;

	// Token: 0x0400AA2A RID: 43562
	[Token(Token = "0x4008050")]
	[FieldOffset(Offset = "0x130")]
	private Vector3 StartPosition;

	// Token: 0x0400AA2B RID: 43563
	[Token(Token = "0x4008051")]
	[FieldOffset(Offset = "0x13C")]
	private float T;
}
