using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace RF5SHOP
{
	// Token: 0x02000E67 RID: 3687
	[Token(Token = "0x2000970")]
	[Serializable]
	public struct ShopCatalogPage
	{
		// Token: 0x0400BFDD RID: 49117
		[Token(Token = "0x4008F96")]
		[FieldOffset(Offset = "0x0")]
		public List<ShopItem> shopItems;

		// Token: 0x0400BFDE RID: 49118
		[Token(Token = "0x4008F97")]
		[FieldOffset(Offset = "0x8")]
		public string name;
	}
}
