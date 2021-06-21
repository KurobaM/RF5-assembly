using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D3D RID: 3389
	[Token(Token = "0x20008BD")]
	[Serializable]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		// Token: 0x0600571D RID: 22301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004888")]
		[Address(RVA = "0x2571EB0", Offset = "0x2571FB1", VA = "0x2571EB0")]
		public void SolveForward(Vector3 position)
		{
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004889")]
		[Address(RVA = "0x2572610", Offset = "0x2572711", VA = "0x2572610")]
		public void SolveBackward(Vector3 position)
		{
		}

		// Token: 0x0600571F RID: 22303 RVA: 0x0001CA40 File Offset: 0x0001AC40
		[Token(Token = "0x600488A")]
		[Address(RVA = "0x25727A0", Offset = "0x25728A1", VA = "0x25727A0", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488B")]
		[Address(RVA = "0x2572840", Offset = "0x2572941", VA = "0x2572840", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488C")]
		[Address(RVA = "0x2572E20", Offset = "0x2572F21", VA = "0x2572E20", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06005722 RID: 22306 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[Token(Token = "0x170008BF")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600488D")]
			[Address(RVA = "0x25731C0", Offset = "0x25732C1", VA = "0x25731C0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005723 RID: 22307 RVA: 0x0001CA70 File Offset: 0x0001AC70
		[Token(Token = "0x600488E")]
		[Address(RVA = "0x25731D0", Offset = "0x25732D1", VA = "0x25731D0")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		// Token: 0x06005724 RID: 22308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488F")]
		[Address(RVA = "0x2571F80", Offset = "0x2572081", VA = "0x2571F80")]
		private void OnPreSolve()
		{
		}

		// Token: 0x06005725 RID: 22309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004890")]
		[Address(RVA = "0x2572740", Offset = "0x2572841", VA = "0x2572740")]
		private void OnPostSolve()
		{
		}

		// Token: 0x06005726 RID: 22310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004891")]
		[Address(RVA = "0x2573140", Offset = "0x2573241", VA = "0x2573140")]
		private void Solve(Vector3 targetPosition)
		{
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004892")]
		[Address(RVA = "0x2572430", Offset = "0x2572531", VA = "0x2572430")]
		private void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004893")]
		[Address(RVA = "0x2573A40", Offset = "0x2573B41", VA = "0x2573A40")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004894")]
		[Address(RVA = "0x2573B50", Offset = "0x2573C51", VA = "0x2573B50")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004895")]
		[Address(RVA = "0x2573CE0", Offset = "0x2573DE1", VA = "0x2573CE0")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004896")]
		[Address(RVA = "0x2573E00", Offset = "0x2573F01", VA = "0x2573E00")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[Token(Token = "0x6004897")]
		[Address(RVA = "0x2572B60", Offset = "0x2572C61", VA = "0x2572B60")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		[Token(Token = "0x6004898")]
		[Address(RVA = "0x2572CC0", Offset = "0x2572DC1", VA = "0x2572CC0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		[Token(Token = "0x6004899")]
		[Address(RVA = "0x2573FF0", Offset = "0x25740F1", VA = "0x2573FF0")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489A")]
		[Address(RVA = "0x25734B0", Offset = "0x25735B1", VA = "0x25734B0")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489B")]
		[Address(RVA = "0x2572730", Offset = "0x2572831", VA = "0x2572730")]
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489C")]
		[Address(RVA = "0x2574760", Offset = "0x2574861", VA = "0x2574760")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489D")]
		[Address(RVA = "0x25741D0", Offset = "0x25742D1", VA = "0x25741D0")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489E")]
		[Address(RVA = "0x25732F0", Offset = "0x25733F1", VA = "0x25732F0")]
		private void MapToSolverPositions()
		{
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489F")]
		[Address(RVA = "0x25733E0", Offset = "0x25734E1", VA = "0x25733E0")]
		private void MapToSolverPositionsLimited()
		{
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x2574830", Offset = "0x2574931", VA = "0x2574830")]
		public IKSolverFABRIK()
		{
		}

		// Token: 0x0400B683 RID: 46723
		[Token(Token = "0x400892A")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.IterationDelegate OnPreIteration;

		// Token: 0x0400B684 RID: 46724
		[Token(Token = "0x400892B")]
		[FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		// Token: 0x0400B685 RID: 46725
		[Token(Token = "0x400892C")]
		[FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;
	}
}
