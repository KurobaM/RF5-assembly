using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B1 RID: 945
[Token(Token = "0x20002D7")]
[Serializable]
public class PesronalMotionPlayData
{
	// Token: 0x0600174D RID: 5965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x213DCC0", Offset = "0x213DDC1", VA = "0x213DCC0")]
	public PesronalMotionPlayData()
	{
	}

	// Token: 0x04001069 RID: 4201
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public FaceType FaceType;

	// Token: 0x0400106A RID: 4202
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public EmotionType EmotionType;

	// Token: 0x0400106B RID: 4203
	[Token(Token = "0x4000D1B")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public VoiceGroup VoiceGroup;

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x4000D1C")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float TransitionDuration;
}
