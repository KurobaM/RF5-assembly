using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D33 RID: 3379
	[Token(Token = "0x20008B8")]
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		// Token: 0x060056C3 RID: 22211 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[Token(Token = "0x6004849")]
		[Address(RVA = "0x2C18330", Offset = "0x2C18431", VA = "0x2C18330", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484A")]
		[Address(RVA = "0x2C18620", Offset = "0x2C18721", VA = "0x2C18620")]
		public IKMappingSpine()
		{
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x2C18770", Offset = "0x2C18871", VA = "0x2C18770")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x2C18940", Offset = "0x2C18A41", VA = "0x2C18940")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484D")]
		[Address(RVA = "0x2C189C0", Offset = "0x2C18AC1", VA = "0x2C189C0")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484E")]
		[Address(RVA = "0x2C18A70", Offset = "0x2C18B71", VA = "0x2C18A70")]
		public void FixTransforms()
		{
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600484F")]
		[Address(RVA = "0x2C18B20", Offset = "0x2C18C21", VA = "0x2C18B20", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[Token(Token = "0x6004850")]
		[Address(RVA = "0x2C193D0", Offset = "0x2C194D1", VA = "0x2C193D0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004851")]
		[Address(RVA = "0x2C19410", Offset = "0x2C19511", VA = "0x2C19410")]
		public void ReadPose()
		{
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004852")]
		[Address(RVA = "0x2C196F0", Offset = "0x2C197F1", VA = "0x2C196F0")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004853")]
		[Address(RVA = "0x2C19AB0", Offset = "0x2C19BB1", VA = "0x2C19AB0")]
		public void ForwardReach(Vector3 position)
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004854")]
		[Address(RVA = "0x2C19BA0", Offset = "0x2C19CA1", VA = "0x2C19BA0")]
		private void BackwardReach(Vector3 position)
		{
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004855")]
		[Address(RVA = "0x2C19C70", Offset = "0x2C19D71", VA = "0x2C19C70")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}

		// Token: 0x0400B644 RID: 46660
		[Token(Token = "0x40088FA")]
		[FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		// Token: 0x0400B645 RID: 46661
		[Token(Token = "0x40088FB")]
		[FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		// Token: 0x0400B646 RID: 46662
		[Token(Token = "0x40088FC")]
		[FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		// Token: 0x0400B647 RID: 46663
		[Token(Token = "0x40088FD")]
		[FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		// Token: 0x0400B648 RID: 46664
		[Token(Token = "0x40088FE")]
		[FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		// Token: 0x0400B649 RID: 46665
		[Token(Token = "0x40088FF")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A940", Offset = "0x17AA41")]
		public int iterations;

		// Token: 0x0400B64A RID: 46666
		[Token(Token = "0x4008900")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A960", Offset = "0x17AA61")]
		public float twistWeight;

		// Token: 0x0400B64B RID: 46667
		[Token(Token = "0x4008901")]
		[FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		// Token: 0x0400B64C RID: 46668
		[Token(Token = "0x4008902")]
		[FieldOffset(Offset = "0x48")]
		private IKMapping.BoneMap[] spine;

		// Token: 0x0400B64D RID: 46669
		[Token(Token = "0x4008903")]
		[FieldOffset(Offset = "0x50")]
		private IKMapping.BoneMap leftUpperArm;

		// Token: 0x0400B64E RID: 46670
		[Token(Token = "0x4008904")]
		[FieldOffset(Offset = "0x58")]
		private IKMapping.BoneMap rightUpperArm;

		// Token: 0x0400B64F RID: 46671
		[Token(Token = "0x4008905")]
		[FieldOffset(Offset = "0x60")]
		private IKMapping.BoneMap leftThigh;

		// Token: 0x0400B650 RID: 46672
		[Token(Token = "0x4008906")]
		[FieldOffset(Offset = "0x68")]
		private IKMapping.BoneMap rightThigh;

		// Token: 0x0400B651 RID: 46673
		[Token(Token = "0x4008907")]
		[FieldOffset(Offset = "0x70")]
		private bool useFABRIK;
	}
}
