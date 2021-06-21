using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

// Token: 0x020003BD RID: 957
[Token(Token = "0x20002E1")]
[Serializable]
public class RecipePanShopDataTable
{
	// Token: 0x06001767 RID: 5991 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x1F405C0", Offset = "0x1F406C1", VA = "0x1F405C0")]
	public static RecipePanShopDataTable GetDataTable(RecipePanShopID id)
	{
		return null;
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x1F40700", Offset = "0x1F40801", VA = "0x1F40700")]
	public static IEnumerable<SerializeRecipePanShopDataTable> GetDataTables_Restaurant()
	{
		return null;
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x1F408E0", Offset = "0x1F409E1", VA = "0x1F408E0")]
	public static IEnumerable<SerializeRecipePanShopDataTable> GetDataTables_Bakery()
	{
		return null;
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x1F40AC0", Offset = "0x1F40BC1", VA = "0x1F40AC0")]
	public RecipePanShopDataTable()
	{
	}

	// Token: 0x0400108C RID: 4236
	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public ItemID ItemID;

	// Token: 0x0400108D RID: 4237
	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public PanShopType PanShopType;

	// Token: 0x0400108E RID: 4238
	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public BuilderId Release_BuilderID;

	// Token: 0x0400108F RID: 4239
	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int Price;

	// Token: 0x04001090 RID: 4240
	[Token(Token = "0x4000D37")]
	[FieldOffset(Offset = "0x0")]
	private static RecipePanShopDataTableArray _RecipePanShopDataTableArray;

	// Token: 0x020003BE RID: 958
	[Token(Token = "0x2001065")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157590", Offset = "0x157691")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x1F40B40", Offset = "0x1F40C41", VA = "0x1F40B40")]
		public <>c()
		{
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x1F40B50", Offset = "0x1F40C51", VA = "0x1F40B50")]
		internal bool <GetDataTables_Restaurant>b__6_0(SerializeRecipePanShopDataTable d)
		{
			return default(bool);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x6006D86")]
		[Address(RVA = "0x1F40B80", Offset = "0x1F40C81", VA = "0x1F40B80")]
		internal bool <GetDataTables_Bakery>b__7_0(SerializeRecipePanShopDataTable d)
		{
			return default(bool);
		}

		// Token: 0x04001091 RID: 4241
		[Token(Token = "0x4018FCC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RecipePanShopDataTable.<>c <>9;

		// Token: 0x04001092 RID: 4242
		[Token(Token = "0x4018FCD")]
		[FieldOffset(Offset = "0x8")]
		public static Func<SerializeRecipePanShopDataTable, bool> <>9__6_0;

		// Token: 0x04001093 RID: 4243
		[Token(Token = "0x4018FCE")]
		[FieldOffset(Offset = "0x10")]
		public static Func<SerializeRecipePanShopDataTable, bool> <>9__7_0;
	}
}
