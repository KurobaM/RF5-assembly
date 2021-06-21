using System;
using Il2CppDummyDll;
using RF5_Sound;
using UnityEngine;
using UnityEngine.Playables;

// Token: 0x020008E4 RID: 2276
[Token(Token = "0x20005F0")]
[Serializable]
public class RF_AudioBehaviour : PlayableBehaviour
{
	// Token: 0x06003BF8 RID: 15352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003254")]
	[Address(RVA = "0x1F392E0", Offset = "0x1F393E1", VA = "0x1F392E0", Slot = "17")]
	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BF9 RID: 15353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003255")]
	[Address(RVA = "0x1F39460", Offset = "0x1F39561", VA = "0x1F39460", Slot = "19")]
	public override void PrepareFrame(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003256")]
	[Address(RVA = "0x1F39520", Offset = "0x1F39621", VA = "0x1F39520", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003257")]
	[Address(RVA = "0x1F395A0", Offset = "0x1F396A1", VA = "0x1F395A0", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	// Token: 0x06003BFC RID: 15356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003258")]
	[Address(RVA = "0x1F39640", Offset = "0x1F39741", VA = "0x1F39640")]
	public RF_AudioBehaviour()
	{
	}

	// Token: 0x04007E7E RID: 32382
	[Token(Token = "0x4007233")]
	[FieldOffset(Offset = "0x10")]
	public SoundID SoundID;

	// Token: 0x04007E7F RID: 32383
	[Token(Token = "0x4007234")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string InputSoundIDString;

	// Token: 0x04007E80 RID: 32384
	[Token(Token = "0x4007235")]
	[FieldOffset(Offset = "0x20")]
	public Transform TargetTransform;

	// Token: 0x04007E81 RID: 32385
	[Token(Token = "0x4007236")]
	[FieldOffset(Offset = "0x28")]
	public bool IsLoop;

	// Token: 0x04007E82 RID: 32386
	[Token(Token = "0x4007237")]
	[FieldOffset(Offset = "0x2C")]
	public float Volume;

	// Token: 0x04007E83 RID: 32387
	[Token(Token = "0x4007238")]
	[FieldOffset(Offset = "0x30")]
	private AudioSourceController<SoundID> audioSourceController;
}
