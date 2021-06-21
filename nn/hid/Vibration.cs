using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015A5 RID: 5541
	[Token(Token = "0x2000F32")]
	public static class Vibration
	{
		// Token: 0x06007DB9 RID: 32185
		[Token(Token = "0x6006835")]
		[Address(RVA = "0x2D78880", Offset = "0x2D78981", VA = "0x2D78880")]
		[PreserveSig]
		public static extern int GetDeviceHandles(VibrationDeviceHandle[] pOutValues, int count, NpadId npadId, NpadStyle npadStyle);

		// Token: 0x06007DBA RID: 32186
		[Token(Token = "0x6006836")]
		[Address(RVA = "0x2D78890", Offset = "0x2D78991", VA = "0x2D78890")]
		[PreserveSig]
		public static extern void GetDeviceInfo(ref VibrationDeviceInfo pOutValue, VibrationDeviceHandle handle);

		// Token: 0x06007DBB RID: 32187
		[Token(Token = "0x6006837")]
		[Address(RVA = "0x2D788A0", Offset = "0x2D789A1", VA = "0x2D788A0")]
		[PreserveSig]
		public static extern void InitializeDevice(VibrationDeviceHandle handle);

		// Token: 0x06007DBC RID: 32188
		[Token(Token = "0x6006838")]
		[Address(RVA = "0x2D788B0", Offset = "0x2D789B1", VA = "0x2D788B0")]
		[PreserveSig]
		public static extern void SendValue(VibrationDeviceHandle handle, VibrationValue value);

		// Token: 0x06007DBD RID: 32189
		[Token(Token = "0x6006839")]
		[Address(RVA = "0x2D788C0", Offset = "0x2D789C1", VA = "0x2D788C0")]
		[PreserveSig]
		public static extern void GetActualValue(ref VibrationValue pOutValue, VibrationDeviceHandle handle);

		// Token: 0x06007DBE RID: 32190
		[Token(Token = "0x600683A")]
		[Address(RVA = "0x2D788D0", Offset = "0x2D789D1", VA = "0x2D788D0")]
		[PreserveSig]
		public static extern bool IsPermitted();
	}
}
