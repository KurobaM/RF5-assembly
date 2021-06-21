using System;
using Field;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x0200104C RID: 4172
	[Token(Token = "0x2000A96")]
	[Serializable]
	public class FurnitureSaveData
	{
		// Token: 0x06006907 RID: 26887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005779")]
		[Address(RVA = "0x20804A0", Offset = "0x20805A1", VA = "0x20804A0")]
		public FurnitureSaveData(int type = 0)
		{
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577A")]
		[Address(RVA = "0x20795C0", Offset = "0x20796C1", VA = "0x20795C0")]
		public FurnitureSaveData(Vector3 pos, Quaternion rot, FieldSceneId scene_id, FurnitureID fid, string unique_id, FurnitureCreatePoint point, int hp, bool have = false)
		{
		}

		// Token: 0x04017133 RID: 94515
		[Token(Token = "0x4013D99")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public Vector3 Pos;

		// Token: 0x04017134 RID: 94516
		[Token(Token = "0x4013D9A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public Quaternion Rot;

		// Token: 0x04017135 RID: 94517
		[Token(Token = "0x4013D9B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public FieldSceneId SceneId;

		// Token: 0x04017136 RID: 94518
		[Token(Token = "0x4013D9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public FurnitureID Id;

		// Token: 0x04017137 RID: 94519
		[Token(Token = "0x4013D9D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public string UniqueId;

		// Token: 0x04017138 RID: 94520
		[Token(Token = "0x4013D9E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public FurnitureCreatePoint Point;

		// Token: 0x04017139 RID: 94521
		[Token(Token = "0x4013D9F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public int Hp;

		// Token: 0x0401713A RID: 94522
		[Token(Token = "0x4013DA0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public bool Have;
	}
}
