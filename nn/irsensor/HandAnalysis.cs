using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.util;

namespace nn.irsensor
{
	// Token: 0x0200150D RID: 5389
	[Token(Token = "0x2000EC8")]
	public static class HandAnalysis
	{
		// Token: 0x06007A88 RID: 31368
		[Token(Token = "0x60066FE")]
		[Address(RVA = "0x34D9C60", Offset = "0x34D9D61", VA = "0x34D9C60")]
		[PreserveSig]
		public static extern Result Run(IrCameraHandle handle, HandAnalysisConfig config);

		// Token: 0x06007A89 RID: 31369
		[Token(Token = "0x60066FF")]
		[Address(RVA = "0x34D9C80", Offset = "0x34D9D81", VA = "0x34D9C80")]
		[PreserveSig]
		public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutValue, IrCameraHandle handle);

		// Token: 0x06007A8A RID: 31370 RVA: 0x0002AE10 File Offset: 0x00029010
		[Token(Token = "0x6006700")]
		[Address(RVA = "0x34D9CA0", Offset = "0x34D9DA1", VA = "0x34D9CA0")]
		public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle)
		{
			return default(Result);
		}

		// Token: 0x06007A8B RID: 31371
		[Token(Token = "0x6006701")]
		[Address(RVA = "0x34D9CE0", Offset = "0x34D9DE1", VA = "0x34D9CE0")]
		[PreserveSig]
		private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutValueArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle);

		// Token: 0x06007A8C RID: 31372
		[Token(Token = "0x6006702")]
		[Address(RVA = "0x34D9D10", Offset = "0x34D9E11", VA = "0x34D9D10")]
		[PreserveSig]
		public static extern Result GetSilhouetteState(ref HandAnalysisSilhouetteState pOutState, [In] [Out] Float2[] pOutPointBuffer, IrCameraHandle handle);

		// Token: 0x06007A8D RID: 31373 RVA: 0x0002AE28 File Offset: 0x00029028
		[Token(Token = "0x6006703")]
		[Address(RVA = "0x34D9D40", Offset = "0x34D9E41", VA = "0x34D9D40")]
		public static Result GetSilhouetteState(HandAnalysisSilhouetteState[] pOutStateArray, Float2[][] pOutPointArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle)
		{
			return default(Result);
		}

		// Token: 0x06007A8E RID: 31374
		[Token(Token = "0x6006704")]
		[Address(RVA = "0x34D9D50", Offset = "0x34D9E51", VA = "0x34D9D50")]
		[PreserveSig]
		private static extern Result GetSilhouetteState([In] [Out] HandAnalysisSilhouetteState[] pOutStateArray, [In] [Out] Float2[][] pOutPointArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle);

		// Token: 0x06007A8F RID: 31375
		[Token(Token = "0x6006705")]
		[Address(RVA = "0x34D9D70", Offset = "0x34D9E71", VA = "0x34D9D70")]
		[PreserveSig]
		public static extern Result GetImageState(ref HandAnalysisImageState pOutState, [In] [Out] ushort[] pOutImageBuffer, IrCameraHandle handle);

		// Token: 0x06007A90 RID: 31376 RVA: 0x0002AE40 File Offset: 0x00029040
		[Token(Token = "0x6006706")]
		[Address(RVA = "0x34D9DA0", Offset = "0x34D9EA1", VA = "0x34D9DA0")]
		public static Result GetImageState(HandAnalysisImageState[] pOutStateArray, ushort[] pOutImageArray, ref int pReturnCount, long infSamplingNumber, IrCameraHandle handle)
		{
			return default(Result);
		}

		// Token: 0x06007A91 RID: 31377
		[Token(Token = "0x6006707")]
		[Address(RVA = "0x34D9DE0", Offset = "0x34D9EE1", VA = "0x34D9DE0")]
		[PreserveSig]
		private static extern Result GetImageState([In] [Out] HandAnalysisImageState[] pOutStateArray, [In] [Out] ushort[] pOutImageArray, ref int pReturnCount, int maxCount, long infSamplingNumber, IrCameraHandle handle);

		// Token: 0x0401BD8B RID: 114059
		[Token(Token = "0x4018734")]
		public const int ProcessorStateCountMax = 5;

		// Token: 0x0401BD8C RID: 114060
		[Token(Token = "0x4018735")]
		public const int ShapePointCountMax = 512;

		// Token: 0x0401BD8D RID: 114061
		[Token(Token = "0x4018736")]
		public const int ShapeCountMax = 16;

		// Token: 0x0401BD8E RID: 114062
		[Token(Token = "0x4018737")]
		public const int ProtrusionCountMax = 8;

		// Token: 0x0401BD8F RID: 114063
		[Token(Token = "0x4018738")]
		public const int HandCountMax = 2;

		// Token: 0x0401BD90 RID: 114064
		[Token(Token = "0x4018739")]
		public const int ImageWidth = 40;

		// Token: 0x0401BD91 RID: 114065
		[Token(Token = "0x401873A")]
		public const int ImageHeight = 30;
	}
}
