using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x02001175 RID: 4469
	[Token(Token = "0x2000B4B")]
	[Serializable]
	public class FriendParamDataTableArray : ScriptableObject
	{
		// Token: 0x060070AB RID: 28843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D6A")]
		[Address(RVA = "0x1DA4BF0", Offset = "0x1DA4CF1", VA = "0x1DA4BF0")]
		public FriendParamDataTableArray()
		{
		}

		// Token: 0x040182E0 RID: 99040
		[Token(Token = "0x4014D4E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FriendParamDataTable[] DataTables;
	}
}
