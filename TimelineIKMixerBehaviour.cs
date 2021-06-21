using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

// Token: 0x020008F8 RID: 2296
[Token(Token = "0x2000602")]
public class TimelineIKMixerBehaviour : PlayableBehaviour
{
	// Token: 0x06003C57 RID: 15447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032AD")]
	[Address(RVA = "0x206CD80", Offset = "0x206CE81", VA = "0x206CD80", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032AE")]
	[Address(RVA = "0x206CE50", Offset = "0x206CF51", VA = "0x206CE50", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032AF")]
	[Address(RVA = "0x206CF90", Offset = "0x206D091", VA = "0x206CF90")]
	public TimelineIKMixerBehaviour()
	{
	}

	// Token: 0x04007EC3 RID: 32451
	[Token(Token = "0x400726E")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, double> markerClips;

	// Token: 0x04007EC4 RID: 32452
	[Token(Token = "0x400726F")]
	[FieldOffset(Offset = "0x18")]
	private PlayableDirector director;
}
