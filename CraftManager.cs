using System;
using System.Collections.Generic;
using Define;
using DualWork;
using Il2CppDummyDll;

// Token: 0x02000620 RID: 1568
[Token(Token = "0x200046D")]
public static class CraftManager
{
	// Token: 0x17000635 RID: 1589
	// (get) Token: 0x06002698 RID: 9880 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
	[Token(Token = "0x170004F3")]
	public static bool IsDualWork
	{
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x20E2980", Offset = "0x20E2A81", VA = "0x20E2980")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000636 RID: 1590
	// (get) Token: 0x06002699 RID: 9881 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
	// (set) Token: 0x0600269A RID: 9882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170004F4")]
	public static DualWorkType DualWorkType
	{
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x20E2A50", Offset = "0x20E2B51", VA = "0x20E2A50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1B20", Offset = "0x1A1C21")]
		get
		{
			return DualWorkType.BlackSmith;
		}
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x20E2AC0", Offset = "0x20E2BC1", VA = "0x20E2AC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1B30", Offset = "0x1A1C31")]
		set
		{
		}
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
	[Token(Token = "0x600209B")]
	[Address(RVA = "0x20E2B30", Offset = "0x20E2C31", VA = "0x20E2B30")]
	public static RecipeId FindMatchRecipe(CraftCategoryId recipeCatalogId, IEnumerable<ItemID> materialItems)
	{
		return RecipeId.EMPTY;
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
	[Token(Token = "0x600209C")]
	[Address(RVA = "0x20E3030", Offset = "0x20E3131", VA = "0x20E3030")]
	private static bool IsWeaponCategory(ItemCategory itemCategory)
	{
		return default(bool);
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x0000F300 File Offset: 0x0000D500
	[Token(Token = "0x600209D")]
	[Address(RVA = "0x20E3040", Offset = "0x20E3141", VA = "0x20E3040")]
	private static bool IsEquipCategory(ItemCategory itemCategory)
	{
		return default(bool);
	}

	// Token: 0x0600269E RID: 9886 RVA: 0x0000F318 File Offset: 0x0000D518
	[Token(Token = "0x600209E")]
	[Address(RVA = "0x20E3050", Offset = "0x20E3151", VA = "0x20E3050")]
	private static bool IsSmithOrDeco(ItemCategory itemCategory)
	{
		return default(bool);
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x0000F330 File Offset: 0x0000D530
	[Token(Token = "0x600209F")]
	[Address(RVA = "0x20E30F0", Offset = "0x20E31F1", VA = "0x20E30F0")]
	public static int CalucCraftCostRp(CraftCategoryId recipeCatalogId, RecipeId recipeId, ItemData[] materialItems, bool isBaseCost)
	{
		return 0;
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x0000F348 File Offset: 0x0000D548
	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x20E3880", Offset = "0x20E3981", VA = "0x20E3880")]
	public static ValueTuple<bool, ItemData[]> DoSynthesis(CraftCategoryId categoryId, RecipeId recipeId, ItemData[][] materialItemDatas, int craftNum, DualWorkType workType)
	{
		return default(ValueTuple<bool, ItemData[]>);
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x0000F360 File Offset: 0x0000D560
	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x20E3E50", Offset = "0x20E3F51", VA = "0x20E3E50")]
	public static ValueTuple<bool, ItemData> DoSynthesisInternal(CraftCategoryId categoryId, RecipeId recipeId, ItemData[] materialItems)
	{
		return default(ValueTuple<bool, ItemData>);
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x20E4BE0", Offset = "0x20E4CE1", VA = "0x20E4BE0")]
	private static void SetSynthesisEquipItemData(ref EquipItemData target, CraftCategoryId categoryId, ItemData[] materialItems, bool[] matchResult)
	{
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x20E5480", Offset = "0x20E5581", VA = "0x20E5480")]
	private static void SetSynthesisFoodItemData(ref FoodItemData target, CraftCategoryId categoryId, ItemData[] materialItems, bool[] matchResult)
	{
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x0000F378 File Offset: 0x0000D578
	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x20E5630", Offset = "0x20E5731", VA = "0x20E5630")]
	private static ValueTuple<int, int> CalcTotalLevels(int inputSozai, int inputLevel, CraftCategoryId categoryId)
	{
		return default(ValueTuple<int, int>);
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x0000F390 File Offset: 0x0000D590
	[Token(Token = "0x60020A5")]
	[Address(RVA = "0x20E2CE0", Offset = "0x20E2DE1", VA = "0x20E2CE0")]
	public static ValueTuple<bool, bool[]> IsRecipeSatisfied(RecipeId recipeId, IEnumerable<ItemID> materialItems)
	{
		return default(ValueTuple<bool, bool[]>);
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A6")]
	[Address(RVA = "0x20E57B0", Offset = "0x20E58B1", VA = "0x20E57B0")]
	public static ValueTuple<ItemData, StorageType>[] AutoFindItemDatasByRecipe(CraftCategoryId recipeCatalogId, RecipeId recipeId)
	{
		return null;
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x20E5E70", Offset = "0x20E5F71", VA = "0x20E5E70")]
	public static int[] HasItemCountAll(CraftCategoryId category, ItemID[] itemIDs)
	{
		return null;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x20E5B20", Offset = "0x20E5C21", VA = "0x20E5B20")]
	private static ValueTuple<ItemData, StorageType> AutoFindItemData_internal(CraftCategoryId recipeCatalogId, ItemID recipeSource)
	{
		return default(ValueTuple<ItemData, StorageType>);
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020A9")]
	[Address(RVA = "0x20E6050", Offset = "0x20E6151", VA = "0x20E6050")]
	private static ItemDataLinker FindGenreItemDataLinker(ItemID[] genreItemArray, ItemDataLinker hitDataLinker, StorageType[] targetStorage)
	{
		return null;
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AA")]
	[Address(RVA = "0x20E61E0", Offset = "0x20E62E1", VA = "0x20E61E0")]
	public static ItemData[] SearchAndReduceItem(CraftCategoryId craftCategoryId, ItemID[] materialItemID)
	{
		return null;
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x20E59F0", Offset = "0x20E5AF1", VA = "0x20E59F0")]
	public static StorageType[] CategoryToStorage(CraftCategoryId recipeCatalogId)
	{
		return null;
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x20E45A0", Offset = "0x20E46A1", VA = "0x20E45A0")]
	public static ItemID RandomFailureItemData(CraftCategoryId categoryId)
	{
		return ItemID.ITEM_EMPTY;
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020AD")]
	[Address(RVA = "0x20E4760", Offset = "0x20E4861", VA = "0x20E4760")]
	private static void GainSkillExp_Synthesis(bool success, RecipeId recipeId, CraftCategoryId categoryId, ItemData[] materialItems)
	{
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020AE")]
	[Address(RVA = "0x20E6520", Offset = "0x20E6621", VA = "0x20E6520")]
	private static void GainSkillExp_Strengthening(SkillID skillID, ItemData baseItemData, ItemData addItemData)
	{
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
	[Token(Token = "0x60020AF")]
	[Address(RVA = "0x20E6670", Offset = "0x20E6771", VA = "0x20E6670")]
	public static Parameter GetBaseLevelParam(int baseLevel, EquipItemFlag equipItemFlag)
	{
		return default(Parameter);
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x0000F3F0 File Offset: 0x0000D5F0
	[Token(Token = "0x60020B0")]
	[Address(RVA = "0x20E67A0", Offset = "0x20E68A1", VA = "0x20E67A0")]
	public static Parameter GetSozaiLevelParam(int sozaiLevel, EquipItemFlag equipItemFlag)
	{
		return default(Parameter);
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020B1")]
	[Address(RVA = "0x20E6A00", Offset = "0x20E6B01", VA = "0x20E6A00")]
	public static RecipeDataTableArray.RecipeDataTable GetRecipeDataTable(ItemID itemId)
	{
		return null;
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x0000F408 File Offset: 0x0000D608
	[Token(Token = "0x60020B2")]
	[Address(RVA = "0x20E6B60", Offset = "0x20E6C61", VA = "0x20E6B60")]
	public static ValueTuple<ItemData, int> GetResultStrengthening(EquipItemData baseItem, ItemData addItem, bool isWeapon)
	{
		return default(ValueTuple<ItemData, int>);
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x20E6F30", Offset = "0x20E7031", VA = "0x20E6F30")]
	public static ItemData DoStrengthening(EquipItemData baseItem, ItemData addItem, bool isWeapon)
	{
		return null;
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020B4")]
	[Address(RVA = "0x20E70D0", Offset = "0x20E71D1", VA = "0x20E70D0")]
	private static void FindCanLearningRecipe_internal(int cap, ref HashSet<RecipeId> set, CraftCategoryId craftCategoryId, SkillID skillID)
	{
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x0000F420 File Offset: 0x0000D620
	[Token(Token = "0x60020B5")]
	[Address(RVA = "0x20E7430", Offset = "0x20E7531", VA = "0x20E7430")]
	public static bool CheckAndLearnRecipePan(ItemData itemData)
	{
		return default(bool);
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020B6")]
	[Address(RVA = "0x20E7D00", Offset = "0x20E7E01", VA = "0x20E7D00")]
	private static void FindCanLearningRecipe_Drug(ref HashSet<RecipeId> ret, ItemID recipePanID)
	{
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020B7")]
	[Address(RVA = "0x20E7D90", Offset = "0x20E7E91", VA = "0x20E7D90")]
	private static void FindCanLearningRecipe_Cook(ref HashSet<RecipeId> ret, ItemID recipePanID)
	{
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020B8")]
	[Address(RVA = "0x20E8210", Offset = "0x20E8311", VA = "0x20E8210")]
	private static void FindCanLearningRecipe_Buki(ref HashSet<RecipeId> ret, ItemID recipePanID)
	{
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x20E8510", Offset = "0x20E8611", VA = "0x20E8510")]
	private static void FindCanLearningRecipe_Soshoku(ref HashSet<RecipeId> ret, ItemID recipePanID)
	{
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x20E85F0", Offset = "0x20E86F1", VA = "0x20E85F0")]
	private static void FindCanLearningRecipe_Nougu(ref HashSet<RecipeId> ret, ItemID recipePanID)
	{
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x0000F438 File Offset: 0x0000D638
	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x20E7990", Offset = "0x20E7A91", VA = "0x20E7990")]
	public static RecipeId CalcRecipeLearning(ItemID panId)
	{
		return RecipeId.EMPTY;
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x0000F450 File Offset: 0x0000D650
	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x20E72B0", Offset = "0x20E73B1", VA = "0x20E72B0")]
	private static bool CalcRecipeLevelCheck(int cap, int skillLv, RecipeId recipeID)
	{
		return default(bool);
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x0000F468 File Offset: 0x0000D668
	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x20E8900", Offset = "0x20E8A01", VA = "0x20E8900")]
	private static int Item_GetRecipeCount(CraftCategoryId craftCategoryId)
	{
		return 0;
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x20E8A30", Offset = "0x20E8B31", VA = "0x20E8A30")]
	public static string GetForTag_Recipe_ItemName(int index)
	{
		return null;
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x20E8AE0", Offset = "0x20E8BE1", VA = "0x20E8AE0")]
	public static string GetForTag_Release_FurnitureName(int index)
	{
		return null;
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x20E8C50", Offset = "0x20E8D51", VA = "0x20E8C50")]
	public static string GetForTag_Release_Category(int index)
	{
		return null;
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x20E8DF0", Offset = "0x20E8EF1", VA = "0x20E8DF0")]
	public static string GetForTag_FalseHint()
	{
		return null;
	}

	// Token: 0x04006D9D RID: 28061
	[Token(Token = "0x400669A")]
	[FieldOffset(Offset = "0x0")]
	public static CraftCategoryId CurrentCraftCategory;

	// Token: 0x04006D9E RID: 28062
	[Token(Token = "0x400669B")]
	[FieldOffset(Offset = "0x4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x168320", Offset = "0x168421")]
	private static DualWorkType <DualWorkType>k__BackingField;

	// Token: 0x04006D9F RID: 28063
	[Token(Token = "0x400669C")]
	private const int MaxLearn = 4;

	// Token: 0x04006DA0 RID: 28064
	[Token(Token = "0x400669D")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<ItemID, SkillID> FarmToolOutputItemIDtoSkillID;

	// Token: 0x04006DA1 RID: 28065
	[Token(Token = "0x400669E")]
	[FieldOffset(Offset = "0x10")]
	private static ItemID[] ReleasedRecipe_ItemIDs;

	// Token: 0x04006DA2 RID: 28066
	[Token(Token = "0x400669F")]
	[FieldOffset(Offset = "0x18")]
	private static FurnitureID[] ReleaseRecipe_Furnitures;

	// Token: 0x04006DA3 RID: 28067
	[Token(Token = "0x40066A0")]
	[FieldOffset(Offset = "0x20")]
	private static ItemID ReleaseFailRecipePan;

	// Token: 0x02000621 RID: 1569
	[Token(Token = "0x200113C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1580F0", Offset = "0x1581F1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060026C4 RID: 9924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60070EC")]
		[Address(RVA = "0x20E9350", Offset = "0x20E9451", VA = "0x20E9350")]
		public <>c()
		{
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0000F480 File Offset: 0x0000D680
		[Token(Token = "0x60070ED")]
		[Address(RVA = "0x20E9360", Offset = "0x20E9461", VA = "0x20E9360")]
		internal ItemID <CalucCraftCostRp>b__11_0(ItemData d)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0000F498 File Offset: 0x0000D698
		[Token(Token = "0x60070EE")]
		[Address(RVA = "0x20E9380", Offset = "0x20E9481", VA = "0x20E9380")]
		internal ItemID <CalucCraftCostRp>b__11_1(ItemData d)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		[Token(Token = "0x60070EF")]
		[Address(RVA = "0x20E93A0", Offset = "0x20E94A1", VA = "0x20E93A0")]
		internal ItemID <DoSynthesis>b__12_0(ItemData d)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		[Token(Token = "0x60070F0")]
		[Address(RVA = "0x20E93C0", Offset = "0x20E94C1", VA = "0x20E93C0")]
		internal ItemID <DoSynthesisInternal>b__13_0(ItemData d)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0000F4E0 File Offset: 0x0000D6E0
		[Token(Token = "0x60070F1")]
		[Address(RVA = "0x20E93E0", Offset = "0x20E94E1", VA = "0x20E93E0")]
		internal bool <DoSynthesisInternal>b__13_1(bool m)
		{
			return default(bool);
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		[Token(Token = "0x60070F2")]
		[Address(RVA = "0x20E93F0", Offset = "0x20E94F1", VA = "0x20E93F0")]
		internal int <SetSynthesisFoodItemData>b__15_0(ItemData m)
		{
			return 0;
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60070F3")]
		[Address(RVA = "0x20E9410", Offset = "0x20E9511", VA = "0x20E9410")]
		internal ItemStorage <SearchAndReduceItem>b__22_0(StorageType id)
		{
			return null;
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0000F510 File Offset: 0x0000D710
		[Token(Token = "0x60070F4")]
		[Address(RVA = "0x20E9480", Offset = "0x20E9581", VA = "0x20E9480")]
		internal bool <GainSkillExp_Synthesis>b__25_0(ItemData d)
		{
			return default(bool);
		}

		// Token: 0x04006DA4 RID: 28068
		[Token(Token = "0x4019376")]
		[FieldOffset(Offset = "0x0")]
		public static readonly CraftManager.<>c <>9;

		// Token: 0x04006DA5 RID: 28069
		[Token(Token = "0x4019377")]
		[FieldOffset(Offset = "0x8")]
		public static Func<ItemData, ItemID> <>9__11_0;

		// Token: 0x04006DA6 RID: 28070
		[Token(Token = "0x4019378")]
		[FieldOffset(Offset = "0x10")]
		public static Func<ItemData, ItemID> <>9__11_1;

		// Token: 0x04006DA7 RID: 28071
		[Token(Token = "0x4019379")]
		[FieldOffset(Offset = "0x18")]
		public static Func<ItemData, ItemID> <>9__12_0;

		// Token: 0x04006DA8 RID: 28072
		[Token(Token = "0x401937A")]
		[FieldOffset(Offset = "0x20")]
		public static Func<ItemData, ItemID> <>9__13_0;

		// Token: 0x04006DA9 RID: 28073
		[Token(Token = "0x401937B")]
		[FieldOffset(Offset = "0x28")]
		public static Func<bool, bool> <>9__13_1;

		// Token: 0x04006DAA RID: 28074
		[Token(Token = "0x401937C")]
		[FieldOffset(Offset = "0x30")]
		public static Func<ItemData, int> <>9__15_0;

		// Token: 0x04006DAB RID: 28075
		[Token(Token = "0x401937D")]
		[FieldOffset(Offset = "0x38")]
		public static Func<StorageType, ItemStorage> <>9__22_0;

		// Token: 0x04006DAC RID: 28076
		[Token(Token = "0x401937E")]
		[FieldOffset(Offset = "0x40")]
		public static Func<ItemData, bool> <>9__25_0;
	}
}
