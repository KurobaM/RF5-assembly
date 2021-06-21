using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200033D RID: 829
[Token(Token = "0x200026D")]
[Serializable]
public class BGMDataTableArray : ScriptableObject
{
	// Token: 0x0600163C RID: 5692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60013AF")]
	[Address(RVA = "0x229A730", Offset = "0x229A831", VA = "0x229A730")]
	public BGMDataTableArray()
	{
	}

	// Token: 0x04000CD5 RID: 3285
	[Token(Token = "0x40009BA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BGMDataTable[] DataTables;
}
