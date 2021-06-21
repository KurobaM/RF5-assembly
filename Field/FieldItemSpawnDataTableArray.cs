using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001127 RID: 4391
	[Token(Token = "0x2000B0A")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x14A160", Offset = "0x14A261")]
	[Serializable]
	public class FieldItemSpawnDataTableArray : ScriptableObject
	{
		// Token: 0x06006F02 RID: 28418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BFE")]
		[Address(RVA = "0x1F85DF0", Offset = "0x1F85EF1", VA = "0x1F85DF0")]
		public FieldItemSpawnDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x00026358 File Offset: 0x00024558
		[Token(Token = "0x6005BFF")]
		[Address(RVA = "0x1F85E00", Offset = "0x1F85F01", VA = "0x1F85E00")]
		public FieldItemSpawnDataTable GetDataTables(int index)
		{
			return default(FieldItemSpawnDataTable);
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x00026370 File Offset: 0x00024570
		[Token(Token = "0x6005C00")]
		[Address(RVA = "0x1F85E60", Offset = "0x1F85F61", VA = "0x1F85E60")]
		public FieldItemSpawnDataTable GetDataTables(FieldItemSpawnID id)
		{
			return default(FieldItemSpawnDataTable);
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C01")]
		[Address(RVA = "0x1F85EC0", Offset = "0x1F85FC1", VA = "0x1F85EC0")]
		public FieldItemSpawnDataTableArray()
		{
		}

		// Token: 0x040181FF RID: 98815
		[Token(Token = "0x4014C99")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FieldItemSpawnDataTable[] DataTables;
	}
}
