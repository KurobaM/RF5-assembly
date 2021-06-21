using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace DataTable
{
	// Token: 0x02001180 RID: 4480
	[Token(Token = "0x2000B56")]
	[Serializable]
	public class ItemDataTableArray : DataTableArrayBase<ItemID, ItemDataTable, SerializedItemDataTable>
	{
		// Token: 0x060070B6 RID: 28854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D75")]
		[Address(RVA = "0x1DA4DF0", Offset = "0x1DA4EF1", VA = "0x1DA4DF0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D76")]
		[Address(RVA = "0x1DA4FB0", Offset = "0x1DA50B1", VA = "0x1DA4FB0")]
		public ItemDataTableArray()
		{
		}

		// Token: 0x040182E2 RID: 99042
		[Token(Token = "0x4014D50")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<ItemID>[] CategoryItems;
	}
}
