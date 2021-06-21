using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000574 RID: 1396
[Token(Token = "0x20003EC")]
[Serializable]
public class ChangeTexture
{
	// Token: 0x060021D5 RID: 8661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x1E82B00", Offset = "0x1E82C01", VA = "0x1E82B00")]
	public ChangeTexture()
	{
	}

	// Token: 0x04006A47 RID: 27207
	[Token(Token = "0x40063F7")]
	[FieldOffset(Offset = "0x10")]
	public Renderer renderer;

	// Token: 0x04006A48 RID: 27208
	[Token(Token = "0x40063F8")]
	[FieldOffset(Offset = "0x18")]
	public Material material;

	// Token: 0x04006A49 RID: 27209
	[Token(Token = "0x40063F9")]
	[FieldOffset(Offset = "0x20")]
	public string textureName;

	// Token: 0x04006A4A RID: 27210
	[Token(Token = "0x40063FA")]
	[FieldOffset(Offset = "0x28")]
	public string propertyName;

	// Token: 0x04006A4B RID: 27211
	[Token(Token = "0x40063FB")]
	[FieldOffset(Offset = "0x30")]
	public int propertyId;
}
