using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000693 RID: 1683
[Token(Token = "0x20004B5")]
[Serializable]
public struct GateStatusDataTable
{
	// Token: 0x0600292B RID: 10539 RVA: 0x00010230 File Offset: 0x0000E430
	[Token(Token = "0x60022CB")]
	[Address(RVA = "0x1FA3EF0", Offset = "0x1FA3FF1", VA = "0x1FA3EF0")]
	public static GateStatusDataTable GetDataTable(GateStatusDataID gateDataID)
	{
		return default(GateStatusDataTable);
	}

	// Token: 0x0600292C RID: 10540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60022CC")]
	[Address(RVA = "0x1FA40D0", Offset = "0x1FA41D1", VA = "0x1FA40D0")]
	public static void LoadData()
	{
	}

	// Token: 0x0400710B RID: 28939
	[Token(Token = "0x4006907")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public GateStatusDataID StatusID;

	// Token: 0x0400710C RID: 28940
	[Token(Token = "0x4006908")]
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	public int Level;

	// Token: 0x0400710D RID: 28941
	[Token(Token = "0x4006909")]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	public MonsterDataID GateMonsterId;

	// Token: 0x0400710E RID: 28942
	[Token(Token = "0x400690A")]
	[FieldOffset(Offset = "0xC")]
	[SerializeField]
	public bool IsIndicate;

	// Token: 0x0400710F RID: 28943
	[Token(Token = "0x400690B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public float CoolDownTime;

	// Token: 0x04007110 RID: 28944
	[Token(Token = "0x400690C")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public float MoveWaitTime;

	// Token: 0x04007111 RID: 28945
	[Token(Token = "0x400690D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float MoveCompleteTime;

	// Token: 0x04007112 RID: 28946
	[Token(Token = "0x400690E")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public bool IsSpawnPosRotFixed;

	// Token: 0x04007113 RID: 28947
	[Token(Token = "0x400690F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public GateTimeZoneMonsterData GateTimeZoneMonsterData;

	// Token: 0x04007114 RID: 28948
	[Token(Token = "0x4006910")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsLoad;

	// Token: 0x04007115 RID: 28949
	[Token(Token = "0x4006911")]
	[FieldOffset(Offset = "0x8")]
	private static GateStatusDataTableArray _GateStatusDataTableArray;
}
