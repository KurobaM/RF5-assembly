using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
public class TextSwitcherMixerBehaviour : PlayableBehaviour
{
	// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x205BAF0", Offset = "0x205BBF1", VA = "0x205BAF0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x205BF60", Offset = "0x205C061", VA = "0x205BF60", Slot = "16")]
	public override void OnPlayableDestroy(Playable playable)
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x205C040", Offset = "0x205C141", VA = "0x205C040")]
	public TextSwitcherMixerBehaviour()
	{
	}

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x10")]
	private Color m_DefaultColor;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	private int m_DefaultFontSize;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	private string m_DefaultText;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	private Text m_TrackBinding;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	private bool m_FirstFrameHappened;
}
