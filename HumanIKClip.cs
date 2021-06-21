using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008E1 RID: 2273
[Token(Token = "0x20005ED")]
[Serializable]
public class HumanIKClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x170008A4 RID: 2212
	// (get) Token: 0x06003BF0 RID: 15344 RVA: 0x00014F10 File Offset: 0x00013110
	[Token(Token = "0x170006E7")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x600324C")]
		[Address(RVA = "0x20A7370", Offset = "0x20A7471", VA = "0x20A7370", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x170008A5 RID: 2213
	// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006E8")]
	public GameObject BindTarget
	{
		[Token(Token = "0x600324D")]
		[Address(RVA = "0x20A7380", Offset = "0x20A7481", VA = "0x20A7380")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6920", Offset = "0x1A6A21")]
		get
		{
			return null;
		}
		[Token(Token = "0x600324E")]
		[Address(RVA = "0x20A7390", Offset = "0x20A7491", VA = "0x20A7390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6930", Offset = "0x1A6A31")]
		set
		{
		}
	}

	// Token: 0x06003BF3 RID: 15347 RVA: 0x00014F28 File Offset: 0x00013128
	[Token(Token = "0x600324F")]
	[Address(RVA = "0x20A73A0", Offset = "0x20A74A1", VA = "0x20A73A0", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003BF4 RID: 15348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003250")]
	[Address(RVA = "0x20A74E0", Offset = "0x20A75E1", VA = "0x20A74E0")]
	public HumanIKClip()
	{
	}

	// Token: 0x04007E79 RID: 32377
	[Token(Token = "0x400722E")]
	[FieldOffset(Offset = "0x18")]
	public HumanIKBehavior template;

	// Token: 0x04007E7A RID: 32378
	[Token(Token = "0x400722F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EBB0", Offset = "0x16ECB1")]
	private GameObject <BindTarget>k__BackingField;

	// Token: 0x04007E7B RID: 32379
	[Token(Token = "0x4007230")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool StartIK;

	// Token: 0x04007E7C RID: 32380
	[Token(Token = "0x4007231")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool EndIK;

	// Token: 0x04007E7D RID: 32381
	[Token(Token = "0x4007232")]
	[FieldOffset(Offset = "0x30")]
	private HumanIKBehavior humanIKBehavior;
}
