using System;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200056B RID: 1387
[Token(Token = "0x20003E7")]
[Serializable]
public struct MineTypeDataTable
{
	// Token: 0x06002182 RID: 8578 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x22F5880", Offset = "0x22F5981", VA = "0x22F5880")]
	public static MineTypeDataTable GetDataTable(MineTypeID MineTypeId)
	{
		return default(MineTypeDataTable);
	}

	// Token: 0x040069DF RID: 27103
	[Token(Token = "0x40063A1")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public string Name;

	// Token: 0x040069E0 RID: 27104
	[Token(Token = "0x40063A2")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public string PrefabName;

	// Token: 0x040069E1 RID: 27105
	[Token(Token = "0x40063A3")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int HP;

	// Token: 0x040069E2 RID: 27106
	[Token(Token = "0x40063A4")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Type;

	// Token: 0x040069E3 RID: 27107
	[Token(Token = "0x40063A5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int BreakRate;

	// Token: 0x040069E4 RID: 27108
	[Token(Token = "0x40063A6")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int ScrapRate;

	// Token: 0x040069E5 RID: 27109
	[Token(Token = "0x40063A7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int Rate1;

	// Token: 0x040069E6 RID: 27110
	[Token(Token = "0x40063A8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public ItemID DropItem1;

	// Token: 0x040069E7 RID: 27111
	[Token(Token = "0x40063A9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int Rate2;

	// Token: 0x040069E8 RID: 27112
	[Token(Token = "0x40063AA")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public ItemID DropItem2;

	// Token: 0x040069E9 RID: 27113
	[Token(Token = "0x40063AB")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int Rate3;

	// Token: 0x040069EA RID: 27114
	[Token(Token = "0x40063AC")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public ItemID DropItem3;

	// Token: 0x040069EB RID: 27115
	[Token(Token = "0x40063AD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ItemID DropItemHighRare;

	// Token: 0x040069EC RID: 27116
	[Token(Token = "0x40063AE")]
	[FieldOffset(Offset = "0x0")]
	private static MineTypeDataTableArray _MineTypeDataTableArray;
}
