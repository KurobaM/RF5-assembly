using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;
using RF5SHOP;
using UnityEngine;

// Token: 0x0200037C RID: 892
[Token(Token = "0x20002A6")]
[Serializable]
public class HotSpringDataTable
{
	// Token: 0x060016D4 RID: 5844 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001444")]
	[Address(RVA = "0x2093570", Offset = "0x2093671", VA = "0x2093570")]
	public static HotSpringDataTable GetDataTable(HotSpringID hotSpringID)
	{
		return null;
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001445")]
	[Address(RVA = "0x20936B0", Offset = "0x20937B1", VA = "0x20936B0")]
	public static IEnumerable<SerializeHotSpringDataTable> GetDataTables()
	{
		return null;
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001446")]
	[Address(RVA = "0x20937D0", Offset = "0x20938D1", VA = "0x20937D0")]
	public HotSpringDataTable()
	{
	}

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000C06")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	public int Price;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000C07")]
	[FieldOffset(Offset = "0x14")]
	[SerializeField]
	public bool IsMedical;

	// Token: 0x04000F50 RID: 3920
	[Token(Token = "0x4000C08")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int Time;

	// Token: 0x04000F51 RID: 3921
	[Token(Token = "0x4000C09")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public float Args1;

	// Token: 0x04000F52 RID: 3922
	[Token(Token = "0x4000C0A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public float Args2;

	// Token: 0x04000F53 RID: 3923
	[Token(Token = "0x4000C0B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string ScreenNameID;

	// Token: 0x04000F54 RID: 3924
	[Token(Token = "0x4000C0C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string DetailTextID;

	// Token: 0x04000F55 RID: 3925
	[Token(Token = "0x4000C0D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public BuilderId Release_BuilderID;

	// Token: 0x04000F56 RID: 3926
	[Token(Token = "0x4000C0E")]
	[FieldOffset(Offset = "0x0")]
	private static HotSpringDataTableArray _HotSpringDataTableArray;
}
