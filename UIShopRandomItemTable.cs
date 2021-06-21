using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000AC3 RID: 2755
[Token(Token = "0x200073C")]
public class UIShopRandomItemTable : ScriptableObject
{
	// Token: 0x060047A5 RID: 18341 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003C13")]
	[Address(RVA = "0x211C260", Offset = "0x211C361", VA = "0x211C260")]
	public UIShopRandomItemTable()
	{
	}

	// Token: 0x0400A700 RID: 42752
	[Token(Token = "0x4007E54")]
	[FieldOffset(Offset = "0x18")]
	public List<UIShopRandomItemTable.RandomIdList> RandomIdLists;

	// Token: 0x0400A701 RID: 42753
	[Token(Token = "0x4007E55")]
	[FieldOffset(Offset = "0x20")]
	public List<UIShopRandomItemTable.Datas> datas;

	// Token: 0x02000AC4 RID: 2756
	[Token(Token = "0x2001309")]
	[Serializable]
	public class RandomIdList
	{
		// Token: 0x060047A6 RID: 18342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007676")]
		[Address(RVA = "0x211C280", Offset = "0x211C381", VA = "0x211C280")]
		public RandomIdList()
		{
		}

		// Token: 0x0400A702 RID: 42754
		[Token(Token = "0x401B50F")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400A703 RID: 42755
		[Token(Token = "0x401B510")]
		[FieldOffset(Offset = "0x14")]
		public bool CheckGet;

		// Token: 0x0400A704 RID: 42756
		[Token(Token = "0x401B511")]
		[FieldOffset(Offset = "0x15")]
		public bool CheckShipment;

		// Token: 0x0400A705 RID: 42757
		[Token(Token = "0x401B512")]
		[FieldOffset(Offset = "0x16")]
		public bool CheckDropCap;

		// Token: 0x0400A706 RID: 42758
		[Token(Token = "0x401B513")]
		[FieldOffset(Offset = "0x17")]
		public bool GoldCheck;

		// Token: 0x0400A707 RID: 42759
		[Token(Token = "0x401B514")]
		[FieldOffset(Offset = "0x18")]
		public bool IgnoreCapCheap;
	}

	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x200130A")]
	[Serializable]
	public class Datas
	{
		// Token: 0x060047A7 RID: 18343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007677")]
		[Address(RVA = "0x211C270", Offset = "0x211C371", VA = "0x211C270")]
		public Datas()
		{
		}

		// Token: 0x0400A708 RID: 42760
		[Token(Token = "0x401B515")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		// Token: 0x0400A709 RID: 42761
		[Token(Token = "0x401B516")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemID> itemIDs;
	}
}
