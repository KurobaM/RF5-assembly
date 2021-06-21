using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000692 RID: 1682
[Token(Token = "0x20004B4")]
[Serializable]
public class GateDataTableArray : ScriptableObject
{
	// Token: 0x0600292A RID: 10538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022CA")]
	[Address(RVA = "0x1FA2970", Offset = "0x1FA2A71", VA = "0x1FA2970")]
	public GateDataTableArray()
	{
	}

	// Token: 0x0400710A RID: 28938
	[Token(Token = "0x4006906")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public GateDataTable[] DataTables;
}
