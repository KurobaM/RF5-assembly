using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008D9 RID: 2265
[Token(Token = "0x20005E5")]
[Serializable]
public class GrounderIKClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x17000898 RID: 2200
	// (get) Token: 0x06003BC6 RID: 15302 RVA: 0x00014E50 File Offset: 0x00013050
	[Token(Token = "0x170006DB")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x20412C0", Offset = "0x20413C1", VA = "0x20412C0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x17000899 RID: 2201
	// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006DC")]
	public GameObject BindTarget
	{
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x20412D0", Offset = "0x20413D1", VA = "0x20412D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A67E0", Offset = "0x1A68E1")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x20412E0", Offset = "0x20413E1", VA = "0x20412E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A67F0", Offset = "0x1A68F1")]
		set
		{
		}
	}

	// Token: 0x06003BC9 RID: 15305 RVA: 0x00014E68 File Offset: 0x00013068
	[Token(Token = "0x6003225")]
	[Address(RVA = "0x20412F0", Offset = "0x20413F1", VA = "0x20412F0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003BCA RID: 15306 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003226")]
	[Address(RVA = "0x2041400", Offset = "0x2041501", VA = "0x2041400")]
	public GrounderIKClip()
	{
	}

	// Token: 0x04007E67 RID: 32359
	[Token(Token = "0x400721C")]
	[FieldOffset(Offset = "0x18")]
	public GrounderIKBehavior template;

	// Token: 0x04007E68 RID: 32360
	[Token(Token = "0x400721D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EAE0", Offset = "0x16EBE1")]
	private GameObject <BindTarget>k__BackingField;
}
