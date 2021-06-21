using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001507 RID: 5383
	[Token(Token = "0x2000EC4")]
	public static class ClusteringProcessor
	{
		// Token: 0x06007A65 RID: 31333
		[Token(Token = "0x60066F1")]
		[Address(RVA = "0x2D7AEF0", Offset = "0x2D7AFF1", VA = "0x2D7AEF0")]
		[PreserveSig]
		public static extern void GetDefaultConfig(ref ClusteringProcessorConfig pOutValue);

		// Token: 0x06007A66 RID: 31334
		[Token(Token = "0x60066F2")]
		[Address(RVA = "0x2D7AF00", Offset = "0x2D7B001", VA = "0x2D7AF00")]
		[PreserveSig]
		public static extern void Run(IrCameraHandle handle, ClusteringProcessorConfig config);

		// Token: 0x06007A67 RID: 31335
		[Token(Token = "0x60066F3")]
		[Address(RVA = "0x2D7AF40", Offset = "0x2D7B041", VA = "0x2D7AF40")]
		[PreserveSig]
		public static extern Result GetState(ref ClusteringProcessorState pOutValue, IrCameraHandle handle);

		// Token: 0x06007A68 RID: 31336
		[Token(Token = "0x60066F4")]
		[Address(RVA = "0x2D7AF60", Offset = "0x2D7B061", VA = "0x2D7AF60")]
		[PreserveSig]
		public static extern Result GetStates([Out] ClusteringProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle);

		// Token: 0x0401BD5F RID: 114015
		[Token(Token = "0x401871C")]
		public const int StateCountMax = 5;

		// Token: 0x0401BD60 RID: 114016
		[Token(Token = "0x401871D")]
		public const int ObjectCountMax = 16;

		// Token: 0x0401BD61 RID: 114017
		[Token(Token = "0x401871E")]
		public const int ObjectPixelCountMax = 76800;

		// Token: 0x0401BD62 RID: 114018
		[Token(Token = "0x401871F")]
		public const int OutObjectPixelCountMax = 65535;

		// Token: 0x0401BD63 RID: 114019
		[Token(Token = "0x4018720")]
		public const long ExposureTimeMinNanoSeconds = 7000L;

		// Token: 0x0401BD64 RID: 114020
		[Token(Token = "0x4018721")]
		public const long ExposureTimeMaxNanoSeconds = 600000L;
	}
}
