using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000648 RID: 1608
[Token(Token = "0x2000484")]
public class ItemStorageManager : SingletonMonoBehaviour<ItemStorageManager>
{
	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x060027AD RID: 10157 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000508")]
	private ItemStorage[] Storages
	{
		[Token(Token = "0x6002181")]
		[Address(RVA = "0x223EF00", Offset = "0x223F001", VA = "0x223EF00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D40", Offset = "0x1A1E41")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002182")]
		[Address(RVA = "0x223EF10", Offset = "0x223F011", VA = "0x223EF10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1D50", Offset = "0x1A1E51")]
		set
		{
		}
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002183")]
	[Address(RVA = "0x223EF20", Offset = "0x223F021", VA = "0x223EF20", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002184")]
	[Address(RVA = "0x223F010", Offset = "0x223F111", VA = "0x223F010")]
	private void Start()
	{
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x0000FB58 File Offset: 0x0000DD58
	[Token(Token = "0x6002185")]
	[Address(RVA = "0x223F2D0", Offset = "0x223F3D1", VA = "0x223F2D0")]
	public static int GetAmountInAllStorage(ItemID itemID)
	{
		return 0;
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002186")]
	[Address(RVA = "0x223CB90", Offset = "0x223CC91", VA = "0x223CB90")]
	public static ItemStorage GetStorage(StorageType storageType)
	{
		return null;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002187")]
	[Address(RVA = "0x223F490", Offset = "0x223F591", VA = "0x223F490")]
	public static string GetStorageName(StorageType storageType)
	{
		return null;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x0000FB70 File Offset: 0x0000DD70
	[Token(Token = "0x6002188")]
	[Address(RVA = "0x223F8E0", Offset = "0x223F9E1", VA = "0x223F8E0")]
	public static bool CanRuckAddItem(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x0000FB88 File Offset: 0x0000DD88
	[Token(Token = "0x6002189")]
	[Address(RVA = "0x223FA00", Offset = "0x223FB01", VA = "0x223FA00")]
	public static bool CanRuckPushItemIn(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
	[Token(Token = "0x600218A")]
	[Address(RVA = "0x223FB10", Offset = "0x223FC11", VA = "0x223FB10")]
	public static bool RuckPushItemIn(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
	[Token(Token = "0x600218B")]
	[Address(RVA = "0x223FC60", Offset = "0x223FD61", VA = "0x223FC60")]
	public static int GetStorageMax(StorageType storageType)
	{
		return 0;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600218C")]
	[Address(RVA = "0x223F020", Offset = "0x223F121", VA = "0x223F020")]
	public void Initialize()
	{
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600218D")]
	[Address(RVA = "0x223FD10", Offset = "0x223FE11", VA = "0x223FD10")]
	public ItemStorageManager()
	{
	}

	// Token: 0x04006F42 RID: 28482
	[Token(Token = "0x40067F4")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168470", Offset = "0x168571")]
	private ItemStorage[] <Storages>k__BackingField;

	// Token: 0x04006F43 RID: 28483
	[Token(Token = "0x40067F5")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int[] MyStorageType;

	// Token: 0x04006F44 RID: 28484
	[Token(Token = "0x40067F6")]
	public const int StorageUpgradeLvMax = 8;

	// Token: 0x04006F45 RID: 28485
	[Token(Token = "0x40067F7")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int[,] StorageSize;
}
