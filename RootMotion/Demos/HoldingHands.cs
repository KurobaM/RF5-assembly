using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC3 RID: 3267
	[Token(Token = "0x2000864")]
	public class HoldingHands : MonoBehaviour
	{
		// Token: 0x060053E9 RID: 21481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FB")]
		[Address(RVA = "0x29B62B0", Offset = "0x29B63B1", VA = "0x29B62B0")]
		private void Start()
		{
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FC")]
		[Address(RVA = "0x29B6460", Offset = "0x29B6561", VA = "0x29B6460")]
		private void LateUpdate()
		{
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FD")]
		[Address(RVA = "0x29B6810", Offset = "0x29B6911", VA = "0x29B6810")]
		public HoldingHands()
		{
		}

		// Token: 0x0400B2EF RID: 45807
		[Token(Token = "0x4008663")]
		[FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		// Token: 0x0400B2F0 RID: 45808
		[Token(Token = "0x4008664")]
		[FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		// Token: 0x0400B2F1 RID: 45809
		[Token(Token = "0x4008665")]
		[FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		// Token: 0x0400B2F2 RID: 45810
		[Token(Token = "0x4008666")]
		[FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		// Token: 0x0400B2F3 RID: 45811
		[Token(Token = "0x4008667")]
		[FieldOffset(Offset = "0x38")]
		public float crossFade;

		// Token: 0x0400B2F4 RID: 45812
		[Token(Token = "0x4008668")]
		[FieldOffset(Offset = "0x3C")]
		public float speed;

		// Token: 0x0400B2F5 RID: 45813
		[Token(Token = "0x4008669")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		// Token: 0x0400B2F6 RID: 45814
		[Token(Token = "0x400866A")]
		[FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;
	}
}
