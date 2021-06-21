using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008D5 RID: 2261
[Token(Token = "0x20005E1")]
[Serializable]
public class FxProClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000892 RID: 2194
	// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D5")]
	public FxPro FxPro
	{
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x23F68B0", Offset = "0x23F69B1", VA = "0x23F68B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6740", Offset = "0x1A6841")]
		get
		{
			return null;
		}
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x23F68C0", Offset = "0x23F69C1", VA = "0x23F68C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6750", Offset = "0x1A6851")]
		set
		{
		}
	}

	// Token: 0x17000893 RID: 2195
	// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x00014E08 File Offset: 0x00013008
	[Token(Token = "0x170006D6")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x23F68D0", Offset = "0x23F69D1", VA = "0x23F68D0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x06003BB3 RID: 15283 RVA: 0x00014E20 File Offset: 0x00013020
	[Token(Token = "0x600320F")]
	[Address(RVA = "0x23F68E0", Offset = "0x23F69E1", VA = "0x23F68E0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003BB4 RID: 15284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003210")]
	[Address(RVA = "0x23F6A40", Offset = "0x23F6B41", VA = "0x23F6A40")]
	public FxProClip()
	{
	}

	// Token: 0x04007E5C RID: 32348
	[Token(Token = "0x4007211")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EA70", Offset = "0x16EB71")]
	private FxPro <FxPro>k__BackingField;

	// Token: 0x04007E5D RID: 32349
	[Token(Token = "0x4007212")]
	[FieldOffset(Offset = "0x20")]
	public bool IsChangeFocusTarget;

	// Token: 0x04007E5E RID: 32350
	[Token(Token = "0x4007213")]
	[FieldOffset(Offset = "0x28")]
	public ExposedReference<Transform> FocusTargetStart;

	// Token: 0x04007E5F RID: 32351
	[Token(Token = "0x4007214")]
	[FieldOffset(Offset = "0x38")]
	public ExposedReference<Transform> FocusTargetEnd;

	// Token: 0x04007E60 RID: 32352
	[Token(Token = "0x4007215")]
	[FieldOffset(Offset = "0x48")]
	public FxProBehaviour FxProBehaviour;
}
