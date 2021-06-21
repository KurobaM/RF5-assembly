using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009C2 RID: 2498
[Token(Token = "0x200068C")]
public class HUDWateringPot : MonoBehaviour
{
	// Token: 0x06004130 RID: 16688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003663")]
	[Address(RVA = "0x24E1C80", Offset = "0x24E1D81", VA = "0x24E1C80")]
	public void SetPotData(ItemData itemData)
	{
	}

	// Token: 0x06004131 RID: 16689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003664")]
	[Address(RVA = "0x24E1DB0", Offset = "0x24E1EB1", VA = "0x24E1DB0")]
	private void CheckWaterEnable()
	{
	}

	// Token: 0x06004132 RID: 16690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003665")]
	[Address(RVA = "0x24E1E50", Offset = "0x24E1F51", VA = "0x24E1E50")]
	private void Update()
	{
	}

	// Token: 0x06004133 RID: 16691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003666")]
	[Address(RVA = "0x24E1EC0", Offset = "0x24E1FC1", VA = "0x24E1EC0")]
	public HUDWateringPot()
	{
	}

	// Token: 0x04009FFD RID: 40957
	[Token(Token = "0x40078AC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image Gauge;

	// Token: 0x04009FFE RID: 40958
	[Token(Token = "0x40078AD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image WaterBackImg;

	// Token: 0x04009FFF RID: 40959
	[Token(Token = "0x40078AE")]
	[FieldOffset(Offset = "0x28")]
	private bool waterEnable;

	// Token: 0x0400A000 RID: 40960
	[Token(Token = "0x40078AF")]
	[FieldOffset(Offset = "0x29")]
	private bool isUsing;

	// Token: 0x0400A001 RID: 40961
	[Token(Token = "0x40078B0")]
	[FieldOffset(Offset = "0x30")]
	private PotToolItemData potToolItemData;
}
