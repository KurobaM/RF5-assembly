using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D30 RID: 3376
	[Token(Token = "0x20008B6")]
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		// Token: 0x060056B0 RID: 22192 RVA: 0x0001C890 File Offset: 0x0001AA90
		[Token(Token = "0x6004836")]
		[Address(RVA = "0x2C16F00", Offset = "0x2C17001", VA = "0x2C16F00", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004837")]
		[Address(RVA = "0x2C16FC0", Offset = "0x2C170C1", VA = "0x2C16FC0")]
		public IKMappingBone()
		{
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004838")]
		[Address(RVA = "0x2C17050", Offset = "0x2C17151", VA = "0x2C17050")]
		public IKMappingBone(Transform bone)
		{
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004839")]
		[Address(RVA = "0x2C17100", Offset = "0x2C17201", VA = "0x2C17100")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483A")]
		[Address(RVA = "0x2C17160", Offset = "0x2C17261", VA = "0x2C17160")]
		public void FixTransforms()
		{
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483B")]
		[Address(RVA = "0x2C17190", Offset = "0x2C17291", VA = "0x2C17190", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483C")]
		[Address(RVA = "0x2C17260", Offset = "0x2C17361", VA = "0x2C17260")]
		public void ReadPose()
		{
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600483D")]
		[Address(RVA = "0x2C172A0", Offset = "0x2C173A1", VA = "0x2C172A0")]
		public void WritePose(float solverWeight)
		{
		}

		// Token: 0x0400B631 RID: 46641
		[Token(Token = "0x40088EC")]
		[FieldOffset(Offset = "0x10")]
		public Transform bone;

		// Token: 0x0400B632 RID: 46642
		[Token(Token = "0x40088ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A8E0", Offset = "0x17A9E1")]
		public float maintainRotationWeight;

		// Token: 0x0400B633 RID: 46643
		[Token(Token = "0x40088EE")]
		[FieldOffset(Offset = "0x20")]
		private IKMapping.BoneMap boneMap;
	}
}
