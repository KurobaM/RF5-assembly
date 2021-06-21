using System;
using System.Collections.Generic;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200056C RID: 1388
[Token(Token = "0x20003E8")]
[Serializable]
public struct MiningDataTable
{
	// Token: 0x06002183 RID: 8579 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x22F6870", Offset = "0x22F6971", VA = "0x22F6870")]
	public static MiningDataTable GetDataTable(MiningID miningId)
	{
		return default(MiningDataTable);
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x22F69B0", Offset = "0x22F6AB1", VA = "0x22F69B0")]
	public static Dictionary<string, int> GetDataTable4List(MiningID miningId)
	{
		return null;
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x22F6DA0", Offset = "0x22F6EA1", VA = "0x22F6DA0")]
	public static int GetDataTableCount()
	{
		return 0;
	}

	// Token: 0x040069ED RID: 27117
	[Token(Token = "0x40063AF")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public int MiningPointID;

	// Token: 0x040069EE RID: 27118
	[Token(Token = "0x40063B0")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public string Mine1;

	// Token: 0x040069EF RID: 27119
	[Token(Token = "0x40063B1")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Rate1;

	// Token: 0x040069F0 RID: 27120
	[Token(Token = "0x40063B2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string Mine2;

	// Token: 0x040069F1 RID: 27121
	[Token(Token = "0x40063B3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int Rate2;

	// Token: 0x040069F2 RID: 27122
	[Token(Token = "0x40063B4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string Mine3;

	// Token: 0x040069F3 RID: 27123
	[Token(Token = "0x40063B5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public int Rate3;

	// Token: 0x040069F4 RID: 27124
	[Token(Token = "0x40063B6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public string Mine4;

	// Token: 0x040069F5 RID: 27125
	[Token(Token = "0x40063B7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public int Rate4;

	// Token: 0x040069F6 RID: 27126
	[Token(Token = "0x40063B8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public string Mine5;

	// Token: 0x040069F7 RID: 27127
	[Token(Token = "0x40063B9")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	public int Rate5;

	// Token: 0x040069F8 RID: 27128
	[Token(Token = "0x40063BA")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	public string Mine6;

	// Token: 0x040069F9 RID: 27129
	[Token(Token = "0x40063BB")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	public int Rate6;

	// Token: 0x040069FA RID: 27130
	[Token(Token = "0x40063BC")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	public string Mine7;

	// Token: 0x040069FB RID: 27131
	[Token(Token = "0x40063BD")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public int Rate7;

	// Token: 0x040069FC RID: 27132
	[Token(Token = "0x40063BE")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public string Mine8;

	// Token: 0x040069FD RID: 27133
	[Token(Token = "0x40063BF")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public int Rate8;

	// Token: 0x040069FE RID: 27134
	[Token(Token = "0x40063C0")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	public string Mine9;

	// Token: 0x040069FF RID: 27135
	[Token(Token = "0x40063C1")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public int Rate9;

	// Token: 0x04006A00 RID: 27136
	[Token(Token = "0x40063C2")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public string Mine10;

	// Token: 0x04006A01 RID: 27137
	[Token(Token = "0x40063C3")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public int Rate10;

	// Token: 0x04006A02 RID: 27138
	[Token(Token = "0x40063C4")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public string Mine11;

	// Token: 0x04006A03 RID: 27139
	[Token(Token = "0x40063C5")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public int Rate11;

	// Token: 0x04006A04 RID: 27140
	[Token(Token = "0x40063C6")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	public string Mine12;

	// Token: 0x04006A05 RID: 27141
	[Token(Token = "0x40063C7")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public int Rate12;

	// Token: 0x04006A06 RID: 27142
	[Token(Token = "0x40063C8")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public string Mine13;

	// Token: 0x04006A07 RID: 27143
	[Token(Token = "0x40063C9")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public int Rate13;

	// Token: 0x04006A08 RID: 27144
	[Token(Token = "0x40063CA")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public string Mine14;

	// Token: 0x04006A09 RID: 27145
	[Token(Token = "0x40063CB")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public int Rate14;

	// Token: 0x04006A0A RID: 27146
	[Token(Token = "0x40063CC")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	public string Mine15;

	// Token: 0x04006A0B RID: 27147
	[Token(Token = "0x40063CD")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	public int Rate15;

	// Token: 0x04006A0C RID: 27148
	[Token(Token = "0x40063CE")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public string Mine16;

	// Token: 0x04006A0D RID: 27149
	[Token(Token = "0x40063CF")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public int Rate16;

	// Token: 0x04006A0E RID: 27150
	[Token(Token = "0x40063D0")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	public string Mine17;

	// Token: 0x04006A0F RID: 27151
	[Token(Token = "0x40063D1")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	public int Rate17;

	// Token: 0x04006A10 RID: 27152
	[Token(Token = "0x40063D2")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	public string Mine18;

	// Token: 0x04006A11 RID: 27153
	[Token(Token = "0x40063D3")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	public int Rate18;

	// Token: 0x04006A12 RID: 27154
	[Token(Token = "0x40063D4")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	public string Mine19;

	// Token: 0x04006A13 RID: 27155
	[Token(Token = "0x40063D5")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	public int Rate19;

	// Token: 0x04006A14 RID: 27156
	[Token(Token = "0x40063D6")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	public string Mine20;

	// Token: 0x04006A15 RID: 27157
	[Token(Token = "0x40063D7")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	public int Rate20;

	// Token: 0x04006A16 RID: 27158
	[Token(Token = "0x40063D8")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	public string Mine21;

	// Token: 0x04006A17 RID: 27159
	[Token(Token = "0x40063D9")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	public int Rate21;

	// Token: 0x04006A18 RID: 27160
	[Token(Token = "0x40063DA")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	public string Mine22;

	// Token: 0x04006A19 RID: 27161
	[Token(Token = "0x40063DB")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	public int Rate22;

	// Token: 0x04006A1A RID: 27162
	[Token(Token = "0x40063DC")]
	[FieldOffset(Offset = "0x0")]
	private static MiningDataTableArray _miningDataTableArray;
}
