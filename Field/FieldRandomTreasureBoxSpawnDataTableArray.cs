using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001129 RID: 4393
	[Token(Token = "0x2000B0C")]
	public class FieldRandomTreasureBoxSpawnDataTableArray : ScriptableObject
	{
		// Token: 0x06006F11 RID: 28433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x1F866C0", Offset = "0x1F867C1", VA = "0x1F866C0")]
		public FieldRandomTreasureBoxSpawnDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x000263D0 File Offset: 0x000245D0
		[Token(Token = "0x6005C0E")]
		[Address(RVA = "0x1F866D0", Offset = "0x1F867D1", VA = "0x1F866D0")]
		public FieldRandomTreasureBoxSpawnDataTable GetDataTables(int index)
		{
			return default(FieldRandomTreasureBoxSpawnDataTable);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x000263E8 File Offset: 0x000245E8
		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x1F86720", Offset = "0x1F86821", VA = "0x1F86720")]
		public FieldRandomTreasureBoxSpawnDataTable GetDataTable(FieldRandomTreasureBoxSpawnID id)
		{
			return default(FieldRandomTreasureBoxSpawnDataTable);
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x1F86770", Offset = "0x1F86871", VA = "0x1F86770")]
		public FieldRandomTreasureBoxSpawnDataTableArray()
		{
		}

		// Token: 0x04018204 RID: 98820
		[Token(Token = "0x4014C9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FieldRandomTreasureBoxSpawnDataTable[] DataTables;
	}
}
