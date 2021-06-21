using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[Serializable]
public class LightControlClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000008 RID: 8 RVA: 0x00002088 File Offset: 0x00000288
	[Token(Token = "0x17000003")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x230FE70", Offset = "0x230FF71", VA = "0x230FE70", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000020A0 File Offset: 0x000002A0
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x230FE80", Offset = "0x230FF81", VA = "0x230FE80", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x230FF20", Offset = "0x2310021", VA = "0x230FF20")]
	public LightControlClip()
	{
	}

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x18")]
	public LightControlBehaviour template;
}
