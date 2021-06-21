using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001567 RID: 5479
	[Token(Token = "0x2000F14")]
	public static class VibrationFile
	{
		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06007C08 RID: 31752 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		[Token(Token = "0x17000B55")]
		public static ErrorRange ResultInvalid
		{
			[Token(Token = "0x60067E4")]
			[Address(RVA = "0x2D78990", Offset = "0x2D78A91", VA = "0x2D78990")]
			get
			{
				return default(ErrorRange);
			}
		}

		// Token: 0x06007C09 RID: 31753
		[Token(Token = "0x60067E5")]
		[Address(RVA = "0x2D789D0", Offset = "0x2D78AD1", VA = "0x2D789D0")]
		[PreserveSig]
		public static extern Result Parse(ref VibrationFileInfo pOutInfo, ref VibrationFileParserContext pOutContext, byte[] address, long fileSize);

		// Token: 0x06007C0A RID: 31754
		[Token(Token = "0x60067E6")]
		[Address(RVA = "0x2D78A00", Offset = "0x2D78B01", VA = "0x2D78A00")]
		[PreserveSig]
		public static extern void RetrieveValue(ref VibrationValue pOutValue, int position, ref VibrationFileParserContext pContext);

		// Token: 0x06007C0B RID: 31755
		[Token(Token = "0x60067E7")]
		[Address(RVA = "0x2D78A10", Offset = "0x2D78B11", VA = "0x2D78A10")]
		[PreserveSig]
		private static extern void Generate(ref long pOutSize, byte[] outBuffer, long bufferSize, VibrationValueArrayInfo info, VibrationValue[] pValues);

		// Token: 0x06007C0C RID: 31756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E8")]
		[Address(RVA = "0x2D78A60", Offset = "0x2D78B61", VA = "0x2D78A60")]
		public static void Generate(ref long pOutSize, byte[] outBuffer, VibrationValueArrayInfo info, VibrationValue[] pValues)
		{
		}

		// Token: 0x06007C0D RID: 31757
		[Token(Token = "0x60067E9")]
		[Address(RVA = "0x2D78AC0", Offset = "0x2D78BC1", VA = "0x2D78AC0")]
		[PreserveSig]
		public static extern long CalculateSize(VibrationValueArrayInfo info);
	}
}
