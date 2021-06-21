using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Farm
{
	// Token: 0x02001091 RID: 4241
	[Token(Token = "0x2000AB7")]
	[Attribute(Name = "MessagePackObjectAttribute", RVA = "0x149FD0", Offset = "0x14A0D1")]
	public class FarmCropData
	{
		// Token: 0x06006B49 RID: 27465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592E")]
		[Address(RVA = "0x2151280", Offset = "0x2151381", VA = "0x2151280")]
		public FarmCropData(Vector3Int _cellSetId, int _cellId)
		{
		}

		// Token: 0x06006B4A RID: 27466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600592F")]
		[Address(RVA = "0x21512E0", Offset = "0x21513E1", VA = "0x21512E0")]
		public FarmCropData()
		{
		}

		// Token: 0x06006B4B RID: 27467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005930")]
		[Address(RVA = "0x21512F0", Offset = "0x21513F1", VA = "0x21512F0")]
		public void SetPlantStatusData(PlantStatus _plantStatus)
		{
		}

		// Token: 0x06006B4C RID: 27468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005931")]
		[Address(RVA = "0x2151320", Offset = "0x2151421", VA = "0x2151320")]
		public void SetSoilStatusData(SoilStatus _soilStatus)
		{
		}

		// Token: 0x040172F4 RID: 94964
		[Token(Token = "0x4013EC5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180DB0", Offset = "0x180EB1")]
		public Vector3Int CellSetId;

		// Token: 0x040172F5 RID: 94965
		[Token(Token = "0x4013EC6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180DD0", Offset = "0x180ED1")]
		public int CellId;

		// Token: 0x040172F6 RID: 94966
		[Token(Token = "0x4013EC7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180DF0", Offset = "0x180EF1")]
		public bool IsCultivated;

		// Token: 0x040172F7 RID: 94967
		[Token(Token = "0x4013EC8")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180E10", Offset = "0x180F11")]
		public bool IsWatering;

		// Token: 0x040172F8 RID: 94968
		[Token(Token = "0x4013EC9")]
		[FieldOffset(Offset = "0x22")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180E30", Offset = "0x180F31")]
		public bool IsPlanted;

		// Token: 0x040172F9 RID: 94969
		[Token(Token = "0x4013ECA")]
		[FieldOffset(Offset = "0x23")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180E50", Offset = "0x180F51")]
		public bool IsLargeSize;

		// Token: 0x040172FA RID: 94970
		[Token(Token = "0x4013ECB")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180E70", Offset = "0x180F71")]
		public int PlantStatusLevel;

		// Token: 0x040172FB RID: 94971
		[Token(Token = "0x4013ECC")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180E90", Offset = "0x180F91")]
		public int PlantStatusLevelMax;

		// Token: 0x040172FC RID: 94972
		[Token(Token = "0x4013ECD")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "KeyAttribute", RVA = "0x180EB0", Offset = "0x180FB1")]
		public ItemData CropItemData;

		// Token: 0x040172FD RID: 94973
		[Token(Token = "0x4013ECE")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "IgnoreMemberAttribute", RVA = "0x180ED0", Offset = "0x180FD1")]
		public CropDataTable CropData;
	}
}
