using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class ScreenFaderMixerBehaviour : PlayableBehaviour
{
	// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x21DE1B0", Offset = "0x21DE2B1", VA = "0x21DE1B0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x21DE4E0", Offset = "0x21DE5E1", VA = "0x21DE4E0", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x21DE590", Offset = "0x21DE691", VA = "0x21DE590")]
	public ScreenFaderMixerBehaviour()
	{
	}

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x20")]
	private Image m_TrackBinding;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x28")]
	private bool m_FirstFrameHappened;
}
