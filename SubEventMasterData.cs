using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020004B5 RID: 1205
[Token(Token = "0x200037F")]
public class SubEventMasterData : ScriptableObject
{
	// Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x1FAA850", Offset = "0x1FAA951", VA = "0x1FAA850")]
	public SubEventMasterData()
	{
	}

	// Token: 0x040063BC RID: 25532
	[Token(Token = "0x4005E9D")]
	[NonSerialized]
	public const int param_num = 10;

	// Token: 0x040063BD RID: 25533
	[Token(Token = "0x4005E9E")]
	[NonSerialized]
	public const int proceed_chknpc_num = 40;

	// Token: 0x040063BE RID: 25534
	[Token(Token = "0x4005E9F")]
	[FieldOffset(Offset = "0x18")]
	public SubEventMasterDataBase[] Datas;
}
