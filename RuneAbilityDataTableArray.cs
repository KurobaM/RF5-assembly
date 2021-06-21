using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000840 RID: 2112
[Token(Token = "0x200056A")]
public class RuneAbilityDataTableArray : ScriptableObject
{
	// Token: 0x06003826 RID: 14374 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x1EF40A0", Offset = "0x1EF41A1", VA = "0x1EF40A0")]
	public RuneAbilityDataTableArray()
	{
	}

	// Token: 0x04007B3A RID: 31546
	[Token(Token = "0x4006F6D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public RuneAbilityDataTable[] DataTables;
}
