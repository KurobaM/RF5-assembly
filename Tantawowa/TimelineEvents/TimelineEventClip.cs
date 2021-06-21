using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace Tantawowa.TimelineEvents
{
	// Token: 0x020010EC RID: 4332
	[Token(Token = "0x2000AE1")]
	[Serializable]
	public class TimelineEventClip : PlayableAsset, ITimelineClipAsset
	{
		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06006DBF RID: 28095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006DC0 RID: 28096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AE8")]
		public GameObject TrackTargetObject
		{
			[Token(Token = "0x6005B08")]
			[Address(RVA = "0x1FC2BB0", Offset = "0x1FC2CB1", VA = "0x1FC2BB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE9B0", Offset = "0x1AEAB1")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005B09")]
			[Address(RVA = "0x1FC2BC0", Offset = "0x1FC2CC1", VA = "0x1FC2BC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AE9C0", Offset = "0x1AEAC1")]
			set
			{
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06006DC1 RID: 28097 RVA: 0x00025C68 File Offset: 0x00023E68
		[Token(Token = "0x17000AE9")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6005B0A")]
			[Address(RVA = "0x1FC2BD0", Offset = "0x1FC2CD1", VA = "0x1FC2BD0", Slot = "9")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x00025C80 File Offset: 0x00023E80
		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0x1FC2BE0", Offset = "0x1FC2CE1", VA = "0x1FC2BE0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0x1FC2CC0", Offset = "0x1FC2DC1", VA = "0x1FC2CC0")]
		public TimelineEventClip()
		{
		}

		// Token: 0x0401755B RID: 95579
		[Token(Token = "0x401403B")]
		[FieldOffset(Offset = "0x18")]
		public TimelineEventBehaviour template;

		// Token: 0x0401755C RID: 95580
		[Token(Token = "0x401403C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181210", Offset = "0x181311")]
		private GameObject <TrackTargetObject>k__BackingField;
	}
}
