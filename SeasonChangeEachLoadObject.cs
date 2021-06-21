using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000572 RID: 1394
[Token(Token = "0x20003EA")]
[Serializable]
public class SeasonChangeEachLoadObject : MonoBehaviour
{
	// Token: 0x060021D0 RID: 8656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x21E4BF0", Offset = "0x21E4CF1", VA = "0x21E4BF0")]
	private void Awake()
	{
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x21E4E20", Offset = "0x21E4F21", VA = "0x21E4E20")]
	private void Start()
	{
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x21E4F10", Offset = "0x21E5011", VA = "0x21E4F10")]
	private void OnDestroy()
	{
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x21E5070", Offset = "0x21E5171", VA = "0x21E5070")]
	public SeasonChangeEachLoadObject()
	{
	}

	// Token: 0x04006A3E RID: 27198
	[Token(Token = "0x40063EE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public ChangeMaterial[] ChangeMaterials;

	// Token: 0x04006A3F RID: 27199
	[Token(Token = "0x40063EF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public ChangeTexture[] ChangeTextures;

	// Token: 0x04006A40 RID: 27200
	[Token(Token = "0x40063F0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Terrain[] Terrains;

	// Token: 0x04006A41 RID: 27201
	[Token(Token = "0x40063F1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public Renderer[] Renderers;

	// Token: 0x04006A42 RID: 27202
	[Token(Token = "0x40063F2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Material[] Materials;

	// Token: 0x04006A43 RID: 27203
	[Token(Token = "0x40063F3")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public Texture[] Textures;
}
