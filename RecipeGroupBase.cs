using System;
using Il2CppDummyDll;

// Token: 0x02000A38 RID: 2616
[Token(Token = "0x20006E0")]
public class RecipeGroupBase
{
	// Token: 0x17000949 RID: 2377
	// (get) Token: 0x06004461 RID: 17505 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000775")]
	public string name
	{
		[Token(Token = "0x6003947")]
		[Address(RVA = "0x1F3B7A0", Offset = "0x1F3B8A1", VA = "0x1F3B7A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700094A RID: 2378
	// (get) Token: 0x06004462 RID: 17506 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000776")]
	public string discription
	{
		[Token(Token = "0x6003948")]
		[Address(RVA = "0x1F3B8A0", Offset = "0x1F3B9A1", VA = "0x1F3B8A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700094B RID: 2379
	// (get) Token: 0x06004463 RID: 17507 RVA: 0x00016BA8 File Offset: 0x00014DA8
	// (set) Token: 0x06004464 RID: 17508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000777")]
	public int RecipeGroupNo
	{
		[Token(Token = "0x6003949")]
		[Address(RVA = "0x1F3BA50", Offset = "0x1F3BB51", VA = "0x1F3BA50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7870", Offset = "0x1A7971")]
		get
		{
			return 0;
		}
		[Token(Token = "0x600394A")]
		[Address(RVA = "0x1F3BA60", Offset = "0x1F3BB61", VA = "0x1F3BA60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7880", Offset = "0x1A7981")]
		private set
		{
		}
	}

	// Token: 0x1700094C RID: 2380
	// (get) Token: 0x06004465 RID: 17509 RVA: 0x00016BC0 File Offset: 0x00014DC0
	[Token(Token = "0x17000778")]
	public int Released
	{
		[Token(Token = "0x600394B")]
		[Address(RVA = "0x1F3BA70", Offset = "0x1F3BB71", VA = "0x1F3BA70")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700094D RID: 2381
	// (get) Token: 0x06004466 RID: 17510 RVA: 0x00016BD8 File Offset: 0x00014DD8
	[Token(Token = "0x17000779")]
	public int Total
	{
		[Token(Token = "0x600394C")]
		[Address(RVA = "0x1F3BC20", Offset = "0x1F3BD21", VA = "0x1F3BC20")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700094E RID: 2382
	// (get) Token: 0x06004467 RID: 17511 RVA: 0x00016BF0 File Offset: 0x00014DF0
	[Token(Token = "0x1700077A")]
	public float CompletePercent
	{
		[Token(Token = "0x600394D")]
		[Address(RVA = "0x1F3BA00", Offset = "0x1F3BB01", VA = "0x1F3BA00")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600394E")]
	[Address(RVA = "0x1F3BC50", Offset = "0x1F3BD51", VA = "0x1F3BC50")]
	public RecipeGroupBase(int recipeGroupNo)
	{
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600394F")]
	[Address(RVA = "0x1F3BD90", Offset = "0x1F3BE91", VA = "0x1F3BD90")]
	public RecipeGroupBase(RecipeId RecipeId)
	{
	}

	// Token: 0x1700094F RID: 2383
	// (get) Token: 0x0600446A RID: 17514 RVA: 0x00016C08 File Offset: 0x00014E08
	[Token(Token = "0x1700077B")]
	public CraftCategoryId CraftCategoryId
	{
		[Token(Token = "0x6003950")]
		[Address(RVA = "0x1F3C0C0", Offset = "0x1F3C1C1", VA = "0x1F3C0C0")]
		get
		{
			return CraftCategoryId.EMPTY;
		}
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x00016C20 File Offset: 0x00014E20
	[Token(Token = "0x6003951")]
	[Address(RVA = "0x1F3C0D0", Offset = "0x1F3C1D1", VA = "0x1F3C0D0")]
	public static FurnitureID CraftCategoryIDToFurnitureID(CraftCategoryId id)
	{
		return FurnitureID.FURNITURE_EMPTY;
	}

	// Token: 0x17000950 RID: 2384
	// (get) Token: 0x0600446C RID: 17516 RVA: 0x00016C38 File Offset: 0x00014E38
	[Token(Token = "0x1700077C")]
	public FurnitureID CraftFurniture
	{
		[Token(Token = "0x6003952")]
		[Address(RVA = "0x1F3C170", Offset = "0x1F3C271", VA = "0x1F3C170")]
		get
		{
			return FurnitureID.FURNITURE_EMPTY;
		}
	}

	// Token: 0x0400A349 RID: 41801
	[Token(Token = "0x4007B76")]
	[FieldOffset(Offset = "0x10")]
	public CraftCategoryDataTable.CraftCategoryData data;

	// Token: 0x0400A34A RID: 41802
	[Token(Token = "0x4007B77")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1721B0", Offset = "0x1722B1")]
	private int <RecipeGroupNo>k__BackingField;

	// Token: 0x0400A34B RID: 41803
	[Token(Token = "0x4007B78")]
	[FieldOffset(Offset = "0x0")]
	private static readonly FurnitureID[] furnitureIDTable;
}
