using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200164A RID: 5706
	[Token(Token = "0x2000F86")]
	public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour
	{
		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x0600816F RID: 33135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008170 RID: 33136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBB")]
		internal PlayableDirector director
		{
			[Token(Token = "0x6006AE0")]
			[Address(RVA = "0x1E45570", Offset = "0x1E45671", VA = "0x1E45570")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE1")]
			[Address(RVA = "0x1E45580", Offset = "0x1E45681", VA = "0x1E45580")]
			set
			{
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06008171 RID: 33137 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008172 RID: 33138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BBC")]
		internal IEnumerable<TimelineClip> clips
		{
			[Token(Token = "0x6006AE2")]
			[Address(RVA = "0x1E45590", Offset = "0x1E45691", VA = "0x1E45590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE3")]
			[Address(RVA = "0x1E455A0", Offset = "0x1E456A1", VA = "0x1E455A0")]
			set
			{
			}
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE4")]
		[Address(RVA = "0x1E455B0", Offset = "0x1E456B1", VA = "0x1E455B0", Slot = "20")]
		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AE5")]
		[Address(RVA = "0x1E45AD0", Offset = "0x1E45BD1", VA = "0x1E45AD0")]
		public VideoSchedulerPlayableBehaviour()
		{
		}

		// Token: 0x0401C212 RID: 115218
		[Token(Token = "0x40189E2")]
		[FieldOffset(Offset = "0x10")]
		private IEnumerable<TimelineClip> m_Clips;

		// Token: 0x0401C213 RID: 115219
		[Token(Token = "0x40189E3")]
		[FieldOffset(Offset = "0x18")]
		private PlayableDirector m_Director;
	}
}
