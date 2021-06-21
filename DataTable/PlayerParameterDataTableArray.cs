using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x02001194 RID: 4500
	[Token(Token = "0x2000B6A")]
	[Serializable]
	public class PlayerParameterDataTableArray : ScriptableObject
	{
		// Token: 0x060070CC RID: 28876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8B")]
		[Address(RVA = "0x1DA5590", Offset = "0x1DA5691", VA = "0x1DA5590")]
		public PlayerParameterDataTableArray()
		{
		}

		// Token: 0x040182E4 RID: 99044
		[Token(Token = "0x4014D52")]
		[FieldOffset(Offset = "0x18")]
		public PlayerParameterDataTable[] DataTables;
	}
}
