using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D3F RID: 3391
	[Token(Token = "0x20008BF")]
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		// Token: 0x06005741 RID: 22337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x2575F40", Offset = "0x2576041", VA = "0x2575F40")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x2576040", Offset = "0x2576141", VA = "0x2576040")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x0001CB18 File Offset: 0x0001AD18
		[Token(Token = "0x60048AE")]
		[Address(RVA = "0x25760B0", Offset = "0x25761B1", VA = "0x25760B0")]
		public int GetChainIndex(Transform transform)
		{
			return 0;
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048AF")]
		[Address(RVA = "0x25761F0", Offset = "0x25762F1", VA = "0x25761F0")]
		public IKSolver.Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B0")]
		[Address(RVA = "0x2576250", Offset = "0x2576351", VA = "0x2576250")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048B1")]
		[Address(RVA = "0x25762D0", Offset = "0x25763D1", VA = "0x25762D0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x25764C0", Offset = "0x25765C1", VA = "0x25764C0", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x0001CB30 File Offset: 0x0001AD30
		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x2576640", Offset = "0x2576741", VA = "0x2576640", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B4")]
		[Address(RVA = "0x2576840", Offset = "0x2576941", VA = "0x2576840", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B5")]
		[Address(RVA = "0x2576920", Offset = "0x2576A21", VA = "0x2576920", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x2576A10", Offset = "0x2576B11", VA = "0x2576A10", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x2576B90", Offset = "0x2576C91", VA = "0x2576B90", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x2576D50", Offset = "0x2576E51", VA = "0x2576D50", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x2576FA0", Offset = "0x25770A1", VA = "0x2576FA0", Slot = "13")]
		protected virtual void Solve()
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x25772A0", Offset = "0x25773A1", VA = "0x25772A0", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x25772F0", Offset = "0x25773F1", VA = "0x25772F0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x25773E0", Offset = "0x25774E1", VA = "0x25773E0")]
		public IKSolverFullBody()
		{
		}

		// Token: 0x0400B68C RID: 46732
		[Token(Token = "0x4008933")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AAE0", Offset = "0x17ABE1")]
		public int iterations;

		// Token: 0x0400B68D RID: 46733
		[Token(Token = "0x4008934")]
		[FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		// Token: 0x0400B68E RID: 46734
		[Token(Token = "0x4008935")]
		[FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		// Token: 0x0400B68F RID: 46735
		[Token(Token = "0x4008936")]
		[FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		// Token: 0x0400B690 RID: 46736
		[Token(Token = "0x4008937")]
		[FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		// Token: 0x0400B691 RID: 46737
		[Token(Token = "0x4008938")]
		[FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		// Token: 0x0400B692 RID: 46738
		[Token(Token = "0x4008939")]
		[FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		// Token: 0x0400B693 RID: 46739
		[Token(Token = "0x400893A")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPreRead;

		// Token: 0x0400B694 RID: 46740
		[Token(Token = "0x400893B")]
		[FieldOffset(Offset = "0x98")]
		public IKSolver.UpdateDelegate OnPreSolve;

		// Token: 0x0400B695 RID: 46741
		[Token(Token = "0x400893C")]
		[FieldOffset(Offset = "0xA0")]
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x0400B696 RID: 46742
		[Token(Token = "0x400893D")]
		[FieldOffset(Offset = "0xA8")]
		public IKSolver.IterationDelegate OnPostIteration;

		// Token: 0x0400B697 RID: 46743
		[Token(Token = "0x400893E")]
		[FieldOffset(Offset = "0xB0")]
		public IKSolver.UpdateDelegate OnPreBend;

		// Token: 0x0400B698 RID: 46744
		[Token(Token = "0x400893F")]
		[FieldOffset(Offset = "0xB8")]
		public IKSolver.UpdateDelegate OnPostSolve;

		// Token: 0x0400B699 RID: 46745
		[Token(Token = "0x4008940")]
		[FieldOffset(Offset = "0xC0")]
		public IKSolver.UpdateDelegate OnStoreDefaultLocalState;

		// Token: 0x0400B69A RID: 46746
		[Token(Token = "0x4008941")]
		[FieldOffset(Offset = "0xC8")]
		public IKSolver.UpdateDelegate OnFixTransforms;
	}
}
