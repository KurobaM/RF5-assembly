using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B8 RID: 952
[Token(Token = "0x20002DD")]
[Serializable]
public class PresentItemParamDataTable
{
	// Token: 0x0600175B RID: 5979 RVA: 0x0000A338 File Offset: 0x00008538
	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x280B1B0", Offset = "0x280B2B1", VA = "0x280B1B0")]
	public static bool HasDataTable(ItemID id)
	{
		return default(bool);
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x280B2F0", Offset = "0x280B3F1", VA = "0x280B2F0")]
	public static PresentItemParamDataTable GetDataTable(ItemID id)
	{
		return null;
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x280B430", Offset = "0x280B531", VA = "0x280B430")]
	public static PresentItemParamDataTable GetDataTable(PresentMonsterCategoryID id)
	{
		return null;
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x280B580", Offset = "0x280B681", VA = "0x280B580")]
	public PresentItemParamDataTable()
	{
	}

	// Token: 0x0400107C RID: 4220
	[Token(Token = "0x4000D2A")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public Parameter Parameter;

	// Token: 0x0400107D RID: 4221
	[Token(Token = "0x4000D2B")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	public bool IsMulti;

	// Token: 0x0400107E RID: 4222
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x0")]
	private static PresentItemParamDataTableArray _PresentItemParamDataTableArray;
}
