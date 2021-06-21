using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class TimeDilationMixerBehaviour : PlayableBehaviour
{
	// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x20606E0", Offset = "0x20607E1", VA = "0x20606E0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x20608B0", Offset = "0x20609B1", VA = "0x20608B0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x20608C0", Offset = "0x20609C1", VA = "0x20608C0", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x20608D0", Offset = "0x20609D1", VA = "0x20608D0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x20608E0", Offset = "0x20609E1", VA = "0x20608E0")]
	public TimeDilationMixerBehaviour()
	{
	}

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x10")]
	private readonly float defaultTimeScale;
}
