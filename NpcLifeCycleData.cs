using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020007FE RID: 2046
[Token(Token = "0x2000544")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x1462F0", Offset = "0x1463F1")]
[Serializable]
public class NpcLifeCycleData : ScriptableObject
{
	// Token: 0x060036A9 RID: 13993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D71")]
	[Address(RVA = "0x1F47760", Offset = "0x1F47861", VA = "0x1F47760")]
	public NpcLifeCycleData()
	{
	}

	// Token: 0x040079A3 RID: 31139
	[Token(Token = "0x4006E32")]
	[FieldOffset(Offset = "0x18")]
	public NPCID NpcId;

	// Token: 0x040079A4 RID: 31140
	[Token(Token = "0x4006E33")]
	[FieldOffset(Offset = "0x20")]
	public NpcLifeCycleTime[] TimeList;

	// Token: 0x040079A5 RID: 31141
	[Token(Token = "0x4006E34")]
	[FieldOffset(Offset = "0x28")]
	public NpcLifeCycleWeather[] WeatherList;

	// Token: 0x040079A6 RID: 31142
	[Token(Token = "0x4006E35")]
	[FieldOffset(Offset = "0x30")]
	public NpcLifeCycleTimeData[] TimeData;
}
