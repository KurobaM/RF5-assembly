using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[Serializable]
public class NavMeshAgentControlClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000013 RID: 19 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x17000004")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1E22B30", Offset = "0x1E22C31", VA = "0x1E22B30", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1E22B40", Offset = "0x1E22C41", VA = "0x1E22B40", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1E22C60", Offset = "0x1E22D61", VA = "0x1E22C60")]
	public NavMeshAgentControlClip()
	{
	}

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	public ExposedReference<Transform> destination;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "HideInInspector", RVA = "0x15B050", Offset = "0x15B151")]
	public NavMeshAgentControlBehaviour template;
}
