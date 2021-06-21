using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000010 RID: 16
[Token(Token = "0x2000010")]
[Serializable]
public class TextSwitcherClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000025 RID: 37 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x17000006")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x205B9A0", Offset = "0x205BAA1", VA = "0x205B9A0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x205B9B0", Offset = "0x205BAB1", VA = "0x205B9B0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x205BA50", Offset = "0x205BB51", VA = "0x205BA50")]
	public TextSwitcherClip()
	{
	}

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x18")]
	public TextSwitcherBehaviour template;
}
