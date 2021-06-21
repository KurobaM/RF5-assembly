using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D27 RID: 3367
	[Token(Token = "0x20008B1")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		// Token: 0x06005648 RID: 22088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x2873980", Offset = "0x2873A81", VA = "0x2873980")]
		private void Start()
		{
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x2873D10", Offset = "0x2873E11", VA = "0x2873D10")]
		private void OnStoreDefaultLocalState()
		{
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F6")]
		[Address(RVA = "0x2874230", Offset = "0x2874331", VA = "0x2874230")]
		private void OnFixTransforms()
		{
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F7")]
		[Address(RVA = "0x2874640", Offset = "0x2874741", VA = "0x2874640")]
		private void OnPreRead()
		{
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F8")]
		[Address(RVA = "0x2874FC0", Offset = "0x28750C1", VA = "0x2874FC0")]
		private void SpineBend()
		{
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047F9")]
		[Address(RVA = "0x2875310", Offset = "0x2875411", VA = "0x2875310")]
		private void CCDPass()
		{
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047FA")]
		[Address(RVA = "0x28756B0", Offset = "0x28757B1", VA = "0x28756B0")]
		private void Iterate(int iteration)
		{
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047FB")]
		[Address(RVA = "0x2876110", Offset = "0x2876211", VA = "0x2876110")]
		private void OnPostUpdate()
		{
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047FC")]
		[Address(RVA = "0x2874CE0", Offset = "0x2874DE1", VA = "0x2874CE0")]
		private void ChestDirection()
		{
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047FD")]
		[Address(RVA = "0x2876320", Offset = "0x2876421", VA = "0x2876320")]
		private void PostStretching()
		{
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047FE")]
		[Address(RVA = "0x2875FD0", Offset = "0x28760D1", VA = "0x2875FD0")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047FF")]
		[Address(RVA = "0x2875E30", Offset = "0x2875F31", VA = "0x2875E30")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004800")]
		[Address(RVA = "0x2876690", Offset = "0x2876791", VA = "0x2876690")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004801")]
		[Address(RVA = "0x2876980", Offset = "0x2876A81", VA = "0x2876980")]
		public FBBIKHeadEffector()
		{
		}

		// Token: 0x0400B593 RID: 46483
		[Token(Token = "0x4008875")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A0A0", Offset = "0x17A1A1")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B594 RID: 46484
		[Token(Token = "0x4008876")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "LargeHeader", RVA = "0x17A0E0", Offset = "0x17A1E1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A0E0", Offset = "0x17A1E1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A0E0", Offset = "0x17A1E1")]
		public float positionWeight;

		// Token: 0x0400B595 RID: 46485
		[Token(Token = "0x4008877")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A160", Offset = "0x17A261")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A160", Offset = "0x17A261")]
		public float bodyWeight;

		// Token: 0x0400B596 RID: 46486
		[Token(Token = "0x4008878")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A1C0", Offset = "0x17A2C1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A1C0", Offset = "0x17A2C1")]
		public float thighWeight;

		// Token: 0x0400B597 RID: 46487
		[Token(Token = "0x4008879")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A220", Offset = "0x17A321")]
		public bool handsPullBody;

		// Token: 0x0400B598 RID: 46488
		[Token(Token = "0x400887A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "LargeHeader", RVA = "0x17A260", Offset = "0x17A361")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A260", Offset = "0x17A361")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A260", Offset = "0x17A361")]
		public float rotationWeight;

		// Token: 0x0400B599 RID: 46489
		[Token(Token = "0x400887B")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A2E0", Offset = "0x17A3E1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A2E0", Offset = "0x17A3E1")]
		public float bodyClampWeight;

		// Token: 0x0400B59A RID: 46490
		[Token(Token = "0x400887C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A340", Offset = "0x17A441")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A340", Offset = "0x17A441")]
		public float headClampWeight;

		// Token: 0x0400B59B RID: 46491
		[Token(Token = "0x400887D")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A3A0", Offset = "0x17A4A1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A3A0", Offset = "0x17A4A1")]
		public float bendWeight;

		// Token: 0x0400B59C RID: 46492
		[Token(Token = "0x400887E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A400", Offset = "0x17A501")]
		public FBBIKHeadEffector.BendBone[] bendBones;

		// Token: 0x0400B59D RID: 46493
		[Token(Token = "0x400887F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "LargeHeader", RVA = "0x17A440", Offset = "0x17A541")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A440", Offset = "0x17A541")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A440", Offset = "0x17A541")]
		public float CCDWeight;

		// Token: 0x0400B59E RID: 46494
		[Token(Token = "0x4008880")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A4C0", Offset = "0x17A5C1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A4C0", Offset = "0x17A5C1")]
		public float roll;

		// Token: 0x0400B59F RID: 46495
		[Token(Token = "0x4008881")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A520", Offset = "0x17A621")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A520", Offset = "0x17A621")]
		public float damper;

		// Token: 0x0400B5A0 RID: 46496
		[Token(Token = "0x4008882")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A580", Offset = "0x17A681")]
		public Transform[] CCDBones;

		// Token: 0x0400B5A1 RID: 46497
		[Token(Token = "0x4008883")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "LargeHeader", RVA = "0x17A5C0", Offset = "0x17A6C1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A5C0", Offset = "0x17A6C1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A5C0", Offset = "0x17A6C1")]
		public float postStretchWeight;

		// Token: 0x0400B5A2 RID: 46498
		[Token(Token = "0x4008884")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A640", Offset = "0x17A741")]
		public float maxStretch;

		// Token: 0x0400B5A3 RID: 46499
		[Token(Token = "0x4008885")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A680", Offset = "0x17A781")]
		public float stretchDamper;

		// Token: 0x0400B5A4 RID: 46500
		[Token(Token = "0x4008886")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A6C0", Offset = "0x17A7C1")]
		public bool fixHead;

		// Token: 0x0400B5A5 RID: 46501
		[Token(Token = "0x4008887")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x17A700", Offset = "0x17A801")]
		public Transform[] stretchBones;

		// Token: 0x0400B5A6 RID: 46502
		[Token(Token = "0x4008888")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "LargeHeader", RVA = "0x17A740", Offset = "0x17A841")]
		public Vector3 chestDirection;

		// Token: 0x0400B5A7 RID: 46503
		[Token(Token = "0x4008889")]
		[FieldOffset(Offset = "0x84")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17A780", Offset = "0x17A881")]
		public float chestDirectionWeight;

		// Token: 0x0400B5A8 RID: 46504
		[Token(Token = "0x400888A")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		// Token: 0x0400B5A9 RID: 46505
		[Token(Token = "0x400888B")]
		[FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		// Token: 0x0400B5AA RID: 46506
		[Token(Token = "0x400888C")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		// Token: 0x0400B5AB RID: 46507
		[Token(Token = "0x400888D")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		// Token: 0x0400B5AC RID: 46508
		[Token(Token = "0x400888E")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		// Token: 0x0400B5AD RID: 46509
		[Token(Token = "0x400888F")]
		[FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		// Token: 0x0400B5AE RID: 46510
		[Token(Token = "0x4008890")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		// Token: 0x0400B5AF RID: 46511
		[Token(Token = "0x4008891")]
		[FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		// Token: 0x0400B5B0 RID: 46512
		[Token(Token = "0x4008892")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		// Token: 0x0400B5B1 RID: 46513
		[Token(Token = "0x4008893")]
		[FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		// Token: 0x0400B5B2 RID: 46514
		[Token(Token = "0x4008894")]
		[FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		// Token: 0x0400B5B3 RID: 46515
		[Token(Token = "0x4008895")]
		[FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		// Token: 0x0400B5B4 RID: 46516
		[Token(Token = "0x4008896")]
		[FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		// Token: 0x0400B5B5 RID: 46517
		[Token(Token = "0x4008897")]
		[FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		// Token: 0x0400B5B6 RID: 46518
		[Token(Token = "0x4008898")]
		[FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		// Token: 0x0400B5B7 RID: 46519
		[Token(Token = "0x4008899")]
		[FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		// Token: 0x0400B5B8 RID: 46520
		[Token(Token = "0x400889A")]
		[FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		// Token: 0x0400B5B9 RID: 46521
		[Token(Token = "0x400889B")]
		[FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		// Token: 0x0400B5BA RID: 46522
		[Token(Token = "0x400889C")]
		[FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		// Token: 0x0400B5BB RID: 46523
		[Token(Token = "0x400889D")]
		[FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		// Token: 0x0400B5BC RID: 46524
		[Token(Token = "0x400889E")]
		[FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		// Token: 0x0400B5BD RID: 46525
		[Token(Token = "0x400889F")]
		[FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		// Token: 0x0400B5BE RID: 46526
		[Token(Token = "0x40088A0")]
		[FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		// Token: 0x0400B5BF RID: 46527
		[Token(Token = "0x40088A1")]
		[FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		// Token: 0x0400B5C0 RID: 46528
		[Token(Token = "0x40088A2")]
		[FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		// Token: 0x02000D28 RID: 3368
		[Token(Token = "0x20013EF")]
		[Serializable]
		public class BendBone
		{
			// Token: 0x06005656 RID: 22102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600791E")]
			[Address(RVA = "0x2876B80", Offset = "0x2876C81", VA = "0x2876B80")]
			public BendBone()
			{
			}

			// Token: 0x06005657 RID: 22103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600791F")]
			[Address(RVA = "0x2876C10", Offset = "0x2876D11", VA = "0x2876C10")]
			public BendBone(Transform transform, float weight)
			{
			}

			// Token: 0x06005658 RID: 22104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007920")]
			[Address(RVA = "0x28741F0", Offset = "0x28742F1", VA = "0x28741F0")]
			public void StoreDefaultLocalState()
			{
			}

			// Token: 0x06005659 RID: 22105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007921")]
			[Address(RVA = "0x2874610", Offset = "0x2874711", VA = "0x2874610")]
			public void FixTransforms()
			{
			}

			// Token: 0x0400B5C1 RID: 46529
			[Token(Token = "0x401B962")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195F50", Offset = "0x196051")]
			public Transform transform;

			// Token: 0x0400B5C2 RID: 46530
			[Token(Token = "0x401B963")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195F90", Offset = "0x196091")]
			[Attribute(Name = "RangeAttribute", RVA = "0x195F90", Offset = "0x196091")]
			public float weight;

			// Token: 0x0400B5C3 RID: 46531
			[Token(Token = "0x401B964")]
			[FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;
		}
	}
}
