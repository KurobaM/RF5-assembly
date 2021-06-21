using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D2D RID: 3373
	[Token(Token = "0x20008B4")]
	[Serializable]
	public class IKEffector
	{
		// Token: 0x06005682 RID: 22146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004822")]
		[Address(RVA = "0x2C133A0", Offset = "0x2C134A1", VA = "0x2C133A0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x0001C770 File Offset: 0x0001A970
		// (set) Token: 0x06005684 RID: 22148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B9")]
		public bool isEndEffector
		{
			[Token(Token = "0x6004823")]
			[Address(RVA = "0x2C13410", Offset = "0x2C13511", VA = "0x2C13410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AABA0", Offset = "0x1AACA1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004824")]
			[Address(RVA = "0x2C13420", Offset = "0x2C13521", VA = "0x2C13420")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AABB0", Offset = "0x1AACB1")]
			private set
			{
			}
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004825")]
		[Address(RVA = "0x2C13430", Offset = "0x2C13531", VA = "0x2C13430")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004826")]
		[Address(RVA = "0x2C13510", Offset = "0x2C13611", VA = "0x2C13510")]
		public IKEffector()
		{
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004827")]
		[Address(RVA = "0x2C13680", Offset = "0x2C13781", VA = "0x2C13680")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x0001C788 File Offset: 0x0001A988
		[Token(Token = "0x6004828")]
		[Address(RVA = "0x2C13830", Offset = "0x2C13931", VA = "0x2C13830")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004829")]
		[Address(RVA = "0x2C13B10", Offset = "0x2C13C11", VA = "0x2C13B10")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482A")]
		[Address(RVA = "0x2C13DF0", Offset = "0x2C13EF1", VA = "0x2C13DF0")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482B")]
		[Address(RVA = "0x2C13F30", Offset = "0x2C14031", VA = "0x2C13F30")]
		public void SetToTarget()
		{
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482C")]
		[Address(RVA = "0x2C13FE0", Offset = "0x2C140E1", VA = "0x2C13FE0")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482D")]
		[Address(RVA = "0x2C14640", Offset = "0x2C14741", VA = "0x2C14640")]
		public void OnPostWrite()
		{
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[Token(Token = "0x600482E")]
		[Address(RVA = "0x2C146B0", Offset = "0x2C147B1", VA = "0x2C146B0")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600482F")]
		[Address(RVA = "0x2C148D0", Offset = "0x2C149D1", VA = "0x2C148D0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		[Token(Token = "0x6004830")]
		[Address(RVA = "0x2C14C00", Offset = "0x2C14D01", VA = "0x2C14C00")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}

		// Token: 0x0400B5FB RID: 46587
		[Token(Token = "0x40088CC")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone;

		// Token: 0x0400B5FC RID: 46588
		[Token(Token = "0x40088CD")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		// Token: 0x0400B5FD RID: 46589
		[Token(Token = "0x40088CE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A870", Offset = "0x17A971")]
		public float positionWeight;

		// Token: 0x0400B5FE RID: 46590
		[Token(Token = "0x40088CF")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A890", Offset = "0x17A991")]
		public float rotationWeight;

		// Token: 0x0400B5FF RID: 46591
		[Token(Token = "0x40088D0")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		// Token: 0x0400B600 RID: 46592
		[Token(Token = "0x40088D1")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		// Token: 0x0400B601 RID: 46593
		[Token(Token = "0x40088D2")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		// Token: 0x0400B602 RID: 46594
		[Token(Token = "0x40088D3")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x17A8B0", Offset = "0x17A9B1")]
		private bool <isEndEffector>k__BackingField;

		// Token: 0x0400B603 RID: 46595
		[Token(Token = "0x40088D4")]
		[FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		// Token: 0x0400B604 RID: 46596
		[Token(Token = "0x40088D5")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A8C0", Offset = "0x17A9C1")]
		public float maintainRelativePositionWeight;

		// Token: 0x0400B605 RID: 46597
		[Token(Token = "0x40088D6")]
		[FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		// Token: 0x0400B606 RID: 46598
		[Token(Token = "0x40088D7")]
		[FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		// Token: 0x0400B607 RID: 46599
		[Token(Token = "0x40088D8")]
		[FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		// Token: 0x0400B608 RID: 46600
		[Token(Token = "0x40088D9")]
		[FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		// Token: 0x0400B609 RID: 46601
		[Token(Token = "0x40088DA")]
		[FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		// Token: 0x0400B60A RID: 46602
		[Token(Token = "0x40088DB")]
		[FieldOffset(Offset = "0x88")]
		private float posW;

		// Token: 0x0400B60B RID: 46603
		[Token(Token = "0x40088DC")]
		[FieldOffset(Offset = "0x8C")]
		private float rotW;

		// Token: 0x0400B60C RID: 46604
		[Token(Token = "0x40088DD")]
		[FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		// Token: 0x0400B60D RID: 46605
		[Token(Token = "0x40088DE")]
		[FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		// Token: 0x0400B60E RID: 46606
		[Token(Token = "0x40088DF")]
		[FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		// Token: 0x0400B60F RID: 46607
		[Token(Token = "0x40088E0")]
		[FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		// Token: 0x0400B610 RID: 46608
		[Token(Token = "0x40088E1")]
		[FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		// Token: 0x0400B611 RID: 46609
		[Token(Token = "0x40088E2")]
		[FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		// Token: 0x0400B612 RID: 46610
		[Token(Token = "0x40088E3")]
		[FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		// Token: 0x0400B613 RID: 46611
		[Token(Token = "0x40088E4")]
		[FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		// Token: 0x0400B614 RID: 46612
		[Token(Token = "0x40088E5")]
		[FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		// Token: 0x0400B615 RID: 46613
		[Token(Token = "0x40088E6")]
		[FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		// Token: 0x0400B616 RID: 46614
		[Token(Token = "0x40088E7")]
		[FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		// Token: 0x0400B617 RID: 46615
		[Token(Token = "0x40088E8")]
		[FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		// Token: 0x0400B618 RID: 46616
		[Token(Token = "0x40088E9")]
		[FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		// Token: 0x0400B619 RID: 46617
		[Token(Token = "0x40088EA")]
		[FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		// Token: 0x0400B61A RID: 46618
		[Token(Token = "0x40088EB")]
		[FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;
	}
}
