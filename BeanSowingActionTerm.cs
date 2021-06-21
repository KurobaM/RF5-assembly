using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004F3 RID: 1267
[Token(Token = "0x200039E")]
[Serializable]
public class BeanSowingActionTerm
{
	// Token: 0x06001F0B RID: 7947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x2208C00", Offset = "0x2208D01", VA = "0x2208C00")]
	public BeanSowingActionTerm()
	{
	}

	// Token: 0x040065ED RID: 26093
	[Token(Token = "0x4006066")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float SowingTime;

	// Token: 0x040065EE RID: 26094
	[Token(Token = "0x4006067")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<BeanSowingActionData> ActionDataList;
}
