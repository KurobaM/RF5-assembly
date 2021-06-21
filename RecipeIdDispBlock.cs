using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A3B RID: 2619
[Token(Token = "0x20006E3")]
public class RecipeIdDispBlock : UIButtonLinkerInScrollBox
{
	// Token: 0x17000952 RID: 2386
	// (get) Token: 0x06004479 RID: 17529 RVA: 0x00016C50 File Offset: 0x00014E50
	// (set) Token: 0x0600447A RID: 17530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700077E")]
	public RecipeId recipeId
	{
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x1F3C950", Offset = "0x1F3CA51", VA = "0x1F3C950")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A78B0", Offset = "0x1A79B1")]
		get
		{
			return RecipeId.EMPTY;
		}
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x1F3C960", Offset = "0x1F3CA61", VA = "0x1F3C960")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A78C0", Offset = "0x1A79C1")]
		private set
		{
		}
	}

	// Token: 0x0600447B RID: 17531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003961")]
	[Address(RVA = "0x1F3C970", Offset = "0x1F3CA71", VA = "0x1F3C970", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x0600447C RID: 17532 RVA: 0x00016C68 File Offset: 0x00014E68
	[Token(Token = "0x6003962")]
	[Address(RVA = "0x1F3CA00", Offset = "0x1F3CB01", VA = "0x1F3CA00")]
	public ItemID GetResultItem()
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600447D RID: 17533 RVA: 0x00016C80 File Offset: 0x00014E80
	[Token(Token = "0x6003963")]
	[Address(RVA = "0x1F3CB30", Offset = "0x1F3CC31", VA = "0x1F3CB30")]
	public ItemID GetMaterialItem(int slotNum)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x0600447E RID: 17534 RVA: 0x00016C98 File Offset: 0x00014E98
	[Token(Token = "0x6003964")]
	[Address(RVA = "0x1F3CD50", Offset = "0x1F3CE51", VA = "0x1F3CD50")]
	private Color GetNameTextColor(bool focusing)
	{
		return default(Color);
	}

	// Token: 0x0600447F RID: 17535 RVA: 0x00016CB0 File Offset: 0x00014EB0
	[Token(Token = "0x6003965")]
	[Address(RVA = "0x1F3CDB0", Offset = "0x1F3CEB1", VA = "0x1F3CDB0")]
	public int GetSkillLv()
	{
		return 0;
	}

	// Token: 0x06004480 RID: 17536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003966")]
	[Address(RVA = "0x1F3CEE0", Offset = "0x1F3CFE1", VA = "0x1F3CEE0")]
	public void InitOnInstantiate(int blockNum, RecipeId id)
	{
	}

	// Token: 0x06004481 RID: 17537 RVA: 0x00016CC8 File Offset: 0x00014EC8
	[Token(Token = "0x6003967")]
	[Address(RVA = "0x1F3D6C0", Offset = "0x1F3D7C1", VA = "0x1F3D6C0")]
	private bool FindItem(ItemID itemID)
	{
		return default(bool);
	}

	// Token: 0x06004482 RID: 17538 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003968")]
	[Address(RVA = "0x1F3D800", Offset = "0x1F3D901", VA = "0x1F3D800", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004483 RID: 17539 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003969")]
	[Address(RVA = "0x1F3DAF0", Offset = "0x1F3DBF1", VA = "0x1F3DAF0", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004484 RID: 17540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600396A")]
	[Address(RVA = "0x1F3DB90", Offset = "0x1F3DC91", VA = "0x1F3DB90")]
	public RecipeIdDispBlock()
	{
	}

	// Token: 0x0400A355 RID: 41813
	[Token(Token = "0x4007B82")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A356 RID: 41814
	[Token(Token = "0x4007B83")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Text DifficultyRankText;

	// Token: 0x0400A357 RID: 41815
	[Token(Token = "0x4007B84")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image OnSelectImage;

	// Token: 0x0400A358 RID: 41816
	[Token(Token = "0x4007B85")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image OutSelectImage;

	// Token: 0x0400A359 RID: 41817
	[Token(Token = "0x4007B86")]
	[FieldOffset(Offset = "0x90")]
	private bool hasItem;

	// Token: 0x0400A35A RID: 41818
	[Token(Token = "0x4007B87")]
	[FieldOffset(Offset = "0x98")]
	private RecipeItemPage recipeItemPage;

	// Token: 0x0400A35B RID: 41819
	[Token(Token = "0x4007B88")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172280", Offset = "0x172381")]
	private RecipeId <recipeId>k__BackingField;

	// Token: 0x0400A35C RID: 41820
	[Token(Token = "0x4007B89")]
	[FieldOffset(Offset = "0xA4")]
	private readonly Color EMTPY_COLOR;

	// Token: 0x02000A3C RID: 2620
	[Token(Token = "0x20012DA")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159070", Offset = "0x159171")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004486 RID: 17542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60075FF")]
		[Address(RVA = "0x1F3DC70", Offset = "0x1F3DD71", VA = "0x1F3DC70")]
		public <>c()
		{
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Token(Token = "0x6007600")]
		[Address(RVA = "0x1F3DC80", Offset = "0x1F3DD81", VA = "0x1F3DC80")]
		internal bool <InitOnInstantiate>b__16_0(ItemID i)
		{
			return default(bool);
		}

		// Token: 0x0400A35D RID: 41821
		[Token(Token = "0x401B436")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RecipeIdDispBlock.<>c <>9;

		// Token: 0x0400A35E RID: 41822
		[Token(Token = "0x401B437")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ItemID, bool> <>9__16_0;
	}
}
