using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005AC RID: 1452
[Token(Token = "0x200040E")]
[Serializable]
public class FishData
{
	// Token: 0x060023AB RID: 9131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x2033B50", Offset = "0x2033C51", VA = "0x2033B50")]
	public FishData(ItemID item_id, StampEnum stamp, int min, int max, float xr, float yr, float zr, bool not_r90, int level_tbl, int up_point1, ItemID up_fish1, int up_point2, ItemID up_fish2, int up_point3, ItemID up_fish3, int up_point_ika)
	{
	}

	// Token: 0x060023AC RID: 9132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x2033C50", Offset = "0x2033D51", VA = "0x2033C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x20344F0", Offset = "0x20345F1", VA = "0x20344F0")]
	public static FishData GetFishData(ItemID itemID)
	{
		return null;
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x2034660", Offset = "0x2034761", VA = "0x2034660")]
	public static StampEnum GetStampEnum(ItemID itemID)
	{
		return StampEnum.Shipping;
	}

	// Token: 0x060023AF RID: 9135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x20347A0", Offset = "0x20348A1", VA = "0x20347A0")]
	public static void LoadData()
	{
	}

	// Token: 0x04006B3F RID: 27455
	[Token(Token = "0x4006496")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID ItemId;

	// Token: 0x04006B40 RID: 27456
	[Token(Token = "0x4006497")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public StampEnum StampEnum;

	// Token: 0x04006B41 RID: 27457
	[Token(Token = "0x4006498")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Min;

	// Token: 0x04006B42 RID: 27458
	[Token(Token = "0x4006499")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int Max;

	// Token: 0x04006B43 RID: 27459
	[Token(Token = "0x400649A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Vector3 Rotate;

	// Token: 0x04006B44 RID: 27460
	[Token(Token = "0x400649B")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public bool NotRotate90;

	// Token: 0x04006B45 RID: 27461
	[Token(Token = "0x400649C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int LevelTable;

	// Token: 0x04006B46 RID: 27462
	[Token(Token = "0x400649D")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int UpPoint1;

	// Token: 0x04006B47 RID: 27463
	[Token(Token = "0x400649E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ItemID UpFish1;

	// Token: 0x04006B48 RID: 27464
	[Token(Token = "0x400649F")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int UpPoint2;

	// Token: 0x04006B49 RID: 27465
	[Token(Token = "0x40064A0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ItemID UpFish2;

	// Token: 0x04006B4A RID: 27466
	[Token(Token = "0x40064A1")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public int UpPoint3;

	// Token: 0x04006B4B RID: 27467
	[Token(Token = "0x40064A2")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ItemID UpFish3;

	// Token: 0x04006B4C RID: 27468
	[Token(Token = "0x40064A3")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int UpPointIka;

	// Token: 0x04006B4D RID: 27469
	[Token(Token = "0x40064A4")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04006B4E RID: 27470
	[Token(Token = "0x40064A5")]
	[FieldOffset(Offset = "0x8")]
	private static FishDataTableArray _FishDataTableArray;

	// Token: 0x04006B4F RID: 27471
	[Token(Token = "0x40064A6")]
	[FieldOffset(Offset = "0x10")]
	private static FishData _dummy2;
}
