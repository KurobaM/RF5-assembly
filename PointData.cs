using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005B0 RID: 1456
[Token(Token = "0x2000412")]
[Serializable]
public class PointData
{
	// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x249E6D0", Offset = "0x249E7D1", VA = "0x249E6D0")]
	public PointData(string id, ItemID fish_id, int rank, int rate, int spring0, int spring1, int summer0, int summer1, int autumn0, int autumn1, int winter0, int winter1)
	{
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x249E780", Offset = "0x249E881", VA = "0x249E780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x0000E808 File Offset: 0x0000CA08
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x249EED0", Offset = "0x249EFD1", VA = "0x249EED0")]
	public static ItemID GetFish(string id, int rank, int season, [Optional] ItemData itemData, bool IkaTaikai = false)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x249FCB0", Offset = "0x249FDB1", VA = "0x249FCB0")]
	public static void LoadData()
	{
	}

	// Token: 0x04006B55 RID: 27477
	[Token(Token = "0x40064AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string Id;

	// Token: 0x04006B56 RID: 27478
	[Token(Token = "0x40064AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ItemID FishId;

	// Token: 0x04006B57 RID: 27479
	[Token(Token = "0x40064AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int Rank;

	// Token: 0x04006B58 RID: 27480
	[Token(Token = "0x40064AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int Rate;

	// Token: 0x04006B59 RID: 27481
	[Token(Token = "0x40064B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int Spring0;

	// Token: 0x04006B5A RID: 27482
	[Token(Token = "0x40064B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public int Spring1;

	// Token: 0x04006B5B RID: 27483
	[Token(Token = "0x40064B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public int Summer0;

	// Token: 0x04006B5C RID: 27484
	[Token(Token = "0x40064B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int Summer1;

	// Token: 0x04006B5D RID: 27485
	[Token(Token = "0x40064B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	public int Autumn0;

	// Token: 0x04006B5E RID: 27486
	[Token(Token = "0x40064B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public int Autumn1;

	// Token: 0x04006B5F RID: 27487
	[Token(Token = "0x40064B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int Winter0;

	// Token: 0x04006B60 RID: 27488
	[Token(Token = "0x40064B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int Winter1;

	// Token: 0x04006B61 RID: 27489
	[Token(Token = "0x40064B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04006B62 RID: 27490
	[Token(Token = "0x40064B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static PointDataTableArray _PointDataTableArray;

	// Token: 0x04006B63 RID: 27491
	[Token(Token = "0x40064BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<RandomData> list_;

	// Token: 0x04006B64 RID: 27492
	[Token(Token = "0x40064BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<UpPointData> UpPointList;
}
