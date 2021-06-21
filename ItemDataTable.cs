using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using Loader.ID;
using UnityEngine;

// Token: 0x02000385 RID: 901
[Token(Token = "0x20002AF")]
[Serializable]
public class ItemDataTable
{
	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x060016EF RID: 5871 RVA: 0x0000A1A0 File Offset: 0x000083A0
	[Token(Token = "0x170003AC")]
	public ItemType ItemType
	{
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x2237580", Offset = "0x2237681", VA = "0x2237580")]
		get
		{
			return ItemType.Crop;
		}
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x060016F0 RID: 5872 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003AD")]
	public string ScreenName
	{
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x22375B0", Offset = "0x22376B1", VA = "0x22375B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x060016F1 RID: 5873 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003AE")]
	public string Describe
	{
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x2237740", Offset = "0x2237841", VA = "0x2237740")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170003AF")]
	public Sprite Image_Debug
	{
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x22378D0", Offset = "0x22379D1", VA = "0x22378D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001463")]
	[Address(RVA = "0x2236800", Offset = "0x2236901", VA = "0x2236800")]
	public static ItemDataTable GetDataTable(ItemID itemID)
	{
		return null;
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001464")]
	[Address(RVA = "0x22379F0", Offset = "0x2237AF1", VA = "0x22379F0")]
	public static SerializedItemDataTable[] GetDataTables()
	{
		return null;
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x0000A1B8 File Offset: 0x000083B8
	[Token(Token = "0x6001465")]
	[Address(RVA = "0x2237B10", Offset = "0x2237C11", VA = "0x2237B10")]
	public static int Length()
	{
		return 0;
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x0000A1D0 File Offset: 0x000083D0
	[Token(Token = "0x6001466")]
	[Address(RVA = "0x2237C40", Offset = "0x2237D41", VA = "0x2237C40")]
	public static ItemID GetItemID(int itemDataTableIndex)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001467")]
	[Address(RVA = "0x2237DC0", Offset = "0x2237EC1", VA = "0x2237DC0")]
	public static IEnumerable<ItemID> GetCategoryToItems(ItemCategory itemCategory)
	{
		return null;
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x0000A1E8 File Offset: 0x000083E8
	[Token(Token = "0x6001468")]
	[Address(RVA = "0x2237140", Offset = "0x2237241", VA = "0x2237140")]
	public static int CalcPrice(int basePrice, int tableIndex, int itemLv)
	{
		return 0;
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x0000A200 File Offset: 0x00008400
	[Token(Token = "0x6001469")]
	[Address(RVA = "0x2237F10", Offset = "0x2238011", VA = "0x2237F10")]
	public int GetShopPrice(int itemLv)
	{
		return 0;
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600146A")]
	[Address(RVA = "0x2237F30", Offset = "0x2238031", VA = "0x2237F30")]
	public ItemDataTable()
	{
	}

	// Token: 0x04000FA4 RID: 4004
	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string OnGroundItemPrefabPath;

	// Token: 0x04000FA5 RID: 4005
	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Prefab PrefabID;

	// Token: 0x04000FA6 RID: 4006
	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int ItemIndex;

	// Token: 0x04000FA7 RID: 4007
	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int ShopPriceTableIndex;

	// Token: 0x04000FA8 RID: 4008
	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int SellPriceTableIndex;

	// Token: 0x04000FA9 RID: 4009
	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public ItemCategory ItemCategory;

	// Token: 0x04000FAA RID: 4010
	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int ShopPrice;

	// Token: 0x04000FAB RID: 4011
	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int SellPrice;

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int UpgradeLevel;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string ModelName;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public string IconName;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ItemSize ItemSize;

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000C68")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int StackSize;

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000C69")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public CropID CropID;

	// Token: 0x04000FB2 RID: 4018
	[Token(Token = "0x4000C6A")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public HoldMotionType HoldMotionType;

	// Token: 0x04000FB3 RID: 4019
	[Token(Token = "0x4000C6B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public DropCapID DropCap;

	// Token: 0x04000FB4 RID: 4020
	[Token(Token = "0x4000C6C")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public bool IsAutoPickup;

	// Token: 0x04000FB5 RID: 4021
	[Token(Token = "0x4000C6D")]
	[FieldOffset(Offset = "0x0")]
	private static Sprite NotDefineSpriteAsset;

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0x8")]
	private static ItemDataTableArray _ItemDataTableArray;
}
