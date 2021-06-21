using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008EA RID: 2282
[Token(Token = "0x20005F6")]
[Serializable]
public class SpringBoneInitClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x170008B0 RID: 2224
	// (get) Token: 0x06003C20 RID: 15392 RVA: 0x00015000 File Offset: 0x00013200
	[Token(Token = "0x170006F3")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600327C")]
		[Address(RVA = "0x2386B90", Offset = "0x2386C91", VA = "0x2386B90", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x170008B1 RID: 2225
	// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C22 RID: 15394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006F4")]
	public GameObject BindTarget
	{
		[Token(Token = "0x600327D")]
		[Address(RVA = "0x2386BA0", Offset = "0x2386CA1", VA = "0x2386BA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6A20", Offset = "0x1A6B21")]
		get
		{
			return null;
		}
		[Token(Token = "0x600327E")]
		[Address(RVA = "0x2386BB0", Offset = "0x2386CB1", VA = "0x2386BB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6A30", Offset = "0x1A6B31")]
		set
		{
		}
	}

	// Token: 0x06003C23 RID: 15395 RVA: 0x00015018 File Offset: 0x00013218
	[Token(Token = "0x600327F")]
	[Address(RVA = "0x2386BC0", Offset = "0x2386CC1", VA = "0x2386BC0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003C24 RID: 15396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003280")]
	[Address(RVA = "0x2386CE0", Offset = "0x2386DE1", VA = "0x2386CE0")]
	public SpringBoneInitClip()
	{
	}

	// Token: 0x04007E98 RID: 32408
	[Token(Token = "0x400724D")]
	[FieldOffset(Offset = "0x18")]
	public SpringBoneInitBehavior template;

	// Token: 0x04007E99 RID: 32409
	[Token(Token = "0x400724E")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16ED00", Offset = "0x16EE01")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E9A RID: 32410
	[Token(Token = "0x400724F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool IsKeepInit;
}
