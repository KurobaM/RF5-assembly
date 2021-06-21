using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000B1D RID: 2845
[Token(Token = "0x2000769")]
public class TextOnSText : MonoBehaviour
{
	// Token: 0x06004994 RID: 18836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D86")]
	[Address(RVA = "0x1F6D4F0", Offset = "0x1F6D5F1", VA = "0x1F6D4F0")]
	private void Awake()
	{
	}

	// Token: 0x06004995 RID: 18837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D87")]
	[Address(RVA = "0x1F6D590", Offset = "0x1F6D691", VA = "0x1F6D590")]
	private void SetText(SysTextGroup _textGroup, string _textID)
	{
	}

	// Token: 0x06004996 RID: 18838 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D88")]
	[Address(RVA = "0x1F6D7C0", Offset = "0x1F6D8C1", VA = "0x1F6D7C0")]
	public void SetText(SysTextGroup _textGroup, int _textID)
	{
	}

	// Token: 0x06004997 RID: 18839 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003D89")]
	[Address(RVA = "0x1F6D8F0", Offset = "0x1F6D9F1", VA = "0x1F6D8F0")]
	public TextOnSText()
	{
	}

	// Token: 0x0400A95E RID: 43358
	[Token(Token = "0x4007F93")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private SysTextGroup textGroup;

	// Token: 0x0400A95F RID: 43359
	[Token(Token = "0x4007F94")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string textID;

	// Token: 0x0400A960 RID: 43360
	[Token(Token = "0x4007F95")]
	[FieldOffset(Offset = "0x28")]
	private Text Text;
}
