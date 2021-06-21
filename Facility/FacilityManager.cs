using System;
using System.Collections.Generic;
using DataTable;
using Define;
using Il2CppDummyDll;

namespace Facility
{
	// Token: 0x020010BA RID: 4282
	[Token(Token = "0x2000ABD")]
	public static class FacilityManager
	{
		// Token: 0x06006C61 RID: 27745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059EB")]
		[Address(RVA = "0x21C03F0", Offset = "0x21C04F1", VA = "0x21C03F0")]
		public static string SelectedItemName(ADVShopID shopID)
		{
			return null;
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059EC")]
		[Address(RVA = "0x21C0760", Offset = "0x21C0861", VA = "0x21C0760")]
		public static string SelectedCrystalFragmentName()
		{
			return null;
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x00025200 File Offset: 0x00023400
		[Token(Token = "0x60059ED")]
		[Address(RVA = "0x21C07F0", Offset = "0x21C08F1", VA = "0x21C07F0")]
		public static int CountSelectedCrystalFragment()
		{
			return 0;
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x00025218 File Offset: 0x00023418
		[Token(Token = "0x60059EE")]
		[Address(RVA = "0x21C08B0", Offset = "0x21C09B1", VA = "0x21C08B0")]
		public static int SelectedItemPrice(ADVShopID shopID)
		{
			return 0;
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059EF")]
		[Address(RVA = "0x21C0A20", Offset = "0x21C0B21", VA = "0x21C0A20")]
		public static string SelectedItemDetail(ADVShopID shopID)
		{
			return null;
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00025230 File Offset: 0x00023430
		[Token(Token = "0x60059F0")]
		[Address(RVA = "0x21C0C40", Offset = "0x21C0D41", VA = "0x21C0C40")]
		public static int SelectedItemTime(ADVShopID shopID)
		{
			return 0;
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F1")]
		[Address(RVA = "0x21C0D30", Offset = "0x21C0E31", VA = "0x21C0D30")]
		public static string Temporary_HotSpring()
		{
			return null;
		}

		// Token: 0x06006C68 RID: 27752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F2")]
		[Address(RVA = "0x21C0E60", Offset = "0x21C0F61", VA = "0x21C0E60")]
		public static string TemporaryTimeLimit_HotSpring()
		{
			return null;
		}

		// Token: 0x06006C69 RID: 27753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F3")]
		[Address(RVA = "0x21C0F20", Offset = "0x21C1021", VA = "0x21C0F20")]
		private static string CreateTextTimeLimit(int to, int current)
		{
			return null;
		}

		// Token: 0x06006C6A RID: 27754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x21C0FF0", Offset = "0x21C10F1", VA = "0x21C0FF0")]
		public static string Temporary_Vaccination()
		{
			return null;
		}

		// Token: 0x06006C6B RID: 27755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x21C1120", Offset = "0x21C1221", VA = "0x21C1120")]
		public static string TemporaryTimeLimit_Vaccination()
		{
			return null;
		}

		// Token: 0x06006C6C RID: 27756 RVA: 0x00025248 File Offset: 0x00023448
		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x21C11E0", Offset = "0x21C12E1", VA = "0x21C11E0")]
		public static ValueTuple<EventSelectGroupType, List<string>> GetADVShopList(ADVShopID id)
		{
			return default(ValueTuple<EventSelectGroupType, List<string>>);
		}

		// Token: 0x06006C6D RID: 27757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x21C2110", Offset = "0x21C2211", VA = "0x21C2110")]
		public static void OnSelectedMenu_ADVShopList(EventSelectGroupType eventSelectGroupType, int index)
		{
		}

		// Token: 0x06006C6E RID: 27758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x21C2520", Offset = "0x21C2621", VA = "0x21C2520")]
		public static void RevivalPlayer()
		{
		}

		// Token: 0x06006C6F RID: 27759 RVA: 0x00025260 File Offset: 0x00023460
		[Token(Token = "0x60059F9")]
		[Address(RVA = "0x21C2920", Offset = "0x21C2A21", VA = "0x21C2920")]
		public static bool IsCheckFreeRespawn()
		{
			return default(bool);
		}

		// Token: 0x06006C70 RID: 27760 RVA: 0x00025278 File Offset: 0x00023478
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0x21C2970", Offset = "0x21C2A71", VA = "0x21C2970")]
		public static int CalucRespawnCost()
		{
			return 0;
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x21C2E60", Offset = "0x21C2F61", VA = "0x21C2E60")]
		public static void ReduceRespawnCost()
		{
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FC")]
		[Address(RVA = "0x21C2F50", Offset = "0x21C3051", VA = "0x21C2F50")]
		public static void RespawnHeal()
		{
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x00025290 File Offset: 0x00023490
		[Token(Token = "0x60059FD")]
		[Address(RVA = "0x21C30D0", Offset = "0x21C31D1", VA = "0x21C30D0")]
		public static bool IsVaccination()
		{
			return default(bool);
		}

		// Token: 0x06006C74 RID: 27764 RVA: 0x000252A8 File Offset: 0x000234A8
		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x21C3150", Offset = "0x21C3251", VA = "0x21C3150")]
		public static bool BuyVaccination()
		{
			return default(bool);
		}

		// Token: 0x06006C75 RID: 27765 RVA: 0x000252C0 File Offset: 0x000234C0
		[Token(Token = "0x60059FF")]
		[Address(RVA = "0x21C2B60", Offset = "0x21C2C61", VA = "0x21C2B60")]
		public static bool IsPartyLover()
		{
			return default(bool);
		}

		// Token: 0x06006C76 RID: 27766 RVA: 0x000252D8 File Offset: 0x000234D8
		[Token(Token = "0x6005A00")]
		[Address(RVA = "0x21C2CE0", Offset = "0x21C2DE1", VA = "0x21C2CE0")]
		public static bool IsPartySpouses()
		{
			return default(bool);
		}

		// Token: 0x06006C77 RID: 27767 RVA: 0x000252F0 File Offset: 0x000234F0
		[Token(Token = "0x6005A01")]
		[Address(RVA = "0x21C32B0", Offset = "0x21C33B1", VA = "0x21C32B0")]
		public static int GetCount_Today_RecipePan(bool isBakery)
		{
			return 0;
		}

		// Token: 0x06006C78 RID: 27768 RVA: 0x00025308 File Offset: 0x00023508
		[Token(Token = "0x6005A02")]
		[Address(RVA = "0x21C3380", Offset = "0x21C3481", VA = "0x21C3380")]
		public static bool BuyRecipePan(bool isBakery)
		{
			return default(bool);
		}

		// Token: 0x06006C79 RID: 27769 RVA: 0x00025320 File Offset: 0x00023520
		[Token(Token = "0x6005A03")]
		[Address(RVA = "0x21C35E0", Offset = "0x21C36E1", VA = "0x21C35E0")]
		public static bool BuyClothShop()
		{
			return default(bool);
		}

		// Token: 0x06006C7A RID: 27770 RVA: 0x00025338 File Offset: 0x00023538
		[Token(Token = "0x6005A04")]
		[Address(RVA = "0x21C3760", Offset = "0x21C3861", VA = "0x21C3760")]
		public static bool IsBoughtClothAll()
		{
			return default(bool);
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x00025350 File Offset: 0x00023550
		[Token(Token = "0x6005A05")]
		[Address(RVA = "0x21C3A20", Offset = "0x21C3B21", VA = "0x21C3A20")]
		public static bool IsHotSpring()
		{
			return default(bool);
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x00025368 File Offset: 0x00023568
		[Token(Token = "0x6005A06")]
		[Address(RVA = "0x21C3AA0", Offset = "0x21C3BA1", VA = "0x21C3AA0")]
		public static bool BuyHotSpring()
		{
			return default(bool);
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A07")]
		[Address(RVA = "0x21C3CE0", Offset = "0x21C3DE1", VA = "0x21C3CE0")]
		public static void SetHotSpring(HotSpringID hotSpringID)
		{
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00025380 File Offset: 0x00023580
		[Token(Token = "0x6005A08")]
		[Address(RVA = "0x21C3D50", Offset = "0x21C3E51", VA = "0x21C3D50")]
		public static bool CheckRookieBadgeLimit(int lv)
		{
			return default(bool);
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00025398 File Offset: 0x00023598
		[Token(Token = "0x6005A09")]
		[Address(RVA = "0x21C3D60", Offset = "0x21C3E61", VA = "0x21C3D60")]
		public static bool TradeCrystal()
		{
			return default(bool);
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x000253B0 File Offset: 0x000235B0
		[Token(Token = "0x6005A0A")]
		[Address(RVA = "0x21C3F60", Offset = "0x21C4061", VA = "0x21C3F60")]
		public static int CountCrystalFragment(ItemID itemID)
		{
			return 0;
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0B")]
		[Address(RVA = "0x21C4020", Offset = "0x21C4121", VA = "0x21C4020")]
		public static void SelectedEquipSlotType(EquipSlotType type)
		{
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x000253C8 File Offset: 0x000235C8
		[Token(Token = "0x6005A0C")]
		[Address(RVA = "0x21C4090", Offset = "0x21C4191", VA = "0x21C4090")]
		public static bool SelectedEquipSlot_IsStrengthening()
		{
			return default(bool);
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x000253E0 File Offset: 0x000235E0
		[Token(Token = "0x6005A0D")]
		[Address(RVA = "0x21C4380", Offset = "0x21C4481", VA = "0x21C4380")]
		public static int GetSelectedEquipSlot_MaterialsNum()
		{
			return 0;
		}

		// Token: 0x06006C84 RID: 27780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A0E")]
		[Address(RVA = "0x21C4400", Offset = "0x21C4501", VA = "0x21C4400")]
		public static string GetSelectedEquipSlot_MaterialName(int index)
		{
			return null;
		}

		// Token: 0x06006C85 RID: 27781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A0F")]
		[Address(RVA = "0x21C44E0", Offset = "0x21C45E1", VA = "0x21C44E0")]
		public static string GetSelectedEquipSlot_Name()
		{
			return null;
		}

		// Token: 0x06006C86 RID: 27782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A10")]
		[Address(RVA = "0x21C4230", Offset = "0x21C4331", VA = "0x21C4230")]
		public static void SetSelectedEquipSlot_AllMaterialStr()
		{
		}

		// Token: 0x06006C87 RID: 27783 RVA: 0x000253F8 File Offset: 0x000235F8
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x21C4A80", Offset = "0x21C4B81", VA = "0x21C4A80")]
		public static int GetSelectedEquipSlot_BaseLvType()
		{
			return 0;
		}

		// Token: 0x06006C88 RID: 27784 RVA: 0x00025410 File Offset: 0x00023610
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x21C4C70", Offset = "0x21C4D71", VA = "0x21C4C70")]
		public static int GetSelectedEquipSlot_TotalMaterialBonusType()
		{
			return 0;
		}

		// Token: 0x06006C89 RID: 27785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x21C4640", Offset = "0x21C4741", VA = "0x21C4640")]
		private static void SetAllMaterialStr(EquipItemData item)
		{
		}

		// Token: 0x06006C8A RID: 27786 RVA: 0x00025428 File Offset: 0x00023628
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x21C4C20", Offset = "0x21C4D21", VA = "0x21C4C20")]
		private static int GetBaseLvType(EquipItemData item)
		{
			return 0;
		}

		// Token: 0x06006C8B RID: 27787 RVA: 0x00025440 File Offset: 0x00023640
		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x21C4E30", Offset = "0x21C4F31", VA = "0x21C4E30")]
		private static int GetTotalMaterialBonusType(EquipItemData item)
		{
			return 0;
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x00025458 File Offset: 0x00023658
		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x21C4EA0", Offset = "0x21C4FA1", VA = "0x21C4EA0")]
		public static int GetSelectedEquipSlot_SynthesisMaterialsNum()
		{
			return 0;
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x21C4F20", Offset = "0x21C5021", VA = "0x21C4F20")]
		public static string GetSelectedEquipSlot_SynthesisMaterialName()
		{
			return null;
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x21C5040", Offset = "0x21C5141", VA = "0x21C5040")]
		public static string GetSelectedEquipSlot_ArrangeOverrideMaterialName()
		{
			return null;
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x00025470 File Offset: 0x00023670
		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x21C5120", Offset = "0x21C5221", VA = "0x21C5120")]
		public static int GetFieldUniqueTreasureBox_OpenedNum()
		{
			return 0;
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x00025488 File Offset: 0x00023688
		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x21C5190", Offset = "0x21C5291", VA = "0x21C5190")]
		public static int GetFieldUniqueTreasureBox_MaxNum()
		{
			return 0;
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x000254A0 File Offset: 0x000236A0
		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0x21C51D0", Offset = "0x21C52D1", VA = "0x21C51D0")]
		public static bool IsEnableNPC(ActorID actorID)
		{
			return default(bool);
		}

		// Token: 0x040174A7 RID: 95399
		[Token(Token = "0x4013FC6")]
		[FieldOffset(Offset = "0x0")]
		private static RecipePanShopID Selected_RecipePanID;

		// Token: 0x040174A8 RID: 95400
		[Token(Token = "0x4013FC7")]
		[FieldOffset(Offset = "0x8")]
		private static List<RecipePanShopID> DisplayedList_RecipePanID;

		// Token: 0x040174A9 RID: 95401
		[Token(Token = "0x4013FC8")]
		[FieldOffset(Offset = "0x10")]
		private static ClothShopID Selected_ClothShopID;

		// Token: 0x040174AA RID: 95402
		[Token(Token = "0x4013FC9")]
		[FieldOffset(Offset = "0x18")]
		private static List<ClothShopID> DisplayedList_ClothShopID;

		// Token: 0x040174AB RID: 95403
		[Token(Token = "0x4013FCA")]
		[FieldOffset(Offset = "0x20")]
		private static HotSpringID Selected_HotSpringID;

		// Token: 0x040174AC RID: 95404
		[Token(Token = "0x4013FCB")]
		[FieldOffset(Offset = "0x28")]
		private static List<HotSpringID> DisplayedList_HotSpringID;

		// Token: 0x040174AD RID: 95405
		[Token(Token = "0x4013FCC")]
		[FieldOffset(Offset = "0x30")]
		private static VaccinationID Selected_VaccinationID;

		// Token: 0x040174AE RID: 95406
		[Token(Token = "0x4013FCD")]
		[FieldOffset(Offset = "0x38")]
		private static List<VaccinationID> DisplayedList_VaccinationID;

		// Token: 0x040174AF RID: 95407
		[Token(Token = "0x4013FCE")]
		[FieldOffset(Offset = "0x40")]
		private static ItemID Selected_CrystalID;

		// Token: 0x040174B0 RID: 95408
		[Token(Token = "0x4013FCF")]
		[FieldOffset(Offset = "0x48")]
		private static List<ItemID> DisplayedList_CrystalID;

		// Token: 0x040174B1 RID: 95409
		[Token(Token = "0x4013FD0")]
		[FieldOffset(Offset = "0x50")]
		private static EquipSlotType Selected_EquipSlotType;

		// Token: 0x040174B2 RID: 95410
		[Token(Token = "0x4013FD1")]
		private const int RookieBadgeLimit = 20;

		// Token: 0x040174B3 RID: 95411
		[Token(Token = "0x4013FD2")]
		[FieldOffset(Offset = "0x54")]
		public static bool IsKilledByWantedMonster;

		// Token: 0x040174B4 RID: 95412
		[Token(Token = "0x4013FD3")]
		[FieldOffset(Offset = "0x55")]
		public static bool IsFreeRespawn;

		// Token: 0x040174B5 RID: 95413
		[Token(Token = "0x4013FD4")]
		[FieldOffset(Offset = "0x58")]
		private static List<string> EquipAppraisalMaterials;

		// Token: 0x040174B6 RID: 95414
		[Token(Token = "0x4013FD5")]
		[FieldOffset(Offset = "0x60")]
		private static List<string> EquipSynthesisMaterials;

		// Token: 0x040174B7 RID: 95415
		[Token(Token = "0x4013FD6")]
		[FieldOffset(Offset = "0x68")]
		private static string EquipArrangeOverrideMaterial;

		// Token: 0x020010BB RID: 4283
		[Token(Token = "0x2001569")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15A040", Offset = "0x15A141")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006C94 RID: 27796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007D26")]
			[Address(RVA = "0x21C5A50", Offset = "0x21C5B51", VA = "0x21C5A50")]
			public <>c()
			{
			}

			// Token: 0x06006C95 RID: 27797 RVA: 0x000254B8 File Offset: 0x000236B8
			[Token(Token = "0x6007D27")]
			[Address(RVA = "0x21C5A60", Offset = "0x21C5B61", VA = "0x21C5A60")]
			internal bool <GetADVShopList>b__28_0(SerializeRecipePanShopDataTable d)
			{
				return default(bool);
			}

			// Token: 0x06006C96 RID: 27798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D28")]
			[Address(RVA = "0x21C5AB0", Offset = "0x21C5BB1", VA = "0x21C5AB0")]
			internal ItemDataTable <GetADVShopList>b__28_1(SerializeRecipePanShopDataTable d)
			{
				return null;
			}

			// Token: 0x06006C97 RID: 27799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D29")]
			[Address(RVA = "0x21C5AE0", Offset = "0x21C5BE1", VA = "0x21C5AE0")]
			internal string <GetADVShopList>b__28_2(ItemDataTable d)
			{
				return null;
			}

			// Token: 0x06006C98 RID: 27800 RVA: 0x000254D0 File Offset: 0x000236D0
			[Token(Token = "0x6007D2A")]
			[Address(RVA = "0x21C5B00", Offset = "0x21C5C01", VA = "0x21C5B00")]
			internal RecipePanShopID <GetADVShopList>b__28_3(SerializeRecipePanShopDataTable d)
			{
				return RecipePanShopID.EMPTY;
			}

			// Token: 0x06006C99 RID: 27801 RVA: 0x000254E8 File Offset: 0x000236E8
			[Token(Token = "0x6007D2B")]
			[Address(RVA = "0x21C5B20", Offset = "0x21C5C21", VA = "0x21C5B20")]
			internal bool <GetADVShopList>b__28_4(SerializeClothShopDataTable d)
			{
				return default(bool);
			}

			// Token: 0x06006C9A RID: 27802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D2C")]
			[Address(RVA = "0x21C5BA0", Offset = "0x21C5CA1", VA = "0x21C5BA0")]
			internal string <GetADVShopList>b__28_5(SerializeClothShopDataTable d)
			{
				return null;
			}

			// Token: 0x06006C9B RID: 27803 RVA: 0x00025500 File Offset: 0x00023700
			[Token(Token = "0x6007D2D")]
			[Address(RVA = "0x21C5CD0", Offset = "0x21C5DD1", VA = "0x21C5CD0")]
			internal ClothShopID <GetADVShopList>b__28_6(SerializeClothShopDataTable d)
			{
				return ClothShopID.ClothShop_01;
			}

			// Token: 0x06006C9C RID: 27804 RVA: 0x00025518 File Offset: 0x00023718
			[Token(Token = "0x6007D2E")]
			[Address(RVA = "0x21C5CF0", Offset = "0x21C5DF1", VA = "0x21C5CF0")]
			internal bool <GetADVShopList>b__28_7(SerializeHotSpringDataTable d)
			{
				return default(bool);
			}

			// Token: 0x06006C9D RID: 27805 RVA: 0x00025530 File Offset: 0x00023730
			[Token(Token = "0x6007D2F")]
			[Address(RVA = "0x21C5D20", Offset = "0x21C5E21", VA = "0x21C5D20")]
			internal bool <GetADVShopList>b__28_8(SerializeHotSpringDataTable d)
			{
				return default(bool);
			}

			// Token: 0x06006C9E RID: 27806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D30")]
			[Address(RVA = "0x21C5D70", Offset = "0x21C5E71", VA = "0x21C5D70")]
			internal string <GetADVShopList>b__28_9(SerializeHotSpringDataTable d)
			{
				return null;
			}

			// Token: 0x06006C9F RID: 27807 RVA: 0x00025548 File Offset: 0x00023748
			[Token(Token = "0x6007D31")]
			[Address(RVA = "0x21C5E70", Offset = "0x21C5F71", VA = "0x21C5E70")]
			internal HotSpringID <GetADVShopList>b__28_10(SerializeHotSpringDataTable d)
			{
				return HotSpringID.EMPTY;
			}

			// Token: 0x06006CA0 RID: 27808 RVA: 0x00025560 File Offset: 0x00023760
			[Token(Token = "0x6007D32")]
			[Address(RVA = "0x21C5E90", Offset = "0x21C5F91", VA = "0x21C5E90")]
			internal bool <GetADVShopList>b__28_11(SerializeVaccinationDataTable d)
			{
				return default(bool);
			}

			// Token: 0x06006CA1 RID: 27809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D33")]
			[Address(RVA = "0x21C5EE0", Offset = "0x21C5FE1", VA = "0x21C5EE0")]
			internal string <GetADVShopList>b__28_12(SerializeVaccinationDataTable d)
			{
				return null;
			}

			// Token: 0x06006CA2 RID: 27810 RVA: 0x00025578 File Offset: 0x00023778
			[Token(Token = "0x6007D34")]
			[Address(RVA = "0x21C5FE0", Offset = "0x21C60E1", VA = "0x21C5FE0")]
			internal VaccinationID <GetADVShopList>b__28_13(SerializeVaccinationDataTable d)
			{
				return VaccinationID.EMPTY;
			}

			// Token: 0x06006CA3 RID: 27811 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D35")]
			[Address(RVA = "0x21C6000", Offset = "0x21C6101", VA = "0x21C6000")]
			internal ItemDataTable <GetADVShopList>b__28_14(SerializeCrystalDataTable d)
			{
				return null;
			}

			// Token: 0x06006CA4 RID: 27812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007D36")]
			[Address(RVA = "0x21C6020", Offset = "0x21C6121", VA = "0x21C6020")]
			internal string <GetADVShopList>b__28_15(ItemDataTable d)
			{
				return null;
			}

			// Token: 0x06006CA5 RID: 27813 RVA: 0x00025590 File Offset: 0x00023790
			[Token(Token = "0x6007D37")]
			[Address(RVA = "0x21C6040", Offset = "0x21C6141", VA = "0x21C6040")]
			internal ItemID <GetADVShopList>b__28_16(SerializeCrystalDataTable d)
			{
				return ItemID.ITEM_EMPTY;
			}

			// Token: 0x06006CA6 RID: 27814 RVA: 0x000255A8 File Offset: 0x000237A8
			[Token(Token = "0x6007D38")]
			[Address(RVA = "0x21C6060", Offset = "0x21C6161", VA = "0x21C6060")]
			internal bool <RevivalPlayer>b__30_0([Attribute(Name = "TupleElementNamesAttribute", RVA = "0x1B84B0", Offset = "0x1B85B1")] ValueTuple<ActorID, int> n)
			{
				return default(bool);
			}

			// Token: 0x040174B8 RID: 95416
			[Token(Token = "0x401C0ED")]
			[FieldOffset(Offset = "0x0")]
			public static readonly FacilityManager.<>c <>9;

			// Token: 0x040174B9 RID: 95417
			[Token(Token = "0x401C0EE")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SerializeRecipePanShopDataTable, bool> <>9__28_0;

			// Token: 0x040174BA RID: 95418
			[Token(Token = "0x401C0EF")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SerializeRecipePanShopDataTable, ItemDataTable> <>9__28_1;

			// Token: 0x040174BB RID: 95419
			[Token(Token = "0x401C0F0")]
			[FieldOffset(Offset = "0x18")]
			public static Func<ItemDataTable, string> <>9__28_2;

			// Token: 0x040174BC RID: 95420
			[Token(Token = "0x401C0F1")]
			[FieldOffset(Offset = "0x20")]
			public static Func<SerializeRecipePanShopDataTable, RecipePanShopID> <>9__28_3;

			// Token: 0x040174BD RID: 95421
			[Token(Token = "0x401C0F2")]
			[FieldOffset(Offset = "0x28")]
			public static Func<SerializeClothShopDataTable, bool> <>9__28_4;

			// Token: 0x040174BE RID: 95422
			[Token(Token = "0x401C0F3")]
			[FieldOffset(Offset = "0x30")]
			public static Func<SerializeClothShopDataTable, string> <>9__28_5;

			// Token: 0x040174BF RID: 95423
			[Token(Token = "0x401C0F4")]
			[FieldOffset(Offset = "0x38")]
			public static Func<SerializeClothShopDataTable, ClothShopID> <>9__28_6;

			// Token: 0x040174C0 RID: 95424
			[Token(Token = "0x401C0F5")]
			[FieldOffset(Offset = "0x40")]
			public static Func<SerializeHotSpringDataTable, bool> <>9__28_7;

			// Token: 0x040174C1 RID: 95425
			[Token(Token = "0x401C0F6")]
			[FieldOffset(Offset = "0x48")]
			public static Func<SerializeHotSpringDataTable, bool> <>9__28_8;

			// Token: 0x040174C2 RID: 95426
			[Token(Token = "0x401C0F7")]
			[FieldOffset(Offset = "0x50")]
			public static Func<SerializeHotSpringDataTable, string> <>9__28_9;

			// Token: 0x040174C3 RID: 95427
			[Token(Token = "0x401C0F8")]
			[FieldOffset(Offset = "0x58")]
			public static Func<SerializeHotSpringDataTable, HotSpringID> <>9__28_10;

			// Token: 0x040174C4 RID: 95428
			[Token(Token = "0x401C0F9")]
			[FieldOffset(Offset = "0x60")]
			public static Func<SerializeVaccinationDataTable, bool> <>9__28_11;

			// Token: 0x040174C5 RID: 95429
			[Token(Token = "0x401C0FA")]
			[FieldOffset(Offset = "0x68")]
			public static Func<SerializeVaccinationDataTable, string> <>9__28_12;

			// Token: 0x040174C6 RID: 95430
			[Token(Token = "0x401C0FB")]
			[FieldOffset(Offset = "0x70")]
			public static Func<SerializeVaccinationDataTable, VaccinationID> <>9__28_13;

			// Token: 0x040174C7 RID: 95431
			[Token(Token = "0x401C0FC")]
			[FieldOffset(Offset = "0x78")]
			public static Func<SerializeCrystalDataTable, ItemDataTable> <>9__28_14;

			// Token: 0x040174C8 RID: 95432
			[Token(Token = "0x401C0FD")]
			[FieldOffset(Offset = "0x80")]
			public static Func<ItemDataTable, string> <>9__28_15;

			// Token: 0x040174C9 RID: 95433
			[Token(Token = "0x401C0FE")]
			[FieldOffset(Offset = "0x88")]
			public static Func<SerializeCrystalDataTable, ItemID> <>9__28_16;

			// Token: 0x040174CA RID: 95434
			[Token(Token = "0x401C0FF")]
			[FieldOffset(Offset = "0x90")]
			[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x199600", Offset = "0x199701")]
			public static Func<ValueTuple<ActorID, int>, bool> <>9__30_0;
		}
	}
}
