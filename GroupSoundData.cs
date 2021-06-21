using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000349 RID: 841
[Token(Token = "0x2000278")]
[Serializable]
public class GroupSoundData
{
	// Token: 0x06001653 RID: 5715 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013C5")]
	[Address(RVA = "0x2041910", Offset = "0x2041A11", VA = "0x2041910")]
	public GroupSoundData()
	{
	}

	// Token: 0x04000E2C RID: 3628
	[Token(Token = "0x4000B0D")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SoundID SoundID;

	// Token: 0x04000E2D RID: 3629
	[Token(Token = "0x4000B0E")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Probability;

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000B0F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Priority;

	// Token: 0x04000E2F RID: 3631
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float Volume;

	// Token: 0x04000E30 RID: 3632
	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public SoundID NextSoundID;
}
