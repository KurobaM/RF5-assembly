using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001508 RID: 5384
	[Token(Token = "0x2000EC5")]
	public struct ClusteringProcessorConfig
	{
		// Token: 0x06007A69 RID: 31337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066F5")]
		[Address(RVA = "0x388780", Offset = "0x388881", VA = "0x388780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BD65 RID: 114021
		[Token(Token = "0x4018722")]
		[FieldOffset(Offset = "0x0")]
		public IrCameraConfig irCameraConfig;

		// Token: 0x0401BD66 RID: 114022
		[Token(Token = "0x4018723")]
		[FieldOffset(Offset = "0x18")]
		public Rect windowOfInterest;

		// Token: 0x0401BD67 RID: 114023
		[Token(Token = "0x4018724")]
		[FieldOffset(Offset = "0x20")]
		public int objectPixelCountMin;

		// Token: 0x0401BD68 RID: 114024
		[Token(Token = "0x4018725")]
		[FieldOffset(Offset = "0x24")]
		public int objectPixelCountMax;

		// Token: 0x0401BD69 RID: 114025
		[Token(Token = "0x4018726")]
		[FieldOffset(Offset = "0x28")]
		public int objectIntensityMin;

		// Token: 0x0401BD6A RID: 114026
		[Token(Token = "0x4018727")]
		[FieldOffset(Offset = "0x2C")]
		public bool isExternalLightFilterEnabled;
	}
}
