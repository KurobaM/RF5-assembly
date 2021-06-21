using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001522 RID: 5410
	[Token(Token = "0x2000ED5")]
	public struct HandAnalysisImageState
	{
		// Token: 0x0401BDFA RID: 114170
		[Token(Token = "0x4018774")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BDFB RID: 114171
		[Token(Token = "0x4018775")]
		[FieldOffset(Offset = "0x8")]
		public IrCameraAmbientNoiseLevel ambientNoiseLevel;
	}
}
