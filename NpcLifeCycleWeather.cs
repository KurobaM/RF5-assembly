using System;
using Define;
using Il2CppDummyDll;

// Token: 0x02000802 RID: 2050
[Token(Token = "0x2000548")]
[Serializable]
public class NpcLifeCycleWeather
{
	// Token: 0x060036BE RID: 14014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002D86")]
	[Address(RVA = "0x1F481A0", Offset = "0x1F482A1", VA = "0x1F481A0")]
	public NpcLifeCycleWeather()
	{
	}

	// Token: 0x040079B1 RID: 31153
	[Token(Token = "0x4006E40")]
	[FieldOffset(Offset = "0x10")]
	public Weather Weather;

	// Token: 0x040079B2 RID: 31154
	[Token(Token = "0x4006E41")]
	[FieldOffset(Offset = "0x14")]
	public int TimeOffset;
}
