using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200096A RID: 2410
[Token(Token = "0x2000651")]
public class MapObjectDatas : ScriptableObject
{
	// Token: 0x06003F8D RID: 16269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60034E2")]
	[Address(RVA = "0x1F234B0", Offset = "0x1F235B1", VA = "0x1F234B0")]
	public MapObjectDatas()
	{
	}

	// Token: 0x04008270 RID: 33392
	[Token(Token = "0x400756A")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public MapObjectDatas.MapObjectData[] datas;

	// Token: 0x0200096B RID: 2411
	[Token(Token = "0x200129B")]
	[Serializable]
	public struct MapObjectData
	{
		// Token: 0x04008271 RID: 33393
		[Token(Token = "0x4019969")]
		[FieldOffset(Offset = "0x0")]
		public string PlaceNameId;

		// Token: 0x04008272 RID: 33394
		[Token(Token = "0x401996A")]
		[FieldOffset(Offset = "0x8")]
		public string MiniIconName;

		// Token: 0x04008273 RID: 33395
		[Token(Token = "0x401996B")]
		[FieldOffset(Offset = "0x10")]
		public string TypeNameId;

		// Token: 0x04008274 RID: 33396
		[Token(Token = "0x401996C")]
		[FieldOffset(Offset = "0x18")]
		public string ExplainNameTextId;

		// Token: 0x04008275 RID: 33397
		[Token(Token = "0x401996D")]
		[FieldOffset(Offset = "0x20")]
		public Place PlaceId;
	}
}
