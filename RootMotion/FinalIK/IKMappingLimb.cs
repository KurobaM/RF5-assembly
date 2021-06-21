using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D31 RID: 3377
	[Token(Token = "0x20008B7")]
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		// Token: 0x060056B8 RID: 22200 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		[Token(Token = "0x600483E")]
		[Address(RVA = "0x2C172D0", Offset = "0x2C173D1", VA = "0x2C172D0", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600483F")]
		[Address(RVA = "0x2C17350", Offset = "0x2C17451", VA = "0x2C17350")]
		public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap)
		{
			return null;
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x2C17430", Offset = "0x2C17531", VA = "0x2C17430")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004841")]
		[Address(RVA = "0x2C177A0", Offset = "0x2C178A1", VA = "0x2C177A0")]
		public IKMappingLimb()
		{
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004842")]
		[Address(RVA = "0x2C178D0", Offset = "0x2C179D1", VA = "0x2C178D0")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004843")]
		[Address(RVA = "0x2C17A60", Offset = "0x2C17B61", VA = "0x2C17A60")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004844")]
		[Address(RVA = "0x2C17AD0", Offset = "0x2C17BD1", VA = "0x2C17AD0")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004845")]
		[Address(RVA = "0x2C17C30", Offset = "0x2C17D31", VA = "0x2C17C30")]
		public void FixTransforms()
		{
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004846")]
		[Address(RVA = "0x2C17D40", Offset = "0x2C17E41", VA = "0x2C17D40", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004847")]
		[Address(RVA = "0x2C180C0", Offset = "0x2C181C1", VA = "0x2C180C0")]
		public void ReadPose()
		{
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004848")]
		[Address(RVA = "0x2C18190", Offset = "0x2C18291", VA = "0x2C18190")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}

		// Token: 0x0400B634 RID: 46644
		[Token(Token = "0x40088EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		// Token: 0x0400B635 RID: 46645
		[Token(Token = "0x40088F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		// Token: 0x0400B636 RID: 46646
		[Token(Token = "0x40088F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		// Token: 0x0400B637 RID: 46647
		[Token(Token = "0x40088F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		// Token: 0x0400B638 RID: 46648
		[Token(Token = "0x40088F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A900", Offset = "0x17AA01")]
		public float maintainRotationWeight;

		// Token: 0x0400B639 RID: 46649
		[Token(Token = "0x40088F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A920", Offset = "0x17AA21")]
		public float weight;

		// Token: 0x0400B63A RID: 46650
		[Token(Token = "0x40088F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public bool updatePlaneRotations;

		// Token: 0x0400B63B RID: 46651
		[Token(Token = "0x40088F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IKMapping.BoneMap boneMapParent;

		// Token: 0x0400B63C RID: 46652
		[Token(Token = "0x40088F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IKMapping.BoneMap boneMap1;

		// Token: 0x0400B63D RID: 46653
		[Token(Token = "0x40088F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKMapping.BoneMap boneMap2;

		// Token: 0x0400B63E RID: 46654
		[Token(Token = "0x40088F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKMapping.BoneMap boneMap3;

		// Token: 0x02000D32 RID: 3378
		[Token(Token = "0x20013F3")]
		[Serializable]
		public enum BoneMapType
		{
			// Token: 0x0400B640 RID: 46656
			[Token(Token = "0x401B98A")]
			Parent,
			// Token: 0x0400B641 RID: 46657
			[Token(Token = "0x401B98B")]
			Bone1,
			// Token: 0x0400B642 RID: 46658
			[Token(Token = "0x401B98C")]
			Bone2,
			// Token: 0x0400B643 RID: 46659
			[Token(Token = "0x401B98D")]
			Bone3
		}
	}
}
