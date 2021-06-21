using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008CB RID: 2251
[Token(Token = "0x20005D9")]
[Serializable]
public class DualworkLoopClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000887 RID: 2183
	// (get) Token: 0x06003B79 RID: 15225 RVA: 0x00014D48 File Offset: 0x00012F48
	[Token(Token = "0x170006CA")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x1E0E800", Offset = "0x1E0E901", VA = "0x1E0E800", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06003B7A RID: 15226 RVA: 0x00014D60 File Offset: 0x00012F60
	[Token(Token = "0x60031DC")]
	[Address(RVA = "0x1E0E810", Offset = "0x1E0E911", VA = "0x1E0E810", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003B7B RID: 15227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031DD")]
	[Address(RVA = "0x1E0E8B0", Offset = "0x1E0E9B1", VA = "0x1E0E8B0")]
	public DualworkLoopClip()
	{
	}
}
