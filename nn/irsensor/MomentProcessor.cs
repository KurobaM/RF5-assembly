using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001532 RID: 5426
	[Token(Token = "0x2000EE5")]
	public static class MomentProcessor
	{
		// Token: 0x06007B42 RID: 31554
		[Token(Token = "0x6006760")]
		[Address(RVA = "0x34DD2F0", Offset = "0x34DD3F1", VA = "0x34DD2F0")]
		[PreserveSig]
		public static extern void GetDefaultConfig(ref MomentProcessorConfig pOutValue);

		// Token: 0x06007B43 RID: 31555
		[Token(Token = "0x6006761")]
		[Address(RVA = "0x34DD300", Offset = "0x34DD401", VA = "0x34DD300")]
		[PreserveSig]
		public static extern void Run(IrCameraHandle handle, MomentProcessorConfig config);

		// Token: 0x06007B44 RID: 31556
		[Token(Token = "0x6006762")]
		[Address(RVA = "0x34DD340", Offset = "0x34DD441", VA = "0x34DD340")]
		[PreserveSig]
		public static extern Result GetState(ref MomentProcessorState pOutValue, IrCameraHandle handle);

		// Token: 0x06007B45 RID: 31557 RVA: 0x0002B698 File Offset: 0x00029898
		[Token(Token = "0x6006763")]
		[Address(RVA = "0x34DD360", Offset = "0x34DD461", VA = "0x34DD360")]
		public static Result GetStatus(MomentProcessorState[] pOutStates, ref int pOutCount, IrCameraHandle handle)
		{
			return default(Result);
		}

		// Token: 0x06007B46 RID: 31558
		[Token(Token = "0x6006764")]
		[Address(RVA = "0x34DD390", Offset = "0x34DD491", VA = "0x34DD390")]
		[PreserveSig]
		private static extern Result GetStates([In] [Out] MomentProcessorState[] pOutStates, ref int pOutCount, int countMax, IrCameraHandle handle);

		// Token: 0x06007B47 RID: 31559
		[Token(Token = "0x6006765")]
		[Address(RVA = "0x34DD3C0", Offset = "0x34DD4C1", VA = "0x34DD3C0")]
		[PreserveSig]
		public static extern MomentStatistic CalculateMomentRegionStatistic(ref MomentProcessorState pState, Rect windowOfInterest, int startRow, int startColumn, int rowCount, int columnCount);

		// Token: 0x0401BE4A RID: 114250
		[Token(Token = "0x40187C4")]
		public const int StateCountMax = 5;

		// Token: 0x0401BE4B RID: 114251
		[Token(Token = "0x40187C5")]
		public const int BlockColumnCount = 8;

		// Token: 0x0401BE4C RID: 114252
		[Token(Token = "0x40187C6")]
		public const int BlockRowCount = 6;

		// Token: 0x0401BE4D RID: 114253
		[Token(Token = "0x40187C7")]
		public const int BlockCount = 48;
	}
}
