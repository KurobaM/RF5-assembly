using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CAC RID: 3244
	[Token(Token = "0x2000851")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		// Token: 0x0600538C RID: 21388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x29AD130", Offset = "0x29AD231", VA = "0x29AD130")]
		private void OnAnimatorIK(int layer)
		{
		}

		// Token: 0x0600538D RID: 21389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x29AD5E0", Offset = "0x29AD6E1", VA = "0x29AD5E0")]
		public BipedIKvsAnimatorIK()
		{
		}

		// Token: 0x0400B241 RID: 45633
		[Token(Token = "0x40085C6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "LargeHeader", RVA = "0x177670", Offset = "0x177771")]
		public Animator animator;

		// Token: 0x0400B242 RID: 45634
		[Token(Token = "0x40085C7")]
		[FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		// Token: 0x0400B243 RID: 45635
		[Token(Token = "0x40085C8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "LargeHeader", RVA = "0x1776B0", Offset = "0x1777B1")]
		public Transform lookAtTargetBiped;

		// Token: 0x0400B244 RID: 45636
		[Token(Token = "0x40085C9")]
		[FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		// Token: 0x0400B245 RID: 45637
		[Token(Token = "0x40085CA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1776F0", Offset = "0x1777F1")]
		public float lookAtWeight;

		// Token: 0x0400B246 RID: 45638
		[Token(Token = "0x40085CB")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177710", Offset = "0x177811")]
		public float lookAtBodyWeight;

		// Token: 0x0400B247 RID: 45639
		[Token(Token = "0x40085CC")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177730", Offset = "0x177831")]
		public float lookAtHeadWeight;

		// Token: 0x0400B248 RID: 45640
		[Token(Token = "0x40085CD")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177750", Offset = "0x177851")]
		public float lookAtEyesWeight;

		// Token: 0x0400B249 RID: 45641
		[Token(Token = "0x40085CE")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177770", Offset = "0x177871")]
		public float lookAtClampWeight;

		// Token: 0x0400B24A RID: 45642
		[Token(Token = "0x40085CF")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177790", Offset = "0x177891")]
		public float lookAtClampWeightHead;

		// Token: 0x0400B24B RID: 45643
		[Token(Token = "0x40085D0")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1777B0", Offset = "0x1778B1")]
		public float lookAtClampWeightEyes;

		// Token: 0x0400B24C RID: 45644
		[Token(Token = "0x40085D1")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "LargeHeader", RVA = "0x1777D0", Offset = "0x1778D1")]
		public Transform footTargetBiped;

		// Token: 0x0400B24D RID: 45645
		[Token(Token = "0x40085D2")]
		[FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		// Token: 0x0400B24E RID: 45646
		[Token(Token = "0x40085D3")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177810", Offset = "0x177911")]
		public float footPositionWeight;

		// Token: 0x0400B24F RID: 45647
		[Token(Token = "0x40085D4")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177830", Offset = "0x177931")]
		public float footRotationWeight;

		// Token: 0x0400B250 RID: 45648
		[Token(Token = "0x40085D5")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "LargeHeader", RVA = "0x177850", Offset = "0x177951")]
		public Transform handTargetBiped;

		// Token: 0x0400B251 RID: 45649
		[Token(Token = "0x40085D6")]
		[FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		// Token: 0x0400B252 RID: 45650
		[Token(Token = "0x40085D7")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177890", Offset = "0x177991")]
		public float handPositionWeight;

		// Token: 0x0400B253 RID: 45651
		[Token(Token = "0x40085D8")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1778B0", Offset = "0x1779B1")]
		public float handRotationWeight;
	}
}
