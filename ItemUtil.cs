using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000647 RID: 1607
[Token(Token = "0x2000483")]
public class ItemUtil
{
	// Token: 0x060027A9 RID: 10153 RVA: 0x0000FB28 File Offset: 0x0000DD28
	[Token(Token = "0x600217D")]
	[Address(RVA = "0x22416D0", Offset = "0x22417D1", VA = "0x22416D0")]
	public static EquipPointType GetEquipPointType(ItemData itemData)
	{
		return EquipPointType.Tool;
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x0000FB40 File Offset: 0x0000DD40
	[Token(Token = "0x600217E")]
	[Address(RVA = "0x223E8D0", Offset = "0x223E9D1", VA = "0x223E8D0")]
	public static bool GetIsStack(ItemID itemId)
	{
		return default(bool);
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600217F")]
	[Address(RVA = "0x22417F0", Offset = "0x22418F1", VA = "0x22417F0")]
	public ItemUtil()
	{
	}

	// Token: 0x04006F40 RID: 28480
	[Token(Token = "0x40067F2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<ItemType, EquipPointType> ItemTypeToEquipSlotTable;

	// Token: 0x04006F41 RID: 28481
	[Token(Token = "0x40067F3")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<ItemType, bool> ConvItemTypeToIsStackable;
}
