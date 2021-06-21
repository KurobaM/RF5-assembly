using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.util;

namespace nn.hid
{
	// Token: 0x0200156B RID: 5483
	[Token(Token = "0x2000F18")]
	public struct SixAxisSensorState
	{
		// Token: 0x06007C0F RID: 31759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60067EB")]
		[Address(RVA = "0x3830A0", Offset = "0x3831A1", VA = "0x3830A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007C10 RID: 31760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067EC")]
		[Address(RVA = "0x3830B0", Offset = "0x3831B1", VA = "0x3830B0")]
		public void GetQuaternion(ref float x, ref float y, ref float z, ref float w)
		{
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067ED")]
		[Address(RVA = "0x3830C0", Offset = "0x3831C1", VA = "0x3830C0")]
		public void GetQuaternion(ref Float4 quaternion)
		{
		}

		// Token: 0x06007C12 RID: 31762
		[Token(Token = "0x60067EE")]
		[Address(RVA = "0x2D62EE0", Offset = "0x2D62FE1", VA = "0x2D62EE0")]
		[PreserveSig]
		private static extern void GetQuaternion(ref SixAxisSensorState state, ref float pOutX, ref float pOutY, ref float pOutZ, ref float pOutW);

		// Token: 0x0401BF78 RID: 114552
		[Token(Token = "0x40188AA")]
		public const float AccelerometerMax = 7f;

		// Token: 0x0401BF79 RID: 114553
		[Token(Token = "0x40188AB")]
		public const float AngularVelocityMax = 5f;

		// Token: 0x0401BF7A RID: 114554
		[Token(Token = "0x40188AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long deltaTimeNanoSeconds;

		// Token: 0x0401BF7B RID: 114555
		[Token(Token = "0x40188AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long samplingNumber;

		// Token: 0x0401BF7C RID: 114556
		[Token(Token = "0x40188AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Float3 acceleration;

		// Token: 0x0401BF7D RID: 114557
		[Token(Token = "0x40188AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Float3 angularVelocity;

		// Token: 0x0401BF7E RID: 114558
		[Token(Token = "0x40188B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Float3 angle;

		// Token: 0x0401BF7F RID: 114559
		[Token(Token = "0x40188B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DirectionState direction;

		// Token: 0x0401BF80 RID: 114560
		[Token(Token = "0x40188B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SixAxisSensorAttribute attributes;
	}
}
