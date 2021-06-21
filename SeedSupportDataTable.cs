using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003C0 RID: 960
[Token(Token = "0x20002E3")]
[Serializable]
public class SeedSupportDataTable
{
	// Token: 0x06001770 RID: 6000 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x1E30270", Offset = "0x1E30371", VA = "0x1E30270")]
	public static SeedSupportDataTable GetDataTable(SeedSupportID seedSupportID)
	{
		return null;
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x0000A3C8 File Offset: 0x000085C8
	[Token(Token = "0x60014D5")]
	[Address(RVA = "0x1E30410", Offset = "0x1E30511", VA = "0x1E30410")]
	public static bool HasDataTable(SeedSupportID seedSupportID)
	{
		return default(bool);
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D6")]
	[Address(RVA = "0x1E30400", Offset = "0x1E30501", VA = "0x1E30400")]
	public SeedSupportDataTable()
	{
	}

	// Token: 0x04001096 RID: 4246
	[Token(Token = "0x4000D3A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SeedSupportData[] Data;

	// Token: 0x04001097 RID: 4247
	[Token(Token = "0x4000D3B")]
	[FieldOffset(Offset = "0x0")]
	private static SeedSupportDataTableArray _SeedSupportDataTableArray;
}
