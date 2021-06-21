using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008EB RID: 2283
[Token(Token = "0x20005F7")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146F00", Offset = "0x147001")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146F00", Offset = "0x147001")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146F00", Offset = "0x147001")]
public class SpringBoneInitTrack : TrackAsset
{
	// Token: 0x06003C25 RID: 15397 RVA: 0x00015030 File Offset: 0x00013230
	[Token(Token = "0x6003281")]
	[Address(RVA = "0x2386D60", Offset = "0x2386E61", VA = "0x2386D60", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003C26 RID: 15398 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003282")]
	[Address(RVA = "0x2387170", Offset = "0x2387271", VA = "0x2387170")]
	public SpringBoneInitTrack()
	{
	}
}
