using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000513 RID: 1299
[Token(Token = "0x20003B3")]
[Serializable]
public class GluttonFoodData
{
	// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x1FEF660", Offset = "0x1FEF761", VA = "0x1FEF660")]
	public GluttonFoodData()
	{
	}

	// Token: 0x0400667E RID: 26238
	[Token(Token = "0x40060C5")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public FoodID FoodID;

	// Token: 0x0400667F RID: 26239
	[Token(Token = "0x40060C6")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Life;

	// Token: 0x04006680 RID: 26240
	[Token(Token = "0x40060C7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<float> Scale;

	// Token: 0x04006681 RID: 26241
	[Token(Token = "0x40060C8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int Score;

	// Token: 0x04006682 RID: 26242
	[Token(Token = "0x40060C9")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public Color DishColor;
}
