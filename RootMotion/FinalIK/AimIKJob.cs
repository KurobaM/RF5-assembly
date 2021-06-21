using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D20 RID: 3360
	[Token(Token = "0x20008AA")]
	public struct AimIKJob : IAnimationJob
	{
		// Token: 0x06005619 RID: 22041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C5")]
		[Address(RVA = "0x367290", Offset = "0x367391", VA = "0x367290")]
		public void Setup(Animator animator, Transform[] bones, Transform target, Transform poleTarget, Transform aimTransform)
		{
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C6")]
		[Address(RVA = "0x3672A0", Offset = "0x3673A1", VA = "0x3672A0")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C7")]
		[Address(RVA = "0x3672B0", Offset = "0x3673B1", VA = "0x3672B0")]
		private void DisposeRotationLimits()
		{
		}

		// Token: 0x0600561C RID: 22044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C8")]
		[Address(RVA = "0x3672C0", Offset = "0x3673C1", VA = "0x3672C0", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047C9")]
		[Address(RVA = "0x3672D0", Offset = "0x3673D1", VA = "0x3672D0", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047CA")]
		[Address(RVA = "0x367320", Offset = "0x367421", VA = "0x367320")]
		private void Update(AnimationStream s)
		{
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047CB")]
		[Address(RVA = "0x367370", Offset = "0x367471", VA = "0x367370")]
		private void RotateToTarget(AnimationStream s, Vector3 targetPosition, Vector3 polePosition, int i, float weight, float poleWeight, bool XY, bool useRotationLimits, Vector3 axis, Vector3 poleAxis)
		{
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x0001C4D0 File Offset: 0x0001A6D0
		[Token(Token = "0x60047CC")]
		[Address(RVA = "0x3673E0", Offset = "0x3674E1", VA = "0x3673E0")]
		public float GetAngle(AnimationStream s, Vector3 axis, Vector3 IKPosition)
		{
			return 0f;
		}

		// Token: 0x06005621 RID: 22049 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		[Token(Token = "0x60047CD")]
		[Address(RVA = "0x367430", Offset = "0x367531", VA = "0x367430")]
		private Vector3 GetClampedIKPosition(AnimationStream s, float clampWeight, int clampSmoothing, Vector3 IKPosition, Vector3 transformPosition, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		// Token: 0x06005622 RID: 22050 RVA: 0x0001C500 File Offset: 0x0001A700
		[Token(Token = "0x60047CE")]
		[Address(RVA = "0x367450", Offset = "0x367551", VA = "0x367450")]
		private Vector3 GetLocalDirection(AnimationStream s, Vector3 transformAxis)
		{
			return default(Vector3);
		}

		// Token: 0x06005623 RID: 22051 RVA: 0x0001C518 File Offset: 0x0001A718
		[Token(Token = "0x60047CF")]
		[Address(RVA = "0x3674A0", Offset = "0x3675A1", VA = "0x3674A0")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return 0f;
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D0")]
		[Address(RVA = "0x3674B0", Offset = "0x3675B1", VA = "0x3674B0")]
		public void Dispose()
		{
		}

		// Token: 0x0400B542 RID: 46402
		[Token(Token = "0x4008824")]
		[FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		// Token: 0x0400B543 RID: 46403
		[Token(Token = "0x4008825")]
		[FieldOffset(Offset = "0x8")]
		public TransformSceneHandle _poleTarget;

		// Token: 0x0400B544 RID: 46404
		[Token(Token = "0x4008826")]
		[FieldOffset(Offset = "0x10")]
		public TransformStreamHandle _transform;

		// Token: 0x0400B545 RID: 46405
		[Token(Token = "0x4008827")]
		[FieldOffset(Offset = "0x1C")]
		public PropertySceneHandle _IKPositionWeight;

		// Token: 0x0400B546 RID: 46406
		[Token(Token = "0x4008828")]
		[FieldOffset(Offset = "0x24")]
		public PropertySceneHandle _poleWeight;

		// Token: 0x0400B547 RID: 46407
		[Token(Token = "0x4008829")]
		[FieldOffset(Offset = "0x2C")]
		public PropertySceneHandle _axisX;

		// Token: 0x0400B548 RID: 46408
		[Token(Token = "0x400882A")]
		[FieldOffset(Offset = "0x34")]
		public PropertySceneHandle _axisY;

		// Token: 0x0400B549 RID: 46409
		[Token(Token = "0x400882B")]
		[FieldOffset(Offset = "0x3C")]
		public PropertySceneHandle _axisZ;

		// Token: 0x0400B54A RID: 46410
		[Token(Token = "0x400882C")]
		[FieldOffset(Offset = "0x44")]
		public PropertySceneHandle _poleAxisX;

		// Token: 0x0400B54B RID: 46411
		[Token(Token = "0x400882D")]
		[FieldOffset(Offset = "0x4C")]
		public PropertySceneHandle _poleAxisY;

		// Token: 0x0400B54C RID: 46412
		[Token(Token = "0x400882E")]
		[FieldOffset(Offset = "0x54")]
		public PropertySceneHandle _poleAxisZ;

		// Token: 0x0400B54D RID: 46413
		[Token(Token = "0x400882F")]
		[FieldOffset(Offset = "0x5C")]
		public PropertySceneHandle _clampWeight;

		// Token: 0x0400B54E RID: 46414
		[Token(Token = "0x4008830")]
		[FieldOffset(Offset = "0x64")]
		public PropertySceneHandle _clampSmoothing;

		// Token: 0x0400B54F RID: 46415
		[Token(Token = "0x4008831")]
		[FieldOffset(Offset = "0x6C")]
		public PropertySceneHandle _maxIterations;

		// Token: 0x0400B550 RID: 46416
		[Token(Token = "0x4008832")]
		[FieldOffset(Offset = "0x74")]
		public PropertySceneHandle _tolerance;

		// Token: 0x0400B551 RID: 46417
		[Token(Token = "0x4008833")]
		[FieldOffset(Offset = "0x7C")]
		public PropertySceneHandle _XY;

		// Token: 0x0400B552 RID: 46418
		[Token(Token = "0x4008834")]
		[FieldOffset(Offset = "0x84")]
		public PropertySceneHandle _useRotationLimits;

		// Token: 0x0400B553 RID: 46419
		[Token(Token = "0x4008835")]
		[FieldOffset(Offset = "0x90")]
		private NativeArray<TransformStreamHandle> bones;

		// Token: 0x0400B554 RID: 46420
		[Token(Token = "0x4008836")]
		[FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> boneWeights;

		// Token: 0x0400B555 RID: 46421
		[Token(Token = "0x4008837")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 lastLocalDirection;

		// Token: 0x0400B556 RID: 46422
		[Token(Token = "0x4008838")]
		[FieldOffset(Offset = "0xBC")]
		private float step;

		// Token: 0x0400B557 RID: 46423
		[Token(Token = "0x4008839")]
		[FieldOffset(Offset = "0xC0")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		// Token: 0x0400B558 RID: 46424
		[Token(Token = "0x400883A")]
		[FieldOffset(Offset = "0xD0")]
		private NativeArray<Vector3> limitAxisArray;

		// Token: 0x0400B559 RID: 46425
		[Token(Token = "0x400883B")]
		[FieldOffset(Offset = "0xE0")]
		private NativeArray<int> hingeFlags;

		// Token: 0x0400B55A RID: 46426
		[Token(Token = "0x400883C")]
		[FieldOffset(Offset = "0xF0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		// Token: 0x0400B55B RID: 46427
		[Token(Token = "0x400883D")]
		[FieldOffset(Offset = "0x100")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		// Token: 0x0400B55C RID: 46428
		[Token(Token = "0x400883E")]
		[FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		// Token: 0x0400B55D RID: 46429
		[Token(Token = "0x400883F")]
		[FieldOffset(Offset = "0x120")]
		private NativeArray<Quaternion> hingeLastRotations;

		// Token: 0x0400B55E RID: 46430
		[Token(Token = "0x4008840")]
		[FieldOffset(Offset = "0x130")]
		private NativeArray<float> hingeLastAngles;

		// Token: 0x0400B55F RID: 46431
		[Token(Token = "0x4008841")]
		[FieldOffset(Offset = "0x140")]
		private NativeArray<int> angleFlags;

		// Token: 0x0400B560 RID: 46432
		[Token(Token = "0x4008842")]
		[FieldOffset(Offset = "0x150")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		// Token: 0x0400B561 RID: 46433
		[Token(Token = "0x4008843")]
		[FieldOffset(Offset = "0x160")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		// Token: 0x0400B562 RID: 46434
		[Token(Token = "0x4008844")]
		[FieldOffset(Offset = "0x170")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;
	}
}
