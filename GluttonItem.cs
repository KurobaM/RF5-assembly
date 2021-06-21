using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000517 RID: 1303
[Token(Token = "0x20003B6")]
[Serializable]
public class GluttonItem
{
	// Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AFC")]
	[Address(RVA = "0x1FEF670", Offset = "0x1FEF771", VA = "0x1FEF670")]
	public GluttonItem()
	{
	}

	// Token: 0x0400668A RID: 26250
	[Token(Token = "0x40060CD")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public FoodID FoodID;

	// Token: 0x0400668B RID: 26251
	[Token(Token = "0x40060CE")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Weight;
}
