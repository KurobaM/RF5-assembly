using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000537 RID: 1335
[Token(Token = "0x20003C8")]
[Serializable]
public class SnowballData
{
	// Token: 0x0600205E RID: 8286 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x2252C80", Offset = "0x2252D81", VA = "0x2252C80")]
	public SnowballData()
	{
	}

	// Token: 0x04006741 RID: 26433
	[Token(Token = "0x4006146")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SnowmanObjectID SnowmanObjectID;

	// Token: 0x04006742 RID: 26434
	[Token(Token = "0x4006147")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float Scale;

	// Token: 0x04006743 RID: 26435
	[Token(Token = "0x4006148")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float Result;

	// Token: 0x04006744 RID: 26436
	[Token(Token = "0x4006149")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float Time;
}
