using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000176 RID: 374
[Token(Token = "0x2000124")]
public class BulletColliderBase : MonoBehaviour
{
	// Token: 0x17000199 RID: 409
	// (get) Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000185")]
	public BulletBase Bullet
	{
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x2192BA0", Offset = "0x2192CA1", VA = "0x2192BA0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060007DF RID: 2015 RVA: 0x00004BC0 File Offset: 0x00002DC0
	// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000186")]
	public Vector3 CurrentPosition
	{
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x2192BB0", Offset = "0x2192CB1", VA = "0x2192BB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AAE0", Offset = "0x19ABE1")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x2192BC0", Offset = "0x2192CC1", VA = "0x2192BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AAF0", Offset = "0x19ABF1")]
		protected set
		{
		}
	}

	// Token: 0x1700019B RID: 411
	// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00004BD8 File Offset: 0x00002DD8
	// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000187")]
	public Vector3 PrevPosition
	{
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x2192BD0", Offset = "0x2192CD1", VA = "0x2192BD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB00", Offset = "0x19AC01")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x2192BE0", Offset = "0x2192CE1", VA = "0x2192BE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19AB10", Offset = "0x19AC11")]
		protected set
		{
		}
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x2192BF0", Offset = "0x2192CF1", VA = "0x2192BF0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x2192C80", Offset = "0x2192D81", VA = "0x2192C80", Slot = "5")]
	public virtual void OnSetup(BulletBase bullet)
	{
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x2192DE0", Offset = "0x2192EE1", VA = "0x2192DE0", Slot = "6")]
	public virtual void OnFixedUpdate(BulletBase bullet)
	{
	}

	// Token: 0x060007E6 RID: 2022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x2192E30", Offset = "0x2192F31", VA = "0x2192E30", Slot = "7")]
	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x2193240", Offset = "0x2193341", VA = "0x2193240", Slot = "8")]
	protected virtual void OnTriggerStay(Collider other)
	{
	}

	// Token: 0x060007E8 RID: 2024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x21936B0", Offset = "0x21937B1", VA = "0x21936B0")]
	public BulletColliderBase()
	{
	}

	// Token: 0x04000494 RID: 1172
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected BulletBase m_bullet;

	// Token: 0x04000495 RID: 1173
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Collider m_collider;

	// Token: 0x04000496 RID: 1174
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x15C330", Offset = "0x15C431")]
	protected LayerMask m_hitLayerMask;

	// Token: 0x04000497 RID: 1175
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C340", Offset = "0x15C441")]
	private Vector3 <CurrentPosition>k__BackingField;

	// Token: 0x04000498 RID: 1176
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15C350", Offset = "0x15C451")]
	private Vector3 <PrevPosition>k__BackingField;
}
