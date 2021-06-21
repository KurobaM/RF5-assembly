using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BA RID: 698
[Token(Token = "0x2000223")]
[Serializable]
public class HandCuffsEffect
{
	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06001240 RID: 4672 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001241 RID: 4673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030F")]
	public ParticleSystem Particle
	{
		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x24E4E30", Offset = "0x24E4F31", VA = "0x24E4E30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C6D0", Offset = "0x19C7D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x24E4E40", Offset = "0x24E4F41", VA = "0x24E4E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C6E0", Offset = "0x19C7E1")]
		private set
		{
		}
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x06001242 RID: 4674 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001243 RID: 4675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000310")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x24E4E50", Offset = "0x24E4F51", VA = "0x24E4E50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C6F0", Offset = "0x19C7F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x24E4E60", Offset = "0x24E4F61", VA = "0x24E4E60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C700", Offset = "0x19C801")]
		private set
		{
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x06001244 RID: 4676 RVA: 0x00008568 File Offset: 0x00006768
	[Token(Token = "0x17000311")]
	public EffectID EffectID
	{
		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x24E4E70", Offset = "0x24E4F71", VA = "0x24E4E70")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x06001245 RID: 4677 RVA: 0x00008580 File Offset: 0x00006780
	[Token(Token = "0x17000312")]
	public HumanJointIDEnum JointID
	{
		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x24E4E80", Offset = "0x24E4F81", VA = "0x24E4E80")]
		get
		{
			return HumanJointIDEnum.Head;
		}
	}

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x06001246 RID: 4678 RVA: 0x00008598 File Offset: 0x00006798
	[Token(Token = "0x17000313")]
	public bool IsActive
	{
		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x24E45C0", Offset = "0x24E46C1", VA = "0x24E45C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x06001248 RID: 4680 RVA: 0x000085B0 File Offset: 0x000067B0
	// (set) Token: 0x06001247 RID: 4679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000314")]
	public float Scale
	{
		[Token(Token = "0x60010AB")]
		[Address(RVA = "0x24E4EA0", Offset = "0x24E4FA1", VA = "0x24E4EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C720", Offset = "0x19C821")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x24E4E90", Offset = "0x24E4F91", VA = "0x24E4E90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C710", Offset = "0x19C811")]
		set
		{
		}
	}

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x06001249 RID: 4681 RVA: 0x000085C8 File Offset: 0x000067C8
	[Token(Token = "0x17000315")]
	public bool IsPlaying
	{
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x24E4EB0", Offset = "0x24E4FB1", VA = "0x24E4EB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600124A RID: 4682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x24E4EC0", Offset = "0x24E4FC1", VA = "0x24E4EC0")]
	public HandCuffsEffect(EffectID effect)
	{
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x24E4F80", Offset = "0x24E5081", VA = "0x24E4F80")]
	public void Copy(HandCuffsEffect effect)
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AF")]
	[Address(RVA = "0x24E2200", Offset = "0x24E2301", VA = "0x24E2200")]
	public void EffectLoad(HumanModel humanModel)
	{
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B0")]
	[Address(RVA = "0x24E4FC0", Offset = "0x24E50C1", VA = "0x24E4FC0")]
	private void AttachEffect(HumanModel humanModel)
	{
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B1")]
	[Address(RVA = "0x24E2530", Offset = "0x24E2631", VA = "0x24E2530")]
	public void OnEnable()
	{
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B2")]
	[Address(RVA = "0x24E3170", Offset = "0x24E3271", VA = "0x24E3170")]
	public void OnDisable()
	{
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B3")]
	[Address(RVA = "0x24E5170", Offset = "0x24E5271", VA = "0x24E5170")]
	public void Play()
	{
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B4")]
	[Address(RVA = "0x24E29C0", Offset = "0x24E2AC1", VA = "0x24E29C0")]
	public void Stop()
	{
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B5")]
	[Address(RVA = "0x24E2D40", Offset = "0x24E2E41", VA = "0x24E2D40")]
	public void Cancel(bool immediate = false)
	{
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010B6")]
	[Address(RVA = "0x24E3720", Offset = "0x24E3821", VA = "0x24E3720")]
	public void OnUpdate()
	{
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x000085E0 File Offset: 0x000067E0
	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x24E5220", Offset = "0x24E5321", VA = "0x24E5220")]
	private bool UpdateParticleScale(AnimationCurve scaleCurve)
	{
		return default(bool);
	}

	// Token: 0x04000A4C RID: 2636
	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private EffectID effectID;

	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private HumanJointIDEnum jointID;

	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x400081C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AnimationCurve stopScaleCurve;

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x400081D")]
	[FieldOffset(Offset = "0x20")]
	private HandCuffsEffect.State currentState;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x400081E")]
	[FieldOffset(Offset = "0x24")]
	private float elapsed;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x400081F")]
	[FieldOffset(Offset = "0x28")]
	private List<ParticleSystem> ParticleSystems;

	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000820")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F040", Offset = "0x15F141")]
	private ParticleSystem <Particle>k__BackingField;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000821")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F050", Offset = "0x15F151")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000822")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F060", Offset = "0x15F161")]
	private float <Scale>k__BackingField;

	// Token: 0x020002BB RID: 699
	[Token(Token = "0x2001020")]
	private enum State
	{
		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4018EA6")]
		None,
		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4018EA7")]
		Play,
		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4018EA8")]
		Stop,
		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4018EA9")]
		Cancel
	}

	// Token: 0x020002BC RID: 700
	[Token(Token = "0x2001021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157320", Offset = "0x157421")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x06001255 RID: 4693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C88")]
		[Address(RVA = "0x24E4FB0", Offset = "0x24E50B1", VA = "0x24E4FB0")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C89")]
		[Address(RVA = "0x24E53F0", Offset = "0x24E54F1", VA = "0x24E53F0")]
		internal void <EffectLoad>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4018EAA")]
		[FieldOffset(Offset = "0x10")]
		public HandCuffsEffect <>4__this;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4018EAB")]
		[FieldOffset(Offset = "0x18")]
		public HumanModel humanModel;
	}
}
