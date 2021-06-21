using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000503 RID: 1283
[Token(Token = "0x20003A9")]
[Serializable]
public class PlayerCheerVoiceData
{
	// Token: 0x06001F4A RID: 8010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x2147EA0", Offset = "0x2147FA1", VA = "0x2147EA0")]
	public PlayerCheerVoiceData()
	{
	}

	// Token: 0x0400663C RID: 26172
	[Token(Token = "0x40060A0")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public Gender Gender;

	// Token: 0x0400663D RID: 26173
	[Token(Token = "0x40060A1")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public SoundID SoundID;
}
