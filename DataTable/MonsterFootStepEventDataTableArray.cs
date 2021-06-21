using System;
using System.Collections.Generic;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace DataTable
{
	// Token: 0x020011BA RID: 4538
	[Token(Token = "0x2000B90")]
	[Serializable]
	public class MonsterFootStepEventDataTableArray : ScriptableObject, ISerializationCallbackReceiver
	{
		// Token: 0x060070F2 RID: 28914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x1DA5320", Offset = "0x1DA5421", VA = "0x1DA5320", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060070F3 RID: 28915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0x1DA54C0", Offset = "0x1DA55C1", VA = "0x1DA54C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060070F4 RID: 28916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0x1DA54D0", Offset = "0x1DA55D1", VA = "0x1DA54D0")]
		public MonsterFootStepEventDataTableArray()
		{
		}

		// Token: 0x040182E9 RID: 99049
		[Token(Token = "0x4014D57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public MonsterFootStepEventDataTable[] DataTables;

		// Token: 0x040182EA RID: 99050
		[Token(Token = "0x4014D58")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<MonsterFootStepEventDataID, MonsterFootStepEventDataTable> DataTableDic;
	}
}
