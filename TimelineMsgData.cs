using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020008FA RID: 2298
[Token(Token = "0x2000604")]
public class TimelineMsgData : ScriptableObject
{
	// Token: 0x06003C5C RID: 15452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60032B2")]
	[Address(RVA = "0x206D470", Offset = "0x206D571", VA = "0x206D470")]
	public TimelineMsgData()
	{
	}

	// Token: 0x04007EC5 RID: 32453
	[Token(Token = "0x4007270")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string[] msgId;

	// Token: 0x04007EC6 RID: 32454
	[Token(Token = "0x4007271")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public string[] text;
}
