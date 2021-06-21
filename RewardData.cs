using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000473 RID: 1139
[Token(Token = "0x200036C")]
[Serializable]
public class RewardData
{
	// Token: 0x06001BC5 RID: 7109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x2492C30", Offset = "0x2492D31", VA = "0x2492C30")]
	public RewardData()
	{
	}

	// Token: 0x0400608E RID: 24718
	[Token(Token = "0x4005C88")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public uint itemId;

	// Token: 0x0400608F RID: 24719
	[Token(Token = "0x4005C89")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string resourcePath;
}
