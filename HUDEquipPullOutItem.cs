using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009AD RID: 2477
[Token(Token = "0x200067C")]
public class HUDEquipPullOutItem : MonoBehaviour
{
	// Token: 0x060040A7 RID: 16551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E2")]
	[Address(RVA = "0x204B370", Offset = "0x204B471", VA = "0x204B370")]
	private void UpdateItem()
	{
	}

	// Token: 0x060040A8 RID: 16552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E3")]
	[Address(RVA = "0x204B5F0", Offset = "0x204B6F1", VA = "0x204B5F0")]
	private void Update()
	{
	}

	// Token: 0x060040A9 RID: 16553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60035E4")]
	[Address(RVA = "0x204B600", Offset = "0x204B701", VA = "0x204B600")]
	public HUDEquipPullOutItem()
	{
	}

	// Token: 0x04009F4B RID: 40779
	[Token(Token = "0x400780D")]
	[FieldOffset(Offset = "0x18")]
	private EquipSlotType EquipSlotType;

	// Token: 0x04009F4C RID: 40780
	[Token(Token = "0x400780E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ItemIconLoader ItemIconLoader;

	// Token: 0x04009F4D RID: 40781
	[Token(Token = "0x400780F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private HUDWateringPot HUDWateringPot;

	// Token: 0x04009F4E RID: 40782
	[Token(Token = "0x4007810")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image ItemAmountImage;

	// Token: 0x04009F4F RID: 40783
	[Token(Token = "0x4007811")]
	[FieldOffset(Offset = "0x38")]
	private int amount;

	// Token: 0x04009F50 RID: 40784
	[Token(Token = "0x4007812")]
	[FieldOffset(Offset = "0x3C")]
	private ItemID NowItemId;
}
