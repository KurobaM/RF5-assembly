using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A37 RID: 2615
[Token(Token = "0x20006DF")]
public class RecipeDataDispBlock : ButtonLinker
{
	// Token: 0x17000947 RID: 2375
	// (get) Token: 0x06004459 RID: 17497 RVA: 0x00016B90 File Offset: 0x00014D90
	// (set) Token: 0x0600445A RID: 17498 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000773")]
	public RecipeId recipeId
	{
		[Token(Token = "0x600393F")]
		[Address(RVA = "0x1F3B670", Offset = "0x1F3B771", VA = "0x1F3B670")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7830", Offset = "0x1A7931")]
		get
		{
			return RecipeId.EMPTY;
		}
		[Token(Token = "0x6003940")]
		[Address(RVA = "0x1F3B680", Offset = "0x1F3B781", VA = "0x1F3B680")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7840", Offset = "0x1A7941")]
		private set
		{
		}
	}

	// Token: 0x17000948 RID: 2376
	// (get) Token: 0x0600445B RID: 17499 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600445C RID: 17500 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000774")]
	public RectTransform RectTransform
	{
		[Token(Token = "0x6003941")]
		[Address(RVA = "0x1F3B690", Offset = "0x1F3B791", VA = "0x1F3B690")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7850", Offset = "0x1A7951")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003942")]
		[Address(RVA = "0x1F3B6A0", Offset = "0x1F3B7A1", VA = "0x1F3B6A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7860", Offset = "0x1A7961")]
		private set
		{
		}
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003943")]
	[Address(RVA = "0x1F3B6B0", Offset = "0x1F3B7B1", VA = "0x1F3B6B0")]
	public void InitOnInstantiate(RecipeId _recipeId, GenerateRecipeDataDispObject generator)
	{
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003944")]
	[Address(RVA = "0x1F3B740", Offset = "0x1F3B841", VA = "0x1F3B740")]
	private void Start()
	{
	}

	// Token: 0x0600445F RID: 17503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003945")]
	[Address(RVA = "0x1F3B750", Offset = "0x1F3B851", VA = "0x1F3B750", Slot = "9")]
	public override void InComingFocus(CursorLinker prevObject)
	{
	}

	// Token: 0x06004460 RID: 17504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003946")]
	[Address(RVA = "0x1F3B770", Offset = "0x1F3B871", VA = "0x1F3B770")]
	public RecipeDataDispBlock()
	{
	}

	// Token: 0x0400A344 RID: 41796
	[Token(Token = "0x4007B71")]
	[FieldOffset(Offset = "0x5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172170", Offset = "0x172271")]
	private RecipeId <recipeId>k__BackingField;

	// Token: 0x0400A345 RID: 41797
	[Token(Token = "0x4007B72")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A346 RID: 41798
	[Token(Token = "0x4007B73")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Text RpText;

	// Token: 0x0400A347 RID: 41799
	[Token(Token = "0x4007B74")]
	[FieldOffset(Offset = "0x70")]
	private GenerateRecipeDataDispObject MyGenerator;

	// Token: 0x0400A348 RID: 41800
	[Token(Token = "0x4007B75")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1721A0", Offset = "0x1722A1")]
	private RectTransform <RectTransform>k__BackingField;
}
