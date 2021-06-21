using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A9E RID: 2718
[Token(Token = "0x2000720")]
public class TextSpeedButton : ButtonLinkerSetImage
{
	// Token: 0x17000977 RID: 2423
	// (get) Token: 0x060046A7 RID: 18087 RVA: 0x000172F8 File Offset: 0x000154F8
	// (set) Token: 0x060046A8 RID: 18088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000799")]
	private int _Value
	{
		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x205AB40", Offset = "0x205AC41", VA = "0x205AB40")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6003B2C")]
		[Address(RVA = "0x205AC40", Offset = "0x205AD41", VA = "0x205AC40")]
		set
		{
		}
	}

	// Token: 0x060046A9 RID: 18089 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B2D")]
	[Address(RVA = "0x205ACA0", Offset = "0x205ADA1", VA = "0x205ACA0")]
	private void OnEnable()
	{
	}

	// Token: 0x060046AA RID: 18090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B2E")]
	[Address(RVA = "0x205AF40", Offset = "0x205B041", VA = "0x205AF40")]
	private void Start()
	{
	}

	// Token: 0x060046AB RID: 18091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B2F")]
	[Address(RVA = "0x205B010", Offset = "0x205B111", VA = "0x205B010")]
	private void Update()
	{
	}

	// Token: 0x060046AC RID: 18092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B30")]
	[Address(RVA = "0x205AE30", Offset = "0x205AF31", VA = "0x205AE30")]
	private void CheckDrawArrow()
	{
	}

	// Token: 0x060046AD RID: 18093 RVA: 0x00017310 File Offset: 0x00015510
	[Token(Token = "0x6003B31")]
	[Address(RVA = "0x205ABD0", Offset = "0x205ACD1", VA = "0x205ABD0")]
	private int GetTableId(float value)
	{
		return 0;
	}

	// Token: 0x060046AE RID: 18094 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B32")]
	[Address(RVA = "0x205B190", Offset = "0x205B291", VA = "0x205B190")]
	private void DoLeft()
	{
	}

	// Token: 0x060046AF RID: 18095 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B33")]
	[Address(RVA = "0x205B400", Offset = "0x205B501", VA = "0x205B400")]
	private void DoRight()
	{
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B34")]
	[Address(RVA = "0x205B680", Offset = "0x205B781", VA = "0x205B680", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x060046B1 RID: 18097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B35")]
	[Address(RVA = "0x205B690", Offset = "0x205B791", VA = "0x205B690", Slot = "8")]
	public override void OnNextFocus(CursorLinker nextObject)
	{
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B36")]
	[Address(RVA = "0x205B6A0", Offset = "0x205B7A1", VA = "0x205B6A0")]
	public TextSpeedButton()
	{
	}

	// Token: 0x060046B3 RID: 18099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B37")]
	[Address(RVA = "0x205B870", Offset = "0x205B971", VA = "0x205B870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7EE0", Offset = "0x1A7FE1")]
	private void <Start>b__9_0()
	{
	}

	// Token: 0x060046B4 RID: 18100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003B38")]
	[Address(RVA = "0x205B8E0", Offset = "0x205B9E1", VA = "0x205B8E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7EF0", Offset = "0x1A7FF1")]
	private void <Start>b__9_1()
	{
	}

	// Token: 0x0400A59E RID: 42398
	[Token(Token = "0x4007D1F")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private Text valueText;

	// Token: 0x0400A59F RID: 42399
	[Token(Token = "0x4007D20")]
	[FieldOffset(Offset = "0xC8")]
	private readonly string[] ValueTextID;

	// Token: 0x0400A5A0 RID: 42400
	[Token(Token = "0x4007D21")]
	[FieldOffset(Offset = "0xD0")]
	private readonly float[] ValueTable;

	// Token: 0x0400A5A1 RID: 42401
	[Token(Token = "0x4007D22")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private NonFocusButton leftArrow;

	// Token: 0x0400A5A2 RID: 42402
	[Token(Token = "0x4007D23")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private NonFocusButton rightArrow;
}
