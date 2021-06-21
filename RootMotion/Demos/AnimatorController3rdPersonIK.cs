using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CB6 RID: 3254
	[Token(Token = "0x2000858")]
	[Attribute(Name = "RequireComponent", RVA = "0x1478A0", Offset = "0x1479A1")]
	[Attribute(Name = "RequireComponent", RVA = "0x1478A0", Offset = "0x1479A1")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		// Token: 0x060053B2 RID: 21426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x29AC060", Offset = "0x29AC161", VA = "0x29AC060", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x29AC250", Offset = "0x29AC351", VA = "0x29AC250", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x29AC330", Offset = "0x29AC431", VA = "0x29AC330")]
		private void Read()
		{
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x29AC490", Offset = "0x29AC591", VA = "0x29AC490")]
		private void AimIK()
		{
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x29AC4E0", Offset = "0x29AC5E1", VA = "0x29AC4E0")]
		private void FBBIK()
		{
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x29ACAF0", Offset = "0x29ACBF1", VA = "0x29ACAF0")]
		private void OnPreRead()
		{
		}

		// Token: 0x060053B8 RID: 21432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CC")]
		[Address(RVA = "0x29AC8B0", Offset = "0x29AC9B1", VA = "0x29AC8B0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CD")]
		[Address(RVA = "0x29ACE50", Offset = "0x29ACF51", VA = "0x29ACE50")]
		private void OnDestroy()
		{
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045CE")]
		[Address(RVA = "0x29ACF70", Offset = "0x29AD071", VA = "0x29ACF70")]
		public AnimatorController3rdPersonIK()
		{
		}

		// Token: 0x0400B29C RID: 45724
		[Token(Token = "0x4008613")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x1779A0", Offset = "0x177AA1")]
		public float headLookWeight;

		// Token: 0x0400B29D RID: 45725
		[Token(Token = "0x4008614")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		// Token: 0x0400B29E RID: 45726
		[Token(Token = "0x4008615")]
		[FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		// Token: 0x0400B29F RID: 45727
		[Token(Token = "0x4008616")]
		[FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		// Token: 0x0400B2A0 RID: 45728
		[Token(Token = "0x4008617")]
		[FieldOffset(Offset = "0x80")]
		private AimIK aim;

		// Token: 0x0400B2A1 RID: 45729
		[Token(Token = "0x4008618")]
		[FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		// Token: 0x0400B2A2 RID: 45730
		[Token(Token = "0x4008619")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		// Token: 0x0400B2A3 RID: 45731
		[Token(Token = "0x400861A")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		// Token: 0x0400B2A4 RID: 45732
		[Token(Token = "0x400861B")]
		[FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		// Token: 0x0400B2A5 RID: 45733
		[Token(Token = "0x400861C")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		// Token: 0x0400B2A6 RID: 45734
		[Token(Token = "0x400861D")]
		[FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;
	}
}
