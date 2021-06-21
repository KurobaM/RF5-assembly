using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008DF RID: 2271
[Token(Token = "0x20005EB")]
[Attribute(Name = "TrackColorAttribute", RVA = "0x146CF0", Offset = "0x146DF1")]
[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x146CF0", Offset = "0x146DF1")]
[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x146CF0", Offset = "0x146DF1")]
public class HumanEquipTrack : TrackAsset
{
	// Token: 0x06003BE2 RID: 15330 RVA: 0x00014EC8 File Offset: 0x000130C8
	[Token(Token = "0x600323E")]
	[Address(RVA = "0x20A3530", Offset = "0x20A3631", VA = "0x20A3530", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	// Token: 0x06003BE3 RID: 15331 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600323F")]
	[Address(RVA = "0x20A3940", Offset = "0x20A3A41", VA = "0x20A3940")]
	public HumanEquipTrack()
	{
	}
}
