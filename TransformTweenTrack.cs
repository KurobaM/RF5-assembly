using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001A")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x144B10", Offset = "0x144C11")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x144B10", Offset = "0x144C11")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x144B10", Offset = "0x144C11")]
public class TransformTweenTrack : TrackAsset
{
	// Token: 0x06000047 RID: 71 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1FF8290", Offset = "0x1FF8391", VA = "0x1FF8290", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1FF8330", Offset = "0x1FF8431", VA = "0x1FF8330", Slot = "28")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1FF8340", Offset = "0x1FF8441", VA = "0x1FF8340")]
	public TransformTweenTrack()
	{
	}
}
