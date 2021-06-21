using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000204 RID: 516
[Token(Token = "0x20001A0")]
public abstract class GrappleController : MonoBehaviour
{
	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00005400 File Offset: 0x00003600
	// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C8")]
	public bool IsGrappling
	{
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1FF5A10", Offset = "0x1FF5B11", VA = "0x1FF5A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B0D0", Offset = "0x19B1D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1FF5A20", Offset = "0x1FF5B21", VA = "0x1FF5A20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B0E0", Offset = "0x19B1E1")]
		protected set
		{
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00005418 File Offset: 0x00003618
	// (set) Token: 0x06000A96 RID: 2710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001C9")]
	public bool IsAttached
	{
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1FF5A30", Offset = "0x1FF5B31", VA = "0x1FF5A30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B0F0", Offset = "0x19B1F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1FF5A40", Offset = "0x1FF5B41", VA = "0x1FF5A40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B100", Offset = "0x19B201")]
		protected set
		{
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CA")]
	public GrapInterface Target
	{
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1FF5A50", Offset = "0x1FF5B51", VA = "0x1FF5A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B110", Offset = "0x19B211")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1FF5A60", Offset = "0x1FF5B61", VA = "0x1FF5A60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B120", Offset = "0x19B221")]
		protected set
		{
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CB")]
	public Collider TargetCollider
	{
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1FF5A70", Offset = "0x1FF5B71", VA = "0x1FF5A70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B130", Offset = "0x19B231")]
		get
		{
			return null;
		}
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1FF5A80", Offset = "0x1FF5B81", VA = "0x1FF5A80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B140", Offset = "0x19B241")]
		protected set
		{
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00005430 File Offset: 0x00003630
	// (set) Token: 0x06000A9C RID: 2716 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CC")]
	public bool IsThrowing
	{
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1FF5A90", Offset = "0x1FF5B91", VA = "0x1FF5A90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B150", Offset = "0x19B251")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1FF5AA0", Offset = "0x1FF5BA1", VA = "0x1FF5AA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B160", Offset = "0x19B261")]
		protected set
		{
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00005448 File Offset: 0x00003648
	// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001CD")]
	public float DirectionRate
	{
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1FF5AB0", Offset = "0x1FF5BB1", VA = "0x1FF5AB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B170", Offset = "0x19B271")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1FF5AC0", Offset = "0x1FF5BC1", VA = "0x1FF5AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B180", Offset = "0x19B281")]
		set
		{
		}
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x1FF5AD0", Offset = "0x1FF5BD1", VA = "0x1FF5AD0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000950")]
	[Address(RVA = "0x1FF5BE0", Offset = "0x1FF5CE1", VA = "0x1FF5BE0", Slot = "5")]
	public virtual void Setup()
	{
	}

	// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000951")]
	[Address(RVA = "0x1FF5BF0", Offset = "0x1FF5CF1", VA = "0x1FF5BF0", Slot = "6")]
	protected virtual void DoEnd()
	{
	}

	// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000952")]
	[Address(RVA = "0x1FF5E60", Offset = "0x1FF5F61", VA = "0x1FF5E60", Slot = "7")]
	public virtual void DoCancel()
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x00005460 File Offset: 0x00003660
	[Token(Token = "0x6000953")]
	[Address(RVA = "0x1FF5E80", Offset = "0x1FF5F81", VA = "0x1FF5E80", Slot = "8")]
	public virtual bool DoAttach()
	{
		return default(bool);
	}

	// Token: 0x06000AA4 RID: 2724
	[Token(Token = "0x6000954")]
	protected abstract void ResetThrowPosition();

	// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000955")]
	[Address(RVA = "0x1FF5EA0", Offset = "0x1FF5FA1", VA = "0x1FF5EA0", Slot = "10")]
	public virtual void DoRelease()
	{
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x00005478 File Offset: 0x00003678
	[Token(Token = "0x6000956")]
	[Address(RVA = "0x1FF6070", Offset = "0x1FF6171", VA = "0x1FF6070", Slot = "11")]
	public virtual bool DoGrap(GrapInterface target)
	{
		return default(bool);
	}

	// Token: 0x06000AA7 RID: 2727
	[Token(Token = "0x6000957")]
	public abstract void DoThrow(float angle, float power, MagicParamID id1, MagicParamID id2 = MagicParamID.EMPTY);

	// Token: 0x06000AA8 RID: 2728
	[Token(Token = "0x6000958")]
	public abstract void DoPound();

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000959")]
	[Address(RVA = "0x1FF6220", Offset = "0x1FF6321", VA = "0x1FF6220", Slot = "14")]
	public virtual void OnThrowEnd()
	{
	}

	// Token: 0x06000AAA RID: 2730
	[Token(Token = "0x600095A")]
	public abstract void DoFlung();

	// Token: 0x06000AAB RID: 2731
	[Token(Token = "0x600095B")]
	public abstract void DoSwing();

	// Token: 0x06000AAC RID: 2732
	[Token(Token = "0x600095C")]
	public abstract void DoSlam();

	// Token: 0x06000AAD RID: 2733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095D")]
	[Address(RVA = "0x1FF6230", Offset = "0x1FF6331", VA = "0x1FF6230", Slot = "18")]
	public virtual void UpdateTargetPosition()
	{
	}

	// Token: 0x06000AAE RID: 2734
	[Token(Token = "0x600095E")]
	public abstract void TakeDamage(MagicParamID id);

	// Token: 0x06000AAF RID: 2735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600095F")]
	[Address(RVA = "0x1FF65E0", Offset = "0x1FF66E1", VA = "0x1FF65E0", Slot = "20")]
	protected virtual void OnTakeDamage(DamageInfo damageInfo, DamageResult damageResult)
	{
	}

	// Token: 0x06000AB0 RID: 2736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000960")]
	[Address(RVA = "0x1FF6600", Offset = "0x1FF6701", VA = "0x1FF6600")]
	protected GrappleController()
	{
	}

	// Token: 0x040006A3 RID: 1699
	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Collider m_collider;

	// Token: 0x040006A4 RID: 1700
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected List<Transform> m_hands;

	// Token: 0x040006A5 RID: 1701
	[Token(Token = "0x400054A")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D290", Offset = "0x15D391")]
	private bool <IsGrappling>k__BackingField;

	// Token: 0x040006A6 RID: 1702
	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x29")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D2A0", Offset = "0x15D3A1")]
	private bool <IsAttached>k__BackingField;

	// Token: 0x040006A7 RID: 1703
	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D2B0", Offset = "0x15D3B1")]
	private GrapInterface <Target>k__BackingField;

	// Token: 0x040006A8 RID: 1704
	[Token(Token = "0x400054D")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D2C0", Offset = "0x15D3C1")]
	private Collider <TargetCollider>k__BackingField;

	// Token: 0x040006A9 RID: 1705
	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D2D0", Offset = "0x15D3D1")]
	private bool <IsThrowing>k__BackingField;

	// Token: 0x040006AA RID: 1706
	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D2E0", Offset = "0x15D3E1")]
	private float <DirectionRate>k__BackingField;
}
