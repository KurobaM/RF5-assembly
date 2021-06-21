using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004DC RID: 1244
[Token(Token = "0x2000393")]
[Serializable]
public class FarmCropsDataTableArray : ScriptableObject
{
	// Token: 0x06001E8F RID: 7823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x21A8010", Offset = "0x21A8111", VA = "0x21A8010")]
	public FarmCropsDataTableArray()
	{
	}

	// Token: 0x04006583 RID: 25987
	[Token(Token = "0x4006023")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public FarmCropsDataTable[] FarmCropsDataTables;
}
