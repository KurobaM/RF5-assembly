using System;
using Define;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;

// Token: 0x020002B5 RID: 693
[Token(Token = "0x2000222")]
public class HandCuffsController : MonoBehaviour
{
	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06001215 RID: 4629 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001216 RID: 4630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000305")]
	public SphereCollider AimTarget
	{
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x24E1ED0", Offset = "0x24E1FD1", VA = "0x24E1ED0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C630", Offset = "0x19C731")]
		get
		{
			return null;
		}
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x24E1EE0", Offset = "0x24E1FE1", VA = "0x24E1EE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C640", Offset = "0x19C741")]
		set
		{
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06001217 RID: 4631 RVA: 0x00008490 File Offset: 0x00006690
	// (set) Token: 0x06001218 RID: 4632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000306")]
	public float CoolTimeNow
	{
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x24E1EF0", Offset = "0x24E1FF1", VA = "0x24E1EF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C650", Offset = "0x19C751")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x24E1F00", Offset = "0x24E2001", VA = "0x24E1F00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C660", Offset = "0x19C761")]
		private set
		{
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06001219 RID: 4633 RVA: 0x000084A8 File Offset: 0x000066A8
	// (set) Token: 0x0600121A RID: 4634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000307")]
	public float CoolTimeMax
	{
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x24E1F10", Offset = "0x24E2011", VA = "0x24E1F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C670", Offset = "0x19C771")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x24E1F20", Offset = "0x24E2021", VA = "0x24E1F20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C680", Offset = "0x19C781")]
		private set
		{
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x0600121B RID: 4635 RVA: 0x000084C0 File Offset: 0x000066C0
	[Token(Token = "0x17000308")]
	public float CoolTimePer
	{
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x24E1F30", Offset = "0x24E2031", VA = "0x24E1F30")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x0600121C RID: 4636 RVA: 0x000084D8 File Offset: 0x000066D8
	[Token(Token = "0x17000309")]
	public virtual bool CanPlay
	{
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x24E1F40", Offset = "0x24E2041", VA = "0x24E1F40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x0600121D RID: 4637 RVA: 0x000084F0 File Offset: 0x000066F0
	[Token(Token = "0x1700030A")]
	public virtual bool CanThrow
	{
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x24E2030", Offset = "0x24E2131", VA = "0x24E2030", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x0600121E RID: 4638 RVA: 0x00008508 File Offset: 0x00006708
	// (set) Token: 0x0600121F RID: 4639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030B")]
	public float ChargeTime
	{
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x24E2060", Offset = "0x24E2161", VA = "0x24E2060")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C690", Offset = "0x19C791")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x24E2070", Offset = "0x24E2171", VA = "0x24E2070")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C6A0", Offset = "0x19C7A1")]
		private set
		{
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x06001220 RID: 4640 RVA: 0x00008520 File Offset: 0x00006720
	// (set) Token: 0x06001221 RID: 4641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700030C")]
	public bool IsCharge
	{
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x24E2080", Offset = "0x24E2181", VA = "0x24E2080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C6B0", Offset = "0x19C7B1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x24E2090", Offset = "0x24E2191", VA = "0x24E2090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C6C0", Offset = "0x19C7C1")]
		private set
		{
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x06001222 RID: 4642 RVA: 0x00008538 File Offset: 0x00006738
	[Token(Token = "0x1700030D")]
	public bool IsPlaying
	{
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x24E20A0", Offset = "0x24E21A1", VA = "0x24E20A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x06001223 RID: 4643 RVA: 0x00008550 File Offset: 0x00006750
	[Token(Token = "0x1700030E")]
	public bool IsAiming
	{
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x24E20C0", Offset = "0x24E21C1", VA = "0x24E20C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108D")]
	[Address(RVA = "0x24E20D0", Offset = "0x24E21D1", VA = "0x24E20D0")]
	public void Initialize()
	{
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108E")]
	[Address(RVA = "0x24E2360", Offset = "0x24E2461", VA = "0x24E2360")]
	public void OnStart()
	{
	}

	// Token: 0x06001226 RID: 4646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x24E25D0", Offset = "0x24E26D1", VA = "0x24E25D0")]
	public void OnThrow()
	{
	}

	// Token: 0x06001227 RID: 4647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x24E2620", Offset = "0x24E2721", VA = "0x24E2620")]
	public void Throw(bool charge)
	{
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x24E2B50", Offset = "0x24E2C51", VA = "0x24E2B50")]
	public void OnCancel(bool immediate = false)
	{
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001092")]
	[Address(RVA = "0x24E2E70", Offset = "0x24E2F71", VA = "0x24E2E70")]
	public void OnShot(bool charge)
	{
	}

	// Token: 0x0600122A RID: 4650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x24E3210", Offset = "0x24E3311", VA = "0x24E3210")]
	public void OnUpdate()
	{
	}

	// Token: 0x0600122B RID: 4651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x24E36B0", Offset = "0x24E37B1", VA = "0x24E36B0")]
	public void OnUpdateEffect()
	{
	}

	// Token: 0x0600122C RID: 4652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x24E38D0", Offset = "0x24E39D1", VA = "0x24E38D0")]
	public void OnFixedUpdate()
	{
	}

	// Token: 0x0600122D RID: 4653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x24E3CF0", Offset = "0x24E3DF1", VA = "0x24E3CF0")]
	private void Awake()
	{
	}

	// Token: 0x0600122E RID: 4654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x24E3DB0", Offset = "0x24E3EB1", VA = "0x24E3DB0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600122F RID: 4655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x24E3DC0", Offset = "0x24E3EC1", VA = "0x24E3DC0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001230 RID: 4656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x24E4080", Offset = "0x24E4181", VA = "0x24E4080")]
	private void OnDisable()
	{
	}

	// Token: 0x06001231 RID: 4657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x24E2AA0", Offset = "0x24E2BA1", VA = "0x24E2AA0")]
	private void StopChargeSound()
	{
	}

	// Token: 0x06001232 RID: 4658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109B")]
	[Address(RVA = "0x24E4260", Offset = "0x24E4361", VA = "0x24E4260")]
	private void PlayChargeSound(SoundID soundID)
	{
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109C")]
	[Address(RVA = "0x24E43A0", Offset = "0x24E44A1", VA = "0x24E43A0")]
	private void SimulateTarget(out Vector3 from, out Vector3 to)
	{
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109D")]
	[Address(RVA = "0x24E44D0", Offset = "0x24E45D1", VA = "0x24E44D0")]
	private static void UpdateNone(HandCuffsController controller)
	{
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109E")]
	[Address(RVA = "0x24E4630", Offset = "0x24E4731", VA = "0x24E4630")]
	private static void UpdateIdle(HandCuffsController controller)
	{
	}

	// Token: 0x06001236 RID: 4662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109F")]
	[Address(RVA = "0x24E4640", Offset = "0x24E4741", VA = "0x24E4640")]
	private static void UpdateCharge(HandCuffsController controller)
	{
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A0")]
	[Address(RVA = "0x24E49C0", Offset = "0x24E4AC1", VA = "0x24E49C0")]
	private static void UpdateAim(HandCuffsController controller)
	{
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x24E49D0", Offset = "0x24E4AD1", VA = "0x24E49D0")]
	public HandCuffsController()
	{
	}

	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x4000807")]
	private const float ChargeStartSoundPlayTime = 0.3f;

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000808")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HumanController HumanController;

	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000809")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float Normal_Scale;

	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x400080A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float Charge_Scale;

	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x400080B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float Charge_MinScale;

	// Token: 0x04000A33 RID: 2611
	[Token(Token = "0x400080C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float Charge_MaxScale;

	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x400080D")]
	private const MagicID Normal_MagicID = MagicID.MagicHandCuffs_01;

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x400080E")]
	private const MagicID Charge_MagicID = MagicID.MagicHandCuffs_02;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x400080F")]
	private const SoundID Normal_ThrowSoundID = SoundID.RF5_SE_chara_motion32;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000810")]
	private const SoundID Charge_ThrowSoundID = SoundID.RF5_SE_chara_motion14;

	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000811")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private HandCuffsEffect[] Effects;

	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x4000812")]
	[FieldOffset(Offset = "0x38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EFC0", Offset = "0x15F0C1")]
	private SphereCollider <AimTarget>k__BackingField;

	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x4000813")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EFD0", Offset = "0x15F0D1")]
	private float <CoolTimeNow>k__BackingField;

	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x4000814")]
	[FieldOffset(Offset = "0x44")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EFE0", Offset = "0x15F0E1")]
	private float <CoolTimeMax>k__BackingField;

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000815")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EFF0", Offset = "0x15F0F1")]
	private float <ChargeTime>k__BackingField;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000816")]
	[FieldOffset(Offset = "0x4C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F000", Offset = "0x15F101")]
	private bool <IsCharge>k__BackingField;

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000817")]
	[FieldOffset(Offset = "0x50")]
	private HandCuffsController.State updateState;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000818")]
	[FieldOffset(Offset = "0x58")]
	private SEController chargeSound;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x0")]
	private static HandCuffsController.UpdateVJ[] updateVJ;

	// Token: 0x020002B6 RID: 694
	[Token(Token = "0x200101C")]
	private enum EffectType
	{
		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4018E9B")]
		Ready,
		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4018E9C")]
		Charge,
		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4018E9D")]
		Length
	}

	// Token: 0x020002B7 RID: 695
	[Token(Token = "0x200101D")]
	private enum State
	{
		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4018E9F")]
		NONE,
		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4018EA0")]
		IDLE,
		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4018EA1")]
		CHARGE,
		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4018EA2")]
		AIM,
		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4018EA3")]
		Length
	}

	// Token: 0x020002B8 RID: 696
	// (Invoke) Token: 0x0600123B RID: 4667
	[Token(Token = "0x200101E")]
	private delegate void UpdateVJ(HandCuffsController controller);

	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x200101F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157310", Offset = "0x157411")]
	private sealed class <>c__DisplayClass65_0
	{
		// Token: 0x0600123E RID: 4670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C86")]
		[Address(RVA = "0x24E49B0", Offset = "0x24E4AB1", VA = "0x24E49B0")]
		public <>c__DisplayClass65_0()
		{
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C87")]
		[Address(RVA = "0x24E4CA0", Offset = "0x24E4DA1", VA = "0x24E4CA0")]
		internal void <UpdateCharge>b__0(ParticleSystem effect)
		{
		}

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4018EA4")]
		[FieldOffset(Offset = "0x10")]
		public HandCuffsController controller;
	}
}
