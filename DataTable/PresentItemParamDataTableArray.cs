using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x02001198 RID: 4504
	[Token(Token = "0x2000B6E")]
	[Serializable]
	public class PresentItemParamDataTableArray : DataTableArrayBase<ItemID, PresentItemParamDataTable, SerializedPresentItemParamDataTable>
	{
		// Token: 0x060070D0 RID: 28880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8F")]
		[Address(RVA = "0x1DA55F0", Offset = "0x1DA56F1", VA = "0x1DA55F0")]
		public PresentItemParamDataTableArray()
		{
		}

		// Token: 0x040182E5 RID: 99045
		[Token(Token = "0x4014D53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public PresentItemParamDataTable[] PresentMonsterCategoryTables;
	}
}
