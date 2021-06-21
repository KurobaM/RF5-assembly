using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000A3D RID: 2621
[Token(Token = "0x20006E4")]
public class RecipeItemPage : UIScrollBoxBase
{
	// Token: 0x17000953 RID: 2387
	// (get) Token: 0x06004488 RID: 17544 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004489 RID: 17545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700077F")]
	public CursorLinkConnector CursorLinker
	{
		[Token(Token = "0x600396B")]
		[Address(RVA = "0x1F3DC90", Offset = "0x1F3DD91", VA = "0x1F3DC90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A78D0", Offset = "0x1A79D1")]
		get
		{
			return null;
		}
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x1F3DCA0", Offset = "0x1F3DDA1", VA = "0x1F3DCA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A78E0", Offset = "0x1A79E1")]
		private set
		{
		}
	}

	// Token: 0x17000954 RID: 2388
	// (get) Token: 0x0600448A RID: 17546 RVA: 0x00016CF8 File Offset: 0x00014EF8
	[Token(Token = "0x17000780")]
	public bool HaveRecipe
	{
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x1F3DA90", Offset = "0x1F3DB91", VA = "0x1F3DA90")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600448B RID: 17547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600396E")]
	[Address(RVA = "0x1F3DCB0", Offset = "0x1F3DDB1", VA = "0x1F3DCB0")]
	private void Awake()
	{
	}

	// Token: 0x0600448C RID: 17548 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600396F")]
	[Address(RVA = "0x1F3DDB0", Offset = "0x1F3DEB1", VA = "0x1F3DDB0", Slot = "9")]
	protected override void Update()
	{
	}

	// Token: 0x0600448D RID: 17549 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003970")]
	[Address(RVA = "0x1F3E190", Offset = "0x1F3E291", VA = "0x1F3E190", Slot = "10")]
	protected override void OnDisable()
	{
	}

	// Token: 0x0600448E RID: 17550 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003971")]
	[Address(RVA = "0x1F3E220", Offset = "0x1F3E321", VA = "0x1F3E220")]
	public void InitOnInstantiate(CraftCategoryId _RecipeDataTableId, CursorLinker headBackLinker, [Optional] List<CraftCategoryId> _craftCategoryIds)
	{
	}

	// Token: 0x0600448F RID: 17551 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003972")]
	[Address(RVA = "0x1F3E380", Offset = "0x1F3E481", VA = "0x1F3E380")]
	private void GenerateRecipeBlock()
	{
	}

	// Token: 0x06004490 RID: 17552 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003973")]
	[Address(RVA = "0x1F3E880", Offset = "0x1F3E981", VA = "0x1F3E880")]
	private void ChangeCategory(int movPage)
	{
	}

	// Token: 0x06004491 RID: 17553 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003974")]
	[Address(RVA = "0x1F3EA50", Offset = "0x1F3EB51", VA = "0x1F3EA50")]
	private void ChangeCategory(CraftCategoryId _RecipeDataTableId)
	{
	}

	// Token: 0x06004492 RID: 17554 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003975")]
	[Address(RVA = "0x1F3DF50", Offset = "0x1F3E051", VA = "0x1F3DF50")]
	private void SetSort()
	{
	}

	// Token: 0x06004493 RID: 17555 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003976")]
	[Address(RVA = "0x1F3D960", Offset = "0x1F3DA61", VA = "0x1F3D960")]
	public void SetDispBlockOnFocus(RecipeIdDispBlock _recipe)
	{
	}

	// Token: 0x06004494 RID: 17556 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003977")]
	[Address(RVA = "0x1F3B390", Offset = "0x1F3B491", VA = "0x1F3B390")]
	public void OpenCraftPage(RecipeIdDispBlock backLink)
	{
	}

	// Token: 0x06004495 RID: 17557 RVA: 0x00016D10 File Offset: 0x00014F10
	[Token(Token = "0x6003978")]
	[Address(RVA = "0x1F3EAF0", Offset = "0x1F3EBF1", VA = "0x1F3EAF0", Slot = "5")]
	protected override int GetListCount()
	{
		return 0;
	}

	// Token: 0x06004496 RID: 17558 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6003979")]
	[Address(RVA = "0x1F3EB40", Offset = "0x1F3EC41", VA = "0x1F3EB40", Slot = "6")]
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button)
	{
	}

	// Token: 0x06004497 RID: 17559 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600397A")]
	[Address(RVA = "0x1F3EC00", Offset = "0x1F3ED01", VA = "0x1F3EC00", Slot = "7")]
	public override void SetFocusDetail()
	{
	}

	// Token: 0x06004498 RID: 17560 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600397B")]
	[Address(RVA = "0x1F3EE40", Offset = "0x1F3EF41", VA = "0x1F3EE40")]
	public RecipeItemPage()
	{
	}

	// Token: 0x06004499 RID: 17561 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600397C")]
	[Address(RVA = "0x1F3EEC0", Offset = "0x1F3EFC1", VA = "0x1F3EEC0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A78F0", Offset = "0x1A79F1")]
	private void <Awake>b__24_0()
	{
	}

	// Token: 0x0600449A RID: 17562 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600397D")]
	[Address(RVA = "0x1F3EF30", Offset = "0x1F3F031", VA = "0x1F3EF30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7900", Offset = "0x1A7A01")]
	private void <Awake>b__24_1()
	{
	}

	// Token: 0x0400A35F RID: 41823
	[Token(Token = "0x4007B8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SText CategoryText;

	// Token: 0x0400A360 RID: 41824
	[Token(Token = "0x4007B8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private UISortBlock sortBlock;

	// Token: 0x0400A361 RID: 41825
	[Token(Token = "0x4007B8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool sortRevert;

	// Token: 0x0400A362 RID: 41826
	[Token(Token = "0x4007B8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text RPText;

	// Token: 0x0400A363 RID: 41827
	[Token(Token = "0x4007B8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private CraftCategoryId CraftCategoryId;

	// Token: 0x0400A364 RID: 41828
	[Token(Token = "0x4007B8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<RecipeId> RecipeIdList;

	// Token: 0x0400A365 RID: 41829
	[Token(Token = "0x4007B90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject CraftPageObj;

	// Token: 0x0400A366 RID: 41830
	[Token(Token = "0x4007B91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private CursorLinker CraftPageMainCursorPoint;

	// Token: 0x0400A367 RID: 41831
	[Token(Token = "0x4007B92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private UICraftMenu UICraftMenu;

	// Token: 0x0400A368 RID: 41832
	[Token(Token = "0x4007B93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private GameObject[] HideOnCraftPageObjects;

	// Token: 0x0400A369 RID: 41833
	[Token(Token = "0x4007B94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool SortUpDown;

	// Token: 0x0400A36A RID: 41834
	[Token(Token = "0x4007B95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<CraftCategoryId> CraftCategoryIds;

	// Token: 0x0400A36B RID: 41835
	[Token(Token = "0x4007B96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private GameObject CategorySwitchButton;

	// Token: 0x0400A36C RID: 41836
	[Token(Token = "0x4007B97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private RecipeMaterialSlot[] materialSlot;

	// Token: 0x0400A36D RID: 41837
	[Token(Token = "0x4007B98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UICanvasGroupAnimation recipeGroup;

	// Token: 0x0400A36E RID: 41838
	[Token(Token = "0x4007B99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x172340", Offset = "0x172441")]
	private CursorLinkConnector <CursorLinker>k__BackingField;

	// Token: 0x0400A36F RID: 41839
	[Token(Token = "0x4007B9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private CursorLinker recipeBackLinker;

	// Token: 0x0400A370 RID: 41840
	[Token(Token = "0x4007B9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private NonFocusButton L_Button;

	// Token: 0x0400A371 RID: 41841
	[Token(Token = "0x4007B9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private NonFocusButton R_Button;

	// Token: 0x02000A3E RID: 2622
	[Token(Token = "0x20012DB")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159080", Offset = "0x159181")]
	private sealed class <>c__DisplayClass29_0
	{
		// Token: 0x0600449B RID: 17563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007601")]
		[Address(RVA = "0x1F3EA40", Offset = "0x1F3EB41", VA = "0x1F3EA40")]
		public <>c__DisplayClass29_0()
		{
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007602")]
		[Address(RVA = "0x1F3F3A0", Offset = "0x1F3F4A1", VA = "0x1F3F3A0")]
		internal void <ChangeCategory>b__0()
		{
		}

		// Token: 0x0400A372 RID: 41842
		[Token(Token = "0x401B438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RecipeItemPage <>4__this;

		// Token: 0x0400A373 RID: 41843
		[Token(Token = "0x401B439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int nextId;
	}

	// Token: 0x02000A3F RID: 2623
	[Token(Token = "0x20012DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159090", Offset = "0x159191")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600449E RID: 17566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007604")]
		[Address(RVA = "0x1F3F010", Offset = "0x1F3F111", VA = "0x1F3F010")]
		public <>c()
		{
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x00016D28 File Offset: 0x00014F28
		[Token(Token = "0x6007605")]
		[Address(RVA = "0x1F3F020", Offset = "0x1F3F121", VA = "0x1F3F020")]
		internal int <SetSort>b__31_0(RecipeId a, RecipeId b)
		{
			return 0;
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x00016D40 File Offset: 0x00014F40
		[Token(Token = "0x6007606")]
		[Address(RVA = "0x1F3F1E0", Offset = "0x1F3F2E1", VA = "0x1F3F1E0")]
		internal int <SetSort>b__31_1(RecipeId a, RecipeId b)
		{
			return 0;
		}

		// Token: 0x0400A374 RID: 41844
		[Token(Token = "0x401B43A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RecipeItemPage.<>c <>9;

		// Token: 0x0400A375 RID: 41845
		[Token(Token = "0x401B43B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Comparison<RecipeId> <>9__31_0;

		// Token: 0x0400A376 RID: 41846
		[Token(Token = "0x401B43C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Comparison<RecipeId> <>9__31_1;
	}
}
