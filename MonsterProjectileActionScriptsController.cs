using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B7 RID: 183
[Token(Token = "0x200008D")]
public class MonsterProjectileActionScriptsController : MonsterActionScriptsControllerBase
{
	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000A4")]
	public override Character Character
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1E6EA60", Offset = "0x1E6EB61", VA = "0x1E6EA60", Slot = "4")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x1E6EA70", Offset = "0x1E6EB71", VA = "0x1E6EA70", Slot = "9")]
	protected override void OnDestroy()
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x1E6EAF0", Offset = "0x1E6EBF1", VA = "0x1E6EAF0", Slot = "24")]
	public override void SetActionCodeDataTableArray(MonsterActionCodeDataTableArray array)
	{
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x1E6EB30", Offset = "0x1E6EC31", VA = "0x1E6EB30", Slot = "27")]
	public virtual void SetupActionCode(string actionCodeName, Vector2 directionBlurAngle)
	{
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x1E6EC60", Offset = "0x1E6ED61", VA = "0x1E6EC60")]
	public void SetupProjectile(Vector2 directionBlurAngle)
	{
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x1E6EE80", Offset = "0x1E6EF81", VA = "0x1E6EE80", Slot = "12")]
	public override void DoAction(ActionCode actionCode)
	{
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x1E6EE90", Offset = "0x1E6EF91", VA = "0x1E6EE90", Slot = "13")]
	public override void StopAction()
	{
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x1E6EF20", Offset = "0x1E6F021", VA = "0x1E6EF20", Slot = "10")]
	protected override ActionCommandBase DataTableToCommandClass(ActionCommandDataTable actionCommandDataTable)
	{
		return null;
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x1E6F040", Offset = "0x1E6F141", VA = "0x1E6F040")]
	public void OnHit(CharacterBase characterBase, int actionIndex)
	{
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x1E6F0E0", Offset = "0x1E6F1E1", VA = "0x1E6F0E0")]
	public void OnHitGround(Collider collider)
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x1E6F170", Offset = "0x1E6F271", VA = "0x1E6F170")]
	public MonsterProjectileActionScriptsController()
	{
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x1E6F210", Offset = "0x1E6F311", VA = "0x1E6F210")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A130", Offset = "0x19A231")]
	private void <SetupProjectile>b__10_0()
	{
	}

	// Token: 0x04000249 RID: 585
	[Token(Token = "0x40001C4")]
	[FieldOffset(Offset = "0x180")]
	public Character Causer;

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x40001C5")]
	[FieldOffset(Offset = "0x188")]
	public Collider TargetCollider;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x40001C6")]
	[FieldOffset(Offset = "0x190")]
	public ProjectileBulletBase ProjectileBulletBase;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x198")]
	public UnityEventCollider OnHitProjectileEvent;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x1A0")]
	public UnityEventCollider OnHitGroundProjectileEvent;
}
