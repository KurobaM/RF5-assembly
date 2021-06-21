using System;
using Il2CppDummyDll;
using UnityEngine.Playables;
using UnityEngine.Timeline;

// Token: 0x020008CA RID: 2250
[Token(Token = "0x20005D8")]
[Serializable]
public class DualworkLoopBehaviour : PlayableBehaviour
{
	// Token: 0x17000885 RID: 2181
	// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B74 RID: 15220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C8")]
	public PlayableDirector director
	{
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x1E0E7A0", Offset = "0x1E0E8A1", VA = "0x1E0E7A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A65D0", Offset = "0x1A66D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x1E0E7B0", Offset = "0x1E0E8B1", VA = "0x1E0E7B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A65E0", Offset = "0x1A66E1")]
		set
		{
		}
	}

	// Token: 0x17000886 RID: 2182
	// (get) Token: 0x06003B75 RID: 15221 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003B76 RID: 15222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170006C9")]
	public DualworkLoopTrack Track
	{
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x1E0E7C0", Offset = "0x1E0E8C1", VA = "0x1E0E7C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A65F0", Offset = "0x1A66F1")]
		get
		{
			return null;
		}
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0x1E0E7D0", Offset = "0x1E0E8D1", VA = "0x1E0E7D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A6600", Offset = "0x1A6701")]
		set
		{
		}
	}

	// Token: 0x06003B77 RID: 15223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031D9")]
	[Address(RVA = "0x1E0E7E0", Offset = "0x1E0E8E1", VA = "0x1E0E7E0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B78 RID: 15224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031DA")]
	[Address(RVA = "0x1E0E7F0", Offset = "0x1E0E8F1", VA = "0x1E0E7F0")]
	public DualworkLoopBehaviour()
	{
	}

	// Token: 0x04007E32 RID: 32306
	[Token(Token = "0x40071EC")]
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E8F0", Offset = "0x16E9F1")]
	private PlayableDirector <director>k__BackingField;

	// Token: 0x04007E33 RID: 32307
	[Token(Token = "0x40071ED")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16E900", Offset = "0x16EA01")]
	private DualworkLoopTrack <Track>k__BackingField;

	// Token: 0x04007E34 RID: 32308
	[Token(Token = "0x40071EE")]
	[FieldOffset(Offset = "0x20")]
	[NonSerialized]
	public TimelineClip Clip;
}
