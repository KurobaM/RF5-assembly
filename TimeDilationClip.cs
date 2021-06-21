using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[Serializable]
public class TimeDilationClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600002F RID: 47 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x17000007")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x20605B0", Offset = "0x20606B1", VA = "0x20605B0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x20605C0", Offset = "0x20606C1", VA = "0x20605C0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2060660", Offset = "0x2060761", VA = "0x2060660")]
	public TimeDilationClip()
	{
	}

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x18")]
	public TimeDilationBehaviour template;
}
