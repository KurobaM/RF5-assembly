using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008D7 RID: 2263
[Token(Token = "0x20005E3")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146B80", Offset = "0x146C81")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146B80", Offset = "0x146C81")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146B80", Offset = "0x146C81")]
public class FxProTrack : TrackAsset
{
	// Token: 0x06003BBB RID: 15291 RVA: 0x00014E38 File Offset: 0x00013038
	[Token(Token = "0x6003217")]
	[Address(RVA = "0x23F9040", Offset = "0x23F9141", VA = "0x23F9040", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003BBC RID: 15292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003218")]
	[Address(RVA = "0x23F92A0", Offset = "0x23F93A1", VA = "0x23F92A0")]
	public FxProTrack()
	{
	}
}
