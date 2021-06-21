using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000504 RID: 1284
[Token(Token = "0x20003AA")]
[Serializable]
public class CheerVoiceData
{
	// Token: 0x06001F4B RID: 8011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x1E9E4C0", Offset = "0x1E9E5C1", VA = "0x1E9E4C0")]
	public CheerVoiceData()
	{
	}

	// Token: 0x0400663E RID: 26174
	[Token(Token = "0x40060A2")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ActorID ActorID;

	// Token: 0x0400663F RID: 26175
	[Token(Token = "0x40060A3")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public SoundID SoundID;

	// Token: 0x04006640 RID: 26176
	[Token(Token = "0x40060A4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CheerVoiceDataTable.Flag Flag;
}
