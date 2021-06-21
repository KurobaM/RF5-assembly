using System;
using Il2CppDummyDll;

// Token: 0x020001B2 RID: 434
[Token(Token = "0x2000155")]
[Serializable]
public class TrackingCameraSetting
{
	// Token: 0x0600090E RID: 2318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x2074FA0", Offset = "0x20750A1", VA = "0x2074FA0")]
	public TrackingCameraSetting()
	{
	}

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x4000440")]
	[FieldOffset(Offset = "0x10")]
	public float distance;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x4000441")]
	[FieldOffset(Offset = "0x14")]
	public float defAngle;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x4000442")]
	[FieldOffset(Offset = "0x18")]
	public float minFov;

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x4000443")]
	[FieldOffset(Offset = "0x1C")]
	public float maxFov;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000444")]
	[FieldOffset(Offset = "0x20")]
	public float offsetY;

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000445")]
	[FieldOffset(Offset = "0x28")]
	public AxisSetting yAxis;

	// Token: 0x04000582 RID: 1410
	[Token(Token = "0x4000446")]
	[FieldOffset(Offset = "0x30")]
	public AxisSetting xAxis;
}
