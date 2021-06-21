using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000083 RID: 131
[Token(Token = "0x2000065")]
[Serializable]
public class ActionCodeDataTable
{
	// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1FD5B20", Offset = "0x1FD5C21", VA = "0x1FD5B20")]
	public static ActionCodeDataTable GetDataTable(string actionCodeDataName)
	{
		return null;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1FD5CD0", Offset = "0x1FD5DD1", VA = "0x1FD5CD0")]
	public ActionCodeDataTable()
	{
	}

	// Token: 0x0400019A RID: 410
	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public string ActionCodeDataName;

	// Token: 0x0400019B RID: 411
	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x18")]
	public ActionCommandDataTable[] ActionCommandDataTables;

	// Token: 0x0400019C RID: 412
	[Token(Token = "0x4000136")]
	[FieldOffset(Offset = "0x0")]
	private static ActionCodeDataTableArray _ActionCodeDataTableArray;

	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000FA8")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157000", Offset = "0x157101")]
	private sealed class <>c__DisplayClass3_0
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B2E")]
		[Address(RVA = "0x1FD5CC0", Offset = "0x1FD5DC1", VA = "0x1FD5CC0")]
		public <>c__DisplayClass3_0()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6006B2F")]
		[Address(RVA = "0x1FD5CE0", Offset = "0x1FD5DE1", VA = "0x1FD5CE0")]
		internal bool <GetDataTable>b__0(ActionCodeDataTable data)
		{
			return default(bool);
		}

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x4018CDE")]
		[FieldOffset(Offset = "0x10")]
		public string actionCodeDataName;
	}
}
