using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000698 RID: 1688
[Token(Token = "0x20004BA")]
[Serializable]
public class MonsterDamageInfoDataTableArray : ScriptableObject
{
	// Token: 0x06002938 RID: 10552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x1E5E250", Offset = "0x1E5E351", VA = "0x1E5E250")]
	public MonsterDamageInfoDataTableArray()
	{
	}

	// Token: 0x04007142 RID: 28994
	[Token(Token = "0x400693E")]
	[FieldOffset(Offset = "0x18")]
	public MonsterDamageInfoDataTable[] DataTables;
}
