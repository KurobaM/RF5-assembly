using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200069B RID: 1691
[Token(Token = "0x20004BD")]
[Serializable]
public class MonsterDataTableArray : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x0600293C RID: 10556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x1E5E7F0", Offset = "0x1E5E8F1", VA = "0x1E5E7F0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022DD")]
	[Address(RVA = "0x1E5E9A0", Offset = "0x1E5EAA1", VA = "0x1E5E9A0", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x1E5E9B0", Offset = "0x1E5EAB1", VA = "0x1E5E9B0")]
	public MonsterDataTableArray()
	{
	}

	// Token: 0x0400716D RID: 29037
	[Token(Token = "0x4006969")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterDataTable[] DataTables;

	// Token: 0x0400716E RID: 29038
	[Token(Token = "0x400696A")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<MonsterDataID, MonsterDataTable> DataTableDic;
}
