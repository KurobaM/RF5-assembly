using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x144A80", Offset = "0x144B81")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x144A80", Offset = "0x144B81")]
public class TimeDilationTrack : TrackAsset
{
	// Token: 0x06000037 RID: 55 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x20608F0", Offset = "0x20609F1", VA = "0x20608F0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2060990", Offset = "0x2060A91", VA = "0x2060990")]
	public TimeDilationTrack()
	{
	}
}
