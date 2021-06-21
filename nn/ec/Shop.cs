using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using nn.account;

namespace nn.ec
{
	// Token: 0x020015DE RID: 5598
	[Token(Token = "0x2000F64")]
	public static class Shop
	{
		// Token: 0x06007F88 RID: 32648
		[Token(Token = "0x60069DC")]
		[Address(RVA = "0x2853EF0", Offset = "0x2853FF1", VA = "0x2853EF0")]
		[PreserveSig]
		public static extern void ShowApplicationInformation(ulong applicationId);

		// Token: 0x06007F89 RID: 32649
		[Token(Token = "0x60069DD")]
		[Address(RVA = "0x2853F00", Offset = "0x2854001", VA = "0x2853F00")]
		[PreserveSig]
		public static extern void ShowApplicationInformation(ulong applicationId, UserHandle selectedUser);

		// Token: 0x06007F8A RID: 32650
		[Token(Token = "0x60069DE")]
		[Address(RVA = "0x2853F30", Offset = "0x2854031", VA = "0x2853F30")]
		[PreserveSig]
		public static extern void ShowAddOnContentList(ulong applicationId);

		// Token: 0x06007F8B RID: 32651
		[Token(Token = "0x60069DF")]
		[Address(RVA = "0x2853F40", Offset = "0x2854041", VA = "0x2853F40")]
		[PreserveSig]
		public static extern void ShowAddOnContentList(ulong applicationId, UserHandle selectedUser);

		// Token: 0x06007F8C RID: 32652
		[Token(Token = "0x60069E0")]
		[Address(RVA = "0x2853F70", Offset = "0x2854071", VA = "0x2853F70")]
		[PreserveSig]
		public static extern void ShowSubscriptionList(ulong applicationId);

		// Token: 0x06007F8D RID: 32653
		[Token(Token = "0x60069E1")]
		[Address(RVA = "0x2853F80", Offset = "0x2854081", VA = "0x2853F80")]
		[PreserveSig]
		public static extern void ShowSubscriptionList(ulong applicationId, UserHandle selectedUser);

		// Token: 0x06007F8E RID: 32654
		[Token(Token = "0x60069E2")]
		[Address(RVA = "0x2853FB0", Offset = "0x28540B1", VA = "0x2853FB0")]
		[PreserveSig]
		public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId);

		// Token: 0x06007F8F RID: 32655
		[Token(Token = "0x60069E3")]
		[Address(RVA = "0x2854010", Offset = "0x2854111", VA = "0x2854010")]
		[PreserveSig]
		public static extern void ShowSubscriptionList(ulong applicationId, CourseId courseId, UserHandle selectedUser);

		// Token: 0x06007F90 RID: 32656
		[Token(Token = "0x60069E4")]
		[Address(RVA = "0x2854090", Offset = "0x2854191", VA = "0x2854090")]
		[PreserveSig]
		public static extern void ShowConsumableItemList(ulong applicationId);

		// Token: 0x06007F91 RID: 32657
		[Token(Token = "0x60069E5")]
		[Address(RVA = "0x28540A0", Offset = "0x28541A1", VA = "0x28540A0")]
		[PreserveSig]
		public static extern void ShowConsumableItemList(ulong applicationId, UserHandle selectedUser);

		// Token: 0x06007F92 RID: 32658
		[Token(Token = "0x60069E6")]
		[Address(RVA = "0x28540D0", Offset = "0x28541D1", VA = "0x28540D0")]
		[PreserveSig]
		public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid);

		// Token: 0x06007F93 RID: 32659
		[Token(Token = "0x60069E7")]
		[Address(RVA = "0x2854140", Offset = "0x2854241", VA = "0x2854140")]
		[PreserveSig]
		public static extern void ShowConsumableItemDetail(ulong applicationId, ConsumableId consumableId, NsUid nsUid, UserHandle selectedUser);

		// Token: 0x06007F94 RID: 32660
		[Token(Token = "0x60069E8")]
		[Address(RVA = "0x28541D0", Offset = "0x28542D1", VA = "0x28541D0")]
		[PreserveSig]
		public static extern void ShowEnterCodeScene();

		// Token: 0x06007F95 RID: 32661
		[Token(Token = "0x60069E9")]
		[Address(RVA = "0x28541E0", Offset = "0x28542E1", VA = "0x28541E0")]
		[PreserveSig]
		public static extern void ShowEnterCodeScene(UserHandle selectedUser);

		// Token: 0x06007F96 RID: 32662
		[Token(Token = "0x60069EA")]
		[Address(RVA = "0x2854210", Offset = "0x2854311", VA = "0x2854210")]
		[PreserveSig]
		public static extern void ShowShopProductDetails(NsUid nsuid);

		// Token: 0x06007F97 RID: 32663
		[Token(Token = "0x60069EB")]
		[Address(RVA = "0x2854220", Offset = "0x2854321", VA = "0x2854220")]
		[PreserveSig]
		public static extern void ShowShopProductDetails(NsUid nsuid, UserHandle selectedUser);

		// Token: 0x06007F98 RID: 32664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EC")]
		[Address(RVA = "0x2854250", Offset = "0x2854351", VA = "0x2854250")]
		public static void ShowShopProductList(NsUid[] nsuidList, string listName)
		{
		}

		// Token: 0x06007F99 RID: 32665
		[Token(Token = "0x60069ED")]
		[Address(RVA = "0x28542A0", Offset = "0x28543A1", VA = "0x28542A0")]
		[PreserveSig]
		private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName);

		// Token: 0x06007F9A RID: 32666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60069EE")]
		[Address(RVA = "0x28542F0", Offset = "0x28543F1", VA = "0x28542F0")]
		public static void ShowShopProductList(NsUid[] nsuidList, string listName, UserHandle selectedUser)
		{
		}

		// Token: 0x06007F9B RID: 32667
		[Token(Token = "0x60069EF")]
		[Address(RVA = "0x2854370", Offset = "0x2854471", VA = "0x2854370")]
		[PreserveSig]
		private static extern void ShowShopProductList(NsUid[] nsuidList, int nsuidCount, string listName, UserHandle selectedUser);

		// Token: 0x06007F9C RID: 32668
		[Token(Token = "0x60069F0")]
		[Address(RVA = "0x28543F0", Offset = "0x28544F1", VA = "0x28543F0")]
		[PreserveSig]
		public static extern NsUid MakeNsUid(string str);
	}
}
