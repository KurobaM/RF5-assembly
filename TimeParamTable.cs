using System;
using System.Collections.Generic;
using Funly.SkyStudio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000555 RID: 1365
[Token(Token = "0x20003DF")]
[Attribute(Name = "CreateAssetMenuAttribute", RVA = "0x145FA0", Offset = "0x1460A1")]
[Serializable]
public class TimeParamTable : ScriptableObject
{
	// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x206ADD0", Offset = "0x206AED1", VA = "0x206ADD0")]
	public void SetPropertyToID()
	{
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x206B1C0", Offset = "0x206B2C1", VA = "0x206B1C0")]
	public TimeParamTable()
	{
	}

	// Token: 0x040067D9 RID: 26585
	[Token(Token = "0x40061C1")]
	[FieldOffset(Offset = "0x18")]
	public List<NumberKeyframeGroup> NumberList;

	// Token: 0x040067DA RID: 26586
	[Token(Token = "0x40061C2")]
	[FieldOffset(Offset = "0x20")]
	public List<ColorKeyframeGroup> ColorList;

	// Token: 0x040067DB RID: 26587
	[Token(Token = "0x40061C3")]
	[FieldOffset(Offset = "0x28")]
	public List<TextureKeyframeGroup> TextureList;

	// Token: 0x040067DC RID: 26588
	[Token(Token = "0x40061C4")]
	[FieldOffset(Offset = "0x30")]
	public List<BoolKeyframeGroup> BoolList;
}
