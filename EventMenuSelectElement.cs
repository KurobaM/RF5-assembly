using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200098C RID: 2444
[Token(Token = "0x2000669")]
public class EventMenuSelectElement : MonoBehaviour
{
	// Token: 0x170008FA RID: 2298
	// (get) Token: 0x06003FFA RID: 16378 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000730")]
	private Text Text
	{
		[Token(Token = "0x600354C")]
		[Address(RVA = "0x21B5AE0", Offset = "0x21B5BE1", VA = "0x21B5AE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170008FB RID: 2299
	// (get) Token: 0x06003FFB RID: 16379 RVA: 0x00015B10 File Offset: 0x00013D10
	// (set) Token: 0x06003FFC RID: 16380 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000731")]
	public int NextStep
	{
		[Token(Token = "0x600354D")]
		[Address(RVA = "0x21B5B60", Offset = "0x21B5C61", VA = "0x21B5B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7230", Offset = "0x1A7331")]
		private get
		{
			return 0;
		}
		[Token(Token = "0x600354E")]
		[Address(RVA = "0x21B5B70", Offset = "0x21B5C71", VA = "0x21B5B70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7240", Offset = "0x1A7341")]
		set
		{
		}
	}

	// Token: 0x170008FC RID: 2300
	// (get) Token: 0x06003FFD RID: 16381 RVA: 0x00015B28 File Offset: 0x00013D28
	// (set) Token: 0x06003FFE RID: 16382 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000732")]
	public int QuestIdx
	{
		[Token(Token = "0x600354F")]
		[Address(RVA = "0x21B5B80", Offset = "0x21B5C81", VA = "0x21B5B80")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7250", Offset = "0x1A7351")]
		private get
		{
			return 0;
		}
		[Token(Token = "0x6003550")]
		[Address(RVA = "0x21B5B90", Offset = "0x21B5C91", VA = "0x21B5B90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7260", Offset = "0x1A7361")]
		set
		{
		}
	}

	// Token: 0x170008FD RID: 2301
	// (set) Token: 0x06003FFF RID: 16383 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000733")]
	public EventMenuMiniSelect EventMenuMiniSelect
	{
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x21B5BA0", Offset = "0x21B5CA1", VA = "0x21B5BA0")]
		set
		{
		}
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003552")]
	[Address(RVA = "0x21B5BB0", Offset = "0x21B5CB1", VA = "0x21B5BB0")]
	public void SetText(string _text)
	{
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003553")]
	[Address(RVA = "0x21B5C50", Offset = "0x21B5D51", VA = "0x21B5C50")]
	public void SetNextStep(int nextStep)
	{
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003554")]
	[Address(RVA = "0x21B5C60", Offset = "0x21B5D61", VA = "0x21B5C60")]
	public void SetQuestIdx(int questIdx)
	{
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003555")]
	[Address(RVA = "0x21B5C70", Offset = "0x21B5D71", VA = "0x21B5C70")]
	public void OnQuestSubmit()
	{
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003556")]
	[Address(RVA = "0x21B5CF0", Offset = "0x21B5DF1", VA = "0x21B5CF0")]
	public void OnSubmit()
	{
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003557")]
	[Address(RVA = "0x21B5D70", Offset = "0x21B5E71", VA = "0x21B5D70")]
	public void OnCancel()
	{
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003558")]
	[Address(RVA = "0x21B5DD0", Offset = "0x21B5ED1", VA = "0x21B5DD0")]
	public EventMenuSelectElement()
	{
	}

	// Token: 0x04009E53 RID: 40531
	[Token(Token = "0x400775C")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16FD80", Offset = "0x16FE81")]
	private int <NextStep>k__BackingField;

	// Token: 0x04009E54 RID: 40532
	[Token(Token = "0x400775D")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x16FD90", Offset = "0x16FE91")]
	private int <QuestIdx>k__BackingField;

	// Token: 0x04009E55 RID: 40533
	[Token(Token = "0x400775E")]
	[FieldOffset(Offset = "0x20")]
	private EventMenuMiniSelect _EventMenuMiniSelect;
}
