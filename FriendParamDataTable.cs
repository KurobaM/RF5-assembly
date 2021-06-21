using System;
using DataTable;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000377 RID: 887
[Token(Token = "0x20002A2")]
[Serializable]
public class FriendParamDataTable
{
	// Token: 0x060016CB RID: 5835 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600143B")]
	[Address(RVA = "0x23D05D0", Offset = "0x23D06D1", VA = "0x23D05D0")]
	public static FriendParamDataTable GetDataTable(int loveLevel)
	{
		return null;
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600143C")]
	[Address(RVA = "0x23D07D0", Offset = "0x23D08D1", VA = "0x23D07D0")]
	public FriendParamDataTable()
	{
	}

	// Token: 0x04000F2D RID: 3885
	[Token(Token = "0x4000BEF")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int LoveLevel;

	// Token: 0x04000F2E RID: 3886
	[Token(Token = "0x4000BF0")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public int Atk;

	// Token: 0x04000F2F RID: 3887
	[Token(Token = "0x4000BF1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Def;

	// Token: 0x04000F30 RID: 3888
	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x0")]
	private static FriendParamDataTableArray _FriendParamDataTableArray;
}
