using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200164C RID: 5708
	[Token(Token = "0x2000F88")]
	[Attribute(Name = "TrackClipTypeAttribute", RVA = "0x156E40", Offset = "0x156F41")]
	[Attribute(Name = "TrackColorAttribute", RVA = "0x156E40", Offset = "0x156F41")]
	[Serializable]
	public class VideoScriptPlayableTrack : TrackAsset
	{
		// Token: 0x06008177 RID: 33143 RVA: 0x0002E8D8 File Offset: 0x0002CAD8
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0x1E45C40", Offset = "0x1E45D41", VA = "0x1E45C40", Slot = "23")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0x1E45D90", Offset = "0x1E45E91", VA = "0x1E45D90")]
		public VideoScriptPlayableTrack()
		{
		}
	}
}
