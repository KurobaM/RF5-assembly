using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008DB RID: 2267
[Token(Token = "0x20005E7")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146C40", Offset = "0x146D41")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146C40", Offset = "0x146D41")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146C40", Offset = "0x146D41")]
public class GrounderIKTrack : TrackAsset
{
	// Token: 0x06003BCC RID: 15308 RVA: 0x00014E80 File Offset: 0x00013080
	[Token(Token = "0x6003228")]
	[Address(RVA = "0x2041490", Offset = "0x2041591", VA = "0x2041490", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003BCD RID: 15309 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003229")]
	[Address(RVA = "0x20418A0", Offset = "0x20419A1", VA = "0x20418A0")]
	public GrounderIKTrack()
	{
	}
}
