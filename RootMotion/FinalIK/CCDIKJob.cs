using System;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Animations;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D22 RID: 3362
	[Token(Token = "0x20008AC")]
	public struct CCDIKJob : IAnimationJob
	{
		// Token: 0x0600562B RID: 22059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D7")]
		[Address(RVA = "0x3674C0", Offset = "0x3675C1", VA = "0x3674C0")]
		public void Setup(Animator animator, Transform[] bones, Transform target)
		{
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D8")]
		[Address(RVA = "0x3674D0", Offset = "0x3675D1", VA = "0x3674D0")]
		private void SetUpRotationLimits(Animator animator, Transform[] bones)
		{
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047D9")]
		[Address(RVA = "0x3674E0", Offset = "0x3675E1", VA = "0x3674E0")]
		private void DisposeRotationLimits()
		{
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DA")]
		[Address(RVA = "0x3674F0", Offset = "0x3675F1", VA = "0x3674F0", Slot = "5")]
		public void ProcessRootMotion(AnimationStream stream)
		{
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DB")]
		[Address(RVA = "0x367500", Offset = "0x367601", VA = "0x367500", Slot = "4")]
		public void ProcessAnimation(AnimationStream stream)
		{
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DC")]
		[Address(RVA = "0x367550", Offset = "0x367651", VA = "0x367550")]
		private void Update(AnimationStream s)
		{
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DD")]
		[Address(RVA = "0x3675A0", Offset = "0x3676A1", VA = "0x3675A0")]
		private void Read(AnimationStream s)
		{
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047DE")]
		[Address(RVA = "0x3675F0", Offset = "0x3676F1", VA = "0x3675F0")]
		private void Solve(AnimationStream s, Vector3 targetPosition, bool XY, float weight, int it, bool useRotationLimits)
		{
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x0001C548 File Offset: 0x0001A748
		[Token(Token = "0x60047DF")]
		[Address(RVA = "0x367640", Offset = "0x367741", VA = "0x367640")]
		private Vector3 GetLocalDirection(AnimationStream s)
		{
			return default(Vector3);
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x0001C560 File Offset: 0x0001A760
		[Token(Token = "0x60047E0")]
		[Address(RVA = "0x367690", Offset = "0x367791", VA = "0x367690")]
		private float GetPositionOffset(AnimationStream s, Vector3 localDirection)
		{
			return 0f;
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x0001C578 File Offset: 0x0001A778
		[Token(Token = "0x60047E1")]
		[Address(RVA = "0x3676A0", Offset = "0x3677A1", VA = "0x3676A0")]
		private Vector3 GetSingularityOffset(AnimationStream s, Vector3 IKPosition, bool useRotationLimits)
		{
			return default(Vector3);
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x0001C590 File Offset: 0x0001A790
		[Token(Token = "0x60047E2")]
		[Address(RVA = "0x3676F0", Offset = "0x3677F1", VA = "0x3676F0")]
		private bool SingularityDetected(AnimationStream s, Vector3 IKPosition)
		{
			return default(bool);
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E3")]
		[Address(RVA = "0x367740", Offset = "0x367841", VA = "0x367740")]
		public void Dispose()
		{
		}

		// Token: 0x0400B56F RID: 46447
		[Token(Token = "0x4008851")]
		[FieldOffset(Offset = "0x0")]
		public TransformSceneHandle _target;

		// Token: 0x0400B570 RID: 46448
		[Token(Token = "0x4008852")]
		[FieldOffset(Offset = "0x8")]
		public PropertySceneHandle _IKPositionWeight;

		// Token: 0x0400B571 RID: 46449
		[Token(Token = "0x4008853")]
		[FieldOffset(Offset = "0x10")]
		public PropertySceneHandle _maxIterations;

		// Token: 0x0400B572 RID: 46450
		[Token(Token = "0x4008854")]
		[FieldOffset(Offset = "0x18")]
		public PropertySceneHandle _tolerance;

		// Token: 0x0400B573 RID: 46451
		[Token(Token = "0x4008855")]
		[FieldOffset(Offset = "0x20")]
		public PropertySceneHandle _XY;

		// Token: 0x0400B574 RID: 46452
		[Token(Token = "0x4008856")]
		[FieldOffset(Offset = "0x28")]
		public PropertySceneHandle _useRotationLimits;

		// Token: 0x0400B575 RID: 46453
		[Token(Token = "0x4008857")]
		[FieldOffset(Offset = "0x30")]
		private NativeArray<TransformStreamHandle> bones;

		// Token: 0x0400B576 RID: 46454
		[Token(Token = "0x4008858")]
		[FieldOffset(Offset = "0x40")]
		private NativeArray<PropertySceneHandle> boneWeights;

		// Token: 0x0400B577 RID: 46455
		[Token(Token = "0x4008859")]
		[FieldOffset(Offset = "0x50")]
		private NativeArray<float> boneSqrMags;

		// Token: 0x0400B578 RID: 46456
		[Token(Token = "0x400885A")]
		[FieldOffset(Offset = "0x60")]
		private float chainSqrMag;

		// Token: 0x0400B579 RID: 46457
		[Token(Token = "0x400885B")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 lastLocalDirection;

		// Token: 0x0400B57A RID: 46458
		[Token(Token = "0x400885C")]
		[FieldOffset(Offset = "0x70")]
		private NativeArray<Quaternion> limitDefaultLocalRotationArray;

		// Token: 0x0400B57B RID: 46459
		[Token(Token = "0x400885D")]
		[FieldOffset(Offset = "0x80")]
		private NativeArray<Vector3> limitAxisArray;

		// Token: 0x0400B57C RID: 46460
		[Token(Token = "0x400885E")]
		[FieldOffset(Offset = "0x90")]
		private NativeArray<int> hingeFlags;

		// Token: 0x0400B57D RID: 46461
		[Token(Token = "0x400885F")]
		[FieldOffset(Offset = "0xA0")]
		private NativeArray<PropertySceneHandle> hingeMinArray;

		// Token: 0x0400B57E RID: 46462
		[Token(Token = "0x4008860")]
		[FieldOffset(Offset = "0xB0")]
		private NativeArray<PropertySceneHandle> hingeMaxArray;

		// Token: 0x0400B57F RID: 46463
		[Token(Token = "0x4008861")]
		[FieldOffset(Offset = "0xC0")]
		private NativeArray<PropertySceneHandle> hingeUseLimitsArray;

		// Token: 0x0400B580 RID: 46464
		[Token(Token = "0x4008862")]
		[FieldOffset(Offset = "0xD0")]
		private NativeArray<Quaternion> hingeLastRotations;

		// Token: 0x0400B581 RID: 46465
		[Token(Token = "0x4008863")]
		[FieldOffset(Offset = "0xE0")]
		private NativeArray<float> hingeLastAngles;

		// Token: 0x0400B582 RID: 46466
		[Token(Token = "0x4008864")]
		[FieldOffset(Offset = "0xF0")]
		private NativeArray<int> angleFlags;

		// Token: 0x0400B583 RID: 46467
		[Token(Token = "0x4008865")]
		[FieldOffset(Offset = "0x100")]
		private NativeArray<Vector3> angleSecondaryAxisArray;

		// Token: 0x0400B584 RID: 46468
		[Token(Token = "0x4008866")]
		[FieldOffset(Offset = "0x110")]
		private NativeArray<PropertySceneHandle> angleLimitArray;

		// Token: 0x0400B585 RID: 46469
		[Token(Token = "0x4008867")]
		[FieldOffset(Offset = "0x120")]
		private NativeArray<PropertySceneHandle> angleTwistLimitArray;
	}
}
