using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000691 RID: 1681
[Token(Token = "0x20004B3")]
[Serializable]
public struct GateDataTable
{
	// Token: 0x06002927 RID: 10535 RVA: 0x00010218 File Offset: 0x0000E418
	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x1FA2670", Offset = "0x1FA2771", VA = "0x1FA2670")]
	public static GateDataTable GetDataTable(GateDataID gateDataID)
	{
		return default(GateDataTable);
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022C8")]
	[Address(RVA = "0x1FA2830", Offset = "0x1FA2931", VA = "0x1FA2830")]
	public static void LoadData()
	{
	}

	// Token: 0x04007105 RID: 28933
	[Token(Token = "0x4006901")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public GateDataID GateDataTableID;

	// Token: 0x04007106 RID: 28934
	[Token(Token = "0x4006902")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public int DestroyEvent;

	// Token: 0x04007107 RID: 28935
	[Token(Token = "0x4006903")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public GateSeasonData GateSeasonData;

	// Token: 0x04007108 RID: 28936
	[Token(Token = "0x4006904")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04007109 RID: 28937
	[Token(Token = "0x4006905")]
	[FieldOffset(Offset = "0x8")]
	private static GateDataTableArray _GateDataTableArray;
}
