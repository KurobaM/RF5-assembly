using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200053A RID: 1338
[Token(Token = "0x20003CB")]
[Serializable]
public class SnowballObject
{
	// Token: 0x06002067 RID: 8295 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x2252F40", Offset = "0x2253041", VA = "0x2252F40")]
	public SnowballObject()
	{
	}

	// Token: 0x0400674E RID: 26446
	[Token(Token = "0x4006153")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public SnowmanObjectID SnowmanObjectID;

	// Token: 0x0400674F RID: 26447
	[Token(Token = "0x4006154")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Weight;
}
