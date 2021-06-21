using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000919 RID: 2329
[Token(Token = "0x200061C")]
[Serializable]
public class AdvOneImageDataTable : ScriptableObject
{
	// Token: 0x06003D21 RID: 15649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600336F")]
	[Address(RVA = "0x2431E80", Offset = "0x2431F81", VA = "0x2431E80")]
	public AdvOneImageDataTable()
	{
	}

	// Token: 0x04007F77 RID: 32631
	[Token(Token = "0x4007308")]
	[FieldOffset(Offset = "0x18")]
	public List<AdvOneImageDataTable.DataTable> Data;

	// Token: 0x0200091A RID: 2330
	[Token(Token = "0x2001280")]
	[Serializable]
	public class DataTable
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007499")]
		[Address(RVA = "0x2431E90", Offset = "0x2431F91", VA = "0x2431E90")]
		public DataTable()
		{
		}

		// Token: 0x04007F78 RID: 32632
		[Token(Token = "0x40198D4")]
		[FieldOffset(Offset = "0x10")]
		public int DataId;

		// Token: 0x04007F79 RID: 32633
		[Token(Token = "0x40198D5")]
		[FieldOffset(Offset = "0x14")]
		public int LoadID;
	}
}
