using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AD3 RID: 2771
[Token(Token = "0x2000741")]
public class UIStrengtheningSlot : UIItemSlot
{
	// Token: 0x17000990 RID: 2448
	// (get) Token: 0x060047F2 RID: 18418 RVA: 0x00017718 File Offset: 0x00015918
	[Token(Token = "0x170007AA")]
	public override bool isStrengtheningSlot
	{
		[Token(Token = "0x6003C3A")]
		[Address(RVA = "0x21213C0", Offset = "0x21214C1", VA = "0x21213C0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C3B")]
	[Address(RVA = "0x21213D0", Offset = "0x21214D1", VA = "0x21213D0", Slot = "21")]
	public override void SwapSlotA(UIItemSlot slotB)
	{
	}

	// Token: 0x060047F4 RID: 18420 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C3C")]
	[Address(RVA = "0x2121460", Offset = "0x2121561", VA = "0x2121460", Slot = "22")]
	public override void SwapSlotB(UIItemSlot slotA)
	{
	}

	// Token: 0x060047F5 RID: 18421 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C3D")]
	[Address(RVA = "0x2120B00", Offset = "0x2120C01", VA = "0x2120B00")]
	public void RestorageItem()
	{
	}

	// Token: 0x060047F6 RID: 18422 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C3E")]
	[Address(RVA = "0x21218A0", Offset = "0x21219A1", VA = "0x21218A0")]
	private void SetStorageIcon()
	{
	}

	// Token: 0x060047F7 RID: 18423 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003C3F")]
	[Address(RVA = "0x21219A0", Offset = "0x2121AA1", VA = "0x21219A0", Slot = "23")]
	protected override ItemData GetItemData()
	{
		return null;
	}

	// Token: 0x060047F8 RID: 18424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C40")]
	[Address(RVA = "0x2121A40", Offset = "0x2121B41", VA = "0x2121A40", Slot = "24")]
	protected override void SetItemData(ItemData _item_data)
	{
	}

	// Token: 0x060047F9 RID: 18425 RVA: 0x00017730 File Offset: 0x00015930
	[Token(Token = "0x6003C41")]
	[Address(RVA = "0x2121B30", Offset = "0x2121C31", VA = "0x2121B30", Slot = "26")]
	public override bool FilterCheck(ItemData _item_data)
	{
		return default(bool);
	}

	// Token: 0x060047FA RID: 18426 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C42")]
	[Address(RVA = "0x2121B70", Offset = "0x2121C71", VA = "0x2121B70", Slot = "28")]
	public override void DoEquipInput(ActorID actorID, StorageType storageType)
	{
	}

	// Token: 0x060047FB RID: 18427 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C43")]
	[Address(RVA = "0x2121C20", Offset = "0x2121D21", VA = "0x2121C20")]
	private void OnDestroy()
	{
	}

	// Token: 0x060047FC RID: 18428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C44")]
	[Address(RVA = "0x2121C30", Offset = "0x2121D31", VA = "0x2121C30", Slot = "27")]
	protected override void OnEnable()
	{
	}

	// Token: 0x060047FD RID: 18429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C45")]
	[Address(RVA = "0x2121C40", Offset = "0x2121D41", VA = "0x2121C40")]
	public UIStrengtheningSlot()
	{
	}

	// Token: 0x0400A753 RID: 42835
	[Token(Token = "0x4007E70")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private UIStrengthening.SlotType slotType;

	// Token: 0x0400A754 RID: 42836
	[Token(Token = "0x4007E71")]
	[FieldOffset(Offset = "0x0")]
	private static ItemData[] StrengtheningItems;

	// Token: 0x0400A755 RID: 42837
	[Token(Token = "0x4007E72")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UIStrengthening uiStrengthening;

	// Token: 0x0400A756 RID: 42838
	[Token(Token = "0x4007E73")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Image storageImage;

	// Token: 0x0400A757 RID: 42839
	[Token(Token = "0x4007E74")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private List<Sprite> storageIcon;
}
