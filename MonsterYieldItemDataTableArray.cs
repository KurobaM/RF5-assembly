using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020006A4 RID: 1700
[Token(Token = "0x20004C6")]
[Serializable]
public class MonsterYieldItemDataTableArray : ScriptableObject
{
	// Token: 0x06002951 RID: 10577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022F1")]
	[Address(RVA = "0x1E0F3D0", Offset = "0x1E0F4D1", VA = "0x1E0F3D0")]
	public MonsterYieldItemDataTableArray()
	{
	}

	// Token: 0x04007193 RID: 29075
	[Token(Token = "0x400698F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterYieldItemDataTable[] DataTables;
}
