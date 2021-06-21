using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x02000019 RID: 25
[Token(Token = "0x2000018")]
[Serializable]
public class TransformTweenClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600003D RID: 61 RVA: 0x00002220 File Offset: 0x00000420
	[Token(Token = "0x17000008")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2076130", Offset = "0x2076231", VA = "0x2076130", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002238 File Offset: 0x00000438
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2076140", Offset = "0x2076241", VA = "0x2076140", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2076290", Offset = "0x2076391", VA = "0x2076290")]
	public TransformTweenClip()
	{
	}

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x18")]
	public TransformTweenBehaviour template;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> startLocation;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x30")]
	public ExposedReference<Transform> endLocation;
}
