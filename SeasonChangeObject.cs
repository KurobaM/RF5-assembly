using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000575 RID: 1397
[Token(Token = "0x20003ED")]
[Serializable]
public class SeasonChangeObject : MonoBehaviour
{
	// Token: 0x060021D6 RID: 8662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x21E5080", Offset = "0x21E5181", VA = "0x21E5080")]
	private void Start()
	{
	}

	// Token: 0x060021D7 RID: 8663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x21E53D0", Offset = "0x21E54D1", VA = "0x21E53D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x21E56A0", Offset = "0x21E57A1", VA = "0x21E56A0")]
	public SeasonChangeObject()
	{
	}

	// Token: 0x04006A4C RID: 27212
	[Token(Token = "0x40063FC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ChangeMaterial[] ChangeMaterials;

	// Token: 0x04006A4D RID: 27213
	[Token(Token = "0x40063FD")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public ChangeTexture[] ChangeTextures;

	// Token: 0x04006A4E RID: 27214
	[Token(Token = "0x40063FE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Terrain[] Terrains;

	// Token: 0x04006A4F RID: 27215
	[Token(Token = "0x40063FF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GameObject[][] SeasonGameObjects;

	// Token: 0x04006A50 RID: 27216
	[Token(Token = "0x4006400")]
	[FieldOffset(Offset = "0x38")]
	public TextureChangeMaterialParam TextureChangeMaterialParam;

	// Token: 0x04006A51 RID: 27217
	[Token(Token = "0x4006401")]
	private const string TextureDefaultProparty = "_MainTex";
}
