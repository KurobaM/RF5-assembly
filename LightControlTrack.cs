using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x144790", Offset = "0x144891")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x144790", Offset = "0x144891")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x144790", Offset = "0x144891")]
public class LightControlTrack : TrackAsset
{
	// Token: 0x0600000E RID: 14 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x23104A0", Offset = "0x23105A1", VA = "0x23104A0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2310540", Offset = "0x2310641", VA = "0x2310540", Slot = "28")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2310550", Offset = "0x2310651", VA = "0x2310550")]
	public LightControlTrack()
	{
	}
}
