using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CAA RID: 3242
	[Token(Token = "0x200084F")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		// Token: 0x06005383 RID: 21379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459D")]
		[Address(RVA = "0x2861D90", Offset = "0x2861E91", VA = "0x2861D90")]
		private void Start()
		{
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459E")]
		[Address(RVA = "0x2861DE0", Offset = "0x2861EE1", VA = "0x2861DE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005385 RID: 21381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600459F")]
		[Address(RVA = "0x2861F30", Offset = "0x2862031", VA = "0x2861F30")]
		private void Pose()
		{
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A0")]
		[Address(RVA = "0x2862190", Offset = "0x2862291", VA = "0x2862190")]
		private void LimitAimTarget()
		{
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A1")]
		[Address(RVA = "0x28624E0", Offset = "0x28625E1", VA = "0x28624E0")]
		private void DirectCrossFade(string state, float target)
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x28625C0", Offset = "0x28626C1", VA = "0x28625C0")]
		public SimpleAimingSystem()
		{
		}

		// Token: 0x0400B231 RID: 45617
		[Token(Token = "0x40085B6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1774F0", Offset = "0x1775F1")]
		public AimPoser aimPoser;

		// Token: 0x0400B232 RID: 45618
		[Token(Token = "0x40085B7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177530", Offset = "0x177631")]
		public AimIK aim;

		// Token: 0x0400B233 RID: 45619
		[Token(Token = "0x40085B8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177570", Offset = "0x177671")]
		public LookAtIK lookAt;

		// Token: 0x0400B234 RID: 45620
		[Token(Token = "0x40085B9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1775B0", Offset = "0x1776B1")]
		public Animator animator;

		// Token: 0x0400B235 RID: 45621
		[Token(Token = "0x40085BA")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1775F0", Offset = "0x1776F1")]
		public float crossfadeTime;

		// Token: 0x0400B236 RID: 45622
		[Token(Token = "0x40085BB")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177630", Offset = "0x177731")]
		public float minAimDistance;

		// Token: 0x0400B237 RID: 45623
		[Token(Token = "0x40085BC")]
		[FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		// Token: 0x0400B238 RID: 45624
		[Token(Token = "0x40085BD")]
		[FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;
	}
}
