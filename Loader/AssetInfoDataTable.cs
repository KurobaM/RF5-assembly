using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Loader
{
	// Token: 0x0200101A RID: 4122
	[Token(Token = "0x2000A71")]
	[Serializable]
	public class AssetInfoDataTable : ScriptableObject
	{
		// Token: 0x060067D8 RID: 26584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005671")]
		[Address(RVA = "0x2311D70", Offset = "0x2311E71", VA = "0x2311D70")]
		public void Setup()
		{
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005672")]
		[Address(RVA = "0x2312120", Offset = "0x2312221", VA = "0x2312120")]
		public AssetInfoDataTable()
		{
		}

		// Token: 0x0400C757 RID: 51031
		[Token(Token = "0x40093EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<AssetInfo> AssetInfos;

		// Token: 0x0400C758 RID: 51032
		[Token(Token = "0x40093F0")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, AssetInfo> DataTables;
	}
}
