using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000343 RID: 835
[Token(Token = "0x2000272")]
[Serializable]
public class BitDataTable
{
	// Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x2454B80", Offset = "0x2454C81", VA = "0x2454B80")]
	public static BitDataTable GetDataTable(BitID bulletId)
	{
		return null;
	}

	// Token: 0x06001646 RID: 5702 RVA: 0x00009E88 File Offset: 0x00008088
	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x2454D20", Offset = "0x2454E21", VA = "0x2454D20")]
	public static bool HasDataTable(BitID bulletId)
	{
		return default(bool);
	}

	// Token: 0x06001647 RID: 5703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x2454D10", Offset = "0x2454E11", VA = "0x2454D10")]
	public BitDataTable()
	{
	}

	// Token: 0x04000DBE RID: 3518
	[Token(Token = "0x4000A9F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public BitData Data;

	// Token: 0x04000DBF RID: 3519
	[Token(Token = "0x4000AA0")]
	[FieldOffset(Offset = "0x0")]
	private static BitDataTableArray _BitDataTableArray;
}
