using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x0200116E RID: 4462
	[Token(Token = "0x2000B44")]
	[Serializable]
	public class EquipSubAttributeDataTableArray : ScriptableObject
	{
		// Token: 0x060070A3 RID: 28835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D62")]
		[Address(RVA = "0x1DA4AA0", Offset = "0x1DA4BA1", VA = "0x1DA4AA0")]
		public EquipSubAttributeDataTableArray()
		{
		}

		// Token: 0x040182DF RID: 99039
		[Token(Token = "0x4014D4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public EquipSubAttributeDataTable[] DataTables;
	}
}
