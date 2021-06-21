using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
[Serializable]
public class ScreenFaderClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600001B RID: 27 RVA: 0x00002118 File Offset: 0x00000318
	[Token(Token = "0x17000005")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x21DE070", Offset = "0x21DE171", VA = "0x21DE070", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x21DE080", Offset = "0x21DE181", VA = "0x21DE080", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x21DE120", Offset = "0x21DE221", VA = "0x21DE120")]
	public ScreenFaderClip()
	{
	}

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x18")]
	public ScreenFaderBehaviour template;
}
