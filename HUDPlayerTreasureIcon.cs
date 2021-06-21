using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009BD RID: 2493
[Token(Token = "0x2000687")]
public class HUDPlayerTreasureIcon : MonoBehaviour
{
	// Token: 0x0600411F RID: 16671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003652")]
	[Address(RVA = "0x205A400", Offset = "0x205A501", VA = "0x205A400")]
	private void Start()
	{
	}

	// Token: 0x06004120 RID: 16672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003653")]
	[Address(RVA = "0x205A4D0", Offset = "0x205A5D1", VA = "0x205A4D0")]
	private void CheckDisp()
	{
	}

	// Token: 0x06004121 RID: 16673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003654")]
	[Address(RVA = "0x205A610", Offset = "0x205A711", VA = "0x205A610")]
	private void Update()
	{
	}

	// Token: 0x06004122 RID: 16674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003655")]
	[Address(RVA = "0x205A620", Offset = "0x205A721", VA = "0x205A620")]
	public HUDPlayerTreasureIcon()
	{
	}

	// Token: 0x04009FE7 RID: 40935
	[Token(Token = "0x4007896")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image IconImage;

	// Token: 0x04009FE8 RID: 40936
	[Token(Token = "0x4007897")]
	[FieldOffset(Offset = "0x20")]
	private bool dispStat;

	// Token: 0x04009FE9 RID: 40937
	[Token(Token = "0x4007898")]
	[FieldOffset(Offset = "0x24")]
	private HUDCharactorStatus.CharactorType charactorType;
}
