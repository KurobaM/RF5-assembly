using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000A1A RID: 2586
[Token(Token = "0x20006C7")]
public class GenerateRecipeDataDispObject : MonoBehaviour
{
	// Token: 0x060043C6 RID: 17350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B2")]
	[Address(RVA = "0x1FA7130", Offset = "0x1FA7231", VA = "0x1FA7130")]
	private void OnEnable()
	{
	}

	// Token: 0x060043C7 RID: 17351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B3")]
	[Address(RVA = "0x1FA7700", Offset = "0x1FA7801", VA = "0x1FA7700")]
	private void OnDisable()
	{
	}

	// Token: 0x060043C8 RID: 17352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B4")]
	[Address(RVA = "0x1FA7710", Offset = "0x1FA7811", VA = "0x1FA7710")]
	private void CleanUpObject()
	{
	}

	// Token: 0x060043C9 RID: 17353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B5")]
	[Address(RVA = "0x1FA7140", Offset = "0x1FA7241", VA = "0x1FA7140")]
	private void Generate()
	{
	}

	// Token: 0x060043CA RID: 17354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B6")]
	[Address(RVA = "0x1FA7870", Offset = "0x1FA7971", VA = "0x1FA7870")]
	public void SetPositionOnChangeFocus(RecipeDataDispBlock nBlock)
	{
	}

	// Token: 0x060043CB RID: 17355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60038B7")]
	[Address(RVA = "0x1FA79E0", Offset = "0x1FA7AE1", VA = "0x1FA79E0")]
	public GenerateRecipeDataDispObject()
	{
	}

	// Token: 0x0400A2A3 RID: 41635
	[Token(Token = "0x4007AE2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RecipeDataDispBlock RecipeDispPrefab;

	// Token: 0x0400A2A4 RID: 41636
	[Token(Token = "0x4007AE3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject ContentsParent;

	// Token: 0x0400A2A5 RID: 41637
	[Token(Token = "0x4007AE4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CursorLinkConnector MyHeadConnector;

	// Token: 0x0400A2A6 RID: 41638
	[Token(Token = "0x4007AE5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 Margin;

	// Token: 0x0400A2A7 RID: 41639
	[Token(Token = "0x4007AE6")]
	[FieldOffset(Offset = "0x38")]
	private int itemCount;

	// Token: 0x0400A2A8 RID: 41640
	[Token(Token = "0x4007AE7")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform rect;

	// Token: 0x0400A2A9 RID: 41641
	[Token(Token = "0x4007AE8")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform maskRect;

	// Token: 0x0400A2AA RID: 41642
	[Token(Token = "0x4007AE9")]
	[FieldOffset(Offset = "0x50")]
	private List<RecipeDataDispBlock> dispList;

	// Token: 0x0400A2AB RID: 41643
	[Token(Token = "0x4007AEA")]
	[FieldOffset(Offset = "0x58")]
	private Vector2 ScrollPosition;
}
