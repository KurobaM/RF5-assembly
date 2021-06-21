using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005F1 RID: 1521
[Token(Token = "0x2000447")]
public class GimmickYasaiSwitch : GimmickBase, ItemInteractionInterface, FocusInterface, InteractionInterface
{
	// Token: 0x1700060A RID: 1546
	// (get) Token: 0x06002580 RID: 9600 RVA: 0x0000EF10 File Offset: 0x0000D110
	[Token(Token = "0x170004D0")]
	private ItemID ItemID
	{
		[Token(Token = "0x6001FA2")]
		[Address(RVA = "0x1FED260", Offset = "0x1FED361", VA = "0x1FED260")]
		get
		{
			return ItemID.ITEM_EMPTY;
		}
	}

	// Token: 0x1700060B RID: 1547
	// (get) Token: 0x06002581 RID: 9601 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004D1")]
	private ItemDataTable ItemDataTable
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0x1FED370", Offset = "0x1FED471", VA = "0x1FED370")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700060C RID: 1548
	// (get) Token: 0x06002582 RID: 9602 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002583 RID: 9603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004D2")]
	public GimmickLayoutID[] TargetGimmickLayoutIDs
	{
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0x1FED390", Offset = "0x1FED491", VA = "0x1FED390")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0x1FED3A0", Offset = "0x1FED4A1", VA = "0x1FED3A0")]
		set
		{
		}
	}

	// Token: 0x1700060D RID: 1549
	// (get) Token: 0x06002584 RID: 9604 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002585 RID: 9605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004D3")]
	public bool[] TargetValueInverts
	{
		[Token(Token = "0x6001FA6")]
		[Address(RVA = "0x1FED3B0", Offset = "0x1FED4B1", VA = "0x1FED3B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x1FED3C0", Offset = "0x1FED4C1", VA = "0x1FED3C0")]
		private set
		{
		}
	}

	// Token: 0x1700060E RID: 1550
	// (get) Token: 0x06002586 RID: 9606 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170004D4")]
	public string ItemInteractionButtonHint
	{
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x1FED3D0", Offset = "0x1FED4D1", VA = "0x1FED3D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x1FED3E0", Offset = "0x1FED4E1", VA = "0x1FED3E0", Slot = "9")]
	public override void Init()
	{
	}

	// Token: 0x1700060F RID: 1551
	// (get) Token: 0x06002588 RID: 9608 RVA: 0x0000EF28 File Offset: 0x0000D128
	[Token(Token = "0x170004D5")]
	public bool Focusable
	{
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x1FEDB20", Offset = "0x1FEDC21", VA = "0x1FEDB20", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000610 RID: 1552
	// (get) Token: 0x06002589 RID: 9609 RVA: 0x0000EF40 File Offset: 0x0000D140
	[Token(Token = "0x170004D6")]
	public FocusObjectType FocusObjectType
	{
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x1FEDB80", Offset = "0x1FEDC81", VA = "0x1FEDB80", Slot = "18")]
		get
		{
			return FocusObjectType.Default;
		}
	}

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x0600258A RID: 9610 RVA: 0x0000EF58 File Offset: 0x0000D158
	[Token(Token = "0x170004D7")]
	public int FocusPriority
	{
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x1FEDB90", Offset = "0x1FEDC91", VA = "0x1FEDB90", Slot = "19")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000612 RID: 1554
	// (get) Token: 0x0600258B RID: 9611 RVA: 0x0000EF70 File Offset: 0x0000D170
	[Token(Token = "0x170004D8")]
	public FocusPointType FocusPointType
	{
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x1FEDBA0", Offset = "0x1FEDCA1", VA = "0x1FEDBA0", Slot = "20")]
		get
		{
			return FocusPointType.HitPoint;
		}
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x0000EF88 File Offset: 0x0000D188
	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x1FEDBB0", Offset = "0x1FEDCB1", VA = "0x1FEDBB0", Slot = "25")]
	public bool CanInteraction(HumanController character)
	{
		return default(bool);
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x1FEDC10", Offset = "0x1FEDD11", VA = "0x1FEDC10", Slot = "12")]
	public bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
		return default(bool);
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x1FEDC90", Offset = "0x1FEDD91", VA = "0x1FEDC90", Slot = "24")]
	public void DoInteraction(HumanController character)
	{
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x1FEDD60", Offset = "0x1FEDE61", VA = "0x1FEDD60", Slot = "11")]
	public void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
	{
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x1FEDEE0", Offset = "0x1FEDFE1", VA = "0x1FEDEE0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1A17A0", Offset = "0x1A18A1")]
	private IEnumerator WaitEventEnd()
	{
		return null;
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x1FED8C0", Offset = "0x1FED9C1", VA = "0x1FED8C0")]
	public void SetSwitchState(bool newState, bool setFlag, bool immediate)
	{
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x1FEDF90", Offset = "0x1FEE091", VA = "0x1FEDF90", Slot = "14")]
	public string GetFocusName()
	{
		return null;
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x1FEDFA0", Offset = "0x1FEE0A1", VA = "0x1FEDFA0", Slot = "28")]
	public string GetInteractionButtonHint()
	{
		return null;
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x1FEDFB0", Offset = "0x1FEE0B1", VA = "0x1FEDFB0", Slot = "17")]
	public void OffFocus()
	{
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x1FEDFC0", Offset = "0x1FEE0C1", VA = "0x1FEDFC0", Slot = "16")]
	public void OnFocus()
	{
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x1FEDFD0", Offset = "0x1FEE0D1", VA = "0x1FEDFD0", Slot = "21")]
	public ushort GetInteractionType()
	{
		return 0;
	}

	// Token: 0x06002597 RID: 9623 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x1FEE140", Offset = "0x1FEE241", VA = "0x1FEE140", Slot = "13")]
	public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x06002598 RID: 9624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x1FEE150", Offset = "0x1FEE251", VA = "0x1FEE150", Slot = "26")]
	public void DoInteraction(MonsterControllerBase character)
	{
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
	[Token(Token = "0x6001FBB")]
	[Address(RVA = "0x1FEE160", Offset = "0x1FEE261", VA = "0x1FEE160", Slot = "27")]
	public bool CanInteraction(MonsterControllerBase character)
	{
		return default(bool);
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x1FEE170", Offset = "0x1FEE271", VA = "0x1FEE170")]
	public GimmickYasaiSwitch()
	{
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x1FEE280", Offset = "0x1FEE381", VA = "0x1FEE280", Slot = "22")]
	private GameObject get_gameObject()
	{
		return null;
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x1FEE290", Offset = "0x1FEE391", VA = "0x1FEE290", Slot = "23")]
	private Transform get_transform()
	{
		return null;
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x1FEE2A0", Offset = "0x1FEE3A1", VA = "0x1FEE2A0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1810", Offset = "0x1A1911")]
	[DebuggerHidden]
	private void <>n__0(bool newState)
	{
	}

	// Token: 0x04006CCF RID: 27855
	[Token(Token = "0x40065F1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string KeyItemID;

	// Token: 0x04006CD0 RID: 27856
	[Token(Token = "0x40065F2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ItemID _ItemID;

	// Token: 0x04006CD1 RID: 27857
	[Token(Token = "0x40065F3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GimmickLayoutID[] _TargetGimmickLayoutIDs;

	// Token: 0x04006CD2 RID: 27858
	[Token(Token = "0x40065F4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool[] _TargetValueInverts;

	// Token: 0x04006CD3 RID: 27859
	[Token(Token = "0x40065F5")]
	[FieldOffset(Offset = "0x40")]
	public OnChangeGimmickSwitch OnChangeGimmickSwitch;

	// Token: 0x04006CD4 RID: 27860
	[Token(Token = "0x40065F6")]
	[FieldOffset(Offset = "0x48")]
	[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x167B60", Offset = "0x167C61")]
	[SerializeField]
	protected string FocusTextID;

	// Token: 0x04006CD5 RID: 27861
	[Token(Token = "0x40065F7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected string ButtonGuideTextID;

	// Token: 0x04006CD6 RID: 27862
	[Token(Token = "0x40065F8")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected string ItemGuideTextID;

	// Token: 0x04006CD7 RID: 27863
	[Token(Token = "0x40065F9")]
	[FieldOffset(Offset = "0x60")]
	protected string FocusText;

	// Token: 0x04006CD8 RID: 27864
	[Token(Token = "0x40065FA")]
	[FieldOffset(Offset = "0x68")]
	protected string ButtonGuideText;

	// Token: 0x04006CD9 RID: 27865
	[Token(Token = "0x40065FB")]
	[FieldOffset(Offset = "0x70")]
	protected string ItemGuideText;

	// Token: 0x04006CDA RID: 27866
	[Token(Token = "0x40065FC")]
	[FieldOffset(Offset = "0x78")]
	protected Collider SwitchCollider;

	// Token: 0x020005F2 RID: 1522
	[Token(Token = "0x2001133")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158090", Offset = "0x158191")]
	private sealed class <WaitEventEnd>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600259E RID: 9630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070C9")]
		[Address(RVA = "0x1FEDF60", Offset = "0x1FEE061", VA = "0x1FEDF60")]
		[DebuggerHidden]
		public <WaitEventEnd>d__37(int <>1__state)
		{
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CA")]
		[Address(RVA = "0x1FEE2B0", Offset = "0x1FEE3B1", VA = "0x1FEE2B0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x0000F000 File Offset: 0x0000D200
		[Token(Token = "0x60070CB")]
		[Address(RVA = "0x1FEE2C0", Offset = "0x1FEE3C1", VA = "0x1FEE2C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF7")]
		private object Current
		{
			[Token(Token = "0x60070CC")]
			[Address(RVA = "0x1FEE430", Offset = "0x1FEE531", VA = "0x1FEE430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070CD")]
		[Address(RVA = "0x1FEE440", Offset = "0x1FEE541", VA = "0x1FEE440", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CF8")]
		private object Current
		{
			[Token(Token = "0x60070CE")]
			[Address(RVA = "0x1FEE4A0", Offset = "0x1FEE5A1", VA = "0x1FEE4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04006CDB RID: 27867
		[Token(Token = "0x4019351")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04006CDC RID: 27868
		[Token(Token = "0x4019352")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04006CDD RID: 27869
		[Token(Token = "0x4019353")]
		[FieldOffset(Offset = "0x20")]
		public GimmickYasaiSwitch <>4__this;
	}
}
