using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003CB RID: 971
[Token(Token = "0x20002ED")]
[Serializable]
public class TimeScaleDataTable
{
	// Token: 0x06001783 RID: 6019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014E7")]
	[Address(RVA = "0x206B1E0", Offset = "0x206B2E1", VA = "0x206B1E0")]
	public static TimeScaleDataTable GetDataTable(TimeScaleID timeScaleID)
	{
		return null;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x0000A410 File Offset: 0x00008610
	[Token(Token = "0x60014E8")]
	[Address(RVA = "0x206B380", Offset = "0x206B481", VA = "0x206B380")]
	public static bool HasDataTable(TimeScaleID timeScaleID)
	{
		return default(bool);
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014E9")]
	[Address(RVA = "0x206B370", Offset = "0x206B471", VA = "0x206B370")]
	public TimeScaleDataTable()
	{
	}

	// Token: 0x040010DC RID: 4316
	[Token(Token = "0x4000D78")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public TimeScaleData Data;

	// Token: 0x040010DD RID: 4317
	[Token(Token = "0x4000D79")]
	[FieldOffset(Offset = "0x0")]
	private static TimeScaleDataTableArray _TimeScaleDataTableArray;
}
