using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000017 RID: 23
[Token(Token = "0x2000017")]
[Serializable]
public class TransformTweenBehaviour : PlayableBehaviour
{
	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2075AD0", Offset = "0x2075BD1", VA = "0x2075AD0", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2075B90", Offset = "0x2075C91", VA = "0x2075B90")]
	public float EvaluateCurrentCurve(float time)
	{
		return 0f;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002208 File Offset: 0x00000408
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2075C90", Offset = "0x2075D91", VA = "0x2075C90")]
	private bool IsCustomCurveNormalised()
	{
		return default(bool);
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2075EE0", Offset = "0x2075FE1", VA = "0x2075EE0")]
	public TransformTweenBehaviour()
	{
	}

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x10")]
	public Transform startLocation;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	public Transform endLocation;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x20")]
	public bool tweenPosition;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x21")]
	public bool tweenRotation;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x24")]
	public TransformTweenBehaviour.TweenType tweenType;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve customCurve;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 startingPosition;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x3C")]
	public Quaternion startingRotation;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x50")]
	private AnimationCurve m_LinearCurve;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x58")]
	private AnimationCurve m_DecelerationCurve;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x60")]
	private AnimationCurve m_HarmonicCurve;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	private const float k_RightAngleInRads = 1.57079637f;

	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000F8A")]
	public enum TweenType
	{
		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4018C79")]
		Linear,
		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4018C7A")]
		Deceleration,
		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4018C7B")]
		Harmonic,
		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4018C7C")]
		Custom
	}
}
