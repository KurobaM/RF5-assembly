using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000696 RID: 1686
[Token(Token = "0x20004B8")]
[Serializable]
public class MonsterBehaviorDataTableArray : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x06002933 RID: 10547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D3")]
	[Address(RVA = "0x1D88660", Offset = "0x1D88761", VA = "0x1D88660", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D4")]
	[Address(RVA = "0x1D886E0", Offset = "0x1D887E1", VA = "0x1D886E0", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x1D886F0", Offset = "0x1D887F1", VA = "0x1D886F0")]
	public MonsterBehaviorDataTableArray()
	{
	}

	// Token: 0x0400711C RID: 28956
	[Token(Token = "0x4006918")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MonsterBehaviorDataTable[] DataTables;
}
