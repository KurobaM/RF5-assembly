using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A19 RID: 2585
[Token(Token = "0x20006C6")]
public class GenerateItemSlot : UIScrollBoxBase
{
	// Token: 0x17000936 RID: 2358
	// (get) Token: 0x060043B3 RID: 17331 RVA: 0x000169E0 File Offset: 0x00014BE0
	[Token(Token = "0x17000762")]
	protected override int RowMax
	{
		[Token(Token = "0x600389F")]
		[Address(RVA = "0x1FA61A0", Offset = "0x1FA62A1", VA = "0x1FA61A0", Slot = "4")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000937 RID: 2359
	// (get) Token: 0x060043B4 RID: 17332 RVA: 0x000169F8 File Offset: 0x00014BF8
	[Token(Token = "0x17000763")]
	public StorageType StorageType
	{
		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x1FA61B0", Offset = "0x1FA62B1", VA = "0x1FA61B0")]
		get
		{
			return StorageType.Rucksack;
		}
	}

	// Token: 0x17000938 RID: 2360
	// (get) Token: 0x060043B5 RID: 17333 RVA: 0x00016A10 File Offset: 0x00014C10
	// (set) Token: 0x060043B6 RID: 17334 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000764")]
	public bool Generated
	{
		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x1FA61C0", Offset = "0x1FA62C1", VA = "0x1FA61C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7780", Offset = "0x1A7881")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x1FA61D0", Offset = "0x1FA62D1", VA = "0x1FA61D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7790", Offset = "0x1A7891")]
		private set
		{
		}
	}

	// Token: 0x17000939 RID: 2361
	// (get) Token: 0x060043B7 RID: 17335 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000765")]
	private ItemStorage ItemStorage
	{
		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x1FA61E0", Offset = "0x1FA62E1", VA = "0x1FA61E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060043B8 RID: 17336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038A4")]
	[Address(RVA = "0x1FA6250", Offset = "0x1FA6351", VA = "0x1FA6250")]
	private void OnEnable()
	{
	}

	// Token: 0x060043B9 RID: 17337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038A5")]
	[Address(RVA = "0x1FA6550", Offset = "0x1FA6651", VA = "0x1FA6550")]
	public void SortItem()
	{
	}

	// Token: 0x060043BA RID: 17338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038A6")]
	[Address(RVA = "0x1FA68B0", Offset = "0x1FA69B1", VA = "0x1FA68B0")]
	public void SetSubSortItem(int subSortType)
	{
	}

	// Token: 0x060043BB RID: 17339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038A7")]
	[Address(RVA = "0x1FA62F0", Offset = "0x1FA63F1", VA = "0x1FA62F0")]
	private void GenerateItemBlock()
	{
	}

	// Token: 0x060043BC RID: 17340 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038A8")]
	[Address(RVA = "0x1FA6950", Offset = "0x1FA6A51", VA = "0x1FA6950")]
	private void SetNameText()
	{
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038A9")]
	[Address(RVA = "0x1FA6AB0", Offset = "0x1FA6BB1", VA = "0x1FA6AB0")]
	public void SetStorage(StorageType _storageType)
	{
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038AA")]
	[Address(RVA = "0x1FA6B00", Offset = "0x1FA6C01", VA = "0x1FA6B00")]
	public void ChangeStorage(StorageType _storageType)
	{
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x00016A28 File Offset: 0x00014C28
	[Token(Token = "0x60038AB")]
	[Address(RVA = "0x1FA6BD0", Offset = "0x1FA6CD1", VA = "0x1FA6BD0")]
	public bool CheckItemFilterGuard(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060043C0 RID: 17344 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60038AC")]
	[Address(RVA = "0x1FA6CA0", Offset = "0x1FA6DA1", VA = "0x1FA6CA0")]
	public UIItemSlot GetEmptySlot()
	{
		return null;
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038AD")]
	[Address(RVA = "0x1FA6E10", Offset = "0x1FA6F11", VA = "0x1FA6E10")]
	public void OpenItemSortMenu()
	{
	}

	// Token: 0x060043C2 RID: 17346 RVA: 0x00016A40 File Offset: 0x00014C40
	[Token(Token = "0x60038AE")]
	[Address(RVA = "0x1FA6F00", Offset = "0x1FA7001", VA = "0x1FA6F00", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038AF")]
	[Address(RVA = "0x1FA6F80", Offset = "0x1FA7081", VA = "0x1FA6F80", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x060043C4 RID: 17348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B0")]
	[Address(RVA = "0x1FA70A0", Offset = "0x1FA71A1", VA = "0x1FA70A0", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B1")]
	[Address(RVA = "0x1FA70B0", Offset = "0x1FA71B1", VA = "0x1FA70B0")]
	public GenerateItemSlot()
	{
	}

	// Token: 0x0400A29C RID: 41628
	[Token(Token = "0x4007ADB")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private UISortBlock UISortBlock;

	// Token: 0x0400A29D RID: 41629
	[Token(Token = "0x4007ADC")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public GenerateItemSlot ConnectingSlot;

	// Token: 0x0400A29E RID: 41630
	[Token(Token = "0x4007ADD")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public List<UIItemSlot> ForceQuickLinkItemslots;

	// Token: 0x0400A29F RID: 41631
	[Token(Token = "0x4007ADE")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private StorageType storageType;

	// Token: 0x0400A2A0 RID: 41632
	[Token(Token = "0x4007ADF")]
	[FieldOffset(Offset = "0x84")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x171A00", Offset = "0x171B01")]
	private bool <Generated>k__BackingField;

	// Token: 0x0400A2A1 RID: 41633
	[Token(Token = "0x4007AE0")]
	[FieldOffset(Offset = "0x88")]
	private CursorLinkConnector cursorConnector;

	// Token: 0x0400A2A2 RID: 41634
	[Token(Token = "0x4007AE1")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text NameText;
}
