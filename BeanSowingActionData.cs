using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F2 RID: 1266
[Token(Token = "0x200039D")]
[Serializable]
public class BeanSowingActionData
{
	// Token: 0x06001F0A RID: 7946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A92")]
	[Address(RVA = "0x2208AD0", Offset = "0x2208BD1", VA = "0x2208AD0")]
	public BeanSowingActionData()
	{
	}

	// Token: 0x040065EA RID: 26090
	[Token(Token = "0x4006063")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SowingPattern SowingPattern;

	// Token: 0x040065EB RID: 26091
	[Token(Token = "0x4006064")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public BeanID BeanID;

	// Token: 0x040065EC RID: 26092
	[Token(Token = "0x4006065")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public bool IsLookAtPlayer;
}
