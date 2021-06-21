using System;
using Farm;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200055A RID: 1370
[Token(Token = "0x20003E3")]
[Serializable]
public struct MiningPointSaveData
{
	// Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C38")]
	[Address(RVA = "0x2DD820", Offset = "0x2DD921", VA = "0x2DD820")]
	public MiningPointSaveData(MiningPoint mp)
	{
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x2DD8A0", Offset = "0x2DD9A1", VA = "0x2DD8A0")]
	public MiningPointSaveData(FarmManager.FARM_ID farmId, int uid, Vector3 position, CropID cropId, MineTypeID mineTypeId, ItemID itemId, int hp)
	{
	}

	// Token: 0x040067E9 RID: 26601
	[Token(Token = "0x40061CE")]
	[FieldOffset(Offset = "0x0")]
	public FarmManager.FARM_ID FarmId;

	// Token: 0x040067EA RID: 26602
	[Token(Token = "0x40061CF")]
	[FieldOffset(Offset = "0x4")]
	public int UID;

	// Token: 0x040067EB RID: 26603
	[Token(Token = "0x40061D0")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 Position;

	// Token: 0x040067EC RID: 26604
	[Token(Token = "0x40061D1")]
	[FieldOffset(Offset = "0x14")]
	public CropID CropId;

	// Token: 0x040067ED RID: 26605
	[Token(Token = "0x40061D2")]
	[FieldOffset(Offset = "0x18")]
	public MineTypeID MineTypeId;

	// Token: 0x040067EE RID: 26606
	[Token(Token = "0x40061D3")]
	[FieldOffset(Offset = "0x1C")]
	public ItemID ItemId;

	// Token: 0x040067EF RID: 26607
	[Token(Token = "0x40061D4")]
	[FieldOffset(Offset = "0x20")]
	public int HP;
}
