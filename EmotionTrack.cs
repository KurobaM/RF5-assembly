using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008D0 RID: 2256
[Token(Token = "0x20005DE")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146AD0", Offset = "0x146BD1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146AD0", Offset = "0x146BD1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146AD0", Offset = "0x146BD1")]
public class EmotionTrack : TrackAsset
{
	// Token: 0x06003B91 RID: 15249 RVA: 0x00014DC0 File Offset: 0x00012FC0
	[Token(Token = "0x60031F3")]
	[Address(RVA = "0x22B12E0", Offset = "0x22B13E1", VA = "0x22B12E0", Slot = "31")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	// Token: 0x06003B92 RID: 15250 RVA: 0x00014DD8 File Offset: 0x00012FD8
	[Token(Token = "0x60031F4")]
	[Address(RVA = "0x22B12F0", Offset = "0x22B13F1", VA = "0x22B12F0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003B93 RID: 15251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031F5")]
	[Address(RVA = "0x22B17A0", Offset = "0x22B18A1", VA = "0x22B17A0")]
	public EmotionTrack()
	{
	}
}
