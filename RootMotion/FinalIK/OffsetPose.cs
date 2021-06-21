using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D98 RID: 3480
	[Token(Token = "0x20008E4")]
	public class OffsetPose : MonoBehaviour
	{
		// Token: 0x06005A28 RID: 23080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7C")]
		[Address(RVA = "0x27C67D0", Offset = "0x27C68D1", VA = "0x27C67D0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7D")]
		[Address(RVA = "0x27C6BE0", Offset = "0x27C6CE1", VA = "0x27C6BE0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A7E")]
		[Address(RVA = "0x27C6CA0", Offset = "0x27C6DA1", VA = "0x27C6CA0")]
		public OffsetPose()
		{
		}

		// Token: 0x0400B961 RID: 47457
		[Token(Token = "0x4008A8F")]
		[FieldOffset(Offset = "0x18")]
		public OffsetPose.EffectorLink[] effectorLinks;

		// Token: 0x02000D99 RID: 3481
		[Token(Token = "0x2001424")]
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x06005A2B RID: 23083 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A67")]
			[Address(RVA = "0x27C68A0", Offset = "0x27C69A1", VA = "0x27C68A0")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			// Token: 0x06005A2C RID: 23084 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A68")]
			[Address(RVA = "0x27C6D10", Offset = "0x27C6E11", VA = "0x27C6D10")]
			public EffectorLink()
			{
			}

			// Token: 0x0400B962 RID: 47458
			[Token(Token = "0x401BAF0")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			// Token: 0x0400B963 RID: 47459
			[Token(Token = "0x401BAF1")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			// Token: 0x0400B964 RID: 47460
			[Token(Token = "0x401BAF2")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			// Token: 0x0400B965 RID: 47461
			[Token(Token = "0x401BAF3")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;
		}
	}
}
