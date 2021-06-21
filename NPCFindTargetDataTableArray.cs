using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003AE RID: 942
[Token(Token = "0x20002D4")]
[Serializable]
public class NPCFindTargetDataTableArray : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x06001742 RID: 5954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x1E22360", Offset = "0x1E22461", VA = "0x1E22360", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x1E22450", Offset = "0x1E22551", VA = "0x1E22450", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x1E22460", Offset = "0x1E22561", VA = "0x1E22460")]
	public NPCFindTargetDataTableArray()
	{
	}

	// Token: 0x04001063 RID: 4195
	[Token(Token = "0x4000D13")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public NPCFindTargetDataTable[] DataTables;

	// Token: 0x04001064 RID: 4196
	[Token(Token = "0x4000D14")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<int, NPCFindTargetDataTable> DataTableDic;
}
