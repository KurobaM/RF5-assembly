using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008E5 RID: 2277
[Token(Token = "0x20005F1")]
[Serializable]
public class RF_AudioClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x170008A6 RID: 2214
	// (get) Token: 0x06003BFD RID: 15357 RVA: 0x00014F58 File Offset: 0x00013158
	[Token(Token = "0x170006E9")]
	public override double duration
	{
		[Token(Token = "0x6003259")]
		[Address(RVA = "0x1F396B0", Offset = "0x1F397B1", VA = "0x1F396B0", Slot = "7")]
		get
		{
			return 0.0;
		}
	}

	// Token: 0x170008A7 RID: 2215
	// (get) Token: 0x06003BFE RID: 15358 RVA: 0x00014F70 File Offset: 0x00013170
	[Token(Token = "0x170006EA")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600325A")]
		[Address(RVA = "0x1F396D0", Offset = "0x1F397D1", VA = "0x1F396D0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x170008A8 RID: 2216
	// (get) Token: 0x06003BFF RID: 15359 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C00 RID: 15360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006EB")]
	public GameObject BindTarget
	{
		[Token(Token = "0x600325B")]
		[Address(RVA = "0x1F396E0", Offset = "0x1F397E1", VA = "0x1F396E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6940", Offset = "0x1A6A41")]
		get
		{
			return null;
		}
		[Token(Token = "0x600325C")]
		[Address(RVA = "0x1F396F0", Offset = "0x1F397F1", VA = "0x1F396F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6950", Offset = "0x1A6A51")]
		set
		{
		}
	}

	// Token: 0x06003C01 RID: 15361 RVA: 0x00014F88 File Offset: 0x00013188
	[Token(Token = "0x600325D")]
	[Address(RVA = "0x1F39700", Offset = "0x1F39801", VA = "0x1F39700", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003C02 RID: 15362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600325E")]
	[Address(RVA = "0x1F39840", Offset = "0x1F39941", VA = "0x1F39840")]
	public RF_AudioClip()
	{
	}

	// Token: 0x04007E84 RID: 32388
	[Token(Token = "0x4007239")]
	[FieldOffset(Offset = "0x18")]
	public RF_AudioBehaviour RF_AudioBehaviour;

	// Token: 0x04007E85 RID: 32389
	[Token(Token = "0x400723A")]
	[FieldOffset(Offset = "0x20")]
	public ExposedReference<Transform> TargetTransform;

	// Token: 0x04007E86 RID: 32390
	[Token(Token = "0x400723B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string SoundIDString;

	// Token: 0x04007E87 RID: 32391
	[Token(Token = "0x400723C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public SoundID SoundID;

	// Token: 0x04007E88 RID: 32392
	[Token(Token = "0x400723D")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public bool IsLoop;

	// Token: 0x04007E89 RID: 32393
	[Token(Token = "0x400723E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x16EC20", Offset = "0x16ED21")]
	public float Volume;

	// Token: 0x04007E8A RID: 32394
	[Token(Token = "0x400723F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private double LastDuration;

	// Token: 0x04007E8B RID: 32395
	[Token(Token = "0x4007240")]
	[FieldOffset(Offset = "0x50")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EC70", Offset = "0x16ED71")]
	private GameObject <BindTarget>k__BackingField;
}
