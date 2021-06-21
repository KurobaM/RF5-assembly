using System;
using Il2CppDummyDll;
using RF5SHIPPING;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009E6 RID: 2534
[Token(Token = "0x20006A2")]
public class UISortBlock : MonoBehaviour
{
	// Token: 0x06004271 RID: 17009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600378C")]
	[Address(RVA = "0x211C290", Offset = "0x211C391", VA = "0x211C290")]
	public void SetSortType(SubSortType subSortType, bool isArrowUp = false)
	{
	}

	// Token: 0x06004272 RID: 17010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600378D")]
	[Address(RVA = "0x211C510", Offset = "0x211C611", VA = "0x211C510")]
	public void SetSortType(SORTTYPE subSortType, bool isArrowUp = false)
	{
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600378E")]
	[Address(RVA = "0x211C770", Offset = "0x211C871", VA = "0x211C770")]
	public void SetSortType(GenerateFriendlistButton.SortType subSortType, bool isArrowUp = false)
	{
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600378F")]
	[Address(RVA = "0x211C9D0", Offset = "0x211CAD1", VA = "0x211C9D0")]
	public void SetSortType(bool isArrowUp = false)
	{
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003790")]
	[Address(RVA = "0x211CC00", Offset = "0x211CD01", VA = "0x211CC00")]
	public UISortBlock()
	{
	}

	// Token: 0x0400A112 RID: 41234
	[Token(Token = "0x400798C")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Image ArrowImage;

	// Token: 0x0400A113 RID: 41235
	[Token(Token = "0x400798D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text SortText;

	// Token: 0x0400A114 RID: 41236
	[Token(Token = "0x400798E")]
	[FieldOffset(Offset = "0x28")]
	private readonly bool[] SortTypeUseArrowImageTable;

	// Token: 0x0400A115 RID: 41237
	[Token(Token = "0x400798F")]
	[FieldOffset(Offset = "0x30")]
	private readonly string[] SortTypeStringTable;

	// Token: 0x0400A116 RID: 41238
	[Token(Token = "0x4007990")]
	[FieldOffset(Offset = "0x38")]
	private readonly string[] ShippingSortTypeStringTable;

	// Token: 0x0400A117 RID: 41239
	[Token(Token = "0x4007991")]
	[FieldOffset(Offset = "0x40")]
	private readonly string[] FRIENDLY_SORT_TEXT;

	// Token: 0x0400A118 RID: 41240
	[Token(Token = "0x4007992")]
	[FieldOffset(Offset = "0x48")]
	private readonly string RECIPE_SORT_TEXT;
}
