using System;
using Il2CppDummyDll;
using RF5Input;

// Token: 0x02000A42 RID: 2626
[Token(Token = "0x20006E7")]
public class RecipeOpenItemPageButton : ButtonWorkBase
{
	// Token: 0x060044AC RID: 17580 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003989")]
	[Address(RVA = "0x1F3FE80", Offset = "0x1F3FF81", VA = "0x1F3FE80")]
	public void SetAddPageParent(GenerateRecipeGroupDispObject _GenerateRecipeGroupDispObject, int id)
	{
	}

	// Token: 0x060044AD RID: 17581 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600398A")]
	[Address(RVA = "0x1F3FEB0", Offset = "0x1F3FFB1", VA = "0x1F3FEB0")]
	public void BackFocus(bool a)
	{
	}

	// Token: 0x060044AE RID: 17582 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600398B")]
	[Address(RVA = "0x1F3FF30", Offset = "0x1F40031", VA = "0x1F3FF30", Slot = "5")]
	public override void ButtonWork(Key btnType)
	{
	}

	// Token: 0x060044AF RID: 17583 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600398C")]
	[Address(RVA = "0x1F3FFD0", Offset = "0x1F400D1", VA = "0x1F3FFD0")]
	public RecipeOpenItemPageButton()
	{
	}

	// Token: 0x0400A386 RID: 41862
	[Token(Token = "0x4007BAC")]
	[FieldOffset(Offset = "0x20")]
	private int blockId;

	// Token: 0x0400A387 RID: 41863
	[Token(Token = "0x4007BAD")]
	[FieldOffset(Offset = "0x28")]
	private GenerateRecipeGroupDispObject GenerateRecipeGroupDispObject;
}
