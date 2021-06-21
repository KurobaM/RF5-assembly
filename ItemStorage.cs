using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;

// Token: 0x02000640 RID: 1600
[Token(Token = "0x2000482")]
public class ItemStorage
{
	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x06002769 RID: 10089 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000502")]
	public ItemData[] ItemDatas
	{
		[Token(Token = "0x6002147")]
		[Address(RVA = "0x223AB20", Offset = "0x223AC21", VA = "0x223AB20")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000649 RID: 1609
	// (get) Token: 0x0600276A RID: 10090 RVA: 0x0000F858 File Offset: 0x0000DA58
	// (set) Token: 0x0600276B RID: 10091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000503")]
	public StorageType StorageType
	{
		[Token(Token = "0x6002148")]
		[Address(RVA = "0x223AB40", Offset = "0x223AC41", VA = "0x223AB40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1CB0", Offset = "0x1A1DB1")]
		get
		{
			return StorageType.Rucksack;
		}
		[Token(Token = "0x6002149")]
		[Address(RVA = "0x223AB50", Offset = "0x223AC51", VA = "0x223AB50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1CC0", Offset = "0x1A1DC1")]
		private set
		{
		}
	}

	// Token: 0x1700064A RID: 1610
	// (get) Token: 0x0600276C RID: 10092 RVA: 0x0000F870 File Offset: 0x0000DA70
	// (set) Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000504")]
	private int ReleasedLv
	{
		[Token(Token = "0x600214A")]
		[Address(RVA = "0x223AB60", Offset = "0x223AC61", VA = "0x223AB60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1CD0", Offset = "0x1A1DD1")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x223AB70", Offset = "0x223AC71", VA = "0x223AB70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1CE0", Offset = "0x1A1DE1")]
		set
		{
		}
	}

	// Token: 0x1700064B RID: 1611
	// (get) Token: 0x0600276E RID: 10094 RVA: 0x0000F888 File Offset: 0x0000DA88
	[Token(Token = "0x17000505")]
	public int NowStorageSize
	{
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x223AB80", Offset = "0x223AC81", VA = "0x223AB80")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700064C RID: 1612
	// (get) Token: 0x0600276F RID: 10095 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000506")]
	public ItemDataLinker[] ItemDataLinkers
	{
		[Token(Token = "0x600214D")]
		[Address(RVA = "0x223AC30", Offset = "0x223AD31", VA = "0x223AC30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1CF0", Offset = "0x1A1DF1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x223AC40", Offset = "0x223AD41", VA = "0x223AC40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D00", Offset = "0x1A1E01")]
		private set
		{
		}
	}

	// Token: 0x1700064D RID: 1613
	// (get) Token: 0x06002771 RID: 10097 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000507")]
	private List<ItemData> ItemList
	{
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x223AC50", Offset = "0x223AD51", VA = "0x223AC50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D10", Offset = "0x1A1E11")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x223AC60", Offset = "0x223AD61", VA = "0x223AC60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D20", Offset = "0x1A1E21")]
		set
		{
		}
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002151")]
	[Address(RVA = "0x223AC70", Offset = "0x223AD71", VA = "0x223AC70")]
	public ItemStorage(StorageType storageType)
	{
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002152")]
	[Address(RVA = "0x223B210", Offset = "0x223B311", VA = "0x223B210")]
	public void Init(ItemStorageData storageData)
	{
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002153")]
	[Address(RVA = "0x223B480", Offset = "0x223B581", VA = "0x223B480")]
	public void Reset()
	{
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002154")]
	[Address(RVA = "0x223B340", Offset = "0x223B441", VA = "0x223B340")]
	private void InitDataLinker()
	{
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002155")]
	[Address(RVA = "0x223B240", Offset = "0x223B341", VA = "0x223B240")]
	public void SetReleasedLv()
	{
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002156")]
	[Address(RVA = "0x223B4B0", Offset = "0x223B5B1", VA = "0x223B4B0")]
	public List<ItemDataLinker> GetDataLinkerList(params ItemCategory[] itemCategories)
	{
		return null;
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002157")]
	[Address(RVA = "0x223B710", Offset = "0x223B811", VA = "0x223B710")]
	public List<ItemDataLinker> GetDataLinkerList(params ItemType[] itemTypes)
	{
		return null;
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002158")]
	[Address(RVA = "0x223B790", Offset = "0x223B891", VA = "0x223B790")]
	public List<ItemDataLinker> GetDataLinkerList(uint FilterType)
	{
		return null;
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002159")]
	[Address(RVA = "0x223B9B0", Offset = "0x223BAB1", VA = "0x223B9B0")]
	public void CompressItem()
	{
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
	[Token(Token = "0x600215A")]
	[Address(RVA = "0x223BFD0", Offset = "0x223C0D1", VA = "0x223BFD0")]
	public bool CompressForOneSlot()
	{
		return default(bool);
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600215B")]
	[Address(RVA = "0x223C6D0", Offset = "0x223C7D1", VA = "0x223C6D0")]
	public ItemData PushAllInAnyStorage(ItemData itemData)
	{
		return null;
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
	[Token(Token = "0x600215C")]
	[Address(RVA = "0x223CCA0", Offset = "0x223CDA1", VA = "0x223CCA0")]
	private ulong GetSortVal(ItemData item)
	{
		return 0UL;
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
	[Token(Token = "0x600215D")]
	[Address(RVA = "0x223D080", Offset = "0x223D181", VA = "0x223D080")]
	private int GetSortHeadId(ItemType itemType)
	{
		return 0;
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600215E")]
	[Address(RVA = "0x223D110", Offset = "0x223D211", VA = "0x223D110")]
	private void DoSortItem()
	{
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
	[Token(Token = "0x600215F")]
	[Address(RVA = "0x223D3C0", Offset = "0x223D4C1", VA = "0x223D3C0")]
	private bool CheckHasSortItem(int sortId)
	{
		return default(bool);
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002160")]
	[Address(RVA = "0x223D4A0", Offset = "0x223D5A1", VA = "0x223D4A0")]
	public void SetSortBlock(UISortBlock UISortBlock)
	{
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x0000F900 File Offset: 0x0000DB00
	[Token(Token = "0x6002161")]
	[Address(RVA = "0x223D4D0", Offset = "0x223D5D1", VA = "0x223D4D0")]
	private bool CheckToNextSortCategory()
	{
		return default(bool);
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002162")]
	[Address(RVA = "0x223D5A0", Offset = "0x223D6A1", VA = "0x223D5A0")]
	public void SortItem()
	{
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002163")]
	[Address(RVA = "0x223D640", Offset = "0x223D741", VA = "0x223D640")]
	public void SetSubSortType(SubSortType type)
	{
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002164")]
	[Address(RVA = "0x223D650", Offset = "0x223D751", VA = "0x223D650")]
	private List<ItemDataLinker> GetItemListOnFilter(ItemType itemType)
	{
		return null;
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x0000F918 File Offset: 0x0000DB18
	[Token(Token = "0x6002165")]
	[Address(RVA = "0x223C620", Offset = "0x223C721", VA = "0x223C620")]
	public int CheckFreeSpace()
	{
		return 0;
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002166")]
	[Address(RVA = "0x223D770", Offset = "0x223D871", VA = "0x223D770")]
	public ItemData PushItemInEmptySlot(ItemData itemData)
	{
		return null;
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x0000F930 File Offset: 0x0000DB30
	[Token(Token = "0x6002167")]
	[Address(RVA = "0x223D850", Offset = "0x223D951", VA = "0x223D850")]
	public ItemStorage.PushItemResult PushItemInWithResult(ItemData itemData)
	{
		return ItemStorage.PushItemResult.NoChange;
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x0000F948 File Offset: 0x0000DB48
	[Token(Token = "0x6002168")]
	[Address(RVA = "0x223C990", Offset = "0x223CA91", VA = "0x223C990")]
	public bool PushItemIn(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002169")]
	[Address(RVA = "0x223DAA0", Offset = "0x223DBA1", VA = "0x223DAA0")]
	public ItemDataLinker TakeItem(ItemID itemId)
	{
		return null;
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600216A")]
	[Address(RVA = "0x223DB70", Offset = "0x223DC71", VA = "0x223DB70")]
	public void RemoveItem(ItemID itemId)
	{
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600216B")]
	[Address(RVA = "0x223DC60", Offset = "0x223DD61", VA = "0x223DC60")]
	public void RemoveAllItem()
	{
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600216C")]
	[Address(RVA = "0x223DCE0", Offset = "0x223DDE1", VA = "0x223DCE0")]
	private List<ItemDataLinker> GetItemListOnFilter(int itemType)
	{
		return null;
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x0000F960 File Offset: 0x0000DB60
	[Token(Token = "0x600216D")]
	[Address(RVA = "0x223DE00", Offset = "0x223DF01", VA = "0x223DE00")]
	public ItemStorage.PushItemResult CheckCanPushAllResult(ItemData itemData)
	{
		return ItemStorage.PushItemResult.NoChange;
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x0000F978 File Offset: 0x0000DB78
	[Token(Token = "0x600216E")]
	[Address(RVA = "0x223DFD0", Offset = "0x223E0D1", VA = "0x223DFD0")]
	public bool CheckCanPushAll(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x0000F990 File Offset: 0x0000DB90
	[Token(Token = "0x600216F")]
	[Address(RVA = "0x223DA80", Offset = "0x223DB81", VA = "0x223DA80")]
	public bool CheckItemGuard(ItemType type)
	{
		return default(bool);
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002170")]
	[Address(RVA = "0x223E180", Offset = "0x223E281", VA = "0x223E180")]
	public ItemData PopInventorySlot(int index)
	{
		return null;
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002171")]
	[Address(RVA = "0x223E1E0", Offset = "0x223E2E1", VA = "0x223E1E0")]
	public List<ItemData> PopInventoryAmount(ItemID itemID, int amount)
	{
		return null;
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
	[Token(Token = "0x6002172")]
	[Address(RVA = "0x223CC80", Offset = "0x223CD81", VA = "0x223CC80")]
	public bool CanAddItem(ItemData inventoryItemData)
	{
		return default(bool);
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
	[Token(Token = "0x6002173")]
	[Address(RVA = "0x223E560", Offset = "0x223E661", VA = "0x223E560")]
	private int IndexOf(ItemData inventoryItemData)
	{
		return 0;
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
	[Token(Token = "0x6002174")]
	[Address(RVA = "0x223E410", Offset = "0x223E511", VA = "0x223E410")]
	private int IndexOfWithAddable(ItemData inventoryItemData)
	{
		return 0;
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
	[Token(Token = "0x6002175")]
	[Address(RVA = "0x223E660", Offset = "0x223E761", VA = "0x223E660")]
	public int GetItemAmoutId(ItemID itemId)
	{
		return 0;
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x0000FA08 File Offset: 0x0000DC08
	[Token(Token = "0x6002176")]
	[Address(RVA = "0x223E740", Offset = "0x223E841", VA = "0x223E740")]
	public int GetSpaceToInput(ItemID itemId)
	{
		return 0;
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x0000FA20 File Offset: 0x0000DC20
	[Token(Token = "0x6002177")]
	[Address(RVA = "0x223E9C0", Offset = "0x223EAC1", VA = "0x223E9C0")]
	public bool IsItemIdInside(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x0000FA38 File Offset: 0x0000DC38
	[Token(Token = "0x6002178")]
	[Address(RVA = "0x223E9E0", Offset = "0x223EAE1", VA = "0x223E9E0")]
	public int IndexOf(ItemID itemID)
	{
		return 0;
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x0000FA50 File Offset: 0x0000DC50
	[Token(Token = "0x6002179")]
	[Address(RVA = "0x223EA90", Offset = "0x223EB91", VA = "0x223EA90")]
	public int IndexOf(ItemCategory itemCategory)
	{
		return 0;
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x0000FA68 File Offset: 0x0000DC68
	[Token(Token = "0x600217A")]
	[Address(RVA = "0x223EB50", Offset = "0x223EC51", VA = "0x223EB50")]
	public int HasItemCount(ItemID itemID)
	{
		return 0;
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x0000FA80 File Offset: 0x0000DC80
	[Token(Token = "0x600217B")]
	[Address(RVA = "0x223CC10", Offset = "0x223CD11", VA = "0x223CC10")]
	public bool IsCanAccess()
	{
		return default(bool);
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x0000FA98 File Offset: 0x0000DC98
	[Token(Token = "0x600217C")]
	[Address(RVA = "0x223EC00", Offset = "0x223ED01", VA = "0x223EC00")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D30", Offset = "0x1A1E31")]
	private int <DoSortItem>b__45_1(ItemData a, ItemData b)
	{
		return 0;
	}

	// Token: 0x04006F1B RID: 28443
	[Token(Token = "0x40067E4")]
	[FieldOffset(Offset = "0x10")]
	private ItemStorageData ItemStorageData;

	// Token: 0x04006F1C RID: 28444
	[Token(Token = "0x40067E5")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168430", Offset = "0x168531")]
	private StorageType <StorageType>k__BackingField;

	// Token: 0x04006F1D RID: 28445
	[Token(Token = "0x40067E6")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168440", Offset = "0x168541")]
	private int <ReleasedLv>k__BackingField;

	// Token: 0x04006F1E RID: 28446
	[Token(Token = "0x40067E7")]
	[FieldOffset(Offset = "0x20")]
	private readonly MakingID[][] ReleaseIdTable;

	// Token: 0x04006F1F RID: 28447
	[Token(Token = "0x40067E8")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168450", Offset = "0x168551")]
	private ItemDataLinker[] <ItemDataLinkers>k__BackingField;

	// Token: 0x04006F20 RID: 28448
	[Token(Token = "0x40067E9")]
	[FieldOffset(Offset = "0x30")]
	private uint ItemGuardFilter;

	// Token: 0x04006F21 RID: 28449
	[Token(Token = "0x40067EA")]
	[FieldOffset(Offset = "0x38")]
	private readonly uint[] SortHead;

	// Token: 0x04006F22 RID: 28450
	[Token(Token = "0x40067EB")]
	[FieldOffset(Offset = "0x40")]
	private int nowCategorySortType;

	// Token: 0x04006F23 RID: 28451
	[Token(Token = "0x40067EC")]
	[FieldOffset(Offset = "0x44")]
	private int nowSortSubType;

	// Token: 0x04006F24 RID: 28452
	[Token(Token = "0x40067ED")]
	[FieldOffset(Offset = "0x48")]
	private bool SubSortTypeReverse;

	// Token: 0x04006F25 RID: 28453
	[Token(Token = "0x40067EE")]
	[FieldOffset(Offset = "0x50")]
	private bool[,] SortPriorityProb;

	// Token: 0x04006F26 RID: 28454
	[Token(Token = "0x40067EF")]
	[FieldOffset(Offset = "0x58")]
	private ulong[] SortPriorityIndex;

	// Token: 0x04006F27 RID: 28455
	[Token(Token = "0x40067F0")]
	[FieldOffset(Offset = "0x60")]
	private ulong[] SortPriorityReverseVal;

	// Token: 0x04006F28 RID: 28456
	[Token(Token = "0x40067F1")]
	[FieldOffset(Offset = "0x68")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168460", Offset = "0x168561")]
	private List<ItemData> <ItemList>k__BackingField;

	// Token: 0x02000641 RID: 1601
	[Token(Token = "0x2001147")]
	public enum PushItemResult
	{
		// Token: 0x04006F2A RID: 28458
		[Token(Token = "0x40193AB")]
		NoChange,
		// Token: 0x04006F2B RID: 28459
		[Token(Token = "0x40193AC")]
		Remain,
		// Token: 0x04006F2C RID: 28460
		[Token(Token = "0x40193AD")]
		PushAll
	}

	// Token: 0x02000642 RID: 1602
	[Token(Token = "0x2001148")]
	private enum SortPriority
	{
		// Token: 0x04006F2E RID: 28462
		[Token(Token = "0x40193AF")]
		Price,
		// Token: 0x04006F2F RID: 28463
		[Token(Token = "0x40193B0")]
		FilterCatalog,
		// Token: 0x04006F30 RID: 28464
		[Token(Token = "0x40193B1")]
		EquipCatalog,
		// Token: 0x04006F31 RID: 28465
		[Token(Token = "0x40193B2")]
		Id,
		// Token: 0x04006F32 RID: 28466
		[Token(Token = "0x40193B3")]
		Atk,
		// Token: 0x04006F33 RID: 28467
		[Token(Token = "0x40193B4")]
		MAtk,
		// Token: 0x04006F34 RID: 28468
		[Token(Token = "0x40193B5")]
		Def,
		// Token: 0x04006F35 RID: 28469
		[Token(Token = "0x40193B6")]
		MDef,
		// Token: 0x04006F36 RID: 28470
		[Token(Token = "0x40193B7")]
		Lv,
		// Token: 0x04006F37 RID: 28471
		[Token(Token = "0x40193B8")]
		Amount,
		// Token: 0x04006F38 RID: 28472
		[Token(Token = "0x40193B9")]
		Max
	}

	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2001149")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158150", Offset = "0x158251")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710E")]
		[Address(RVA = "0x223ECC0", Offset = "0x223EDC1", VA = "0x223ECC0")]
		public <>c()
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		[Token(Token = "0x600710F")]
		[Address(RVA = "0x223ECD0", Offset = "0x223EDD1", VA = "0x223ECD0")]
		internal int <CompressItem>b__40_0(int a, int b)
		{
			return 0;
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6007110")]
		[Address(RVA = "0x223ECE0", Offset = "0x223EDE1", VA = "0x223ECE0")]
		internal bool <DoSortItem>b__45_0(ItemData item)
		{
			return default(bool);
		}

		// Token: 0x04006F39 RID: 28473
		[Token(Token = "0x40193BA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ItemStorage.<>c <>9;

		// Token: 0x04006F3A RID: 28474
		[Token(Token = "0x40193BB")]
		[FieldOffset(Offset = "0x8")]
		public static Comparison<int> <>9__40_0;

		// Token: 0x04006F3B RID: 28475
		[Token(Token = "0x40193BC")]
		[FieldOffset(Offset = "0x10")]
		public static Predicate<ItemData> <>9__45_0;
	}

	// Token: 0x02000644 RID: 1604
	[Token(Token = "0x200114A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158160", Offset = "0x158261")]
	private sealed class <>c__DisplayClass41_0
	{
		// Token: 0x060027A3 RID: 10147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007111")]
		[Address(RVA = "0x223C6C0", Offset = "0x223C7C1", VA = "0x223C6C0")]
		public <>c__DisplayClass41_0()
		{
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x6007112")]
		[Address(RVA = "0x223ECF0", Offset = "0x223EDF1", VA = "0x223ECF0")]
		internal bool <CompressForOneSlot>b__0(ItemDataLinker a)
		{
			return default(bool);
		}

		// Token: 0x04006F3C RID: 28476
		[Token(Token = "0x40193BD")]
		[FieldOffset(Offset = "0x10")]
		public int mainSlot;

		// Token: 0x04006F3D RID: 28477
		[Token(Token = "0x40193BE")]
		[FieldOffset(Offset = "0x18")]
		public ItemStorage <>4__this;
	}

	// Token: 0x02000645 RID: 1605
	[Token(Token = "0x200114B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158170", Offset = "0x158271")]
	private sealed class <>c__DisplayClass51_0
	{
		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007113")]
		[Address(RVA = "0x223D760", Offset = "0x223D861", VA = "0x223D760")]
		public <>c__DisplayClass51_0()
		{
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x6007114")]
		[Address(RVA = "0x223EDF0", Offset = "0x223EEF1", VA = "0x223EDF0")]
		internal bool <GetItemListOnFilter>b__0(ItemDataLinker item)
		{
			return default(bool);
		}

		// Token: 0x04006F3E RID: 28478
		[Token(Token = "0x40193BF")]
		[FieldOffset(Offset = "0x10")]
		public ItemType itemType;
	}

	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x200114C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x158180", Offset = "0x158281")]
	private sealed class <>c__DisplayClass59_0
	{
		// Token: 0x060027A7 RID: 10151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007115")]
		[Address(RVA = "0x223DDF0", Offset = "0x223DEF1", VA = "0x223DDF0")]
		public <>c__DisplayClass59_0()
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x6007116")]
		[Address(RVA = "0x223EE70", Offset = "0x223EF71", VA = "0x223EE70")]
		internal bool <GetItemListOnFilter>b__0(ItemDataLinker item)
		{
			return default(bool);
		}

		// Token: 0x04006F3F RID: 28479
		[Token(Token = "0x40193C0")]
		[FieldOffset(Offset = "0x10")]
		public int itemType;
	}
}
