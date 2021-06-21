using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000236 RID: 566
[Token(Token = "0x20001C7")]
[Serializable]
public class HumanEquipItem
{
	// Token: 0x17000293 RID: 659
	// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00006480 File Offset: 0x00004680
	// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000273")]
	public bool IsEquip
	{
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x20A3080", Offset = "0x20A3181", VA = "0x20A3080")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD10", Offset = "0x19BE11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x20A3090", Offset = "0x20A3191", VA = "0x20A3090")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19BD20", Offset = "0x19BE21")]
		set
		{
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00006498 File Offset: 0x00004698
	[Token(Token = "0x17000274")]
	public EquipSlotType SlotType
	{
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x20A30A0", Offset = "0x20A31A1", VA = "0x20A30A0")]
		get
		{
			return EquipSlotType.RuneRX;
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000275")]
	public ItemData ItemData
	{
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x20A30B0", Offset = "0x20A31B1", VA = "0x20A30B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000276")]
	public ItemEquip[] ItemEquips
	{
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x20A30C0", Offset = "0x20A31C1", VA = "0x20A30C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C05")]
	[Address(RVA = "0x20A30D0", Offset = "0x20A31D1", VA = "0x20A30D0")]
	private void Init()
	{
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C06")]
	[Address(RVA = "0x20A3120", Offset = "0x20A3221", VA = "0x20A3120")]
	public HumanEquipItem(EquipSlotType slot_type)
	{
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C07")]
	[Address(RVA = "0x20A3180", Offset = "0x20A3281", VA = "0x20A3180")]
	public void Set(ItemData item_data)
	{
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C08")]
	[Address(RVA = "0x20A31B0", Offset = "0x20A32B1", VA = "0x20A31B0")]
	public void Reset(ItemData item_data)
	{
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C09")]
	[Address(RVA = "0x20A31C0", Offset = "0x20A32C1", VA = "0x20A31C0")]
	public void Create(ItemID itemID, GameObject[] items)
	{
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C0A")]
	[Address(RVA = "0x20A33E0", Offset = "0x20A34E1", VA = "0x20A33E0")]
	public void Clear()
	{
	}

	// Token: 0x040007C2 RID: 1986
	[Token(Token = "0x400064D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private EquipSlotType equipSlotType;

	// Token: 0x040007C3 RID: 1987
	[Token(Token = "0x400064E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ItemData itemData;

	// Token: 0x040007C4 RID: 1988
	[Token(Token = "0x400064F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject[] itemsPrefab;

	// Token: 0x040007C5 RID: 1989
	[Token(Token = "0x4000650")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ItemEquip[] itemEquips;

	// Token: 0x040007C6 RID: 1990
	[Token(Token = "0x4000651")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15DF60", Offset = "0x15E061")]
	private bool <IsEquip>k__BackingField;
}
