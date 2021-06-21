using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000357 RID: 855
[Token(Token = "0x2000286")]
[Serializable]
public class CostumeDataTable
{
	// Token: 0x06001667 RID: 5735 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x20E1F50", Offset = "0x20E2051", VA = "0x20E1F50")]
	public static CostumeDataTable GetDataTable(VariationNo variationNo)
	{
		return null;
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x20E20A0", Offset = "0x20E21A1", VA = "0x20E20A0")]
	public static string GetCostumeTitleKey(VariationNo variationNo, bool male)
	{
		return null;
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x20E20E0", Offset = "0x20E21E1", VA = "0x20E20E0")]
	public CostumeDataTable()
	{
	}

	// Token: 0x04000E6D RID: 3693
	[Token(Token = "0x4000B4E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string MaleNameKey;

	// Token: 0x04000E6E RID: 3694
	[Token(Token = "0x4000B4F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string FemaleNameKey;

	// Token: 0x04000E6F RID: 3695
	[Token(Token = "0x4000B50")]
	[FieldOffset(Offset = "0x0")]
	private static CostumeDataTableArray _CostumeDataTableArray;
}
