using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200039C RID: 924
[Token(Token = "0x20002C4")]
[Serializable]
public abstract class MobNameDataTable : ScriptableObject
{
	// Token: 0x06001721 RID: 5921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600148D")]
	[Address(RVA = "0x1D7A000", Offset = "0x1D7A101", VA = "0x1D7A000")]
	protected MobNameDataTable()
	{
	}

	// Token: 0x04001040 RID: 4160
	[Token(Token = "0x4000CF4")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<int> TextIDList;
}
