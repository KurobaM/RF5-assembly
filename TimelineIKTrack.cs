using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008F9 RID: 2297
[Token(Token = "0x2000603")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x1470F0", Offset = "0x1471F1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x1470F0", Offset = "0x1471F1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x1470F0", Offset = "0x1471F1")]
public class TimelineIKTrack : TrackAsset
{
	// Token: 0x06003C5A RID: 15450 RVA: 0x00015120 File Offset: 0x00013320
	[Token(Token = "0x60032B0")]
	[Address(RVA = "0x206CFA0", Offset = "0x206D0A1", VA = "0x206CFA0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032B1")]
	[Address(RVA = "0x206D3F0", Offset = "0x206D4F1", VA = "0x206D3F0")]
	public TimelineIKTrack()
	{
	}
}
