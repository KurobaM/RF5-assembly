using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CC7 RID: 3271
	[Token(Token = "0x2000868")]
	public class KissingRig : MonoBehaviour
	{
		// Token: 0x060053F4 RID: 21492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004606")]
		[Address(RVA = "0x29B7550", Offset = "0x29B7651", VA = "0x29B7550")]
		private void Start()
		{
		}

		// Token: 0x060053F5 RID: 21493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004607")]
		[Address(RVA = "0x29B75D0", Offset = "0x29B76D1", VA = "0x29B75D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060053F6 RID: 21494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004608")]
		[Address(RVA = "0x29B7C80", Offset = "0x29B7D81", VA = "0x29B7C80")]
		public KissingRig()
		{
		}

		// Token: 0x0400B306 RID: 45830
		[Token(Token = "0x400867A")]
		[FieldOffset(Offset = "0x18")]
		public KissingRig.Partner partner1;

		// Token: 0x0400B307 RID: 45831
		[Token(Token = "0x400867B")]
		[FieldOffset(Offset = "0x20")]
		public KissingRig.Partner partner2;

		// Token: 0x0400B308 RID: 45832
		[Token(Token = "0x400867C")]
		[FieldOffset(Offset = "0x28")]
		public float weight;

		// Token: 0x0400B309 RID: 45833
		[Token(Token = "0x400867D")]
		[FieldOffset(Offset = "0x2C")]
		public int iterations;

		// Token: 0x02000CC8 RID: 3272
		[Token(Token = "0x20013D8")]
		[Serializable]
		public class Partner
		{
			// Token: 0x060053F7 RID: 21495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B8")]
			[Address(RVA = "0x29B75B0", Offset = "0x29B76B1", VA = "0x29B75B0")]
			public void Initiate()
			{
			}

			// Token: 0x060053F8 RID: 21496 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078B9")]
			[Address(RVA = "0x29B7630", Offset = "0x29B7731", VA = "0x29B7630")]
			public void Update(float weight)
			{
			}

			// Token: 0x17000AD3 RID: 2771
			// (get) Token: 0x060053F9 RID: 21497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DF6")]
			private Transform neck
			{
				[Token(Token = "0x60078BA")]
				[Address(RVA = "0x29B7E70", Offset = "0x29B7F71", VA = "0x29B7E70")]
				get
				{
					return null;
				}
			}

			// Token: 0x060053FA RID: 21498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BB")]
			[Address(RVA = "0x29B7C90", Offset = "0x29B7D91", VA = "0x29B7C90")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			// Token: 0x060053FB RID: 21499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078BC")]
			[Address(RVA = "0x29B7ED0", Offset = "0x29B7FD1", VA = "0x29B7ED0")]
			public Partner()
			{
			}

			// Token: 0x0400B30A RID: 45834
			[Token(Token = "0x401B8D0")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			// Token: 0x0400B30B RID: 45835
			[Token(Token = "0x401B8D1")]
			[FieldOffset(Offset = "0x18")]
			public Transform mouth;

			// Token: 0x0400B30C RID: 45836
			[Token(Token = "0x401B8D2")]
			[FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			// Token: 0x0400B30D RID: 45837
			[Token(Token = "0x401B8D3")]
			[FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			// Token: 0x0400B30E RID: 45838
			[Token(Token = "0x401B8D4")]
			[FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			// Token: 0x0400B30F RID: 45839
			[Token(Token = "0x401B8D5")]
			[FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			// Token: 0x0400B310 RID: 45840
			[Token(Token = "0x401B8D6")]
			[FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			// Token: 0x0400B311 RID: 45841
			[Token(Token = "0x401B8D7")]
			[FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			// Token: 0x0400B312 RID: 45842
			[Token(Token = "0x401B8D8")]
			[FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			// Token: 0x0400B313 RID: 45843
			[Token(Token = "0x401B8D9")]
			[FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			// Token: 0x0400B314 RID: 45844
			[Token(Token = "0x401B8DA")]
			[FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;
		}
	}
}
