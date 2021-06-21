using System;
using Il2CppDummyDll;

namespace ErosionBrushPlugin
{
	// Token: 0x02000E37 RID: 3639
	[Token(Token = "0x200094C")]
	public class Noise
	{
		// Token: 0x06005FBC RID: 24508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F2D")]
		[Address(RVA = "0x1DAC2B0", Offset = "0x1DAC3B1", VA = "0x1DAC2B0")]
		public Noise(float size, int resolution, int seedX, int seedZ)
		{
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00020040 File Offset: 0x0001E240
		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0x1DAC390", Offset = "0x1DAC491", VA = "0x1DAC390")]
		public float Fractal(int x, int z, float detail = 0.5f)
		{
			return 0f;
		}

		// Token: 0x0400BED4 RID: 48852
		[Token(Token = "0x4008EAF")]
		[FieldOffset(Offset = "0x10")]
		private int iterations;

		// Token: 0x0400BED5 RID: 48853
		[Token(Token = "0x4008EB0")]
		[FieldOffset(Offset = "0x14")]
		public int seedX;

		// Token: 0x0400BED6 RID: 48854
		[Token(Token = "0x4008EB1")]
		[FieldOffset(Offset = "0x18")]
		public int seedZ;

		// Token: 0x0400BED7 RID: 48855
		[Token(Token = "0x4008EB2")]
		[FieldOffset(Offset = "0x1C")]
		public int resolution;

		// Token: 0x0400BED8 RID: 48856
		[Token(Token = "0x4008EB3")]
		[FieldOffset(Offset = "0x20")]
		public float size;
	}
}
