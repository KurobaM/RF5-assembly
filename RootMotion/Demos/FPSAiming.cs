using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC0 RID: 3264
	[Token(Token = "0x2000861")]
	public class FPSAiming : MonoBehaviour
	{
		// Token: 0x060053DB RID: 21467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045ED")]
		[Address(RVA = "0x29B4270", Offset = "0x29B4371", VA = "0x29B4270")]
		private void Start()
		{
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EE")]
		[Address(RVA = "0x29B43D0", Offset = "0x29B44D1", VA = "0x29B43D0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045EF")]
		[Address(RVA = "0x29B43E0", Offset = "0x29B44E1", VA = "0x29B43E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F0")]
		[Address(RVA = "0x29B4730", Offset = "0x29B4831", VA = "0x29B4730")]
		private void Aiming()
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F1")]
		[Address(RVA = "0x29B49A0", Offset = "0x29B4AA1", VA = "0x29B49A0")]
		private void LookDownTheSight()
		{
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F2")]
		[Address(RVA = "0x29B44B0", Offset = "0x29B45B1", VA = "0x29B44B0")]
		private void RotateCharacter()
		{
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045F3")]
		[Address(RVA = "0x29B53D0", Offset = "0x29B54D1", VA = "0x29B53D0")]
		public FPSAiming()
		{
		}

		// Token: 0x0400B2D7 RID: 45783
		[Token(Token = "0x400864B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177BA0", Offset = "0x177CA1")]
		public float aimWeight;

		// Token: 0x0400B2D8 RID: 45784
		[Token(Token = "0x400864C")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177BC0", Offset = "0x177CC1")]
		public float sightWeight;

		// Token: 0x0400B2D9 RID: 45785
		[Token(Token = "0x400864D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177BE0", Offset = "0x177CE1")]
		public float maxAngle;

		// Token: 0x0400B2DA RID: 45786
		[Token(Token = "0x400864E")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		// Token: 0x0400B2DB RID: 45787
		[Token(Token = "0x400864F")]
		[FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		// Token: 0x0400B2DC RID: 45788
		[Token(Token = "0x4008650")]
		[FieldOffset(Offset = "0x38")]
		public Transform gun;

		// Token: 0x0400B2DD RID: 45789
		[Token(Token = "0x4008651")]
		[FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		// Token: 0x0400B2DE RID: 45790
		[Token(Token = "0x4008652")]
		[FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B2DF RID: 45791
		[Token(Token = "0x4008653")]
		[FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		// Token: 0x0400B2E0 RID: 45792
		[Token(Token = "0x4008654")]
		[FieldOffset(Offset = "0x58")]
		public CameraControllerFPS cam;

		// Token: 0x0400B2E1 RID: 45793
		[Token(Token = "0x4008655")]
		[FieldOffset(Offset = "0x60")]
		public Recoil recoil;

		// Token: 0x0400B2E2 RID: 45794
		[Token(Token = "0x4008656")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177C00", Offset = "0x177D01")]
		public float cameraRecoilWeight;

		// Token: 0x0400B2E3 RID: 45795
		[Token(Token = "0x4008657")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 gunTargetDefaultLocalPosition;

		// Token: 0x0400B2E4 RID: 45796
		[Token(Token = "0x4008658")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 gunTargetDefaultLocalRotation;

		// Token: 0x0400B2E5 RID: 45797
		[Token(Token = "0x4008659")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 camDefaultLocalPosition;

		// Token: 0x0400B2E6 RID: 45798
		[Token(Token = "0x400865A")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 camRelativeToGunTarget;

		// Token: 0x0400B2E7 RID: 45799
		[Token(Token = "0x400865B")]
		[FieldOffset(Offset = "0x9C")]
		private bool updateFrame;
	}
}
