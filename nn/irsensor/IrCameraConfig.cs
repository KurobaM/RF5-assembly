using System;
using Il2CppDummyDll;

namespace nn.irsensor
{
	// Token: 0x02001531 RID: 5425
	[Token(Token = "0x2000EE4")]
	public struct IrCameraConfig : IEquatable<IrCameraConfig>
	{
		// Token: 0x06007B3C RID: 31548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675A")]
		[Address(RVA = "0x39F310", Offset = "0x39F411", VA = "0x39F310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x0002B620 File Offset: 0x00029820
		[Token(Token = "0x600675B")]
		[Address(RVA = "0x34DCDD0", Offset = "0x34DCED1", VA = "0x34DCDD0")]
		public static bool operator ==(IrCameraConfig lhs, IrCameraConfig rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x0002B638 File Offset: 0x00029838
		[Token(Token = "0x600675C")]
		[Address(RVA = "0x34DCE40", Offset = "0x34DCF41", VA = "0x34DCE40")]
		public static bool operator !=(IrCameraConfig lhs, IrCameraConfig rhs)
		{
			return default(bool);
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x0002B650 File Offset: 0x00029850
		[Token(Token = "0x600675D")]
		[Address(RVA = "0x39F320", Offset = "0x39F421", VA = "0x39F320", Slot = "0")]
		public override bool Equals(object right)
		{
			return default(bool);
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x0002B668 File Offset: 0x00029868
		[Token(Token = "0x600675E")]
		[Address(RVA = "0x39F410", Offset = "0x39F511", VA = "0x39F410", Slot = "4")]
		public bool Equals(IrCameraConfig other)
		{
			return default(bool);
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x0002B680 File Offset: 0x00029880
		[Token(Token = "0x600675F")]
		[Address(RVA = "0x39F470", Offset = "0x39F571", VA = "0x39F470", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0401BE46 RID: 114246
		[Token(Token = "0x40187C0")]
		[FieldOffset(Offset = "0x0")]
		public long exposureTimeNanoSeconds;

		// Token: 0x0401BE47 RID: 114247
		[Token(Token = "0x40187C1")]
		[FieldOffset(Offset = "0x8")]
		public IrCameraLightTarget lightTarget;

		// Token: 0x0401BE48 RID: 114248
		[Token(Token = "0x40187C2")]
		[FieldOffset(Offset = "0xC")]
		public int gain;

		// Token: 0x0401BE49 RID: 114249
		[Token(Token = "0x40187C3")]
		[FieldOffset(Offset = "0x10")]
		public bool isNegativeImageUsed;
	}
}
