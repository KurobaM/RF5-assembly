using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008F6 RID: 2294
[Token(Token = "0x2000600")]
public class TimelineIKBehaviour : PlayableBehaviour
{
	// Token: 0x06003C4E RID: 15438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A4")]
	[Address(RVA = "0x206C770", Offset = "0x206C871", VA = "0x206C770", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x206C7F0", Offset = "0x206C8F1", VA = "0x206C7F0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x206CAB0", Offset = "0x206CBB1", VA = "0x206CAB0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032A7")]
	[Address(RVA = "0x206CBE0", Offset = "0x206CCE1", VA = "0x206CBE0")]
	public TimelineIKBehaviour()
	{
	}

	// Token: 0x04007EBE RID: 32446
	[Token(Token = "0x4007269")]
	[FieldOffset(Offset = "0x10")]
	public GameObject TargetObject;

	// Token: 0x04007EBF RID: 32447
	[Token(Token = "0x400726A")]
	[FieldOffset(Offset = "0x18")]
	private bool clipPlayed;

	// Token: 0x04007EC0 RID: 32448
	[Token(Token = "0x400726B")]
	[FieldOffset(Offset = "0x19")]
	private bool resetPosition;
}
