using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

// Token: 0x020008F0 RID: 2288
[Token(Token = "0x20005FC")]
[Serializable]
public class TimeMachineBehaviour : PlayableBehaviour
{
	// Token: 0x06003C2A RID: 15402 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003286")]
	[Address(RVA = "0x2060A00", Offset = "0x2060B01", VA = "0x2060A00", Slot = "15")]
	public override void OnPlayableCreate(Playable playable)
	{
	}

	// Token: 0x06003C2B RID: 15403 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003287")]
	[Address(RVA = "0x2060AF0", Offset = "0x2060BF1", VA = "0x2060AF0", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003288")]
	[Address(RVA = "0x2060BD0", Offset = "0x2060CD1", VA = "0x2060BD0", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x00015060 File Offset: 0x00013260
	[Token(Token = "0x6003289")]
	[Address(RVA = "0x2060D10", Offset = "0x2060E11", VA = "0x2060D10")]
	public bool ConditionMet()
	{
		return default(bool);
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600328A")]
	[Address(RVA = "0x2060D70", Offset = "0x2060E71", VA = "0x2060D70")]
	public TimeMachineBehaviour()
	{
	}

	// Token: 0x04007EA3 RID: 32419
	[Token(Token = "0x4007258")]
	[FieldOffset(Offset = "0x10")]
	public TimeMachineCondition condition;

	// Token: 0x04007EA4 RID: 32420
	[Token(Token = "0x4007259")]
	[FieldOffset(Offset = "0x14")]
	public float timeOfLoopStart;

	// Token: 0x04007EA5 RID: 32421
	[Token(Token = "0x400725A")]
	[FieldOffset(Offset = "0x18")]
	public float timeOfLoopEnd;

	// Token: 0x04007EA6 RID: 32422
	[Token(Token = "0x400725B")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "HideInInspector", RVA = "0x16ED20", Offset = "0x16EE21")]
	public bool clipExecuted;

	// Token: 0x04007EA7 RID: 32423
	[Token(Token = "0x400725C")]
	[FieldOffset(Offset = "0x20")]
	private PlayableDirector director;
}
