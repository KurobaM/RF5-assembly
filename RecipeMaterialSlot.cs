using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A40 RID: 2624
[Token(Token = "0x20006E5")]
public class RecipeMaterialSlot : ButtonLinker
{
	// Token: 0x17000955 RID: 2389
	// (get) Token: 0x060044A1 RID: 17569 RVA: 0x00016D58 File Offset: 0x00014F58
	// (set) Token: 0x060044A2 RID: 17570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000781")]
	public ItemID ItemID
	{
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x1F3F430", Offset = "0x1F3F531", VA = "0x1F3F430")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7910", Offset = "0x1A7A11")]
		get
		{
			return ItemID.ITEM_EMPTY;
		}
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x1F3F440", Offset = "0x1F3F541", VA = "0x1F3F440")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7920", Offset = "0x1A7A21")]
		private set
		{
		}
	}

	// Token: 0x060044A3 RID: 17571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003980")]
	[Address(RVA = "0x1F3F450", Offset = "0x1F3F551", VA = "0x1F3F450")]
	private void CheckImageNull()
	{
	}

	// Token: 0x060044A4 RID: 17572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003981")]
	[Address(RVA = "0x1F3F550", Offset = "0x1F3F651", VA = "0x1F3F550")]
	private void SetItemSprite()
	{
	}

	// Token: 0x060044A5 RID: 17573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003982")]
	[Address(RVA = "0x1F3EE00", Offset = "0x1F3EF01", VA = "0x1F3EE00")]
	public void UpdateMaterial(RecipeIdDispBlock _recipe_block)
	{
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003983")]
	[Address(RVA = "0x1F3F8B0", Offset = "0x1F3F9B1", VA = "0x1F3F8B0")]
	public RecipeMaterialSlot()
	{
	}

	// Token: 0x0400A377 RID: 41847
	[Token(Token = "0x4007B9D")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private int SlotNum;

	// Token: 0x0400A378 RID: 41848
	[Token(Token = "0x4007B9E")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Image Image;

	// Token: 0x0400A379 RID: 41849
	[Token(Token = "0x4007B9F")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Image XImg;

	// Token: 0x0400A37A RID: 41850
	[Token(Token = "0x4007BA0")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Image XImg2;

	// Token: 0x0400A37B RID: 41851
	[Token(Token = "0x4007BA1")]
	[FieldOffset(Offset = "0x78")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1723B0", Offset = "0x1724B1")]
	private ItemID <ItemID>k__BackingField;
}
