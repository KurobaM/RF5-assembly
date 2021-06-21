using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000576 RID: 1398
[Token(Token = "0x20003EE")]
public class TextureChangeMaterialParam
{
	// Token: 0x060021D9 RID: 8665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x205E110", Offset = "0x205E211", VA = "0x205E110")]
	public TextureChangeMaterialParam()
	{
	}

	// Token: 0x04006A52 RID: 27218
	[Token(Token = "0x4006402")]
	[FieldOffset(Offset = "0x10")]
	public int Id;

	// Token: 0x04006A53 RID: 27219
	[Token(Token = "0x4006403")]
	[FieldOffset(Offset = "0x14")]
	public int Count;

	// Token: 0x04006A54 RID: 27220
	[Token(Token = "0x4006404")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<int, int> ProprtyParams;

	// Token: 0x04006A55 RID: 27221
	[Token(Token = "0x4006405")]
	[FieldOffset(Offset = "0x20")]
	public Material ChangeMaterial;
}
