using System;
using Il2CppDummyDll;

// Token: 0x020001B1 RID: 433
[Token(Token = "0x2000154")]
[Serializable]
public class AxisSetting
{
	// Token: 0x0600090D RID: 2317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x229A1B0", Offset = "0x229A2B1", VA = "0x229A1B0")]
	public AxisSetting()
	{
	}

	// Token: 0x04000579 RID: 1401
	[Token(Token = "0x400043D")]
	[FieldOffset(Offset = "0x10")]
	public SpeedSetting rotation;

	// Token: 0x0400057A RID: 1402
	[Token(Token = "0x400043E")]
	[FieldOffset(Offset = "0x18")]
	public SpeedSetting acceleration;

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400043F")]
	[FieldOffset(Offset = "0x20")]
	public SpeedSetting deceleration;
}
