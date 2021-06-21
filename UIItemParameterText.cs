using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020009DD RID: 2525
[Token(Token = "0x200069C")]
public class UIItemParameterText
{
	// Token: 0x06004207 RID: 16903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003728")]
	[Address(RVA = "0x2015700", Offset = "0x2015801", VA = "0x2015700")]
	private string GetParamterOnlyText(ItemDetailParameterId parameterId)
	{
		return null;
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003729")]
	[Address(RVA = "0x2015820", Offset = "0x2015921", VA = "0x2015820")]
	private string SetStringFormat(string formatText, params string[] strs)
	{
		return null;
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x000163F8 File Offset: 0x000145F8
	[Token(Token = "0x600372A")]
	[Address(RVA = "0x2015830", Offset = "0x2015931", VA = "0x2015830")]
	private int ParamToInt(float value, int minVal = 0, int maxVal = 0)
	{
		return 0;
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x00016410 File Offset: 0x00014610
	[Token(Token = "0x600372B")]
	[Address(RVA = "0x2015930", Offset = "0x2015A31", VA = "0x2015930")]
	private int ParamToInt(int value, int minVal = 0, int maxVal = 0)
	{
		return 0;
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600372C")]
	[Address(RVA = "0x2015A00", Offset = "0x2015B01", VA = "0x2015A00")]
	private string DPlusStr(int value)
	{
		return null;
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600372D")]
	[Address(RVA = "0x2015AC0", Offset = "0x2015BC1", VA = "0x2015AC0")]
	private string GetParameterText(int parameterId, ItemData item, Parameter parameter, UseParameter useParameter, ItemStrengtheningDataTable strengthDataTable)
	{
		return null;
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600372E")]
	[Address(RVA = "0x2018210", Offset = "0x2018311", VA = "0x2018210")]
	private string GetArgText(int paramId, string formatStr, ItemData item, Parameter parameter, UseParameter useParameter, ItemStrengtheningDataTable strengthDataTable)
	{
		return null;
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x00016428 File Offset: 0x00014628
	[Token(Token = "0x600372F")]
	[Address(RVA = "0x20182E0", Offset = "0x20183E1", VA = "0x20182E0")]
	private bool CheckMushroom(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003730")]
	[Address(RVA = "0x2014FF0", Offset = "0x20150F1", VA = "0x2014FF0")]
	public string GetItemFullParameterText(ItemData item)
	{
		return null;
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6003731")]
	[Address(RVA = "0x20172E0", Offset = "0x20173E1", VA = "0x20172E0")]
	private string GetItemStatusText(int statusId, ItemData item, Parameter parameter, UseParameter useParameter, ItemStrengtheningDataTable strengthDataTable)
	{
		return null;
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003732")]
	[Address(RVA = "0x2018350", Offset = "0x2018451", VA = "0x2018350")]
	public UIItemParameterText()
	{
	}

	// Token: 0x0400A0EE RID: 41198
	[Token(Token = "0x400796E")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Color ITEMARRENGE_NAME_COLOR;

	// Token: 0x0400A0EF RID: 41199
	[Token(Token = "0x400796F")]
	[FieldOffset(Offset = "0x10")]
	private readonly ItemID[] mushroomIdTable;
}
