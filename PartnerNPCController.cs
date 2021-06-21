using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B2 RID: 690
[Token(Token = "0x200021F")]
public class PartnerNPCController : HumanController, InteractionInterface, FocusInterface, ItemInteractionInterface
{
	// Token: 0x17000325 RID: 805
	// (get) Token: 0x060011DE RID: 4574 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060011DF RID: 4575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002FB")]
	public NpcData NPCData
	{
		[Token(Token = "0x6001047")]
		[Address(RVA = "0x2136DC0", Offset = "0x2136EC1", VA = "0x2136DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C5A0", Offset = "0x19C6A1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001048")]
		[Address(RVA = "0x2136DD0", Offset = "0x2136ED1", VA = "0x2136DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C5B0", Offset = "0x19C6B1")]
		protected set
		{
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002FC")]
	public NPCBehaviorDataTable NPCBehaviorDataTable
	{
		[Token(Token = "0x6001049")]
		[Address(RVA = "0x2136DE0", Offset = "0x2136EE1", VA = "0x2136DE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C5C0", Offset = "0x19C6C1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600104A")]
		[Address(RVA = "0x2136DF0", Offset = "0x2136EF1", VA = "0x2136DF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C5D0", Offset = "0x19C6D1")]
		protected set
		{
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00008358 File Offset: 0x00006558
	// (set) Token: 0x060011E3 RID: 4579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002FD")]
	public PartnerNPCWeaponBehaviorDataTable CurrentEquipWeaponDataTable
	{
		[Token(Token = "0x600104B")]
		[Address(RVA = "0x2136E00", Offset = "0x2136F01", VA = "0x2136E00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C5E0", Offset = "0x19C6E1")]
		get
		{
			return default(PartnerNPCWeaponBehaviorDataTable);
		}
		[Token(Token = "0x600104C")]
		[Address(RVA = "0x2136E10", Offset = "0x2136F11", VA = "0x2136E10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C5F0", Offset = "0x19C6F1")]
		protected set
		{
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00008370 File Offset: 0x00006570
	[Token(Token = "0x170002FE")]
	protected override bool UseGravityOnNavMeshEnabled
	{
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x2136E20", Offset = "0x2136F21", VA = "0x2136E20", Slot = "38")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104E")]
	[Address(RVA = "0x2136E30", Offset = "0x2136F31", VA = "0x2136E30")]
	public void SetReceiver(PartnerNPCEventReceiverInterface receiver)
	{
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600104F")]
	[Address(RVA = "0x2136E40", Offset = "0x2136F41", VA = "0x2136E40")]
	public void SetNPCData(NpcData nPCData)
	{
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001050")]
	[Address(RVA = "0x2136F60", Offset = "0x2137061", VA = "0x2136F60", Slot = "85")]
	public override void ResetEquip()
	{
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001051")]
	[Address(RVA = "0x2137160", Offset = "0x2137261", VA = "0x2137160")]
	public void SetupPartner()
	{
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001052")]
	[Address(RVA = "0x2137670", Offset = "0x2137771", VA = "0x2137670")]
	public void SetActionScript(string actionScriptName)
	{
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001053")]
	[Address(RVA = "0x21376C0", Offset = "0x21377C1", VA = "0x21376C0")]
	public void DoActionScript()
	{
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001054")]
	[Address(RVA = "0x2137220", Offset = "0x2137321", VA = "0x2137220")]
	public void SetupActionEvent()
	{
	}

	// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001055")]
	[Address(RVA = "0x21376F0", Offset = "0x21377F1", VA = "0x21376F0", Slot = "11")]
	protected override void Awake()
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001056")]
	[Address(RVA = "0x2137700", Offset = "0x2137801", VA = "0x2137700", Slot = "12")]
	protected override void Start()
	{
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001057")]
	[Address(RVA = "0x2137750", Offset = "0x2137851", VA = "0x2137750", Slot = "39")]
	protected override void Update()
	{
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00008388 File Offset: 0x00006588
	[Token(Token = "0x6001058")]
	[Address(RVA = "0x21379B0", Offset = "0x2137AB1", VA = "0x21379B0", Slot = "7")]
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult)
	{
		return default(bool);
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001059")]
	[Address(RVA = "0x2137B80", Offset = "0x2137C81", VA = "0x2137B80", Slot = "66")]
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105A")]
	[Address(RVA = "0x2137D70", Offset = "0x2137E71", VA = "0x2137D70", Slot = "68")]
	public override void OnAfterDamageAction(DamageActionType type, DamageResult damageResult)
	{
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105B")]
	[Address(RVA = "0x2137F20", Offset = "0x2138021", VA = "0x2137F20", Slot = "64")]
	public override void OnBadStatus(BadStatus badStatus, bool isEnable)
	{
	}

	// Token: 0x060011F3 RID: 4595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105C")]
	[Address(RVA = "0x2138010", Offset = "0x2138111", VA = "0x2138010", Slot = "17")]
	public override void OnSwitchActorBase(bool on)
	{
	}

	// Token: 0x060011F4 RID: 4596 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600105D")]
	[Address(RVA = "0x2138180", Offset = "0x2138281", VA = "0x2138180", Slot = "98")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x000083A0 File Offset: 0x000065A0
	[Token(Token = "0x600105E")]
	[Address(RVA = "0x21381D0", Offset = "0x21382D1", VA = "0x21381D0", Slot = "95")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600105F")]
	[Address(RVA = "0x2138350", Offset = "0x2138451", VA = "0x2138350", Slot = "94")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x21384A0", Offset = "0x21385A1", VA = "0x21384A0", Slot = "99")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x060011F8 RID: 4600 RVA: 0x000083B8 File Offset: 0x000065B8
	// (set) Token: 0x060011F9 RID: 4601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002FF")]
	public bool Focusable
	{
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x21384B0", Offset = "0x21385B1", VA = "0x21384B0", Slot = "100")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x2138540", Offset = "0x2138641", VA = "0x2138540")]
		private set
		{
		}
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x2138550", Offset = "0x2138651", VA = "0x2138550", Slot = "101")]
	public void OnFocus()
	{
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x2138560", Offset = "0x2138661", VA = "0x2138560", Slot = "102")]
	public void OffFocus()
	{
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x000083D0 File Offset: 0x000065D0
	[Token(Token = "0x6001065")]
	[Address(RVA = "0x2138570", Offset = "0x2138671", VA = "0x2138570", Slot = "106")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x060011FD RID: 4605 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000300")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x21387D0", Offset = "0x21388D1", VA = "0x21387D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x060011FE RID: 4606 RVA: 0x000083E8 File Offset: 0x000065E8
	[Token(Token = "0x17000301")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x2138820", Offset = "0x2138921", VA = "0x2138820", Slot = "103")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x060011FF RID: 4607 RVA: 0x00008400 File Offset: 0x00006600
	[Token(Token = "0x17000302")]
	public int FocusPriority
	{
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x2138830", Offset = "0x2138931", VA = "0x2138830", Slot = "104")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x06001200 RID: 4608 RVA: 0x00008418 File Offset: 0x00006618
	[Token(Token = "0x17000303")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x2138840", Offset = "0x2138941", VA = "0x2138840", Slot = "105")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x06001201 RID: 4609 RVA: 0x00008430 File Offset: 0x00006630
	[Token(Token = "0x600106A")]
	[Address(RVA = "0x2138650", Offset = "0x2138751", VA = "0x2138650", Slot = "110")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00008448 File Offset: 0x00006648
	[Token(Token = "0x600106B")]
	[Address(RVA = "0x2138850", Offset = "0x2138951", VA = "0x2138850", Slot = "111")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106C")]
	[Address(RVA = "0x2138860", Offset = "0x2138961", VA = "0x2138860", Slot = "109")]
	public void DoItemInteraction(HumanController causer, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106D")]
	[Address(RVA = "0x2138AC0", Offset = "0x2138BC1", VA = "0x2138AC0", Slot = "96")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x00008460 File Offset: 0x00006660
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x2138AD0", Offset = "0x2138BD1", VA = "0x2138AD0", Slot = "97")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x2138AE0", Offset = "0x2138BE1", VA = "0x2138AE0")]
	public PartnerNPCController()
	{
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001070")]
	[Address(RVA = "0x2138B60", Offset = "0x2138C61", VA = "0x2138B60", Slot = "107")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001071")]
	[Address(RVA = "0x2138B70", Offset = "0x2138C71", VA = "0x2138B70", Slot = "108")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001072")]
	[Address(RVA = "0x2138B80", Offset = "0x2138C81", VA = "0x2138B80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C600", Offset = "0x19C701")]
	private void <SetupActionEvent>b__26_0()
	{
	}

	// Token: 0x04000A1D RID: 2589
	[Token(Token = "0x40007F6")]
	[FieldOffset(Offset = "0x238")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15EE80", Offset = "0x15EF81")]
	[SerializeField]
	public NPCID m_CharaID;

	// Token: 0x04000A1E RID: 2590
	[Token(Token = "0x40007F7")]
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	private HumanDualSkillGaugeObserve m_DualSkillGaugeObserve;

	// Token: 0x04000A1F RID: 2591
	[Token(Token = "0x40007F8")]
	[FieldOffset(Offset = "0x248")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EEE0", Offset = "0x15EFE1")]
	private NpcData <NPCData>k__BackingField;

	// Token: 0x04000A20 RID: 2592
	[Token(Token = "0x40007F9")]
	[FieldOffset(Offset = "0x250")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EEF0", Offset = "0x15EFF1")]
	private NPCBehaviorDataTable <NPCBehaviorDataTable>k__BackingField;

	// Token: 0x04000A21 RID: 2593
	[Token(Token = "0x40007FA")]
	[FieldOffset(Offset = "0x258")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15EF00", Offset = "0x15F001")]
	private PartnerNPCWeaponBehaviorDataTable <CurrentEquipWeaponDataTable>k__BackingField;

	// Token: 0x04000A22 RID: 2594
	[Token(Token = "0x40007FB")]
	[FieldOffset(Offset = "0x268")]
	private string FocusName;

	// Token: 0x04000A23 RID: 2595
	[Token(Token = "0x40007FC")]
	[FieldOffset(Offset = "0x270")]
	protected AS_ToolController EquiptToolActionScriptsController;

	// Token: 0x04000A24 RID: 2596
	[Token(Token = "0x40007FD")]
	[FieldOffset(Offset = "0x278")]
	private PartnerNPCEventReceiverInterface Receiver;

	// Token: 0x04000A25 RID: 2597
	[Token(Token = "0x40007FE")]
	[FieldOffset(Offset = "0x280")]
	protected string CurrentActionScriptName;

	// Token: 0x04000A26 RID: 2598
	[Token(Token = "0x40007FF")]
	[FieldOffset(Offset = "0x288")]
	public bool focusable;
}
