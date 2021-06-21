using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009AC RID: 2476
[Token(Token = "0x200067B")]
public class HUDEquipItemSlot : MonoBehaviour
{
	// Token: 0x060040A3 RID: 16547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035DE")]
	[Address(RVA = "0x204B240", Offset = "0x204B341", VA = "0x204B240")]
	private void UpdateItem()
	{
	}

	// Token: 0x060040A4 RID: 16548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035DF")]
	[Address(RVA = "0x204B340", Offset = "0x204B441", VA = "0x204B340")]
	private void OnEnable()
	{
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E0")]
	[Address(RVA = "0x204B350", Offset = "0x204B451", VA = "0x204B350")]
	private void Update()
	{
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E1")]
	[Address(RVA = "0x204B360", Offset = "0x204B461", VA = "0x204B360")]
	public HUDEquipItemSlot()
	{
	}

	// Token: 0x04009F48 RID: 40776
	[Token(Token = "0x400780A")]
	[FieldOffset(Offset = "0x18")]
	public EquipSlotType EquipSlotType;

	// Token: 0x04009F49 RID: 40777
	[Token(Token = "0x400780B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ItemIconLoader ItemIconLoader;

	// Token: 0x04009F4A RID: 40778
	[Token(Token = "0x400780C")]
	[FieldOffset(Offset = "0x28")]
	private ItemID NowItemId;
}
