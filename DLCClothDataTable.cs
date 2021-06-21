using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200035E RID: 862
[Token(Token = "0x200028C")]
[Serializable]
public class DLCClothDataTable
{
	// Token: 0x0600167B RID: 5755 RVA: 0x00009F18 File Offset: 0x00008118
	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x1D9DB80", Offset = "0x1D9DC81", VA = "0x1D9DB80")]
	public static bool HasDataTable(DLCID dlcID)
	{
		return default(bool);
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x1D9DD10", Offset = "0x1D9DE11", VA = "0x1D9DD10")]
	public static DLCClothDataTable GetDataTable(DLCID dlcID)
	{
		return null;
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x1D9DEA0", Offset = "0x1D9DFA1", VA = "0x1D9DEA0")]
	public DLCClothDataTable()
	{
	}

	// Token: 0x04000E7C RID: 3708
	[Token(Token = "0x4000B5B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public VariationNo[] VariationNos;

	// Token: 0x04000E7D RID: 3709
	[Token(Token = "0x4000B5C")]
	[FieldOffset(Offset = "0x0")]
	private static DLCClothDataTableArray _DLCClothDataTableArray;
}
