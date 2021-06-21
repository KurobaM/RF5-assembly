using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008C4 RID: 2244
[Token(Token = "0x20005D3")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x1469A0", Offset = "0x146AA1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x1469A0", Offset = "0x146AA1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x1469A0", Offset = "0x146AA1")]
public class DialogueTrack : TrackAsset
{
	// Token: 0x06003B58 RID: 15192 RVA: 0x00014CE8 File Offset: 0x00012EE8
	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x1DFAD20", Offset = "0x1DFAE21", VA = "0x1DFAD20", Slot = "31")]
	protected override Playable CreatePlayable(PlayableGraph graph, GameObject gameObject, TimelineClip clip)
	{
		return default(Playable);
	}

	// Token: 0x06003B59 RID: 15193 RVA: 0x00014D00 File Offset: 0x00012F00
	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x1DFAD30", Offset = "0x1DFAE31", VA = "0x1DFAD30", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003B5A RID: 15194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x1DFB110", Offset = "0x1DFB211", VA = "0x1DFB110")]
	public DialogueTrack()
	{
	}
}
