using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using DualWork;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Token: 0x02000A59 RID: 2649
[Token(Token = "0x20006F5")]
public class UICraftMenu : CursorLinkConnector
{
	// Token: 0x1700095E RID: 2398
	// (get) Token: 0x06004518 RID: 17688 RVA: 0x00016E60 File Offset: 0x00015060
	// (set) Token: 0x06004519 RID: 17689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000786")]
	public RecipeId SelectedRecipeId
	{
		[Token(Token = "0x60039E2")]
		[Address(RVA = "0x2003200", Offset = "0x2003301", VA = "0x2003200")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7AE0", Offset = "0x1A7BE1")]
		get
		{
			return RecipeId.EMPTY;
		}
		[Token(Token = "0x60039E3")]
		[Address(RVA = "0x2003210", Offset = "0x2003311", VA = "0x2003210")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7AF0", Offset = "0x1A7BF1")]
		set
		{
		}
	}

	// Token: 0x1700095F RID: 2399
	// (get) Token: 0x0600451A RID: 17690 RVA: 0x00016E78 File Offset: 0x00015078
	// (set) Token: 0x0600451B RID: 17691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000787")]
	public static bool IsCraftFist
	{
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x2003220", Offset = "0x2003321", VA = "0x2003220")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B00", Offset = "0x1A7C01")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60039E5")]
		[Address(RVA = "0x2003270", Offset = "0x2003371", VA = "0x2003270")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B10", Offset = "0x1A7C11")]
		private set
		{
		}
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039E6")]
	[Address(RVA = "0x20032D0", Offset = "0x20033D1", VA = "0x20032D0")]
	private void Start()
	{
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039E7")]
	[Address(RVA = "0x2003C70", Offset = "0x2003D71", VA = "0x2003C70")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600451E RID: 17694 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039E8")]
	[Address(RVA = "0x2003970", Offset = "0x2003A71", VA = "0x2003970")]
	public void OpenRecipeItemPage(CraftCategoryId id)
	{
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039E9")]
	[Address(RVA = "0x2003CD0", Offset = "0x2003DD1", VA = "0x2003CD0")]
	public void CloseRecipeItemPage()
	{
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039EA")]
	[Address(RVA = "0x2004070", Offset = "0x2004171", VA = "0x2004070")]
	public void OnCraftPage()
	{
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039EB")]
	[Address(RVA = "0x2004E50", Offset = "0x2004F51", VA = "0x2004E50")]
	public void DoTutorialCraft()
	{
	}

	// Token: 0x06004522 RID: 17698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039EC")]
	[Address(RVA = "0x2005370", Offset = "0x2005471", VA = "0x2005370")]
	public void DoSynthesis(DualWorkType workType)
	{
	}

	// Token: 0x06004523 RID: 17699 RVA: 0x00016E90 File Offset: 0x00015090
	[Token(Token = "0x60039ED")]
	[Address(RVA = "0x2006370", Offset = "0x2006471", VA = "0x2006370")]
	public bool CanRequestCraftNum(bool isLeft)
	{
		return default(bool);
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039EE")]
	[Address(RVA = "0x2006410", Offset = "0x2006511", VA = "0x2006410")]
	public void RequestCraftNum(bool isLeft)
	{
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039EF")]
	[Address(RVA = "0x2006510", Offset = "0x2006611", VA = "0x2006510")]
	public void OnUpdateCraftSlot()
	{
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F0")]
	[Address(RVA = "0x2004880", Offset = "0x2004981", VA = "0x2004880")]
	private void UpdateCraftNumMax(ItemID[] itemIDs)
	{
	}

	// Token: 0x06004527 RID: 17703 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F1")]
	[Address(RVA = "0x2004AE0", Offset = "0x2004BE1", VA = "0x2004AE0")]
	private void UpdateUSERP([Optional] ItemData[] itemDatas)
	{
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F2")]
	[Address(RVA = "0x2003A90", Offset = "0x2003B91", VA = "0x2003A90")]
	private void UpdateMenuTitle(CraftCategoryId craftCategoryId)
	{
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F3")]
	[Address(RVA = "0x2003B30", Offset = "0x2003C31", VA = "0x2003B30")]
	private void UpdatePlayerStatusOnTopMenu()
	{
	}

	// Token: 0x0600452A RID: 17706 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F4")]
	[Address(RVA = "0x20067D0", Offset = "0x20068D1", VA = "0x20067D0")]
	public UICraftMenu()
	{
	}

	// Token: 0x0600452B RID: 17707 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F5")]
	[Address(RVA = "0x2006850", Offset = "0x2006951", VA = "0x2006850")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B20", Offset = "0x1A7C21")]
	private void <DoTutorialCraft>b__28_3()
	{
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F6")]
	[Address(RVA = "0x2006860", Offset = "0x2006961", VA = "0x2006860")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B30", Offset = "0x1A7C31")]
	private void <DoSynthesis>b__29_7()
	{
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60039F7")]
	[Address(RVA = "0x2006870", Offset = "0x2006971", VA = "0x2006870")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A7B40", Offset = "0x1A7C41")]
	private void <DoSynthesis>b__29_8()
	{
	}

	// Token: 0x0400A405 RID: 41989
	[Token(Token = "0x4007C0D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public CraftCategoryId CraftCategoryId;

	// Token: 0x0400A406 RID: 41990
	[Token(Token = "0x4007C0E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private RecipeItemPage RecipeItemPage;

	// Token: 0x0400A407 RID: 41991
	[Token(Token = "0x4007C0F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<ButtonLinker> CraftSlots;

	// Token: 0x0400A408 RID: 41992
	[Token(Token = "0x4007C10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private ButtonLinker[] materialSlot;

	// Token: 0x0400A409 RID: 41993
	[Token(Token = "0x4007C11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private UIStrengtheningTopMenu topMenu;

	// Token: 0x0400A40A RID: 41994
	[Token(Token = "0x4007C12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private UICraftResult craftResult;

	// Token: 0x0400A40B RID: 41995
	[Token(Token = "0x4007C13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private CursorLinker itemSlotL1;

	// Token: 0x0400A40C RID: 41996
	[Token(Token = "0x4007C14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private CursorLinker itemSlotR1;

	// Token: 0x0400A40D RID: 41997
	[Token(Token = "0x4007C15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Text USERP_Text;

	// Token: 0x0400A40E RID: 41998
	[Token(Token = "0x4007C16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Text CraftNumText;

	// Token: 0x0400A40F RID: 41999
	[Token(Token = "0x4007C17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<CraftCategoryId> CraftCategoryIdList;

	// Token: 0x0400A410 RID: 42000
	[Token(Token = "0x4007C18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1729B0", Offset = "0x172AB1")]
	private RecipeId <SelectedRecipeId>k__BackingField;

	// Token: 0x0400A411 RID: 42001
	[Token(Token = "0x4007C19")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private int CraftNum;

	// Token: 0x0400A412 RID: 42002
	[Token(Token = "0x4007C1A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int OneCostRP;

	// Token: 0x0400A413 RID: 42003
	[Token(Token = "0x4007C1B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool OnTutorial;

	// Token: 0x0400A414 RID: 42004
	[Token(Token = "0x4007C1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private int CraftNumMax;

	// Token: 0x0400A415 RID: 42005
	[Token(Token = "0x4007C1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1729C0", Offset = "0x172AC1")]
	private static bool <IsCraftFist>k__BackingField;

	// Token: 0x02000A5A RID: 2650
	[Token(Token = "0x20012E6")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1590E0", Offset = "0x1591E1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600452F RID: 17711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600761B")]
		[Address(RVA = "0x20068F0", Offset = "0x20069F1", VA = "0x20068F0")]
		public <>c()
		{
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600761C")]
		[Address(RVA = "0x2006900", Offset = "0x2006A01", VA = "0x2006900")]
		internal void <Start>b__23_0()
		{
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600761D")]
		[Address(RVA = "0x2006960", Offset = "0x2006A61", VA = "0x2006960")]
		internal void <CloseRecipeItemPage>b__26_0()
		{
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00016EA8 File Offset: 0x000150A8
		[Token(Token = "0x600761E")]
		[Address(RVA = "0x20069C0", Offset = "0x2006AC1", VA = "0x20069C0")]
		internal bool <OnCraftPage>b__27_0([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B82D0", Offset = "0x1B83D1")] ValueTuple<ItemData, StorageType> d)
		{
			return default(bool);
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00016EC0 File Offset: 0x000150C0
		[Token(Token = "0x600761F")]
		[Address(RVA = "0x20069D0", Offset = "0x2006AD1", VA = "0x20069D0")]
		internal ItemID <OnCraftPage>b__27_1([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B8370", Offset = "0x1B8471")] ValueTuple<ItemData, StorageType> d)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007620")]
		[Address(RVA = "0x20069F0", Offset = "0x2006AF1", VA = "0x20069F0")]
		internal ItemData <OnCraftPage>b__27_2([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B8410", Offset = "0x1B8511")] ValueTuple<ItemData, StorageType> d)
		{
			return null;
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00016ED8 File Offset: 0x000150D8
		[Token(Token = "0x6007621")]
		[Address(RVA = "0x2006A00", Offset = "0x2006B01", VA = "0x2006A00")]
		internal bool <DoTutorialCraft>b__28_0(ButtonLinker s)
		{
			return default(bool);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007622")]
		[Address(RVA = "0x2006A40", Offset = "0x2006B41", VA = "0x2006A40")]
		internal ItemData <DoTutorialCraft>b__28_1(ButtonLinker s)
		{
			return null;
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007623")]
		[Address(RVA = "0x2006A70", Offset = "0x2006B71", VA = "0x2006A70")]
		internal void <DoTutorialCraft>b__28_2(bool _select)
		{
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00016EF0 File Offset: 0x000150F0
		[Token(Token = "0x6007624")]
		[Address(RVA = "0x2006A80", Offset = "0x2006B81", VA = "0x2006A80")]
		internal bool <DoSynthesis>b__29_0(ButtonLinker s)
		{
			return default(bool);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007625")]
		[Address(RVA = "0x2006AC0", Offset = "0x2006BC1", VA = "0x2006AC0")]
		internal ItemData <DoSynthesis>b__29_1(ButtonLinker s)
		{
			return null;
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00016F08 File Offset: 0x00015108
		[Token(Token = "0x6007626")]
		[Address(RVA = "0x2006AF0", Offset = "0x2006BF1", VA = "0x2006AF0")]
		internal ItemID <DoSynthesis>b__29_2(ItemData i)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007627")]
		[Address(RVA = "0x2006B10", Offset = "0x2006C11", VA = "0x2006B10")]
		internal void <DoSynthesis>b__29_3(bool _select)
		{
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00016F20 File Offset: 0x00015120
		[Token(Token = "0x6007628")]
		[Address(RVA = "0x2006B20", Offset = "0x2006C21", VA = "0x2006B20")]
		internal ItemID <DoSynthesis>b__29_4(ItemData d)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007629")]
		[Address(RVA = "0x2006B40", Offset = "0x2006C41", VA = "0x2006B40")]
		internal void <DoSynthesis>b__29_5(bool _select)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600762A")]
		[Address(RVA = "0x2006B50", Offset = "0x2006C51", VA = "0x2006B50")]
		internal void <DoSynthesis>b__29_6()
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00016F38 File Offset: 0x00015138
		[Token(Token = "0x600762B")]
		[Address(RVA = "0x2006BE0", Offset = "0x2006CE1", VA = "0x2006BE0")]
		internal bool <OnUpdateCraftSlot>b__32_0(ButtonLinker s)
		{
			return default(bool);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00016F50 File Offset: 0x00015150
		[Token(Token = "0x600762C")]
		[Address(RVA = "0x2006C20", Offset = "0x2006D21", VA = "0x2006C20")]
		internal ItemID <OnUpdateCraftSlot>b__32_1(ButtonLinker s)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600762D")]
		[Address(RVA = "0x2006C60", Offset = "0x2006D61", VA = "0x2006C60")]
		internal ItemData <OnUpdateCraftSlot>b__32_2(ButtonLinker s)
		{
			return null;
		}

		// Token: 0x0400A416 RID: 42006
		[Token(Token = "0x401B45B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly UICraftMenu.<>c <>9;

		// Token: 0x0400A417 RID: 42007
		[Token(Token = "0x401B45C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__23_0;

		// Token: 0x0400A418 RID: 42008
		[Token(Token = "0x401B45D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static UnityAction <>9__26_0;

		// Token: 0x0400A419 RID: 42009
		[Token(Token = "0x401B45E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1955D0", Offset = "0x1956D1")]
		public static Func<ValueTuple<ItemData, StorageType>, bool> <>9__27_0;

		// Token: 0x0400A41A RID: 42010
		[Token(Token = "0x401B45F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x195670", Offset = "0x195771")]
		public static Func<ValueTuple<ItemData, StorageType>, ItemID> <>9__27_1;

		// Token: 0x0400A41B RID: 42011
		[Token(Token = "0x401B460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x195710", Offset = "0x195811")]
		public static Func<ValueTuple<ItemData, StorageType>, ItemData> <>9__27_2;

		// Token: 0x0400A41C RID: 42012
		[Token(Token = "0x401B461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<ButtonLinker, bool> <>9__28_0;

		// Token: 0x0400A41D RID: 42013
		[Token(Token = "0x401B462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Func<ButtonLinker, ItemData> <>9__28_1;

		// Token: 0x0400A41E RID: 42014
		[Token(Token = "0x401B463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static UnityAction<bool> <>9__28_2;

		// Token: 0x0400A41F RID: 42015
		[Token(Token = "0x401B464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<ButtonLinker, bool> <>9__29_0;

		// Token: 0x0400A420 RID: 42016
		[Token(Token = "0x401B465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Func<ButtonLinker, ItemData> <>9__29_1;

		// Token: 0x0400A421 RID: 42017
		[Token(Token = "0x401B466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Func<ItemData, ItemID> <>9__29_2;

		// Token: 0x0400A422 RID: 42018
		[Token(Token = "0x401B467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static UnityAction<bool> <>9__29_3;

		// Token: 0x0400A423 RID: 42019
		[Token(Token = "0x401B468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Func<ItemData, ItemID> <>9__29_4;

		// Token: 0x0400A424 RID: 42020
		[Token(Token = "0x401B469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static UnityAction<bool> <>9__29_5;

		// Token: 0x0400A425 RID: 42021
		[Token(Token = "0x401B46A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static UnityAction <>9__29_6;

		// Token: 0x0400A426 RID: 42022
		[Token(Token = "0x401B46B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static Func<ButtonLinker, bool> <>9__32_0;

		// Token: 0x0400A427 RID: 42023
		[Token(Token = "0x401B46C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static Func<ButtonLinker, ItemID> <>9__32_1;

		// Token: 0x0400A428 RID: 42024
		[Token(Token = "0x401B46D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static Func<ButtonLinker, ItemData> <>9__32_2;
	}
}
