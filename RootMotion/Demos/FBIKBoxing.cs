using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CBE RID: 3262
	[Token(Token = "0x200085F")]
	public class FBIKBoxing : MonoBehaviour
	{
		// Token: 0x060053D3 RID: 21459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x29B38B0", Offset = "0x29B39B1", VA = "0x29B38B0")]
		private void Start()
		{
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E6")]
		[Address(RVA = "0x29B3910", Offset = "0x29B3A11", VA = "0x29B3910")]
		private void LateUpdate()
		{
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E7")]
		[Address(RVA = "0x29B3AB0", Offset = "0x29B3BB1", VA = "0x29B3AB0")]
		public FBIKBoxing()
		{
		}

		// Token: 0x0400B2CD RID: 45773
		[Token(Token = "0x4008641")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1779E0", Offset = "0x177AE1")]
		public Transform target;

		// Token: 0x0400B2CE RID: 45774
		[Token(Token = "0x4008642")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177A20", Offset = "0x177B21")]
		public Transform pin;

		// Token: 0x0400B2CF RID: 45775
		[Token(Token = "0x4008643")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177A60", Offset = "0x177B61")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B2D0 RID: 45776
		[Token(Token = "0x4008644")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177AA0", Offset = "0x177BA1")]
		public AimIK aim;

		// Token: 0x0400B2D1 RID: 45777
		[Token(Token = "0x4008645")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177AE0", Offset = "0x177BE1")]
		public float weight;

		// Token: 0x0400B2D2 RID: 45778
		[Token(Token = "0x4008646")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177B20", Offset = "0x177C21")]
		public FullBodyBipedEffector effector;

		// Token: 0x0400B2D3 RID: 45779
		[Token(Token = "0x4008647")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177B60", Offset = "0x177C61")]
		public AnimationCurve aimWeight;

		// Token: 0x0400B2D4 RID: 45780
		[Token(Token = "0x4008648")]
		[FieldOffset(Offset = "0x48")]
		private Animator animator;
	}
}
