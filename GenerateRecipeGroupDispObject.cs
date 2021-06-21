using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A1B RID: 2587
[Token(Token = "0x20006C8")]
public class GenerateRecipeGroupDispObject : UIScrollBoxBase
{
	// Token: 0x060043CC RID: 17356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B8")]
	[Address(RVA = "0x1FA7A60", Offset = "0x1FA7B61", VA = "0x1FA7A60")]
	private void OnEnable()
	{
	}

	// Token: 0x060043CD RID: 17357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B9")]
	[Address(RVA = "0x1FA7CA0", Offset = "0x1FA7DA1", VA = "0x1FA7CA0")]
	public void SetEnable(bool state)
	{
	}

	// Token: 0x060043CE RID: 17358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038BA")]
	[Address(RVA = "0x1FA7E20", Offset = "0x1FA7F21", VA = "0x1FA7E20")]
	public void OpenRecipeItemPage(int blockId, CursorLinker backLinker)
	{
	}

	// Token: 0x060043CF RID: 17359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038BB")]
	[Address(RVA = "0x1FA7AC0", Offset = "0x1FA7BC1", VA = "0x1FA7AC0")]
	private void GetRecipeData()
	{
	}

	// Token: 0x060043D0 RID: 17360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038BC")]
	[Address(RVA = "0x1FA7CF0", Offset = "0x1FA7DF1", VA = "0x1FA7CF0")]
	private void Generate()
	{
	}

	// Token: 0x060043D1 RID: 17361 RVA: 0x00016A58 File Offset: 0x00014C58
	[Token(Token = "0x60038BD")]
	[Address(RVA = "0x1FA7F30", Offset = "0x1FA8031", VA = "0x1FA7F30", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x060043D2 RID: 17362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038BE")]
	[Address(RVA = "0x1FA7F80", Offset = "0x1FA8081", VA = "0x1FA7F80", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x060043D3 RID: 17363 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038BF")]
	[Address(RVA = "0x1FA8050", Offset = "0x1FA8151", VA = "0x1FA8050", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x060043D4 RID: 17364 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038C0")]
	[Address(RVA = "0x1FA8060", Offset = "0x1FA8161", VA = "0x1FA8060")]
	public GenerateRecipeGroupDispObject()
	{
	}

	// Token: 0x0400A2AC RID: 41644
	[Token(Token = "0x4007AEB")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Transform ItemPageParent;

	// Token: 0x0400A2AD RID: 41645
	[Token(Token = "0x4007AEC")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private RecipeItemPage RecipeItemPage;

	// Token: 0x0400A2AE RID: 41646
	[Token(Token = "0x4007AED")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private GameObject MainBorder;

	// Token: 0x0400A2AF RID: 41647
	[Token(Token = "0x4007AEE")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject RecipeDetail;

	// Token: 0x0400A2B0 RID: 41648
	[Token(Token = "0x4007AEF")]
	[FieldOffset(Offset = "0x88")]
	private List<RecipeGroupBase> recipeBases;
}
