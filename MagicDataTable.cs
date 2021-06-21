using System;
using DataTable;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000392 RID: 914
[Token(Token = "0x20002BA")]
[Serializable]
public class MagicDataTable
{
	// Token: 0x0600170D RID: 5901 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001479")]
	[Address(RVA = "0x1F11C70", Offset = "0x1F11D71", VA = "0x1F11C70")]
	public static MagicDataTable GetDataTable(MagicID magicId)
	{
		return null;
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x0000A260 File Offset: 0x00008460
	[Token(Token = "0x600147A")]
	[Address(RVA = "0x1F125C0", Offset = "0x1F126C1", VA = "0x1F125C0")]
	public static bool HasDataTable(MagicID magicId)
	{
		return default(bool);
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600147B")]
	[Address(RVA = "0x1F12700", Offset = "0x1F12801", VA = "0x1F12700")]
	public MagicDataTable()
	{
	}

	// Token: 0x0400100C RID: 4108
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public MagicData Data;

	// Token: 0x0400100D RID: 4109
	[Token(Token = "0x4000CC1")]
	[FieldOffset(Offset = "0x0")]
	private static MagicDataTableArray _MagicDataTableArray;
}
