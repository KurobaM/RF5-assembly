using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D44 RID: 3396
	[Token(Token = "0x20008C4")]
	[Serializable]
	public class IKSolverLeg : IKSolver
	{
		// Token: 0x06005792 RID: 22418 RVA: 0x0001CC98 File Offset: 0x0001AE98
		[Token(Token = "0x60048FD")]
		[Address(RVA = "0x257BAF0", Offset = "0x257BBF1", VA = "0x257BAF0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06005793 RID: 22419 RVA: 0x0001CCB0 File Offset: 0x0001AEB0
		[Token(Token = "0x60048FE")]
		[Address(RVA = "0x257BEB0", Offset = "0x257BFB1", VA = "0x257BEB0")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		// Token: 0x06005794 RID: 22420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048FF")]
		[Address(RVA = "0x257BF70", Offset = "0x257C071", VA = "0x257BF70", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06005795 RID: 22421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004900")]
		[Address(RVA = "0x257C110", Offset = "0x257C211", VA = "0x257C110", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06005796 RID: 22422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004901")]
		[Address(RVA = "0x257C2B0", Offset = "0x257C3B1", VA = "0x257C2B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06005797 RID: 22423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004902")]
		[Address(RVA = "0x257C3B0", Offset = "0x257C4B1", VA = "0x257C3B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06005798 RID: 22424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004903")]
		[Address(RVA = "0x257C410", Offset = "0x257C511", VA = "0x257C410", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06005799 RID: 22425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004904")]
		[Address(RVA = "0x257C7A0", Offset = "0x257C8A1", VA = "0x257C7A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004905")]
		[Address(RVA = "0x257C7D0", Offset = "0x257C8D1", VA = "0x257C7D0")]
		private void Solve()
		{
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004906")]
		[Address(RVA = "0x257C480", Offset = "0x257C581", VA = "0x257C480")]
		private void Read()
		{
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004907")]
		[Address(RVA = "0x257C8E0", Offset = "0x257C9E1", VA = "0x257C8E0")]
		private void Write()
		{
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004908")]
		[Address(RVA = "0x257CA70", Offset = "0x257CB71", VA = "0x257CA70")]
		public IKSolverLeg()
		{
		}

		// Token: 0x0400B6B8 RID: 46776
		[Token(Token = "0x400895F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AB70", Offset = "0x17AC71")]
		public float IKRotationWeight;

		// Token: 0x0400B6B9 RID: 46777
		[Token(Token = "0x4008960")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		// Token: 0x0400B6BA RID: 46778
		[Token(Token = "0x4008961")]
		[FieldOffset(Offset = "0x70")]
		public IKSolver.Point pelvis;

		// Token: 0x0400B6BB RID: 46779
		[Token(Token = "0x4008962")]
		[FieldOffset(Offset = "0x78")]
		public IKSolver.Point thigh;

		// Token: 0x0400B6BC RID: 46780
		[Token(Token = "0x4008963")]
		[FieldOffset(Offset = "0x80")]
		public IKSolver.Point calf;

		// Token: 0x0400B6BD RID: 46781
		[Token(Token = "0x4008964")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.Point foot;

		// Token: 0x0400B6BE RID: 46782
		[Token(Token = "0x4008965")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.Point toe;

		// Token: 0x0400B6BF RID: 46783
		[Token(Token = "0x4008966")]
		[FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		// Token: 0x0400B6C0 RID: 46784
		[Token(Token = "0x4008967")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		// Token: 0x0400B6C1 RID: 46785
		[Token(Token = "0x4008968")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		// Token: 0x0400B6C2 RID: 46786
		[Token(Token = "0x4008969")]
		[FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;
	}
}
