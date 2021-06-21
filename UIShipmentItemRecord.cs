using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RF5SHIPPING;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000AAE RID: 2734
[Token(Token = "0x200072B")]
public class UIShipmentItemRecord : MonoBehaviour
{
	// Token: 0x0600471F RID: 18207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003B95")]
	[Address(RVA = "0x1EB8560", Offset = "0x1EB8661", VA = "0x1EB8560")]
	private string ConvToSpriteTextStr(int val)
	{
		return null;
	}

	// Token: 0x06004720 RID: 18208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B96")]
	[Address(RVA = "0x1EB8650", Offset = "0x1EB8751", VA = "0x1EB8650")]
	public void SetPage(ShippingCategory shippingCategory, List<ShipmentItemRecords> ItemRecords, [Optional] List<FishShipmentRecords> FishRecords)
	{
	}

	// Token: 0x06004721 RID: 18209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B97")]
	[Address(RVA = "0x1EB8CB0", Offset = "0x1EB8DB1", VA = "0x1EB8CB0")]
	public UIShipmentItemRecord()
	{
	}

	// Token: 0x0400A619 RID: 42521
	[Token(Token = "0x4007D81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text HeadText;

	// Token: 0x0400A61A RID: 42522
	[Token(Token = "0x4007D82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text CompleteText;

	// Token: 0x0400A61B RID: 42523
	[Token(Token = "0x4007D83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text RecordText;

	// Token: 0x0400A61C RID: 42524
	[Token(Token = "0x4007D84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private TextMeshProUGUI BronzeCrownNum;

	// Token: 0x0400A61D RID: 42525
	[Token(Token = "0x4007D85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TextMeshProUGUI SilverCrownNum;

	// Token: 0x0400A61E RID: 42526
	[Token(Token = "0x4007D86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI GoldCrownNum;

	// Token: 0x0400A61F RID: 42527
	[Token(Token = "0x4007D87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ItemIconLoader BestItemIcon;

	// Token: 0x0400A620 RID: 42528
	[Token(Token = "0x4007D88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Text BestItemTotalPrice;
}
