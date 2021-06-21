using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008E8 RID: 2280
[Token(Token = "0x20005F4")]
[Serializable]
public class SpringBoneClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x170008AC RID: 2220
	// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00014FD0 File Offset: 0x000131D0
	[Token(Token = "0x170006EF")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600326D")]
		[Address(RVA = "0x2386720", Offset = "0x2386821", VA = "0x2386720", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x170008AD RID: 2221
	// (get) Token: 0x06003C12 RID: 15378 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C13 RID: 15379 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F0")]
	public GameObject BindTarget
	{
		[Token(Token = "0x600326E")]
		[Address(RVA = "0x2386730", Offset = "0x2386831", VA = "0x2386730")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A69C0", Offset = "0x1A6AC1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600326F")]
		[Address(RVA = "0x2386740", Offset = "0x2386841", VA = "0x2386740")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A69D0", Offset = "0x1A6AD1")]
		set
		{
		}
	}

	// Token: 0x06003C14 RID: 15380 RVA: 0x00014FE8 File Offset: 0x000131E8
	[Token(Token = "0x6003270")]
	[Address(RVA = "0x2386750", Offset = "0x2386851", VA = "0x2386750", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003C15 RID: 15381 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003271")]
	[Address(RVA = "0x2386870", Offset = "0x2386971", VA = "0x2386870")]
	public SpringBoneClip()
	{
	}

	// Token: 0x04007E91 RID: 32401
	[Token(Token = "0x4007246")]
	[FieldOffset(Offset = "0x18")]
	public SpringBoneBehavior template;

	// Token: 0x04007E92 RID: 32402
	[Token(Token = "0x4007247")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16ECB0", Offset = "0x16EDB1")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E93 RID: 32403
	[Token(Token = "0x4007248")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool StartEnable;

	// Token: 0x04007E94 RID: 32404
	[Token(Token = "0x4007249")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool EndEnable;
}
