using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009D7 RID: 2519
[Token(Token = "0x2000698")]
public class UICraftSlot : UIItemSlot
{
	// Token: 0x17000918 RID: 2328
	// (get) Token: 0x060041E0 RID: 16864 RVA: 0x00016338 File Offset: 0x00014538
	[Token(Token = "0x17000748")]
	public override bool IsEquipItemSlot
	{
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x20083F0", Offset = "0x20084F1", VA = "0x20083F0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000919 RID: 2329
	// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00016350 File Offset: 0x00014550
	[Token(Token = "0x17000749")]
	public override bool isCraftSlot
	{
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x2008400", Offset = "0x2008501", VA = "0x2008400", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003706")]
	[Address(RVA = "0x2008410", Offset = "0x2008511", VA = "0x2008410", Slot = "21")]
	public override void SwapSlotA(UIItemSlot slotB)
	{
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003707")]
	[Address(RVA = "0x2008490", Offset = "0x2008591", VA = "0x2008490", Slot = "22")]
	public override void SwapSlotB(UIItemSlot slotA)
	{
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003708")]
	[Address(RVA = "0x2006190", Offset = "0x2006291", VA = "0x2006190")]
	public void SetStorageImage()
	{
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003709")]
	[Address(RVA = "0x20088B0", Offset = "0x20089B1", VA = "0x20088B0", Slot = "23")]
	protected override ItemData GetItemData()
	{
		return null;
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600370A")]
	[Address(RVA = "0x2008950", Offset = "0x2008A51", VA = "0x2008950", Slot = "24")]
	protected override void SetItemData(ItemData _itemData)
	{
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600370B")]
	[Address(RVA = "0x2008A40", Offset = "0x2008B41", VA = "0x2008A40", Slot = "25")]
	public override void ReDisp()
	{
	}

	// Token: 0x060041E8 RID: 16872 RVA: 0x00016368 File Offset: 0x00014568
	[Token(Token = "0x600370C")]
	[Address(RVA = "0x2008A70", Offset = "0x2008B71", VA = "0x2008A70", Slot = "26")]
	public override bool FilterCheck(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600370D")]
	[Address(RVA = "0x2008A80", Offset = "0x2008B81", VA = "0x2008A80", Slot = "27")]
	protected override void OnEnable()
	{
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600370E")]
	[Address(RVA = "0x20087F0", Offset = "0x20088F1", VA = "0x20087F0")]
	private void RestorageItem()
	{
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600370F")]
	[Address(RVA = "0x2008AC0", Offset = "0x2008BC1", VA = "0x2008AC0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003710")]
	[Address(RVA = "0x2008AD0", Offset = "0x2008BD1", VA = "0x2008AD0")]
	private void OnDisable()
	{
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003711")]
	[Address(RVA = "0x2008AE0", Offset = "0x2008BE1", VA = "0x2008AE0", Slot = "28")]
	public override void DoEquipInput(ActorID actorID, StorageType storageType)
	{
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003712")]
	[Address(RVA = "0x2008B70", Offset = "0x2008C71", VA = "0x2008B70")]
	public UICraftSlot()
	{
	}

	// Token: 0x0400A0CD RID: 41165
	[Token(Token = "0x4007956")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private Image StorageIconImage;

	// Token: 0x0400A0CE RID: 41166
	[Token(Token = "0x4007957")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private Sprite[] StorageSprites;

	// Token: 0x0400A0CF RID: 41167
	[Token(Token = "0x4007958")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private UICraftMenu UICraftMenu;

	// Token: 0x0400A0D0 RID: 41168
	[Token(Token = "0x4007959")]
	[FieldOffset(Offset = "0x0")]
	private static ItemData[] StockItemData;
}
