using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A3A RID: 2618
[Token(Token = "0x20006E2")]
public class RecipeGroupDispBlock : UIButtonLinkerInScrollBox
{
	// Token: 0x17000951 RID: 2385
	// (get) Token: 0x06004471 RID: 17521 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004472 RID: 17522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700077D")]
	public RecipeGroupBase RecipeGroup
	{
		[Token(Token = "0x6003957")]
		[Address(RVA = "0x1F3C490", Offset = "0x1F3C591", VA = "0x1F3C490")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7890", Offset = "0x1A7991")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x1F3C4A0", Offset = "0x1F3C5A1", VA = "0x1F3C4A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A78A0", Offset = "0x1A79A1")]
		private set
		{
		}
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003959")]
	[Address(RVA = "0x1F3C4B0", Offset = "0x1F3C5B1", VA = "0x1F3C4B0", Slot = "16")]
	public override void Init()
	{
	}

	// Token: 0x06004474 RID: 17524 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600395A")]
	[Address(RVA = "0x1F3C540", Offset = "0x1F3C641", VA = "0x1F3C540", Slot = "9")]
	public override void InComingFocus(CursorLinker prevObject)
	{
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600395B")]
	[Address(RVA = "0x1F3C630", Offset = "0x1F3C731", VA = "0x1F3C630")]
	public void Disp(RecipeGroupBase recipe)
	{
	}

	// Token: 0x06004476 RID: 17526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600395C")]
	[Address(RVA = "0x1F3C7C0", Offset = "0x1F3C8C1", VA = "0x1F3C7C0", Slot = "10")]
	public override void OnFocus()
	{
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600395D")]
	[Address(RVA = "0x1F3C880", Offset = "0x1F3C981", VA = "0x1F3C880", Slot = "11")]
	public override void EndFocus()
	{
	}

	// Token: 0x06004478 RID: 17528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600395E")]
	[Address(RVA = "0x1F3C940", Offset = "0x1F3CA41", VA = "0x1F3C940")]
	public RecipeGroupDispBlock()
	{
	}

	// Token: 0x0400A34D RID: 41805
	[Token(Token = "0x4007B7A")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1721D0", Offset = "0x1722D1")]
	private RecipeGroupBase <RecipeGroup>k__BackingField;

	// Token: 0x0400A34E RID: 41806
	[Token(Token = "0x4007B7B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image NoSelectBorder;

	// Token: 0x0400A34F RID: 41807
	[Token(Token = "0x4007B7C")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image SelectedBorder;

	// Token: 0x0400A350 RID: 41808
	[Token(Token = "0x4007B7D")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Text NameText;

	// Token: 0x0400A351 RID: 41809
	[Token(Token = "0x4007B7E")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Text LvText;

	// Token: 0x0400A352 RID: 41810
	[Token(Token = "0x4007B7F")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Image Gauge;

	// Token: 0x0400A353 RID: 41811
	[Token(Token = "0x4007B80")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text ExpPercent;

	// Token: 0x0400A354 RID: 41812
	[Token(Token = "0x4007B81")]
	[FieldOffset(Offset = "0xA8")]
	private GenerateRecipeGroupDispObject MyGenerator;
}
