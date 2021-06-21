using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000573 RID: 1395
[Token(Token = "0x20003EB")]
[Serializable]
public class ChangeMaterial
{
	// Token: 0x060021D4 RID: 8660 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x1E82A50", Offset = "0x1E82B51", VA = "0x1E82A50")]
	public ChangeMaterial()
	{
	}

	// Token: 0x04006A44 RID: 27204
	[Token(Token = "0x40063F4")]
	[FieldOffset(Offset = "0x10")]
	public Renderer renderer;

	// Token: 0x04006A45 RID: 27205
	[Token(Token = "0x40063F5")]
	[FieldOffset(Offset = "0x18")]
	public int materialIndex;

	// Token: 0x04006A46 RID: 27206
	[Token(Token = "0x40063F6")]
	[FieldOffset(Offset = "0x20")]
	public string materialName;
}
