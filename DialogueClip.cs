using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008C3 RID: 2243
[Token(Token = "0x20005D2")]
[Serializable]
public class DialogueClip : PlayableAsset, ITimelineClipAsset
{
	// Token: 0x1700087F RID: 2175
	// (get) Token: 0x06003B53 RID: 15187 RVA: 0x00014CB8 File Offset: 0x00012EB8
	[Token(Token = "0x170006C2")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x60031B8")]
		[Address(RVA = "0x1DFABD0", Offset = "0x1DFACD1", VA = "0x1DFABD0", Slot = "9")]
		get
		{
			return ClipCaps.None;
		}
	}

	// Token: 0x17000880 RID: 2176
	// (get) Token: 0x06003B54 RID: 15188 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B55 RID: 15189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C3")]
	public GameObject BindTarget
	{
		[Token(Token = "0x60031B9")]
		[Address(RVA = "0x1DFABE0", Offset = "0x1DFACE1", VA = "0x1DFABE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6530", Offset = "0x1A6631")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031BA")]
		[Address(RVA = "0x1DFABF0", Offset = "0x1DFACF1", VA = "0x1DFABF0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6540", Offset = "0x1A6641")]
		set
		{
		}
	}

	// Token: 0x06003B56 RID: 15190 RVA: 0x00014CD0 File Offset: 0x00012ED0
	[Token(Token = "0x60031BB")]
	[Address(RVA = "0x1DFAC00", Offset = "0x1DFAD01", VA = "0x1DFAC00", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	// Token: 0x06003B57 RID: 15191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x1DFACA0", Offset = "0x1DFADA1", VA = "0x1DFACA0")]
	public DialogueClip()
	{
	}

	// Token: 0x04007E27 RID: 32295
	[Token(Token = "0x40071E3")]
	[FieldOffset(Offset = "0x18")]
	public DialogueBehaviour template;

	// Token: 0x04007E28 RID: 32296
	[Token(Token = "0x40071E4")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E870", Offset = "0x16E971")]
	private GameObject <BindTarget>k__BackingField;
}
