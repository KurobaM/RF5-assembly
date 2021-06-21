using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x0200156D RID: 5485
	[Token(Token = "0x2000F1A")]
	public static class SixAxisSensor
	{
		// Token: 0x06007C13 RID: 31763
		[Token(Token = "0x60067EF")]
		[Address(RVA = "0x2D62990", Offset = "0x2D62A91", VA = "0x2D62990")]
		[PreserveSig]
		public static extern int GetHandles(SixAxisSensorHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle);

		// Token: 0x06007C14 RID: 31764
		[Token(Token = "0x60067F0")]
		[Address(RVA = "0x2D629A0", Offset = "0x2D62AA1", VA = "0x2D629A0")]
		[PreserveSig]
		public static extern void Start(SixAxisSensorHandle handle);

		// Token: 0x06007C15 RID: 31765
		[Token(Token = "0x60067F1")]
		[Address(RVA = "0x2D629B0", Offset = "0x2D62AB1", VA = "0x2D629B0")]
		[PreserveSig]
		public static extern void Stop(SixAxisSensorHandle handle);

		// Token: 0x06007C16 RID: 31766
		[Token(Token = "0x60067F2")]
		[Address(RVA = "0x2D629C0", Offset = "0x2D62AC1", VA = "0x2D629C0")]
		[PreserveSig]
		public static extern bool IsRest(SixAxisSensorHandle handle);

		// Token: 0x06007C17 RID: 31767
		[Token(Token = "0x60067F3")]
		[Address(RVA = "0x2D629E0", Offset = "0x2D62AE1", VA = "0x2D629E0")]
		[PreserveSig]
		public static extern void GetState(ref SixAxisSensorState pOutValue, SixAxisSensorHandle handle);

		// Token: 0x06007C18 RID: 31768
		[Token(Token = "0x60067F4")]
		[Address(RVA = "0x2D629F0", Offset = "0x2D62AF1", VA = "0x2D629F0")]
		[PreserveSig]
		public static extern int GetStates([Out] SixAxisSensorState[] pOutValues, int count, SixAxisSensorHandle handle);

		// Token: 0x06007C19 RID: 31769
		[Token(Token = "0x60067F5")]
		[Address(RVA = "0x2D62B20", Offset = "0x2D62C21", VA = "0x2D62B20")]
		[PreserveSig]
		public static extern bool IsFusionEnabled(SixAxisSensorHandle handle);

		// Token: 0x06007C1A RID: 31770
		[Token(Token = "0x60067F6")]
		[Address(RVA = "0x2D62B40", Offset = "0x2D62C41", VA = "0x2D62B40")]
		[PreserveSig]
		public static extern void EnableFusion(SixAxisSensorHandle handle, bool enable);

		// Token: 0x06007C1B RID: 31771
		[Token(Token = "0x60067F7")]
		[Address(RVA = "0x2D62B50", Offset = "0x2D62C51", VA = "0x2D62B50")]
		[PreserveSig]
		public static extern void SetFusionParameters(SixAxisSensorHandle handle, float revisePower, float reviseRange);

		// Token: 0x06007C1C RID: 31772
		[Token(Token = "0x60067F8")]
		[Address(RVA = "0x2D62B60", Offset = "0x2D62C61", VA = "0x2D62B60")]
		[PreserveSig]
		public static extern void GetFusionParameters(ref float pOutRevisePower, ref float pOutReviseRange, SixAxisSensorHandle handle);

		// Token: 0x06007C1D RID: 31773
		[Token(Token = "0x60067F9")]
		[Address(RVA = "0x2D62B70", Offset = "0x2D62C71", VA = "0x2D62B70")]
		[PreserveSig]
		public static extern void ResetFusionParameters(SixAxisSensorHandle handle);

		// Token: 0x06007C1E RID: 31774
		[Token(Token = "0x60067FA")]
		[Address(RVA = "0x2D62B80", Offset = "0x2D62C81", VA = "0x2D62B80")]
		[PreserveSig]
		public static extern void SetGyroscopeZeroDriftMode(SixAxisSensorHandle handle, GyroscopeZeroDriftMode mode);

		// Token: 0x06007C1F RID: 31775
		[Token(Token = "0x60067FB")]
		[Address(RVA = "0x2D62B90", Offset = "0x2D62C91", VA = "0x2D62B90")]
		[PreserveSig]
		public static extern GyroscopeZeroDriftMode GetGyroscopeZeroDriftMode(SixAxisSensorHandle handle);

		// Token: 0x06007C20 RID: 31776
		[Token(Token = "0x60067FC")]
		[Address(RVA = "0x2D62BA0", Offset = "0x2D62CA1", VA = "0x2D62BA0")]
		[PreserveSig]
		public static extern bool IsFirmwareUpdateAvailableForSixAxisSensor(SixAxisSensorHandle handle);

		// Token: 0x0401BF85 RID: 114565
		[Token(Token = "0x40188B7")]
		public const int StateCountMax = 16;

		// Token: 0x0401BF86 RID: 114566
		[Token(Token = "0x40188B8")]
		public const int HandleCountMax = 8;
	}
}
