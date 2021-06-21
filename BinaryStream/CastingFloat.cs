using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace BinaryStream
{
	// Token: 0x020011CF RID: 4559
	[Token(Token = "0x2000BA4")]
	[StructLayout(2)]
	public struct CastingFloat
	{
		// Token: 0x06007151 RID: 29009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0D")]
		[Address(RVA = "0x2F2750", Offset = "0x2F2851", VA = "0x2F2750")]
		public CastingFloat(byte dat0, byte dat1, byte dat2, byte dat3)
		{
		}

		// Token: 0x06007152 RID: 29010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0x2F2770", Offset = "0x2F2871", VA = "0x2F2770")]
		public CastingFloat(float dat0)
		{
		}

		// Token: 0x04018306 RID: 99078
		[Token(Token = "0x4014D72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float f;

		// Token: 0x04018307 RID: 99079
		[Token(Token = "0x4014D73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte d0;

		// Token: 0x04018308 RID: 99080
		[Token(Token = "0x4014D74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte d1;

		// Token: 0x04018309 RID: 99081
		[Token(Token = "0x4014D75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public byte d2;

		// Token: 0x0401830A RID: 99082
		[Token(Token = "0x4014D76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public byte d3;
	}
}
