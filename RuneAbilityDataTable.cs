using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200083E RID: 2110
[Token(Token = "0x2000568")]
public class RuneAbilityDataTable : ScriptableObject
{
	// Token: 0x06003824 RID: 14372 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x1EF3F90", Offset = "0x1EF4091", VA = "0x1EF3F90")]
	public static RuneAbilityDataTable GetDataTable(RuneABID runeABID)
	{
		return null;
	}

	// Token: 0x06003825 RID: 14373 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x1EF4090", Offset = "0x1EF4191", VA = "0x1EF4090")]
	public RuneAbilityDataTable()
	{
	}

	// Token: 0x04007B36 RID: 31542
	[Token(Token = "0x4006F69")]
	[FieldOffset(Offset = "0x18")]
	public AbilityType AbilityType;

	// Token: 0x04007B37 RID: 31543
	[Token(Token = "0x4006F6A")]
	[FieldOffset(Offset = "0x0")]
	private static RuneAbilityDataTableArray _RuneAbilityDataTableArray;
}
