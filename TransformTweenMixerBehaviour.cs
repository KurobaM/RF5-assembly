using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x0200001A RID: 26
[Token(Token = "0x2000019")]
public class TransformTweenMixerBehaviour : PlayableBehaviour
{
	// Token: 0x06000040 RID: 64 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2076300", Offset = "0x2076401", VA = "0x2076300", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2076AF0", Offset = "0x2076BF1", VA = "0x2076AF0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2076AD0", Offset = "0x2076BD1", VA = "0x2076AD0")]
	private static Quaternion AddQuaternions(Quaternion first, Quaternion second)
	{
		return default(Quaternion);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2076AB0", Offset = "0x2076BB1", VA = "0x2076AB0")]
	private static Quaternion ScaleQuaternion(Quaternion rotation, float multiplier)
	{
		return default(Quaternion);
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2076B00", Offset = "0x2076C01", VA = "0x2076B00")]
	private static float QuaternionMagnitude(Quaternion rotation)
	{
		return 0f;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2076910", Offset = "0x2076A11", VA = "0x2076910")]
	private static Quaternion NormalizeQuaternion(Quaternion rotation)
	{
		return default(Quaternion);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2076C00", Offset = "0x2076D01", VA = "0x2076C00")]
	public TransformTweenMixerBehaviour()
	{
	}

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x10")]
	private bool m_FirstFrameHappened;
}
