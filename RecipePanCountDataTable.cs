using System;
using DataTable;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

// Token: 0x020003BB RID: 955
[Token(Token = "0x20002DF")]
[Serializable]
public class RecipePanCountDataTable
{
	// Token: 0x06001761 RID: 5985 RVA: 0x0000A350 File Offset: 0x00008550
	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x1F3FFE0", Offset = "0x1F400E1", VA = "0x1F3FFE0")]
	private static int GetCount(PanShopType panShopType, BuilderId builderId)
	{
		return 0;
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x0000A368 File Offset: 0x00008568
	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x1F401D0", Offset = "0x1F402D1", VA = "0x1F401D0")]
	public static int GetCount_Restaurant()
	{
		return 0;
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x0000A380 File Offset: 0x00008580
	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x1F403B0", Offset = "0x1F404B1", VA = "0x1F403B0")]
	public static int GetCount_Bakery()
	{
		return 0;
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x1F40590", Offset = "0x1F40691", VA = "0x1F40590")]
	public RecipePanCountDataTable()
	{
	}

	// Token: 0x04001087 RID: 4231
	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public PanShopType PanShopType;

	// Token: 0x04001088 RID: 4232
	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public BuilderId Release_BuilderID;

	// Token: 0x04001089 RID: 4233
	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Count;

	// Token: 0x0400108A RID: 4234
	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x0")]
	private static RecipePanCountDataTableArray _RecipePanCountDataTableArray;
}
