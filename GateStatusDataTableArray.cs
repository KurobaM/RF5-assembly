using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000694 RID: 1684
[Token(Token = "0x20004B6")]
[Serializable]
public class GateStatusDataTableArray : ScriptableObject
{
	// Token: 0x0600292E RID: 10542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x1FA4210", Offset = "0x1FA4311", VA = "0x1FA4210")]
	public GateStatusDataTableArray()
	{
	}

	// Token: 0x04007116 RID: 28950
	[Token(Token = "0x4006912")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GateStatusDataTable[] DataTables;
}
