using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000237 RID: 567
[Token(Token = "0x20001C8")]
public class HumanEquipment : AS_ToolController
{
	// Token: 0x17000297 RID: 663
	// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000277")]
	public HumanModel HumanModel
	{
		[Token(Token = "0x6000C0B")]
		[Address(RVA = "0x20A39B0", Offset = "0x20A3AB1", VA = "0x20A39B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD30", Offset = "0x19BE31")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x20A39C0", Offset = "0x20A3AC1", VA = "0x20A39C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD40", Offset = "0x19BE41")]
		private set
		{
		}
	}

	// Token: 0x17000298 RID: 664
	// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000278")]
	public HumanStatus HumanStatus
	{
		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x20A39D0", Offset = "0x20A3AD1", VA = "0x20A39D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD50", Offset = "0x19BE51")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x20A39E0", Offset = "0x20A3AE1", VA = "0x20A39E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD60", Offset = "0x19BE61")]
		private set
		{
		}
	}

	// Token: 0x17000299 RID: 665
	// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000279")]
	public UnityEventDicHumanItemEquip ResetDicHumanItemEquipEvent
	{
		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x20A39F0", Offset = "0x20A3AF1", VA = "0x20A39F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD70", Offset = "0x19BE71")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x20A3A00", Offset = "0x20A3B01", VA = "0x20A3A00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD80", Offset = "0x19BE81")]
		set
		{
		}
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x000064B0 File Offset: 0x000046B0
	[Token(Token = "0x6000C11")]
	[Address(RVA = "0x20A3A10", Offset = "0x20A3B11", VA = "0x20A3A10")]
	public bool CanEquip(EquipSlotType slot_type)
	{
		return default(bool);
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x209C940", Offset = "0x209CA41", VA = "0x209C940")]
	public void ResetEquip(bool enableWeaponAndTool)
	{
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x209CCE0", Offset = "0x209CDE1", VA = "0x209CCE0")]
	public bool Equip(EquipSlotType slot_type)
	{
		return default(bool);
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x20A3B70", Offset = "0x20A3C71", VA = "0x20A3B70")]
	private void ClearEquipItem(HumanEquipItem equipItem)
	{
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x20A3A80", Offset = "0x20A3B81", VA = "0x20A3A80")]
	public bool UnEquip(EquipSlotType slot_type)
	{
		return default(bool);
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C16")]
	[Address(RVA = "0x2097560", Offset = "0x2097661", VA = "0x2097560")]
	public void UnEquipAll()
	{
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C17")]
	[Address(RVA = "0x2097EB0", Offset = "0x2097FB1", VA = "0x2097EB0")]
	public void SetVisible(EquipSlotType slot_type, bool visible)
	{
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C18")]
	[Address(RVA = "0x20A3ED0", Offset = "0x20A3FD1", VA = "0x20A3ED0")]
	public ItemData GetItemData(EquipSlotType slot_type)
	{
		return null;
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000C19")]
	[Address(RVA = "0x20A3F80", Offset = "0x20A4081", VA = "0x20A3F80")]
	public ItemEquip[] GetItemEquip(EquipSlotType slot_type)
	{
		return null;
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1A")]
	[Address(RVA = "0x2097B30", Offset = "0x2097C31", VA = "0x2097B30")]
	public void OnUpdate()
	{
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1B")]
	[Address(RVA = "0x2096F70", Offset = "0x2097071", VA = "0x2096F70")]
	public void Init(HumanController humanController)
	{
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1C")]
	[Address(RVA = "0x20A4030", Offset = "0x20A4131", VA = "0x20A4030", Slot = "8")]
	protected override void Awake()
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1D")]
	[Address(RVA = "0x20A41A0", Offset = "0x20A42A1", VA = "0x20A41A0")]
	protected void Start()
	{
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1E")]
	[Address(RVA = "0x20A4460", Offset = "0x20A4561", VA = "0x20A4460")]
	private void ItemLoaded(EquipSlotType slot_type, ItemID item_id)
	{
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C1F")]
	[Address(RVA = "0x20A3C80", Offset = "0x20A3D81", VA = "0x20A3C80")]
	private void AttachEquips(EquipSlotType slot_type, HumanEquipItem equipItem)
	{
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000064F8 File Offset: 0x000046F8
	// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700027A")]
	public bool InitedToolEquip
	{
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x20A4610", Offset = "0x20A4711", VA = "0x20A4610")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD90", Offset = "0x19BE91")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x20A4620", Offset = "0x20A4721", VA = "0x20A4620")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BDA0", Offset = "0x19BEA1")]
		protected set
		{
		}
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x20A4630", Offset = "0x20A4731", VA = "0x20A4630")]
	private void OnOpenToolEquip()
	{
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x2094C90", Offset = "0x2094D91", VA = "0x2094C90")]
	public void OpenToolEquip(EquipSlotType equipSlotType)
	{
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x20953B0", Offset = "0x20954B1", VA = "0x20953B0")]
	public void CloseToolEquip()
	{
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x2094C10", Offset = "0x2094D11", VA = "0x2094C10")]
	public void OnOpenedToolEquip()
	{
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x20951B0", Offset = "0x20952B1", VA = "0x20951B0")]
	public void OnClosedToolEquip()
	{
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C27")]
	[Address(RVA = "0x20A4640", Offset = "0x20A4741", VA = "0x20A4640")]
	public HumanEquipment()
	{
	}

	// Token: 0x040007C7 RID: 1991
	[Token(Token = "0x4000652")]
	[FieldOffset(Offset = "0x1C0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DF70", Offset = "0x15E071")]
	private HumanModel <HumanModel>k__BackingField;

	// Token: 0x040007C8 RID: 1992
	[Token(Token = "0x4000653")]
	[FieldOffset(Offset = "0x1C8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DF80", Offset = "0x15E081")]
	private HumanStatus <HumanStatus>k__BackingField;

	// Token: 0x040007C9 RID: 1993
	[Token(Token = "0x4000654")]
	[FieldOffset(Offset = "0x1D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DF90", Offset = "0x15E091")]
	private UnityEventDicHumanItemEquip <ResetDicHumanItemEquipEvent>k__BackingField;

	// Token: 0x040007CA RID: 1994
	[Token(Token = "0x4000655")]
	[FieldOffset(Offset = "0x1D8")]
	private readonly EquipSlotType[] EquipItemSlots;

	// Token: 0x040007CB RID: 1995
	[Token(Token = "0x4000656")]
	[FieldOffset(Offset = "0x1E0")]
	private Dictionary<EquipSlotType, HumanEquipItem> EquipItemList;

	// Token: 0x040007CC RID: 1996
	[Token(Token = "0x4000657")]
	[FieldOffset(Offset = "0x1E8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DFA0", Offset = "0x15E0A1")]
	private bool <InitedToolEquip>k__BackingField;

	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000FF8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157270", Offset = "0x157371")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x06000D87 RID: 3463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4A")]
		[Address(RVA = "0x20A3B60", Offset = "0x20A3C61", VA = "0x20A3B60")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4B")]
		[Address(RVA = "0x20A4710", Offset = "0x20A4811", VA = "0x20A4710")]
		internal void <Equip>b__0(ItemID itemID)
		{
		}

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x4018DE8")]
		[FieldOffset(Offset = "0x10")]
		public HumanEquipment <>4__this;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x4018DE9")]
		[FieldOffset(Offset = "0x18")]
		public EquipSlotType slot_type;
	}
}
