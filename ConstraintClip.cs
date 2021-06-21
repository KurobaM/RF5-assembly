using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008BF RID: 2239
[Token(Token = "0x20005CE")]
[Serializable]
public class ConstraintClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x1700087D RID: 2173
	// (get) Token: 0x06003B47 RID: 15175 RVA: 0x00014C70 File Offset: 0x00012E70
	[Token(Token = "0x170006C0")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60031AC")]
		[Address(RVA = "0x20E1150", Offset = "0x20E1251", VA = "0x20E1150", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x1700087E RID: 2174
	// (get) Token: 0x06003B48 RID: 15176 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B49 RID: 15177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C1")]
	public GameObject BindTarget
	{
		[Token(Token = "0x60031AD")]
		[Address(RVA = "0x20E1160", Offset = "0x20E1261", VA = "0x20E1160")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6510", Offset = "0x1A6611")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x20E1170", Offset = "0x20E1271", VA = "0x20E1170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6520", Offset = "0x1A6621")]
		set
		{
		}
	}

	// Token: 0x06003B4A RID: 15178 RVA: 0x00014C88 File Offset: 0x00012E88
	[Token(Token = "0x60031AF")]
	[Address(RVA = "0x20E1180", Offset = "0x20E1281", VA = "0x20E1180", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003B4B RID: 15179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x20E1290", Offset = "0x20E1391", VA = "0x20E1290")]
	public ConstraintClip()
	{
	}

	// Token: 0x04007E1F RID: 32287
	[Token(Token = "0x40071DB")]
	[FieldOffset(Offset = "0x18")]
	public ConstraintBehavior template;

	// Token: 0x04007E20 RID: 32288
	[Token(Token = "0x40071DC")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E860", Offset = "0x16E961")]
	private GameObject <BindTarget>k__BackingField;
}
