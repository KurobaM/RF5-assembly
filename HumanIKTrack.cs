using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008E3 RID: 2275
[Token(Token = "0x20005EF")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146DA0", Offset = "0x146EA1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146DA0", Offset = "0x146EA1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146DA0", Offset = "0x146EA1")]
public class HumanIKTrack : TrackAsset
{
	// Token: 0x06003BF6 RID: 15350 RVA: 0x00014F40 File Offset: 0x00013140
	[Token(Token = "0x6003252")]
	[Address(RVA = "0x20A7580", Offset = "0x20A7681", VA = "0x20A7580", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003253")]
	[Address(RVA = "0x20A7990", Offset = "0x20A7A91", VA = "0x20A7990")]
	public HumanIKTrack()
	{
	}
}
