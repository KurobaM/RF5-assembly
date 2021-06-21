using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000B29 RID: 2857
[Token(Token = "0x2000774")]
public class AttackCollider : MonoBehaviour
{
	// Token: 0x170009C7 RID: 2503
	// (get) Token: 0x060049D1 RID: 18897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170007C9")]
	private Collider Collider
	{
		[Token(Token = "0x6003DC3")]
		[Address(RVA = "0x2444780", Offset = "0x2444881", VA = "0x2444780")]
		get
		{
			return null;
		}
	}

	// Token: 0x170009C8 RID: 2504
	// (get) Token: 0x060049D2 RID: 18898 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060049D3 RID: 18899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170007CA")]
	public List<CharacterBase> HitList
	{
		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x2444850", Offset = "0x2444951", VA = "0x2444850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8A90", Offset = "0x1A8B91")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x2444860", Offset = "0x2444961", VA = "0x2444860")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A8AA0", Offset = "0x1A8BA1")]
		set
		{
		}
	}

	// Token: 0x060049D4 RID: 18900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DC6")]
	[Address(RVA = "0x2444870", Offset = "0x2444971", VA = "0x2444870")]
	private void Start()
	{
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DC7")]
	[Address(RVA = "0x2444A50", Offset = "0x2444B51", VA = "0x2444A50")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DC8")]
	[Address(RVA = "0x2444C20", Offset = "0x2444D21", VA = "0x2444C20")]
	public void SetColliderEnable(bool enable)
	{
	}

	// Token: 0x060049D7 RID: 18903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003DC9")]
	[Address(RVA = "0x2444C50", Offset = "0x2444D51", VA = "0x2444C50")]
	public AttackCollider()
	{
	}

	// Token: 0x0400A9AB RID: 43435
	[Token(Token = "0x4007FD7")]
	[FieldOffset(Offset = "0x18")]
	public OnAttackCollisionEvent TriggerEnter;

	// Token: 0x0400A9AC RID: 43436
	[Token(Token = "0x4007FD8")]
	[FieldOffset(Offset = "0x20")]
	private Collider _Collider;

	// Token: 0x0400A9AD RID: 43437
	[Token(Token = "0x4007FD9")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody Rigidbody;

	// Token: 0x0400A9AE RID: 43438
	[Token(Token = "0x4007FDA")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1746C0", Offset = "0x1747C1")]
	private List<CharacterBase> <HitList>k__BackingField;
}
