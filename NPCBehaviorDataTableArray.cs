using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003AC RID: 940
[Token(Token = "0x20002D2")]
[Serializable]
public class NPCBehaviorDataTableArray : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x0600173D RID: 5949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x1E22220", Offset = "0x1E22321", VA = "0x1E22220", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x1E22310", Offset = "0x1E22411", VA = "0x1E22310", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x1E22320", Offset = "0x1E22421", VA = "0x1E22320")]
	public NPCBehaviorDataTableArray()
	{
	}

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public NPCBehaviorDataTable[] DataTables;

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x4000D0B")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<int, NPCBehaviorDataTable> DataTableDic;
}
