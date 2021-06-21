using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000825 RID: 2085
[Token(Token = "0x2000561")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x146310", Offset = "0x146411")]
[Serializable]
public class PartnerNPCWeaponBehaviorDataTableArray : ScriptableObject, ISerializationCallbackReceiver
{
	// Token: 0x060037AB RID: 14251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x213A570", Offset = "0x213A671", VA = "0x213A570", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	// Token: 0x060037AC RID: 14252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x213A660", Offset = "0x213A761", VA = "0x213A660", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	// Token: 0x060037AD RID: 14253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002E62")]
	[Address(RVA = "0x213A670", Offset = "0x213A771", VA = "0x213A670")]
	public PartnerNPCWeaponBehaviorDataTableArray()
	{
	}

	// Token: 0x04007AD5 RID: 31445
	[Token(Token = "0x4006F37")]
	[FieldOffset(Offset = "0x18")]
	public PartnerNPCWeaponBehaviorDataTable[] DataTables;

	// Token: 0x04007AD6 RID: 31446
	[Token(Token = "0x4006F38")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<ItemCategory, PartnerNPCWeaponBehaviorDataTable> DataDic;
}
