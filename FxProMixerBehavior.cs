using System;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008D6 RID: 2262
[Token(Token = "0x20005E2")]
public class FxProMixerBehavior : PlayableBehaviour
{
	// Token: 0x17000894 RID: 2196
	// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BB6 RID: 15286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D7")]
	public TimelineClip[] Clips
	{
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x23F6B40", Offset = "0x23F6C41", VA = "0x23F6B40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6760", Offset = "0x1A6861")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x23F6B50", Offset = "0x23F6C51", VA = "0x23F6B50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6770", Offset = "0x1A6871")]
		set
		{
		}
	}

	// Token: 0x17000895 RID: 2197
	// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003BB8 RID: 15288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006D8")]
	public PlayableDirector Director
	{
		[Token(Token = "0x6003213")]
		[Address(RVA = "0x23F6B60", Offset = "0x23F6C61", VA = "0x23F6B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6780", Offset = "0x1A6881")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003214")]
		[Address(RVA = "0x23F6B70", Offset = "0x23F6C71", VA = "0x23F6B70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6790", Offset = "0x1A6891")]
		set
		{
		}
	}

	// Token: 0x06003BB9 RID: 15289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003215")]
	[Address(RVA = "0x23F6B80", Offset = "0x23F6C81", VA = "0x23F6B80", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003BBA RID: 15290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003216")]
	[Address(RVA = "0x23F6E50", Offset = "0x23F6F51", VA = "0x23F6E50")]
	public FxProMixerBehavior()
	{
	}

	// Token: 0x04007E61 RID: 32353
	[Token(Token = "0x4007216")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EA80", Offset = "0x16EB81")]
	private TimelineClip[] <Clips>k__BackingField;

	// Token: 0x04007E62 RID: 32354
	[Token(Token = "0x4007217")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16EA90", Offset = "0x16EB91")]
	private PlayableDirector <Director>k__BackingField;
}
