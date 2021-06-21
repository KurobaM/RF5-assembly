using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200114E RID: 4430
	[Token(Token = "0x2000B26")]
	public class FieldWoodBoxSpawnDataTableArray : ScriptableObject
	{
		// Token: 0x06007057 RID: 28759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D1E")]
		[Address(RVA = "0x1F928D0", Offset = "0x1F929D1", VA = "0x1F928D0")]
		public FieldWoodBoxSpawnDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x00026CA0 File Offset: 0x00024EA0
		[Token(Token = "0x6005D1F")]
		[Address(RVA = "0x1F928E0", Offset = "0x1F929E1", VA = "0x1F928E0")]
		public FieldWoodBoxSpawnDataTable GetDataTables(int index)
		{
			return default(FieldWoodBoxSpawnDataTable);
		}

		// Token: 0x06007059 RID: 28761 RVA: 0x00026CB8 File Offset: 0x00024EB8
		[Token(Token = "0x6005D20")]
		[Address(RVA = "0x1F92930", Offset = "0x1F92A31", VA = "0x1F92930")]
		public FieldWoodBoxSpawnDataTable GetDataTable(FieldWoodBoxSpawnID id)
		{
			return default(FieldWoodBoxSpawnDataTable);
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D21")]
		[Address(RVA = "0x1F92980", Offset = "0x1F92A81", VA = "0x1F92980")]
		public FieldWoodBoxSpawnDataTableArray()
		{
		}

		// Token: 0x040182C3 RID: 99011
		[Token(Token = "0x4014D37")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FieldWoodBoxSpawnDataTable[] DataTables;
	}
}
