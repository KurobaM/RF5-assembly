using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A79 RID: 2681
[Token(Token = "0x2000708")]
public class UINamingWindowButton : ButtonWorkBase
{
	// Token: 0x060045F4 RID: 17908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A91")]
	[Address(RVA = "0x1EA8E20", Offset = "0x1EA8F21", VA = "0x1EA8E20")]
	private void Start()
	{
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A92")]
	[Address(RVA = "0x1EA8E80", Offset = "0x1EA8F81", VA = "0x1EA8E80", Slot = "7")]
	public override void OnFocus()
	{
	}

	// Token: 0x060045F6 RID: 17910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A93")]
	[Address(RVA = "0x1EA8EC0", Offset = "0x1EA8FC1", VA = "0x1EA8EC0", Slot = "8")]
	public override void EndFocus()
	{
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A94")]
	[Address(RVA = "0x1EA8F00", Offset = "0x1EA9001", VA = "0x1EA8F00", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x060045F8 RID: 17912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003A95")]
	[Address(RVA = "0x1EA9040", Offset = "0x1EA9141", VA = "0x1EA9040")]
	public UINamingWindowButton()
	{
	}

	// Token: 0x0400A4ED RID: 42221
	[Token(Token = "0x4007C99")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image choiceImage;

	// Token: 0x0400A4EE RID: 42222
	[Token(Token = "0x4007C9A")]
	[FieldOffset(Offset = "0x28")]
	private ChoiceButton OK_Button;
}
