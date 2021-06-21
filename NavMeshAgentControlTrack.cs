using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x144850", Offset = "0x144951")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x144850", Offset = "0x144951")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x144850", Offset = "0x144951")]
public class NavMeshAgentControlTrack : TrackAsset
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1E23050", Offset = "0x1E23151", VA = "0x1E23050", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1E230F0", Offset = "0x1E231F1", VA = "0x1E230F0")]
	public NavMeshAgentControlTrack()
	{
	}
}
