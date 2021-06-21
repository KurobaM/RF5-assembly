using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000900 RID: 2304
[Token(Token = "0x200060A")]
public class ProjectileBulletBehaviorTargetBase : ProjectileBulletBehaviorBase
{
	// Token: 0x06003C8B RID: 15499 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032E1")]
	[Address(RVA = "0x216FCF0", Offset = "0x216FDF1", VA = "0x216FCF0")]
	public ProjectileBulletBehaviorTargetBase(Collider targetCollider)
	{
	}

	// Token: 0x06003C8C RID: 15500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x216FD30", Offset = "0x216FE31", VA = "0x216FD30", Slot = "12")]
	protected virtual void UpdateTargetPosition()
	{
	}

	// Token: 0x06003C8D RID: 15501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032E3")]
	[Address(RVA = "0x216FE10", Offset = "0x216FF11", VA = "0x216FE10", Slot = "13")]
	public virtual void SetTargetPosition(Vector3 position)
	{
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032E4")]
	[Address(RVA = "0x216FE30", Offset = "0x216FF31", VA = "0x216FE30", Slot = "14")]
	public virtual void ResetTargetPosition()
	{
	}

	// Token: 0x06003C8F RID: 15503 RVA: 0x00015198 File Offset: 0x00013398
	[Token(Token = "0x60032E5")]
	[Address(RVA = "0x216FE40", Offset = "0x216FF41", VA = "0x216FE40")]
	protected Vector3 GetTargetDirection()
	{
		return default(Vector3);
	}

	// Token: 0x04007EEE RID: 32494
	[Token(Token = "0x4007299")]
	[FieldOffset(Offset = "0x18")]
	protected Collider TargetCollider;

	// Token: 0x04007EEF RID: 32495
	[Token(Token = "0x400729A")]
	[FieldOffset(Offset = "0x20")]
	protected Vector3 TargetPosition;

	// Token: 0x04007EF0 RID: 32496
	[Token(Token = "0x400729B")]
	[FieldOffset(Offset = "0x2C")]
	private bool IsSetTargetPostion;
}
