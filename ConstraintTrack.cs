using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008C1 RID: 2241
[Token(Token = "0x20005D0")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x1468F0", Offset = "0x1469F1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x1468F0", Offset = "0x1469F1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x1468F0", Offset = "0x1469F1")]
public class ConstraintTrack : TrackAsset
{
	// Token: 0x06003B4D RID: 15181 RVA: 0x00014CA0 File Offset: 0x00012EA0
	[Token(Token = "0x60031B2")]
	[Address(RVA = "0x20E1320", Offset = "0x20E1421", VA = "0x20E1320", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003B4E RID: 15182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031B3")]
	[Address(RVA = "0x20E1730", Offset = "0x20E1831", VA = "0x20E1730")]
	public ConstraintTrack()
	{
	}
}
