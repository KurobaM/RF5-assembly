using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B18 RID: 2840
[Token(Token = "0x2000766")]
public class SText : Text
{
	// Token: 0x06004982 RID: 18818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D7A")]
	[Address(RVA = "0x1EF6460", Offset = "0x1EF6561", VA = "0x1EF6460", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x06004983 RID: 18819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D7B")]
	[Address(RVA = "0x1EF6790", Offset = "0x1EF6891", VA = "0x1EF6790")]
	public void SetText(int _textGroup, int _textID)
	{
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D7C")]
	[Address(RVA = "0x1EF64F0", Offset = "0x1EF65F1", VA = "0x1EF64F0")]
	public void SetText(UITextDic.DICID _DicId)
	{
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D7D")]
	[Address(RVA = "0x1EF6600", Offset = "0x1EF6701", VA = "0x1EF6600")]
	public void SetText(SysTextGroup _textGroup, string _textID)
	{
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D7E")]
	[Address(RVA = "0x1EF68B0", Offset = "0x1EF69B1", VA = "0x1EF68B0")]
	public void SetText(SysTextGroup _textGroup, int _textID)
	{
	}

	// Token: 0x06004987 RID: 18823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D7F")]
	[Address(RVA = "0x1EF69D0", Offset = "0x1EF6AD1", VA = "0x1EF69D0")]
	public SText()
	{
	}

	// Token: 0x0400A94C RID: 43340
	[Token(Token = "0x4007F87")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private SysTextGroup textGroup;

	// Token: 0x0400A94D RID: 43341
	[Token(Token = "0x4007F88")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	public string textID;

	// Token: 0x0400A94E RID: 43342
	[Token(Token = "0x4007F89")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	public UITextDic.DICID DicId;
}
