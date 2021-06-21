using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008EC RID: 2284
[Token(Token = "0x20005F8")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146FB0", Offset = "0x1470B1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146FB0", Offset = "0x1470B1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146FB0", Offset = "0x1470B1")]
public class SpringBoneTrack : TrackAsset
{
	// Token: 0x06003C27 RID: 15399 RVA: 0x00015048 File Offset: 0x00013248
	[Token(Token = "0x6003283")]
	[Address(RVA = "0x23871E0", Offset = "0x23872E1", VA = "0x23871E0", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003C28 RID: 15400 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003284")]
	[Address(RVA = "0x23875F0", Offset = "0x23876F1", VA = "0x23875F0")]
	public SpringBoneTrack()
	{
	}
}
