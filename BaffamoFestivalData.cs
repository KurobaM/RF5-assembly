using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004EE RID: 1262
[Token(Token = "0x2000399")]
[Serializable]
public class BaffamoFestivalData
{
	// Token: 0x06001EF9 RID: 7929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x22A1180", Offset = "0x22A1281", VA = "0x22A1180")]
	public BaffamoFestivalData()
	{
	}

	// Token: 0x040065D5 RID: 26069
	[Token(Token = "0x400604E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MonsterModelDataID MonsterDataID;

	// Token: 0x040065D6 RID: 26070
	[Token(Token = "0x400604F")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public BaffamoID BaffamoID;

	// Token: 0x040065D7 RID: 26071
	[Token(Token = "0x4006050")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float MoveSpeedRate;

	// Token: 0x040065D8 RID: 26072
	[Token(Token = "0x4006051")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int RollingScore;
}
