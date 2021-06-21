using System;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020003B4 RID: 948
[Token(Token = "0x20002DA")]
[Serializable]
public class PlayerParameterDataTable
{
	// Token: 0x06001752 RID: 5970 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014BC")]
	[Address(RVA = "0x2497360", Offset = "0x2497461", VA = "0x2497360")]
	public static PlayerParameterDataTable GetDataTable(int level)
	{
		return null;
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x0000A2F0 File Offset: 0x000084F0
	[Token(Token = "0x60014BD")]
	[Address(RVA = "0x24974E0", Offset = "0x24975E1", VA = "0x24974E0")]
	public static int CountDataTable()
	{
		return 0;
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014BE")]
	[Address(RVA = "0x2497610", Offset = "0x2497711", VA = "0x2497610")]
	public PlayerParameterDataTable()
	{
	}

	// Token: 0x04001074 RID: 4212
	[Token(Token = "0x4000D24")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Level;

	// Token: 0x04001075 RID: 4213
	[Token(Token = "0x4000D25")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Exp;

	// Token: 0x04001076 RID: 4214
	[Token(Token = "0x4000D26")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public Parameter Parameter;

	// Token: 0x04001077 RID: 4215
	[Token(Token = "0x4000D27")]
	[FieldOffset(Offset = "0x0")]
	private static PlayerParameterDataTableArray _PlayerPrameterDataTableArray;
}
