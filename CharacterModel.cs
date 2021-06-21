using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200021B RID: 539
[Token(Token = "0x20001B6")]
public class CharacterModel : MonoBehaviour
{
	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021B")]
	public RuntimeAnimatorController RuntimeAnimatorController
	{
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1E8E090", Offset = "0x1E8E191", VA = "0x1E8E090")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021C")]
	public Avatar Avatar
	{
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1E8E0A0", Offset = "0x1E8E1A1", VA = "0x1E8E0A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021D")]
	public AudioSource AudioSource
	{
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1E8E0B0", Offset = "0x1E8E1B1", VA = "0x1E8E0B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x00005C10 File Offset: 0x00003E10
	// (set) Token: 0x06000BFA RID: 3066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021E")]
	public bool FadeEnable
	{
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1E8E0C0", Offset = "0x1E8E1C1", VA = "0x1E8E0C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B5D0", Offset = "0x19B6D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1E8E0D0", Offset = "0x1E8E1D1", VA = "0x1E8E0D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B5E0", Offset = "0x19B6E1")]
		protected set
		{
		}
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x06000BFB RID: 3067 RVA: 0x00005C28 File Offset: 0x00003E28
	// (set) Token: 0x06000BFC RID: 3068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021F")]
	public float FadeAlpha
	{
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1E8E0E0", Offset = "0x1E8E1E1", VA = "0x1E8E0E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B5F0", Offset = "0x19B6F1")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1E8E0F0", Offset = "0x1E8E1F1", VA = "0x1E8E0F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B600", Offset = "0x19B701")]
		protected set
		{
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00005C40 File Offset: 0x00003E40
	// (set) Token: 0x06000BFE RID: 3070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000220")]
	public float FadeWeight
	{
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x1E8E100", Offset = "0x1E8E201", VA = "0x1E8E100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B610", Offset = "0x19B711")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1E8E110", Offset = "0x1E8E211", VA = "0x1E8E110")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B620", Offset = "0x19B721")]
		protected set
		{
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00005C58 File Offset: 0x00003E58
	[Token(Token = "0x17000221")]
	public float CurrentFadeAlpha
	{
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1E8E120", Offset = "0x1E8E221", VA = "0x1E8E120")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000222")]
	public virtual Transform LookPoint
	{
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1E8E1B0", Offset = "0x1E8E2B1", VA = "0x1E8E1B0", Slot = "4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19B630", Offset = "0x19B731")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AAF")]
	[Address(RVA = "0x1E8E1C0", Offset = "0x1E8E2C1", VA = "0x1E8E1C0")]
	public void SetLoaderId(int id)
	{
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x1E8E1D0", Offset = "0x1E8E2D1", VA = "0x1E8E1D0")]
	public void RemoveAsset()
	{
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x1E8E250", Offset = "0x1E8E351", VA = "0x1E8E250", Slot = "5")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x1E8E390", Offset = "0x1E8E491", VA = "0x1E8E390", Slot = "6")]
	protected virtual void Start()
	{
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x1E8E3A0", Offset = "0x1E8E4A1", VA = "0x1E8E3A0", Slot = "1")]
	protected override void Finalize()
	{
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x1E8E460", Offset = "0x1E8E561", VA = "0x1E8E460", Slot = "7")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0x1E8E4E0", Offset = "0x1E8E5E1", VA = "0x1E8E4E0", Slot = "8")]
	public virtual void SetFadeEnable(bool enable)
	{
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0x1E8E620", Offset = "0x1E8E721", VA = "0x1E8E620", Slot = "9")]
	public virtual void SetFadeAlpha(float alpha)
	{
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB7")]
	[Address(RVA = "0x1E8E770", Offset = "0x1E8E871", VA = "0x1E8E770", Slot = "10")]
	public virtual void SetFadeWeight(float weight)
	{
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB8")]
	[Address(RVA = "0x1E8E8C0", Offset = "0x1E8E9C1", VA = "0x1E8E8C0", Slot = "11")]
	public virtual void SetShadowState(ShadowCastingMode shadowCastingMode)
	{
	}

	// Token: 0x06000C0B RID: 3083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AB9")]
	[Address(RVA = "0x1E8D560", Offset = "0x1E8D661", VA = "0x1E8D560")]
	public void SetNearCullingEnable(bool enable)
	{
	}

	// Token: 0x06000C0C RID: 3084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABA")]
	[Address(RVA = "0x1E8E9C0", Offset = "0x1E8EAC1", VA = "0x1E8E9C0")]
	public CharacterModel()
	{
	}

	// Token: 0x04000715 RID: 1813
	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected RuntimeAnimatorController m_RuntimeAnimatorController;

	// Token: 0x04000716 RID: 1814
	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Avatar m_Avatar;

	// Token: 0x04000717 RID: 1815
	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected AudioSource m_AudioSource;

	// Token: 0x04000718 RID: 1816
	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected MeshFadeController m_FadeController;

	// Token: 0x04000719 RID: 1817
	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected CharacterNearCullingController m_NearCullingController;

	// Token: 0x0400071A RID: 1818
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public Transform StatusEffect_Point;

	// Token: 0x0400071B RID: 1819
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D8C0", Offset = "0x15D9C1")]
	private bool <FadeEnable>k__BackingField;

	// Token: 0x0400071C RID: 1820
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D8D0", Offset = "0x15D9D1")]
	private float <FadeAlpha>k__BackingField;

	// Token: 0x0400071D RID: 1821
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D8E0", Offset = "0x15D9E1")]
	private float <FadeWeight>k__BackingField;

	// Token: 0x0400071E RID: 1822
	[Token(Token = "0x40005C2")]
	[FieldOffset(Offset = "0x58")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15D8F0", Offset = "0x15D9F1")]
	private readonly Transform <LookPoint>k__BackingField;

	// Token: 0x0400071F RID: 1823
	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x60")]
	private int LoaderId;
}
