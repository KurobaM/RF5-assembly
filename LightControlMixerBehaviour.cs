using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class LightControlMixerBehaviour : PlayableBehaviour
{
	// Token: 0x0600000B RID: 11 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x230FFC0", Offset = "0x23100C1", VA = "0x230FFC0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x23103B0", Offset = "0x23104B1", VA = "0x23103B0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2310490", Offset = "0x2310591", VA = "0x2310490")]
	public LightControlMixerBehaviour()
	{
	}

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	private float m_DefaultIntensity;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x24")]
	private float m_DefaultBounceIntensity;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x28")]
	private float m_DefaultRange;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x30")]
	private Light m_TrackBinding;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;
}
