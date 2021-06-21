using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Tantawowa.TimelineEvents
{
	// Token: 0x020010EE RID: 4334
	[Token(Token = "0x2000AE3")]
	[Attribute(Name = "TrackColorAttribute", RVA = "0x14A000", Offset = "0x14A101")]
	[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x14A000", Offset = "0x14A101")]
	[Attribute(Name = "TrackBindingTypeAttribute", RVA = "0x14A000", Offset = "0x14A101")]
	public class TimelineEventTrack : TrackAsset
	{
		// Token: 0x06006DC5 RID: 28101 RVA: 0x00025C98 File Offset: 0x00023E98
		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0x1FC2D50", Offset = "0x1FC2E51", VA = "0x1FC2D50", Slot = "23")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0x1FC31A0", Offset = "0x1FC32A1", VA = "0x1FC31A0")]
		public TimelineEventTrack()
		{
		}
	}
}
