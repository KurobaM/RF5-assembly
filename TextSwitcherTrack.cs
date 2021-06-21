using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x1449C0", Offset = "0x144AC1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x1449C0", Offset = "0x144AC1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x1449C0", Offset = "0x144AC1")]
public class TextSwitcherTrack : TrackAsset
{
	// Token: 0x0600002B RID: 43 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x205C050", Offset = "0x205C151", VA = "0x205C050", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x205C0F0", Offset = "0x205C1F1", VA = "0x205C0F0", Slot = "28")]
	public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x205C100", Offset = "0x205C201", VA = "0x205C100")]
	public TextSwitcherTrack()
	{
	}
}
