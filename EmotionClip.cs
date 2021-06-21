using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008CF RID: 2255
[Token(Token = "0x20005DD")]
[Serializable]
public class EmotionClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x1700088C RID: 2188
	// (get) Token: 0x06003B8C RID: 15244 RVA: 0x00014D90 File Offset: 0x00012F90
	[Token(Token = "0x170006CF")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x22AF1D0", Offset = "0x22AF2D1", VA = "0x22AF1D0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x1700088D RID: 2189
	// (get) Token: 0x06003B8D RID: 15245 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B8E RID: 15246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D0")]
	public GameObject BindTarget
	{
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x22AF1E0", Offset = "0x22AF2E1", VA = "0x22AF1E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6690", Offset = "0x1A6791")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x22AF1F0", Offset = "0x22AF2F1", VA = "0x22AF1F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A66A0", Offset = "0x1A67A1")]
		set
		{
		}
	}

	// Token: 0x06003B8F RID: 15247 RVA: 0x00014DA8 File Offset: 0x00012FA8
	[Token(Token = "0x60031F1")]
	[Address(RVA = "0x22AF200", Offset = "0x22AF301", VA = "0x22AF200", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003B90 RID: 15248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031F2")]
	[Address(RVA = "0x22AF330", Offset = "0x22AF431", VA = "0x22AF330")]
	public EmotionClip()
	{
	}

	// Token: 0x04007E3C RID: 32316
	[Token(Token = "0x40071F6")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public EmotionType EmotionType;

	// Token: 0x04007E3D RID: 32317
	[Token(Token = "0x40071F7")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public Vector3 Offset;

	// Token: 0x04007E3E RID: 32318
	[Token(Token = "0x40071F8")]
	[FieldOffset(Offset = "0x28")]
	private EmotionBehavior EmotionBehavior;

	// Token: 0x04007E3F RID: 32319
	[Token(Token = "0x40071F9")]
	[FieldOffset(Offset = "0x30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E980", Offset = "0x16EA81")]
	private GameObject <BindTarget>k__BackingField;
}
