using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200038D RID: 909
[Token(Token = "0x20002B5")]
[Serializable]
public class ItemWeightData
{
	// Token: 0x06001704 RID: 5892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001470")]
	[Address(RVA = "0x2241B20", Offset = "0x2241C21", VA = "0x2241B20")]
	public ItemWeightData()
	{
	}

	// Token: 0x04000FED RID: 4077
	[Token(Token = "0x4000CA1")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID ItemID;

	// Token: 0x04000FEE RID: 4078
	[Token(Token = "0x4000CA2")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Weight;
}
