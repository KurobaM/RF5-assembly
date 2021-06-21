using System;
using BinaryStream;
using Il2CppDummyDll;

// Token: 0x02000325 RID: 805
[Token(Token = "0x200025F")]
[Serializable]
public struct WeatherData
{
	// Token: 0x06001572 RID: 5490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x2DE660", Offset = "0x2DE761", VA = "0x2DE660")]
	public void Initalize()
	{
	}

	// Token: 0x06001573 RID: 5491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x2DE670", Offset = "0x2DE771", VA = "0x2DE670")]
	public void Writer(BinaryWriter writer)
	{
	}

	// Token: 0x06001574 RID: 5492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x2DE680", Offset = "0x2DE781", VA = "0x2DE680")]
	public void Reader0000(BinaryReader reader)
	{
	}

	// Token: 0x04000C63 RID: 3171
	[Token(Token = "0x4000977")]
	[FieldOffset(Offset = "0x0")]
	public byte WeatherId;

	// Token: 0x04000C64 RID: 3172
	[Token(Token = "0x4000978")]
	[FieldOffset(Offset = "0x1")]
	public byte WeatherDayId;

	// Token: 0x04000C65 RID: 3173
	[Token(Token = "0x4000979")]
	[FieldOffset(Offset = "0x2")]
	public byte TodayRate;

	// Token: 0x04000C66 RID: 3174
	[Token(Token = "0x400097A")]
	[FieldOffset(Offset = "0x3")]
	public byte TyphoonDayCount;

	// Token: 0x04000C67 RID: 3175
	[Token(Token = "0x400097B")]
	[FieldOffset(Offset = "0x4")]
	public byte RuneyDayCount;

	// Token: 0x04000C68 RID: 3176
	[Token(Token = "0x400097C")]
	[FieldOffset(Offset = "0x5")]
	public byte MeteorShowerDayCount;

	// Token: 0x04000C69 RID: 3177
	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x6")]
	public byte NextWeatherDayId;

	// Token: 0x04000C6A RID: 3178
	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x8")]
	public byte[] WeatherHour;
}
