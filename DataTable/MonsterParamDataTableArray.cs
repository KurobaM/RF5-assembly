using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x0200118F RID: 4495
	[Token(Token = "0x2000B65")]
	[Serializable]
	public class MonsterParamDataTableArray : ScriptableObject
	{
		// Token: 0x060070C7 RID: 28871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D86")]
		[Address(RVA = "0x1DA54E0", Offset = "0x1DA55E1", VA = "0x1DA54E0")]
		public MonsterParamDataTableArray()
		{
		}

		// Token: 0x040182E3 RID: 99043
		[Token(Token = "0x4014D51")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MonsterParamDataTable[] DataTables;
	}
}
