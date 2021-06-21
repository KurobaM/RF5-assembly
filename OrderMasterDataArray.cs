using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200046D RID: 1133
[Token(Token = "0x2000369")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145E00", Offset = "0x145F01")]
[Serializable]
public class OrderMasterDataArray : ScriptableObject
{
	// Token: 0x06001B92 RID: 7058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001899")]
	[Address(RVA = "0x20D6190", Offset = "0x20D6291", VA = "0x20D6190")]
	public OrderMasterDataArray()
	{
	}

	// Token: 0x04006068 RID: 24680
	[Token(Token = "0x4005C75")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<OrderMasterData> NpcDatas;

	// Token: 0x04006069 RID: 24681
	[Token(Token = "0x4005C76")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<OrderMasterData> PoliceDatas;

	// Token: 0x0400606A RID: 24682
	[Token(Token = "0x4005C77")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public List<OrderMasterData> TanteiDatas;
}
