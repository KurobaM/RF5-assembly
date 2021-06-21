using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A8 RID: 680
[Token(Token = "0x200021A")]
public class MovementVelocity
{
	// Token: 0x17000311 RID: 785
	// (get) Token: 0x06001159 RID: 4441 RVA: 0x00007F80 File Offset: 0x00006180
	// (set) Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E7")]
	public Vector3 current
	{
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x1E11B90", Offset = "0x1E11C91", VA = "0x1E11B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C500", Offset = "0x19C601")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x1E11BA0", Offset = "0x1E11CA1", VA = "0x1E11BA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C510", Offset = "0x19C611")]
		set
		{
		}
	}

	// Token: 0x17000312 RID: 786
	// (get) Token: 0x0600115B RID: 4443 RVA: 0x00007F98 File Offset: 0x00006198
	// (set) Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002E8")]
	public float maxSpeed
	{
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x1E11BB0", Offset = "0x1E11CB1", VA = "0x1E11BB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C520", Offset = "0x19C621")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x1E11BC0", Offset = "0x1E11CC1", VA = "0x1E11BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C530", Offset = "0x19C631")]
		set
		{
		}
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCA")]
	[Address(RVA = "0x1E11BD0", Offset = "0x1E11CD1", VA = "0x1E11BD0")]
	public void ClearForce()
	{
	}

	// Token: 0x0600115E RID: 4446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCB")]
	[Address(RVA = "0x1E11C90", Offset = "0x1E11D91", VA = "0x1E11C90")]
	public void AddForce(Vector3 _force, ForceMode mode = ForceMode.Force)
	{
	}

	// Token: 0x0600115F RID: 4447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x1E11E80", Offset = "0x1E11F81", VA = "0x1E11E80")]
	public void ApplyForce(float mass, float deltaTime)
	{
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x1E12030", Offset = "0x1E12131", VA = "0x1E12030")]
	public MovementVelocity()
	{
	}

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40007AB")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15ED30", Offset = "0x15EE31")]
	private Vector3 <current>k__BackingField;

	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x40007AC")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15ED40", Offset = "0x15EE41")]
	private float <maxSpeed>k__BackingField;

	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x40007AD")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 force;

	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x40007AE")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 inpulse;

	// Token: 0x040009C6 RID: 2502
	[Token(Token = "0x40007AF")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 velocityChange;

	// Token: 0x040009C7 RID: 2503
	[Token(Token = "0x40007B0")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 acceleration;

	// Token: 0x040009C8 RID: 2504
	[Token(Token = "0x40007B1")]
	[FieldOffset(Offset = "0x50")]
	private bool isClearForce;
}
