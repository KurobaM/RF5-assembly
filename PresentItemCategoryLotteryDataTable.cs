using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B6 RID: 950
[Token(Token = "0x20002DC")]
[Serializable]
public class PresentItemCategoryLotteryDataTable
{
	// Token: 0x06001757 RID: 5975 RVA: 0x0000A320 File Offset: 0x00008520
	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x280AF10", Offset = "0x280B011", VA = "0x280AF10")]
	public static bool HasDataTable(ItemCategory id)
	{
		return default(bool);
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x280B050", Offset = "0x280B151", VA = "0x280B050")]
	public static PresentItemCategoryLotteryDataTable GetDataTable(ItemCategory id)
	{
		return null;
	}

	// Token: 0x06001759 RID: 5977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x280B190", Offset = "0x280B291", VA = "0x280B190")]
	public PresentItemCategoryLotteryDataTable()
	{
	}

	// Token: 0x04001078 RID: 4216
	[Token(Token = "0x4000D28")]
	[FieldOffset(Offset = "0x10")]
	public PresentItemCategoryLotteryDataTable.LotteryInfo[] LotteryInfos;

	// Token: 0x04001079 RID: 4217
	[Token(Token = "0x4000D29")]
	[FieldOffset(Offset = "0x0")]
	private static PresentItemCategoryLotteryDataTableArray _PresentItemCategoryLotteryDataTableArray;

	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x2001063")]
	[Serializable]
	public class LotteryInfo
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x280B1A0", Offset = "0x280B2A1", VA = "0x280B1A0")]
		public LotteryInfo()
		{
		}

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x4018FC3")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int Weight;

		// Token: 0x0400107B RID: 4219
		[Token(Token = "0x4018FC4")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public PresentMonsterCategoryID ID;
	}
}
