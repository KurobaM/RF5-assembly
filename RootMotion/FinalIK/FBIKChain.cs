using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D29 RID: 3369
	[Token(Token = "0x20008B2")]
	[Serializable]
	public class FBIKChain
	{
		// Token: 0x0600565A RID: 22106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004802")]
		[Address(RVA = "0x2876CC0", Offset = "0x2876DC1", VA = "0x2876CC0")]
		public FBIKChain()
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004803")]
		[Address(RVA = "0x2876DC0", Offset = "0x2876EC1", VA = "0x2876DC0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004804")]
		[Address(RVA = "0x2876F20", Offset = "0x2877021", VA = "0x2876F20")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		// Token: 0x0600565D RID: 22109 RVA: 0x0001C650 File Offset: 0x0001A850
		[Token(Token = "0x6004805")]
		[Address(RVA = "0x2877060", Offset = "0x2877161", VA = "0x2877060")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return 0;
		}

		// Token: 0x0600565E RID: 22110 RVA: 0x0001C668 File Offset: 0x0001A868
		[Token(Token = "0x6004806")]
		[Address(RVA = "0x2877140", Offset = "0x2877241", VA = "0x2877140")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x0600565F RID: 22111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004807")]
		[Address(RVA = "0x2877250", Offset = "0x2877351", VA = "0x2877250")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005660 RID: 22112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004808")]
		[Address(RVA = "0x2877990", Offset = "0x2877A91", VA = "0x2877990")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		// Token: 0x06005661 RID: 22113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004809")]
		[Address(RVA = "0x28773F0", Offset = "0x28774F1", VA = "0x28773F0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600480A")]
		[Address(RVA = "0x2877ED0", Offset = "0x2877FD1", VA = "0x2877ED0")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x0001C680 File Offset: 0x0001A880
		[Token(Token = "0x600480B")]
		[Address(RVA = "0x2878280", Offset = "0x2878381", VA = "0x2878280")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600480C")]
		[Address(RVA = "0x2878670", Offset = "0x2878771", VA = "0x2878670")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600480D")]
		[Address(RVA = "0x2878C20", Offset = "0x2878D21", VA = "0x2878C20")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600480E")]
		[Address(RVA = "0x2879240", Offset = "0x2879341", VA = "0x2879240")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600480F")]
		[Address(RVA = "0x28794D0", Offset = "0x28795D1", VA = "0x28794D0")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x0001C698 File Offset: 0x0001A898
		[Token(Token = "0x6004810")]
		[Address(RVA = "0x2879130", Offset = "0x2879231", VA = "0x2879130")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
		[Token(Token = "0x6004811")]
		[Address(RVA = "0x28789F0", Offset = "0x2878AF1", VA = "0x28789F0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004812")]
		[Address(RVA = "0x28790B0", Offset = "0x28791B1", VA = "0x28790B0")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004813")]
		[Address(RVA = "0x2879620", Offset = "0x2879721", VA = "0x2879620")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004814")]
		[Address(RVA = "0x2878FD0", Offset = "0x28790D1", VA = "0x2878FD0")]
		public void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004815")]
		[Address(RVA = "0x28793C0", Offset = "0x28794C1", VA = "0x28793C0")]
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x0400B5C4 RID: 46532
		[Token(Token = "0x40088A3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A7A0", Offset = "0x17A8A1")]
		public float pin;

		// Token: 0x0400B5C5 RID: 46533
		[Token(Token = "0x40088A4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A7C0", Offset = "0x17A8C1")]
		public float pull;

		// Token: 0x0400B5C6 RID: 46534
		[Token(Token = "0x40088A5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A7E0", Offset = "0x17A8E1")]
		public float push;

		// Token: 0x0400B5C7 RID: 46535
		[Token(Token = "0x40088A6")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A800", Offset = "0x17A901")]
		public float pushParent;

		// Token: 0x0400B5C8 RID: 46536
		[Token(Token = "0x40088A7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A820", Offset = "0x17A921")]
		public float reach;

		// Token: 0x0400B5C9 RID: 46537
		[Token(Token = "0x40088A8")]
		[FieldOffset(Offset = "0x24")]
		public FBIKChain.Smoothing reachSmoothing;

		// Token: 0x0400B5CA RID: 46538
		[Token(Token = "0x40088A9")]
		[FieldOffset(Offset = "0x28")]
		public FBIKChain.Smoothing pushSmoothing;

		// Token: 0x0400B5CB RID: 46539
		[Token(Token = "0x40088AA")]
		[FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		// Token: 0x0400B5CC RID: 46540
		[Token(Token = "0x40088AB")]
		[FieldOffset(Offset = "0x38")]
		public int[] children;

		// Token: 0x0400B5CD RID: 46541
		[Token(Token = "0x40088AC")]
		[FieldOffset(Offset = "0x40")]
		public FBIKChain.ChildConstraint[] childConstraints;

		// Token: 0x0400B5CE RID: 46542
		[Token(Token = "0x40088AD")]
		[FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		// Token: 0x0400B5CF RID: 46543
		[Token(Token = "0x40088AE")]
		[FieldOffset(Offset = "0x50")]
		private float rootLength;

		// Token: 0x0400B5D0 RID: 46544
		[Token(Token = "0x40088AF")]
		[FieldOffset(Offset = "0x54")]
		private bool initiated;

		// Token: 0x0400B5D1 RID: 46545
		[Token(Token = "0x40088B0")]
		[FieldOffset(Offset = "0x58")]
		private float length;

		// Token: 0x0400B5D2 RID: 46546
		[Token(Token = "0x40088B1")]
		[FieldOffset(Offset = "0x5C")]
		private float distance;

		// Token: 0x0400B5D3 RID: 46547
		[Token(Token = "0x40088B2")]
		[FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		// Token: 0x0400B5D4 RID: 46548
		[Token(Token = "0x40088B3")]
		[FieldOffset(Offset = "0x68")]
		private float reachForce;

		// Token: 0x0400B5D5 RID: 46549
		[Token(Token = "0x40088B4")]
		[FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		// Token: 0x0400B5D6 RID: 46550
		[Token(Token = "0x40088B5")]
		[FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		// Token: 0x0400B5D7 RID: 46551
		[Token(Token = "0x40088B6")]
		[FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		// Token: 0x0400B5D8 RID: 46552
		[Token(Token = "0x40088B7")]
		[FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		// Token: 0x0400B5D9 RID: 46553
		[Token(Token = "0x40088B8")]
		[FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		// Token: 0x0400B5DA RID: 46554
		[Token(Token = "0x40088B9")]
		private const float maxLimbLength = 0.99999f;

		// Token: 0x02000D2A RID: 3370
		[Token(Token = "0x20013F0")]
		[Serializable]
		public class ChildConstraint
		{
			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x0600566E RID: 22126 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
			// (set) Token: 0x0600566F RID: 22127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E0F")]
			public float nominalDistance
			{
				[Token(Token = "0x6007922")]
				[Address(RVA = "0x2C00A00", Offset = "0x2C00B01", VA = "0x2C00A00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C50", Offset = "0x1B4D51")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6007923")]
				[Address(RVA = "0x2C00A10", Offset = "0x2C00B11", VA = "0x2C00A10")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C60", Offset = "0x1B4D61")]
				private set
				{
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06005670 RID: 22128 RVA: 0x0001C6E0 File Offset: 0x0001A8E0
			// (set) Token: 0x06005671 RID: 22129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000E10")]
			public bool isRigid
			{
				[Token(Token = "0x6007924")]
				[Address(RVA = "0x2C00A20", Offset = "0x2C00B21", VA = "0x2C00A20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C70", Offset = "0x1B4D71")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007925")]
				[Address(RVA = "0x2C00A30", Offset = "0x2C00B31", VA = "0x2C00A30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4C80", Offset = "0x1B4D81")]
				private set
				{
				}
			}

			// Token: 0x06005672 RID: 22130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007926")]
			[Address(RVA = "0x2C00A40", Offset = "0x2C00B41", VA = "0x2C00A40")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			// Token: 0x06005673 RID: 22131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007927")]
			[Address(RVA = "0x2C00AB0", Offset = "0x2C00BB1", VA = "0x2C00AB0")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			// Token: 0x06005674 RID: 22132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007928")]
			[Address(RVA = "0x2C00B10", Offset = "0x2C00C11", VA = "0x2C00B10")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			// Token: 0x06005675 RID: 22133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007929")]
			[Address(RVA = "0x2C00D20", Offset = "0x2C00E21", VA = "0x2C00D20")]
			public void Solve(IKSolverFullBody solver)
			{
			}

			// Token: 0x0400B5DB RID: 46555
			[Token(Token = "0x401B965")]
			[FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			// Token: 0x0400B5DC RID: 46556
			[Token(Token = "0x401B966")]
			[FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			// Token: 0x0400B5DD RID: 46557
			[Token(Token = "0x401B967")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			// Token: 0x0400B5DE RID: 46558
			[Token(Token = "0x401B968")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			// Token: 0x0400B5DF RID: 46559
			[Token(Token = "0x401B969")]
			[FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x196010", Offset = "0x196111")]
			private float <nominalDistance>k__BackingField;

			// Token: 0x0400B5E0 RID: 46560
			[Token(Token = "0x401B96A")]
			[FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x196020", Offset = "0x196121")]
			private bool <isRigid>k__BackingField;

			// Token: 0x0400B5E1 RID: 46561
			[Token(Token = "0x401B96B")]
			[FieldOffset(Offset = "0x30")]
			private float crossFade;

			// Token: 0x0400B5E2 RID: 46562
			[Token(Token = "0x401B96C")]
			[FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			// Token: 0x0400B5E3 RID: 46563
			[Token(Token = "0x401B96D")]
			[FieldOffset(Offset = "0x38")]
			private int chain1Index;

			// Token: 0x0400B5E4 RID: 46564
			[Token(Token = "0x401B96E")]
			[FieldOffset(Offset = "0x3C")]
			private int chain2Index;
		}

		// Token: 0x02000D2B RID: 3371
		[Token(Token = "0x20013F1")]
		[Serializable]
		public enum Smoothing
		{
			// Token: 0x0400B5E6 RID: 46566
			[Token(Token = "0x401B970")]
			None,
			// Token: 0x0400B5E7 RID: 46567
			[Token(Token = "0x401B971")]
			Exponential,
			// Token: 0x0400B5E8 RID: 46568
			[Token(Token = "0x401B972")]
			Cubic
		}
	}
}
