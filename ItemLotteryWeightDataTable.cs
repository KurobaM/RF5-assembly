using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200038E RID: 910
[Token(Token = "0x20002B6")]
[Serializable]
public class ItemLotteryWeightDataTable
{
	// Token: 0x06001705 RID: 5893 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001471")]
	[Address(RVA = "0x208F640", Offset = "0x208F741", VA = "0x208F640")]
	public static ItemLotteryWeightDataTable GetDataTable(ItemLotteryWeightID id)
	{
		return null;
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001472")]
	[Address(RVA = "0x208F780", Offset = "0x208F881", VA = "0x208F780")]
	public ItemLotteryWeightDataTable()
	{
	}

	// Token: 0x04000FEF RID: 4079
	[Token(Token = "0x4000CA3")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemWeightData[] ItemWeightDatas;

	// Token: 0x04000FF0 RID: 4080
	[Token(Token = "0x4000CA4")]
	[FieldOffset(Offset = "0x0")]
	private static ItemLotteryWeightDataTableArray _ItemLotteryWeightDataTableArray;
}
