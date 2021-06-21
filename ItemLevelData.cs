using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005AE RID: 1454
[Token(Token = "0x2000410")]
[Serializable]
public struct ItemLevelData
{
	// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x2E0920", Offset = "0x2E0A21", VA = "0x2E0920")]
	public ItemLevelData(int level0, int level1, int level2, int level3)
	{
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x2E0930", Offset = "0x2E0A31", VA = "0x2E0930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060023B4 RID: 9140 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0x208DBC0", Offset = "0x208DCC1", VA = "0x208DBC0")]
	public static int GetLevel(int table)
	{
		return 0;
	}

	// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x208DD20", Offset = "0x208DE21", VA = "0x208DD20")]
	public static void LoadData()
	{
	}

	// Token: 0x04006B51 RID: 27473
	[Token(Token = "0x40064A8")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int[] Level;

	// Token: 0x04006B52 RID: 27474
	[Token(Token = "0x40064A9")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04006B53 RID: 27475
	[Token(Token = "0x40064AA")]
	[FieldOffset(Offset = "0x8")]
	private static ItemLevelDataTableArray _ItemLevelDataTableArray;
}
