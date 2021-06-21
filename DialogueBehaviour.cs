using System;
using Define;
using Il2CppDummyDll;
using UnityEngine.Playables;

// Token: 0x020008C2 RID: 2242
[Token(Token = "0x20005D1")]
[Serializable]
public class DialogueBehaviour : PlayableBehaviour
{
	// Token: 0x06003B4F RID: 15183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031B4")]
	[Address(RVA = "0x1DFA7C0", Offset = "0x1DFA8C1", VA = "0x1DFA7C0", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	// Token: 0x06003B50 RID: 15184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031B5")]
	[Address(RVA = "0x1DFA900", Offset = "0x1DFAA01", VA = "0x1DFA900", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003B51 RID: 15185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031B6")]
	[Address(RVA = "0x1DFAAC0", Offset = "0x1DFABC1", VA = "0x1DFAAC0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60031B7")]
	[Address(RVA = "0x1DFABC0", Offset = "0x1DFACC1", VA = "0x1DFABC0")]
	public DialogueBehaviour()
	{
	}

	// Token: 0x04007E21 RID: 32289
	[Token(Token = "0x40071DD")]
	[FieldOffset(Offset = "0x10")]
	public string TextId;

	// Token: 0x04007E22 RID: 32290
	[Token(Token = "0x40071DE")]
	[FieldOffset(Offset = "0x18")]
	public TimelineMsgID msgId;

	// Token: 0x04007E23 RID: 32291
	[Token(Token = "0x40071DF")]
	[FieldOffset(Offset = "0x1C")]
	public bool hasToPause;

	// Token: 0x04007E24 RID: 32292
	[Token(Token = "0x40071E0")]
	[FieldOffset(Offset = "0x1D")]
	public bool endOfDialogClose;

	// Token: 0x04007E25 RID: 32293
	[Token(Token = "0x40071E1")]
	[FieldOffset(Offset = "0x1E")]
	private bool clipPlayed;

	// Token: 0x04007E26 RID: 32294
	[Token(Token = "0x40071E2")]
	[FieldOffset(Offset = "0x1F")]
	private bool pauseScheduled;
}
