using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200020C RID: 524
[Token(Token = "0x20001A8")]
[Serializable]
public class PersonalMotion
{
	// Token: 0x06000AEB RID: 2795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600099B")]
	[Address(RVA = "0x213D4C0", Offset = "0x213D5C1", VA = "0x213D4C0")]
	public PersonalMotion()
	{
	}

	// Token: 0x040006BB RID: 1723
	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float Time;

	// Token: 0x040006BC RID: 1724
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Index;

	// Token: 0x040006BD RID: 1725
	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public EmotionType EmotionType;

	// Token: 0x040006BE RID: 1726
	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public VoiceGroup VoiceGroup;
}
