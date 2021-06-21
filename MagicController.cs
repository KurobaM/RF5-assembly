using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000208 RID: 520
[Token(Token = "0x20001A4")]
public abstract class MagicController : MonoBehaviour
{
	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x000054D8 File Offset: 0x000036D8
	[Token(Token = "0x170001CF")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1F12000", Offset = "0x1F12101", VA = "0x1F12000")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001D0")]
	public List<Collider> Targets
	{
		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1F12070", Offset = "0x1F12171", VA = "0x1F12070")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x000054F0 File Offset: 0x000036F0
	// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001D1")]
	public bool IsBulletExtension
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x1F12080", Offset = "0x1F12181", VA = "0x1F12080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B190", Offset = "0x19B291")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x1F12090", Offset = "0x1F12191", VA = "0x1F12090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B1A0", Offset = "0x19B2A1")]
		protected set
		{
		}
	}

	// Token: 0x06000ACB RID: 2763 RVA: 0x00005508 File Offset: 0x00003708
	[Token(Token = "0x600097B")]
	[Address(RVA = "0x1F120A0", Offset = "0x1F121A1", VA = "0x1F120A0", Slot = "4")]
	public virtual bool CanPlay()
	{
		return default(bool);
	}

	// Token: 0x06000ACC RID: 2764 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097C")]
	[Address(RVA = "0x1F120B0", Offset = "0x1F121B1", VA = "0x1F120B0", Slot = "5")]
	public virtual void OnUpdate()
	{
	}

	// Token: 0x06000ACD RID: 2765 RVA: 0x00005520 File Offset: 0x00003720
	[Token(Token = "0x600097D")]
	[Address(RVA = "0x1F121A0", Offset = "0x1F122A1", VA = "0x1F121A0", Slot = "6")]
	public virtual bool DoPlay(MagicID magicId, int level, AttackAttribute attribute, Vector3 offset)
	{
		return default(bool);
	}

	// Token: 0x06000ACE RID: 2766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600097E")]
	[Address(RVA = "0x1F121B0", Offset = "0x1F122B1", VA = "0x1F121B0", Slot = "7")]
	public virtual void DoStop()
	{
	}

	// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600097F")]
	[Address(RVA = "0x1F12290", Offset = "0x1F12391", VA = "0x1F12290", Slot = "8")]
	public virtual List<Collider> GetTargets()
	{
		return null;
	}

	// Token: 0x06000AD0 RID: 2768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000980")]
	[Address(RVA = "0x1F122A0", Offset = "0x1F123A1", VA = "0x1F122A0", Slot = "9")]
	public virtual void ClearBullet()
	{
	}

	// Token: 0x06000AD1 RID: 2769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000981")]
	[Address(RVA = "0x1F12420", Offset = "0x1F12521", VA = "0x1F12420", Slot = "10")]
	public virtual void AddBullet(BulletBase bullet)
	{
	}

	// Token: 0x06000AD2 RID: 2770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000982")]
	[Address(RVA = "0x1F124A0", Offset = "0x1F125A1", VA = "0x1F124A0")]
	public void StartBulletExtension()
	{
	}

	// Token: 0x06000AD3 RID: 2771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000983")]
	[Address(RVA = "0x1F12280", Offset = "0x1F12381", VA = "0x1F12280")]
	public void StopBulletExtension()
	{
	}

	// Token: 0x06000AD4 RID: 2772 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000984")]
	[Address(RVA = "0x1F124B0", Offset = "0x1F125B1", VA = "0x1F124B0")]
	protected MagicController()
	{
	}

	// Token: 0x040006B0 RID: 1712
	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected List<Collider> m_Targets;

	// Token: 0x040006B1 RID: 1713
	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x20")]
	protected List<CharacterBase> m_TargetCharas;

	// Token: 0x040006B2 RID: 1714
	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x28")]
	protected AS_MagicController m_Spawner;

	// Token: 0x040006B3 RID: 1715
	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x30")]
	protected float elapsed;

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x34")]
	protected float minDuration;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x38")]
	protected float maxDuration;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x40")]
	private List<BulletBase> bulletList;

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D330", Offset = "0x15D431")]
	private bool <IsBulletExtension>k__BackingField;
}
