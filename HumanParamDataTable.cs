using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000381 RID: 897
[Token(Token = "0x20002AB")]
[Serializable]
public class HumanParamDataTable
{
	// Token: 0x060016E8 RID: 5864 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001458")]
	[Address(RVA = "0x2227280", Offset = "0x2227381", VA = "0x2227280")]
	public static HumanParamDataTable GetDataTable(ActorID id)
	{
		return null;
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x0000A188 File Offset: 0x00008388
	[Token(Token = "0x6001459")]
	[Address(RVA = "0x22273D0", Offset = "0x22274D1", VA = "0x22273D0")]
	public static bool HasDataTable(ActorID id)
	{
		return default(bool);
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600145A")]
	[Address(RVA = "0x2227520", Offset = "0x2227621", VA = "0x2227520")]
	public static SerializedHumanParamDataTable[] GetDataTables()
	{
		return null;
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600145B")]
	[Address(RVA = "0x2227660", Offset = "0x2227761", VA = "0x2227660")]
	public HumanParamDataTable()
	{
	}

	// Token: 0x04000F64 RID: 3940
	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public CharaParamDataTable CharaParam;

	// Token: 0x04000F65 RID: 3941
	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ItemID[] StartEquipItemID;

	// Token: 0x04000F66 RID: 3942
	[Token(Token = "0x4000C1E")]
	[FieldOffset(Offset = "0x0")]
	private static HumanPramDataTableArray _HumanPramDataTableArray;
}
