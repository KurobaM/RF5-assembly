using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022D RID: 557
[Token(Token = "0x20001BF")]
public abstract class CharaGrantAttributeController<T> : GrantAttributeController where T : Character
{
	// Token: 0x1700027C RID: 636
	// (get) Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700025C")]
	protected override Transform EffectPoint
	{
		[Token(Token = "0x6000B7F")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00006258 File Offset: 0x00004458
	[Token(Token = "0x1700025D")]
	protected override float EffectScale
	{
		[Token(Token = "0x6000B80")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000CDF RID: 3295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B81")]
	protected void Awake()
	{
	}

	// Token: 0x06000CE0 RID: 3296 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B82")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000CE1 RID: 3297 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B83")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06000CE2 RID: 3298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B84")]
	protected CharaGrantAttributeController()
	{
	}

	// Token: 0x040007A8 RID: 1960
	[Token(Token = "0x4000635")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	protected T m_chara;

	// Token: 0x040007A9 RID: 1961
	[Token(Token = "0x4000636")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x15DD90", Offset = "0x15DE91")]
	protected float m_effectScale;
}
