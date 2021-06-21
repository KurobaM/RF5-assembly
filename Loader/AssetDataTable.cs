using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Loader
{
	// Token: 0x02001017 RID: 4119
	[Token(Token = "0x2000A6E")]
	[Serializable]
	public class AssetDataTable : ScriptableObject
	{
		// Token: 0x060067D2 RID: 26578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566B")]
		[Address(RVA = "0x2310AE0", Offset = "0x2310BE1", VA = "0x2310AE0")]
		public void Setup()
		{
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600566C")]
		[Address(RVA = "0x2310C20", Offset = "0x2310D21", VA = "0x2310C20")]
		public AssetDataTable()
		{
		}

		// Token: 0x0400C73C RID: 51004
		[Token(Token = "0x40093D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public ASSET_TABLE[] AssetTables;

		// Token: 0x0400C73D RID: 51005
		[Token(Token = "0x40093D5")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, ASSET_TABLE> DataTables;
	}
}
