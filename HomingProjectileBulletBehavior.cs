using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000903 RID: 2307
[Token(Token = "0x200060D")]
public class HomingProjectileBulletBehavior : ProjectileBulletBehaviorTargetBase
{
	// Token: 0x06003C96 RID: 15510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032EC")]
	[Address(RVA = "0x2092FC0", Offset = "0x20930C1", VA = "0x2092FC0")]
	public HomingProjectileBulletBehavior(Collider targetCollider, float angleSpeed)
	{
	}

	// Token: 0x06003C97 RID: 15511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032ED")]
	[Address(RVA = "0x2093000", Offset = "0x2093101", VA = "0x2093000", Slot = "8")]
	public override void BeginUpdate()
	{
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032EE")]
	[Address(RVA = "0x2093040", Offset = "0x2093141", VA = "0x2093040")]
	protected void UpdateHorming()
	{
	}

	// Token: 0x04007EF2 RID: 32498
	[Token(Token = "0x400729D")]
	[FieldOffset(Offset = "0x30")]
	protected float AngleSpeed;
}
