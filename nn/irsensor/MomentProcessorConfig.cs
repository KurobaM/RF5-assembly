using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001534 RID: 5428
	[Token(Token = "0x2000EE7")]
	public struct MomentProcessorConfig : IEquatable<MomentProcessorConfig>
	{
		// Token: 0x06007B48 RID: 31560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006766")]
		[Address(RVA = "0x39F4F0", Offset = "0x39F5F1", VA = "0x39F4F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x0002B6B0 File Offset: 0x000298B0
		[Token(Token = "0x6006767")]
		[Address(RVA = "0x34DD5D0", Offset = "0x34DD6D1", VA = "0x34DD5D0")]
		public static bool operator ==(MomentProcessorConfig lhs, MomentProcessorConfig rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x0002B6C8 File Offset: 0x000298C8
		[Token(Token = "0x6006768")]
		[Address(RVA = "0x34DD700", Offset = "0x34DD801", VA = "0x34DD700")]
		public static bool operator !=(MomentProcessorConfig lhs, MomentProcessorConfig rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x0002B6E0 File Offset: 0x000298E0
		[Token(Token = "0x6006769")]
		[Address(RVA = "0x39F500", Offset = "0x39F601", VA = "0x39F500", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007B4C RID: 31564 RVA: 0x0002B6F8 File Offset: 0x000298F8
		[Token(Token = "0x600676A")]
		[Address(RVA = "0x39F510", Offset = "0x39F611", VA = "0x39F510", Slot = "4")]
		public bool Equals(MomentProcessorConfig other)
		{
			return default(bool);
		}

		// Token: 0x06007B4D RID: 31565 RVA: 0x0002B710 File Offset: 0x00029910
		[Token(Token = "0x600676B")]
		[Address(RVA = "0x39F5F0", Offset = "0x39F6F1", VA = "0x39F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BE51 RID: 114257
		[Token(Token = "0x40187CB")]
		[FieldOffset(Offset = "0x0")]
		public IrCameraConfig irCameraConfig;

		// Token: 0x0401BE52 RID: 114258
		[Token(Token = "0x40187CC")]
		[FieldOffset(Offset = "0x18")]
		public Rect windowOfInterest;

		// Token: 0x0401BE53 RID: 114259
		[Token(Token = "0x40187CD")]
		[FieldOffset(Offset = "0x20")]
		public MomentProcessorPreprocess preprocess;

		// Token: 0x0401BE54 RID: 114260
		[Token(Token = "0x40187CE")]
		[FieldOffset(Offset = "0x24")]
		public int preprocessIntensityThreshold;
	}
}
