using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200111E RID: 4382
	[Token(Token = "0x2000B06")]
	[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x14A110", Offset = "0x14A211")]
	[Serializable]
	public class FieldHideItemSpawnDataTableArray : ScriptableObject
	{
		// Token: 0x06006EB6 RID: 28342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BC4")]
		[Address(RVA = "0x1F824D0", Offset = "0x1F825D1", VA = "0x1F824D0")]
		public FieldHideItemSpawnDataTable[] GetDataTables()
		{
			return null;
		}

		// Token: 0x06006EB7 RID: 28343 RVA: 0x00026070 File Offset: 0x00024270
		[Token(Token = "0x6005BC5")]
		[Address(RVA = "0x1F824E0", Offset = "0x1F825E1", VA = "0x1F824E0")]
		public FieldHideItemSpawnDataTable GetDataTables(int index)
		{
			return default(FieldHideItemSpawnDataTable);
		}

		// Token: 0x06006EB8 RID: 28344 RVA: 0x00026088 File Offset: 0x00024288
		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x1F82520", Offset = "0x1F82621", VA = "0x1F82520")]
		public FieldHideItemSpawnDataTable GetDataTables(FieldHideItemSpawnID id)
		{
			return default(FieldHideItemSpawnDataTable);
		}

		// Token: 0x06006EB9 RID: 28345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x1F82560", Offset = "0x1F82661", VA = "0x1F82560")]
		public FieldHideItemSpawnDataTableArray()
		{
		}

		// Token: 0x040181D9 RID: 98777
		[Token(Token = "0x4014C7C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public FieldHideItemSpawnDataTable[] DataTables;
	}
}
