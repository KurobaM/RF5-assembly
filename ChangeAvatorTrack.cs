using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008BD RID: 2237
[Token(Token = "0x20005CC")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146840", Offset = "0x146941")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146840", Offset = "0x146941")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146840", Offset = "0x146941")]
public class ChangeAvatorTrack : TrackAsset
{
	// Token: 0x06003B3D RID: 15165 RVA: 0x00014C58 File Offset: 0x00012E58
	[Token(Token = "0x60031A2")]
	[Address(RVA = "0x1E82220", Offset = "0x1E82321", VA = "0x1E82220", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003B3E RID: 15166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031A3")]
	[Address(RVA = "0x1E82680", Offset = "0x1E82781", VA = "0x1E82680")]
	public ChangeAvatorTrack()
	{
	}
}
