using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008F1 RID: 2289
[Token(Token = "0x20005FD")]
[Serializable]
public class TimeMachineClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x170008B2 RID: 2226
	// (get) Token: 0x06003C2F RID: 15407 RVA: 0x00015078 File Offset: 0x00013278
	[Token(Token = "0x170006F5")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600328B")]
		[Address(RVA = "0x2060D80", Offset = "0x2060E81", VA = "0x2060D80", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x00015090 File Offset: 0x00013290
	[Token(Token = "0x600328C")]
	[Address(RVA = "0x2060D90", Offset = "0x2060E91", VA = "0x2060D90", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003C31 RID: 15409 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600328D")]
	[Address(RVA = "0x2060E30", Offset = "0x2060F31", VA = "0x2060E30")]
	public TimeMachineClip()
	{
	}

	// Token: 0x04007EA8 RID: 32424
	[Token(Token = "0x400725D")]
	[FieldOffset(Offset = "0x18")]
	public TimeMachineBehaviour Repeat;
}
