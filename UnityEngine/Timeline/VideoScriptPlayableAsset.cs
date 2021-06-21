using System;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace UnityEngine.Timeline
{
	// Token: 0x0200164B RID: 5707
	[Token(Token = "0x2000F87")]
	[Serializable]
	public class VideoScriptPlayableAsset : PlayableAsset
	{
		// Token: 0x06008175 RID: 33141 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		[Token(Token = "0x6006AE6")]
		[Address(RVA = "0x1E45AE0", Offset = "0x1E45BE1", VA = "0x1E45AE0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0x1E45C20", Offset = "0x1E45D21", VA = "0x1E45C20")]
		public VideoScriptPlayableAsset()
		{
		}

		// Token: 0x0401C214 RID: 115220
		[Token(Token = "0x40189E4")]
		[FieldOffset(Offset = "0x18")]
		public ExposedReference<VideoPlayer> videoPlayer;

		// Token: 0x0401C215 RID: 115221
		[Token(Token = "0x40189E5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Attribute(Name = "NotKeyableAttribute", RVA = "0x194C50", Offset = "0x194D51")]
		public VideoClip videoClip;

		// Token: 0x0401C216 RID: 115222
		[Token(Token = "0x40189E6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Attribute(Name = "NotKeyableAttribute", RVA = "0x194C90", Offset = "0x194D91")]
		public bool mute;

		// Token: 0x0401C217 RID: 115223
		[Token(Token = "0x40189E7")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		[Attribute(Name = "NotKeyableAttribute", RVA = "0x194CD0", Offset = "0x194DD1")]
		public bool loop;

		// Token: 0x0401C218 RID: 115224
		[Token(Token = "0x40189E8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Attribute(Name = "NotKeyableAttribute", RVA = "0x194D10", Offset = "0x194E11")]
		public double preloadTime;

		// Token: 0x0401C219 RID: 115225
		[Token(Token = "0x40189E9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "NotKeyableAttribute", RVA = "0x194D50", Offset = "0x194E51")]
		public double clipInTime;
	}
}
