using System;
using System.Collections.Generic;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004D6 RID: 1238
[Token(Token = "0x200038F")]
[Serializable]
public struct CropDataTable
{
	// Token: 0x06001E82 RID: 7810 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x20E96F0", Offset = "0x20E97F1", VA = "0x20E96F0")]
	public static CropDataTable GetDataTable(CropID cropId)
	{
		return default(CropDataTable);
	}

	// Token: 0x06001E83 RID: 7811 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x20E9830", Offset = "0x20E9931", VA = "0x20E9830")]
	public static CropDataTable GetDataTable(int id)
	{
		return default(CropDataTable);
	}

	// Token: 0x06001E84 RID: 7812 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x20E9A00", Offset = "0x20E9B01", VA = "0x20E9A00")]
	public static CropDataTable GetDataTableFromItemDataId(ItemID itemDataId)
	{
		return default(CropDataTable);
	}

	// Token: 0x06001E85 RID: 7813 RVA: 0x0000D008 File Offset: 0x0000B208
	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x20E9CA0", Offset = "0x20E9DA1", VA = "0x20E9CA0")]
	public static CropDataTable GetDataTableFromItemDataIdContest(ItemID itemDataId)
	{
		return default(CropDataTable);
	}

	// Token: 0x06001E86 RID: 7814 RVA: 0x0000D020 File Offset: 0x0000B220
	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x20E9E70", Offset = "0x20E9F71", VA = "0x20E9E70")]
	public static CropDataTable GetDataTableFromItemData(ItemData itemData)
	{
		return default(CropDataTable);
	}

	// Token: 0x06001E87 RID: 7815 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x20EA120", Offset = "0x20EA221", VA = "0x20EA120")]
	public static List<CropDataTable> GetDataTableList()
	{
		return null;
	}

	// Token: 0x06001E88 RID: 7816 RVA: 0x0000D038 File Offset: 0x0000B238
	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x20EA310", Offset = "0x20EA411", VA = "0x20EA310")]
	public static CropID GetCropIDfromCropId(int cropDataTableId)
	{
		return global::CropID.EMPTY;
	}

	// Token: 0x0400645C RID: 25692
	[Token(Token = "0x4005EFF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int CropID;

	// Token: 0x0400645D RID: 25693
	[Token(Token = "0x4005F00")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public int CropGroupID;

	// Token: 0x0400645E RID: 25694
	[Token(Token = "0x4005F01")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public string CropName;

	// Token: 0x0400645F RID: 25695
	[Token(Token = "0x4005F02")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID SeedItemID;

	// Token: 0x04006460 RID: 25696
	[Token(Token = "0x4005F03")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string PrefabName_01;

	// Token: 0x04006461 RID: 25697
	[Token(Token = "0x4005F04")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string PrefabName_02;

	// Token: 0x04006462 RID: 25698
	[Token(Token = "0x4005F05")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string PrefabName_03;

	// Token: 0x04006463 RID: 25699
	[Token(Token = "0x4005F06")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string PrefabName_04;

	// Token: 0x04006464 RID: 25700
	[Token(Token = "0x4005F07")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ItemID HarvestItemID;

	// Token: 0x04006465 RID: 25701
	[Token(Token = "0x4005F08")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public int CropType;

	// Token: 0x04006466 RID: 25702
	[Token(Token = "0x4005F09")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int CropSize;

	// Token: 0x04006467 RID: 25703
	[Token(Token = "0x4005F0A")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public int ToLargeDataID;

	// Token: 0x04006468 RID: 25704
	[Token(Token = "0x4005F0B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public int ToSmallDataID;

	// Token: 0x04006469 RID: 25705
	[Token(Token = "0x4005F0C")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	public int ElapsedDays_01;

	// Token: 0x0400646A RID: 25706
	[Token(Token = "0x4005F0D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public int ElapsedDays_02;

	// Token: 0x0400646B RID: 25707
	[Token(Token = "0x4005F0E")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	public int ElapsedDays_03;

	// Token: 0x0400646C RID: 25708
	[Token(Token = "0x4005F0F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public int ElapsedDays_04;

	// Token: 0x0400646D RID: 25709
	[Token(Token = "0x4005F10")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	public int ElapsedDays_Total;

	// Token: 0x0400646E RID: 25710
	[Token(Token = "0x4005F11")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int RepeatDays;

	// Token: 0x0400646F RID: 25711
	[Token(Token = "0x4005F12")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	public int HarvestCount;

	// Token: 0x04006470 RID: 25712
	[Token(Token = "0x4005F13")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public int CropHP;

	// Token: 0x04006471 RID: 25713
	[Token(Token = "0x4005F14")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	public int RuneEncount;

	// Token: 0x04006472 RID: 25714
	[Token(Token = "0x4005F15")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public int SpawnRate;

	// Token: 0x04006473 RID: 25715
	[Token(Token = "0x4005F16")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	public int IsSickle;

	// Token: 0x04006474 RID: 25716
	[Token(Token = "0x4005F17")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public int IsHammer;

	// Token: 0x04006475 RID: 25717
	[Token(Token = "0x4005F18")]
	[FieldOffset(Offset = "0x7C")]
	[SerializeField]
	public int IsAxe;

	// Token: 0x04006476 RID: 25718
	[Token(Token = "0x4005F19")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public int Spring_Positive;

	// Token: 0x04006477 RID: 25719
	[Token(Token = "0x4005F1A")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	public int Summer_Positive;

	// Token: 0x04006478 RID: 25720
	[Token(Token = "0x4005F1B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public int Autumn_Positive;

	// Token: 0x04006479 RID: 25721
	[Token(Token = "0x4005F1C")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	public int Winter_Positive;

	// Token: 0x0400647A RID: 25722
	[Token(Token = "0x4005F1D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public int Spring_Negative;

	// Token: 0x0400647B RID: 25723
	[Token(Token = "0x4005F1E")]
	[FieldOffset(Offset = "0x94")]
	[SerializeField]
	public int Summer_Negative;

	// Token: 0x0400647C RID: 25724
	[Token(Token = "0x4005F1F")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public int Autumn_Negative;

	// Token: 0x0400647D RID: 25725
	[Token(Token = "0x4005F20")]
	[FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public int Winter_Negative;

	// Token: 0x0400647E RID: 25726
	[Token(Token = "0x4005F21")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public int RegistDisaster;

	// Token: 0x0400647F RID: 25727
	[Token(Token = "0x4005F22")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	public int TotalExp;

	// Token: 0x04006480 RID: 25728
	[Token(Token = "0x4005F23")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public int SpeedExp;

	// Token: 0x04006481 RID: 25729
	[Token(Token = "0x4005F24")]
	[FieldOffset(Offset = "0xAC")]
	[SerializeField]
	public int LevelExp;

	// Token: 0x04006482 RID: 25730
	[Token(Token = "0x4005F25")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public int SizeExp;

	// Token: 0x04006483 RID: 25731
	[Token(Token = "0x4005F26")]
	[FieldOffset(Offset = "0xB4")]
	[SerializeField]
	public int HarvestExp;

	// Token: 0x04006484 RID: 25732
	[Token(Token = "0x4005F27")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	public int SpeedDmg;

	// Token: 0x04006485 RID: 25733
	[Token(Token = "0x4005F28")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	public int LevelDmg;

	// Token: 0x04006486 RID: 25734
	[Token(Token = "0x4005F29")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public int SizeDmg;

	// Token: 0x04006487 RID: 25735
	[Token(Token = "0x4005F2A")]
	[FieldOffset(Offset = "0xC4")]
	[SerializeField]
	public int HarvestDmg;

	// Token: 0x04006488 RID: 25736
	[Token(Token = "0x4005F2B")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public int SoidDmg;

	// Token: 0x04006489 RID: 25737
	[Token(Token = "0x4005F2C")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	public int SpeedRate;

	// Token: 0x0400648A RID: 25738
	[Token(Token = "0x4005F2D")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public int LevelRate;

	// Token: 0x0400648B RID: 25739
	[Token(Token = "0x4005F2E")]
	[FieldOffset(Offset = "0xD4")]
	[SerializeField]
	public int SizeRate;

	// Token: 0x0400648C RID: 25740
	[Token(Token = "0x4005F2F")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public int HarvestRate;

	// Token: 0x0400648D RID: 25741
	[Token(Token = "0x4005F30")]
	[FieldOffset(Offset = "0xDC")]
	[SerializeField]
	public int IsPickUp;

	// Token: 0x0400648E RID: 25742
	[Token(Token = "0x4005F31")]
	[FieldOffset(Offset = "0xE0")]
	public int HarvestNum;

	// Token: 0x0400648F RID: 25743
	[Token(Token = "0x4005F32")]
	[FieldOffset(Offset = "0xE4")]
	public int HarvestDays;

	// Token: 0x04006490 RID: 25744
	[Token(Token = "0x4005F33")]
	[FieldOffset(Offset = "0xE8")]
	public float InitialHP;

	// Token: 0x04006491 RID: 25745
	[Token(Token = "0x4005F34")]
	[FieldOffset(Offset = "0x0")]
	private static CropDataTableArray _CropDataTableArray;

	// Token: 0x020004D7 RID: 1239
	[Token(Token = "0x20010D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B80", Offset = "0x157C81")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06001E8A RID: 7818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2A")]
		[Address(RVA = "0x20EA490", Offset = "0x20EA591", VA = "0x20EA490")]
		public <>c()
		{
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0x20EA4A0", Offset = "0x20EA5A1", VA = "0x20EA4A0")]
		internal CropDataTable <GetDataTableList>b__59_0(SerializeCropDataTable data)
		{
			return default(CropDataTable);
		}

		// Token: 0x04006492 RID: 25746
		[Token(Token = "0x40191D0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CropDataTable.<>c <>9;

		// Token: 0x04006493 RID: 25747
		[Token(Token = "0x40191D1")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SerializeCropDataTable, CropDataTable> <>9__59_0;
	}

	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20010D1")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157B90", Offset = "0x157C91")]
	private sealed class <>c__DisplayClass60_0
	{
		// Token: 0x06001E8C RID: 7820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0x20EA410", Offset = "0x20EA511", VA = "0x20EA410")]
		public <>c__DisplayClass60_0()
		{
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0x20EA4C0", Offset = "0x20EA5C1", VA = "0x20EA4C0")]
		internal bool <GetCropIDfromCropId>b__0(SerializeCropDataTable data)
		{
			return default(bool);
		}

		// Token: 0x04006494 RID: 25748
		[Token(Token = "0x40191D2")]
		[FieldOffset(Offset = "0x10")]
		public int cropDataTableId;
	}
}
