using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029C RID: 668
[Token(Token = "0x2000211")]
[Serializable]
public class MobTravelerName
{
	// Token: 0x06001135 RID: 4405 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x1D7D160", Offset = "0x1D7D261", VA = "0x1D7D160")]
	public MobTravelerName(int nicknameTextID, int nameTextID)
	{
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x1D7D9E0", Offset = "0x1D7DAE1", VA = "0x1D7D9E0")]
	public string GetString()
	{
		return null;
	}

	// Token: 0x040009B3 RID: 2483
	[Token(Token = "0x40007A3")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private int m_nicknameTextID;

	// Token: 0x040009B4 RID: 2484
	[Token(Token = "0x40007A4")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	private int m_nameTextID;
}
