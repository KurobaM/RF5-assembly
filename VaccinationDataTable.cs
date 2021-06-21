using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

// Token: 0x020003CF RID: 975
[Token(Token = "0x20002F1")]
[Serializable]
public class VaccinationDataTable
{
	// Token: 0x0600178C RID: 6028 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014F0")]
	[Address(RVA = "0x1E471F0", Offset = "0x1E472F1", VA = "0x1E471F0")]
	public static VaccinationDataTable GetDataTable(VaccinationID vaccinationID)
	{
		return null;
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x1E47330", Offset = "0x1E47431", VA = "0x1E47330")]
	public static IEnumerable<SerializeVaccinationDataTable> GetDataTables()
	{
		return null;
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x1E47450", Offset = "0x1E47551", VA = "0x1E47450")]
	public VaccinationDataTable()
	{
	}

	// Token: 0x040010EB RID: 4331
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Price;

	// Token: 0x040010EC RID: 4332
	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Time;

	// Token: 0x040010ED RID: 4333
	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Args1;

	// Token: 0x040010EE RID: 4334
	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float Args2;

	// Token: 0x040010EF RID: 4335
	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string ScreenNameID;

	// Token: 0x040010F0 RID: 4336
	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string DetailTextID;

	// Token: 0x040010F1 RID: 4337
	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public BuilderId Release_BuilderID;

	// Token: 0x040010F2 RID: 4338
	[Token(Token = "0x4000D8E")]
	[FieldOffset(Offset = "0x0")]
	private static VaccinationDataTableArray _VaccinationDataTableArray;
}
