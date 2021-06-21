using System;
using Il2CppDummyDll;

// Token: 0x0200067F RID: 1663
[Token(Token = "0x20004A2")]
[Serializable]
public class MonsterActionInformationBase
{
	// Token: 0x06002911 RID: 10513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x1D837E0", Offset = "0x1D838E1", VA = "0x1D837E0")]
	public MonsterActionInformationBase()
	{
	}

	// Token: 0x06002912 RID: 10514 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x1D83870", Offset = "0x1D83971", VA = "0x1D83870")]
	public MonsterActionInformationBase(MonsterActionInformation information)
	{
	}

	// Token: 0x040070C1 RID: 28865
	[Token(Token = "0x40068BF")]
	[FieldOffset(Offset = "0x10")]
	public string ActionScriptName;

	// Token: 0x040070C2 RID: 28866
	[Token(Token = "0x40068C0")]
	[FieldOffset(Offset = "0x18")]
	public int ActionTypeNo;
}
