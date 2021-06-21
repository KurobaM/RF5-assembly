using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003C8 RID: 968
[Token(Token = "0x20002EA")]
[Serializable]
public class StrengtheningEtcDataTable
{
	// Token: 0x0600177E RID: 6014 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E2")]
	[Address(RVA = "0x238F470", Offset = "0x238F571", VA = "0x238F470")]
	public static StrengtheningEtcDataTable GetDataTable(StrengtheningEtcID id)
	{
		return null;
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E3")]
	[Address(RVA = "0x238F5B0", Offset = "0x238F6B1", VA = "0x238F5B0")]
	public StrengtheningEtcDataTable()
	{
	}

	// Token: 0x040010D7 RID: 4311
	[Token(Token = "0x4000D73")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public Parameter Parameter;

	// Token: 0x040010D8 RID: 4312
	[Token(Token = "0x4000D74")]
	[FieldOffset(Offset = "0x0")]
	private static StrengtheningEtcDataTableArray _StrengtheningEtcDataTableArray;
}
