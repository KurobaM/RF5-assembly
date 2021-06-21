using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CB9 RID: 3257
	[Token(Token = "0x200085B")]
	public class EffectorOffset : OffsetModifier
	{
		// Token: 0x060053C4 RID: 21444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D8")]
		[Address(RVA = "0x29B2810", Offset = "0x29B2911", VA = "0x29B2810", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045D9")]
		[Address(RVA = "0x29B2E00", Offset = "0x29B2F01", VA = "0x29B2E00")]
		public EffectorOffset()
		{
		}

		// Token: 0x0400B2AA RID: 45738
		[Token(Token = "0x4008621")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1779C0", Offset = "0x177AC1")]
		public float handsMaintainRelativePositionWeight;

		// Token: 0x0400B2AB RID: 45739
		[Token(Token = "0x4008622")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		// Token: 0x0400B2AC RID: 45740
		[Token(Token = "0x4008623")]
		[FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		// Token: 0x0400B2AD RID: 45741
		[Token(Token = "0x4008624")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		// Token: 0x0400B2AE RID: 45742
		[Token(Token = "0x4008625")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		// Token: 0x0400B2AF RID: 45743
		[Token(Token = "0x4008626")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		// Token: 0x0400B2B0 RID: 45744
		[Token(Token = "0x4008627")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		// Token: 0x0400B2B1 RID: 45745
		[Token(Token = "0x4008628")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		// Token: 0x0400B2B2 RID: 45746
		[Token(Token = "0x4008629")]
		[FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		// Token: 0x0400B2B3 RID: 45747
		[Token(Token = "0x400862A")]
		[FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;
	}
}
