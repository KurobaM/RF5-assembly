using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008E6 RID: 2278
[Token(Token = "0x20005F2")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146E50", Offset = "0x146F51")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146E50", Offset = "0x146F51")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146E50", Offset = "0x146F51")]
public class RF_AudioTrack : TrackAsset
{
	// Token: 0x06003C03 RID: 15363 RVA: 0x00014FA0 File Offset: 0x000131A0
	[Token(Token = "0x600325F")]
	[Address(RVA = "0x1F39920", Offset = "0x1F39A21", VA = "0x1F39920", Slot = "31")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	// Token: 0x06003C04 RID: 15364 RVA: 0x00014FB8 File Offset: 0x000131B8
	[Token(Token = "0x6003260")]
	[Address(RVA = "0x1F39930", Offset = "0x1F39A31", VA = "0x1F39930", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003C05 RID: 15365 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003261")]
	[Address(RVA = "0x1F39EC0", Offset = "0x1F39FC1", VA = "0x1F39EC0")]
	public RF_AudioTrack()
	{
	}
}
