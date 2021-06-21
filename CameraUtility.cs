using System;
using Il2CppDummyDll;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x2000147")]
public static class CameraUtility
{
	// Token: 0x060008AD RID: 2221 RVA: 0x00004D88 File Offset: 0x00002F88
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x1E79450", Offset = "0x1E79551", VA = "0x1E79450")]
	public static float GetAxisY()
	{
		return 0f;
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00004DA0 File Offset: 0x00002FA0
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x1E79500", Offset = "0x1E79601", VA = "0x1E79500")]
	public static float GetAxisX()
	{
		return 0f;
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x00004DB8 File Offset: 0x00002FB8
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x1E794F0", Offset = "0x1E795F1", VA = "0x1E794F0")]
	private static float GetAxis(float input, bool invert)
	{
		return 0f;
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x00004DD0 File Offset: 0x00002FD0
	[Token(Token = "0x6000776")]
	[Address(RVA = "0x1E795A0", Offset = "0x1E796A1", VA = "0x1E795A0")]
	public static float UpdateAxisSpeed(float input, AxisSetting setting, float prevSpeed, CameraUtility.AxisType axisType)
	{
		return 0f;
	}

	// Token: 0x0400051A RID: 1306
	[Token(Token = "0x40003EB")]
	private const float CAMERA_AXIS_THRESHOLD = 0.25f;

	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x2000FE2")]
	public enum AxisType
	{
		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x4018DA3")]
		Horizontal,
		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x4018DA4")]
		Vertical
	}
}
