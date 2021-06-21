using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D3A RID: 3386
	[Token(Token = "0x20008BA")]
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		// Token: 0x06005701 RID: 22273 RVA: 0x0001C980 File Offset: 0x0001AB80
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x256DF30", Offset = "0x256E031", VA = "0x256DF30")]
		public float GetAngle()
		{
			return 0f;
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06005702 RID: 22274 RVA: 0x0001C998 File Offset: 0x0001AB98
		[Token(Token = "0x170008BB")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600486D")]
			[Address(RVA = "0x256E030", Offset = "0x256E131", VA = "0x256E030")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06005703 RID: 22275 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		[Token(Token = "0x170008BC")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600486E")]
			[Address(RVA = "0x256E100", Offset = "0x256E201", VA = "0x256E100")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x256E1D0", Offset = "0x256E2D1", VA = "0x256E1D0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004870")]
		[Address(RVA = "0x256E450", Offset = "0x256E551", VA = "0x256E450", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06005706 RID: 22278 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[Token(Token = "0x170008BD")]
		protected override int minBones
		{
			[Token(Token = "0x6004871")]
			[Address(RVA = "0x256EEA0", Offset = "0x256EFA1", VA = "0x256EEA0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004872")]
		[Address(RVA = "0x256EDE0", Offset = "0x256EEE1", VA = "0x256EDE0")]
		private void Solve()
		{
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		[Token(Token = "0x6004873")]
		[Address(RVA = "0x256EA00", Offset = "0x256EB01", VA = "0x256EA00")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004874")]
		[Address(RVA = "0x256EEB0", Offset = "0x256EFB1", VA = "0x256EEB0")]
		private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight)
		{
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600570A RID: 22282 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		[Token(Token = "0x170008BE")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6004875")]
			[Address(RVA = "0x256F450", Offset = "0x256F551", VA = "0x256F450", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004876")]
		[Address(RVA = "0x256F4D0", Offset = "0x256F5D1", VA = "0x256F4D0")]
		public IKSolverAim()
		{
		}

		// Token: 0x0400B66A RID: 46698
		[Token(Token = "0x4008911")]
		[FieldOffset(Offset = "0x88")]
		public Transform transform;

		// Token: 0x0400B66B RID: 46699
		[Token(Token = "0x4008912")]
		[FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		// Token: 0x0400B66C RID: 46700
		[Token(Token = "0x4008913")]
		[FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		// Token: 0x0400B66D RID: 46701
		[Token(Token = "0x4008914")]
		[FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		// Token: 0x0400B66E RID: 46702
		[Token(Token = "0x4008915")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AA40", Offset = "0x17AB41")]
		public float poleWeight;

		// Token: 0x0400B66F RID: 46703
		[Token(Token = "0x4008916")]
		[FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		// Token: 0x0400B670 RID: 46704
		[Token(Token = "0x4008917")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AA60", Offset = "0x17AB61")]
		public float clampWeight;

		// Token: 0x0400B671 RID: 46705
		[Token(Token = "0x4008918")]
		[FieldOffset(Offset = "0xC4")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AA80", Offset = "0x17AB81")]
		public int clampSmoothing;

		// Token: 0x0400B672 RID: 46706
		[Token(Token = "0x4008919")]
		[FieldOffset(Offset = "0xC8")]
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x0400B673 RID: 46707
		[Token(Token = "0x400891A")]
		[FieldOffset(Offset = "0xD0")]
		private float step;

		// Token: 0x0400B674 RID: 46708
		[Token(Token = "0x400891B")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		// Token: 0x0400B675 RID: 46709
		[Token(Token = "0x400891C")]
		[FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		// Token: 0x0400B676 RID: 46710
		[Token(Token = "0x400891D")]
		[FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;
	}
}
