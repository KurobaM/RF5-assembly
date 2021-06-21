using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200037D RID: 893
[Token(Token = "0x20002A7")]
[Serializable]
public class HumanActionDataTable
{
	// Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001447")]
	[Address(RVA = "0x2093AC0", Offset = "0x2093BC1", VA = "0x2093AC0")]
	public static HumanActionDataTable GetDataTable(HumanActionID actionCodeID)
	{
		return null;
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x0000A140 File Offset: 0x00008340
	[Token(Token = "0x6001448")]
	[Address(RVA = "0x2093C60", Offset = "0x2093D61", VA = "0x2093C60")]
	public static bool HasDataTable(HumanActionID actionCodeID)
	{
		return default(bool);
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001449")]
	[Address(RVA = "0x2093C50", Offset = "0x2093D51", VA = "0x2093C50")]
	public HumanActionDataTable()
	{
	}

	// Token: 0x04000F57 RID: 3927
	[Token(Token = "0x4000C0F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string ScriptName;

	// Token: 0x04000F58 RID: 3928
	[Token(Token = "0x4000C10")]
	[FieldOffset(Offset = "0x0")]
	private static HumanActionDataTableArray _HumanActionDataTableArray;
}
