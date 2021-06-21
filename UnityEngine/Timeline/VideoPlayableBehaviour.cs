using System;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Video;

namespace UnityEngine.Timeline
{
	// Token: 0x02001649 RID: 5705
	[Token(Token = "0x2000F85")]
	public class VideoPlayableBehaviour : PlayableBehaviour
	{
		// Token: 0x06008161 RID: 33121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD2")]
		[Address(RVA = "0x1E446E0", Offset = "0x1E447E1", VA = "0x1E446E0")]
		public void PrepareVideo()
		{
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD3")]
		[Address(RVA = "0x1E44B20", Offset = "0x1E44C21", VA = "0x1E44B20")]
		private void LoopPointReached(VideoPlayer vp)
		{
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD4")]
		[Address(RVA = "0x1E44B30", Offset = "0x1E44C31", VA = "0x1E44B30", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0x1E44E30", Offset = "0x1E44F31", VA = "0x1E44E30", Slot = "17")]
		public override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0x1E45000", Offset = "0x1E45101", VA = "0x1E45000", Slot = "18")]
		public override void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD7")]
		[Address(RVA = "0x1E45200", Offset = "0x1E45301", VA = "0x1E45200", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD8")]
		[Address(RVA = "0x1E45400", Offset = "0x1E45501", VA = "0x1E45400", Slot = "13")]
		public override void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD9")]
		[Address(RVA = "0x1E45410", Offset = "0x1E45511", VA = "0x1E45410", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADA")]
		[Address(RVA = "0x1E454B0", Offset = "0x1E455B1", VA = "0x1E454B0", Slot = "16")]
		public override void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADB")]
		[Address(RVA = "0x1E44EF0", Offset = "0x1E44FF1", VA = "0x1E44EF0")]
		public void PlayVideo()
		{
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADC")]
		[Address(RVA = "0x1E45170", Offset = "0x1E45271", VA = "0x1E45170")]
		public void PauseVideo()
		{
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADD")]
		[Address(RVA = "0x1E44A80", Offset = "0x1E44B81", VA = "0x1E44A80")]
		public void StopVideo()
		{
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADE")]
		[Address(RVA = "0x1E44CB0", Offset = "0x1E44DB1", VA = "0x1E44CB0")]
		private void SyncVideoToPlayable(Playable playable)
		{
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ADF")]
		[Address(RVA = "0x1E45550", Offset = "0x1E45651", VA = "0x1E45550")]
		public VideoPlayableBehaviour()
		{
		}

		// Token: 0x0401C20A RID: 115210
		[Token(Token = "0x40189DA")]
		[FieldOffset(Offset = "0x10")]
		public VideoPlayer videoPlayer;

		// Token: 0x0401C20B RID: 115211
		[Token(Token = "0x40189DB")]
		[FieldOffset(Offset = "0x18")]
		public VideoClip videoClip;

		// Token: 0x0401C20C RID: 115212
		[Token(Token = "0x40189DC")]
		[FieldOffset(Offset = "0x20")]
		public bool mute;

		// Token: 0x0401C20D RID: 115213
		[Token(Token = "0x40189DD")]
		[FieldOffset(Offset = "0x21")]
		public bool loop;

		// Token: 0x0401C20E RID: 115214
		[Token(Token = "0x40189DE")]
		[FieldOffset(Offset = "0x28")]
		public double preloadTime;

		// Token: 0x0401C20F RID: 115215
		[Token(Token = "0x40189DF")]
		[FieldOffset(Offset = "0x30")]
		public double clipInTime;

		// Token: 0x0401C210 RID: 115216
		[Token(Token = "0x40189E0")]
		[FieldOffset(Offset = "0x38")]
		private bool playedOnce;

		// Token: 0x0401C211 RID: 115217
		[Token(Token = "0x40189E1")]
		[FieldOffset(Offset = "0x39")]
		private bool preparing;
	}
}
