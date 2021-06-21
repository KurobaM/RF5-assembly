using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CBA RID: 3258
	[Token(Token = "0x200085C")]
	public class ExplosionDemo : MonoBehaviour
	{
		// Token: 0x060053C6 RID: 21446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DA")]
		[Address(RVA = "0x29B2E10", Offset = "0x29B2F11", VA = "0x29B2E10")]
		private void Start()
		{
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DB")]
		[Address(RVA = "0x29B2ED0", Offset = "0x29B2FD1", VA = "0x29B2ED0")]
		private void Update()
		{
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DC")]
		[Address(RVA = "0x29B3350", Offset = "0x29B3451", VA = "0x29B3350")]
		private void SetEffectorWeights(float w)
		{
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045DD")]
		[Address(RVA = "0x29B3400", Offset = "0x29B3501", VA = "0x29B3400")]
		public ExplosionDemo()
		{
		}

		// Token: 0x0400B2B4 RID: 45748
		[Token(Token = "0x400862B")]
		[FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		// Token: 0x0400B2B5 RID: 45749
		[Token(Token = "0x400862C")]
		[FieldOffset(Offset = "0x20")]
		public float forceMlp;

		// Token: 0x0400B2B6 RID: 45750
		[Token(Token = "0x400862D")]
		[FieldOffset(Offset = "0x24")]
		public float upForce;

		// Token: 0x0400B2B7 RID: 45751
		[Token(Token = "0x400862E")]
		[FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		// Token: 0x0400B2B8 RID: 45752
		[Token(Token = "0x400862F")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		// Token: 0x0400B2B9 RID: 45753
		[Token(Token = "0x4008630")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		// Token: 0x0400B2BA RID: 45754
		[Token(Token = "0x4008631")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		// Token: 0x0400B2BB RID: 45755
		[Token(Token = "0x4008632")]
		[FieldOffset(Offset = "0x48")]
		private float weight;

		// Token: 0x0400B2BC RID: 45756
		[Token(Token = "0x4008633")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		// Token: 0x0400B2BD RID: 45757
		[Token(Token = "0x4008634")]
		[FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		// Token: 0x0400B2BE RID: 45758
		[Token(Token = "0x4008635")]
		[FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;
	}
}
