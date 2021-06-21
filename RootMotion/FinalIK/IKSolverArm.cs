using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D3B RID: 3387
	[Token(Token = "0x20008BB")]
	[Serializable]
	public class IKSolverArm : IKSolver
	{
		// Token: 0x0600570C RID: 22284 RVA: 0x0001CA10 File Offset: 0x0001AC10
		[Token(Token = "0x6004877")]
		[Address(RVA = "0x256F640", Offset = "0x256F741", VA = "0x256F640", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x0001CA28 File Offset: 0x0001AC28
		[Token(Token = "0x6004878")]
		[Address(RVA = "0x256FA00", Offset = "0x256FB01", VA = "0x256FA00")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004879")]
		[Address(RVA = "0x256FAC0", Offset = "0x256FBC1", VA = "0x256FAC0", Slot = "6")]
		public override IKSolver.Point[] GetPoints()
		{
			return null;
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600487A")]
		[Address(RVA = "0x256FC60", Offset = "0x256FD61", VA = "0x256FC60", Slot = "7")]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			return null;
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487B")]
		[Address(RVA = "0x256FE00", Offset = "0x256FF01", VA = "0x256FE00", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487C")]
		[Address(RVA = "0x256FF00", Offset = "0x2570001", VA = "0x256FF00", Slot = "8")]
		public override void FixTransforms()
		{
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487D")]
		[Address(RVA = "0x256FF60", Offset = "0x2570061", VA = "0x256FF60", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487E")]
		[Address(RVA = "0x25702F0", Offset = "0x25703F1", VA = "0x25702F0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600487F")]
		[Address(RVA = "0x2570320", Offset = "0x2570421", VA = "0x2570320")]
		private void Solve()
		{
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004880")]
		[Address(RVA = "0x256FFD0", Offset = "0x25700D1", VA = "0x256FFD0")]
		private void Read()
		{
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004881")]
		[Address(RVA = "0x2570390", Offset = "0x2570491", VA = "0x2570390")]
		private void Write()
		{
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004882")]
		[Address(RVA = "0x2570520", Offset = "0x2570621", VA = "0x2570520")]
		public IKSolverArm()
		{
		}

		// Token: 0x0400B677 RID: 46711
		[Token(Token = "0x400891E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17AAA0", Offset = "0x17ABA1")]
		public float IKRotationWeight;

		// Token: 0x0400B678 RID: 46712
		[Token(Token = "0x400891F")]
		[FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		// Token: 0x0400B679 RID: 46713
		[Token(Token = "0x4008920")]
		[FieldOffset(Offset = "0x70")]
		public IKSolver.Point chest;

		// Token: 0x0400B67A RID: 46714
		[Token(Token = "0x4008921")]
		[FieldOffset(Offset = "0x78")]
		public IKSolver.Point shoulder;

		// Token: 0x0400B67B RID: 46715
		[Token(Token = "0x4008922")]
		[FieldOffset(Offset = "0x80")]
		public IKSolver.Point upperArm;

		// Token: 0x0400B67C RID: 46716
		[Token(Token = "0x4008923")]
		[FieldOffset(Offset = "0x88")]
		public IKSolver.Point forearm;

		// Token: 0x0400B67D RID: 46717
		[Token(Token = "0x4008924")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.Point hand;

		// Token: 0x0400B67E RID: 46718
		[Token(Token = "0x4008925")]
		[FieldOffset(Offset = "0x98")]
		public bool isLeft;

		// Token: 0x0400B67F RID: 46719
		[Token(Token = "0x4008926")]
		[FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		// Token: 0x0400B680 RID: 46720
		[Token(Token = "0x4008927")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		// Token: 0x0400B681 RID: 46721
		[Token(Token = "0x4008928")]
		[FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;
	}
}
