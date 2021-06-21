using System;
using Il2CppDummyDll;
using SaveData;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A99 RID: 2713
[Token(Token = "0x200071C")]
public class OptionFlagButton : ButtonLinkerSetImage
{
	// Token: 0x17000975 RID: 2421
	// (get) Token: 0x06004687 RID: 18055 RVA: 0x000172C8 File Offset: 0x000154C8
	// (set) Token: 0x06004688 RID: 18056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000797")]
	private int _Value
	{
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x20C62F0", Offset = "0x20C63F1", VA = "0x20C62F0")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003B0C")]
		[Address(RVA = "0x20C6380", Offset = "0x20C6481", VA = "0x20C6380")]
		set
		{
		}
	}

	// Token: 0x06004689 RID: 18057 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B0D")]
	[Address(RVA = "0x20C63E0", Offset = "0x20C64E1", VA = "0x20C63E0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600468A RID: 18058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B0E")]
	[Address(RVA = "0x20C65F0", Offset = "0x20C66F1", VA = "0x20C65F0")]
	private void Start()
	{
	}

	// Token: 0x0600468B RID: 18059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B0F")]
	[Address(RVA = "0x20C6A50", Offset = "0x20C6B51", VA = "0x20C6A50")]
	private void Update()
	{
	}

	// Token: 0x0600468C RID: 18060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B10")]
	[Address(RVA = "0x20C6BD0", Offset = "0x20C6CD1", VA = "0x20C6BD0")]
	private void DoLeft()
	{
	}

	// Token: 0x0600468D RID: 18061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B11")]
	[Address(RVA = "0x20C6DF0", Offset = "0x20C6EF1", VA = "0x20C6DF0")]
	private void DoRight()
	{
	}

	// Token: 0x0600468E RID: 18062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B12")]
	[Address(RVA = "0x20C66C0", Offset = "0x20C67C1", VA = "0x20C66C0")]
	private void InitValueText()
	{
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B13")]
	[Address(RVA = "0x20C6580", Offset = "0x20C6681", VA = "0x20C6580")]
	private void CheckDrawArrow()
	{
	}

	// Token: 0x06004690 RID: 18064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B14")]
	[Address(RVA = "0x20C7020", Offset = "0x20C7121", VA = "0x20C7020", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B15")]
	[Address(RVA = "0x20C7030", Offset = "0x20C7131", VA = "0x20C7030", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B16")]
	[Address(RVA = "0x20C7040", Offset = "0x20C7141", VA = "0x20C7040")]
	public OptionFlagButton()
	{
	}

	// Token: 0x06004693 RID: 18067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B17")]
	[Address(RVA = "0x20C70E0", Offset = "0x20C71E1", VA = "0x20C70E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7EC0", Offset = "0x1A7FC1")]
	private void <Start>b__10_0()
	{
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B18")]
	[Address(RVA = "0x20C7150", Offset = "0x20C7251", VA = "0x20C7150")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7ED0", Offset = "0x1A7FD1")]
	private void <Start>b__10_1()
	{
	}

	// Token: 0x0400A588 RID: 42376
	[Token(Token = "0x4007D0C")]
	[FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private RF5OptionData.FLAG optionFlag;

	// Token: 0x0400A589 RID: 42377
	[Token(Token = "0x4007D0D")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Text valueText;

	// Token: 0x0400A58A RID: 42378
	[Token(Token = "0x4007D0E")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private NonFocusButton leftArrow;

	// Token: 0x0400A58B RID: 42379
	[Token(Token = "0x4007D0F")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private NonFocusButton rightArrow;

	// Token: 0x0400A58C RID: 42380
	[Token(Token = "0x4007D10")]
	[FieldOffset(Offset = "0xD8")]
	private string[] valueTextID;

	// Token: 0x0400A58D RID: 42381
	[Token(Token = "0x4007D11")]
	[FieldOffset(Offset = "0xE0")]
	private readonly bool[] valueTable;
}
