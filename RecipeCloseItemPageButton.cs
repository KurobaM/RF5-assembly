using System;
using Il2CppDummyDll;
using RF5Input;
using UnityEngine;

// Token: 0x02000A35 RID: 2613
[Token(Token = "0x20006DE")]
public class RecipeCloseItemPageButton : ButtonWorkBase
{
	// Token: 0x06004453 RID: 17491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600393C")]
	[Address(RVA = "0x1F3B0F0", Offset = "0x1F3B1F1", VA = "0x1F3B0F0")]
	public void SetCloseItem(RecipeItemPage _ItemPage)
	{
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600393D")]
	[Address(RVA = "0x1F3B100", Offset = "0x1F3B201", VA = "0x1F3B100", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x06004455 RID: 17493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600393E")]
	[Address(RVA = "0x1F3B580", Offset = "0x1F3B681", VA = "0x1F3B580")]
	public RecipeCloseItemPageButton()
	{
	}

	// Token: 0x0400A340 RID: 41792
	[Token(Token = "0x4007B6F")]
	[FieldOffset(Offset = "0x20")]
	private RecipeItemPage ItemPage;

	// Token: 0x0400A341 RID: 41793
	[Token(Token = "0x4007B70")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool CraftPageButton;

	// Token: 0x02000A36 RID: 2614
	[Token(Token = "0x20012D9")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159060", Offset = "0x159161")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004457 RID: 17495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075FC")]
		[Address(RVA = "0x1F3B600", Offset = "0x1F3B701", VA = "0x1F3B600")]
		public <>c()
		{
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075FD")]
		[Address(RVA = "0x1F3B610", Offset = "0x1F3B711", VA = "0x1F3B610")]
		internal void <ButtonWork>b__3_0()
		{
		}

		// Token: 0x0400A342 RID: 41794
		[Token(Token = "0x401B434")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RecipeCloseItemPageButton.<>c <>9;

		// Token: 0x0400A343 RID: 41795
		[Token(Token = "0x401B435")]
		[FieldOffset(Offset = "0x8")]
		public static Action <>9__3_0;
	}
}
