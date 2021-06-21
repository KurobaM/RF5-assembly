using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace RF5SHOP
{
	// Token: 0x02000E69 RID: 3689
	[Token(Token = "0x2000972")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x149650", Offset = "0x149751")]
	[Serializable]
	public class NpcShopTable : ScriptableObject
	{
		// Token: 0x060060EA RID: 24810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600503E")]
		[Address(RVA = "0x21789F0", Offset = "0x2178AF1", VA = "0x21789F0")]
		public NpcShopTable()
		{
		}

		// Token: 0x0400BFE9 RID: 49129
		[Token(Token = "0x4008FA2")]
		[FieldOffset(Offset = "0x18")]
		public List<ShopCatalogPage> ShopCatalogPages;

		// Token: 0x0400BFEA RID: 49130
		[Token(Token = "0x4008FA3")]
		[FieldOffset(Offset = "0x20")]
		public List<ShopNpcTalk> ShopNpcTalks;
	}
}
