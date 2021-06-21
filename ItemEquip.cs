using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000629 RID: 1577
[Token(Token = "0x2000473")]
public abstract class ItemEquip : MonoBehaviour
{
	// Token: 0x1700063C RID: 1596
	// (get) Token: 0x060026E8 RID: 9960 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004F6")]
	public Transform EffectPoint
	{
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x22380F0", Offset = "0x22381F1", VA = "0x22380F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020D3")]
	[Address(RVA = "0x2238100", Offset = "0x2238201", VA = "0x2238100", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x0000F558 File Offset: 0x0000D758
	[Token(Token = "0x60020D4")]
	[Address(RVA = "0x2238110", Offset = "0x2238211", VA = "0x2238110", Slot = "5")]
	public virtual bool Attach(HumanController human, HumanAttachIDEnum attachId)
	{
		return default(bool);
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x0000F570 File Offset: 0x0000D770
	[Token(Token = "0x60020D5")]
	[Address(RVA = "0x2238240", Offset = "0x2238341", VA = "0x2238240", Slot = "6")]
	public virtual bool Detach()
	{
		return default(bool);
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020D6")]
	[Address(RVA = "0x22383C0", Offset = "0x22384C1", VA = "0x22383C0")]
	public void EraseOn()
	{
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020D7")]
	[Address(RVA = "0x22384E0", Offset = "0x22385E1", VA = "0x22384E0")]
	public void EraseOff()
	{
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x0000F588 File Offset: 0x0000D788
	[Token(Token = "0x60020D8")]
	[Address(RVA = "0x2238600", Offset = "0x2238701", VA = "0x2238600")]
	public bool ReAttach()
	{
		return default(bool);
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020D9")]
	[Address(RVA = "0x2238620", Offset = "0x2238721", VA = "0x2238620", Slot = "7")]
	public virtual void SetVisible(bool visible)
	{
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020DA")]
	[Address(RVA = "0x22386B0", Offset = "0x22387B1", VA = "0x22386B0", Slot = "8")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020DB")]
	[Address(RVA = "0x22386C0", Offset = "0x22387C1", VA = "0x22386C0", Slot = "9")]
	protected virtual void OnDisable()
	{
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020DC")]
	[Address(RVA = "0x22386D0", Offset = "0x22387D1", VA = "0x22386D0", Slot = "10")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020DD")]
	[Address(RVA = "0x22386E0", Offset = "0x22387E1", VA = "0x22386E0")]
	public void Play(EffectID effectID, float scale, bool loop)
	{
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020DE")]
	[Address(RVA = "0x2238810", Offset = "0x2238911", VA = "0x2238810")]
	public void Stop()
	{
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020DF")]
	[Address(RVA = "0x2238900", Offset = "0x2238A01", VA = "0x2238900", Slot = "11")]
	public virtual void PlayEffect(int no, float scale)
	{
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E0")]
	[Address(RVA = "0x22389B0", Offset = "0x2238AB1", VA = "0x22389B0", Slot = "12")]
	public virtual void StopEffect(int no)
	{
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E1")]
	[Address(RVA = "0x22386A0", Offset = "0x22387A1", VA = "0x22386A0")]
	public void StopAllEffects()
	{
	}

	// Token: 0x1700063D RID: 1597
	// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
	[Token(Token = "0x170004F7")]
	public float FadeAlpha
	{
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x22389C0", Offset = "0x2238AC1", VA = "0x22389C0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E3")]
	[Address(RVA = "0x2238A70", Offset = "0x2238B71", VA = "0x2238A70")]
	public void SetAlpha(float alpha)
	{
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x2238B30", Offset = "0x2238C31", VA = "0x2238B30", Slot = "13")]
	public virtual void SetShadowState(ShadowCastingMode shadowCastingMode)
	{
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x2238C30", Offset = "0x2238D31", VA = "0x2238C30")]
	protected ItemEquip()
	{
	}

	// Token: 0x04006DBB RID: 28091
	[Token(Token = "0x40066A6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ItemID m_EquipItemID;

	// Token: 0x04006DBC RID: 28092
	[Token(Token = "0x40066A7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Transform m_effectPoint;

	// Token: 0x04006DBD RID: 28093
	[Token(Token = "0x40066A8")]
	[FieldOffset(Offset = "0x28")]
	private EffectID m_CurrentEffectID;

	// Token: 0x04006DBE RID: 28094
	[Token(Token = "0x40066A9")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem m_effect;

	// Token: 0x04006DBF RID: 28095
	[Token(Token = "0x40066AA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public List<EffectID> m_EffectID;

	// Token: 0x04006DC0 RID: 28096
	[Token(Token = "0x40066AB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private MeshFadeController m_FadeController;

	// Token: 0x04006DC1 RID: 28097
	[Token(Token = "0x40066AC")]
	[FieldOffset(Offset = "0x48")]
	protected HumanController m_Human;

	// Token: 0x04006DC2 RID: 28098
	[Token(Token = "0x40066AD")]
	[FieldOffset(Offset = "0x50")]
	private HumanAttachIDEnum m_AttachID;

	// Token: 0x04006DC3 RID: 28099
	[Token(Token = "0x40066AE")]
	[FieldOffset(Offset = "0x58")]
	protected Dictionary<int, ParticleSystem> m_Effects;

	// Token: 0x0200062A RID: 1578
	[Token(Token = "0x200113F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158120", Offset = "0x158221")]
	private sealed class <>c__DisplayClass21_0
	{
		// Token: 0x060026FC RID: 9980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007101")]
		[Address(RVA = "0x2238800", Offset = "0x2238901", VA = "0x2238800")]
		public <>c__DisplayClass21_0()
		{
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007102")]
		[Address(RVA = "0x2238CF0", Offset = "0x2238DF1", VA = "0x2238CF0")]
		internal void <Play>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x04006DC4 RID: 28100
		[Token(Token = "0x4019388")]
		[FieldOffset(Offset = "0x10")]
		public ItemEquip <>4__this;

		// Token: 0x04006DC5 RID: 28101
		[Token(Token = "0x4019389")]
		[FieldOffset(Offset = "0x18")]
		public EffectID effectID;

		// Token: 0x04006DC6 RID: 28102
		[Token(Token = "0x401938A")]
		[FieldOffset(Offset = "0x1C")]
		public bool loop;

		// Token: 0x04006DC7 RID: 28103
		[Token(Token = "0x401938B")]
		[FieldOffset(Offset = "0x20")]
		public float scale;
	}
}
