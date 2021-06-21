using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000822 RID: 2082
[Token(Token = "0x200055E")]
public class PartnerNPCBehaviorController : AIInput, PartnerNPCEventReceiverInterface
{
	// Token: 0x170007B9 RID: 1977
	// (get) Token: 0x06003780 RID: 14208 RVA: 0x00013218 File Offset: 0x00011418
	// (set) Token: 0x06003781 RID: 14209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000602")]
	public PartnerBehaviorType PartnerBehaviorType
	{
		[Token(Token = "0x6002E35")]
		[Address(RVA = "0x21350B0", Offset = "0x21351B1", VA = "0x21350B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5BC0", Offset = "0x1A5CC1")]
		get
		{
			return PartnerBehaviorType.None;
		}
		[Token(Token = "0x6002E36")]
		[Address(RVA = "0x21350C0", Offset = "0x21351C1", VA = "0x21350C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A5BD0", Offset = "0x1A5CD1")]
		protected set
		{
		}
	}

	// Token: 0x170007BA RID: 1978
	// (get) Token: 0x06003782 RID: 14210 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003783 RID: 14211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000603")]
	public override SearchCharacterController SearchCharacterController
	{
		[Token(Token = "0x6002E37")]
		[Address(RVA = "0x21350D0", Offset = "0x21351D1", VA = "0x21350D0", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002E38")]
		[Address(RVA = "0x21350E0", Offset = "0x21351E1", VA = "0x21350E0", Slot = "8")]
		protected set
		{
		}
	}

	// Token: 0x170007BB RID: 1979
	// (get) Token: 0x06003784 RID: 14212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000604")]
	public PartnerNPCController PartnerNPCController
	{
		[Token(Token = "0x6002E39")]
		[Address(RVA = "0x21350F0", Offset = "0x21351F1", VA = "0x21350F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170007BC RID: 1980
	// (get) Token: 0x06003785 RID: 14213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000605")]
	public NpcData NPCData
	{
		[Token(Token = "0x6002E3A")]
		[Address(RVA = "0x21351D0", Offset = "0x21352D1", VA = "0x21351D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06003786 RID: 14214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x21351F0", Offset = "0x21352F1", VA = "0x21351F0")]
	private void SetupActionBehaviorContriller()
	{
	}

	// Token: 0x06003787 RID: 14215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x2135280", Offset = "0x2135381", VA = "0x2135280")]
	public void SetupAction()
	{
	}

	// Token: 0x06003788 RID: 14216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x21352D0", Offset = "0x21353D1", VA = "0x21352D0")]
	public void ExecuteAction(int index)
	{
	}

	// Token: 0x06003789 RID: 14217 RVA: 0x00013230 File Offset: 0x00011430
	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x21352F0", Offset = "0x21353F1", VA = "0x21352F0")]
	public bool EnableTarget()
	{
		return default(bool);
	}

	// Token: 0x0600378A RID: 14218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x2135080", Offset = "0x2135181", VA = "0x2135080")]
	public void AbortAction(int index)
	{
	}

	// Token: 0x0600378B RID: 14219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E40")]
	[Address(RVA = "0x2135420", Offset = "0x2135521", VA = "0x2135420")]
	public void EndAction()
	{
	}

	// Token: 0x0600378C RID: 14220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E41")]
	[Address(RVA = "0x2135430", Offset = "0x2135531", VA = "0x2135430", Slot = "4")]
	protected override void Start()
	{
	}

	// Token: 0x0600378D RID: 14221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E42")]
	[Address(RVA = "0x2135440", Offset = "0x2135541", VA = "0x2135440", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x0600378E RID: 14222 RVA: 0x00013248 File Offset: 0x00011448
	[Token(Token = "0x6002E43")]
	[Address(RVA = "0x2135480", Offset = "0x2135581", VA = "0x2135480")]
	private bool IgnoreCharacter(Character character)
	{
		return default(bool);
	}

	// Token: 0x0600378F RID: 14223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E44")]
	[Address(RVA = "0x2135580", Offset = "0x2135681", VA = "0x2135580", Slot = "15")]
	public override void SetupSearchCharacterController()
	{
	}

	// Token: 0x06003790 RID: 14224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E45")]
	[Address(RVA = "0x2135750", Offset = "0x2135851", VA = "0x2135750", Slot = "16")]
	protected override void OnSetupSearchCharacterController()
	{
	}

	// Token: 0x06003791 RID: 14225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E46")]
	[Address(RVA = "0x2135840", Offset = "0x2135941", VA = "0x2135840", Slot = "17")]
	public override void ResetSearchCharacterController()
	{
	}

	// Token: 0x06003792 RID: 14226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E47")]
	[Address(RVA = "0x2135890", Offset = "0x2135991", VA = "0x2135890", Slot = "6")]
	public override void SetCharacter(Character character)
	{
	}

	// Token: 0x06003793 RID: 14227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E48")]
	[Address(RVA = "0x2135930", Offset = "0x2135A31", VA = "0x2135930", Slot = "30")]
	public virtual void SetPartnerBehaviorType(PartnerBehaviorType type)
	{
	}

	// Token: 0x06003794 RID: 14228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E49")]
	[Address(RVA = "0x2135940", Offset = "0x2135A41", VA = "0x2135940", Slot = "10")]
	protected override void OnSetup()
	{
	}

	// Token: 0x06003795 RID: 14229 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4A")]
	[Address(RVA = "0x21359E0", Offset = "0x2135AE1", VA = "0x21359E0", Slot = "19")]
	protected override void OnGetVariableBehaviorParameter()
	{
	}

	// Token: 0x06003796 RID: 14230 RVA: 0x00013260 File Offset: 0x00011460
	[Token(Token = "0x6002E4B")]
	[Address(RVA = "0x2135AB0", Offset = "0x2135BB1", VA = "0x2135AB0")]
	public bool CheckSameMovementOrder(PartnerMovementOrderType order)
	{
		return default(bool);
	}

	// Token: 0x06003797 RID: 14231 RVA: 0x00013278 File Offset: 0x00011478
	[Token(Token = "0x6002E4C")]
	[Address(RVA = "0x2135B00", Offset = "0x2135C01", VA = "0x2135B00")]
	public bool CheckSameBattleOrder(PartnerBattleOrder order)
	{
		return default(bool);
	}

	// Token: 0x06003798 RID: 14232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4D")]
	[Address(RVA = "0x2135B10", Offset = "0x2135C11", VA = "0x2135B10")]
	public void SetPartnerBattleOrder(PartnerBattleOrder order)
	{
	}

	// Token: 0x06003799 RID: 14233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4E")]
	[Address(RVA = "0x2135B20", Offset = "0x2135C21", VA = "0x2135B20", Slot = "22")]
	public void OnChangeShortPlay(bool isEnable)
	{
	}

	// Token: 0x0600379A RID: 14234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E4F")]
	[Address(RVA = "0x2135B70", Offset = "0x2135C71", VA = "0x2135B70", Slot = "23")]
	public void TakeDamage(bool isDamage, float blowDist, DamageInfo damageInfo, ref DamageResult damageResult)
	{
	}

	// Token: 0x0600379B RID: 14235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E50")]
	[Address(RVA = "0x2135C20", Offset = "0x2135D21", VA = "0x2135C20", Slot = "24")]
	public void OnFreeze()
	{
	}

	// Token: 0x0600379C RID: 14236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E51")]
	[Address(RVA = "0x2135C80", Offset = "0x2135D81", VA = "0x2135C80", Slot = "25")]
	public void OnBlow()
	{
	}

	// Token: 0x0600379D RID: 14237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E52")]
	[Address(RVA = "0x2135CA0", Offset = "0x2135DA1", VA = "0x2135CA0", Slot = "26")]
	public void OnKnockBack()
	{
	}

	// Token: 0x0600379E RID: 14238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E53")]
	[Address(RVA = "0x2135CC0", Offset = "0x2135DC1", VA = "0x2135CC0", Slot = "27")]
	public void OnDead()
	{
	}

	// Token: 0x0600379F RID: 14239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E54")]
	[Address(RVA = "0x2135CE0", Offset = "0x2135DE1", VA = "0x2135CE0", Slot = "31")]
	public virtual void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x060037A0 RID: 14240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E55")]
	[Address(RVA = "0x2135DA0", Offset = "0x2135EA1", VA = "0x2135DA0", Slot = "28")]
	public void EndDamageAction()
	{
	}

	// Token: 0x060037A1 RID: 14241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E56")]
	[Address(RVA = "0x2135E70", Offset = "0x2135F71", VA = "0x2135E70")]
	public PartnerNPCBehaviorController()
	{
	}

	// Token: 0x04007ACA RID: 31434
	[Token(Token = "0x4006F2C")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16B1E0", Offset = "0x16B2E1")]
	private PartnerBehaviorType <PartnerBehaviorType>k__BackingField;

	// Token: 0x04007ACB RID: 31435
	[Token(Token = "0x4006F2D")]
	[FieldOffset(Offset = "0x78")]
	public HateController HateController;

	// Token: 0x04007ACC RID: 31436
	[Token(Token = "0x4006F2E")]
	[FieldOffset(Offset = "0x80")]
	public PartnerMovementController PartnerMovementController;

	// Token: 0x04007ACD RID: 31437
	[Token(Token = "0x4006F2F")]
	[FieldOffset(Offset = "0x88")]
	private PartnerNPCController _PartnerNPCController;

	// Token: 0x04007ACE RID: 31438
	[Token(Token = "0x4006F30")]
	[FieldOffset(Offset = "0x90")]
	private NPCActionBehaviorController NPCActionBehaviorController;

	// Token: 0x04007ACF RID: 31439
	[Token(Token = "0x4006F31")]
	[FieldOffset(Offset = "0x98")]
	public List<PartnerNPCActionBehaviorType> ActionTypeList;
}
