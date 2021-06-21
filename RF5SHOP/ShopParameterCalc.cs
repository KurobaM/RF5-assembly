using System;
using Define;
using Il2CppDummyDll;

namespace RF5SHOP
{
	// Token: 0x02000E6A RID: 3690
	[Token(Token = "0x2000973")]
	public class ShopParameterCalc
	{
		// Token: 0x060060EB RID: 24811 RVA: 0x00020700 File Offset: 0x0001E900
		[Token(Token = "0x600503F")]
		[Address(RVA = "0x217A970", Offset = "0x217AA71", VA = "0x217A970")]
		private int GetBuilderLv(BuilderId builderId, int maxLv)
		{
			return 0;
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00020718 File Offset: 0x0001E918
		[Token(Token = "0x6005040")]
		[Address(RVA = "0x2178D10", Offset = "0x2178E11", VA = "0x2178D10")]
		public int GetShopLv(NpcShopType shopType)
		{
			return 0;
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x00020730 File Offset: 0x0001E930
		[Token(Token = "0x6005041")]
		[Address(RVA = "0x217A9F0", Offset = "0x217AAF1", VA = "0x217A9F0")]
		public bool CheckShopItemCondition(ulong conditionId, GameFlagData storyLineFrags, int conditionShopLv, int myShopLv, NPCID npcId)
		{
			return default(bool);
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x00020748 File Offset: 0x0001E948
		[Token(Token = "0x6005042")]
		[Address(RVA = "0x2179400", Offset = "0x2179501", VA = "0x2179400")]
		public bool CheckShopItemCondition(NpcShopType shopType, ShopItem shopItem, int myShopLv, NPCID npcId)
		{
			return default(bool);
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x00020760 File Offset: 0x0001E960
		[Token(Token = "0x6005043")]
		[Address(RVA = "0x217B170", Offset = "0x217B271", VA = "0x217B170")]
		public bool CheckBuildItemCondition(BuildItemData shopItem, int myShopLv, NPCID npcId)
		{
			return default(bool);
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005044")]
		[Address(RVA = "0x2178D00", Offset = "0x2178E01", VA = "0x2178D00")]
		public ShopParameterCalc()
		{
		}
	}
}
