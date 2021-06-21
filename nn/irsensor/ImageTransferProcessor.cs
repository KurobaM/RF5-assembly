using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001527 RID: 5415
	[Token(Token = "0x2000EDA")]
	public static class ImageTransferProcessor
	{
		// Token: 0x06007B22 RID: 31522
		[Token(Token = "0x6006740")]
		[Address(RVA = "0x34DC3C0", Offset = "0x34DC4C1", VA = "0x34DC3C0")]
		[PreserveSig]
		public static extern void GetDefaultConfig(ref ImageTransferProcessorConfig pOutValue);

		// Token: 0x06007B23 RID: 31523
		[Token(Token = "0x6006741")]
		[Address(RVA = "0x34DC3D0", Offset = "0x34DC4D1", VA = "0x34DC3D0")]
		[PreserveSig]
		public static extern void GetDefaultConfig(ref ImageTransferProcessorExConfig pOutValue);

		// Token: 0x06007B24 RID: 31524
		[Token(Token = "0x6006742")]
		[Address(RVA = "0x34DC3E0", Offset = "0x34DC4E1", VA = "0x34DC3E0")]
		[PreserveSig]
		public static extern void Run(IrCameraHandle handle, ImageTransferProcessorConfig config, IntPtr workBuffer, long workBufferSize);

		// Token: 0x06007B25 RID: 31525
		[Token(Token = "0x6006743")]
		[Address(RVA = "0x34DC420", Offset = "0x34DC521", VA = "0x34DC420")]
		[PreserveSig]
		public static extern void Run(IrCameraHandle handle, ImageTransferProcessorExConfig config, IntPtr workBuffer, long workBufferSize);

		// Token: 0x06007B26 RID: 31526
		[Token(Token = "0x6006744")]
		[Address(RVA = "0x34DC460", Offset = "0x34DC561", VA = "0x34DC460")]
		[PreserveSig]
		public static extern Result GetState(ref ImageTransferProcessorState pOutState, IntPtr pOutImage, long size, IrCameraHandle handle);

		// Token: 0x06007B27 RID: 31527
		[Token(Token = "0x6006745")]
		[Address(RVA = "0x34DC480", Offset = "0x34DC581", VA = "0x34DC480")]
		[PreserveSig]
		public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorConfig config);

		// Token: 0x06007B28 RID: 31528
		[Token(Token = "0x6006746")]
		[Address(RVA = "0x34DC4B0", Offset = "0x34DC5B1", VA = "0x34DC4B0")]
		[PreserveSig]
		public static extern void InitializeWorkBuffer(ref IntPtr pOutWorkBuffer, ref long pOutWorkBufferSize, ImageTransferProcessorExConfig config);

		// Token: 0x06007B29 RID: 31529
		[Token(Token = "0x6006747")]
		[Address(RVA = "0x34DC4F0", Offset = "0x34DC5F1", VA = "0x34DC4F0")]
		[PreserveSig]
		public static extern void DestroyWorkBuffer(IntPtr workBuffer);

		// Token: 0x06007B2A RID: 31530 RVA: 0x0002B578 File Offset: 0x00029778
		[Token(Token = "0x6006748")]
		[Address(RVA = "0x34DC500", Offset = "0x34DC601", VA = "0x34DC500")]
		public static int GetWorkBufferSize(ImageTransferProcessorFormat format)
		{
			return 0;
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x0002B590 File Offset: 0x00029790
		[Token(Token = "0x6006749")]
		[Address(RVA = "0x34DC530", Offset = "0x34DC631", VA = "0x34DC530")]
		public static int GetImageSize(ImageTransferProcessorFormat format)
		{
			return 0;
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[Token(Token = "0x600674A")]
		[Address(RVA = "0x34DC560", Offset = "0x34DC661", VA = "0x34DC560")]
		public static int GetImageWidth(ImageTransferProcessorFormat format)
		{
			return 0;
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x0002B5C0 File Offset: 0x000297C0
		[Token(Token = "0x600674B")]
		[Address(RVA = "0x34DC590", Offset = "0x34DC691", VA = "0x34DC590")]
		public static int GetImageHeight(ImageTransferProcessorFormat format)
		{
			return 0;
		}

		// Token: 0x0401BE08 RID: 114184
		[Token(Token = "0x4018782")]
		public const int QvgaImageSize = 76800;

		// Token: 0x0401BE09 RID: 114185
		[Token(Token = "0x4018783")]
		public const int QqvgaImageSize = 19200;

		// Token: 0x0401BE0A RID: 114186
		[Token(Token = "0x4018784")]
		public const int QqqvgaImageSize = 4800;

		// Token: 0x0401BE0B RID: 114187
		[Token(Token = "0x4018785")]
		public const int ImageSize320x240 = 76800;

		// Token: 0x0401BE0C RID: 114188
		[Token(Token = "0x4018786")]
		public const int ImageSize160x120 = 19200;

		// Token: 0x0401BE0D RID: 114189
		[Token(Token = "0x4018787")]
		public const int ImageSize80x60 = 4800;

		// Token: 0x0401BE0E RID: 114190
		[Token(Token = "0x4018788")]
		public const int ImageSize40x30 = 1200;

		// Token: 0x0401BE0F RID: 114191
		[Token(Token = "0x4018789")]
		public const int ImageSize20x15 = 300;

		// Token: 0x0401BE10 RID: 114192
		[Token(Token = "0x401878A")]
		public const int QvgaWorkBufferSize = 155648;

		// Token: 0x0401BE11 RID: 114193
		[Token(Token = "0x401878B")]
		public const int QqvgaWorkBufferSize = 40960;

		// Token: 0x0401BE12 RID: 114194
		[Token(Token = "0x401878C")]
		public const int QqqvgaWorkBufferSize = 12288;

		// Token: 0x0401BE13 RID: 114195
		[Token(Token = "0x401878D")]
		public const int WorkBufferSize320x240 = 155648;

		// Token: 0x0401BE14 RID: 114196
		[Token(Token = "0x401878E")]
		public const int WorkBufferSize160x120 = 40960;

		// Token: 0x0401BE15 RID: 114197
		[Token(Token = "0x401878F")]
		public const int WorkBufferSize80x60 = 12288;

		// Token: 0x0401BE16 RID: 114198
		[Token(Token = "0x4018790")]
		public const int WorkBufferSize40x30 = 4096;

		// Token: 0x0401BE17 RID: 114199
		[Token(Token = "0x4018791")]
		public const int WorkBufferSize20x15 = 4096;

		// Token: 0x0401BE18 RID: 114200
		[Token(Token = "0x4018792")]
		public const long ExposureTimeMinNanoSeconds = 7000L;

		// Token: 0x0401BE19 RID: 114201
		[Token(Token = "0x4018793")]
		public const long ExposureTimeMaxNanoSeconds = 600000L;
	}
}
