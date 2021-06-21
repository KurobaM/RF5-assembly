using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000967 RID: 2407
[Token(Token = "0x200064F")]
public class MapDatas : ScriptableObject
{
	// Token: 0x06003F8C RID: 16268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E1")]
	[Address(RVA = "0x1F226D0", Offset = "0x1F227D1", VA = "0x1F226D0")]
	public MapDatas()
	{
	}

	// Token: 0x0400820C RID: 33292
	[Token(Token = "0x4007509")]
	[FieldOffset(Offset = "0x18")]
	public MapDatas.MapData[] datas;

	// Token: 0x02000968 RID: 2408
	[Token(Token = "0x200129A")]
	[Serializable]
	public struct MapData
	{
		// Token: 0x0400820D RID: 33293
		[Token(Token = "0x4019966")]
		[FieldOffset(Offset = "0x0")]
		public string SystemTextId;

		// Token: 0x0400820E RID: 33294
		[Token(Token = "0x4019967")]
		[FieldOffset(Offset = "0x8")]
		public string SceneName;

		// Token: 0x0400820F RID: 33295
		[Token(Token = "0x4019968")]
		[FieldOffset(Offset = "0x10")]
		public string MapFileName;
	}
}
