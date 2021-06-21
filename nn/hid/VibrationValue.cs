using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x020015AB RID: 5547
	[Token(Token = "0x2000F36")]
	public struct VibrationValue
	{
		// Token: 0x06007DD7 RID: 32215 RVA: 0x0002CC88 File Offset: 0x0002AE88
		[Token(Token = "0x600683D")]
		[Address(RVA = "0x2D7A070", Offset = "0x2D7A171", VA = "0x2D7A070")]
		public static VibrationValue Make()
		{
			return default(VibrationValue);
		}

		// Token: 0x06007DD8 RID: 32216 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
		[Token(Token = "0x600683E")]
		[Address(RVA = "0x2D7A0B0", Offset = "0x2D7A1B1", VA = "0x2D7A0B0")]
		public static VibrationValue Make(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh)
		{
			return default(VibrationValue);
		}

		// Token: 0x06007DD9 RID: 32217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600683F")]
		[Address(RVA = "0x3884B0", Offset = "0x3885B1", VA = "0x3884B0")]
		public VibrationValue(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh)
		{
		}

		// Token: 0x06007DDA RID: 32218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006840")]
		[Address(RVA = "0x3884D0", Offset = "0x3885D1", VA = "0x3884D0")]
		public void Set(float amplitudeLow, float frequencyLow, float amplitudeHigh, float frequencyHigh)
		{
		}

		// Token: 0x06007DDB RID: 32219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006841")]
		[Address(RVA = "0x3884F0", Offset = "0x3885F1", VA = "0x3884F0")]
		public void Clear()
		{
		}

		// Token: 0x06007DDC RID: 32220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006842")]
		[Address(RVA = "0x388500", Offset = "0x388601", VA = "0x388500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401C0D4 RID: 114900
		[Token(Token = "0x4018930")]
		public const int FrequencyLowDefault = 160;

		// Token: 0x0401C0D5 RID: 114901
		[Token(Token = "0x4018931")]
		public const int FrequencyHighDefault = 320;

		// Token: 0x0401C0D6 RID: 114902
		[Token(Token = "0x4018932")]
		[FieldOffset(Offset = "0x0")]
		public float amplitudeLow;

		// Token: 0x0401C0D7 RID: 114903
		[Token(Token = "0x4018933")]
		[FieldOffset(Offset = "0x4")]
		public float frequencyLow;

		// Token: 0x0401C0D8 RID: 114904
		[Token(Token = "0x4018934")]
		[FieldOffset(Offset = "0x8")]
		public float amplitudeHigh;

		// Token: 0x0401C0D9 RID: 114905
		[Token(Token = "0x4018935")]
		[FieldOffset(Offset = "0xC")]
		public float frequencyHigh;
	}
}
