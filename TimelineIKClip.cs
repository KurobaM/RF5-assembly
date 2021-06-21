using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008F7 RID: 2295
[Token(Token = "0x2000601")]
[Serializable]
public class TimelineIKClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x170008B6 RID: 2230
	// (get) Token: 0x06003C52 RID: 15442 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C53 RID: 15443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F7")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x60032A8")]
		[Address(RVA = "0x206CBF0", Offset = "0x206CCF1", VA = "0x206CBF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6AD0", Offset = "0x1A6BD1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60032A9")]
		[Address(RVA = "0x206CC00", Offset = "0x206CD01", VA = "0x206CC00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6AE0", Offset = "0x1A6BE1")]
		set
		{
		}
	}

	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x06003C54 RID: 15444 RVA: 0x000150F0 File Offset: 0x000132F0
	[Token(Token = "0x170006F8")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60032AA")]
		[Address(RVA = "0x206CC10", Offset = "0x206CD11", VA = "0x206CC10", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x00015108 File Offset: 0x00013308
	[Token(Token = "0x60032AB")]
	[Address(RVA = "0x206CC20", Offset = "0x206CD21", VA = "0x206CC20", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032AC")]
	[Address(RVA = "0x206CD00", Offset = "0x206CE01", VA = "0x206CD00")]
	public TimelineIKClip()
	{
	}

	// Token: 0x04007EC1 RID: 32449
	[Token(Token = "0x400726C")]
	[FieldOffset(Offset = "0x18")]
	public TimelineIKBehaviour template;

	// Token: 0x04007EC2 RID: 32450
	[Token(Token = "0x400726D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16ED90", Offset = "0x16EE91")]
	private GameObject <TrackTargetObject>k__BackingField;
}
