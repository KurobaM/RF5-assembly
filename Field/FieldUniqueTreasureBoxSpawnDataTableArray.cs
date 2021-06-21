using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200114C RID: 4428
	[Token(Token = "0x2000B24")]
	public class FieldUniqueTreasureBoxSpawnDataTableArray : ScriptableObject
	{
		// Token: 0x06007048 RID: 28744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0x1F92110", Offset = "0x1F92211", VA = "0x1F92110")]
		public FieldUniqueTreasureBoxSpawnDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x00026C58 File Offset: 0x00024E58
		[Token(Token = "0x6005D10")]
		[Address(RVA = "0x1F92120", Offset = "0x1F92221", VA = "0x1F92120")]
		public FieldUniqueTreasureBoxSpawnDataTable GetDataTables(int index)
		{
			return default(FieldUniqueTreasureBoxSpawnDataTable);
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x00026C70 File Offset: 0x00024E70
		[Token(Token = "0x6005D11")]
		[Address(RVA = "0x1F92180", Offset = "0x1F92281", VA = "0x1F92180")]
		public FieldUniqueTreasureBoxSpawnDataTable GetDataTable(FieldUniqueTreasureBoxSpawnID id)
		{
			return default(FieldUniqueTreasureBoxSpawnDataTable);
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D12")]
		[Address(RVA = "0x1F921E0", Offset = "0x1F922E1", VA = "0x1F921E0")]
		public FieldUniqueTreasureBoxSpawnDataTableArray()
		{
		}

		// Token: 0x040182BE RID: 99006
		[Token(Token = "0x4014D32")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FieldUniqueTreasureBoxSpawnDataTable[] DataTables;
	}
}
