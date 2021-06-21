using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x144910", Offset = "0x144A11")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x144910", Offset = "0x144A11")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x144910", Offset = "0x144A11")]
public class ScreenFaderTrack : TrackAsset
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x21DE5A0", Offset = "0x21DE6A1", VA = "0x21DE5A0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x21DE640", Offset = "0x21DE741", VA = "0x21DE640", Slot = "28")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x21DE650", Offset = "0x21DE751", VA = "0x21DE650")]
	public ScreenFaderTrack()
	{
	}
}
