using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000358 RID: 856
[Token(Token = "0x2000287")]
[Serializable]
public class CostumeDataTableArray : ScriptableObject
{
	// Token: 0x0600166A RID: 5738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x20E20F0", Offset = "0x20E21F1", VA = "0x20E20F0")]
	public CostumeDataTableArray()
	{
	}

	// Token: 0x04000E70 RID: 3696
	[Token(Token = "0x4000B51")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public CostumeDataTable[] DataTables;
}
