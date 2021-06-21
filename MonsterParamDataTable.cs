using System;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003A6 RID: 934
[Token(Token = "0x20002CD")]
[Serializable]
public class MonsterParamDataTable
{
	// Token: 0x06001732 RID: 5938 RVA: 0x0000A2C0 File Offset: 0x000084C0
	[Token(Token = "0x600149D")]
	[Address(RVA = "0x1E6E4A0", Offset = "0x1E6E5A1", VA = "0x1E6E4A0")]
	public static ValueTuple<MonsterParamDataTable, MonsterParamDataTable> GetDataTables(int level, bool levelup)
	{
		return default(ValueTuple<MonsterParamDataTable, MonsterParamDataTable>);
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600149E")]
	[Address(RVA = "0x1E6E6F0", Offset = "0x1E6E7F1", VA = "0x1E6E6F0")]
	public MonsterParamDataTable()
	{
	}

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x4000CFC")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Level;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public Parameter Parameter;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x4000CFE")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public int Exp;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x4000CFF")]
	[FieldOffset(Offset = "0x0")]
	private static MonsterParamDataTableArray _MonsterParamTypeDataTableArray;
}
