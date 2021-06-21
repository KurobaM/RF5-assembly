using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000425 RID: 1061
[Token(Token = "0x2000331")]
[Serializable]
public class CharacterCallingData
{
	// Token: 0x060019C8 RID: 6600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60016EE")]
	[Address(RVA = "0x1E8D6B0", Offset = "0x1E8D7B1", VA = "0x1E8D6B0")]
	public CharacterCallingData()
	{
	}

	// Token: 0x04005CCA RID: 23754
	[Token(Token = "0x4005911")]
	[FieldOffset(Offset = "0x10")]
	public int npcId;

	// Token: 0x04005CCB RID: 23755
	[Token(Token = "0x4005912")]
	[FieldOffset(Offset = "0x18")]
	public List<SoundID> VoiceID;
}
