using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D3E RID: 3390
	[Token(Token = "0x20008BE")]
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		// Token: 0x06005736 RID: 22326 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x2574920", Offset = "0x2574A21", VA = "0x2574920", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x2575370", Offset = "0x2575471", VA = "0x2575370", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A3")]
		[Address(RVA = "0x2575410", Offset = "0x2575511", VA = "0x2575410", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x25754B0", Offset = "0x25755B1", VA = "0x25754B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x0001CAE8 File Offset: 0x0001ACE8
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x25755C0", Offset = "0x25756C1", VA = "0x25755C0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x2575670", Offset = "0x2575771", VA = "0x2575670", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600573C RID: 22332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A7")]
		[Address(RVA = "0x2575C00", Offset = "0x2575D01", VA = "0x2575C00", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x0600573D RID: 22333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A8")]
		[Address(RVA = "0x2575E20", Offset = "0x2575F21", VA = "0x2575E20", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x0600573E RID: 22334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A9")]
		[Address(RVA = "0x2575CB0", Offset = "0x2575DB1", VA = "0x2575CB0")]
		private void AddPointsToArray(ref IKSolver.Point[] array, FABRIKChain chain)
		{
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x0001CB00 File Offset: 0x0001AD00
		[Token(Token = "0x60048AA")]
		[Address(RVA = "0x25758C0", Offset = "0x25759C1", VA = "0x25758C0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x2575EC0", Offset = "0x2575FC1", VA = "0x2575EC0")]
		public IKSolverFABRIKRoot()
		{
		}

		// Token: 0x0400B686 RID: 46726
		[Token(Token = "0x400892D")]
		[FieldOffset(Offset = "0x58")]
		public int iterations;

		// Token: 0x0400B687 RID: 46727
		[Token(Token = "0x400892E")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AAC0", Offset = "0x17ABC1")]
		public float rootPin;

		// Token: 0x0400B688 RID: 46728
		[Token(Token = "0x400892F")]
		[FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		// Token: 0x0400B689 RID: 46729
		[Token(Token = "0x4008930")]
		[FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		// Token: 0x0400B68A RID: 46730
		[Token(Token = "0x4008931")]
		[FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		// Token: 0x0400B68B RID: 46731
		[Token(Token = "0x4008932")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;
	}
}
