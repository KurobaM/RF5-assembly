using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x02001176 RID: 4470
	[Token(Token = "0x2000B4C")]
	[Serializable]
	public class HitOptionParamDataTableArray : ScriptableObject
	{
		// Token: 0x060070AC RID: 28844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0x1DA4CA0", Offset = "0x1DA4DA1", VA = "0x1DA4CA0")]
		public HitOptionParamDataTableArray()
		{
		}

		// Token: 0x040182E1 RID: 99041
		[Token(Token = "0x4014D4F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public HitOptionParamDataTable[] DataTables;
	}
}
