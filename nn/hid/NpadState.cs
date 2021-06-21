using System;
using Il2CppDummyDll;

namespace nn.hid
{
	// Token: 0x02001555 RID: 5461
	[Token(Token = "0x2000F02")]
	public struct NpadState
	{
		// Token: 0x06007BD8 RID: 31704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B4")]
		[Address(RVA = "0x382FD0", Offset = "0x3830D1", VA = "0x382FD0")]
		public void Clear()
		{
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x0002BD28 File Offset: 0x00029F28
		[Token(Token = "0x60067B5")]
		[Address(RVA = "0x383010", Offset = "0x383111", VA = "0x383010")]
		public bool GetButton(NpadButton button)
		{
			return default(bool);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x0002BD40 File Offset: 0x00029F40
		[Token(Token = "0x60067B6")]
		[Address(RVA = "0x383020", Offset = "0x383121", VA = "0x383020")]
		public bool GetButtonDown(NpadButton button)
		{
			return default(bool);
		}

		// Token: 0x06007BDB RID: 31707 RVA: 0x0002BD58 File Offset: 0x00029F58
		[Token(Token = "0x60067B7")]
		[Address(RVA = "0x383050", Offset = "0x383151", VA = "0x383050")]
		public bool GetButtonUp(NpadButton button)
		{
			return default(bool);
		}

		// Token: 0x06007BDC RID: 31708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067B8")]
		[Address(RVA = "0x383080", Offset = "0x383181", VA = "0x383080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401BF3B RID: 114491
		[Token(Token = "0x401886D")]
		[FieldOffset(Offset = "0x0")]
		public long samplingNumber;

		// Token: 0x0401BF3C RID: 114492
		[Token(Token = "0x401886E")]
		[FieldOffset(Offset = "0x8")]
		public NpadButton buttons;

		// Token: 0x0401BF3D RID: 114493
		[Token(Token = "0x401886F")]
		[FieldOffset(Offset = "0x10")]
		public AnalogStickState analogStickL;

		// Token: 0x0401BF3E RID: 114494
		[Token(Token = "0x4018870")]
		[FieldOffset(Offset = "0x18")]
		public AnalogStickState analogStickR;

		// Token: 0x0401BF3F RID: 114495
		[Token(Token = "0x4018871")]
		[FieldOffset(Offset = "0x20")]
		public NpadAttribute attributes;

		// Token: 0x0401BF40 RID: 114496
		[Token(Token = "0x4018872")]
		[FieldOffset(Offset = "0x28")]
		public NpadButton preButtons;
	}
}
