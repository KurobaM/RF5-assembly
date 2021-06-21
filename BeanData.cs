using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F6 RID: 1270
[Token(Token = "0x20003A1")]
[Serializable]
public class BeanData
{
	// Token: 0x06001F15 RID: 7957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x2208AC0", Offset = "0x2208BC1", VA = "0x2208AC0")]
	public BeanData()
	{
	}

	// Token: 0x040065F5 RID: 26101
	[Token(Token = "0x400606E")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public BeanID BeanID;

	// Token: 0x040065F6 RID: 26102
	[Token(Token = "0x400606F")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Score;
}
